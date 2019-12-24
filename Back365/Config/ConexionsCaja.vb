Imports System.IO
Imports Oracle.DataAccess.Client

Public Class ConexionesCaja

    Private titulo As String = "ConexionesCaja"
    Private cadena As String = ""
    Public cnn As OracleConnection

    Private DB_HOST As String = ""
    Private DB_USER As String = "appusr"
    Private DB_PASS As String = "appusr"

    Public Sub setDB_HOST(host As String)
        DB_HOST = host
    End Sub

    Public Sub conectar()
        Try
            cadena = "Data Source=" & DB_HOST & ";User Id=" & DB_USER & ";Password=" & DB_PASS & ";"
            cnn = New OracleConnection(cadena)
            cnn.Open()
        Catch ex As Exception
            ControlMensajes.mensaje("Error al conectarse a Base de Datos: " + ex.Message, titulo, "ERR")
        End Try
    End Sub


    Public Sub desconectar()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al desconectarse de base de datos: " + ex.Message, titulo, "ERR")
        End Try
    End Sub

End Class
