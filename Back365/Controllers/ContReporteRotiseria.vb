Imports DevExpress
Imports Oracle.DataAccess.Client

Public Class ContReporteRotiseria

    Inherits Conexion
    Dim cmd As New OracleCommand

    Public Function listar(ByVal campo As String, ByVal desde As Date, ByVal hasta As Date) As DataTable
        Try
            conectar()
            cmd = New OracleCommand("SELECT 
                                      MVS.ID_PRODUCTO AS ID_PRODUCTO,
                                      PR_PRODUCTOS.DESCRIPCION AS DESCRIPCION,
                                      TO_DATE(MVS." + campo + ",'dd/MM/yy') AS FECHA,
                                      SUM(CANTIDAD) AS CANTIDAD,  
                                      MVS.COSTO_UNITARIO AS PRECIO_COSTO,
                                      MVS.PRECIO_UNITARIO AS PRECIO_VENTA,
                                      ROUND(SUM(MVS.CANTIDAD * MVS.COSTO_UNITARIO)) AS TOTAL_COSTO,
                                      ROUND(SUM(MVS.CANTIDAD * MVS.PRECIO_UNITARIO)) AS TOTAL_VENTA
                                    FROM STK_ITEMS_MV_STOCK MVS
                                      LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = MVS.ID_PRODUCTO 
                                    WHERE MVS.ID_TRANSACCION=9160 
                                      AND TRUNC(MVS." + campo + ") >= TO_DATE('" + desde + "','dd/MM/yy') 
                                      AND TRUNC(MVS." + campo + ") <= TO_DATE('" + hasta + "','dd/MM/yy')
                                    GROUP BY MVS.ID_PRODUCTO,
                                      PR_PRODUCTOS.DESCRIPCION,
                                      TO_DATE(MVS." + campo + ",'dd/MM/yy'),
                                      MVS.PRECIO_UNITARIO, 
                                      MVS.COSTO_UNITARIO
                                    ORDER BY TO_DATE(MVS." + campo + ",'dd/MM/yy') ASC")

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
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("listar: " + ex.Message, "Reporte de Mov. en Rotiseria", Utils.DefaultBoolean.Default)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

End Class