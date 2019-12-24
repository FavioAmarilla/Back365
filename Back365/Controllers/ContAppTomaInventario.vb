Imports Oracle.DataAccess.Client

Public Class ContAppTomaInventario

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContAppTomaInventario"

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

    Public Function getIdTomaInventario() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT APP_TOMA_INVENTARIO_SQ.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function getNroTomaInventario() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT MAX(NUMERO) FROM APP_TOMA_INVENTARIO")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0) + 1
        Else
            Return 1
        End If
    End Function

    Public Function insertarTomaInventario(identificador As Integer, numero As String, fecha As String, apuntador As String, idEmpresa As Integer,
                                           idSucursal As Integer, idUnidad As Integer, descripcion As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_TOMA_INVENTARIO(IDENTIFICADOR, NUMERO, FECHA, APUNTADOR, ID_EMPRESA, ID_SUCURSAL, ID_UNIDAD, 
                                            DESCRIPCION, FEC_CRE, USR_CRE)
                                            VALUES (:IDENTIFICADOR, :NUMERO, :FECHA, :APUNTADOR, :ID_EMPRESA, :ID_SUCURSAL, :ID_UNIDAD, :DESCRIPCION, 
                                            SYSDATE, 'APPUSR')", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":NUMERO", numero)
            comand.Parameters.Add(":FECHA", fecha)
            comand.Parameters.Add(":APUNTADOR", apuntador)
            comand.Parameters.Add(":ID_EMPRESA", idEmpresa)
            comand.Parameters.Add(":ID_SUCURSAL", idSucursal)
            comand.Parameters.Add(":ID_UNIDAD", idUnidad)
            comand.Parameters.Add(":DESCRIPCION", descripcion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar toma de inventario: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function getIdTomaInvItem() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT APP_TOMA_INV_ITEMS_SQ.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarTomaInvItem(identificador As Integer, idTomaInv As Integer, idProduco As Integer, precioVenta As Integer, costoUnitario As Integer,
                                        cantidad As Double, idProveedor As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_TOMA_INV_ITEMS(IDENTIFICADOR, ID_TOMA_INV, ID_PRODUCTO, PRECIO_VENTA, COSTO_UNITARIO, CANTIDAD, 
                                            TOTAL_PRECIO_VENTA, TOTAL_COSTO, ID_PROVEEDOR, USR_CRE, FEC_CRE)
                                            VALUES (:IDENTIFICADOR, :ID_TOMA_INV, :ID_PRODUCTO, :PRECIO_VENTA, :COSTO_UNITARIO, :CANTIDAD, 
                                            :TOTAL_PRECIO_VENTA, :TOTAL_COSTO, :ID_PROVEEDOR, 'APPUSR', SYSDATE)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_TOMA_INV", idTomaInv)
            comand.Parameters.Add(":ID_PRODUCTO", idProduco)
            comand.Parameters.Add(":PRECIO_VENTA", precioVenta)
            comand.Parameters.Add(":COSTO_UNITARIO", costoUnitario)
            comand.Parameters.Add(":CANTIDAD", cantidad)
            comand.Parameters.Add(":TOTAL_PRECIO_VENTA", precioVenta * cantidad)
            comand.Parameters.Add(":TOTAL_COSTO", costoUnitario * cantidad)
            comand.Parameters.Add(":ID_PROVEEDOR", idProveedor)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al registrar items de toma de inventario: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
