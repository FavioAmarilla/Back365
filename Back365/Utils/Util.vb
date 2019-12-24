Public Class Util

    Public Function ping(ip As String) As Boolean
        Try
            If My.Computer.Network.Ping(ip) Then
                Return True
            Else
                ControlMensajes.mensaje("Sin conexion a la caja", "Ping", "ERR")
                Return False
            End If
        Catch ex As Net.NetworkInformation.PingException
            MessageBox.Show("Ocurrió el siguiente error:" & vbCrLf & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            MessageBox.Show("Ocurrió el siguiente error:" & vbCrLf & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function eliminarEspacios(cadena As String) As String
        Return cadena.Replace(" ", "") = ""
    End Function

End Class
