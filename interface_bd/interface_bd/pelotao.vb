Imports System.Data.SqlClient
Public Class pelotao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaPelotao As New List(Of Pelotoes)()
    Dim nCC_general As Integer
    Dim id_pelotao_selected As Integer
    Dim pelSelected As Integer

    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub pelotao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalVariables.porto()

        TBnome.ReadOnly = False

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT id, nome, Pnome, Unome, idMissao, militar.nCC  FROM EXERCITO.pelotao LEFT JOIN EXERCITO.militar ON militar.nCC=pelotao.nCC"

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        listaPelotao.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        While RDR.Read
            Dim P As New Pelotoes
            P.id = Convert.ToString(RDR.Item("id"))
            P.nome = RDR.Item("nome")

            P.general = RDR.Item("Pnome") & " " & RDR.Item("Unome")

            If IsDBNull(RDR.Item("Pnome")) Then
                P.general = "null"
            Else
                P.general = RDR.Item("Pnome") & " " & RDR.Item("Unome")
            End If

            If IsDBNull(RDR.Item("idMissao")) Then
                P.idMissao = Nothing
            Else
                P.idMissao = Convert.ToString(RDR.Item("idMissao"))
            End If

            If IsDBNull(RDR.Item("nCC")) Then
                P.general_id = Nothing
            Else
                P.general_id = RDR.Item("nCC")
            End If


            listaPelotao.Add(P)
            ListBox1.Items.Add(P)
        End While

        RDR.Close()
        CN.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        TBnome.ReadOnly = True
        Dim index As Integer
        If ListBox1.SelectedIndex = -1 Then
            index = 0
        Else
            index = ListBox1.SelectedIndex
        End If

        Dim P = listaPelotao(index)

        id_pelotao_selected = P.id

        ListBox2.Items.Clear()

        TBnome.Text = P.nome
        TBid.Text = P.id
        TBgeneral.Text = P.general

        For i As Integer = 0 To GlobalVariables.listaMilitares.Count - 1
            Dim M = GlobalVariables.listaMilitares(i)
            If M.pelotao = P.id Then

                ListBox2.Items.Add(M)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalVariables.add2pelotao = True
        GlobalVariables.pelotao_id = id_pelotao_selected
        Dim mil = New militares
        mil.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index = ListBox2.SelectedIndex
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand("EXERCITO.removeFromPelotao")
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@nCC", ListBox2.Items(index).nCC))
        CMD.Parameters.Add(New SqlParameter("@pel", GlobalVariables.pelotao_id))
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        MsgBox("Militar removido com sucesso!")
        Dim pel = New pelotao
        pel.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TBnome.Text = ""
        TBnome.ReadOnly = False
        TBid.Text = ""
        TBgeneral.Text = ""

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub criarPelotao_Click(sender As Object, e As EventArgs) Handles criarPelotao.Click
        Dim nome = TBnome.Text

        Dim index = ListBox2.SelectedIndex
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand("EXERCITO.createPelotao")
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@nome ", nome))
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        MsgBox("Pelotão criado com sucesso!")
        Dim pel = New pelotao
        pel.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim index = ListBox2.SelectedIndex
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand("EXERCITO.deletePelotao")
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@pel ", id_pelotao_selected))
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        MsgBox("Pelotão eliminado com sucesso!")
        Dim pel = New pelotao
        pel.Show()
        Me.Close()
    End Sub
End Class