Imports Oracle.DataAccess.Client

Public Class ContTcControlCaja

    Inherits ConexionesCaja
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContTcControlCaja"

    Public Function consultar(sql As String, IP As String) As DataTable
        Try
            setDB_HOST(IP)
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
            ControlMensajes.mensaje("Error al realizar consulta: " + ex.Message, titulo, "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function cerrarControl(identificador As Integer, cerrado As String, arqueado As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE TC_CONTROL_CAJA SET CERRADO=:CERRADO, ARQUEADO=:ARQUEADO, FEC_MOD=SYSDATE WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":CERRADO", cerrado)
            comand.Parameters.Add(":CERRADO", arqueado)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al cerrar control de caja: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
