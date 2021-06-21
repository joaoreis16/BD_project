Public Class escolha_equi
    Friend Shared arma As Boolean

    Private Sub armabttn_Click(sender As Object, e As EventArgs) Handles armabttn.Click
        arma = True
        Dim equi = New equipamento
        equi.Show()
        Me.Close()
    End Sub

    Private Sub veiculobttn_Click(sender As Object, e As EventArgs) Handles veiculobttn.Click
        arma = False
        Dim equi = New equipamento
        equi.Show()
        Me.Close()
    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim pag_init = New Form1
        pag_init.Show()
        Me.Close()
    End Sub
End Class