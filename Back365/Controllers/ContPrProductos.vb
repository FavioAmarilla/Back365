Imports Oracle.DataAccess.Client

Public Class ContPrProductos

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContPrProductos"

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

    Public Function actualizarPrecioVenta(identificador As Integer, precioVenta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE PR_PRODUCTOS SET PRECIO_VENTA=:PRECIO_VENTA, FEC_MOD=SYSDATE WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":PRECIO_VENTA", precioVenta)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar precio de venta: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function actualizarParm(identificador As Integer, descripcion As String, idLinea As Integer, idMarca As Integer, idPresentacion As Integer, idProveedor As Integer, activo As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE PR_PRODUCTOS SET DESCRIPCION=:DESCRIPCION, ID_LINEA=:ID_LINEA, ID_MARCA=:ID_MARCA,
                            ID_PRESENTACION=:ID_PRESENTACION, ID_PROVEEDOR=:ID_PROVEEDOR, ACTIVO=:ACTIVO, FEC_MOD=SYSDATE
                            WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":DESCRIPCION", descripcion)
            comand.Parameters.Add(":ID_LINEA", idLinea)
            comand.Parameters.Add(":ID_MARCA", idMarca)
            comand.Parameters.Add(":ID_PRESENTACION", idPresentacion)
            comand.Parameters.Add(":ID_PROVEEDOR", idProveedor)
            comand.Parameters.Add(":ACTIVO", activo)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar producto: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
