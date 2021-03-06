Imports System.Data.SqlClient

Public Class militares
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim StartingList As New List(Of Militar)()
    Friend Shared militarSelected As Militar
    Friend Shared EmMissao As Boolean
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"

    Private Sub militares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.porto()
        If GlobalVariables.add2pelotao Then
            Add2Pelotao.Visible = True
            register.Visible = False

        End If

        Dim RDR As SqlDataReader

        Dim SQA As SqlDataAdapter

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)


        PopulateBoxes(CN)
        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM EXERCITO.militar_info"
        CN.Open()

        Dim count As Integer = 0
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        Dim index = 0
        While RDR.Read
            Dim M = GlobalVariables.listaMilitares(index)
            ListBox1.Items.Add(M)
            count = count + 1
            If index = GlobalVariables.listaMilitares.Count Then
                Exit While
            End If
            index = index + 1
        End While
        StartingList.AddRange(GlobalVariables.listaMilitares.ToArray)
        totalTxtBox.Text = count
        CN.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index = ListBox1.SelectedIndex
        GlobalVariables.milSelected = GlobalVariables.listaMilitares(index)
        militarSelected = GlobalVariables.listaMilitares(index)
    End Sub

    Private Sub ListBox1_PYlance(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        If Not GlobalVariables.add2pelotao Then
            Dim info = New info_militar
            info.Show()
            Me.Close()
        End If
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim pag_init = New Form1
        pag_init.Show()
        Me.Close()
    End Sub

    Private Sub pesquisaBttn_Click(sender As Object, e As EventArgs) Handles pesquisaBttn.Click
        Dim num_search = False
        Dim text = TBpesquisa.Text
        If IsNumeric(text) Then
            num_search = True
            text = Convert.ToInt32(text)
        End If

        Dim count As Integer = 0
        Dim RDR As SqlDataReader
        Dim idx As Integer
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        CMD = New SqlCommand
        CMD.Connection = CN

        If num_search Then
            CMD.CommandText = String.Format("SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, Ramo, Base, EXERCITO.cargo.cargo
                           From EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON militar.cargo = cargo.id
                           WHERE nCC = {0}", text)

        Else
            CMD.CommandText = String.Format("SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo
                                   FROM EXERCITO.militar 
                                   JOIN EXERCITO.cargo 
                                   ON militar.cargo = cargo.id
                                   WHERE Concat (Pnome, ' ', Unome) LIKE '%{0}%'", text)
        End If
        CN.Open()
        Dim RowsReturned = CMD.ExecuteScalar()
        ListBox1.Items.Clear()

        If RowsReturned = 0 Then
            ListBox1.Items.Add("Não foram encontrados dados :(")
            ListBox1.Enabled = False
            totalTxtBox.Text = 0

        Else
            GlobalVariables.listaMilitares.AddRange(StartingList.ToArray)
            ListBox1.Enabled = True


            RDR = CMD.ExecuteReader

            While (RDR.Read)
                idx = BinSrch(GlobalVariables.listaMilitares, 0, GlobalVariables.listaMilitares.Count - 1, RDR.Item("nCC"))
                If idx > -1 Then
                    ListBox1.Items.Add(GlobalVariables.listaMilitares(idx))
                    count = count + 1
                End If
            End While

            GlobalVariables.listaMilitares.Clear()
            For i As Integer = 0 To ListBox1.Items.Count - 1
                GlobalVariables.listaMilitares.Add(ListBox1.Items(i))
            Next
            totalTxtBox.Text = count
        End If

        CN.Close()

    End Sub


    Private Sub ApplyFilters_Click(sender As Object, e As EventArgs) Handles ApplyFilters.Click
        Dim base = BaseDD.SelectedValue
        Dim cargo = CargoDD.SelectedValue
        Dim ramo = RamoDD.SelectedValue
        Dim nacVal = NacDD.SelectedValue
        Dim nac = NacDD.Text
        Dim missoesVal = MissoesDD.SelectedValue
        Dim missoes = MissoesDD.Text
        Dim dispon = DispDD.SelectedValue
        Dim subcl = subclasse.SelectedValue
        Dim state = stateDD.SelectedValue
        Dim conds As New List(Of String)()


        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        Dim cmd = "SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, cargo
                           FROM EXERCITO.militar"

        If subcl IsNot "" Then
            conds.Add(String.Format("EXERCITO.subclass(nCC) = '{0}'", subcl))
        End If

        If base > -1 Then
            conds.Add(String.Format("base = {0}", base))
        End If

        If cargo > -1 Then
            conds.Add(String.Format("cargo = {0}", cargo))
        End If

        If ramo > -1 Then
            conds.Add(String.Format("ramo = {0}", ramo))
        End If

        If nacVal > -1 Then
            conds.Add(String.Format("nacionalidade = '{0}'", nac))
        End If

        If state > -1 Then
            conds.Add(String.Format("estado = {0}", state))
        End If

        If missoesVal > -1 Then
            If missoesVal = 5 Then
                conds.Add(String.Format("nMissoes > 50"))
            Else
                Dim min = missoes.Split("-")(0)
                Dim max = missoes.Split("-")(1)
                conds.Add(String.Format("nMissoes > {0} AND nMissoes < {1}", min, max))
            End If
        End If

        If Not (dispon = -1) Then
            If dispon = 1 Then
                conds.Add(String.Format("EXERCITO.militarEmMissao(nCC) > 0"))
            Else
                conds.Add(String.Format("EXERCITO.militarEmMissao(nCC) = -1"))
            End If
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


        GlobalVariables.listaMilitares.AddRange(ListBox1.Items.OfType(Of Militar).ToArray)

        ListBox1.Enabled = True


        RDR = SQLcmd.ExecuteReader

        While (RDR.Read)
            i = BinSrch(GlobalVariables.listaMilitares, 0, GlobalVariables.listaMilitares.Count - 1, RDR.Item("nCC"))
            If i > -1 Then
                ListBox1.Items.Add(GlobalVariables.listaMilitares(i))
                count = count + 1
            End If
        End While

        GlobalVariables.listaMilitares.Clear()
        For it As Integer = 0 To ListBox1.Items.Count - 1
            GlobalVariables.listaMilitares.Add(ListBox1.Items(it))
        Next
        totalTxtBox.Text = count

        If count = 0 Then
            ListBox1.Items.Add("Não foram encontrados dados :(")
            ListBox1.Enabled = False
            totalTxtBox.Text = 0
        End If

        CN.Close()

    End Sub


    Function BinSrch(arr As List(Of Militar), l As Integer, r As Integer, nCC As Integer)

        If (r >= l) Then
            Dim mid As Integer = l + (r - l) / 2

            If (arr(mid).nCC = nCC) Then
                Return mid
            End If

            If arr(mid).nCC > nCC Then
                Return BinSrch(arr, l, mid - 1, nCC)
            End If

            Return BinSrch(arr, mid + 1, r, nCC)
        End If

        Return -1
    End Function

    Function PopulateBoxes(CN As SqlConnection)
        Dim SQA As SqlDataAdapter

        'bases
        SQA = New SqlDataAdapter("SELECT id, nome FROM EXERCITO.base_militar", CN)
        Dim dt As DataTable = New DataTable()
        SQA.Fill(dt)

        Dim row As DataRow = dt.NewRow()
        row(0) = -1
        row(1) = "Base"
        dt.Rows.InsertAt(row, 0)

        BaseDD.DataSource = dt
        BaseDD.DisplayMember = "nome"
        BaseDD.ValueMember = "id"

        'ramos
        SQA = New SqlDataAdapter("SELECT ramo.id,design FROM EXERCITO.ramo
                                  JOIN EXERCITO.tipo_ramo
                                  ON ramo.id = tipo_ramo.id", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        row = dt.NewRow()
        row(0) = -1
        row(1) = "Ramo"
        dt.Rows.InsertAt(row, 0)

        RamoDD.DataSource = dt
        RamoDD.DisplayMember = "design"
        RamoDD.ValueMember = "id"

        'cargos
        SQA = New SqlDataAdapter("SELECT id, cargo FROM EXERCITO.cargo", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        row = dt.NewRow()
        row(0) = -1
        row(1) = "Cargo"
        dt.Rows.InsertAt(row, 0)

        CargoDD.DataSource = dt
        CargoDD.DisplayMember = "cargo"
        CargoDD.ValueMember = "id"

        SQA = New SqlDataAdapter("SELECT id, nacionalidade FROM EXERCITO.getNacionalidades()", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        row = dt.NewRow()
        row(0) = -1
        row(1) = "Nacionalidade"
        dt.Rows.InsertAt(row, 0)

        NacDD.DataSource = dt
        NacDD.DisplayMember = "nacionalidade"
        NacDD.ValueMember = "id"

        SQA = New SqlDataAdapter("SELECT id, estado FROM EXERCITO.estado_militar", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        row = dt.NewRow()
        row(0) = -1
        row(1) = "Estado"
        dt.Rows.InsertAt(row, 0)

        stateDD.DataSource = dt
        stateDD.DisplayMember = "estado"
        stateDD.ValueMember = "id"


        Dim missDict As New Dictionary(Of Integer, String)()
        missDict.Add(-1, "Missoes")
        missDict.Add(1, "0-10")
        missDict.Add(2, "11-20")
        missDict.Add(3, "21-30")
        missDict.Add(4, "30-50")
        missDict.Add(5, "50+")

        MissoesDD.DataSource = New BindingSource(missDict, Nothing)
        MissoesDD.DisplayMember = "Value"
        MissoesDD.ValueMember = "Key"

        Dim dispDict As New Dictionary(Of Integer, String)()
        dispDict.Add(-1, "Disponibilidade")
        dispDict.Add(1, "Em Missão")
        dispDict.Add(2, "Disponível")

        DispDD.DataSource = New BindingSource(dispDict, Nothing)
        DispDD.DisplayMember = "Value"
        DispDD.ValueMember = "Key"

        Dim scDict As New Dictionary(Of String, String)()
        scDict.Add("", "Tipo Militar")
        scDict.Add("SOLDADO", "Soldado")
        scDict.Add("MEDICO", "Medico")
        scDict.Add("ENGENHEIRO", "Engenheiro")

        subclasse.DataSource = New BindingSource(scDict, Nothing)
        subclasse.DisplayMember = "Value"
        subclasse.ValueMember = "Key"


        CN.Close()

    End Function

    Private Sub MissoesDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MissoesDD.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles resetBttn.Click
        GlobalVariables.listaMilitares.Clear()
        GlobalVariables.listaMilitares.AddRange(StartingList.ToArray)
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(GlobalVariables.listaMilitares.ToArray)
    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        GlobalVariables.inserting = True
        Dim pag_init = New info_militar
        pag_init.Show()
        Me.Close()
    End Sub

    Private Sub Add2Pelotao_Click(sender As Object, e As EventArgs) Handles Add2Pelotao.Click
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand("EXERCITO.addToPelotao")
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@nCC", militarSelected.nCC))
        CMD.Parameters.Add(New SqlParameter("@pel", GlobalVariables.pelotao_id))
        Try
            CMD.ExecuteNonQuery()
            MsgBox("Militar adicionado com sucesso!")
            Exit Try
        Catch ex As SqlException
            MsgBox("Impossível adicionar militar com esse cargo")

        End Try
        GlobalVariables.porto()
        Dim pelotao = New pelotao
        pelotao.Show()
        Me.Close()

    End Sub
End Class