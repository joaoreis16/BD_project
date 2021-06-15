Imports System.Data.SqlClient

Public Class info_militar

    Private Sub CheckMissao_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMissao.CheckedChanged


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
        TBtipo.Text = militar.tipo

        If militar.missao = -1 Then
            CheckMissao.Checked = False
            BoxMissao.Visible = False
        Else
            CheckMissao.Checked = True
            BoxMissao.Visible = True

            Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
            Dim dbName = "p9g6"
            Dim userName = "p9g6"
            Dim userPass = "-99745397@BD"
            Dim CN As SqlConnection
            Dim CMD As SqlCommand
            Dim RDR As SqlDataReader
            CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                   "initial Catalog = " + dbName + ";" +
                                   "uid = " + userName + ";" +
                                   "password = " + userPass)

            CMD = New SqlCommand
            CMD.Connection = CN

            CMD.CommandText = String.Format("	select nome, tipo_missao.tipo from exercito.missao
				            JOIN exercito.tipo_missao
				            ON missao.tipo = tipo_missao.id
				            where missao.id = {0}", militar.missao)
            CN.Open()
            RDR = CMD.ExecuteReader

            While RDR.Read
                nomeMiss.Text = RDR.Item("nome")
                tipoMiss.Text = RDR.Item("tipo")
            End While
            RDR.Close()
            CMD.CommandText = String.Format("	SELECT equipamento.modelo
                           FROM EXERCITO.militar 
						   JOIN EXERCITO.arma
						   ON EXERCITO.aUsarArma(nCC) = EXERCITO.arma.idEqui
						   JOIN EXERCITO.equipamento
						   ON arma.idEqui = equipamento.id
						   WHERE nCC = {0}", militar.nCC)
            RDR = CMD.ExecuteReader
            While RDR.Read
                Arma.Text = RDR.Item("modelo")
            End While

            RDR.Close()

            CMD.CommandText = String.Format("	SELECT equipamento.modelo
                           FROM EXERCITO.militar 
						   JOIN EXERCITO.veiculo
						   ON EXERCITO.aUsarVeiculo(nCC) = EXERCITO.veiculo.idEqui
						   JOIN EXERCITO.equipamento
						   ON veiculo.idEqui = equipamento.id
						   WHERE nCC = {0}", militar.nCC)
            RDR = CMD.ExecuteReader
            While RDR.Read
                Veic.Text = RDR.Item("modelo")
            End While


            CN.Close()
        End If

    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim militares = New militares
        militares.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class