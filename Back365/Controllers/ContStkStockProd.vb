Imports Oracle.DataAccess.Client

Public Class ContStkStockProd

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContStkStockProd"

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

    Public Function getIdStock() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_STOCK.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertarExistencia(identificador As Integer, idempresa As Integer, idUnidad As Integer, idAlmacen As Integer, idProducto As Integer, idUndMedida As Integer, existencia As Double) As Boolean
        Try
            conectar()
            Dim sql As String = "INSERT INTO STK_STOCK_PROD(IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD, ID_ALMACEN, ID_PRODUCTO, ID_UND_MEDIDA, EXISTENCIA, USR_CRE, FEC_CRE)
                                    VALUES(:IDENTIFICADOR, :ID_EMPRESA, :ID_UNIDAD, :ID_ALMACEN, :ID_PRODUCTO, :ID_UND_MEDIDA, :EXISTENCIA, :USR_CRE, SYSDATE)"

            Dim comand As New OracleCommand(sql, cnn)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_EMPRESA", idempresa)
            comand.Parameters.Add(":ID_UNIDAD", idUnidad)
            comand.Parameters.Add(":ID_ALMACEN", idAlmacen)
            comand.Parameters.Add(":ID_PRODUCTO", idProducto)
            comand.Parameters.Add(":ID_UND_MEDIDA", idUndMedida)
            comand.Parameters.Add(":EXISTENCIA", existencia)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al reistrar existencia: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function actualizarExistencia(cantidad As Double, id_producto As Integer, id_almacen As Integer, accion As String) As Boolean
        Try
            conectar()
            Dim sql As String = ""

            If accion = "EG" Then
                sql = "UPDATE STK_STOCK_PROD SET EXISTENCIA=EXISTENCIA-:CANTIDAD WHERE ID_PRODUCTO=:ID_PRODUCTO AND ID_ALMACEN=:ID_ALMACEN"
            End If
            If accion = "IN" Then
                sql = "UPDATE STK_STOCK_PROD SET EXISTENCIA=EXISTENCIA+:CANTIDAD WHERE ID_PRODUCTO=:ID_PRODUCTO AND ID_ALMACEN=:ID_ALMACEN"
            End If

            Dim comand As New OracleCommand(sql, cnn)
            comand.Parameters.Add(":CANTIDAD", cantidad)
            comand.Parameters.Add(":ID_PRODUCTO", id_producto)
            comand.Parameters.Add(":ID_ALMACEN", id_almacen)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar existencia: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


End Class
