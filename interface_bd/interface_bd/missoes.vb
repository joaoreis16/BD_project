Imports System.Data.SqlClient

Public Class missoes
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
    Dim listaMissoes As New List(Of Missao)()
    Dim StartingList As New List(Of Missao)()
    Friend Shared misSelected As missoes
    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim pag_init = New Form1
        pag_init.Show()
        Me.Close()
    End Sub

    Private Sub info_militar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CN As SqlConnection
        Dim CMD As New SqlCommand
        Dim RDR As SqlDataReader
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                       "initial Catalog = " + dbName + ";" +
                                       "uid = " + userName + ";" +
                                       "password = " + userPass)

        CMD.Connection = CN

        CMD.CommandText = "SELECT missao.id,nome, tipo_missao.tipo, pais,brief, estado_missao.estado FROM EXERCITO.missao
									JOIN EXERCITO.tipo_missao
									ON missao.tipo = tipo_missao.id
									JOIN EXERCITO.estado_missao
									ON missao.estado = estado_missao.id"
        CN.Open()

        Dim count As Integer = 0
        RDR = CMD.ExecuteReader
        missoesLB.Items.Clear()
        While RDR.Read
            Dim M As New Missao
            M.id = Convert.ToString(RDR.Item("id"))
            M.nome = RDR.Item("nome")
            M.tipo = Convert.ToString(RDR.Item("tipo"))
            M.pais = RDR.Item("pais")
            'B.data_inicio = Convert.ToString(RDR.Item("data_inicio"))
            'B.data_fim = Convert.ToString(RDR.Item("data_fim"))
            M.brief = Convert.ToString(RDR.Item("brief"))
            M.estado = Convert.ToString(RDR.Item("estado"))
            listaMissoes.Add(M)
            missoesLB.Items.Add(M)
            count = count + 1
        End While
        StartingList.AddRange(listaMissoes.ToArray)
        'totalTxtBox.Text = count
        CN.Close()




    End Sub

    Private Sub misLB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles missoesLB.DoubleClick
        Dim index = missoesLB.SelectedIndex
        GlobalVariables.misSelected = listaMissoes(index)
        'Dim info = New info_mis
        'info.Show()
        'Me.Close()
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

End Class