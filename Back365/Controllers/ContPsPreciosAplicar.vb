Imports Oracle.DataAccess.Client

Public Class ContPsPreciosAplicar

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContPsPreciosAplicar"

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

    Public Function identificador() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT APP_PROMOCIONES_SQ.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarPrecioAplicar(identificador As Integer, idEmpresa As Integer, idUnidad As Integer, idSitio As Integer, idProducto As Integer,
                                          idUnidadMedida As Integer, idCaja As Integer, precioNuevo As Integer, fechaAplicacion As String,
                                          precioAnterior As Integer, codigoBarras As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO PS_PRECIOS_A_APLICAR(IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD, ID_SITIO, ID_PRODUCTO, 
                                            ID_UNIDAD_MEDIDA, ID_CAJA, USR_CRE, FEC_CRE, PRECIO_NUEVO, FECHA_APLICACION, PRECIO_ANTERIOR, CODIGO_BARRA, 
                                            PRECIO_SUGERIDO, ID_APLICACION)
                                            VALUES (:IDENTIFICADOR, :ID_EMPRESA, :ID_UNIDAD, :ID_SITIO, :ID_PRODUCTO, :ID_UNIDAD_MEDIDA, :ID_CAJA, 
                                            'APPUSR', SYSDATE, :PRECIO_NUEVO, TO_DATE(:FECHA_APLICACION, 'dd/mm/yyyy hh24:mi:ss'), 
                                            :PRECIO_ANTERIOR, :CODIGO_BARRA, 'N', 123456)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_EMPRESA", idEmpresa)
            comand.Parameters.Add(":ID_UNIDAD", idUnidad)
            comand.Parameters.Add(":ID_SITIO", idSitio)
            comand.Parameters.Add(":ID_PRODUCTO", idProducto)
            comand.Parameters.Add(":ID_UNIDAD_MEDIDA", idUnidadMedida)
            comand.Parameters.Add(":ID_CAJA", idCaja)
            comand.Parameters.Add(":PRECIO_NUEVO", precioNuevo)
            comand.Parameters.Add(":FECHA_APLICACION", CStr(fechaAplicacion))
            comand.Parameters.Add(":PRECIO_ANTERIOR", precioAnterior)
            comand.Parameters.Add(":CODIGO_BARRA", codigoBarras)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar precio a aplicar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
