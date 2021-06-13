Public Class ramos
    Friend Shared id As Integer

    Private Sub ButtonFT_Click(sender As Object, e As EventArgs) Handles ButtonFT.Click
        id = 1
        Dim FT = New info_ramo
        FT.Show()
        Me.Close()
    End Sub

    Private Sub ButtonFA_Click(sender As Object, e As EventArgs) Handles ButtonFA.Click
        id = 2
        Dim FA = New info_ramo
        FA.Show()
        Me.Close()
    End Sub

    Private Sub ButtonFM_Click(sender As Object, e As EventArgs) Handles ButtonFM.Click
        id = 3
        Dim FM = New info_ramo
        FM.Show()
        Me.Close()
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim pag_init = New Form1
        pag_init.Show()
        Me.Close()
    End Sub
End Class