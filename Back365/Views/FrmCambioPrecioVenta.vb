Public Class FrmCambioPrecioVenta

    Dim contPrProductos As New ContPrProductos
    Dim contPrUmProducto As New ContPrUmProducto
    Dim contPrAudCambiosPrec As New ContPrAudCambiosPrec
    Dim contPsPreciosAplicar As New ContPsPreciosAplicar

    Dim dtListado As New DataTable

    Dim idEmpresa As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idSitio As Integer = 0
    Dim idProducto As Integer = 0
    Dim idProveedor As Integer = 0
    Dim idUnidadMedida As Integer = 0
    Dim precioVentaUsar As Integer = 0
    Dim titulo As String = "Cambio precio de venta"

    Private Sub FrmCambioPrecioVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub crear_cursor()
        dtListado = New DataTable
        dtListado.Columns.Add("ID_SITIO")
        dtListado.Columns.Add("ID_EMPRESA")
        dtListado.Columns.Add("ID_UNIDAD")
        dtListado.Columns.Add("SUCURSAL")
        dtListado.Columns.Add("COSTO_LISTA")
        dtListado.Columns.Add("PORC_DESCUENTO")
        dtListado.Columns.Add("COSTO_REAL")
        dtListado.Columns.Add("PORC_REAL")
        dtListado.Columns.Add("PORC_LISTA")
        dtListado.Columns.Add("ULTIMO_CAMBIO")
        dtListado.Columns.Add("PRECIO_ACTUAL")
        dtListado.Columns.Add("MARGEN", GetType(System.Double))
        dtListado.Columns.Add("PRECIO_NUEVO")

        gridListado.DataSource = dtListado
    End Sub

    Sub limpiar()
        idEmpresa = 0
        idUnidad = 0
        idSitio = 0
        idProducto = 0
        idProveedor = 0
        idUnidadMedida = 0
        precioVentaUsar = 0
        txtSucursal.Text = ""
        txtCodigoBarras.Text = ""
        txtDescripcion.Text = ""
        txtProveedor.Text = ""
        txtCodigoBalanza.Text = ""
        txtIdentificador.Text = ""
        chkActivo.Checked = False

        dtListado = Nothing
        gridListado.DataSource = dtListado
    End Sub

    Sub vistas(verificador As String)
        If verificador = "SI" Then
            Dim frm As New FrmVistaFndSitios
            frm.setFrmActivo("FrmCambioPrecioVenta")
            frm.setFrmCambioPrecioVenta(Me)
            frm.ShowDialog()
        End If
        If verificador = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmCambioPrecioVenta")
            frm.setFrmCambioPrecioVenta(Me)
            frm.setCondicion(" ")
            frm.ShowDialog()
        End If
        If verificador = "HI" Then
            If txtCodigoBarras.Text = "" Then
                ControlMensajes.mensaje("Debe seleccionar producto", titulo, "WAR")
                txtCodigoBarras.Focus()
            Else
                Dim frm As New FrmVistaPrAudCambiosPrecio
                frm.setCodigoBarras(txtCodigoBarras.Text)
                frm.ShowDialog()
            End If
        End If
    End Sub

    Sub getSitio(id As Integer)
        Dim dt As New DataTable
        dt = contPrProductos.consultar("SELECT IDENTIFICADOR, DESCRIPCION, ID_EMPRESA, ID_UNIDAD FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
            idEmpresa = CStr(dt.Rows(0).Item(2))
            idUnidad = CStr(dt.Rows(0).Item(3))
        End If
    End Sub

    Sub getProveedor(id As Integer)
        Dim dt As New DataTable
        dt = contPrProductos.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idProveedor = CInt(dt.Rows(0).Item(0))
            txtProveedor.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getProducto(codigo_barras As String)
        Dim dt As New DataTable
        dt = contPrProductos.consultar("SELECT PR.DESCRIPCION, COALESCE(PR.CODIGO_BALANZA, '-'), PR.IDENTIFICADOR, PR.ACTIVO, ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO),
                                        PR.ID_UNIDAD_MEDIDA, PR.ID_PROVEEDOR
                                        FROM PR_PRODUCTOS PR
                                        INNER JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                                        WHERE PR.CODIGO_BARRAS ='" & codigo_barras & "'")
        If dt.Rows.Count > 0 Then
            txtCodigoBarras.Text = codigo_barras
            idProducto = CInt(dt.Rows(0).Item(2))
            txtDescripcion.Text = CStr(dt.Rows(0).Item(0))
            txtCodigoBalanza.Text = CStr(dt.Rows(0).Item(1))
            txtIdentificador.Text = CStr(dt.Rows(0).Item(2))
            If CStr(dt.Rows(0).Item(3)) = "S" Then
                chkActivo.Checked = True
            Else
                chkActivo.Checked = False
            End If
            idUnidadMedida = CStr(dt.Rows(0).Item(5))
            getProveedor(CInt(dt.Rows(0).Item(6)))
            getDetalles()
        Else
            ControlMensajes.mensaje("Producto no definido", titulo, "WAR")
        End If
    End Sub

    Sub getDetalles()

        Dim precioVenta As Integer = 0
        Dim ultimoCambio As String = ""
        Dim costoLista As Integer = 0
        Dim descuento As Double = 0
        Dim costoReal As Integer = 0
        Dim porcLista As Double = 0
        Dim porcReal As Double = 0


        crear_cursor()

        Dim dtsitios As New DataTable
        Dim querySitios As String = ""
        If idSitio > 0 Then
            querySitios = "SELECT IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & idSitio
        Else
            querySitios = "SELECT IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD, DESCRIPCION FROM FND_SITIOS ORDER BY IDENTIFICADOR ASC"
        End If
        dtsitios = contPrProductos.consultar(querySitios)
        If dtsitios.Rows.Count > 0 Then
            For s As Integer = 0 To dtsitios.Rows.Count - 1
                'se obtiene precio de venta y ultimo cambio
                Dim dtPU As New DataTable
                dtPU = contPrProductos.consultar("SELECT COALESCE(PRECIO_NUEVO,0), FECHA_APLICACION FROM PR_AUD_CAMBIOS_PREC 
                WHERE IDENTIFICADOR=(SELECT MAX(IDENTIFICADOR) FROM PR_AUD_CAMBIOS_PREC 
                WHERE ID_PRODUCTO=" & CStr(idProducto) & " AND ID_SITIO=" & CStr(dtsitios.Rows(s).Item(0)) & ")")
                If dtPU.Rows.Count > 0 Then
                    precioVenta = CInt(dtPU.Rows(0).Item(0))
                    ultimoCambio = CStr(dtPU.Rows(0).Item(1))
                End If

                'se obtiene costoLista, porcDescuento, costoReal
                Dim dtCPC As New DataTable
                dtCPC = contPrProductos.consultar("SELECT ROUND(RE.PRECIO_UNITARIO) AS COSTO_LISTA,  COALESCE(PORC_DESCUENTO, 0) AS PORC_DESCUENTO,
                                                        ROUND((ROUND(RE.PRECIO_UNITARIO) - (COALESCE(RE.IMPORTE_DESCUENTO, 0) / RE.CANTIDAD)),0) AS COSTO_REAL
                                                        FROM STK_ITEMS_RECEP RE
                                                        WHERE RE.IDENTIFICADOR IN(
                                                              SELECT IDENTIFICADOR FROM (
                                                                  SELECT MAX(IT.IDENTIFICADOR) AS IDENTIFICADOR, IT.ID_PRODUCTO
                                                                  FROM STK_ITEMS_RECEP IT
                                                                  INNER JOIN STK_RECEPCIONES ON STK_RECEPCIONES.IDENTIFICADOR = IT.ID_RECEPCION
                                                                  INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                                                  WHERE ID_PRODUCTO=" & CStr(idProducto) & " AND STK_RECEPCIONES.ID_SITIO=" & CStr(dtsitios.Rows(s).Item(0)) & "
                                                                  GROUP BY IT.ID_PRODUCTO
                                                              )
                                                        )")
                If dtCPC.Rows.Count > 0 Then
                    costoLista = CInt(dtCPC.Rows(0).Item(0))
                    descuento = CDbl(dtCPC.Rows(0).Item(1))
                    costoReal = CInt(dtCPC.Rows(0).Item(2))
                    porcReal = CDbl(((precioVenta / costoReal) * 100) - 100)
                    porcLista = CDbl(((precioVenta / costoLista) * 100) - 100)
                Else
                    costoLista = 0
                    descuento = 0
                    costoReal = 0
                    porcReal = 0
                    porcLista = 0
                End If

                Dim newRow As DataRow = (TryCast(gridListado.DataSource, DataTable)).NewRow()
                newRow("ID_SITIO") = CStr(dtsitios.Rows(s).Item(0))
                newRow("ID_EMPRESA") = CStr(dtsitios.Rows(s).Item(1))
                newRow("ID_UNIDAD") = CStr(dtsitios.Rows(s).Item(2))
                newRow("SUCURSAL") = CStr(dtsitios.Rows(s).Item(3))
                newRow("COSTO_LISTA") = costoLista
                newRow("PORC_DESCUENTO") = descuento
                newRow("COSTO_REAL") = costoReal
                newRow("PORC_REAL") = porcReal
                newRow("PORC_LISTA") = porcLista
                newRow("ULTIMO_CAMBIO") = ultimoCambio
                newRow("PRECIO_ACTUAL") = precioVenta
                newRow("MARGEN") = 0
                newRow("PRECIO_NUEVO") = 0

                TryCast(gridListado.DataSource, DataTable).Rows.Add(newRow)
                gridListado.RefreshDataSource()
            Next
        End If

        GridView1.FocusedRowHandle = 0
    End Sub

    Sub cambiarPrecio()
        If idProducto <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar un producto", titulo, "WAR")
            txtCodigoBarras.Focus()
            Return
        End If
        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
            Return
        End If

        Dim precioActual As Integer = 0
        Dim precioNuevo As Integer = 0
        Dim recargo As Double = 0
        Dim sucursal As Integer = 0
        Dim empresa As Integer = 0
        Dim unidad As Integer = 0
        Dim identificador As Integer = contPrAudCambiosPrec.identificador()

        For i As Integer = 0 To GridView1.RowCount - 1
            precioActual = CInt(GridView1.GetRowCellValue(i, "PRECIO_ACTUAL"))
            precioNuevo = CInt(GridView1.GetRowCellValue(i, "PRECIO_NUEVO"))
            sucursal = CInt(GridView1.GetRowCellValue(i, "ID_SITIO"))
            empresa = CInt(GridView1.GetRowCellValue(i, "ID_EMPRESA"))
            unidad = CInt(GridView1.GetRowCellValue(i, "ID_UNIDAD"))
            recargo = CDbl(GridView1.GetRowCellValue(i, "MARGEN"))

            If precioNuevo > 0 Then
                'SE REGISTRA AUDITORIA DE PRECIOS
                identificador = contPrAudCambiosPrec.identificador()
                If contPrAudCambiosPrec.insertarAudCambio(idProducto, idUnidadMedida, "PV", precioNuevo, Now.ToString("dd/MM/yyyy hh: mm:ss"), precioActual, recargo, "APP", txtCodigoBarras.Text, "N", idProveedor, "S", empresa, unidad, sucursal, identificador, Now.ToString("dd/MM/yyyy hh:mm:ss")) = False Then
                    ControlMensajes.mensaje("Auditoria de precio no registrado", titulo, "WAR")
                    Return
                End If

                'SE REGISTRA PRECIOS A APLICAR
                Dim dtCajas As New DataTable
                Dim queryCajas As String = "SELECT IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD FROM TC_CAJAS WHERE ACTIVO='S' AND ID_SITIO = " & CStr(sucursal)
                dtCajas = contPrProductos.consultar(queryCajas)
                If dtCajas.Rows.Count > 0 Then
                    For j As Integer = 0 To dtCajas.Rows.Count - 1
                        If contPsPreciosAplicar.insertarPrecioAplicar(contPsPreciosAplicar.identificador(), CInt(dtCajas.Rows(j).Item(1)), CInt(dtCajas.Rows(j).Item(2)), idSitio, idProducto, idUnidadMedida, CInt(dtCajas.Rows(j).Item(0)), precioNuevo, Now.ToString("dd/MM/yyyy hh:mm:ss"), precioActual, txtCodigoBarras.Text) = False Then
                            ControlMensajes.mensaje("Precio a aplicar no registrado", titulo, "WAR")
                            Return
                        End If
                    Next
                Else
                    ControlMensajes.mensaje("Cajas no definidas", titulo, "WAR")
                End If

                'SE ACTUALIZA PR_PRODUCTOS
                If contPrProductos.actualizarPrecioVenta(idProducto, precioNuevo) = False Then
                    ControlMensajes.mensaje("Precio no actualizado(PR)", titulo, "WAR")
                    Return
                End If

                'SE ACTUALIZA PR_UM_PRODUCTOS
                If contPrUmProducto.actualizarPrecioVenta(idProducto, precioNuevo) = False Then
                    ControlMensajes.mensaje("Precio no actualizado(UM)", titulo, "WAR")
                    Return
                End If
            End If

        Next

        ControlMensajes.mensaje("Precio actualizado", titulo, "INF")
        limpiar()
        txtSucursal.Focus()
    End Sub

    Sub calcularTotal(porcentaje As Double, rowhandle As Integer)
        Dim costoReal As Integer = GridView1.GetRowCellValue(rowhandle, "COSTO_REAL")
        If costoReal > 0 Then
            Dim margen As Double = (costoReal * porcentaje) / 100
            Dim total As Integer = costoReal + margen

            GridView1.SetRowCellValue(rowhandle, "PRECIO_NUEVO", setTotalRedondeo(total))
            calcularMargen(rowhandle, total)
        Else
            GridView1.SetRowCellValue(rowhandle, "MARGEN", 0)
        End If
    End Sub

    Sub calcularMargen(rowhandle As Integer, total As Integer)
        Dim costoReal As Integer = GridView1.GetRowCellValue(rowhandle, "COSTO_REAL")
        If costoReal > 0 Then
            Dim margen As Double = ((total / costoReal) * 100) - 100

            GridView1.SetRowCellValue(rowhandle, "MARGEN", margen)
            GridView1.SetRowCellValue(rowhandle, "PRECIO_NUEVO", setTotalRedondeo(total))
        Else
            GridView1.SetRowCellValue(rowhandle, "MARGEN", 0)
        End If
    End Sub

    Function setTotalRedondeo(numero As Integer) As Integer
        Dim result As Integer = 0
        result = redondeo(numero / 50) * 50
        Return result
    End Function

    Function redondeo(valor As Double) As Integer
        Dim returnVal As Integer = 0

        If valor - CInt(valor) >= 0.1 Then
            returnVal = valor + 1
        Else
            returnVal = valor
        End If

        Return returnVal
    End Function

    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCodigoBarras.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("SI")
        End If
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        vistas("SI")
    End Sub

    Private Sub txtCodigoBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            getProducto(txtCodigoBarras.Text)
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("PR")
        End If
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        vistas("PR")
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCodigoBalanza.Focus()
        End If
    End Sub

    Private Sub txtCodigoBalanza_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBalanza.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtIdentificador.Focus()
        End If
    End Sub

    Private Sub txtIdentificador_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdentificador.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.Focus()
        End If
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        vistas("HI")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        cambiarPrecio()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelar la operacion", titulo) Then
            limpiar()
        End If
    End Sub

    Private Sub btnCostos_Click(sender As Object, e As EventArgs)
        vistas("CO")
    End Sub

    Private Sub rpsMargen_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsMargen.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(7)
            GridView1.FocusedColumn = GridView1.VisibleColumns(8)

            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            Dim porcentaje As Double = GridView1.GetRowCellValue(rowhandle, "MARGEN")
            If porcentaje > 0 Then
                calcularTotal(porcentaje, rowhandle)
                GridView1.FocusedColumn = GridView1.VisibleColumns(9)
            Else
                GridView1.FocusedColumn = GridView1.VisibleColumns(9)
            End If

        End If
    End Sub

    Private Sub rpsPrecioNuevo_KeyDown(sender As Object, e As KeyEventArgs) Handles rpsPrecioNuevo.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(8)
            GridView1.FocusedColumn = GridView1.VisibleColumns(9)

            Dim rowhandle As Integer = GridView1.FocusedRowHandle

            Dim total As Double = GridView1.GetRowCellValue(rowhandle, "PRECIO_NUEVO")
            If total > 0 Then
                calcularMargen(rowhandle, total)
                GridView1.FocusedRowHandle = rowhandle + 1
                GridView1.FocusedColumn = GridView1.VisibleColumns(8)
            End If
        End If
    End Sub


End Class