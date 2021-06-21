Imports System.Data.SqlClient
Public Class assing_equipamento
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
    Dim listaEquipamento As New List(Of Equi)()
    Dim selectedEquip As Equi
    Dim curwpn As Integer


    Private Sub assing_equipamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arbox = Armbox
        Dim miltxt = Milbox
        miltxt.Text = GlobalVariables.milSelected.ToString
        ListBox2.Enabled = False
        Armbox.ReadOnly = True
        Milbox.ReadOnly = True

        If GlobalVariables.typeEqui = False Then
            Label3.Text = "Veiculos Disponiveis"
            Label2.Text = "Veiculo Atual"
            Button1.Text = "Atribuir Veiculo"
            Button2.Text = "Remover Veiculo"
        End If

        Dim cmd As New SqlCommand
        Dim RDR As SqlDataReader
        curwpn = -1

        Dim CN = New SqlConnection("data Source = " + dbServer + " ;" +
                       "initial Catalog = " + dbName + ";" +
                       "uid = " + userName + ";" +
                       "password = " + userPass)

        Dim txt As String
        If GlobalVariables.typeEqui = True Then
            txt = "SELECT * FROM EXERCITO.equipamento JOIN EXERCITO.arma ON  id = idEqui JOIN EXERCITO.tipo_arma ON tipo_arma.id = arma.idTipo
                    WHERE EXERCITO.equipIsAvailable(idEqui) = 1"
        Else
            txt = "SELECT * FROM EXERCITO.equipamento JOIN EXERCITO.veiculo ON  id = idEqui JOIN EXERCITO.tipo_veiculo ON tipo_veiculo.id = veiculo.idTipo
                    WHERE EXERCITO.equipIsAvailable(idEqui) = 1"
        End If

        cmd.CommandText = txt
        cmd.Connection = CN
        CN.Open()
        RDR = cmd.ExecuteReader
        While RDR.Read
            Dim equipamento As New Equi
            If GlobalVariables.typeEqui Then
                equipamento.nSerie_matricula = Convert.ToString(RDR.Item("nSerie"))
            Else
                equipamento.nSerie_matricula = Convert.ToString(RDR.Item("matricula"))
                If IsDBNull(RDR.Item("idMissao")) Then
                    equipamento.missao = "null"
                Else
                    equipamento.missao = Convert.ToString(RDR.Item("idMissao"))
                End If
            End If
            equipamento.id = RDR.Item("id")
            equipamento.tipo = RDR.Item("tipo")
            equipamento.modelo = RDR.Item("modelo")

            listaEquipamento.Add(equipamento)
            ListBox1.Items.Add(equipamento)
        End While
        RDR.Close()

        If GlobalVariables.typeEqui Then
            txt = String.Format("SELECT * FROM EXERCITO.utiliza_equipamento
                            JOIN EXERCITO.arma
                            On equipamento = idEqui
                            JOIN EXERCITO.equipamento
                            ON equipamento = id WHERE data_f IS NOT NULL
                            AND soldado = {0}", GlobalVariables.milSelected.nCC)
        Else
            txt = String.Format("SELECT * FROM EXERCITO.utiliza_equipamento
                            JOIN EXERCITO.veiculo
                            On equipamento = idEqui
                            JOIN EXERCITO.equipamento
                            ON equipamento = id WHERE data_f IS NOT NULL
                            AND soldado = {0}", GlobalVariables.milSelected.nCC)
        End If

        cmd.CommandText = txt
        cmd.Connection = CN
        RDR = cmd.ExecuteReader
        While RDR.Read
            If GlobalVariables.typeEqui Then
                ListBox2.Items.Add(String.Format("{0}  [ {1} - {2} ]", RDR.Item("nSerie"), RDR.Item("data_i"), RDR.Item("data_f")))
            Else
                ListBox2.Items.Add(String.Format("{0}  [ {1} - {2} ]", RDR.Item("matricula"), RDR.Item("data_i"), RDR.Item("data_f")))
            End If
        End While
        RDR.Close()

        If GlobalVariables.typeEqui Then
            txt = String.Format("SELECT * FROM EXERCITO.arma JOIN 
				    EXERCITO.equipamento
				    ON arma.idEqui = equipamento.id JOIN
				    EXERCITO.utiliza_equipamento 
				    ON utiliza_equipamento.equipamento = equipamento.id JOIN
				    EXERCITO.militar
				    ON militar.nCC = utiliza_equipamento.soldado
				    WHERE data_f IS NULL
				    AND nCC={0}", GlobalVariables.milSelected.nCC)
        Else
            txt = String.Format("SELECT * FROM EXERCITO.veiculo JOIN 
				    EXERCITO.equipamento
				    ON veiculo.idEqui = equipamento.id JOIN
				    EXERCITO.utiliza_equipamento 
				    ON utiliza_equipamento.equipamento = equipamento.id JOIN
				    EXERCITO.militar
				    ON militar.nCC = utiliza_equipamento.soldado
				    WHERE data_f IS NULL
				    AND nCC={0}", GlobalVariables.milSelected.nCC)
        End If


        cmd.CommandText = txt
        cmd.Connection = CN
        RDR = cmd.ExecuteReader
        While RDR.Read
            curwpn = RDR.Item("id")
            If GlobalVariables.typeEqui Then
                arbox.Text = String.Format("{0}   |   {1}", RDR.Item("nSerie"), RDR.Item("modelo"))
            Else
                arbox.Text = String.Format("{0}   |   {1}", RDR.Item("matricula"), RDR.Item("modelo"))
            End If
        End While

        If curwpn = -1 Then
            Button2.Enabled = False
        End If
        RDR.Close()



        CN.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        selectedEquip = ListBox1.SelectedItem
    End Sub

    Private Sub goBack_Click_1(sender As Object, e As EventArgs) Handles goBack.Click
        Dim equi = New equipamento
        equi.Show()
        Me.Close()
    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index = ListBox1.SelectedIndex
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand("EXERCITO.assignEquipamento")
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@nCC ", GlobalVariables.milSelected.nCC))
        CMD.Parameters.Add(New SqlParameter("@equi ", ListBox1.Items(index).id))
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        If GlobalVariables.typeEqui Then
            MsgBox("Arma adicionada!")
        Else
            MsgBox("Veiculo adicionado!")
        End If
        Dim ae = New assing_equipamento
        ae.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)
        CN.Open()
        CMD = New SqlCommand("EXERCITO.removeEquipamento")
        CMD.Connection = CN
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add(New SqlParameter("@nCC ", GlobalVariables.milSelected.nCC))
        CMD.Parameters.Add(New SqlParameter("@id ", curwpn))
        CMD.ExecuteNonQuery()
        GlobalVariables.porto()
        If GlobalVariables.typeEqui Then
            MsgBox("Arma removida!")
        Else
            MsgBox("Veiculo removido!")
        End If
        Dim ae = New assing_equipamento
        ae.Show()
        Me.Close()
    End Sub
End Class