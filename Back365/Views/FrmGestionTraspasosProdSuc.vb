Imports DevExpress.XtraReports.UI

Public Class FrmGestionTraspasosProdSuc

    Dim titulo As String = "Traspaso"
    Dim dtItems As New DataTable
    Dim contAppTraspasoProductosSuc As New ContAppTraspasoProductosSuc

    Dim idEmpresa As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idSitio As Integer = 0
    Dim idAlmOrigen As Integer = 0
    Dim idAlmDestino As Integer = 0
    Dim idRemision As Integer = 0
    Dim estado As Integer = 0

    Private Sub FrmGestionTraspasosProdSuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crearCursor()
    End Sub

    Sub limpiar()
        idAlmOrigen = 0
        idAlmDestino = 0
        idRemision = 0
        estado = 0
        txtRemision.Text = ""
        txtDestino.Text = ""
        txtOrigen.Text = ""
        txtFecha.Text = ""
        txtFechaRecepcion.Text = ""
        txtUsrRecepcion.Text = ""

        dtItems = Nothing
        gridItems.DataSource = dtItems
    End Sub

    Sub crearCursor()
        dtItems = New DataTable
        dtItems.Columns.Add("ID_ITEM")
        dtItems.Columns.Add("ID_PRODUCTO")
        dtItems.Columns.Add("CODIGO_BARRAS")
        dtItems.Columns.Add("ID_PROVEEDOR")
        dtItems.Columns.Add("ID_UND_MEDIDA")
        dtItems.Columns.Add("ID_LINEA")
        dtItems.Columns.Add("DESCRIPCION")
        dtItems.Columns.Add("CANTIDAD", GetType(Double))
        dtItems.Columns.Add("COSTO_UNITARIO")
        dtItems.Columns.Add("PRECIO_VENTA")
        dtItems.Columns.Add("NUEVO")
        dtItems.Columns.Add("CANTIDAD_RECEP", GetType(Double))

        gridItems.DataSource = dtItems
    End Sub

    Sub vistas(verificador As String)
        If verificador = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmGestionTraspasosProdSuc")
            frm.ShowDialog()
        End If

        If verificador = "RE" Then
            Dim frm As New FrmVistaAppRemisionesTraspaso
            frm.setFrmActivo("FrmGestionTraspasosProdSuc")
            frm.setFrmGestionTraspasosProdSuc(Me)
            frm.ShowDialog()
        End If
        If verificador = "ALD" Then
            Dim frm As New FrmVistaAppRemisionesTraspaso
            frm.setFrmActivo("FrmTraspasoProductosSucALD")
            frm.setFrmGestionTraspasosProdSuc(Me)
            frm.ShowDialog()
        End If
        If verificador = "ALO" Then
            Dim frm As New FrmVistaAppRemisionesTraspaso
            frm.setFrmActivo("FrmTraspasoProductosSucALO")
            frm.setFrmGestionTraspasosProdSuc(Me)
            frm.ShowDialog()
        End If
    End Sub

    Public Sub getRemision(id As Integer)
        Dim dt As New DataTable
        dt = contAppTraspasoProductosSuc.consultar("SELECT FECHA_CRE, ID_ALM_ORIGEN, ID_ALM_DESTINO, ESTADO, FECHA_RECEPCION, USR_RECEPCION, IDENTIFICADOR
                                                    FROM APP_REMISION WHERE IDENTIFICADOR = " & CStr(id))

        txtFecha.Text = CStr(dt.Rows(0).Item(0))
        getAlmacen(CInt(dt.Rows(0).Item(1)), "ORIGEN")
        getAlmacen(CInt(dt.Rows(0).Item(2)), "DESTINO")
        estado = CInt(dt.Rows(0).Item(3))

        If IsDBNull(dt.Rows(0).Item(4)) = False Then
            txtFechaRecepcion.Text = CStr(dt.Rows(0).Item(4))
        End If
        If IsDBNull(dt.Rows(0).Item(5)) = False Then
            txtUsrRecepcion.Text = CStr(dt.Rows(0).Item(5))
        End If
        idRemision = CInt(dt.Rows(0).Item(6))
        txtRemision.Text = CStr(idRemision)

        If estado = 0 Then
            txtEstado.Text = "PENDIENTE"
            GridView1.Columns("CANTIDAD_RECEP").Visible = False
        End If
        If estado = 1 Then
            txtEstado.Text = "CONFIRMADO"
            GridView1.Columns("CANTIDAD_RECEP").Visible = False
        End If
        If estado = 2 Then
            txtEstado.Text = "RECIBIDO"
            GridView1.Columns("CANTIDAD_RECEP").Visible = True
        End If
        If estado = 3 Then
            txtEstado.Text = "ANULADO"
            GridView1.Columns("CANTIDAD_RECEP").Visible = True
        End If

        Dim items As New DataTable
        items = contAppTraspasoProductosSuc.consultar("SELECT IT.IDENTIFICADOR AS ID_ITEM, IT.ID_PRODUCTO, IT.CODIGO_BARRAS, IT.ID_PROVEEDOR, IT.ID_UND_MEDIDA, 
                                                    IT.ID_LINEA, PR_PRODUCTOS.DESCRIPCION, IT.CANTIDAD, IT.COSTO_UNITARIO, IT.PRECIO_VENTA, 'N' AS NUEVO, IT.CANTIDAD_RECEP
                                                    FROM APP_ITEMS_REMISION IT
                                                    INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                                    WHERE IT.ID_REMISION =  " & CStr(idRemision))

        gridItems.DataSource = items

    End Sub


    Public Sub getAlmacen(id As String, verificador As String)
        Dim dt As New DataTable
        dt = contAppTraspasoProductosSuc.consultar("Select IDENTIFICADOR, DESCRIPCION, ID_EMPRESA, ID_UNIDAD, ID_SITIO FROM STK_ALMACENES WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            If verificador = "ORIGEN" Then
                idAlmOrigen = CInt(dt.Rows(0).Item(0))
                txtOrigen.Text = CStr(dt.Rows(0).Item(1))
                idEmpresa = CInt(dt.Rows(0).Item(2))
                idUnidad = CInt(dt.Rows(0).Item(3))
                idSitio = CInt(dt.Rows(0).Item(4))
                txtOrigen.Focus()
            End If
            If verificador = "DESTINO" Then
                idAlmDestino = CInt(dt.Rows(0).Item(0))
                txtDestino.Text = CStr(dt.Rows(0).Item(1))
                idEmpresa = CInt(dt.Rows(0).Item(2))
                idUnidad = CInt(dt.Rows(0).Item(3))
                idSitio = CInt(dt.Rows(0).Item(4))
                txtDestino.Focus()
            End If

        Else
            ControlMensajes.mensaje("ALMACEN no DEFINIDO", titulo, "WAR")
        End If
    End Sub

    Public Sub getProducto(codigo As String)
        Dim dt As New DataTable
        dt = contAppTraspasoProductosSuc.consultar("SELECT PR.IDENTIFICADOR, PR.CODIGO_BARRAS, PR.ID_PROVEEDOR, PR.ID_UNIDAD_MEDIDA, PR.ID_LINEA,
                                            PR.DESCRIPCION, PR.PRECIO_VENTA, ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO, 0)
                                            FROM PR_PRODUCTOS PR
                                            INNER JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                                            WHERE CODIGO_BARRAS= '" & codigo & "'")

        If dt.Rows.Count > 0 Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle >= 0 Then
                GridView1.SetRowCellValue(rowhandle, "ID_PRODUCTO", dt.Rows(0).Item(0))
                GridView1.SetRowCellValue(rowhandle, "CODIGO_BARRAS", dt.Rows(0).Item(1))
                GridView1.SetRowCellValue(rowhandle, "ID_PROVEEDOR", dt.Rows(0).Item(2))
                GridView1.SetRowCellValue(rowhandle, "ID_UND_MEDIDA", dt.Rows(0).Item(3))
                GridView1.SetRowCellValue(rowhandle, "ID_LINEA", dt.Rows(0).Item(4))
                GridView1.SetRowCellValue(rowhandle, "DESCRIPCION", dt.Rows(0).Item(5))
                GridView1.SetRowCellValue(rowhandle, "PRECIO_VENTA", dt.Rows(0).Item(6))
                GridView1.SetRowCellValue(rowhandle, "COSTO_UNITARIO", dt.Rows(0).Item(7))
                GridView1.SetRowCellValue(rowhandle, "CANTIDAD", 0)
                GridView1.SetRowCellValue(rowhandle, "NUEVO", "S")
                GridView1.SetRowCellValue(rowhandle, "ID_ITEM", 0)


                GridView1.FocusedColumn = GridView1.Columns("DESCRIPCION")

            End If
        Else
            ControlMensajes.mensaje("Producto no definido", titulo, "WAR")
        End If
    End Sub

    Function validarCampos() As Boolean

        If idAlmOrigen <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar almacen de origen", titulo, "WAR")
            txtOrigen.Focus()
            Return False
        End If
        If idAlmDestino <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar almacen de destino", titulo, "WAR")
            txtDestino.Focus()
            Return False
        End If
        If txtFecha.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha no puede estar vacio", titulo, "WAR")
            txtFecha.Focus()
            Return False
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe agregar items a la transaccion", titulo, "WAR")
            txtFecha.Focus()
            Return False
        End If

        For i As Integer = 0 To GridView1.RowCount - 1
            Dim idItem As Integer = contAppTraspasoProductosSuc.getIdItemRemision()
            Dim cantidad As Double = CDbl(GridView1.GetRowCellValue(i, "CANTIDAD"))

            If cantidad <= 0 Then
                ControlMensajes.mensaje("Cantidad debe ser mayor a cero(0)", titulo, "WAR")
                Return False
            End If
        Next

        Return True
    End Function


    Sub actualizarRemision()
        If validarCampos() Then

            If estado = 1 Then
                ControlMensajes.mensaje("La remision ya esta confirmada", titulo, "WAR")
                Return
            End If
            If estado = 2 Then
                ControlMensajes.mensaje("La remision ya ha sido recibida", titulo, "WAR")
                Return
            End If
            If estado = 3 Then
                ControlMensajes.mensaje("La remision esta anulada", titulo, "WAR")
                Return
            End If

            If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
                ControlMensajes.mensaje("Operacion no confirmada", titulo, "INF")
            End If

            Dim fecha As Date = txtFecha.Text

            If contAppTraspasoProductosSuc.actualizar_remision(idRemision, idAlmOrigen, idAlmDestino) Then

                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim idItem As Integer = CInt(GridView1.GetRowCellValue(i, "ID_ITEM"))
                    Dim idProducto As Integer = CInt(GridView1.GetRowCellValue(i, "ID_PRODUCTO"))
                    Dim codigoBarras As String = CStr(GridView1.GetRowCellValue(i, "CODIGO_BARRAS"))
                    Dim idProveedor As Integer = CInt(GridView1.GetRowCellValue(i, "ID_PROVEEDOR"))
                    Dim idUndMedida As Integer = CInt(GridView1.GetRowCellValue(i, "ID_UND_MEDIDA"))
                    Dim idLinea As Integer = CInt(GridView1.GetRowCellValue(i, "ID_LINEA"))
                    Dim cantidad As Double = CDbl(GridView1.GetRowCellValue(i, "CANTIDAD"))
                    Dim precioVenta As Integer = CInt(GridView1.GetRowCellValue(i, "PRECIO_VENTA"))
                    Dim costoUnitario As Integer = CInt(GridView1.GetRowCellValue(i, "COSTO_UNITARIO"))
                    Dim nuevo As String = CStr(GridView1.GetRowCellValue(i, "NUEVO"))

                    If nuevo = "N" Then
                        If contAppTraspasoProductosSuc.actualizar_items(idItem, idProducto, codigoBarras, idProveedor, idUndMedida, idLinea, cantidad, precioVenta, costoUnitario) = False Then
                            ControlMensajes.mensaje("Item de transaccion no actualizado" & CStr(i + 1), titulo, "WAR")
                            Return
                        End If
                    Else
                        idItem = contAppTraspasoProductosSuc.getIdItemRemision()
                        If contAppTraspasoProductosSuc.insertar_items(idItem, idRemision, idProducto, codigoBarras, idProveedor, idUndMedida, idLinea, cantidad, precioVenta, costoUnitario) = False Then
                            ControlMensajes.mensaje("Item de transaccion no registrado" & CStr(i + 1), titulo, "WAR")
                            Return
                        End If
                    End If
                Next


                ControlMensajes.mensaje("Remision actualizada", titulo, "INF")
                getRemision(idRemision)
                limpiar()
                txtRemision.Focus()
            Else
                ControlMensajes.mensaje("Remision no actualizada", titulo, "WAR")
            End If

        End If
    End Sub


    Private Sub eliminarItem()
        If estado = 1 Then
            ControlMensajes.mensaje("La remision ya esta confirmada", titulo, "WAR")
            Return
        End If
        If estado = 2 Then
            ControlMensajes.mensaje("La remision ya ha sido recibida", titulo, "WAR")
            Return
        End If
        If estado = 3 Then
            ControlMensajes.mensaje("La remision esta anulada", titulo, "WAR")
            Return
        End If

        If ControlMensajes.msj_confirmacion("Deseas quitar el item", titulo) = False Then
            ControlMensajes.mensaje("Item no eliminado", titulo, "WAR")
            Return
        End If

        Dim index As Integer = GridView1.FocusedRowHandle
        Dim id As Integer = CInt(GridView1.GetRowCellValue(index, "ID_ITEM"))


        If id <= 0 Then
            GridView1.DeleteRow(index)
        Else
            If contAppTraspasoProductosSuc.eliminar_item(id) Then
                ControlMensajes.mensaje("Item eliminado", titulo, "INF")
                GridView1.DeleteRow(index)
            Else
                ControlMensajes.mensaje("Item no eliminado", titulo, "WAR")
            End If
        End If
    End Sub

    Private Sub confirmar()
        If estado = 1 Then
            ControlMensajes.mensaje("La remision ya esta confirmada", titulo, "WAR")
            Return
        End If
        If estado = 2 Then
            ControlMensajes.mensaje("La remision ya ha sido recibida", titulo, "WAR")
            Return
        End If
        If estado = 3 Then
            ControlMensajes.mensaje("La remision esta anulada", titulo, "WAR")
            Return
        End If
        If ControlMensajes.msj_confirmacion("Deseas confirmar la remision", titulo) = False Then
            ControlMensajes.mensaje("Remision no confirmada", titulo, "WAR")
            Return
        End If

        If generarMvStock(9220, "EG") Then
            If contAppTraspasoProductosSuc.cambiar_estado(idRemision, 1) Then
                ControlMensajes.mensaje("Remision confirmada", titulo, "INF")
                getRemision(idRemision)
                crearReporte()
                limpiar()
            Else
                ControlMensajes.mensaje("Remision no confirmada", titulo, "WAR")
            End If
        End If
    End Sub

    Private Sub anular()
        If estado = 2 Then
            ControlMensajes.mensaje("La remision ya ha sido recibida", titulo, "WAR")
            Return
        End If
        If estado = 3 Then
            ControlMensajes.mensaje("La remision esta anulada", titulo, "WAR")
            Return
        End If
        If ControlMensajes.msj_confirmacion("Deseas anular la remision", titulo) = False Then
            ControlMensajes.mensaje("Remision no anulada", titulo, "WAR")
            Return
        End If

        If generarMvStock(9221, "IN") Then
            If contAppTraspasoProductosSuc.cambiar_estado(idRemision, 3) Then
                ControlMensajes.mensaje("Remision anulada", titulo, "INF")
                limpiar()
            Else
                ControlMensajes.mensaje("Remision no anulada", titulo, "WAR")
            End If
        End If
    End Sub

    Private Sub eliminar_filas_vacias()
        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "ID_PRODUCTO")) Then
                GridView1.DeleteRow(i)
            Else
                If CStr(GridView1.GetRowCellValue(i, "ID_PRODUCTO")) = "" Then
                    GridView1.DeleteRow(i)
                End If
            End If
        Next
    End Sub

    Private Function existeStock(idAlmacen As Integer, idProducto As Integer) As Boolean
        Dim stkStockProd As New ContStkStockProd
        Dim dt As New DataTable

        dt = stkStockProd.consultar("SELECT IDENTIFICADOR FROM STK_STOCK_PROD WHERE ID_ALMACEN=" & CStr(idAlmacen) & " AND ID_PRODUCTO=" & CStr(idProducto))

        Return dt.Rows.Count > 0
    End Function

    Private Function generarMvStock(idTransaccion As Integer, accion As String) As Boolean
        Dim contStkMovimStock As New ContStkMovimStock
        Dim contStkStockProd As New ContStkStockProd

        Dim idMovimiento As Integer = contStkMovimStock.idMovimStock()
        If contStkMovimStock.insertarMovimStock(idMovimiento, idEmpresa, idUnidad, Now.ToString("dd/MM/yyyy HH:mm:ss"), "00", idSitio, FrmMenuPrincipal.USUARIO, FrmMenuPrincipal.USUARIO, idRemision, "ST", idTransaccion, "N", "") = False Then
            ControlMensajes.mensaje("Movimiento de stock no registrado", titulo, "WAR")
            Return False
        End If

        Dim idItemMovimiento As Integer = contStkMovimStock.idItemMovimStock()
        For i As Integer = 0 To GridView1.RowCount - 1
            Dim idProducto As Integer = CInt(GridView1.GetRowCellValue(i, "ID_PRODUCTO"))
            Dim codigoBarras As String = CStr(GridView1.GetRowCellValue(i, "CODIGO_BARRAS"))
            Dim idProveedor As Integer = CInt(GridView1.GetRowCellValue(i, "ID_PROVEEDOR"))
            Dim idUndMedida As Integer = CInt(GridView1.GetRowCellValue(i, "ID_UND_MEDIDA"))
            Dim idLinea As Integer = CInt(GridView1.GetRowCellValue(i, "ID_LINEA"))
            Dim cantidad As Double = CDbl(GridView1.GetRowCellValue(i, "CANTIDAD"))
            Dim precioVenta As Integer = CInt(GridView1.GetRowCellValue(i, "PRECIO_VENTA"))
            Dim costoUnitario As Integer = CInt(GridView1.GetRowCellValue(i, "COSTO_UNITARIO"))

            If contStkMovimStock.insertarItemsMovimStock(idItemMovimiento, idMovimiento, idEmpresa, idUnidad, idTransaccion, idAlmOrigen, accion, idProducto, idUndMedida, cantidad, cantidad, costoUnitario, precioVenta, precioVenta, costoUnitario, codigoBarras, Now.ToString("dd/MM/yyyy HH:mm:ss")) = False Then
                ControlMensajes.mensaje("Item de stock no registrado: " & CStr(i + 1), titulo, "WAR")
                Return False
            End If

            If existeStock(idAlmOrigen, idProducto) Then
                If contStkStockProd.actualizarExistencia(cantidad, idProducto, idAlmOrigen, accion) = False Then
                    ControlMensajes.mensaje("Stock no actualizado: " & CStr(i + 1), titulo, "WAR")
                    Return False
                End If
            Else
                Dim idStock As Integer = contStkStockProd.getIdStock()
                If contStkStockProd.insertarExistencia(idStock, idEmpresa, idUnidad, idAlmOrigen, idProducto, idUndMedida, cantidad) = False Then
                    ControlMensajes.mensaje("Stock no registrado: " & CStr(i + 1), titulo, "WAR")
                    Return False
                End If
            End If

        Next

        Return True

    End Function

    Private Sub crearReporte()
        If ControlMensajes.msj_confirmacion("Impirmir reporte?", titulo) = False Then
            Return
        End If

        Dim report As New RptAppTraspasoProdSuc
        Dim estadRpt As String = ""

        If estado = 0 Then
            estadRpt = "PENDIENTE"
        End If
        If estado = 1 Then
            estadRpt = "CONFIRMADO"
        End If
        If estado = 2 Then
            estadRpt = "RECIBIDO"
        End If
        If estado = 3 Then
            estadRpt = "ANULADO"
        End If

        report.DataSource = gridItems.DataSource

        report.Parameters("destino").Value = txtDestino.Text
        report.Parameters("estado").Value = estadRpt
        report.Parameters("fecha_registro").Value = txtFecha.Text
        report.Parameters("fecha_recepcion").Value = txtFechaRecepcion.Text
        report.Parameters("numero").Value = txtRemision.Text
        report.Parameters("origen").Value = txtOrigen.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy HH:mm:ss")

        report.Parameters("destino").Visible = False
        report.Parameters("estado").Visible = False
        report.Parameters("fecha_registro").Visible = False
        report.Parameters("numero").Visible = False
        report.Parameters("origen").Visible = False
        report.Parameters("fecha_recepcion").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub txtRemisionn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemision.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtRemision.Text IsNot "" Then
                If idRemision <= 0 Then
                    getRemision(CInt(txtRemision.Text))
                Else
                    txtOrigen.Focus()
                End If
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("RE")
        End If
    End Sub

    Private Sub btnRemisiones_Click(sender As Object, e As EventArgs) Handles btnRemisiones.Click
        vistas("RE")
    End Sub

    Private Sub txtOrigen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrigen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtOrigen.Text IsNot "" Then
                txtDestino.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("ALO")
        End If
    End Sub

    Private Sub btnOrigen_Click(sender As Object, e As EventArgs) Handles btnOrigen.Click
        vistas("ALO")
    End Sub


    Private Sub txtDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDestino.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDestino.Text IsNot "" Then
                txtFecha.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("ALD")
        End If
    End Sub

    Private Sub btnDestino_Click(sender As Object, e As EventArgs) Handles btnDestino.Click
        vistas("ALD")
    End Sub

    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFecha.Text = "  /  /" Then
            Else
                txtFechaRecepcion.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FE")
        End If
    End Sub

    Private Sub txtFechaRecepcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaRecepcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUsrRecepcion.Focus()
        End If
    End Sub

    Private Sub txtUsrRecepcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsrRecepcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.Focus()
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            SendKeys.Send("{Enter}")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        eliminar_filas_vacias()
        actualizarRemision()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelar la operacion", titulo) Then
            limpiar()
        Else
            ControlMensajes.mensaje("Operacion no cancelada", titulo, "INF")
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        eliminarItem()

    End Sub

    Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) Then
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO") IsNot "" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                    Return
                Else
                    If CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) > 0 Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                        Return
                    End If
                End If
            End If

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS")) Then
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS") IsNot "" Then
                    getProducto(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS"))
                End If
            End If
        End If

        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("PR")
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DESCRIPCION")) Then
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DESCRIPCION") IsNot "" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) Then
                ControlMensajes.mensaje("Debe selecciconar un producto", titulo, "WAR")
                Return
            Else
                If CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) = "" Then
                    ControlMensajes.mensaje("Debe selecciconar un producto", titulo, "WAR")
                    Return
                Else
                    If CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) <= 0 Then
                        ControlMensajes.mensaje("Debe selecciconar un producto", titulo, "WAR")
                        Return
                    End If
                End If
            End If

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CANTIDAD")) Then
                ControlMensajes.mensaje("cantidad debe ser mayor a cero(0)", titulo, "WAR")
                Return
            Else
                If CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CANTIDAD")) = "" Then
                    ControlMensajes.mensaje("cantidad debe ser mayor a cero(0)", titulo, "WAR")
                    Return
                Else
                    If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CANTIDAD")) <= 0 Then
                        ControlMensajes.mensaje("cantidad debe ser mayor a cero(0)", titulo, "WAR")
                        Return
                    End If
                End If
            End If

            If GridView1.FocusedRowHandle = GridView1.RowCount - 1 Then
                eliminar_filas_vacias()
                GridView1.AddNewRow()
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                SendKeys.Send("{Enter}")
            Else
                GridView1.FocusedRowHandle = GridView1.FocusedRowHandle + 1
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                SendKeys.Send("{Enter}")
            End If

        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        eliminar_filas_vacias()
        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = GridView1.RowCount - 1
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        confirmar()
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        anular()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If idRemision <= 0 Or GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
        Else
            crearReporte()
        End If
    End Sub



End Class