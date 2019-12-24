Imports Oracle.DataAccess.Client

Public Class ContAppPromociones

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContAppPromociones"

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

    Public Function idPromocion() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT APP_PROMOCIONES_SQ.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarPromocion(identificador As Integer, descripcion As String, idProveedor As Integer, fechaDesde As Date, fechaHasta As Date, activo As String,
                                      liquidado As String, confirmado As String, idEmpresa As Integer, idUnidad As Integer, idSitio As Integer, vrTipoPromo As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_PROMOCIONES(IDENTIFICADOR, DESCRIPCION, ID_PROVEEDOR, FECHA_DESDE, FECHA_HASTA, ACTIVO, 
                                            LIQUIDADO, FEC_CRE, USR_CRE, CONFIRMADO, ID_EMPRESA, ID_UNIDAD, ID_SITIO, CERRADO, VR_TIPO_PROMO)
                                            VALUES (:IDENTIFICADOR, :DESCRIPCION, :ID_PROVEEDOR, TO_DATE(:FECHA_DESDE, 'dd/mm/yyyy'), 
                                            TO_DATE(:FECHA_HASTA, 'dd/mm/yyyy'), :ACTIVO, :LIQUIDADO, SYSDATE, 'APPUSR', :CONFIRMADO, :ID_EMPRESA, 
                                            :ID_UNIDAD, :ID_SITIO, 'N', :VR_TIPO_PROMO)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":DESCRIPCION", descripcion)
            comand.Parameters.Add(":ID_PROVEEDOR", idProveedor)
            comand.Parameters.Add(":FECHA_DESDE", CStr(fechaDesde))
            comand.Parameters.Add(":FECHA_HASTA", CStr(fechaHasta))
            comand.Parameters.Add(":ACTIVO", activo)
            comand.Parameters.Add(":LIQUIDADO", liquidado)
            comand.Parameters.Add(":CONFIRMADO", confirmado)
            comand.Parameters.Add(":ID_EMPRESA", idEmpresa)
            comand.Parameters.Add(":ID_UNIDAD", idUnidad)
            comand.Parameters.Add(":ID_SITIO", idSitio)
            comand.Parameters.Add(":VR_TIPO_PROMO", vrTipoPromo)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function abrirPromocion(identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_PROMOCIONES SET ACTIVO='S', FEC_CRE=SYSDATE, USR_CRE='APPUSR' WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al abrir promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function cerrarPromocion(identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_PROMOCIONES SET CERRADO='S', FEC_MOD=SYSDATE, USR_MOD='APPUSR' WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al cerrar promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizarPromocion(identificador As Integer, idSitio As Integer, descripcion As String, idProveedor As Integer, fechaDesde As String, fechaHasta As String, vrTipoPromo As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_PROMOCIONES SET ID_SITIO=:ID_SITIO, DESCRIPCION=:DESCRIPCION, ID_PROVEEDOR=:ID_PROVEEDOR,
                                            FECHA_DESDE=TO_DATE(:FECHA_DESDE, 'dd/mm/yyyy'), FECHA_HASTA=TO_DATE(:FECHA_HASTA, 'dd/mm/yyyy'),
                                            FEC_MOD=SYSDATE, USR_MOD='APPUSR', VR_TIPO_PROMO=:VR_TIPO_PROMO WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":ID_SITIO", idSitio)
            comand.Parameters.Add(":DESCRIPCION", descripcion)
            comand.Parameters.Add(":ID_PROVEEDOR", idProveedor)
            comand.Parameters.Add(":FECHA_DESDE", fechaDesde)
            comand.Parameters.Add(":FECHA_HASTA", fechaHasta)
            comand.Parameters.Add(":VR_TIPO_PROMO", vrTipoPromo)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function confirmarPromocion(identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_PROMOCIONES SET CONFIRMADO='S', FEC_MOD=SYSDATE, USR_MOD='APPUSR' 
                                                WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al confirmar promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function idItemPromocion() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT APP_ITEMS_PROMOCION_SQ.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarItemsPromocion(identificador As Integer, idPromocion As Integer, idProducto As Integer, precioActual As Integer, costoUnitario As Integer,
                                           precioPromo As Integer, diferenciaPrecio As Integer, porcDiferencia As Double, difReconocer As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_ITEMS_PROMOCION(IDENTIFICADOR, ID_PROMOCION, ID_PRODUCTO, PRECIO_ACTUAL, COSTO_UNITARIO, 
                                            PRECIO_PROMO, DIFERENCIA_PRECIO, PORC_DIFERENCIA, DIF_RECONOCER, FEC_CRE, USR_CRE)
                                            VALUES (:IDENTIFICADOR, :ID_PROMOCION, :ID_PRODUCTO, :PRECIO_ACTUAL, :COSTO_UNITARIO, 
                                            :PRECIO_PROMO, :DIFERENCIA_PRECIO, :PORC_DIFERENCIA, :DIF_RECONOCER, SYSDATE, 'APPUSR')", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_PROMOCION", idPromocion)
            comand.Parameters.Add(":ID_PRODUCTO", idProducto)
            comand.Parameters.Add(":PRECIO_ACTUAL", precioActual)
            comand.Parameters.Add(":COSTO_UNITARIO", costoUnitario)
            comand.Parameters.Add(":PRECIO_PROMO", precioPromo)
            comand.Parameters.Add(":DIFERENCIA_PRECIO", diferenciaPrecio)
            comand.Parameters.Add(":PORC_DIFERENCIA", porcDiferencia)
            comand.Parameters.Add(":DIF_RECONOCER", difReconocer)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar items de promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizarItemsPromocion(identificador As Integer, precioActual As Integer, precioPromo As Integer, diferenciaPrecio As Integer, porcDiferencia As Double) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_ITEMS_PROMOCION SET PRECIO_ACTUAL=:PRECIO_ACTUAL, PRECIO_PROMO=:PRECIO_PROMO, DIFERENCIA_PRECIO=:DIFERENCIA_PRECIO, 
                                             PORC_DIFERENCIA=:PORC_DIFERENCIA WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":PRECIO_ACTUAL", precioActual)
            comand.Parameters.Add(":PRECIO_PROMO", precioPromo)
            comand.Parameters.Add(":DIFERENCIA_PRECIO", diferenciaPrecio)
            comand.Parameters.Add(":PORC_DIFERENCIA", porcDiferencia)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar items de promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function eliminarItemPromocion(identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("DELETE FROM APP_ITEMS_PROMOCION WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al eliminar item de promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function cerrarItemsPromocion(identificador As Integer, cantidadVendida As Double, difReconocer As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_ITEMS_PROMOCION SET CANTIDAD_VENDIDA=:CANTIDAD_VENDIDA, DIF_RECONOCER=:DIF_RECONOCER,
                                             USR_MOD='APPUSR', FEC_MOD=SYSDATE WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":CANTIDAD_VENDIDA", cantidadVendida)
            comand.Parameters.Add(":DIF_RECONOCER", difReconocer)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al cerrar item de promocion: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
