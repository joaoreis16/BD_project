Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class GlobalVariables

    Public Shared Property baseSelected As Base

    Public Shared Property milSelected As Militar
    Public Shared Property inserting As Boolean
    Public Shared Property typeEqui As Boolean
    Public Shared Property misSelected As Missoes

    Public Shared Property listaMilitares As New List(Of Militar)()

    Public Shared Property add2pelotao As Boolean = False
    Public Shared Property add2missao As Boolean = False

    Public Shared Property pelotao_id As Integer

    Public Shared Function porto()
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim dbServer = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbName = "p9g6"
        Dim userName = "p9g6"
        Dim userPass = "-99745397@BD"

        GlobalVariables.listaMilitares.Clear()

        Dim RDR As SqlDataReader

        Dim SQA As SqlDataAdapter

        CN = New SqlConnection("data Source = " + dbServer + " ;" +
                               "initial Catalog = " + dbName + ";" +
                               "uid = " + userName + ";" +
                               "password = " + userPass)


        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM EXERCITO.militar_info"
        CN.Open()
        RDR = CMD.ExecuteReader

        While RDR.Read
            Dim M As New Militar
            M.nCC = Convert.ToString(RDR.Item("nCC"))
            M.Pnome = RDR.Item("Pnome")
            M.Unome = RDR.Item("Unome")
            M.morada = RDR.Item("morada")
            M.email = RDR.Item("email")
            M.dNasc = Convert.ToString(RDR.Item("dNasc"))
            M.dInsc = Convert.ToString(RDR.Item("dInsc"))
            M.tel = RDR.Item("tel")
            M.nacionalidade = RDR.Item("nacionalidade")
            M.nMissoes = Convert.ToString(RDR.Item("nMissoes"))
            M.ramo = Convert.ToString(RDR.Item("ramo"))
            If IsDBNull(RDR.Item("base")) Then
                M.base = Nothing
            Else
                M.base = Convert.ToString(RDR.Item("base"))
            End If
            M.cargo = RDR.Item("cargo")
            M.tipo = RDR.Item("tipo")
            M.estado = RDR.Item("estado")

            M.missao = RDR.Item("EmMissao")

            If IsDBNull(RDR.Item("pelotao")) Then
                M.pelotao = Nothing
            Else
                M.pelotao = RDR.Item("pelotao")
            End If

            GlobalVariables.listaMilitares.Add(M)
        End While
        CN.Close()
    End Function


End Class
