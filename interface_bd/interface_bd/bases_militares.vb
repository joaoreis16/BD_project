Imports System.Data.SqlClient

Public Class bases_militares
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaBases As New List(Of Base)()
    Friend Shared baseSelected As Base
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

        CMD.CommandText = "SELECT * FROM EXERCITO.base_militar"
        CN.Open()

        Dim count As Integer = 0
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
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
            ListBox1.Items.Add(B)
            count = count + 1
        End While

        totalTxtBox.Text = count
        CN.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index = ListBox1.SelectedIndex
        baseSelected = listaBases(index) ' acabar
        Dim info = New info_base
        info.Show()
        Me.Close()
    End Sub
End Class