Imports System.Data.SqlClient
Public Class missao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaMissao As New List(Of Missoes)()
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
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

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

        CMD.CommandText = "SELECT missao.id,nome, tipo_missao.tipo, pais,brief, estado_missao.estado FROM EXERCITO.missao
									JOIN EXERCITO.tipo_missao
									ON missao.tipo = tipo_missao.id
									JOIN EXERCITO.estado_missao
									ON missao.estado = estado_missao.id"

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBox1.Items.Clear()
        While RDR.Read
            Dim M As New Missoes
            M.id = Convert.ToString(RDR.Item("id"))
            M.nome = RDR.Item("nome")
            M.tipo = Convert.ToString(RDR.Item("tipo"))
            M.pais = RDR.Item("pais")
            M.brief = Convert.ToString(RDR.Item("brief"))
            M.estado = Convert.ToString(RDR.Item("estado"))
            listaMissao.Add(M)
            ListBox1.Items.Add(M)
        End While

        RDR.Close()
        CN.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TBnome.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False

        Dim index = ListBox1.SelectedIndex
        Dim M = listaMissao(index)
        GlobalVariables.misSelected = M

        TBnome.Text = M.nome
        ComboBox2.SelectedItem = M.pais
        ComboBox1.SelectedItem = M.tipo
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Reset Button
        TBnome.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True

        TBnome.Text = ""
        ComboBox2.SelectedItem = ""
        ComboBox1.SelectedItem = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Criar Missão
        Dim nome = TBnome.Text
        Dim pais = ComboBox2.SelectedItem
        Dim tipo = ComboBox1.SelectedItem


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ver mais info
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Selecione uma missão primeiro")

        Else
            Dim info = New info_missao
            info.Show()
            Me.Close()
        End If

    End Sub


End Class