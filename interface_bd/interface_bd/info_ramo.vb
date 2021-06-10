Public Class info_ramo
    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim ramos = New ramos
        ramos.Show()
        Me.Close()
    End Sub
End Class