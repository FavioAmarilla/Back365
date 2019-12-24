Imports Oracle.DataAccess.Client


Public Class ContAppGastosDiarios

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContAppGastosDiarios"

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
            ControlMensajes.mensaje("Error al realizar consulta: " & ex.Message, titulo, "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function getIdentificador() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_APP_GASTOS_DIARIOS.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertar(identificador As Integer, idSitio As Integer, concepto As String, fecha As String, total As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_GASTOS_DIARIOS(IDENTIFICADOR, ID_SITIO, CONCEPTO, FECHA, FEC_CRE, USR_CRE, TOTAL)
                                            VALUES(:IDENTIFICADOR, :ID_SITIO, :CONCEPTO, TO_DATE(:FECHA,'dd/MM/yyyy'), SYSDATE, :USR_CRE, :TOTAL)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_SITIO", idSitio)
            comand.Parameters.Add(":CONCEPTO", concepto)
            comand.Parameters.Add(":FECHA", fecha)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":TOTAL", total)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al insertar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(identificador As Integer, concepto As String, total As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_GASTOS_DIARIOS SET CONCEPTO=:CONCEPTO, FEC_MOD=SYSDATE, USR_MOD=:USR_MOD, TOTAL=:TOTAL
                                                WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":CONCEPTO", concepto)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":TOTAL", total)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
