Imports Oracle.DataAccess.Client

Public Class ContPrUmProducto

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContPrUmProducto"

    Public Function actualizarPrecioVenta(idProducto As Integer, precioVenta As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE PR_UM_PRODUCTO SET PRECIO_VENTA=:PRECIO_VENTA, FEC_MOD=SYSDATE WHERE ID_PRODUCTO=:ID_PRODUCTO", cnn)

            comand.Parameters.Add(":PRECIO_VENTA", precioVenta)
            comand.Parameters.Add(":ID_PRODUCTO", idProducto)

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

End Class
