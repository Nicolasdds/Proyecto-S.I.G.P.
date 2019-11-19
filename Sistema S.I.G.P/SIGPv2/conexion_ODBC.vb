Imports System.Data.Odbc
Module conexion_ODBC

    Public comando As New OdbcCommand
    Public conexion As New OdbcConnection
    Public usuario As String
    Public pass As String

    Public Sub conectar()
        Dim conectar As String
        Try
            conectar = "FileDsn=" & Application.StartupPath & "/odbchc.dsn;UID=" & usuario & " ;PWD=" & pass & ""
            conexion.ConnectionString = conectar
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectarse con la Base de Datos")
            conexion.Close()
        End Try
    End Sub

    Public Sub Desconectar()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Module








































































'HIPERCODE DEVELOPINGS. ALL RIGHTS RESERVED. ™, ® & COPYRIGHT © 2019, MADE IN URUGUAY.

