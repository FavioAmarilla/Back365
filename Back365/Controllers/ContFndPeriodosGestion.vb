Imports Oracle.DataAccess.Client

Public Class ContFndPeriodosGestion

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContFndPeriodosGestion"

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

    Public Function getIdPeriodoGestion() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_FND_PERIODOS.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insrtarPeriodoGestion(identificador As Integer, id_empresa As Integer, nombre As String, anho As Integer, trimestre As Integer, fecha_desde As Date, fecha_hasta As Date, vr_situacion As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO FND_PERIODOS_GESTION(IDENTIFICADOR, ID_EMPRESA, NOMBRE, CODIGO, ANHO, TRIMESTRE, 
                                            FECHA_DESDE, FECHA_HASTA, VR_SITUACION, FEC_CRE, USR_CRE)
                                            VALUES (:IDENTIFICADOR, :ID_EMPRESA, :NOMBRE, :CODIGO, :ANHO, :TRIMESTRE, 
                                            TO_DATE(:FECHA_DESDE, 'dd/mm/yyyy'), TO_DATE(:FECHA_HASTA, 'dd/mm/yyyy'), 
                                            :VR_SITUACION, SYSDATE, 'APPUSR')", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_EMPRESA", id_empresa)
            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":CODIGO", nombre)
            comand.Parameters.Add(":ANHO", anho)
            comand.Parameters.Add(":TRIMESTRE", trimestre)
            comand.Parameters.Add(":FECHA_DESDE", CStr(fecha_desde))
            comand.Parameters.Add(":FECHA_HASTA", CStr(fecha_hasta))
            comand.Parameters.Add(":VR_SITUACION", vr_situacion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar periodo de gestion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
