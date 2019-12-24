Imports DevExpress.XtraReports.UI

Public Class FrmAppPromocionesProv

    Dim contAppPromocionesProv As New ContAppPromocionesProv

    Dim titulo As String = ""
    Dim idSitio As Integer = 0
    Dim idProveedor As Integer = 0
    Dim dtItems As New DataTable
    Dim idPromocion As Integer = 0

    Private Sub FrmAppPromocionesProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldDesde.Visible = False
        cldHasta.Visible = False
        GridView1.Columns("CANTIDAD").Visible = False
        crear_cursor()
    End Sub

    Sub vistas(verificador As String)
        If verificador = "FD" Then
            If cldDesde.Visible = False Then
                cldDesde.Visible = True
                cldDesde.Focus()
            Else
                cldDesde.Visible = False
                txtFechaDesde.Focus()
            End If
        End If

        If verificador = "FH" Then
            If cldHasta.Visible = False Then
                cldHasta.Visible = True
                cldHasta.Focus()
            Else
                cldHasta.Visible = False
                txtFechaHasta.Focus()
            End If
        End If

        If verificador = "SI" Then
            Dim frm As New FrmVistaFndSitios
            frm.setFrmActivo("FrmAppPromocionesProv")
            frm.setFrmAppPromocionesProv(Me)
            frm.ShowDialog()
        End If

        If verificador = "PV" Then
            Dim frm As New FrmVistaCpProveedores
            frm.setFrmActivo("FrmAppPromocionesProv")
            frm.setFrmAppPromocionesProv(Me)
            frm.ShowDialog()
        End If

        If verificador = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmAppPromocionesProv")
            frm.setFrmAppPromocionesProv(Me)
            frm.ShowDialog()
        End If

        If verificador = "PM" Then
            Dim frm As New FrmVistaAppPromocionesProv
            frm.setFrmActivo("FrmAppPromocionesProv")
            frm.setFrmAppPromocionesProv(Me)
            frm.ShowDialog()
        End If

    End Sub

    Sub getSitio(id As Integer)
        Dim dt As New DataTable
        dt = contAppPromocionesProv.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
        Else
            ControlMensajes.mensaje("Sucursal no definida", titulo, "WAR")
        End If
    End Sub

    Sub getProveedor(id As Integer)
        Dim dt As New DataTable
        dt = contAppPromocionesProv.consultar("SELECT DENOMINACION, IDENTIFICADOR FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            txtProveedor.Text = CStr(dt.Rows(0).Item(0))
            idProveedor = CInt(dt.Rows(0).Item(1))
        Else
            ControlMensajes.mensaje("Proveedor no definido", titulo, "WAR")
        End If
    End Sub

    Sub limpiar()
        idSitio = 0
        idProveedor = 0
        idPromocion = 0
        txtNombre.Text = ""
        txtSucursal.Text = ""
        txtProveedor.Text = ""
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        btnAceptar.Enabled = True

        dtItems = Nothing
        gridItems.DataSource = dtItems
        GridView1.Columns("CANTIDAD").Visible = False
    End Sub

    Sub crear_cursor()
        dtItems = New DataTable
        dtItems.Columns.Add("CODIGO_BARRAS")
        dtItems.Columns.Add("DESCRIPCION")
        dtItems.Columns.Add("COSTO_UNITARIO")
        dtItems.Columns.Add("PRECIO_VENTA")
        dtItems.Columns.Add("IDENTIFICADOR")

        gridItems.DataSource = dtItems
        agregarFila()
    End Sub

    Sub eliminarFilasVacias()
        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "IDENTIFICADOR")) Then
                GridView1.DeleteRow(i)
            End If
        Next
    End Sub

    Sub agregarFila()
        GridView1.Focus()
        eliminarFilasVacias()
        GridView1.AddNewRow()

        GridView1.FocusedRowHandle = GridView1.RowCount - 1
        GridView1.FocusedColumn = GridView1.Columns("CODIGO_BARRAS")
        GridView1.ShowEditor()
    End Sub

    Sub getProducto(codigoBarras As String)
        Dim index As Integer = GridView1.FocusedRowHandle
        Dim sitio As String = ""


        'obtener datos del producto
        Dim producto As DataTable
        producto = contAppPromocionesProv.consultar("SELECT IDENTIFICADOR, CODIGO_BARRAS, DESCRIPCION FROM PR_PRODUCTOS WHERE CODIGO_BARRAS='" & codigoBarras & "' AND ID_PROVEEDOR=" & CStr(idProveedor))
        If producto.Rows.Count <= 0 Then
            ControlMensajes.mensaje("Producto no definido", titulo, "WAR")
            GridView1.FocusedColumn = GridView1.Columns("CODIGO_BARRAS")
            Return
        End If


        'obtener ultimo precio de venta del producto
        Dim precio_venta As Integer = 0
        If idSitio > 0 Then
            sitio = " AND STK_RECEPCIONES.ID_SITIO=" & CStr(idSitio)
        End If
        Dim precio As New DataTable
        precio = contAppPromocionesProv.consultar("SELECT COALESCE(ROUND((ROUND(RE.PRECIO_UNITARIO) - (COALESCE(RE.IMPORTE_DESCUENTO, 0) / RE.CANTIDAD)),0), 0) AS COSTO_REAL
                                                        FROM STK_ITEMS_RECEP RE
                                                        WHERE RE.IDENTIFICADOR IN(
                                                              SELECT IDENTIFICADOR FROM (
                                                                  SELECT MAX(IT.IDENTIFICADOR) AS IDENTIFICADOR, IT.ID_PRODUCTO
                                                                  FROM STK_ITEMS_RECEP IT
                                                                  INNER JOIN STK_RECEPCIONES ON STK_RECEPCIONES.IDENTIFICADOR = IT.ID_RECEPCION
                                                                  WHERE IT.ID_PRODUCTO='" & CStr(producto.Rows(0).Item(0)) & "' " & sitio & "
                                                                  GROUP BY IT.ID_PRODUCTO
                                                              )
                                                        )")
        If precio.Rows.Count > 0 Then
            precio_venta = precio.Rows(0).Item(0)
        Else
            precio_venta = 0
        End If


        'obtener ultimo costo del producto
        Dim costo_unitario As Integer = 0
        If idSitio > 0 Then
            sitio = " AND PR_AUD_CAMBIOS_PREC.ID_SITIO=" & CStr(idSitio)
        End If
        Dim costo As New DataTable
        costo = contAppPromocionesProv.consultar("SELECT COALESCE(PRECIO_NUEVO,0)
                                                    FROM PR_AUD_CAMBIOS_PREC 
                                                    WHERE PR_AUD_CAMBIOS_PREC.IDENTIFICADOR=(SELECT MAX(PR_AUD_CAMBIOS_PREC.IDENTIFICADOR) FROM PR_AUD_CAMBIOS_PREC 
                                                    WHERE PR_AUD_CAMBIOS_PREC.ID_PRODUCTO='" & CStr(producto.Rows(0).Item(0)) & "' " & sitio & ")")
        If costo.Rows.Count > 0 Then
            costo_unitario = costo.Rows(0).Item(0)
        Else
            costo_unitario = 0
        End If


        GridView1.SetRowCellValue(index, "IDENTIFICADOR", producto.Rows(0).Item(0))
        GridView1.SetRowCellValue(index, "CODIGO_BARRAS", producto.Rows(0).Item(1))
        GridView1.SetRowCellValue(index, "DESCRIPCION", producto.Rows(0).Item(2))
        GridView1.SetRowCellValue(index, "COSTO_UNITARIO", costo.Rows(0).Item(0))
        GridView1.SetRowCellValue(index, "PRECIO_VENTA", precio.Rows(0).Item(0))

    End Sub

    Sub insertarPromocion()

        If txtNombre.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("Debe ingresar nombre", titulo, "WAR")
            txtNombre.Focus()
            Return
        End If
        If idProveedor <= 0 Then
            ControlMensajes.mensaje("Debe ingresar proveedor", titulo, "WAR")
            txtNombre.Focus()
            Return
        End If
        If txtFechaDesde.Text = "  /  /" Then
            ControlMensajes.mensaje("Debe ingresar fecha desde", titulo, "WAR")
            txtFechaDesde.Focus()
            Return
        End If
        If txtFechaHasta.Text = "  /  /" Then
            ControlMensajes.mensaje("Debe ingresar fecha hasta", titulo, "WAR")
            txtFechaHasta.Focus()
            Return
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe ingresar items a la promocion", titulo, "WAR")
            agregarFila()
            Return
        End If
        If ControlMensajes.msj_confirmacion("Confirmar operacion?", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
            Return
        End If

        Dim identificador As Integer = 0
        Dim fechaDesde As String = txtFechaDesde.Text
        Dim fechaHasta As String = txtFechaHasta.Text
        Dim nombre As String = txtNombre.Text


        If idSitio > 0 Then
            identificador = contAppPromocionesProv.getIdItemPromo()
            If contAppPromocionesProv.insertarPromo(identificador, idSitio, idProveedor, fechaDesde, fechaHasta, nombre) = False Then
                ControlMensajes.mensaje("Promocion no registrada", titulo, "WAR")
            End If

            If insertarItemsPromocion(identificador) = False Then
                Return
            End If
        Else
            Dim sitios As DataTable
            sitios = contAppPromocionesProv.consultar("SELECT IDENTIFICADOR FROM FND_SITIOS ORDER BY IDENTIFICADOR ASC")
            If sitios.Rows.Count > 0 Then
                For i As Integer = 0 To sitios.Rows.Count - 1
                    identificador = contAppPromocionesProv.getIdItemPromo()
                    If contAppPromocionesProv.insertarPromo(identificador, sitios.Rows(i).Item(0), idProveedor, fechaDesde, fechaHasta, nombre) = False Then
                        ControlMensajes.mensaje("Promocion no registrada", titulo, "WAR")
                    End If

                    If insertarItemsPromocion(identificador) = False Then
                        Return
                    End If
                Next
            Else
                ControlMensajes.mensaje("Sitios no definidos", titulo, "WAR")
                Return
            End If
        End If

        ControlMensajes.mensaje("Promocion registrada", titulo, "INF")
        limpiar()
        txtNombre.Focus()
    End Sub

    Function insertarItemsPromocion(idPromocion As Integer) As Boolean
        Dim identificador As Integer = 0
        Dim idProducto As Integer = 0
        Dim precio_venta As Integer = 0
        Dim costo_unitario As Integer = 0
        Dim cantidad As Integer = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            identificador = contAppPromocionesProv.getIdItemPromo()
            idProducto = CInt(GridView1.GetRowCellValue(i, "IDENTIFICADOR"))
            precio_venta = CInt(GridView1.GetRowCellValue(i, "PRECIO_VENTA"))
            costo_unitario = CInt(GridView1.GetRowCellValue(i, "COSTO_UNITARIO"))
            cantidad = 0

            If contAppPromocionesProv.insertarItemPromo(identificador, idPromocion, idProducto, precio_venta, costo_unitario, cantidad) = False Then
                ControlMensajes.mensaje("Item de promocion no registrado: " & CStr(i), titulo, "WAR")
                Return False
            End If
        Next

        Return True
    End Function

    Sub getPromociones()
        Dim dt As New DataTable
        dt = contAppPromocionesProv.consultar("")

        If dt.Rows.Count > 0 Then
            gridItems.DataSource = dt
        End If
    End Sub

    Sub getPromocion(id As Integer)
        Dim dt As New DataTable
        dt = contAppPromocionesProv.consultar("SELECT NOMBRE, ID_PROVEEDOR, ID_SITIO, FECHA_DESDE, FECHA_HASTA, IDENTIFICADOR FROM APP_PROMOCIONES_PROV WHERE IDENTIFICADOR=" & CStr(id))

        If dt.Rows.Count > 0 Then
            txtNombre.Text = CStr(dt.Rows(0).Item(0))
            getProveedor(CInt(dt.Rows(0).Item(1)))
            getSitio(CInt(dt.Rows(0).Item(2)))
            txtFechaDesde.Text = CStr(dt.Rows(0).Item(3))
            txtFechaHasta.Text = CStr(dt.Rows(0).Item(4))

            idPromocion = CInt(dt.Rows(0).Item(5))
            getItemsPromocion(idPromocion)

            btnAceptar.Enabled = False
        End If
    End Sub

    Sub getItemsPromocion(id As Integer)
        Dim dt As New DataTable
        dt = contAppPromocionesProv.consultar("SELECT PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, COALESCE(SUM(CANTIDAD), 0) AS CANTIDAD
                                                FROM APP_ITEMS_PROM_PROV APP
                                                INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = APP.ID_PRODUCTO
                                                WHERE APP.ID_PROMOCION=" & CStr(id) & "
                                                GROUP BY PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION")

        If dt.Rows.Count > 0 Then
            gridItems.DataSource = dt
            GridView1.Columns("CANTIDAD").Visible = True
        End If
    End Sub

    Sub crearReporte()
        If idPromocion <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim rowhandle As Integer = 0
        Dim sucursal As String = ""
        Dim proveedor As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""

        If idSitio <= 0 Then
            sucursal = "TODOS"
        Else
            sucursal = txtSucursal.Text
        End If

        proveedor = txtProveedor.Text
        desde = txtFechaDesde.Text
        hasta = txtFechaHasta.Text

        Dim report As New RptAppPromocionProv

        report.DataSource = gridItems.DataSource

        report.Parameters("sucursal").Value = sucursal
        report.Parameters("proveedor").Value = proveedor
        report.Parameters("fechaDesde").Value = desde
        report.Parameters("fechaHasta").Value = hasta
        report.Parameters("usuarioFechaImp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy hh:mm:ss")

        report.Parameters("sucursal").Visible = False
        report.Parameters("proveedor").Visible = False
        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False
        report.Parameters("usuarioFechaImp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter And txtNombre.Text.Replace(" ", "") IsNot "" Then
            txtSucursal.Focus()
        End If
    End Sub

    Private Sub txtsucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProveedor.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        vistas("SI")
    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Enter And idProveedor > 0 Then
            txtFechaDesde.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PV")
        End If
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        vistas("PV")
    End Sub

    Private Sub txtFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFechaDesde.Text = "  /  /" Then
            Else
                txtFechaHasta.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FD")
        End If
    End Sub

    Private Sub btnFechaDesde_Click(sender As Object, e As EventArgs) Handles btnFechaDesde.Click
        vistas("FD")
    End Sub

    Private Sub cldDesde_DoubleClick(sender As Object, e As EventArgs) Handles cldDesde.DoubleClick
        txtFechaDesde.Text = cldDesde.DateTime.ToString
        txtFechaDesde.Focus()
        vistas("FD")
    End Sub

    Private Sub cldDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles cldDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaDesde.Text = cldDesde.DateTime.ToString
            txtFechaDesde.Focus()
            vistas("FD")
        End If
    End Sub

    Private Sub txtFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFechaHasta.Text = "  /  /" Then
            Else
                agregarFila()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FH")
        End If
    End Sub

    Private Sub btnFechaHasta_Click(sender As Object, e As EventArgs) Handles btnFechaHasta.Click
        vistas("FH")
    End Sub

    Private Sub cldHasta_DoubleClick(sender As Object, e As EventArgs) Handles cldHasta.DoubleClick
        txtFechaHasta.Text = cldHasta.DateTime.ToString
        txtFechaHasta.Focus()
        vistas("FH")
    End Sub

    Private Sub cldHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cldHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaHasta.Text = cldHasta.DateTime.ToString
            txtFechaHasta.Focus()
            vistas("FH")
        End If
    End Sub

    Private Sub rpsCodigoBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsCodigoBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.Columns("DESCRIPCION")
            GridView1.FocusedColumn = GridView1.Columns("CODIGO_BARRAS")

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS")) Then
                ControlMensajes.mensaje("Debe ingresarcodigo de barras", titulo, "WAR")
                Return
            End If

            getProducto(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS"))
            GridView1.FocusedColumn = GridView1.Columns("DESCRIPCION")
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("PR")
        End If
    End Sub

    Private Sub rpsDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.Columns("CODIGO_BARRAS")
            GridView1.FocusedColumn = GridView1.Columns("DESCRIPCION")

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS")) Then
                ControlMensajes.mensaje("Debe ingresar codigo de barras", titulo, "WAR")
                Return
            End If
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DESCRIPCION")) Then
                ControlMensajes.mensaje("Debe ingresar descripcion", titulo, "WAR")
                Return
            End If

            agregarFila()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        eliminarFilasVacias()
        insertarPromocion()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Cancelar operacion?", titulo) Then
            limpiar()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        vistas("PM")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        crearReporte()
    End Sub
End Class