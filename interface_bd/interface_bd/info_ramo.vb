Imports System.Data.SqlClient

Public Class info_ramo
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim listaBases As New List(Of Base)()
    Friend Shared baseSelected As Base

    Private Sub goBack_Click(sender As Object, e As EventArgs) Handles goBack.Click
        Dim ramos = New ramos
        ramos.Show()
        Me.Close()
    End Sub


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)
        Dim info = New info_militar
        info.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)
        Dim info = New info_militar
        info.Show()
        Me.Close()
    End Sub

    Private Sub info_ramo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbName = "p9g6"
        Dim userName = "p9g6"
        Dim userPass = "-99745397@BD"

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)

        CMD = New SqlCommand
        CMD.Connection = CN
        'Debug.Print(ramos.id)
        If (ramos.id = 1) Then
            CMD.CommandText = "SELECT * FROM EXERCITO.ramo JOIN EXERCITO.tipo_ramo ON ramo.tipo = tipo_ramo.id  WHERE design = 'Força Terrestre'"
            brasao.ImageLocation = "..\imagens\FT.png"

        ElseIf (ramos.id = 2) Then
            CMD.CommandText = "SELECT * FROM EXERCITO.ramo JOIN EXERCITO.tipo_ramo ON ramo.tipo = tipo_ramo.id  WHERE design = 'Força Aérea'"
            brasao.ImageLocation = "..\imagens\FA.png"

        ElseIf (ramos.id = 3) Then
            CMD.CommandText = "SELECT * FROM EXERCITO.ramo JOIN EXERCITO.tipo_ramo ON ramo.tipo = tipo_ramo.id  WHERE design = 'Força Marítima'"
            brasao.ImageLocation = "..\imagens\FM.png"

        End If

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        Dim R As New Ramo
        While RDR.Read
            R.id = Convert.ToString(RDR.Item("id"))
            R.sigla = RDR.Item("sigla")
            R.mote = RDR.Item("mote")
            R.contacto = RDR.Item("contacto")
            R.morada = RDR.Item("morada")
            R.dia = Convert.ToString(RDR.Item("dia"))
            R.fax = RDR.Item("fax")
            tipoRamo.Text = RDR.Item("design")
        End While

        RDR.Close()

        TBcontacto.Text = R.contacto
        TBsigla.Text = R.sigla
        TBmote.Text = R.mote
        TBcontacto.Text = R.contacto
        TBmorada.Text = R.morada
        TBdia.Text = R.dia
        TBfax.Text = R.fax

        ' BASE MILITARES DE DETERMINADO RAMO
        CMD.CommandText = String.Format("SELECT * FROM EXERCITO.base_militar 
                                        JOIN EXERCITO.base_ramo 
                                        ON base_militar.id = base_ramo.idBase
                                        WHERE idRamo = {0}", ramos.id)

        RDR = CMD.ExecuteReader
        ramoLB1.Items.Clear()
        Dim count As Integer = 0
        While RDR.Read
            Dim B As New Base
            B.id = Convert.ToString(RDR.Item("id"))
            B.nome = RDR.Item("nome")
            B.contacto = RDR.Item("contacto")
            B.morada = RDR.Item("morada")
            'B.data_inicio = Convert.ToString(RDR.Item("data_inicio"))
            'B.data_fim = Convert.ToString(RDR.Item("data_fim"))
            B.maxMilitares = Convert.ToString(RDR.Item("maxMilitares"))

            listaBases.Add(B)
            ramoLB1.Items.Add(B)
            count = count + 1
        End While

        totalTxtBox.Text = count
        CN.Close()

    End Sub

    Private Sub homeBttn_Click(sender As Object, e As EventArgs) Handles homeBttn.Click
        Dim home = New Form1
        home.Show()
        Me.Close()
    End Sub

    Private Sub ramoLB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ramoLB1.DoubleClick
        Dim index = ramoLB1.SelectedIndex
        Debug.Print(index)
        GlobalVariables.baseSelected = listaBases(index)
        Dim info = New info_base
        info.Show()
        Me.Close()
    End Sub
End Class