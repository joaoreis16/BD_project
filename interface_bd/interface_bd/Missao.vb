Imports System.Data.SqlClient
Public Class missao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaMissao As New List(Of Missoes)()
    Friend Shared baseSelected As Base
    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim pag_init = New Form1
        pag_init.Show()
        Me.Close()
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim pag_init = New Form1
        pag_init.Show()
        Me.Close()
    End Sub

    Private Sub missao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBnome.Enabled = True
        TBpais.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.SelectedIndex = 0

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

        CMD.CommandText = "SELECT * FROM EXERCITO.missao"

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBox1.Items.Clear()
        Dim M As New Missoes
        While RDR.Read
            M.id = Convert.ToString(RDR.Item("id"))
            M.nome = RDR.Item("nome")
            M.tipo = RDR.Item("tipo")
            M.pais = RDR.Item("pais")
            M.nBaixas = Convert.ToString(RDR.Item("nBaixas"))

            listaMissao.Add(M)
            ListBox1.Items.Add(M)
        End While

        RDR.Close()
        CN.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TBnome.Enabled = False
        TBpais.Enabled = False
        ComboBox1.Enabled = False

        Dim index = ListBox1.SelectedIndex
        Dim M = listaMissao(index)
        Debug.Print(index)

        TBnome.Text = M.nome
        TBpais.Text = M.pais
        ComboBox1.SelectedItem = M.tipo
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TBnome.Enabled = True
        TBpais.Enabled = True
        ComboBox1.Enabled = True


        TBnome.Text = ""
        TBpais.Text = ""
        ComboBox1.SelectedItem = ""
        ComboBox1.SelectedIndex = 0
    End Sub
End Class