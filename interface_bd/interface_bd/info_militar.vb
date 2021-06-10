Public Class info_militar
    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim militares = New militares
        militares.Show()
        Me.Close()
    End Sub

    Private Sub CheckMissao_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMissao.CheckedChanged
        If CheckMissao.Checked = True Then
            BoxMissao.Visible = True

        Else
            BoxMissao.Visible = False
        End If
    End Sub
End Class