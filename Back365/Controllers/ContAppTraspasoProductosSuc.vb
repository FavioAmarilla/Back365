Imports Oracle.DataAccess.Client

Public Class ContAppTraspasoProductosSuc

    Inherits Conexion
    Dim cmd As New OracleCommand
    Dim titulo As String = "ContAppTraspasoProductosSuc"

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

    Public Function getIdRemision() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT SQ_APP_REMISION.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertar_remision(identificador As Integer, fecha_cre As Date, id_alm_origen As Integer, id_alm_destino As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_REMISION(IDENTIFICADOR, FECHA_CRE, USR_CRE, ESTADO, ID_ALM_ORIGEN, ID_ALM_DESTINO)
                                            VALUES (:IDENTIFICADOR, :FECHA_CRE, :USR_CRE, :ESTADO, :ID_ALM_ORIGEN, :ID_ALM_DESTINO)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":FECHA_CRE", fecha_cre)
            comand.Parameters.Add(":USR_CRE", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":ESTADO", 0)
            comand.Parameters.Add(":ID_ALM_ORIGEN", id_alm_origen)
            comand.Parameters.Add(":ID_ALM_DESTINO", id_alm_destino)

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

    Public Function actualizar_remision(identificador As Integer, id_alm_origen As Integer, id_alm_destino As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_REMISION SET ID_ALM_ORIGEN=:ID_ALM_ORIGEN, ID_ALM_DESTINO=:ID_ALM_DESTINO, FEC_MOD=SYSDATE, USR_MOD=:USR_MOD WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":ID_ALM_ORIGEN", id_alm_origen)
            comand.Parameters.Add(":ID_ALM_DESTINO", id_alm_destino)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function


    Public Function recepcionar_remision(identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_REMISION SET FECHA_RECEPCION=SYSDATE, USR_RECEPCION=:USR_RECEPCION, ESTADO=2, FEC_MOD=SYSDATE, USR_MOD=:USR_MOD WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":USR_RECEPCION", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function cambiar_estado(identificador As Integer, estado As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_REMISION SET ESTADO=:ESTADO, FEC_MOD=SYSDATE, USR_MOD=:USR_MOD WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":ESTADO", estado)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al cambiar estado: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function getIdItemRemision() As Integer
        Dim dt As New DataTable
        dt = consultar("SELECT APP_ITEMS_REMISION_SQ.NEXTVAL FROM DUAL")

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Public Function insertar_items(identificador As Integer, id_remision As Integer, id_producto As Integer, codigo_barras As String, id_proveedor As Integer, id_und_medida As Integer, id_linea As Integer, cantidad As Double, precio_venta As Integer, costo_unitario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("INSERT INTO APP_ITEMS_REMISION(IDENTIFICADOR, ID_REMISION, ID_PRODUCTO, CODIGO_BARRAS, ID_PROVEEDOR, ID_UND_MEDIDA, ID_LINEA, CANTIDAD, PRECIO_VENTA, COSTO_UNITARIO, FEC_CRE, USR_CRE, CANTIDAD_RECEP)
                                            VALUES (:IDENTIFICADOR, :ID_REMISION, :ID_PRODUCTO, :CODIGO_BARRAS, :ID_PROVEEDOR, :ID_UND_MEDIDA, :ID_LINEA, :CANTIDAD, :PRECIO_VENTA, :COSTO_UNITARIO, SYSDATE, :USR_CRE, 0)", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)
            comand.Parameters.Add(":ID_REMISION", id_remision)
            comand.Parameters.Add(":ID_PRODUCTO", id_producto)
            comand.Parameters.Add(":CODIGO_BARRAS", codigo_barras)
            comand.Parameters.Add(":ID_PROVEEDOR", id_proveedor)
            comand.Parameters.Add(":ID_UND_MEDIDA", id_und_medida)
            comand.Parameters.Add(":ID_LINEA", id_linea)
            comand.Parameters.Add(":CANTIDAD", cantidad)
            comand.Parameters.Add(":PRECIO_VENTA", precio_venta)
            comand.Parameters.Add(":COSTO_UNITARIO", costo_unitario)
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

    Public Function actualizar_items(identificador As Integer, id_producto As Integer, codigo_barras As String, id_proveedor As Integer, id_und_medida As Integer, id_linea As Integer, cantidad As Double, precio_venta As Integer, costo_unitario As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_ITEMS_REMISION SET ID_PRODUCTO=:ID_PRODUCTO, CODIGO_BARRAS=:CODIGO_BARRAS, ID_PROVEEDOR=:ID_PROVEEDOR, 
                                            ID_UND_MEDIDA=:ID_UND_MEDIDA, ID_LINEA=:ID_LINEA, CANTIDAD=:CANTIDAD, PRECIO_VENTA=:PRECIO_VENTA, COSTO_UNITARIO=:COSTO_UNITARIO, 
                                            FEC_MOD=SYSDATE, USR_MOD=:USR_MOD
                                             WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":ID_PRODUCTO", id_producto)
            comand.Parameters.Add(":CODIGO_BARRAS", codigo_barras)
            comand.Parameters.Add(":ID_PROVEEDOR", id_proveedor)
            comand.Parameters.Add(":ID_UND_MEDIDA", id_und_medida)
            comand.Parameters.Add(":ID_LINEA", id_linea)
            comand.Parameters.Add(":CANTIDAD", cantidad)
            comand.Parameters.Add(":PRECIO_VENTA", precio_venta)
            comand.Parameters.Add(":COSTO_UNITARIO", costo_unitario)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function cantidad_recep_items(identificador As Integer, cantidad As Double) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("UPDATE APP_ITEMS_REMISION SET CANTIDAD_RECEP=:CANTIDAD_RECEP, FEC_MOD=SYSDATE, USR_MOD=:USR_MOD
                                             WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":CANTIDAD_RECEP", cantidad)
            comand.Parameters.Add(":USR_MOD", FrmMenuPrincipal.USUARIO)
            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al actualizar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

    Public Function eliminar_item(identificador As Integer) As Boolean
        Try
            conectar()
            Dim comand As New OracleCommand("DELETE FROM APP_ITEMS_REMISION WHERE IDENTIFICADOR=:IDENTIFICADOR", cnn)

            comand.Parameters.Add(":IDENTIFICADOR", identificador)

            If comand.ExecuteNonQuery = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ControlMensajes.mensaje("Error al eliminar: " + ex.Message, titulo, "ERR")
            Return False
        Finally
            desconectar()
        End Try
    End Function

End Class
