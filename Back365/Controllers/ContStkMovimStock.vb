Imports Oracle.DataAccess.Client

Public Class ContStkMovimStock

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContStkMovimStock"

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

    Public Function idMovimStock() As Integer
        Try
            conectar()
            cmd = New OracleCommand("SELECT SQ_STK_MOVIM.NEXTVAL FROM DUAL")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New OracleDataAdapter(cmd)
                da.Fill(dt)
                Return dt.Rows(0).Item(0)
            Else
                Return 0
            End If

        Catch ex As Exception
            ControlMensajes.mensaje("Error al obtener idMovimStock: " + ex.Message, titulo, "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertarMovimStock(identificador As Integer, id_empresa As Integer, id_unidad As Integer, fecha As String, vr_situacion As String,
                                       id_sitio As Integer, usuario As String, usr_cre As String, numero As String, vr_origen_trans As String,
                                       id_transaccion As Integer, reversado As String, descripcion As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO STK_MOVIM_STOCK(IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD, FECHA, 
                                        VR_SITUACION, ID_SITIO, USUARIO, USR_CRE, FEC_CRE, NUMERO, VR_ORIGEN_TRANS, 
                                        ID_TRANSACCION, REVERSADO, DESCRIPCION)
                                        VALUES(:IDENTIFICADOR, :ID_EMPRESA, :ID_UNIDAD, TO_DATE(:FECHA, 'dd/MM/yyyy hh24:mi:ss'), :VR_SITUACION, :ID_SITIO, 
                                        :USUARIO, :USR_CRE, SYSDATE, :NUMERO, :VR_ORIGEN_TRANS, :ID_TRANSACCION, :REVERSADO, :DESCRIPCION)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_EMPRESA", id_empresa)
            comand.Parameters.Add(":ID_UNIDAD", id_unidad)
            comand.Parameters.Add(":FECHA", fecha)
            comand.Parameters.Add(":VR_SITUACION", vr_situacion)
            comand.Parameters.Add(":ID_SITIO", id_sitio)
            comand.Parameters.Add(":USUARIO", usuario)
            comand.Parameters.Add(":USR_CRE", usr_cre)
            comand.Parameters.Add(":NUMERO", numero)
            comand.Parameters.Add(":VR_ORIGEN_TRANS", vr_origen_trans)
            comand.Parameters.Add(":ID_TRANSACCION", id_transaccion)
            comand.Parameters.Add(":REVERSADO", reversado)
            comand.Parameters.Add(":DESCRIPCION", descripcion)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al insertar movimiento de stock: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function idItemMovimStock() As Integer
        Try
            conectar()
            cmd = New OracleCommand("SELECT SQ_ITEMS_STKM.NEXTVAL FROM DUAL")
            cmd.CommandType = CommandType.Text
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New OracleDataAdapter(cmd)
                da.Fill(dt)
                Return dt.Rows(0).Item(0)
            Else
                Return 0
            End If

        Catch ex As Exception
            ControlMensajes.mensaje("Error al obtener idItemMovimStock: " + ex.Message, titulo, "ERR")
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function insertarItemsMovimStock(identificador As Integer, id_movimiento As Integer, id_empresa As Integer, id_unidad As Integer, id_transaccion As Integer,
                                            id_almacen As Integer, vr_accion As String, id_producto As Integer, id_und_medida As Integer, cantidad As Double,
                                            cantidad_ub As Double, precio_unitario_ub As Integer, costo_unitario_ub As Integer, precio_unitario As Integer,
                                            costo_unitario As Integer, codigo_barra As String, fecha As String) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO STK_ITEMS_MV_STOCK(IDENTIFICADOR, ID_MOVIMIENTO, ID_EMPRESA, ID_UNIDAD, ID_TRANSACCION,
                                                ID_ALMACEN,VR_ACCION, ID_PRODUCTO, ID_UND_MEDIDA, CANTIDAD, USR_CRE, FEC_CRE, CANTIDAD_UB, 
                                                PRECIO_UNITARIO_UB, COSTO_UNITARIO_UB, PRECIO_UNITARIO, COSTO_UNITARIO, CODIGO_BARRA, 
                                                ID_ESTADO, ID_MOTIVO, FECHA)
                                                VALUES (:IDENTIFICADOR, :ID_MOVIMIENTO, :ID_EMPRESA, :ID_UNIDAD, :ID_TRANSACCION,
                                                :ID_ALMACEN, :VR_ACCION, :ID_PRODUCTO, :ID_UND_MEDIDA, :CANTIDAD, :USR_CRE, SYSDATE, :CANTIDAD_UB, 
                                                :PRECIO_UNITARIO_UB, :COSTO_UNITARIO_UB, :PRECIO_UNITARIO, :COSTO_UNITARIO, :CODIGO_BARRA, 
                                                :ID_ESTADO, :ID_MOTIVO, TO_DATE(:FECHA, 'dd/MM/yyyy hh24:mi:ss'))", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_MOVIMIENTO", id_movimiento)
            comand.Parameters.Add(":ID_EMPRESA", id_empresa)
            comand.Parameters.Add(":ID_UNIDAD", id_unidad)
            comand.Parameters.Add(":ID_TRANSACCION", id_transaccion)
            comand.Parameters.Add(":ID_ALMACEN", id_almacen)
            comand.Parameters.Add(":VR_ACCION", vr_accion)
            comand.Parameters.Add(":ID_PRODUCTO", id_producto)
            comand.Parameters.Add(":ID_UND_MEDIDA", id_und_medida)
            comand.Parameters.Add(":CANTIDAD", cantidad)
            comand.Parameters.Add(":USR_CRE", "APPUSR")
            comand.Parameters.Add(":CANTIDAD_UB", cantidad_ub)
            comand.Parameters.Add(":PRECIO_UNITARIO_UB", precio_unitario_ub)
            comand.Parameters.Add(":COSTO_UNITARIO_UB", costo_unitario_ub)
            comand.Parameters.Add(":PRECIO_UNITARIO", precio_unitario)
            comand.Parameters.Add(":COSTO_UNITARIO", costo_unitario)
            comand.Parameters.Add(":CODIGO_BARRA", codigo_barra)
            comand.Parameters.Add(":ID_ESTADO", 0)
            comand.Parameters.Add(":ID_MOTIVO", 0)
            comand.Parameters.Add(":FECHA", fecha)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al insertar item de movimiento de stock: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
