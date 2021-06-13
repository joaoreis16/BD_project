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

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo
                           FROM EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON militar.cargo = cargo.id"
        CN.Open()

        Dim count As Integer = 0
        Dim RDR As SqlDataReader
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
        Dim text = TBpesquisa.Text

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

        CMD.CommandText = String.Format("SELECT nCC, Pnome, Unome, morada, email, dNasc, dInsc, tel, nacionalidade, nMissoes, ramo, base, EXERCITO.cargo.cargo
                           FROM EXERCITO.militar 
                           JOIN EXERCITO.cargo 
                           ON militar.cargo = cargo.id
                           WHERE Pnome = '{0}' OR Unome = '{0}'", text)
        CN.Open()
        Dim RowsReturned = CMD.ExecuteScalar()
        ListBox1.Items.Clear()

        If RowsReturned = 0 Then
            ListBox1.Items.Add("Não foram encontrados dados :(")
            ListBox1.Enabled = False
            totalTxtBox.Text = 0

        Else
            Dim count As Integer = 0
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader

            For index As Integer = 1 To listaMilitares.Count
                Dim militar = listaMilitares(index)
                If militar.nCC = RDR.Item("nCC") Then ' dá erro aqui, ou não está a fazer bem o get do nCC do militar ou não há data na bd para aquela query
                    ListBox1.Items.Add(militar)
                    count = count + 1
                End If
            Next

            totalTxtBox.Text = count
        End If

        CN.Close()

    End Sub

    Private Sub LoadMilitar()

    End Sub
End Class