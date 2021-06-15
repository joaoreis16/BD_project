Public Class equipamento
    Private Sub armabttn_Click(sender As Object, e As EventArgs) Handles armabttn.Click
        veiculobttn.Visible = False
        armabttn.Visible = False

        infoBox.Visible = True
        pesquisaBox.Visible = True
        veiculoBox.Visible = False

    End Sub

    Private Sub veiculobttn_Click(sender As Object, e As EventArgs) Handles veiculobttn.Click
        veiculobttn.Visible = False
        armabttn.Visible = False

        infoBox.Visible = True
        pesquisaBox.Visible = True
        armaBox.Visible = False
    End Sub

End Class