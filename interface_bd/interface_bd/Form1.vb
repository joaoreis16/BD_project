Imports System.Data.SqlClient
Public Class Form1

    Private Sub ButtonRamos_Click(sender As Object, e As EventArgs) Handles ButtonRamos.Click
        Dim ramos = New ramos
        ramos.Show()
        Me.Close()
    End Sub

    Private Sub ButtonMilitar_Click(sender As Object, e As EventArgs) Handles ButtonMilitar.Click
        GlobalVariables.add2pelotao = False
        Dim mil = New militares
        mil.Show()
        Me.Close()
    End Sub

    Private Sub ButtonBases_Click(sender As Object, e As EventArgs) Handles ButtonBases.Click
        Dim base = New bases_militares
        base.Show()
        Me.Close()
    End Sub

    Private Sub Equipamento_Click(sender As Object, e As EventArgs) Handles Equipamento.Click
        Dim equi = New escolha_equi
        equi.Show()
        Me.Close()
    End Sub

    Private Sub ButtonMissao_Click(sender As Object, e As EventArgs) Handles ButtonMissao.Click
        Dim mis = New missao
        mis.Show()
        Me.Close()
    End Sub

    Private Sub ButtonPelotao_Click(sender As Object, e As EventArgs) Handles ButtonPelotao.Click
        Dim pel = New pelotao
        pel.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.porto()
    End Sub
End Class
