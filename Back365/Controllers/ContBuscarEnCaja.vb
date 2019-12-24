Imports DevExpress
Imports Oracle.DataAccess.Client


Public Class ContBuscarEnCaja

    Inherits conexion
    Dim cmd As New OracleCommand

    Public Function listar() As DataTable
        Try
            conectar()
            cmd = New OracleCommand("SELECT IDENTIFICADOR, DESCRIPCION, CODIGO_BARRAS, TO_CHAR(PRECIO_VENTA, '9999,999,999') AS PRECIO_VENTA, " +
                                    "COALESCE(BUSCAR_EN_CAJA,'N') AS BUSCAR_EN_CAJA FROM PR_PRODUCTOS WHERE BUSCAR_EN_CAJA = 'S' ORDER BY FEC_MOD DESC")
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
            XtraEditors.XtraMessageBox.Show("Error al listar Productos: " + ex.Message, "func_buscar_en_caja", Utils.DefaultBoolean.Default)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function buscar(ByVal codigo As String) As DataTable
        Try
            conectar()
            cmd = New OracleCommand("SELECT IDENTIFICADOR, SUBSTR(DESCRIPCION,0,60) AS DESCRIPCION, CODIGO_BARRAS, " +
                                    "TO_CHAR(PRECIO_VENTA, '9999,999,999') AS PRECIO_VENTA, COALESCE(BUSCAR_EN_CAJA,'N') AS BUSCAR_EN_CAJA " +
                                    "FROM PR_PRODUCTOS WHERE CODIGO_BARRAS LIKE '" + codigo + "%'")
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
            XtraEditors.XtraMessageBox.Show("Error al buscar el Producto: " + ex.Message, "func_buscar_en_caja", Utils.DefaultBoolean.Default)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function update(ByVal valor As String, ByVal id As Integer)
        Try
            conectar()
            If valor = "S" Then
                cmd = New OracleCommand("UPDATE PR_PRODUCTOS SET BUSCAR_EN_CAJA = 'N', FEC_MOD = SYSDATE WHERE IDENTIFICADOR = " + Convert.ToString(id) + "")
            ElseIf valor = "N" Then
                cmd = New OracleCommand("UPDATE PR_PRODUCTOS SET BUSCAR_EN_CAJA = 'S', FEC_MOD = SYSDATE WHERE IDENTIFICADOR = " + Convert.ToString(id) + "")
            End If

            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("Error al actualizar el Producto: " + ex.Message, "func_buscar_en_caja", Utils.DefaultBoolean.Default)
        End Try
    End Function
End Class
