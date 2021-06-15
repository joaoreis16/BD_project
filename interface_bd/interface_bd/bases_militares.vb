Imports System.Data.SqlClient

Public Class bases_militares
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaBases As New List(Of Base)()
    Dim StartingList As New List(Of Base)()
    Friend Shared baseSelected As Base
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
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

    Private Sub bases_militares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        'PopulateBoxes(CN)
        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM EXERCITO.base_militar"
        CN.Open()

        Dim count As Integer = 0
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox2.Items.Clear()
        While RDR.Read
            Dim B As New Base
            B.id = Convert.ToString(RDR.Item("id"))
            B.nome = RDR.Item("nome")
            B.contacto = RDR.Item("contacto")
            B.morada = RDR.Item("morada")
            'B.data_inicio = Convert.ToString(RDR.Item("data_inicio"))
            'B.data_fim = Convert.ToString(RDR.Item("data_fim"))
            B.maxMilitares = Convert.ToString(RDR.Item("maxMilitares"))

            listaBases.Add(B)
            ListBox2.Items.Add(B)
            count = count + 1
        End While
        StartingList.AddRange(listaBases.ToArray)
        totalTxtBox.Text = count
        CN.Close()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim index = ListBox2.SelectedIndex
        baseSelected = listaBases(index)
        Dim info = New info_base
        info.Show()
        Me.Close()
    End Sub

    Private Sub pesquisaBttn_Click(sender As Object, e As EventArgs) Handles basePesquisa.Click
        Dim num_search = False
        Dim text = barraBases.Text
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
            CMD.CommandText = String.Format("SELECT * FROM EXERCITO.base_militar
                                             WHERE id = {0}", text)

        Else
            CMD.CommandText = String.Format("SELECT * FROM EXERCITO.base_militar
                                             WHERE nome LIKE '%{0}%'", text)
        End If
        CN.Open()
        Dim RowsReturned = CMD.ExecuteScalar()
        ListBox2.Items.Clear()

        If RowsReturned = 0 Then
            ListBox2.Items.Add("Não foram encontrados dados :(")
            ListBox2.Enabled = False
            totalTxtBox.Text = 0

        Else
            listaBases.AddRange(StartingList.ToArray)
            ListBox2.Enabled = True


            RDR = CMD.ExecuteReader

            While (RDR.Read)
                idx = BinSrch(listaBases, 0, listaBases.Count - 1, RDR.Item("id"))
                If idx > -1 Then
                    ListBox2.Items.Add(listaBases(idx))
                    count = count + 1
                End If
            End While

            listaBases.Clear()
            For i As Integer = 0 To ListBox2.Items.Count - 1
                listaBases.Add(ListBox2.Items(i))
            Next
            totalTxtBox.Text = count
        End If

        CN.Close()

    End Sub

    Private Sub ApplyFilters_Click(sender As Object, e As EventArgs) Handles ApplyBases.Click
        Dim ftcb = FT.Checked
        Dim facb = FA.Checked
        Dim fmcb = FM.Checked

        Dim conds As New List(Of Integer)({0, 0, 0})


        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        Dim cmd As String


        If ftcb Then
            conds(0) = 1
        End If

        If facb Then
            conds(1) = 1
        End If

        If fmcb Then
            conds(2) = 1
        End If

        If conds.Count > 0 Then
            If (ftcb Or facb Or fmcb) Then
                cmd = cmd + "SELECT id FROM EXERCITO.basesOfRamos("
                For idx As Integer = 0 To conds.Count - 1
                    cmd = cmd + Convert.ToString(conds(idx))

                    If Not (idx = conds.Count - 1) Then
                        cmd = cmd + ","
                    End If
                Next
                cmd = cmd + ")"
            Else
                cmd = "SELECT id FROM EXERCITO.base_militar"
            End If

        End If


        Dim count As Integer = 0
        Dim RDR As SqlDataReader
        Dim i As Integer
        Dim SQLcmd As SqlCommand
        Debug.Print(cmd)
        SQLcmd = New SqlCommand
        SQLcmd.Connection = CN
        SQLcmd.CommandText = cmd
        CN.Open()
        ListBox2.Items.Clear()

        ListBox2.Enabled = True


        RDR = SQLcmd.ExecuteReader

        While (RDR.Read)
            i = BinSrch(listaBases, 0, listaBases.Count - 1, RDR.Item("id"))
            If i > -1 Then
                ListBox2.Items.Add(listaBases(i))
                count = count + 1
            End If
        End While

        listaBases.Clear()
        For it As Integer = 0 To ListBox2.Items.Count - 1
            listaBases.Add(ListBox2.Items(it))
        Next
        totalTxtBox.Text = count

        If count = 0 Then
            ListBox2.Items.Add("Não foram encontrados dados :(")
            ListBox2.Enabled = False
            totalTxtBox.Text = 0
        End If


        CN.Close()

    End Sub

    Function BinSrch(arr As List(Of Base), l As Integer, r As Integer, id As Integer)

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

    'Function PopulateBoxes(CN As SqlConnection)
    '
    'End Function

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles FM.CheckedChanged

    End Sub

    Private Sub baseReset_Click(sender As Object, e As EventArgs) Handles baseReset.Click
        listaBases.Clear()
        listaBases.AddRange(StartingList.ToArray)
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(listaBases.ToArray)
    End Sub
End Class