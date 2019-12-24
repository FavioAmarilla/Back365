Imports Oracle.DataAccess.Client

Public Class ContAppPromocionesProv

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContAppPromocionesProv"

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

    Public Function getIdPromocion() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_APP_PROMOCIONES_PROV.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarPromo(identificador As Integer, idSitio As Integer, idProveedor As Integer, fechaDesde As String, fechaHasta As String, nombre As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_PROMOCIONES_PROV(IDENTIFICADOR, ID_SITIO, ID_PROVEEDOR, FECHA_DESDE, FECHA_HASTA, NOMBRE, USR_CRE, FEC_CRE)
                                                VALUES (:IDENTIFICADOR, :ID_SITIO, :ID_PROVEEDOR, TO_DATE(:FECHA_DESDE, 'dd/mm/yyyy'), TO_DATE(:FECHA_HASTA, 'dd/mm/yyyy'), 
                                                :NOMBRE, :USR_CRE, SYSDATE)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_SITIO", idSitio)
            comand.Parameters.Add(":ID_PROVEEDOR", idProveedor)
            comand.Parameters.Add(":FECHA_DESDE", fechaDesde)
            comand.Parameters.Add(":FECHA_HASTA", fechaHasta)
            comand.Parameters.Add(":NOMBRE", nombre)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)

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



    Public Function getIdItemPromo() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_APP_ITEMS_PROM_PROV.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarItemPromo(identificador As Integer, idPromocion As Integer, idProducto As Integer, precio_venta As Integer, costo_unitario As Integer, cantidad As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_ITEMS_PROM_PROV(IDENTIFICADOR, ID_PROMOCION, ID_PRODUCTO, PRECIO_VENTA, COSTO_UNITARIO, CANTIDAD, USR_CRE, FEC_CRE)
                                                VALUES (:IDENTIFICADOR, :ID_PROMOCION, :ID_PRODUCTO, :PRECIO_VENTA, :COSTO_UNITARIO, :CANTIDAD, :USR_CRE, SYSDATE)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_PROMOCION", idPromocion)
            comand.Parameters.Add(":ID_PRODUCTO", idProducto)
            comand.Parameters.Add(":PRECIO_VENTA", precio_venta)
            comand.Parameters.Add(":COSTO_UNITARIO", costo_unitario)
            comand.Parameters.Add(":CANTIDAD", cantidad)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar item: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
