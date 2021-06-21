Imports System.Data.SqlClient

Public Class equipamento
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaEquipamento As New List(Of Equi)()
    Dim StartingList As New List(Of Equi)()
    Dim listaMilitares As New List(Of Militar)()
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
    Private Sub equipamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        PopulateBoxes(CN)

        CMD = New SqlCommand
        CMD.Connection = CN
        ListBox1.Enabled = True
        If escolha_equi.arma Then
            missao.Visible = False
            TBmissao.Visible = False
            CMD.CommandText = "SELECT * FROM EXERCITO.equipamento JOIN EXERCITO.arma ON  id = idEqui JOIN EXERCITO.tipo_arma ON tipo_arma.id = arma.idTipo "
        Else
            Label5.Text = "Matrícula"
            CMD.CommandText = "SELECT * 
                                FROM EXERCITO.equipamento 

                                JOIN EXERCITO.veiculo 
                                ON  id = idEqui 

                                JOIN EXERCITO.tipo_veiculo 
                                ON tipo_veiculo.id = veiculo.idTipo 

                                LEFT JOIN EXERCITO.missao 
                                ON missao.id = veiculo.idMissao 

                                LEFT JOIN EXERCITO.utiliza_equipamento 
                                ON utiliza_equipamento.equipamento = equipamento.id

                                LEFT JOIN EXERCITO.militar
                                ON utiliza_equipamento.soldado = militar.nCC"


        End If
        CN.Open()

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBox1.Items.Clear()
        While RDR.Read
            Dim equipamento As New Equi
            If escolha_equi.arma Then
                equipamento.nSerie_matricula = Convert.ToString(RDR.Item("nSerie"))
            Else
                equipamento.nSerie_matricula = Convert.ToString(RDR.Item("matricula"))
                If IsDBNull(RDR.Item("nome")) Then
                    equipamento.missao = "null"
                Else
                    equipamento.missao = Convert.ToString(RDR.Item("nome"))
                End If
            End If
            equipamento.id = RDR.Item("id")
            equipamento.tipo = RDR.Item("tipo")
            equipamento.modelo = RDR.Item("modelo")

            listaEquipamento.Add(equipamento)
            ListBox1.Items.Add(equipamento)
        End While
        StartingList.AddRange(listaEquipamento.ToArray)

        CN.Close()
    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim escolha = New escolha_equi
        escolha.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index = ListBox1.SelectedIndex
        Debug.Print(index)
        Dim Equi As Equi = listaEquipamento(index)
        TBmodelo.Text = Equi.modelo
        TBserie.Text = Equi.nSerie_matricula
        TBtipo.Text = Equi.tipo
        If Not escolha_equi.arma Then
            TBmissao.Text = Equi.missao
        End If

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                       "initial Catalog = " + dbName + ";" +
                       "uid = " + userName + ";" +
                       "password = " + userPass)
        Dim cmd As New SqlCommand
        cmd.CommandText = String.Format("SELECT militar.nCC, militar.Pnome, militar.Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo, EXERCITO.militarEmMissao(militar.nCC) AS EmMissao, EXERCITO.subclass(militar.nCC) AS tipo, estado_militar.estado
                           FROM EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON militar.cargo = cargo.id
                           JOIN EXERCITO.estado_militar
                           ON militar.estado = estado_militar.id
                           JOIN EXERCITO.militaresUsarEquip({0}) AS equiU
						   ON militar.nCC = equiU.nCC", Equi.id)
        cmd.Connection = CN
        CN.Open()

        Dim RDR As SqlDataReader
        RDR = cmd.ExecuteReader

        listaMilitares.Clear()
        ListBox2.Items.Clear()
        While RDR.Read
            Dim M As New Militar
            M.nCC = Convert.ToString(RDR.Item("nCC"))
            M.Pnome = RDR.Item("Pnome")
            M.Unome = RDR.Item("Unome")
            M.morada = RDR.Item("morada")
            M.email = RDR.Item("email")
            M.dNasc = Convert.ToString(RDR.Item("dNasc"))
            M.dInsc = Convert.ToString(RDR.Item("dInsc"))
            M.tel = RDR.Item("tel")
            M.nacionalidade = RDR.Item("nacionalidade")
            M.nMissoes = Convert.ToString(RDR.Item("nMissoes"))
            M.ramo = Convert.ToString(RDR.Item("ramo"))
            If IsDBNull(RDR.Item("base")) Then
                M.base = Nothing
            Else
                M.base = Convert.ToString(RDR.Item("base"))
            End If
            M.cargo = RDR.Item("cargo")
            M.tipo = RDR.Item("tipo")
            M.estado = RDR.Item("estado")
            M.missao = RDR.Item("EmMissao")
            listaMilitares.Add(M)
            ListBox2.Items.Add(M)
        End While

        CN.Close()


    End Sub

    Private Sub ApplyFilters_Click(sender As Object, e As EventArgs) Handles ApplyFilters.Click
        Dim tp = TipoDD.SelectedValue
        Dim isUsed = uso.SelectedValue
        Dim cmd As String
        Dim conds As New List(Of String)()


        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        If escolha_equi.arma Then
            cmd = "SELECT * FROM EXERCITO.equipamento JOIN EXERCITO.arma ON  id = idEqui JOIN EXERCITO.tipo_arma ON tipo_arma.id = arma.idTipo "
        Else
            cmd = "SELECT * FROM EXERCITO.equipamento JOIN EXERCITO.veiculo ON  id = idEqui JOIN EXERCITO.tipo_veiculo ON tipo_veiculo.id = veiculo.idTipo "
        End If

        If tp > -1 Then
            If escolha_equi.arma Then
                conds.Add(String.Format("arma.idTipo = {0}", tp))
            Else
                conds.Add(String.Format("veiculo.idTipo = {0}", tp))
            End If
        End If

        If isUsed > -1 Then
            Debug.Print(isUsed)
            conds.Add(String.Format("EXERCITO.equipIsAvailable(idEqui) = {0}", isUsed))
        End If

        If conds.Count > 0 Then
            cmd = cmd + " WHERE "
            For idx As Integer = 0 To conds.Count - 1
                cmd = cmd + conds(idx)
                If Not (idx = conds.Count - 1) Then
                    cmd = cmd + " AND "
                End If
            Next
        End If



        Dim count As Integer = 0
        Dim RDR As SqlDataReader
        Dim i As Integer
        Dim SQLcmd As SqlCommand

        SQLcmd = New SqlCommand
        SQLcmd.Connection = CN
        SQLcmd.CommandText = cmd
        CN.Open()
        ListBox1.Items.Clear()


        listaEquipamento.AddRange(ListBox1.Items.OfType(Of Equi).ToArray)

        ListBox1.Enabled = True


        RDR = SQLcmd.ExecuteReader

        While (RDR.Read)
            i = BinSrch(listaEquipamento, 0, listaEquipamento.Count - 1, RDR.Item("id"))
            If i > -1 Then
                ListBox1.Items.Add(listaEquipamento(i))
                count = count + 1
            End If
        End While

        listaEquipamento.Clear()
        For it As Integer = 0 To ListBox1.Items.Count - 1
            listaEquipamento.Add(ListBox1.Items(it))
        Next

        If count = 0 Then
            ListBox1.Items.Add("Não foram encontrados dados :(")
            ListBox1.Enabled = False
        End If

        CN.Close()

    End Sub

    Function BinSrch(arr As List(Of Equi), l As Integer, r As Integer, id As Integer)

        If (r >= l) Then
            Dim mid As Integer = l + (r - l) / 2

            If (arr(mid).id = id) Then
                Return mid
            End If

            If arr(mid).id > id Then
                Return BinSrch(arr, l, mid - 1, id)
            End If

            Return BinSrch(arr, mid + 1, r, id)
        End If

        Return -1
    End Function

    Function PopulateBoxes(CN As SqlConnection)
        Dim SQA As SqlDataAdapter
        Dim cmd As String
        'tipo

        If escolha_equi.arma Then
            cmd = "SELECT id, tipo FROM EXERCITO.tipo_arma"

        Else
            cmd = "SELECT id, tipo FROM EXERCITO.tipo_veiculo"
        End If

        SQA = New SqlDataAdapter(cmd, CN)
        Dim dt As DataTable = New DataTable()
        SQA.Fill(dt)

        Dim row As DataRow = dt.NewRow()
        row(0) = -1
        row(1) = "Tipo"
        dt.Rows.InsertAt(row, 0)

        TipoDD.DataSource = dt
        TipoDD.DisplayMember = "tipo"
        TipoDD.ValueMember = "id"

        'em uso
        Dim useDict As New Dictionary(Of String, String)()
        useDict.Add(-1, "Todas")
        useDict.Add(0, "Em uso")
        useDict.Add(1, "Disponível")

        uso.DataSource = New BindingSource(useDict, Nothing)
        uso.DisplayMember = "Value"
        uso.ValueMember = "Key"


        CN.Close()

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listaEquipamento.Clear()
        listaEquipamento.AddRange(StartingList.ToArray)
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(listaEquipamento.ToArray)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim index = ListBox2.SelectedIndex
        GlobalVariables.milSelected = listaMilitares(index)
        Dim info = New info_militar
        info.Show()
        Me.Close()
    End Sub
End Class