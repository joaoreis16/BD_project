Public Class equipamento
    Private Sub equipamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If escolha_equi.arma Then
            veiculoBox.Visible = False
        Else
            armaBox.Visible = False
        End If
    End Sub
End Class