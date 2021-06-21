Imports System.Data.SqlClient
Public Class info_missao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaMilitar As New List(Of Militar)()
    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim missao = New missao
        missao.Show()
        Me.Close()
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub info_missao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim M = GlobalVariables.misSelected
        TBbrief.Text = M.brief
        TBestado.Text = M.estado
        TBid.Text = M.id
        TBnome.Text = M.nome
        TBpais.Text = M.pais
        TBtipo.Text = M.tipo

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

        CMD.CommandText = String.Format("SELECT * FROM EXERCITO.pelotao JOIN EXERCITO.missao ON pelotao.idMissao = missao.id WHERE missao.id = {0}", M.id)

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBox1.Items.Clear()

        ' se fizer desta maneira temos que clicar em militares para gerar a lista de militares :/ portisse máxima
        Dim index = 0
        While RDR.Read

            Dim nCC = RDR.Item("nCC")
            Dim militar = GlobalVariables.listaMilitares(index)

            If militar.nCC = nCC Then
                ListBox1.Items.Add(militar)
            End If

            index = index + 1
        End While

        RDR.Close()
        CN.Close()
    End Sub
End Class