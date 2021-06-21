Imports System.Data.SqlClient
Public Class missao
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaMissao As New List(Of Missoes)()
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
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
        Dim tipo = ComboBox1.SelectedIndex

        Dim M As Missoes
        M.nome = nome
        M.pais = pais
        M.tipo = tipo

        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = String.Format("INSERT INTO EXERCITO.missao (nome, tipo, pais, nBaixas, brief) 
                                            VALUES ('{0}', {1}, '{2}', 0, '-')", nome, tipo, pais)

        CN.Open()
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        CN.Close()
        MsgBox("Missão criada com sucesso!")
        listaMissao.Add(M)
        Dim miss = New missao
        miss.Show()
        Me.Close()


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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim index = ListBox1.SelectedIndex
        Dim M = listaMissao(index)

        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = String.Format("DELETE FROM EXERCITO.missao WHERE id={0}", M.id)

        CN.Open()
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        CN.Close()
        MsgBox("Missão removida com sucesso!")
        listaMissao.Remove(M)
        Dim miss = New missao
        miss.Show()
        Me.Close()
    End Sub
End Class