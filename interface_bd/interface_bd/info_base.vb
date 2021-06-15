Public Class info_base
    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim bases = New bases_militares
        bases.Show()
        Me.Close()
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub info_base_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' tá foda aqui porque esta base pode vir de dois Forms: ou de bases_militares ou de info_ramo
        Dim base As Base = bases_militares.baseSelected
        TBcapacidade.Text = base.maxMilitares
        TBmorada.Text = base.morada
        TBnome.Text = base.nome
        TBtel.Text = base.contacto

    End Sub
End Class