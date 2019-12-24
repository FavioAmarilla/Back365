Imports System.IO
Imports Oracle.DataAccess.Client

Public Class Conexion

    Private titulo As String = "Conexion"
    Private cadena As String = ""
    Public cnn As OracleConnection

    Private DB_HOST As String = ""
    Private DB_USER As String = ""
    Private DB_PASS As String = ""

    Public Sub conectar()
        Try
            parametrosConexion()
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

    Public Sub parametrosConexion()
        Try
            Dim directorio As String = My.Application.Info.DirectoryPath & "\Back365.txt"
            Dim objReader As New StreamReader(directorio)
            Dim sLine As String = ""
            Dim arrText As New ArrayList()

            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                End If
            Loop Until sLine Is Nothing
            objReader.Close()

            DB_HOST = "(DESCRIPTION =
                            (ADDRESS = (PROTOCOL = TCP)(HOST = " & arrText(0).ToString & ")(PORT = 1521))
                            (CONNECT_DATA =
                              (SERVER = DEDICATED)
                              (SERVICE_NAME = XE)
                            )
                          )
                        "
            DB_USER = arrText(1).ToString
            DB_PASS = arrText(2).ToString
        Catch ex As Exception
            ControlMensajes.mensaje("Error al obtener archivo de configuracion: " + ex.Message, titulo, "ERR")
        End Try
    End Sub

End Class
