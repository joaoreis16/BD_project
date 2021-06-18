Imports System.Data.SqlClient

Public Class info_militar
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
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
        State.Text = militar.estado
        dnascTB.Text = militar.dNasc

        If militar.estado = "Reformado" Then
            Button1.Enabled = False
        End If

        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim RDR As SqlDataReader
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                   "initial Catalog = " + dbName + ";" +
                                   "uid = " + userName + ";" +
                                   "password = " + userPass)

        CMD = New SqlCommand



        CMD.Connection = CN
        CMD.CommandText = String.Format("SELECT design, nome FROM
                                         EXERCITO.militar
                                         JOIN EXERCITO.base_militar
                                         ON militar.base = base_militar.id
                                         JOIN EXERCITO.ramo
                                         ON militar.ramo = ramo.id
                                         JOIN EXERCITO.tipo_ramo
                                         ON tipo_ramo.id = ramo.tipo")

        CN.Open()
        RDR = CMD.ExecuteReader
        While RDR.Read
            baseTT.Text = RDR.Item("nome")
            ramoTT.Text = RDR.Item("design")
        End While

        If militar.base = Nothing Then
            baseTT.Hide()
            Label19.Hide()
        End If

        If militar.missao = -1 Then
            CheckMissao.Checked = False
            BoxMissao.Visible = False
        Else
            CheckMissao.Checked = True
            BoxMissao.Visible = True

            CMD.Connection = CN

            CMD.CommandText = String.Format("	select nome, tipo_missao.tipo from exercito.missao
				            JOIN exercito.tipo_missao
				            ON missao.tipo = tipo_missao.id
				            where missao.id = {0}", militar.missao)
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

            RDR.Close()
        End If
        CMD.Connection = CN
        If militar.tipo = "SOLDADO" Then
            Espec.Hide()
            EspecLabel.Hide()

            CMD.CommandText = String.Format("SELECT tipo_soldado.tipo FROM EXERCITO.soldado
                                            JOIN EXERCITO.tipo_soldado ON tipo_soldado.id = soldado.tipo
                                            WHERE nCC = {0}", militar.nCC)

            RDR = CMD.ExecuteReader
            While RDR.Read
                TipoSol.Text = RDR.Item("tipo")
            End While
        ElseIf militar.tipo = "MEDICO" Then
            TipoSol.Hide()
            TpSolLabel.Hide()

            CMD.CommandText = String.Format("SELECT especialidade.especialidade FROM EXERCITO.medico
                                            JOIN EXERCITO.especialidade ON especialidade.id = medico.especialidade
                                            WHERE nCC = {0}", militar.nCC)
            RDR = CMD.ExecuteReader
            While RDR.Read
                Espec.Text = RDR.Item("especialidade")
            End While

        Else
            TipoSol.Hide()
            TpSolLabel.Hide()
            Espec.Hide()
            EspecLabel.Hide()
        End If

        CN.Close()

    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim militares = New militares
        militares.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim RDR As SqlDataReader
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                   "initial Catalog = " + dbName + ";" +
                                   "uid = " + userName + ";" +
                                   "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand("EXERCITO.retire")
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@nCC", militares.militarSelected.nCC))
        CMD.ExecuteNonQuery()
        militares.militarSelected.estado = "Reformado"
        Dim info = New info_militar
        info.Show()
        Me.Close()
    End Sub

End Class