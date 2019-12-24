Public Class FrmRecargoProductos

    Dim titulo As String = "Recargo de productos"
    Dim tituloDialogo As String = ""
    Dim redondeoDialog As Double = 50
    Dim contRecepcion As New ContStkRecepciones
    Dim contProducto As New ContPrProductos
    Dim contUmProducto As New ContPrUmProducto
    Dim contPreciosAplicar As New ContPsPreciosAplicar
    Dim contAudCambiosPrecio As New ContPrAudCambiosPrec

    Dim idEmpresa As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idSitio As Integer = 0
    Dim idProveedor As Integer = 0

    Private Sub FrmRecargoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPrecioActual.Text = CStr(0)
        txtCostoActual.Text = CStr(0)
        txtMargenActual.Text = CStr(0) & " %"
        txtMargenActualPu.Text = CStr(0) & " %"
        txtCostoAnterior.Text = CStr(0)
    End Sub

    Sub limpiar()

        idEmpresa = 0
        idUnidad = 0
        idSitio = 0
        idProveedor = 0

        txtNroRecepcion.Text = ""
        txtFecha.Text = ""
        txtNumero.Text = ""
        txtProveedor.Text = ""
        txtComprobante.Text = ""
        txtPrecioActual.Text = ""
        txtMargenActual.Text = ""
        txtMargenActualPu.Text = ""
        txtCostoActual.Text = ""
        txtCostoAnterior.Text = ""
        txtFechaUltimoCosto.Text = ""
        txtSucursal.Text = ""

        gridItems.DataSource = Nothing
        txtNroRecepcion.Focus()
    End Sub

    Sub getRecepcion()
        If txtNroRecepcion.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje(" Then ThenDebe ingresar nro. de recepcion", titulo, "WAR")
            txtNroRecepcion.Focus()
            Return
        End If

        Dim dt As New DataTable
        Dim sql As String = ""

        sql = "SELECT CP.FECHA, STK_RECEPCIONES.NUMERO, CP_PROVEEDORES.DENOMINACION AS PROVEEDOR,
                CP.NUMERO AS COMPROBANTE, STK_RECEPCIONES.ID_EMPRESA, STK_RECEPCIONES.ID_UNIDAD,
                STK_RECEPCIONES.ID_SITIO, STK_RECEPCIONES.ID_PROVEEDOR
                FROM CP_COMPROBANTES CP
                LEFT JOIN STK_RECEPCIONES ON STK_RECEPCIONES.IDENTIFICADOR = CP.ID_RECEPCION
                LEFT JOIN CP_PROVEEDORES ON CP_PROVEEDORES.IDENTIFICADOR = CP.ID_PROVEEDOR
                WHERE STK_RECEPCIONES.NUMERO = '" & txtNroRecepcion.Text & "'"

        dt = contRecepcion.consultar(sql)

        If dt.Rows.Count <= 0 Then
            ControlMensajes.mensaje("Recepcion de productos no encontrado", titulo, "WAR")
            txtNroRecepcion.Focus()
        Else
            txtFecha.Text = CStr(dt.Rows(0).Item(0))
            txtNumero.Text = CStr(dt.Rows(0).Item(1))
            txtProveedor.Text = CStr(dt.Rows(0).Item(2))
            txtComprobante.Text = CStr(dt.Rows(0).Item(3))
            idEmpresa = CInt(dt.Rows(0).Item(4))
            idUnidad = CInt(dt.Rows(0).Item(5))
            idSitio = CInt(dt.Rows(0).Item(6))
            idProveedor = CInt(dt.Rows(0).Item(7))
            getSucursal(idSitio)
            getItemsRecepcion(CInt(dt.Rows(0).Item(1)))
        End If
    End Sub

    Sub getItemsRecepcion(idRecepcion As Integer)
        Dim dt As New DataTable
        Dim sql As String = ""

        'sql = "SELECT ID_PRODUCTO, CODIGO_BARRAS, DESCRIPCION, ID_UNIDAD_MEDIDA, CANTIDAD, PRECIO_ACTUAL, 
        '       COSTO_UNITARIO, PRECIO_UNITARIO, PORC_DESCUENTO, ROUND((((PRECIO_ACTUAL / COSTO_UNITARIO) * 100) - 100),2) AS MARGEN, TOTAL 
        '       FROM (
        '            SELECT PR_PRODUCTOS.IDENTIFICADOR AS ID_PRODUCTO, PR_PRODUCTOS.CODIGO_BARRAS,
        '            PR_PRODUCTOS.DESCRIPCION, PR_PRODUCTOS.ID_UNIDAD_MEDIDA,
        '            IT.CANTIDAD, COALESCE(ROUND(PR_PRODUCTOS.PRECIO_VENTA), 0) AS PRECIO_ACTUAL,
        '            CASE 
        '            WHEN COALESCE(IT.PORC_DESCUENTO, 0) > 0 
        '            THEN (ROUND(IT.PRECIO_UNITARIO) - ((ROUND(IT.PRECIO_UNITARIO) * COALESCE(IT.PORC_DESCUENTO, 0)) / 100))
        '            ELSE ROUND(IT.PRECIO_UNITARIO)
        '            END AS COSTO_UNITARIO,
        '            ROUND(IT.PRECIO_UNITARIO)  AS PRECIO_UNITARIO,
        '            COALESCE(IT.PORC_DESCUENTO, 0) AS PORC_DESCUENTO,
        '            ROUND((((ROUND(PR_PRODUCTOS.PRECIO_VENTA) / ROUND(IT.PRECIO_UNITARIO)) * 100) - 100), 2) AS MARGEN,
        '            PR_PRODUCTOS.PRECIO_VENTA AS TOTAL
        '            FROM STK_ITEMS_RECEP IT
        '            LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
        '            LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = IT.ID_PRODUCTO
        '            WHERE IT.ID_RECEPCION=" & idRecepcion.ToString & " ORDER BY IT.NUMERO_ITEM ASC
        '      )"

        sql = "SELECT ID_PRODUCTO, CODIGO_BARRAS, DESCRIPCION, ID_UNIDAD_MEDIDA, CANTIDAD, ROUND(PRECIO_ACTUAL) AS PRECIO_ACTUAL, ROUND(PRECIO_UNITARIO) AS PRECIO_UNITARIO, PORC_DESCUENTO, ROUND(COSTO_UNITARIO) AS COSTO_UNITARIO, 
                ROUND((((ROUND(PRECIO_ACTUAL) / ROUND(COSTO_UNITARIO)) * 100) - 100),2) AS MARGEN, ROUND(PRECIO_ACTUAL) AS TOTAL
                FROM (
                                SELECT ID_PRODUCTO, CODIGO_BARRAS, DESCRIPCION, ID_UNIDAD_MEDIDA, CANTIDAD, COSTO_UNITARIO, PRECIO_UNITARIO, PORC_DESCUENTO, 
                                CASE WHEN COALESCE(PRECIO_ACTUAL, 0) <= 0 
                                     THEN COALESCE(PRECIO_VENTA, 0)
                                     ELSE COALESCE(PRECIO_ACTUAL, 0)
                                END AS PRECIO_ACTUAL
                                FROM (
                                       SELECT PR_PRODUCTOS.IDENTIFICADOR AS ID_PRODUCTO, PR_PRODUCTOS.CODIGO_BARRAS,
                                                PR_PRODUCTOS.DESCRIPCION, PR_PRODUCTOS.ID_UNIDAD_MEDIDA, IT.CANTIDAD,
                                                (SELECT ROUND(PRECIO_NUEVO) FROM PR_AUD_CAMBIOS_PREC 
                                                       WHERE IDENTIFICADOR =( SELECT MAX(IDENTIFICADOR) FROM PR_AUD_CAMBIOS_PREC 
                                                                              WHERE ID_PRODUCTO=IT.ID_PRODUCTO AND ID_SITIO=" & CStr(idSitio) & "
                                                                              GROUP BY ID_PRODUCTO)
                                                ) AS PRECIO_ACTUAL,
                                                CASE WHEN COALESCE(IT.PORC_DESCUENTO, 0) > 0 
                                                     THEN (ROUND(IT.PRECIO_UNITARIO) - ((ROUND(IT.PRECIO_UNITARIO) * COALESCE(IT.PORC_DESCUENTO, 0)) / 100))
                                                     ELSE ROUND(IT.PRECIO_UNITARIO)
                                                END AS COSTO_UNITARIO,
                                                IT.PRECIO_UNITARIO AS PRECIO_UNITARIO,
                                                COALESCE(IT.PORC_DESCUENTO, 0) AS PORC_DESCUENTO,
                                                PR_PRODUCTOS.PRECIO_VENTA
                                        FROM STK_ITEMS_RECEP IT
                                                LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                                LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = IT.ID_PRODUCTO
                                        WHERE IT.ID_RECEPCION=" & CStr(idRecepcion) & " 
                                        ORDER BY IT.NUMERO_ITEM ASC
                                )
                )
                "

        dt = contRecepcion.consultar(sql)

        If dt.Rows.Count <= 0 Then
            ControlMensajes.mensaje("Items de recepcion no encontrados", titulo, "WAR")
            txtNroRecepcion.Focus()
        Else
            gridItems.DataSource = dt
        End If
    End Sub
    

    Sub getDetallesItem(idProducto As Integer, costo As Integer, precio As Integer)
        Try
            Dim dt As New DataTable
            Dim sql As String = ""

            sql = "SELECT ROUND(COALESCE(PR.PRECIO_VENTA, 0)), ROUND(COALESCE(PR_UM_PRODUCTO.COSTO_REMPLAZO, 0))
                FROM PR_PRODUCTOS PR
                LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                WHERE PR.IDENTIFICADOR = " & idProducto.ToString
            dt = contRecepcion.consultar(sql)
            If dt.Rows.Count > 0 Then
                Dim precio_actual As Integer = 0

                Dim dtPrecio As New DataTable
                dtPrecio = contAudCambiosPrecio.consultar("select precio_nuevo from pr_aud_cambios_prec where identificador=(select max(identificador) from pr_aud_cambios_prec where id_producto=" & CStr(idProducto) & " and id_sitio=" & CStr(idSitio) & ")")
                If dtPrecio.Rows.Count > 0 Then
                    precio_actual = CInt(dtPrecio.Rows(0).Item(0))
                Else
                    dtPrecio = New DataTable
                    dtPrecio = contAudCambiosPrecio.consultar("select precio_nuevo from pr_aud_cambios_prec where identificador=(select max(identificador) from pr_aud_cambios_prec where id_producto=" & CStr(idProducto) & ")")
                    If dtPrecio.Rows.Count > 0 Then
                        precio_actual = CInt(dtPrecio.Rows(0).Item(0))
                    Else
                        precio_actual = 0
                    End If
                End If

                txtPrecioActual.Text = precio_actual
                txtCostoActual.Text = costo
                txtMargenActual.Text = ((precio_actual / costo) * 100) - 100

                If precio > 0 Then
                    txtMargenActualPu.Text = ((precio_actual / precio) * 100) - 100
                Else
                    txtMargenActualPu.Text = 0
                End If
            Else
                txtPrecioActual.Text = CStr(0)
                txtCostoActual.Text = CStr(0)
                txtMargenActual.Text = CStr(0) & "%"
            End If


            sql = "SELECT ROUND(COSTO_RECEPCION), TO_DATE(FECHA, 'dd/MM/yy'), ID_PRODUCTO FROM PR_VARIACION_COSTOS WHERE ID_PRODUCTO=" & idProducto.ToString & " ORDER BY FEC_CRE DESC"
            dt = contRecepcion.consultar(sql)
            If dt.Rows.Count > 0 Then
                Dim costo_actual As Integer = 0
                If dt.Rows.Count >= 2 Then
                    costo_actual = CInt(dt.Rows(1).Item(0))
                    txtFechaUltimoCosto.Text = dt.Rows(1).Item(1)
                Else
                    costo_actual = CInt(dt.Rows(0).Item(0))
                    txtFechaUltimoCosto.Text = dt.Rows(0).Item(1)
                End If
                txtCostoAnterior.Text = costo_actual
            Else
                txtCostoAnterior.Text = CStr(0)
                txtFechaUltimoCosto.Text = ""
            End If
        Catch ex As Exception
            'ControlMensajes.mensaje("Error: " & ex.Message, "Recargo de productos", "ERR")
        End Try
    End Sub

    Sub getSucursal(id)
        Dim dt As New DataTable
        dt = contAudCambiosPrecio.consultar("SELECT DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            txtSucursal.Text = CStr(dt.Rows(0).Item(0))
        Else
            ControlMensajes.mensaje("Sucursal no definida", "Recargo de productos", "ERR")
        End If
    End Sub

    Function redondeo(valor As Double) As Integer
        Dim returnVal As Integer = 0

        If valor - CInt(valor) >= 0.1 Then
            returnVal = valor + 1
        Else
            returnVal = valor
        End If

        Return returnVal
    End Function

    Function setTotalRedondeo(numero As Integer) As Integer
        If redondeoDialog <= 0 Then
            redondeoDialog = 50
        End If

        Dim result As Integer = 0
        result = redondeo(numero / redondeoDialog) * redondeoDialog
        Return result
    End Function

    Sub calcularTotal(porcentaje As Double, vr As String)
        Dim rowhandle As Integer = 0
        Dim precioUnitario As Integer = 0
        Dim costoUnitario As Integer = 0
        Dim margen As Double = 0
        Dim total As Integer = 0

        If vr = "T" Then
            For i As Integer = 0 To GridView1.RowCount - 1
                rowhandle = i
                precioUnitario = GridView1.GetRowCellValue(rowhandle, "PRECIO_UNITARIO")
                costoUnitario = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
                margen = (costoUnitario * porcentaje) / 100
                total = costoUnitario + margen

                If porcentaje > 0 Then
                    GridView1.SetRowCellValue(rowhandle, "TOTAL", setTotalRedondeo(total))
                    GridView1.SetRowCellValue(rowhandle, "MARGEN", porcentaje)
                End If
                calcularMargen(vr)
            Next
        End If

        If vr = "F" Then
            rowhandle = GridView1.FocusedRowHandle
            precioUnitario = GridView1.GetRowCellValue(rowhandle, "PRECIO_UNITARIO")
            costoUnitario = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
            margen = (costoUnitario * porcentaje) / 100
            total = costoUnitario + margen

            If porcentaje > 0 Then
                GridView1.SetRowCellValue(rowhandle, "TOTAL", setTotalRedondeo(total))
            End If
            calcularMargen(vr)
        End If

    End Sub

    Sub calcularMargen(vr)
        Try
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
            GridView1.FocusedColumn = GridView1.VisibleColumns(7)

            Dim rowhandle As Integer = 0
            Dim total As Integer = 0
            Dim costoUnitario As Integer = 0
            Dim margen As Double = 0

            If vr = "T" Then
                For i As Integer = 0 To GridView1.RowCount - 1
                    rowhandle = i
                    total = setTotalRedondeo(GridView1.GetRowCellValue(rowhandle, "TOTAL"))
                    costoUnitario = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
                    margen = ((total / costoUnitario) * 100) - 100

                    If total > 0 Then
                        GridView1.SetRowCellValue(rowhandle, "MARGEN", margen)
                        GridView1.SetRowCellValue(rowhandle, "TOTAL", setTotalRedondeo(total))
                    End If
                Next
            End If

            If vr = "F" Then
                rowhandle = GridView1.FocusedRowHandle
                total = setTotalRedondeo(GridView1.GetRowCellValue(rowhandle, "TOTAL"))
                costoUnitario = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
                margen = ((total / costoUnitario) * 100) - 100

                If total > 0 Then
                    GridView1.SetRowCellValue(rowhandle, "MARGEN", margen)
                    GridView1.SetRowCellValue(rowhandle, "TOTAL", setTotalRedondeo(total))
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function validarCosto() As Boolean
        Dim costo As Integer = 0
        Dim total As Integer = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            total = GridView1.GetRowCellValue(i, "TOTAL")
            costo = GridView1.GetRowCellValue(i, "COSTO_TOTAL")
            If total < costo Then
                GridView1.FocusedRowHandle = i
                GridView1.FocusedColumn = GridView1.VisibleColumns(7)
                Return False
            End If
        Next

        Return True
    End Function


    Sub actualizarPrecios()

        If validarCosto() = False Then
            ControlMensajes.mensaje("Total debe ser mayor a costo", titulo, "WAR")
            Return
        End If



        Dim idProducto As Integer = 0
        Dim precioUnitario As Integer = 0
        Dim idUnidadMedida As Integer = 0
        Dim precioActual As Integer = 0
        Dim porcRecargo As Integer = 0
        Dim idProveedor As Integer = 0
        Dim codigoBarras As String = ""
        Dim fecha As Date = Nothing
        Dim result As Boolean = False

        For i As Integer = 0 To GridView1.RowCount - 1
            idProducto = GridView1.GetRowCellValue(i, "ID_PRODUCTO")
            idUnidadMedida = GridView1.GetRowCellValue(i, "ID_UNIDAD_MEDIDA")
            precioUnitario = GridView1.GetRowCellValue(i, "TOTAL")
            precioActual = GridView1.GetRowCellValue(i, "PRECIO_ACTUAL")
            codigoBarras = GridView1.GetRowCellValue(i, "CODIGO_BARRAS")
            fecha = Convert.ToDateTime(Now.ToString("dd/MM/yyyy"))
            porcRecargo = GridView1.GetRowCellValue(i, "MARGEN")
            idProveedor = GridView1.GetRowCellValue(i, "ID_PROVEEDOR")

            If precioUnitario > 0 Then
                If contProducto.actualizarPrecioVenta(idProducto, precioUnitario) = False Then
                    ControlMensajes.mensaje("Precio no actualizado(PR)", titulo, "WAR")
                    result = False
                    Return
                End If

                If contUmProducto.actualizarPrecioVenta(idProducto, precioUnitario) = False Then
                    ControlMensajes.mensaje("Precio no actualizado(UM)", titulo, "WAR")
                    result = False
                    Return
                End If

                Dim idAudCambioPrecio As Integer = contAudCambiosPrecio.identificador()
                If contAudCambiosPrecio.insertarAudCambio(idProducto, idUnidadMedida, "PV", precioUnitario, fecha, precioActual, porcRecargo, "APPTRADE", codigoBarras, "N", idProveedor, "S", idEmpresa, idUnidad, idSitio, idAudCambioPrecio, fecha) = False Then
                    ControlMensajes.mensaje("Auditoria de precio no registrado", titulo, "WAR")
                    result = False
                    Return
                End If

                Dim dtCajas As New DataTable
                Dim idCaja As Integer = 0
                Dim idPrecioAplicar As Integer = 0
                Dim queryCajas As String = ""
                If idSitio > 0 Then
                    queryCajas = "SELECT * FROM TC_CAJAS WHERE ACTIVO='S' AND ID_SITIO = " & CStr(idSitio)
                Else
                    queryCajas = "SELECT * FROM TC_CAJAS WHERE ACTIVO='S'"
                End If

                dtCajas = contProducto.consultar(queryCajas)
                If dtCajas.Rows.Count > 0 Then
                    For j As Integer = 0 To dtCajas.Rows.Count - 1
                        idCaja = CInt(dtCajas.Rows(j).Item(0))
                        idPrecioAplicar = contPreciosAplicar.identificador()
                        If contPreciosAplicar.insertarPrecioAplicar(idPrecioAplicar, idEmpresa, idUnidad, idSitio, idProducto, idUnidadMedida, idCaja, precioUnitario, fecha, precioActual, codigoBarras) = False Then
                            ControlMensajes.mensaje("Precio a aplicar no registrado", titulo, "WAR")
                            result = False
                            Return
                        End If
                    Next
                Else
                    ControlMensajes.mensaje("Cajas no definidas", titulo, "WAR")
                End If
                result = True
            End If


        Next

        If result Then
            ControlMensajes.mensaje("Cambios de precio realizados", titulo, "INF")
            limpiar()
        End If
    End Sub

    Private Sub txtNroRecepcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroRecepcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNroRecepcion.Text IsNot "" Then
                getRecepcion()
                GridView1.FocusedColumn = GridView1.VisibleColumns(6)
                GridView1.ShowEditor()
            End If
        End If
    End Sub

    Private Sub txtMargen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMargen.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(7)
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            Dim porcentaje As Double = GridView1.GetRowCellValue(rowhandle, "MARGEN")
            calcularTotal(porcentaje, "F")
            GridView1.FocusedColumn = GridView1.VisibleColumns(7)
        End If
    End Sub

    Private Sub txtMargen_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMargen.Validating
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim idProducto As Double = GridView1.GetRowCellValue(rowhandle, "ID_PRODUCTO")
        Dim costo As Double = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
        Dim precio As Double = GridView1.GetRowCellValue(rowhandle, "PRECIO_UNITARIO")
        getDetallesItem(idProducto, costo, precio)
    End Sub

    Private Sub txtTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            calcularMargen("F")
            GridView1.FocusedRowHandle = GridView1.FocusedRowHandle + 1
            GridView1.FocusedColumn = GridView1.VisibleColumns(6)
        End If
    End Sub

    Private Sub txtTotal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTotal.Validating
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim idProducto As Double = GridView1.GetRowCellValue(rowhandle, "ID_PRODUCTO")
        Dim costo As Double = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
        Dim precio As Double = GridView1.GetRowCellValue(rowhandle, "PRECIO_UNITARIO")
        getDetallesItem(idProducto, costo, precio)
    End Sub

    Private Sub btnMargen_Click(sender As Object, e As EventArgs) Handles btnMargen.Click
        Try
            Dim Message, Title, defecto, MyValue
            Message = "Ingrese margen a aplicar"
            Title = "Margen"
            defecto = ""
            MyValue = InputBox(Message, Title, defecto)
            calcularTotal(MyValue, "T")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRedondeo_Click(sender As Object, e As EventArgs) Handles btnRedondeo.Click
        Try
            Dim Message, Title, defecto, rowhandle, porcentaje
            Message = "Ingrese numero de redondeo"
            Title = "Redondeo"
            defecto = ""
            redondeoDialog = InputBox(Message, Title, defecto)
            For i As Integer = 0 To GridView1.RowCount - 1
                rowhandle = GridView1.FocusedRowHandle
                porcentaje = GridView1.GetRowCellValue(rowhandle, "MARGEN")
                calcularTotal(porcentaje, "T")
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        actualizarPrecios()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub gridItems_Click(sender As Object, e As EventArgs) Handles gridItems.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim idProducto As Double = GridView1.GetRowCellValue(rowhandle, "ID_PRODUCTO")
        Dim costo As Double = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
        Dim precio As Double = GridView1.GetRowCellValue(rowhandle, "PRECIO_UNITARIO")
        getDetallesItem(idProducto, costo, precio)
    End Sub

    Private Sub gridItems_KeyDown(sender As Object, e As KeyEventArgs) Handles gridItems.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            Dim idProducto As Double = GridView1.GetRowCellValue(rowhandle, "ID_PRODUCTO")
            Dim costo As Double = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
            Dim precio As Double = GridView1.GetRowCellValue(rowhandle, "PRECIO_UNITARIO")
            getDetallesItem(idProducto, costo, precio)
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim idProducto As Double = GridView1.GetRowCellValue(rowhandle, "ID_PRODUCTO")
        Dim costo As Double = GridView1.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
        Dim precio As Double = GridView1.GetRowCellValue(rowhandle, "PRECIO_UNITARIO")
        getDetallesItem(idProducto, costo, precio)
    End Sub

    Private Sub txtPrecioActual_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecioActual.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtMargenActual_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMargenActual.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtMargenActualPu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMargenActualPu.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCostoActual_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCostoActual.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtCostoAnterior_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCostoAnterior.KeyDown
        e.Handled = True
    End Sub

    Private Sub txtFechaUltimoCosto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaUltimoCosto.KeyDown
        e.Handled = True
    End Sub


End Class
