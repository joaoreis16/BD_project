Imports System.Data.SqlClient
Imports System.Globalization

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
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim RDR As SqlDataReader
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                       "initial Catalog = " + dbName + ";" +
                                       "uid = " + userName + ";" +
                                       "password = " + userPass)

        CMD = New SqlCommand
        If GlobalVariables.inserting = False Then
            submit.Hide()
            fname.Hide()
            lname.Hide()
            CargoCC.Hide()
            tmCC.Hide()
            RamoCC.Hide()
            BaseCC.Hide()
            especCC.Hide()
            tSolCC.Hide()
            Dim militar = militares.militarSelected
            TBcargo.Text = militar.cargo
            TBmorada.Text = militar.morada
            TBnCC.Text = militar.nCC
            TBnome.Text = militar.Pnome & " " & militar.Unome
            TBtel.Text = militar.tel
            TBnac.Text = militar.nacionalidade
            TBnMiss.Text = militar.nMissoes
            TBtipo.Text = militar.tipo
            TBemail.Text = militar.email
            State.Text = militar.estado
            dnascTB.Text = militar.dNasc

            If militar.estado = "Reformado" Then
                Button1.Enabled = False
            End If

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
            RDR.Close()

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
            RDR.Close()
            CN.Close()
        Else
            GlobalVariables.inserting = False
            Label16.Hide()
            State.Hide()
            TipoSol.Hide()
            Espec.Hide()
            especCC.Hide()
            Button1.Hide()
            Label6.Hide()
            Label12.Hide()
            CheckMissao.Hide()
            TBnMiss.Hide()
            TBcargo.Hide()
            TBtipo.Hide()
            ramoTT.Hide()
            TBnome.Hide()
            baseTT.Hide()
            Espec.Hide()
            Espec.Hide()
            TBnCC.ReadOnly = False
            TBmorada.ReadOnly = False
            TBnac.ReadOnly = False
            TBtel.ReadOnly = False
            dnascTB.ReadOnly = False
            TBemail.ReadOnly = False
            PopulateBoxes(CN)
            CargoCC.SelectedIndex = 1
            RamoCC.SelectedIndex = 1
            BaseCC.SelectedIndex = 1
            tmCC.SelectedIndex = 1
            especCC.SelectedIndex = 1
        End If

    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim militares = New militares
        militares.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
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

    Function PopulateBoxes(CN As SqlConnection)
        Dim SQA As SqlDataAdapter

        'bases
        SQA = New SqlDataAdapter("SELECT id, nome FROM EXERCITO.base_militar", CN)
        Dim dt As DataTable = New DataTable()
        SQA.Fill(dt)

        BaseCC.DataSource = dt
        BaseCC.DisplayMember = "nome"
        BaseCC.ValueMember = "id"

        'ramos
        SQA = New SqlDataAdapter("SELECT ramo.id,design FROM EXERCITO.ramo
                                  JOIN EXERCITO.tipo_ramo
                                  ON ramo.id = tipo_ramo.id", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        RamoCC.DataSource = dt
        RamoCC.DisplayMember = "design"
        RamoCC.ValueMember = "id"

        'cargos
        SQA = New SqlDataAdapter("SELECT id, cargo FROM EXERCITO.cargo", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        CargoCC.DataSource = dt
        CargoCC.DisplayMember = "cargo"
        CargoCC.ValueMember = "id"

        Dim scDict As New Dictionary(Of Integer, String)()
        scDict.Add(1, "Soldado")
        scDict.Add(2, "Medico")
        scDict.Add(3, "Engenheiro")
        tmCC.DataSource = New BindingSource(scDict, Nothing)
        tmCC.DisplayMember = "Value"
        tmCC.ValueMember = "Key"

        SQA = New SqlDataAdapter("SELECT id, especialidade FROM EXERCITO.especialidade", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        especCC.DataSource = dt
        especCC.DisplayMember = "especialidade"
        especCC.ValueMember = "id"

        SQA = New SqlDataAdapter("SELECT id, tipo FROM EXERCITO.tipo_soldado
                                                WHERE ramo=1", CN)
        dt = New DataTable()
        SQA.Fill(dt)

        tSolCC.DataSource = dt
        tSolCC.DisplayMember = "tipo"
        tSolCC.ValueMember = "id"


        CN.Close()

    End Function

    Private Sub RamoCC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RamoCC.SelectedIndexChanged
        Dim CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                       "initial Catalog = " + dbName + ";" +
                                       "uid = " + userName + ";" +
                                         "password = " + userPass)
        Dim SQA As SqlDataAdapter
        SQA = New SqlDataAdapter(String.Format("SELECT id, tipo FROM EXERCITO.tipo_soldado
                                                WHERE ramo={0}", RamoCC.SelectedItem(0)), CN)
        Dim dt As DataTable = New DataTable()
        SQA.Fill(dt)

        tSolCC.DataSource = dt
        tSolCC.DisplayMember = "tipo"
        tSolCC.ValueMember = "id"

        SQA = New SqlDataAdapter(String.Format("SELECT base_militar.id, nome FROM EXERCITO.base_militar
                                  JOIN EXERCITO.base_ramo ON idBase = base_militar.id
                                  WHERE idRamo = {0}", RamoCC.SelectedItem(0)), CN)
        dt = New DataTable()
        SQA.Fill(dt)

        BaseCC.DataSource = dt
        BaseCC.DisplayMember = "nome"
        BaseCC.ValueMember = "id"
    End Sub

    Private Sub tmCC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tmCC.SelectedIndexChanged
        If tmCC.SelectedIndex = 0 Then
            especCC.Hide()
            EspecLabel.Hide()
            tSolCC.Show()
            TpSolLabel.Show()
        ElseIf tmCC.SelectedIndex = 1 Then
            tSolCC.Hide()
            TpSolLabel.Hide()
            especCC.Show()
            EspecLabel.Show()
        Else
            tSolCC.Hide()
            TpSolLabel.Hide()
            especCC.Hide()
            EspecLabel.Hide()
        End If


    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                                   "initial Catalog = " + dbName + ";" +
                                   "uid = " + userName + ";" +
                                   "password = " + userPass)

        Dim nCC = TBnCC.Text
        Dim Pnome = fname.Text
        Dim Unome = lname.Text
        Dim morada = TBmorada.Text
        Dim tel = TBtel.Text
        Dim email = TBemail.Text
        Dim nac = TBnac.Text
        Dim dNasc = dnascTB.Text
        Dim cargo = CargoCC.SelectedItem(0)
        Dim tipo_m As Integer = 1
        For Each pair As KeyValuePair(Of Integer, String) In tmCC.Items
            If (pair.Key = tmCC.SelectedIndex) Then
                tipo_m = pair.Key
            End If
        Next
        Dim ramo = RamoCC.SelectedItem(0)
        Dim base = BaseCC.SelectedItem(0)
        CN.Open()
        CMD = New SqlCommand
        CMD.Connection = CN

        If tipo_m = 1 Then
            Dim tipo_s = tSolCC.SelectedItem(0)
            CMD = New SqlCommand("EXERCITO.createSoldadoAndM", CN)
            CMD.Parameters.Add(New SqlParameter("@tipo", tipo_s))
        ElseIf tipo_m = 2 Then
            Dim espec = especCC.SelectedItem(0)
            CMD = New SqlCommand("EXERCITO.createMedicoAndM", CN)
            CMD.Parameters.Add(New SqlParameter("@tipo", espec))
        Else
            CMD = New SqlCommand("EXERCITO.createEngenheiroAndM", CN)

        End If
        Dim parsing = dNasc.Split("/")
        Dim gformat = parsing(1) + "/" + parsing(0) + "/" + parsing(2)
        Debug.Print(IsDate(gformat))
        If (String.IsNullOrEmpty(nCC) Or String.IsNullOrEmpty(Pnome) Or String.IsNullOrEmpty(Unome) Or String.IsNullOrEmpty(morada) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(dNasc) Or String.IsNullOrEmpty(tel) Or String.IsNullOrEmpty(nac) Or (Not IsDate(dNasc))) Then
            Return
        End If
        gformat = parsing(2) + parsing(0) + parsing(1)
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@nCC", nCC))
        CMD.Parameters.Add(New SqlParameter("@fname", Pnome))
        CMD.Parameters.Add(New SqlParameter("@lname", Unome))
        CMD.Parameters.Add(New SqlParameter("@morada", morada))
        CMD.Parameters.Add(New SqlParameter("@email", email))
        CMD.Parameters.Add(New SqlParameter("@dnasc", gformat))
        CMD.Parameters.Add(New SqlParameter("@tel", tel))
        CMD.Parameters.Add(New SqlParameter("@nac", nac))
        CMD.Parameters.Add(New SqlParameter("@ramo", ramo))
        CMD.Parameters.Add(New SqlParameter("@base", base))
        CMD.Parameters.Add(New SqlParameter("@cargo", cargo))

        CMD.ExecuteNonQuery()
        Dim info = New militares
        info.Show()
        Me.Close()
    End Sub

End Class