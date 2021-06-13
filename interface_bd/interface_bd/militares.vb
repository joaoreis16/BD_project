Imports System.Data.SqlClient

Public Class militares
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaMilitares As New List(Of Militar)()
    Friend Shared militarSelected As Militar

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
                            JOIN EXERCITO.cargo ON militar.cargo = cargo.id"
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
            'M.pelotao = Convert.ToString(RDR.Item("pelotao"))

            M.cargo = RDR.Item("cargo")         'temos 2 atributos com o mesmo nome!! como ir buscar o segundo


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

End Class