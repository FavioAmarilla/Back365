Imports Oracle.DataAccess.Client

Public Class ContPrAudCambiosPrec

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContPrAudCambiosPrec"

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
        dt = consultar("SELECT SQ_PR_AUD_CAMBIOS_PREC.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    'Public Function insertarAudCambio(identificador As Integer, idProducto As Integer, idUnidadMedida As Integer, vrTipoCambio As String, usuario As String,
    '                                      precioNuevo As Integer, fechaAplicacion As Date, precioAnterior As Integer) As Boolean
    Public Function insertarAudCambio(idProducto As Integer, idUnidadMedida As Integer, vrTipoCambio As String, precioNuevo As String, fechaAplicacion As String, precioAnterior As Integer,
                                      porcRecargo As Double, programa As String, codigoBarras As String, precioSugerido As String, idProveedor As Integer, aplicado As String,
                                      idEmpresa As Integer, idUnidad As Integer, idSitio As Integer, identificador As Integer, fechaAplicacionPrecio As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO PR_AUD_CAMBIOS_PREC(ID_PRODUCTO, ID_UNIDAD_MEDIDA, VR_TIPO_CAMBIO, PRECIO_NUEVO, FECHA_APLICACION, PRECIO_ANTERIOR,
                                            PORC_RECARGO, PROGRAMA, CODIGO_BARRA, PRECIO_SUGERIDO, ID_PROVEEDOR, APLICADO, ID_EMPRESA, ID_UNIDAD, ID_SITIO, IDENTIFICADOR,
                                            FECHA_APLIC_PRECIO, FECHA, USUARIO)
                                            VALUES (:ID_PRODUCTO, :ID_UNIDAD_MEDIDA, :VR_TIPO_CAMBIO, :PRECIO_NUEVO, TO_DATE(:FECHA_APLICACION, 'dd/mm/yyyy hh24:mi:ss'), :PRECIO_ANTERIOR,
                                            :PORC_RECARGO, :PROGRAMA, :CODIGO_BARRAS, :PRECIO_SUGERIDO, :ID_PROVEEDOR, :APLICADO, :ID_EMPRESA, :ID_UNIDAD, :ID_SITIO, :IDENTIFICADOR,
                                            TO_DATE(:FECHA_APLIC_PRECIO, 'dd/mm/yyyy hh24:mi:ss'), SYSDATE, :USUARIO)", cnn)

            comand.Parameters.Add(":ID_PRODUCTO", idProducto)
            comand.Parameters.Add(":ID_UNIDAD_MEDIDA", idUnidadMedida)
            comand.Parameters.Add(":VR_TIPO_CAMBIO", vrTipoCambio)
            comand.Parameters.Add(":PRECIO_NUEVO", precioNuevo)
            comand.Parameters.Add(":FECHA_APLICACION", fechaAplicacion)
            comand.Parameters.Add(":PRECIO_ANTERIOR", precioAnterior)
            comand.Parameters.Add(":PORC_RECARGO", porcRecargo)
            comand.Parameters.Add(":PROGRAMA", programa)
            comand.Parameters.Add(":CODIGO_BARRA", codigoBarras)
            comand.Parameters.Add(":PRECIO_SUGERIDO", precioSugerido)
            comand.Parameters.Add(":ID_PROVEEDOR", idProveedor)
            comand.Parameters.Add(":APLICADO", aplicado)
            comand.Parameters.Add(":ID_EMPRESA", idEmpresa)
            comand.Parameters.Add(":ID_UNIDAD", idUnidad)
            comand.Parameters.Add(":ID_SITIO", idSitio)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":FECHA_APLIC_PRECIO", fechaAplicacionPrecio)
            comand.Parameters.Add(":USUARIO", FrmMenuPrincipal.USUARIO)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar auditoria de cambio de precio: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function
End Class
