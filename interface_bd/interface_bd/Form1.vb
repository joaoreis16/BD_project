Public Class Form1
    Private Sub ButtonRamos_Click(sender As Object, e As EventArgs) Handles ButtonRamos.Click
        Dim ramos = New ramos
        ramos.Show()
        Me.Close()
    End Sub

    Private Sub ButtonMilitar_Click(sender As Object, e As EventArgs) Handles ButtonMilitar.Click
        Dim mil = New militares
        mil.Show()
        Me.Close()
    End Sub

    Private Sub ButtonBases_Click(sender As Object, e As EventArgs) Handles ButtonBases.Click
        Dim base = New bases_militares
        base.Show()
        Me.Close()
    End Sub
End Class
