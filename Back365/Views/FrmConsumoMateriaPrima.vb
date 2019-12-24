Public Class FrmConsumoMateriaPrima

    Dim titulo As String = "Consumo de materia prima"
    Dim contStkMovimStock As New ContStkMovimStock
    Dim contStock As New ContStkStockProd
    Dim dtItems As New DataTable

    Dim idEmpresa As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idSitio As Integer = 0
    Dim idTransaccion As Integer = 0
    Dim vrAccionTransaccion As String = ""
    Dim idAlmacen As Integer = 0

    Private Sub FrmConsumoMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFecha.Visible = False
        crearCursor()
    End Sub

    Sub limpiarBusquedaProducto()
        txtCodigoBarras.Text = ""
        txtCantidad.Text = ""
        txtCodigoBarras.Focus()
    End Sub

    Sub cancelar()
        idEmpresa = 0
        idUnidad = 0
        idSitio = 0
        idAlmacen = 0
        idTransaccion = 0
        txtEmpresa.Text = ""
        txtUnidadOperat.Text = ""
        txtSucursal.Text = ""
        txtAlmacen.Text = ""
        txtTransaccion.Text = ""
        txtFecha.Text = ""
    End Sub

    Sub crearCursor()
        dtItems.Columns.Add("CODIGO_BARRAS")
        dtItems.Columns.Add("DESCRIPCION")
        dtItems.Columns.Add("CANTIDAD")
        dtItems.Columns.Add("PRECIO_UNITARIO")
        dtItems.Columns.Add("TOTAL")
        dtItems.Columns.Add("ID_PRODUCTO")
        dtItems.Columns.Add("ID_UND_MEDIDA")
        dtItems.Columns.Add("COSTO_UNITARIO")

        gridItems.DataSource = dtItems
    End Sub

    Sub vistas(verificador As String)
        If verificador = "EM" Then
            Dim frm As New FrmVistaFndEmpresas
            frm.setFrmConsumoMateriaPrima(Me, "FrmConsumoMateriaPrima")
            frm.ShowDialog()
        End If

        If verificador = "UO" Then
            Dim frm As New FrmVistaCoUnidadesOperat
            frm.setFrmConsumoMateriaPrima(Me, "FrmConsumoMateriaPrima")
            frm.ShowDialog()
        End If

        If verificador = "SI" Then
            Dim frm As New FrmVistaFndSitios
            frm.setFrmConsumoMateriaPrima(Me, "FrmConsumoMateriaPrima")
            frm.ShowDialog()
        End If

        If verificador = "TR" Then
            Dim frm As New FrmVistaStkTransaccionesStock
            frm.setFrmConsumoMateriaPrima(Me, "FrmConsumoMateriaPrima")
            frm.ShowDialog()
        End If

        If verificador = "AL" Then
            Dim frm As New FrmVistaStkAlmacenes
            frm.setFrmConsumoMateriaPrima(Me, "FrmConsumoMateriaPrima")
            frm.ShowDialog()
        End If

        If verificador = "FE" Then
            If cldFecha.Visible = True Then
                cldFecha.Visible = False
            Else
                cldFecha.Visible = True
                cldFecha.Focus()
            End If
        End If

        If verificador = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmConsumoMateriaPrima")
            frm.ShowDialog()
        End If
    End Sub


    Public Sub getEmpresa(id As String)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("Select IDENTIFICADOR, NOMBRE FROM FND_PARM_EMPRESAS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idEmpresa = CInt(dt.Rows(0).Item(0))
            txtEmpresa.Text = CStr(dt.Rows(0).Item(1))
            txtIdEmpresa.Text = CStr(idEmpresa)
            txtEmpresa.Focus()
        Else
            ControlMensajes.mensaje("Empresa no definida", titulo, "WAR")
            txtEmpresa.Text = ""
            txtIdEmpresa.Text = ""
            txtIdEmpresa.Focus()
        End If
    End Sub

    Public Sub getUnidadOperat(id As String)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("Select IDENTIFICADOR, DESCRIPCION FROM CO_UNIDADES_OPERAT WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idUnidad = CInt(dt.Rows(0).Item(0))
            txtUnidadOperat.Text = CStr(dt.Rows(0).Item(1))
            txtIdUnidad.Text = CStr(idUnidad)
            txtUnidadOperat.Focus()
        Else
            ControlMensajes.mensaje("Unidad operativa no definida", titulo, "WAR")
            txtUnidadOperat.Text = ""
            txtIdUnidad.Text = ""
            txtIdUnidad.Focus()
        End If
    End Sub

    Public Sub getSitio(id As String)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("Select IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
            txtIdSucursal.Text = CStr(idSitio)
            txtSucursal.Focus()
        Else
            ControlMensajes.mensaje("Sucursal no definida", titulo, "WAR")
            txtSucursal.Text = ""
            txtIdSucursal.Text = ""
            txtIdSucursal.Focus()
        End If
    End Sub

    Public Sub getTransaccion(id As String)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("Select IDENTIFICADOR, NOMBRE, VR_ACCION FROM STK_TRANSACCIONES WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idTransaccion = CInt(dt.Rows(0).Item(0))
            txtTransaccion.Text = CStr(dt.Rows(0).Item(1))
            vrAccionTransaccion = CStr(dt.Rows(0).Item(2))
            txtIdTransaccion.Text = CStr(idTransaccion)
            txtTransaccion.Focus()
        Else
            ControlMensajes.mensaje("Transaccion no definida", titulo, "WAR")
            txtTransaccion.Text = ""
            txtIdTransaccion.Text = ""
            txtIdTransaccion.Focus()
        End If
    End Sub


    Public Sub getAlmacen(id As String)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("Select IDENTIFICADOR, DESCRIPCION FROM STK_ALMACENES WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idAlmacen = CInt(dt.Rows(0).Item(0))
            txtAlmacen.Text = CStr(dt.Rows(0).Item(1))
            txtIdAlmacen.Text = CStr(idAlmacen)
            txtAlmacen.Focus()
        Else
            ControlMensajes.mensaje("Almacen no definido", titulo, "WAR")
            txtAlmacen.Text = ""
            txtIdAlmacen.Text = ""
            txtIdAlmacen.Focus()
        End If
    End Sub

    Public Sub leerCodigoBarras(codigoBarras As String)
        Dim ceros As String = ""
        If codigoBarras.Length < 13 Then
            For i As Integer = 0 To (13 - codigoBarras.Length)
                ceros += "0"
            Next
            codigoBarras = codigoBarras & ceros
        End If

        Dim codTipoUnidad As Integer = CInt(codigoBarras.Substring(0, 2))
        Dim codBalanza As Integer = CInt(codigoBarras.Substring(2, 5))
        Dim codCantidad As Double = CDbl(codigoBarras.Substring(7, 5))

        If codTipoUnidad = 20 Then
            txtCantidad.Text = CStr(codCantidad / 1000)
            getProducto(" WHERE PR.CODIGO_BALANZA = " & CStr(codBalanza))
        ElseIf codTipoUnidad = 24 Then
            txtCantidad.Text = codCantidad
            getProducto(" WHERE PR.CODIGO_BALANZA = " & CStr(codBalanza))
        Else
            If txtCantidad.Text.Replace(" ", "") = "" Then
                txtCantidad.Text = "1"
            End If
            getProducto(" WHERE PR.CODIGO_BARRAS = '" & codigoBarras & "'")
        End If
    End Sub

    Sub getProducto(condicion As String)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("SELECT PR.IDENTIFICADOR, PR.CODIGO_BARRAS, PR.DESCRIPCION, 
                                           ROUND( PR_UM_PRODUCTO.COSTO_REMPLAZO) AS COSTO_UNITARIO, ROUND(PR.PRECIO_VENTA), PR.ID_UNIDAD_MEDIDA 
                                            FROM PR_PRODUCTOS PR 
                                            LEFT JOIN PR_UM_PRODUCTO ON PR.IDENTIFICADOR = PR_UM_PRODUCTO.ID_PRODUCTO " & condicion)

        If dt.Rows.Count > 0 Then
            Dim newRow As DataRow = (TryCast(gridItems.DataSource, DataTable)).NewRow()
            newRow("CODIGO_BARRAS") = dt.Rows(0).Item(1)
            newRow("DESCRIPCION") = dt.Rows(0).Item(2)
            newRow("CANTIDAD") = txtCantidad.Text
            newRow("PRECIO_UNITARIO") = dt.Rows(0).Item(4)
            newRow("TOTAL") = (dt.Rows(0).Item(4) * CDbl(txtCantidad.Text))
            newRow("ID_PRODUCTO") = dt.Rows(0).Item(0)
            newRow("ID_UND_MEDIDA") = dt.Rows(0).Item(5)
            newRow("COSTO_UNITARIO") = dt.Rows(0).Item(3)

            TryCast(gridItems.DataSource, DataTable).Rows.Add(newRow)
            gridItems.RefreshDataSource()

            limpiarBusquedaProducto()
        Else
            ControlMensajes.mensaje("Producto no definido", titulo, "WAR")
            txtCodigoBarras.Focus()
            limpiarBusquedaProducto()
        End If
    End Sub

    Function validarCampos() As Boolean
        If idEmpresa <= 0 Then
            ControlMensajes.mensaje("El campo empresa no puede estar vacio", titulo, "WAR")
            txtEmpresa.Focus()
            Return False
        End If
        If idUnidad <= 0 Then
            ControlMensajes.mensaje("El campo unidad operativa no puede estar vacio", titulo, "WAR")
            txtUnidadOperat.Focus()
            Return False
        End If
        If idSitio <= 0 Then
            ControlMensajes.mensaje("El campo sucursal no puede estar vacio", titulo, "WAR")
            txtSucursal.Focus()
            Return False
        End If
        If idTransaccion <= 0 Then
            ControlMensajes.mensaje("El campo transaccion no puede estar vacio", titulo, "WAR")
            txtTransaccion.Focus()
            Return False
        End If
        If txtFecha.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha no puede estar vacio", titulo, "WAR")
            txtFecha.Focus()
            Return False
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe agregar items al movimiento", titulo, "WAR")
            txtFecha.Focus()
            Return False
        End If

        Return True
    End Function


    Sub insertarMovimientoStock()
        If validarCampos() = False Then
            Return
        End If

        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "INF")
        End If

        Dim idMovimiento As Integer = contStkMovimStock.idMovimStock
        Dim descripcion As String = txtComentario.Text
        Dim fecha As String = txtFecha.Text

        If contStkMovimStock.insertarMovimStock(idMovimiento, idEmpresa, idUnidad, fecha, "00", idSitio, "APPUSR", "APPUSR", "0", "ST", idTransaccion, "N", descripcion) = False Then
            ControlMensajes.mensaje("Movimiento de stock no registrado", titulo, "WAR")
            Return
        End If

        Dim idItemMovimStock As Integer = 0
        Dim idProducto As Integer = 0
        Dim idUndMedida As Integer = 0
        Dim cantidad As Double = 0
        Dim cantidad_ub As Double = 0
        Dim precioUnitarioUb As Integer = 0
        Dim costoUnitarioUb As Integer = 0
        Dim precioUnitario As Integer = 0
        Dim costoUnitario As Integer = 0
        Dim codigoBarras As String = ""

        For i As Integer = 0 To (GridView1.RowCount - 1)
            idItemMovimStock = contStkMovimStock.idItemMovimStock()
            idProducto = CInt(GridView1.GetRowCellValue(i, "ID_PRODUCTO"))
            idUndMedida = CInt(GridView1.GetRowCellValue(i, "ID_UND_MEDIDA"))
            cantidad = CDbl(GridView1.GetRowCellValue(i, "CANTIDAD"))
            cantidad_ub = CDbl(GridView1.GetRowCellValue(i, "CANTIDAD"))
            precioUnitarioUb = CInt(GridView1.GetRowCellValue(i, "PRECIO_UNITARIO"))
            costoUnitarioUb = CInt(GridView1.GetRowCellValue(i, "COSTO_UNITARIO"))
            precioUnitario = CInt(GridView1.GetRowCellValue(i, "PRECIO_UNITARIO"))
            costoUnitario = CInt(GridView1.GetRowCellValue(i, "COSTO_UNITARIO"))
            codigoBarras = CStr(GridView1.GetRowCellValue(i, "CODIGO_BARRAS"))

            If contStkMovimStock.insertarItemsMovimStock(idItemMovimStock, idMovimiento, idEmpresa, idUnidad, idTransaccion, idAlmacen, vrAccionTransaccion, idProducto, idUndMedida, cantidad, cantidad_ub, precioUnitarioUb, costoUnitarioUb, precioUnitario, costoUnitario, codigoBarras, fecha) = False Then
                ControlMensajes.mensaje("Item de stock no registrado", titulo, "WAR")
                Return
            End If

            If contStock.actualizarExistencia(cantidad, idProducto, idAlmacen, vrAccionTransaccion) = False Then
                ControlMensajes.mensaje("Existencia no actualizada", titulo, "WAR")
                Return
            End If

        Next

        ControlMensajes.mensaje("Operacion registrada", titulo, "INF")
        cancelar()
        limpiarBusquedaProducto()


    End Sub


    Private Sub txtEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEmpresa.Text IsNot "" Then
                txtIdUnidad.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("EM")
        End If
    End Sub

    Private Sub btnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpresa.Click
        vistas("EM")
    End Sub

    Private Sub txtUnidadOperat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnidadOperat.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUnidadOperat.Text IsNot "" Then
                txtIdSucursal.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("UO")
        End If
    End Sub

    Private Sub btnBuscarUnidadOperat_Click(sender As Object, e As EventArgs) Handles btnBuscarUnidadOperat.Click
        vistas("UO")
    End Sub

    Private Sub btnBuscarSucursal_Click(sender As Object, e As EventArgs) Handles btnBuscarSucursal.Click
        vistas("SI")
    End Sub

    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSucursal.Text IsNot "" Then
                txtIdAlmacen.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub btnAlmacenes_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        vistas("AL")
    End Sub

    Private Sub txtAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSucursal.Text IsNot "" Then
                txtIdTransaccion.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("AL")
        End If
    End Sub

    Private Sub btnTransacciones_Click(sender As Object, e As EventArgs) Handles btnTransacciones.Click
        vistas("TR")
    End Sub

    Private Sub txtTransaccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTransaccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTransaccion.Text IsNot "" Then
                txtFecha.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("TR")
        End If
    End Sub

    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFecha.Text = "  /  /" Then
            Else
                txtComentario.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FE")
        End If
    End Sub

    Private Sub btnFechaDesde_Click(sender As Object, e As EventArgs) Handles btnFechaDesde.Click
        vistas("FE")
    End Sub

    Private Sub cldFecha_DoubleClick(sender As Object, e As EventArgs) Handles cldFecha.DoubleClick
        txtFecha.Text = cldFecha.DateTime.ToString
        txtFecha.Focus()
        vistas("FE")
    End Sub

    Private Sub cldFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFecha.Text = cldFecha.DateTime.ToString
            txtFecha.Focus()
            vistas("FE")
        End If
        If e.KeyCode = Keys.Escape Then
            vistas("FE")
        End If
    End Sub

    Private Sub txtCodigoBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigoBarras.Text.Replace(" ", "") = "" Then
                txtCantidad.Focus()
            Else
                leerCodigoBarras(txtCodigoBarras.Text)
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCodigoBarras.Focus()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        insertarMovimientoStock()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelar la operacion", titulo) Then
            cancelar()
        Else
            ControlMensajes.mensaje("Operacion no cancelada", titulo, "INF")
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If ControlMensajes.msj_confirmacion("Deseas quietar el item", titulo) Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle < 0 Then
                ControlMensajes.mensaje("Debe seleccionar un item para quitar", titulo, "WAR")
            Else
                GridView1.DeleteRow(rowhandle)
            End If
        End If
    End Sub


    Private Sub txtIdEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtIdEmpresa.Text.Replace(" ", "") = "" Then
                txtEmpresa.Focus()
            Else
                getEmpresa(txtIdEmpresa.Text)
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("EM")
        End If
    End Sub

    Private Sub txtIdUnidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdUnidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtIdUnidad.Text.Replace(" ", "") = "" Then
                txtUnidadOperat.Focus()
            Else
                getUnidadOperat(txtIdUnidad.Text)
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("UO")
        End If
    End Sub

    Private Sub txtIdSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtIdSucursal.Text.Replace(" ", "") = "" Then
                txtSucursal.Focus()
            Else
                getSitio(txtIdSucursal.Text)
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub txtIdAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtIdAlmacen.Text.Replace(" ", "") = "" Then
                txtAlmacen.Focus()
            Else
                getAlmacen(txtIdAlmacen.Text)
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("AL")
        End If
    End Sub

    Private Sub txtIdTransaccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdTransaccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtIdTransaccion.Text.Replace(" ", "") = "" Then
                txtTransaccion.Focus()
            Else
                getTransaccion(txtIdTransaccion.Text)
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("TR")
        End If
    End Sub

    Private Sub txtComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCodigoBarras.Focus()
        End If
    End Sub

End Class