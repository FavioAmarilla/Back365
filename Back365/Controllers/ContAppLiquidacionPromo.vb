Imports Oracle.DataAccess.Client

Public Class ContAppLiquidacionPromo

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContAppLiquidacionPromo"

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
            ControlMensajes.mensaje("Error al realizar consulta: " + ex.Message, titulo, "ERR")
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function identificador() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT APP_LIQUIDACION_PROMO_SQ.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarLiquidacion(identificador As Integer, fechaLiquid As Date, idPromocion As Integer, cantidadVendida As Double,
                                        totalPagado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_LIQUIDACIONES_PROMO(IDENTIFICADOR, FECHA_LIQUID, ID_PROMOCION, CANTIDAD_VENDIDA,
                                            TOTAL_PAGADO, FEC_CRE, USR_CRE)
                                            VALUES (:IDENTIFICADOR, TO_DATE(:FECHA_LIQUID, 'dd/mm/yyyy'), :ID_PROMOCION, :CANTIDAD_VENDIDA,
                                            :TOTAL_PAGADO, SYSDATE, 'APPUSR')", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":FECHA_LIQUID", CStr(fechaLiquid))
            comand.Parameters.Add(":ID_PROMOCION", idPromocion)
            comand.Parameters.Add(":CANTIDAD_VENDIDA", cantidadVendida)
            comand.Parameters.Add(":TOTAL_PAGADO", totalPagado)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar liquidacion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
