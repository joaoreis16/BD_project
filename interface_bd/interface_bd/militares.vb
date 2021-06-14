Imports System.Data.SqlClient

Public Class militares
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaMilitares As New List(Of Militar)()
    Friend Shared militarSelected As Militar
    Friend Shared EmMissao As Boolean

    Private Sub militares_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbName = "p9g6"
        Dim userName = "p9g6"
        Dim userPass = "-99745397@BD"
        Dim RDR As SqlDataReader
        Dim SQA As SqlDataAdapter

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)


        PopulateBoxes(CN)
        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo
                           FROM EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON militar.cargo = cargo.id"
        CN.Open()

        Dim count As Integer = 0
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
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
            M.base = Convert.ToString(RDR.Item("base"))
            M.cargo = RDR.Item("cargo")

            ' VERIFICAR SE O MILITAR ESTÁ EM MISSÃO    ---> PROBLEMA: como ver se um atributo é null?

            'If If(RDR.IsDBNull("pelotao"), "", RDR.GetString("pelotao")) Then
            'EmMissao = False
            'Else
            'EmMissao = True
            'M.pelotao = Convert.ToString(RDR.Item("pelotao"))
            'End If

            listaMilitares.Add(M)
            ListBox1.Items.Add(M)
            count = count + 1
        End While

        totalTxtBox.Text = count
        CN.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index = ListBox1.SelectedIndex
        militarSelected = listaMilitares(index)
        Dim info = New info_militar
        info.Show()
        Me.Close()
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

        Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbName = "p9g6"
        Dim userName = "p9g6"
        Dim userPass = "-99745397@BD"





        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        CMD = New SqlCommand
        CMD.Connection = CN

        If num_search Then
            CMD.CommandText = String.Format("SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo
                           FROM EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON militar.cargo = cargo.id
                           WHERE nCC = {0}", text)

        Else
            CMD.CommandText = String.Format("SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo
                                   FROM EXERCITO.militar 
                                   JOIN EXERCITO.cargo 
                                   ON militar.cargo = cargo.id
                                   WHERE Pnome LIKE '%{0}%' OR Unome LIKE '%{0}%'", text)
        End If
        CN.Open()
        Dim RowsReturned = CMD.ExecuteScalar()
        ListBox1.Items.Clear()

        If RowsReturned = 0 Then
            ListBox1.Items.Add("Não foram encontrados dados :(")
            ListBox1.Enabled = False
            totalTxtBox.Text = 0

        Else
            ListBox1.Enabled = True


            RDR = CMD.ExecuteReader

            While (RDR.Read)
                idx = BinSrch(listaMilitares, 0, listaMilitares.Count - 1, RDR.Item("nCC"))
                ListBox1.Items.Add(listaMilitares(idx))
                count = count + 1
            End While

            listaMilitares.Clear()
            For i As Integer = 0 To ListBox1.Items.Count - 1
                listaMilitares.Add(ListBox1.Items(i))
            Next
            totalTxtBox.Text = count
        End If

        CN.Close()

    End Sub

    Private Sub LoadMilitar()

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

    End Function

End Class