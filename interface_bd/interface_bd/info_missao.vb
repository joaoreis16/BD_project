Imports System.Data.SqlClient
Public Class info_missao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaPel As New List(Of Pelotoes)()
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
    Dim idMissao As Integer
    Public Shared id As Integer

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

        id = M.id

        Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbName = "p9g6"
        Dim userName = "p9g6"
        Dim userPass = "-99745397@BD"

        TBnome.ReadOnly = False

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = String.Format("SELECT* FROM  EXERCITO.pelotao JOIN  EXERCITO.missao ON missao.id = pelotao.idMissao WHERE missao.id = {0}", M.id)

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBox1.Items.Clear()
        While RDR.Read
            Dim P As New Pelotoes
            P.id = Convert.ToString(RDR.Item("id"))
            P.nome = RDR.Item("nome")

            listaPel.Add(P)
            ListBox1.Items.Add(P)
        End While

        RDR.Close()
        CN.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' adicionar pelotao
        Dim pel = New pelotao
        GlobalVariables.add2missao = True
        pel.addMission.Visible = True
        pel.criarPelotao.Visible = False
        pel.Button1.Visible = False
        pel.Button2.Visible = False
        pel.Button3.Visible = False
        pel.Button4.Visible = False
        pel.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' remove pel 

        Dim index = ListBox1.SelectedIndex
        Dim P = listaPel(index)

        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                   "initial Catalog = " + dbName + ";" +
                                   "uid = " + userName + ";" +
                                   "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand(String.Format("UPDATE EXERCITO.pelotao SET idMissao = null WHERE id = {0}", P.id))
        CMD.Connection = CN
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        MsgBox("Pelotão removido com sucesso!")
        Dim infom = New info_missao
        infom.Show()
        Me.Close()
    End Sub
End Class