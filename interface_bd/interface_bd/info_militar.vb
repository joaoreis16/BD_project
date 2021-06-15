Public Class info_militar

    Private Sub CheckMissao_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMissao.CheckedChanged

        If militares.EmMissao Then
            CheckMissao.Checked = True
            BoxMissao.Visible = True

        Else
            CheckMissao.Checked = False
            BoxMissao.Visible = False
        End If
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub info_militar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim militar = militares.militarSelected

        TBcargo.Text = militar.cargo
        TBmorada.Text = militar.morada
        TBnCC.Text = militar.nCC
        TBnome.Text = militar.Pnome & " " & militar.Unome
        TBtel.Text = militar.tel
        TBnac.Text = militar.nacionalidade
        TBnMiss.Text = militar.nMissoes
        'TBtipo.Text = militar.tipo

    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim militares = New militares
        militares.Show()
        Me.Close()
    End Sub

    Private Sub TBnome_TextChanged(sender As Object, e As EventArgs) Handles TBnome.TextChanged

    End Sub

    Private Sub TBtel_TextChanged(sender As Object, e As EventArgs) Handles TBtel.TextChanged

    End Sub

    Private Sub TBmorada_TextChanged(sender As Object, e As EventArgs) Handles TBmorada.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class