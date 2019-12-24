Public Class FrmGenerarListaProd

    Dim contPrProductos As New ContPrProductos
    Dim dtItems As New DataTable
    Dim titulo As String = "Listado de productos"

    Dim idSucursal As Integer = 0


    Private Sub FrmGenerarListaProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crear_cursor()
        agregarFila()
    End Sub

    Sub limpiar()
        txtSucursal.Text = ""
        gridProductos.DataSource = Nothing

        idSucursal = 0
    End Sub

    Sub agregarFila()
        eliminarFilasVacias()
        GridView1.AddNewRow()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        Else
            GridView1.FocusedRowHandle = 0
        End If
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
    End Sub

    Private Sub eliminarFilasVacias()
        Try
            For i As Integer = 0 To GridView1.RowCount - 1
                If IsDBNull(GridView1.GetRowCellValue(i, "CODIGO_BARRAS")) Then
                    GridView1.DeleteRow(i)
                Else
                    If GridView1.GetRowCellValue(i, "CODIGO_BARRAS") = "" Then
                        GridView1.DeleteRow(i)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Sub vistas(verificador As String)
        If verificador = "SI" Then
            Dim frm As New FrmVistaFndSitios
            frm.setFrmGenerarListaProd(Me)
            frm.setFrmActivo("FrmGenerarListaProd")
            frm.ShowDialog()
        End If

        If verificador = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmGenerarListaProd")
            frm.setFrmGenerarListaProd(Me)
            frm.ShowDialog()
        End If
    End Sub

    Public Sub getSucursal(id As String)
        Dim dt As New DataTable
        dt = ContPrProductos.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idSucursal = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
            txtSucursal.Focus()
        End If
    End Sub

    Private Sub crear_cursor()
        dtItems = New DataTable
        dtItems.Columns.Add("CODIGO_BARRAS")
        dtItems.Columns.Add("DESCRIPCION")
        dtItems.Columns.Add("COSTO_UNITARIO")
        dtItems.Columns.Add("PRECIO_VENTA")
        dtItems.Columns.Add("CANTIDAD")

        gridProductos.DataSource = dtItems
    End Sub

    Public Sub getProducto(codigoBarras As String)

        Dim idProducto As Integer = 0
        Dim precioVenta As Integer = 0
        Dim costounitario As Integer = 0

        Dim cantidad As Integer = getCantidad(codigoBarras)
        codigoBarras = getCodigoBarras(codigoBarras)

        If codigoBarras.Replace(" ", "") = "" Then
            Return
        End If

        If GridView1.RowCount <= 0 Then
            crear_cursor()
        End If


        'se obtiene codigo de barras y descripcion
        Dim dtProducto As New DataTable
        dtProducto = contPrProductos.consultar("Select IDENTIFICADOR, CODIGO_BARRAS, DESCRIPCION FROM PR_PRODUCTOS WHERE CODIGO_BARRAS= '" & codigoBarras & "'")
        If dtProducto.Rows.Count > 0 Then
            idProducto = CInt(dtProducto.Rows(0).Item(0))
        Else
            'si no encuentra el producto sale de la funcion
            Return
        End If


        'se obtiene ultimo precio de venta precio de venta
        Dim dtPU As New DataTable
        dtPU = contPrProductos.consultar("SELECT COALESCE(PRECIO_NUEVO,0) FROM PR_AUD_CAMBIOS_PREC 
                WHERE IDENTIFICADOR=(SELECT MAX(IDENTIFICADOR) FROM PR_AUD_CAMBIOS_PREC 
                WHERE ID_PRODUCTO=" & CStr(idProducto) & " AND ID_SITIO=" & CStr(idSucursal) & ")")
        If dtPU.Rows.Count > 0 Then
            precioVenta = CInt(dtPU.Rows(0).Item(0))
        End If


        'se obtiene costoLista, porcDescuento, costoReal
        Dim dtCPC As New DataTable
        dtCPC = contPrProductos.consultar("SELECT ROUND(RE.PRECIO_UNITARIO) AS COSTO_LISTA
                                                        FROM STK_ITEMS_RECEP RE
                                                        WHERE RE.IDENTIFICADOR IN(
                                                              SELECT IDENTIFICADOR FROM (
                                                                  SELECT MAX(IT.IDENTIFICADOR) AS IDENTIFICADOR, IT.ID_PRODUCTO
                                                                  FROM STK_ITEMS_RECEP IT
                                                                  INNER JOIN STK_RECEPCIONES ON STK_RECEPCIONES.IDENTIFICADOR = IT.ID_RECEPCION
                                                                  INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                                                  WHERE ID_PRODUCTO=" & CStr(idProducto) & " AND STK_RECEPCIONES.ID_SITIO=" & CStr(idSucursal) & "
                                                                  GROUP BY IT.ID_PRODUCTO
                                                              )
                                                        )")
        If dtCPC.Rows.Count > 0 Then
            costounitario = CInt(dtCPC.Rows(0).Item(0))
        End If



        'se agrega el producto al datagrid
        Dim index As Integer = GridView1.FocusedRowHandle
        GridView1.SetRowCellValue(index, "CODIGO_BARRAS", dtProducto.Rows(0).Item(1))
        GridView1.SetRowCellValue(index, "DESCRIPCION", dtProducto.Rows(0).Item(2))
        GridView1.SetRowCellValue(index, "COSTO_UNITARIO", dtCPC.Rows(0).Item(0))
        GridView1.SetRowCellValue(index, "PRECIO_VENTA", dtPU.Rows(0).Item(0))
        GridView1.SetRowCellValue(index, "CANTIDAD", cantidad)


    End Sub


    Public Sub addProducto(codigoBarras As String)
        eliminarFilasVacias()

        Dim idProducto As Integer = 0
        Dim precioVenta As Integer = 0
        Dim costounitario As Integer = 0

        Dim cantidad As Integer = getCantidad(codigoBarras)
        codigoBarras = getCodigoBarras(codigoBarras)

        If codigoBarras.Replace(" ", "") = "" Then
            Return
        End If

        If GridView1.RowCount <= 0 Then
            crear_cursor()
        End If


        'se obtiene codigo de barras y descripcion
        Dim dtProducto As New DataTable
        dtProducto = contPrProductos.consultar("SELECT IDENTIFICADOR, CODIGO_BARRAS, DESCRIPCION FROM PR_PRODUCTOS WHERE CODIGO_BARRAS= '" & codigoBarras & "'")
        If dtProducto.Rows.Count > 0 Then
            idProducto = CInt(dtProducto.Rows(0).Item(0))
        Else
            'si no encuentra el producto sale de la funcion
            Return
        End If


        'se obtiene ultimo precio de venta precio de venta
        Dim dtPU As New DataTable
        dtPU = contPrProductos.consultar("SELECT COALESCE(PRECIO_NUEVO,0) FROM PR_AUD_CAMBIOS_PREC 
                WHERE IDENTIFICADOR=(SELECT MAX(IDENTIFICADOR) FROM PR_AUD_CAMBIOS_PREC 
                WHERE ID_PRODUCTO=" & CStr(idProducto) & " AND ID_SITIO=" & CStr(idSucursal) & ")")
        If dtPU.Rows.Count > 0 Then
            precioVenta = CInt(dtPU.Rows(0).Item(0))
        End If


        'se obtiene costoLista, porcDescuento, costoReal
        Dim dtCPC As New DataTable
        dtCPC = contPrProductos.consultar("SELECT ROUND(RE.PRECIO_UNITARIO) AS COSTO_LISTA
                                                        FROM STK_ITEMS_RECEP RE
                                                        WHERE RE.IDENTIFICADOR IN(
                                                              SELECT IDENTIFICADOR FROM (
                                                                  SELECT MAX(IT.IDENTIFICADOR) AS IDENTIFICADOR, IT.ID_PRODUCTO
                                                                  FROM STK_ITEMS_RECEP IT
                                                                  INNER JOIN STK_RECEPCIONES ON STK_RECEPCIONES.IDENTIFICADOR = IT.ID_RECEPCION
                                                                  INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                                                  WHERE ID_PRODUCTO=" & CStr(idProducto) & " AND STK_RECEPCIONES.ID_SITIO=" & CStr(idSucursal) & "
                                                                  GROUP BY IT.ID_PRODUCTO
                                                              )
                                                        )")
        If dtCPC.Rows.Count > 0 Then
            costounitario = CInt(dtCPC.Rows(0).Item(0))
        End If



        'se agrega el producto al datagrid
        Dim newRow As DataRow = (TryCast(gridProductos.DataSource, DataTable)).NewRow()

        newRow("CODIGO_BARRAS") = dtProducto.Rows(0).Item(1)
        newRow("DESCRIPCION") = dtProducto.Rows(0).Item(2)
        newRow("COSTO_UNITARIO") = dtCPC.Rows(0).Item(0)
        newRow("PRECIO_VENTA") = dtPU.Rows(0).Item(0)
        newRow("CANTIDAD") = cantidad

        TryCast(gridProductos.DataSource, DataTable).Rows.Add(newRow)
        gridProductos.RefreshDataSource()

        agregarFila()
    End Sub

    Function getCodigoBarras(codigo As String) As String
        Try
            Dim vector As String() = codigo.Split(",")
            Return vector(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function getCantidad(codigo) As Double
        Try
            Dim vector As String() = codigo.Split(",")
            Return CDbl(vector(1))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Sub exportarExcel()
        GridView1.ShowPrintPreview()

        'Dim path As String = "Listado de Productos.xls"
        'GridView1.ExportToXls(path)
        'Process.Start(path)
    End Sub


    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSucursal.Text IsNot "" Then
                gridProductos.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub btnBuscarSucursal_Click(sender As Object, e As EventArgs) Handles btnBuscarSucursal.Click
        vistas("SI")
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion?", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
        Else
            exportarExcel()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Eliminar item", titulo) Then
            limpiar()
        End If
    End Sub

    Private Sub btnCargarProd_Click(sender As Object, e As EventArgs) Handles btnCargarProd.Click
        Dim frm As New FrmCargaRapidaProd
        frm.setFrmActivo("FrmGenerarListaProd")
        frm.setFrmGenerarListaProd(Me)
        frm.ShowDialog()
    End Sub

    Private Sub rpsCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "CODIGO_BARRAS")) Then
            Else
                If GridView1.GetRowCellValue(rowhandle, "CODIGO_BARRAS") = "" Then
                Else
                    Dim cod As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS")
                    getProducto(cod)
                    GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                End If
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            vistas("PR")
        End If
    End Sub

    Private Sub rpsDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "DESCRIPCION")) Then
            Else
                If GridView1.GetRowCellValue(rowhandle, "DESCRIPCION") = "" Then
                Else
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                End If
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            vistas("PR")
        End If
    End Sub

    Private Sub rpsPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)
            GridView1.FocusedColumn = GridView1.VisibleColumns(2)

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "PRECIO_VENTA")) Then
            Else
                If CStr(GridView1.GetRowCellValue(rowhandle, "PRECIO_VENTA")) = "" Then
                Else
                    If CInt(GridView1.GetRowCellValue(rowhandle, "PRECIO_VENTA")) > 0 Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(3)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub rpsCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) Then
            Else
                If CStr(GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) = "" Then
                Else
                    If CInt(GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) > 0 Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(4)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub rpsCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(5)
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)

            If IsDBNull(GridView1.GetRowCellValue(rowhandle, "CANTIDAD")) Then
            Else
                If CStr(GridView1.GetRowCellValue(rowhandle, "CANTIDAD")) = "" Then
                Else
                    If CInt(GridView1.GetRowCellValue(rowhandle, "CANTIDAD")) > 0 Then
                        eliminarFilasVacias()
                        agregarFila()
                        SendKeys.Send("{ENTER}")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If ControlMensajes.msj_confirmacion("Eliminar item", titulo) Then
            Dim index As Integer = GridView1.FocusedRowHandle
            GridView1.DeleteRow(index)
        Else
            ControlMensajes.mensaje("Item no eliminado", titulo, "INF")
        End If
    End Sub
End Class