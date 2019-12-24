Imports Oracle.DataAccess.Client

Public Class ContAppVtaPromociones

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContAppVtaPromociones"

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

    Public Function getIdentificador() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_VTA_PROMOCIONES.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertar(identificador As Integer, idSitio As Integer, idCaja As Integer, monto As Integer, fechaDesde As String, fechaHasta As String, nombre As String, ultNumero As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_VTA_PROMOCIONES(IDENTIFICADOR, ID_SITIO, ID_CAJA, MONTO, ULT_NUMERO, 
                                                NOMBRE, USR_CRE, FEC_CRE, FECHA_DESDE, FECHA_HASTA)
                                                VALUES (:IDENTIFICADOR, :ID_SITIO, :ID_CAJA, :MONTO, :ULT_NUMERO, :NOMBRE, :USR_CRE, SYSDATE, 
                                                TO_DATE(:FECHA_DESDE, 'dd/mm/yyyy'), TO_DATE(:FECHA_HASTA, 'dd/mm/yyyy'))", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_SITIO", idSitio)
            comand.Parameters.Add(":ID_CAJA", idCaja)
            comand.Parameters.Add(":MONTO", monto)
            comand.Parameters.Add(":ULT_NUMERO", ultNumero)
            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":FECHA_DESDE", fechaDesde)
            comand.Parameters.Add(":FECHA_HASTA", fechaHasta)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizar(identificador As Integer, fechaDesde As String, fechaHasta As String, nombre As String, descripcion As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_VTA_PROMOCIONES SET MONTO=:MONTO, FECHA_DESDE=TO_DATE(:FECHA_DESDE, 'dd/mm/yyyy'), FECHA_HASTA=TO_DATE(:FECHA_HASTA, 'dd/mm/yyyy'), 
                                            NOMBRE=:NOMBRE, USR_MOD=:USR_MOD, FEC_MOD=SYSDATE
                                            WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":FECHA_DESDE", fechaDesde)
            comand.Parameters.Add(":FECHA_HASTA", fechaHasta)
            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
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
