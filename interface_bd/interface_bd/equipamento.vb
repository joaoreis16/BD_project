Imports System.Data.SqlClient

Public Class equipamento
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaEquipamento As New List(Of Equi)()
    Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
    Dim dbName = "p9g6"
    Dim userName = "p9g6"
    Dim userPass = "-99745397@BD"
    Private Sub equipamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        CMD = New SqlCommand
        CMD.Connection = CN

        If escolha_equi.arma Then
            missao.Visible = False
            TBmissao.Visible = False
            CMD.CommandText = "SELECT * FROM EXERCITO.equipamento JOIN EXERCITO.arma ON  id = idEqui JOIN EXERCITO.tipo_arma ON tipo_arma.id = arma.idTipo "
        Else
            Label5.Text = "Matrícula"
            CMD.CommandText = "SELECT * 
                                FROM EXERCITO.equipamento 

                                JOIN EXERCITO.veiculo 
                                ON  id = idEqui 

                                JOIN EXERCITO.tipo_veiculo 
                                ON tipo_veiculo.id = veiculo.idTipo 

                                LEFT JOIN EXERCITO.missao 
                                ON missao.id = veiculo.idMissao 

                                LEFT JOIN EXERCITO.utiliza_equipamento 
                                ON utiliza_equipamento.equipamento = equipamento.id

                                LEFT JOIN EXERCITO.militar
                                ON utiliza_equipamento.soldado = militar.nCC"


        End If
        CN.Open()

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBox2.Items.Clear()
        While RDR.Read
            Dim equipamento As New Equi
            If escolha_equi.arma Then
                equipamento.nSerie_matricula = Convert.ToString(RDR.Item("nSerie"))
            Else
                equipamento.nSerie_matricula = Convert.ToString(RDR.Item("matricula"))
                If IsDBNull(RDR.Item("nome")) Then
                    equipamento.missao = "null"
                Else
                    equipamento.missao = Convert.ToString(RDR.Item("nome"))
                End If
            End If
            equipamento.tipo = RDR.Item("tipo")
            equipamento.modelo = RDR.Item("modelo")

            listaEquipamento.Add(equipamento)
            ListBox1.Items.Add(equipamento)
        End While

        CN.Close()
    End Sub

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim escolha = New escolha_equi
        escolha.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index = ListBox1.SelectedIndex
        Dim Equi As Equi = listaEquipamento(index)
        TBmodelo.Text = Equi.modelo
        TBserie.Text = Equi.nSerie_matricula
        TBtipo.Text = Equi.tipo
        If Not escolha_equi.arma Then
            TBmissao.Text = Equi.missao
        End If
    End Sub
End Class