Imports Oracle.DataAccess.Client

Public Class ContFndParmEmpresas

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContFndParmEmpresas"

    Public Function consultar(sql As String) As DataTable
        Try
            conectar()
            cmd = New OracleCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New OracleDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ControlMensajes.mensaje("Error al realizar consulta", titulo, "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

End Class
