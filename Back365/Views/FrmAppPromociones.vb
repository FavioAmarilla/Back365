Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class FrmAppPromociones

    Dim contPromocion As New ContAppPromociones
    Dim contLiquidacionPromo As New ContAppLiquidacionPromo
    Dim contProducto As New ContPrProductos
    Dim contUmProducto As New ContPrUmProducto
    Dim contPrecioAplicar As New ContPsPreciosAplicar
    Dim contAudiCambioPrecio As New ContPrAudCambiosPrec

    Dim dtItemsPromocion As New DataTable

    Dim titulo As String = "Promociones"
    Dim existePromocion As Boolean = False
    Dim idProveedor As Integer = 0
    Dim idEmpresa As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idSitio As Integer = 0S
    Dim idPromocion As Integer = 0
    Dim idLiquidacion As Integer = 0
    Dim activo As String = ""
    Dim cerrado As String = ""
    Dim confirmado As String = ""
    Public cargarProducto As String = ""

    Private Sub FrmPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Promociones
        limpiar()
        btnActivarPromo.Enabled = False
        '
        'Liquidaciones
        obtenerLiquidaciones()
    End Sub

    Sub limpiar()
        txtEmpresa.Text = ""
        txtUnidadOperat.Text = ""
        txtSucursal.Text = ""
        txtDescripcion.Text = ""
        cboTipoPromo.SelectedIndex = -1
        txtProveedor.Text = ""
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
        gridItemsPromocion.DataSource = Nothing
        existePromocion = False
        idProveedor = 0
        idEmpresa = 0
        idUnidad = 0
        idSitio = 0
        idPromocion = 0
        btnAceptar.Enabled = True
        btnActivarPromo.Enabled = False
        btnCancelar.Enabled = True

        obtenerLiquidaciones()
        gridItemsLiquidacion.DataSource = Nothing
        btnDesactivarPromo.Enabled = True
        btnConfirmarPromo.Enabled = True
    End Sub

    Private Sub crear_cursor()
        dtItemsPromocion = New DataTable
        dtItemsPromocion.Columns.Add("ID_PRODUCTO")
        dtItemsPromocion.Columns.Add("CODIGO_BARRAS")
        dtItemsPromocion.Columns.Add("PRODUCTO")
        dtItemsPromocion.Columns.Add("PRECIO_ACTUAL")
        dtItemsPromocion.Columns.Add("MARGEN")
        dtItemsPromocion.Columns.Add("COSTO_UNITARIO")
        dtItemsPromocion.Columns.Add("PRECIO_PROMO")
        dtItemsPromocion.Columns.Add("DIFERENCIA_PRECIO")
        dtItemsPromocion.Columns.Add("PORC_DIFERENCIA")
        dtItemsPromocion.Columns.Add("ID_UNIDAD_MEDIDA")
        dtItemsPromocion.Columns.Add("NUEVO")
        dtItemsPromocion.Columns.Add("ELIMINAR")

        gridItemsPromocion.DataSource = dtItemsPromocion
    End Sub

    Sub vistas(verificador As String)
        If verificador = "FD" Then
            If cldFechaDesde.Visible = True Then
                cldFechaDesde.Visible = False
            Else
                cldFechaDesde.Visible = True
                cldFechaDesde.Focus()
            End If
        End If
        If verificador = "FH" Then
            If cldFechaHasta.Visible = True Then
                cldFechaHasta.Visible = False
            Else
                cldFechaHasta.Visible = True
                cldFechaHasta.Focus()
            End If
        End If
        If verificador = "PV" Then
            Dim frm As New FrmVistaCpProveedores
            frm.setFrmActivo("FrmAppPromociones")
            frm.ShowDialog()
        End If
        If verificador = "EM" Then
            Dim frm As New FrmVistaFndEmpresas
            frm.setFrmActivo("FrmAppPromociones")
            frm.ShowDialog()
        End If
        If verificador = "UO" Then
            If txtEmpresa.Text = "" Then
                ControlMensajes.mensaje("Debe seleccionar empresa", titulo, "WAR")
                txtEmpresa.Focus()
                Return
            End If
            Dim frm As New FrmVistaCoUnidadesOperat
            frm.setFrmActivo("FrmAppPromociones")
            frm.ShowDialog()
        End If
        If verificador = "SI" Then
            If txtEmpresa.Text = "" Then
                ControlMensajes.mensaje("Debe seleccionar empresa", titulo, "WAR")
                txtEmpresa.Focus()
                Return
            End If
            If txtUnidadOperat.Text = "" Then
                ControlMensajes.mensaje("Debe seleccionar unidad operat.", titulo, "WAR")
                txtEmpresa.Focus()
                Return
            End If
            Dim frm As New FrmVistaFndSitios
            frm.setFrmActivo("FrmAppPromociones")
            frm.ShowDialog()
        End If

        If verificador = "PR" Then
            If txtEmpresa.Text = "" Then
                ControlMensajes.mensaje("Debe seleccionar empresa", titulo, "WAR")
                txtEmpresa.Focus()
                Return
            End If
            If txtUnidadOperat.Text = "" Then
                ControlMensajes.mensaje("Debe seleccionar unidad operat.", titulo, "WAR")
                txtEmpresa.Focus()
                Return
            End If
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmAppPromociones")
            frm.setIdProveedor(idProveedor)
            frm.ShowDialog()
        End If
    End Sub

    Public Sub setProveedor(id As String)
        Dim dt As New DataTable
        dt = contPromocion.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idProveedor = CInt(dt.Rows(0).Item(0))
            txtProveedor.Text = CStr(dt.Rows(0).Item(1))
            txtProveedor.Focus()
        End If
    End Sub

    Public Sub setEmpresa(id As String)
        Dim dt As New DataTable
        dt = contPromocion.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PARM_EMPRESAS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idEmpresa = CInt(dt.Rows(0).Item(0))
            txtEmpresa.Text = CStr(dt.Rows(0).Item(1))
            txtEmpresa.Focus()
        End If
    End Sub

    Public Sub setUnidadOperat(id As String)
        Dim dt As New DataTable
        dt = contPromocion.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM CO_UNIDADES_OPERAT WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idUnidad = CInt(dt.Rows(0).Item(0))
            txtUnidadOperat.Text = CStr(dt.Rows(0).Item(1))
            txtUnidadOperat.Focus()
        End If
    End Sub

    Public Sub setSitio(id As String)
        Dim dt As New DataTable
        dt = contPromocion.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
            txtSucursal.Focus()
        Else
            idSitio = 0
            txtSucursal.Text = ""
            txtSucursal.Focus()
        End If
    End Sub

    Public Sub getProducto(codigoBarras As String)
        If codigoBarras.Replace(" ", "") IsNot "" Then
            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            Dim dt As New DataTable
            Dim proveedor As String = ""

            If idProveedor > 0 Then
                proveedor = " AND ID_PROVEEDOR=" & idProveedor.ToString
            End If

            dt = contPromocion.consultar("SELECT P.IDENTIFICADOR, P.CODIGO_BARRAS, P.DESCRIPCION , P.PRECIO_VENTA,
                                        COALESCE(ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO + ((PR_UM_PRODUCTO.COSTO_REMPLAZO * FND_TIPOS_IMPUESTO.VALOR)/100)), 0), PR_UM_PRODUCTO.ID_UNIDAD_MEDIDA
                                        FROM PR_PRODUCTOS P 
                                        LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = P.IDENTIFICADOR
                                        LEFT JOIN FND_TIPOS_IMPUESTO ON FND_TIPOS_IMPUESTO.IDENTIFICADOR = P.ID_TIPO_IMPUESTO
                                        WHERE P.CODIGO_BARRAS = '" & codigoBarras & "'" & proveedor)

            If dt.Rows.Count > 0 Then
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "ID_PRODUCTO", dt.Rows(0).Item(0))
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "CODIGO_BARRAS", dt.Rows(0).Item(1))
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRODUCTO", dt.Rows(0).Item(2))
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRECIO_ACTUAL", dt.Rows(0).Item(3))
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "MARGEN", 0)
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "COSTO_UNITARIO", dt.Rows(0).Item(4))
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRECIO_PROMO", 0)
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "DIFERENCIA_PRECIO", 0)
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "PORC_DIFERENCIA", 0)
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "ID_UNIDAD_MEDIDA", dt.Rows(0).Item(5))
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "NUEVO", "S")
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "ELIMINAR", "N")

                cargarProducto = "N"
            Else
                ControlMensajes.mensaje("Producto no definido", titulo, "ERR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
            End If

        End If
    End Sub

    Sub addProductos(codigoBarras As String)
        If GridViewItemsPromocion.RowCount <= 0 Then
            crear_cursor()
        End If

        Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
        Dim dt As New DataTable
        Dim proveedor As String = ""

        If idProveedor > 0 Then
            proveedor = " AND ID_PROVEEDOR=" & idProveedor.ToString
        End If

        codigoBarras = codigoBarras.Replace(" ", "")
        codigoBarras = codigoBarras.Replace("vbCrLf", "")

        dt = contPromocion.consultar("SELECT P.IDENTIFICADOR, P.CODIGO_BARRAS, P.DESCRIPCION , P.PRECIO_VENTA,
                                        COALESCE( ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO), 0), PR_UM_PRODUCTO.ID_UNIDAD_MEDIDA
                                        FROM PR_PRODUCTOS P 
                                        LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = P.IDENTIFICADOR
                                        WHERE P.CODIGO_BARRAS = '" & codigoBarras & "'" & proveedor)

        If dt.Rows.Count > 0 Then
            Dim newRow As DataRow = (TryCast(gridItemsPromocion.DataSource, DataTable)).NewRow()
            newRow("ID_PRODUCTO") = dt.Rows(0).Item(0)
            newRow("CODIGO_BARRAS") = dt.Rows(0).Item(1)
            newRow("PRODUCTO") = dt.Rows(0).Item(2)
            newRow("PRECIO_ACTUAL") = dt.Rows(0).Item(3)
            newRow("MARGEN") = 0
            newRow("COSTO_UNITARIO") = dt.Rows(0).Item(4)
            newRow("PRECIO_PROMO") = 0
            newRow("DIFERENCIA_PRECIO") = 0
            newRow("PORC_DIFERENCIA") = 0
            newRow("ID_UNIDAD_MEDIDA") = dt.Rows(0).Item(5)
            newRow("NUEVO") = "S"
            newRow("ELIMINAR") = "N"

            TryCast(gridItemsPromocion.DataSource, DataTable).Rows.Add(newRow)
            gridItemsPromocion.RefreshDataSource()

            cargarProducto = "S"
        Else
            ControlMensajes.mensaje("Producto no definido: " & codigoBarras, titulo, "WAR")
        End If

        gridItemsPromocion.Focus()

    End Sub

    Sub calcularDiferencia()
        If cboTipoPromo.SelectedIndex < 0 Then
            ControlMensajes.mensaje("Debe seleccionar tipo de promocion", titulo, "WAR")
            cboTipoPromo.Focus()
            Return
        End If

        Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
        Dim precioActual As Integer = 0
        Dim costoUnitario As Integer = 0
        Dim precioPromo As Integer = 0
        Dim diferenciaPrecio As Integer = 0
        Dim porcDiferencia As Double = 0

        If GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO") <= 0 Then
            GridViewItemsPromocion.SetRowCellValue(rowhandle, "PORC_DIFERENCIA", 0)
            GridViewItemsPromocion.SetRowCellValue(rowhandle, "DIFERENCIA_PRECIO", 0)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(6)
            Return
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_ACTUAL")) Then
            Return
        Else
            precioActual = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_ACTUAL")
            If precioActual <= 0 Then
                ControlMensajes.mensaje("Precio actual debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
                Return
            End If
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")) Then
            Return
        Else
            precioPromo = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")
            If precioActual <= 0 Then
                ControlMensajes.mensaje("Precio promocional debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(5)
                Return
            End If
        End If


        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) Then
            Return
        Else
            costoUnitario = GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
            If costoUnitario <= 0 Then
                ControlMensajes.mensaje("Costo Unitario debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(4)
                Return
            End If
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PORC_DIFERENCIA")) Then
            Return
        Else
            porcDiferencia = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PORC_DIFERENCIA")
        End If

        If cboTipoPromo.SelectedIndex = 1 Then
            If porcDiferencia <= 0 Then
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRECIO_PROMO", 0)
            Else
                GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRECIO_PROMO", precioPromo)
            End If

            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(6)
            Return
        End If

        diferenciaPrecio = precioActual - precioPromo
        GridViewItemsPromocion.SetRowCellValue(rowhandle, "DIFERENCIA_PRECIO", diferenciaPrecio)

        If diferenciaPrecio > 0 And precioActual > 0 Then
            If cboTipoPromo.SelectedIndex = 0 Then
                porcDiferencia = (diferenciaPrecio / precioActual) * 100
            End If

            GridViewItemsPromocion.SetRowCellValue(rowhandle, "PORC_DIFERENCIA", porcDiferencia)
        Else
            GridViewItemsPromocion.SetRowCellValue(rowhandle, "PORC_DIFERENCIA", 0)
        End If

        ''si no se ingreso un margen se calculara
        'Dim margen As Integer = 0
        'If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "MARGEN")) Then
        '    Return
        'Else
        '    margen = GridViewItemsPromocion.GetRowCellValue(rowhandle, "MARGEN")
        '    If margen <= 0 Then
        '    End If
        'End If

        calcularPorcMargen()

        GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(6)
    End Sub

    Sub calcularDiferenciaPorc()
        If cboTipoPromo.SelectedIndex < 0 Then
            ControlMensajes.mensaje("Debe seleccionar tipo de promocion", titulo, "WAR")
            cboTipoPromo.Focus()
            Return
        End If

        Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
        Dim precioActual As Integer = 0
        Dim costoUnitario As Integer = 0
        Dim porcDiferencia As Double = 0
        Dim precioPromo As Integer = 0
        Dim diferenciaPrecio As Integer = 0

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) Then
            Return
        Else
            costoUnitario = GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
            If costoUnitario <= 0 Then
                ControlMensajes.mensaje("Costo Unitario debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(3)
                Return
            End If
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_ACTUAL")) Then
            Return
        Else
            precioActual = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_ACTUAL")
            If precioActual <= 0 Then
                ControlMensajes.mensaje("Precio actual debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
                Return
            End If
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PORC_DIFERENCIA")) Then
            Return
        Else
            porcDiferencia = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PORC_DIFERENCIA")
            If costoUnitario <= 0 Then
                ControlMensajes.mensaje("Porc. diferencia debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(6)
                Return
            End If
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")) Then
            Return
        Else
            precioPromo = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")
            If precioActual <= 0 Then
                ControlMensajes.mensaje("Precio promocional debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(4)
                Return
            End If
        End If


        If precioPromo > 0 Then
            If cargarProducto = "S" Then
                eliminarFilasVacias()
                GridViewItemsPromocion.FocusedRowHandle = rowhandle + 1
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
            Else
                eliminarFilasVacias()
                GridViewItemsPromocion.AddNewRow()
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
            End If
            Return
        End If

        If cboTipoPromo.SelectedIndex = 0 Then
            If cargarProducto = "S" Then
                eliminarFilasVacias()
                GridViewItemsPromocion.FocusedRowHandle = rowhandle + 1
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
            Else
                eliminarFilasVacias()
                GridViewItemsPromocion.AddNewRow()
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
            End If
            Return
        End If

        If cboTipoPromo.SelectedIndex = 1 Then
            diferenciaPrecio = (costoUnitario * porcDiferencia) / 100
            precioPromo = precioActual - diferenciaPrecio
        End If

        GridViewItemsPromocion.SetRowCellValue(rowhandle, "DIFERENCIA_PRECIO", diferenciaPrecio)
        GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRECIO_PROMO", precioPromo)

        If cargarProducto = "S" Then
            eliminarFilasVacias()
            GridViewItemsPromocion.FocusedRowHandle = rowhandle + 1
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
        Else
            eliminarFilasVacias()
            GridViewItemsPromocion.AddNewRow()
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
        End If


        calcularMargen()
    End Sub

    Sub calcularMargen()
        If cboTipoPromo.SelectedIndex = 1 Then
            Return
        End If

        Dim rowhandle = GridViewItemsPromocion.FocusedRowHandle
        Dim margen As Double = 0
        Dim precio_promo As Integer = 0
        Dim costo_unitario As Integer = 0

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) Then
            Return
        Else
            costo_unitario = GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
            If costo_unitario <= 0 Then
                ControlMensajes.mensaje("Costo unitario debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(3)
                Return
            End If
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "MARGEN")) Then
            Return
        Else
            margen = GridViewItemsPromocion.GetRowCellValue(rowhandle, "MARGEN")
            If margen <= 0 Then
                ControlMensajes.mensaje("Margen debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(4)
                Return
            End If
        End If

        precio_promo = costo_unitario + ((costo_unitario * margen) / 100)
        GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRECIO_PROMO", redondeoPrecioPromocional(precio_promo))


        calcularDiferencia()
        GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(5)

    End Sub

    Sub calcularPorcMargen()
        If cboTipoPromo.SelectedIndex = 1 Then
            Return
        End If

        Dim rowhandle = GridViewItemsPromocion.FocusedRowHandle
        Dim margen As Double = 0
        Dim costo_unitario As Integer = 0
        Dim precio_promo As Integer = 0

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) Then
            Return
        Else
            costo_unitario = GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")
            If costo_unitario <= 0 Then
                ControlMensajes.mensaje("Costo unitario debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(3)
                Return
            End If
        End If

        If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")) Then
            Return
        Else
            precio_promo = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")
            If precio_promo <= 0 Then
                ControlMensajes.mensaje("Precio promocional debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
                Return
            End If
        End If


        margen = ((precio_promo / costo_unitario) * 100) - 100

        GridViewItemsPromocion.SetRowCellValue(rowhandle, "MARGEN", margen)

    End Sub

    Function redondeoPrecioPromocional(precio_promo) As Integer
        Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
        Dim multiplo As Integer = 50
        Dim promo As Integer = 0

        promo = multiplo * (Math.Round(precio_promo / multiplo))

        Return promo
    End Function

    Private Sub eliminarFilasVacias()
        Try
            Dim listaux As New List(Of DataRow)
            dtItemsPromocion = Nothing
            dtItemsPromocion = gridItemsPromocion.DataSource

            For Each dr As DataRow In dtItemsPromocion.Rows
                If IsDBNull(dr("ID_PRODUCTO")) Then
                    listaux.Add(dr)
                End If
            Next

            For Each dr As DataRow In listaux
                dtItemsPromocion.Rows.Remove(dr)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Function validarPreciosPromo() As Boolean
        For i As Integer = 0 To GridViewItemsPromocion.RowCount - 1
            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_PROMO")) Then
                ControlMensajes.mensaje("Precios promocionales deben ser mayor a cero(0)", titulo, "WAR")
                Return False
            Else
                If GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_PROMO") <= 0 Then
                    ControlMensajes.mensaje("Precios promocionales deben ser mayor a cero(0)", titulo, "WAR")
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Function validarPreciosActual() As Boolean

        For i As Integer = 0 To GridViewItemsPromocion.RowCount - 1
            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_ACTUAL")) Then
                ControlMensajes.mensaje("Precios actuales deben ser mayor a cero(0)", titulo, "WAR")
                Return False
            Else
                If GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_ACTUAL") <= 0 Then
                    ControlMensajes.mensaje("Precios actuales deben ser mayor a cero(0)", titulo, "WAR")
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Sub getPromocion(id As String)
        Dim dt As New DataTable
        'Se obtiene la cabezera de la promocion
        dt = contPromocion.consultar("SELECT IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD, COALESCE(ID_SITIO,0), DESCRIPCION, ID_PROVEEDOR, FECHA_DESDE, 
                                        FECHA_HASTA, COALESCE(ACTIVO,'N'), COALESCE(CERRADO,'N'), COALESCE(CONFIRMADO,'N'),
                                        COALESCE(VR_TIPO_PROMO, 'PR') FROM APP_PROMOCIONES WHERE IDENTIFICADOR=" & id)

        idPromocion = dt.Rows(0).Item(0)
        setEmpresa(dt.Rows(0).Item(1))
        setUnidadOperat(dt.Rows(0).Item(2))
        setSitio(dt.Rows(0).Item(3))
        txtDescripcion.Text = dt.Rows(0).Item(4)
        setProveedor(dt.Rows(0).Item(5))
        txtFechaDesde.Text = dt.Rows(0).Item(6)
        txtFechaHasta.Text = dt.Rows(0).Item(7)
        activo = dt.Rows(0).Item(8)
        cerrado = dt.Rows(0).Item(9)
        confirmado = dt.Rows(0).Item(10)

        If activo = "S" Then
            btnActivarPromo.Enabled = False
        Else
            If cerrado = "S" Then
                btnActivarPromo.Enabled = False
            Else
                btnActivarPromo.Enabled = True
            End If
        End If


        If dt.Rows(0).Item(11).ToString = "PR" Then
            cboTipoPromo.SelectedIndex = 0
        End If

        If dt.Rows(0).Item(11).ToString = "CO" Then
            cboTipoPromo.SelectedIndex = 1
        End If

        'Se obtienen los items de la promocion
        dt.Clear()
        dt = contPromocion.consultar("SELECT APP.IDENTIFICADOR AS ID_ITEM, APP.ID_PRODUCTO, PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION AS PRODUCTO,
                                        APP.PRECIO_ACTUAL, APP.COSTO_UNITARIO, APP.PRECIO_PROMO, APP.DIFERENCIA_PRECIO, APP.PORC_DIFERENCIA, 
                                        PR_PRODUCTOS.ID_UNIDAD_MEDIDA, 'N' AS NUEVO, 'N' AS ELIMINAR, ROUND((((APP.PRECIO_PROMO / APP.COSTO_UNITARIO) * 100) - 100), 2) AS MARGEN
                                        FROM APP_ITEMS_PROMOCION APP
                                        LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = APP.ID_PRODUCTO
                                        WHERE APP.ID_PROMOCION=" & id)

        gridItemsPromocion.DataSource = dt
        existePromocion = True
        cargarProducto = "S"
    End Sub

    Sub insertarPromocion()

        eliminarFilasVacias()

        If txtEmpresa.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo empresa no puede estar vacio", titulo, "WAR")
            txtEmpresa.Focus()
            Return
        End If
        If txtUnidadOperat.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo unidad operat. no puede estar vacio", titulo, "WAR")
            txtUnidadOperat.Focus()
            Return
        End If
        If cboTipoPromo.SelectedIndex < 0 Then
            ControlMensajes.mensaje("Debe seleccionar tipo de promocion", titulo, "WAR")
            cboTipoPromo.Focus()
            Return
        End If
        If txtDescripcion.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo descripcion no puede estar vacio", titulo, "WAR")
            txtDescripcion.Focus()
            Return
        End If
        If txtFechaDesde.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha desde no puede estar vacio", titulo, "WAR")
            txtFechaDesde.Focus()
            Return
        End If
        If txtFechaHasta.Text.Replace(" ", "") = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha hasta no puede estar vacio", titulo, "WAR")
            txtFechaHasta.Focus()
            Return
        End If

        If GridViewItemsPromocion.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe asignar items a la promocion", titulo, "WAR")
            GridViewItemsPromocion.AddNewRow()
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
            GridViewItemsPromocion.ShowEditor()
            Return
        End If

        If validarPreciosPromo() = False Then
            Return
        End If

        If validarPreciosActual() = False Then
            Return
        End If


        Dim identificador As Integer = contPromocion.idPromocion()
        Dim descripcion As String = txtDescripcion.Text
        Dim vrTipoPromo As String = ""
        Dim fechaDesde As Date = Convert.ToDateTime(txtFechaDesde.Text)
        Dim fechaHasta As Date = Convert.ToDateTime(txtFechaHasta.Text)

        If cboTipoPromo.SelectedIndex = 0 Then
            vrTipoPromo = "PR"
        End If
        If cboTipoPromo.SelectedIndex = 1 Then
            vrTipoPromo = "CO"
        End If

        If identificador <= 0 Then
            ControlMensajes.mensaje("Secuencia de promocion no valido", titulo, "WAR")
            Return
        End If

        If contPromocion.insertarPromocion(identificador, descripcion, idProveedor, fechaDesde, fechaHasta, "N", "N", "N", idEmpresa, idUnidad, idSitio, vrTipoPromo) = False Then
            ControlMensajes.mensaje("Promocion no registrada", titulo, "WAR")
        Else
            insertarItemsPromocion(identificador)
        End If

    End Sub

    Sub insertarItemsPromocion(idPromocion As Integer)
        Dim identificador As Integer = 0
        Dim idProducto As Integer = 0
        Dim precioActual As Integer = 0
        Dim costoUnitario As Integer = 0
        Dim precioPromo As Integer = 0
        Dim difPrecio As Integer = 0
        Dim porDiferencia As Double = 0

        For i As Integer = 0 To GridViewItemsPromocion.RowCount - 1
            identificador = contPromocion.idItemPromocion()
            idProducto = GridViewItemsPromocion.GetRowCellValue(i, "ID_PRODUCTO")
            precioActual = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_ACTUAL")
            costoUnitario = GridViewItemsPromocion.GetRowCellValue(i, "COSTO_UNITARIO")
            precioPromo = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_PROMO")
            difPrecio = GridViewItemsPromocion.GetRowCellValue(i, "DIFERENCIA_PRECIO")
            porDiferencia = GridViewItemsPromocion.GetRowCellValue(i, "PORC_DIFERENCIA")

            If contPromocion.insertarItemsPromocion(identificador, idPromocion, idProducto, precioActual, costoUnitario, precioPromo, difPrecio, porDiferencia, difPrecio) = False Then
                ControlMensajes.mensaje("Items de promocion no registrados", titulo, "WAR")
                Return
            End If
        Next

        ControlMensajes.mensaje("Promocion registrada", titulo, "INF")
        limpiar()
    End Sub

    Sub actualizarItemsPromocion()
        If idPromocion <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar promocion", titulo, "WAR")
            btnBuscar.Focus()
            Return
        End If

        If GridViewItemsPromocion.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe asignar items a la promocion", titulo, "WAR")
            GridViewItemsPromocion.AddNewRow()
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
            GridViewItemsPromocion.ShowEditor()
            Return
        End If

        If validarPreciosPromo() = False Then
            Return
        End If

        If validarPreciosActual() = False Then
            Return
        End If

        Dim vrTipoPromo As String = ""
        If cboTipoPromo.SelectedIndex = 0 Then
            vrTipoPromo = "PR"
        End If
        If cboTipoPromo.SelectedIndex = 1 Then
            vrTipoPromo = "CO"
        End If

        If contPromocion.actualizarPromocion(idPromocion, idSitio, txtDescripcion.Text, idProveedor, txtFechaDesde.Text, txtFechaHasta.Text, vrTipoPromo) = False Then
            ControlMensajes.mensaje("Promocion no actualizada", titulo, "WAR")
            Return
        End If

        Dim identificador As Integer = 0
        Dim idProducto As Integer = 0
        Dim precioActual As Integer = 0
        Dim costoUnitario As Integer = 0
        Dim precioPromo As Integer = 0
        Dim difPrecio As Integer = 0
        Dim porDiferencia As Double = 0
        Dim difReconocer As Integer = 0
        Dim nuevo As String = "N"

        For i As Integer = 0 To GridViewItemsPromocion.RowCount - 1
            nuevo = GridViewItemsPromocion.GetRowCellValue(i, "NUEVO")

            If nuevo = "N" Then
                identificador = GridViewItemsPromocion.GetRowCellValue(i, "ID_ITEM")
                precioActual = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_ACTUAL")
                precioPromo = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_PROMO")
                difPrecio = GridViewItemsPromocion.GetRowCellValue(i, "DIFERENCIA_PRECIO")
                porDiferencia = GridViewItemsPromocion.GetRowCellValue(i, "PORC_DIFERENCIA")

                If contPromocion.actualizarItemsPromocion(identificador, precioActual, precioPromo, difPrecio, porDiferencia) = False Then
                    ControlMensajes.mensaje("Items de promocion no actualizados", titulo, "WAR")
                    Return
                End If
            End If

            If nuevo = "S" Then
                identificador = contPromocion.idItemPromocion()
                idProducto = GridViewItemsPromocion.GetRowCellValue(i, "ID_PRODUCTO")
                precioActual = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_ACTUAL")
                costoUnitario = GridViewItemsPromocion.GetRowCellValue(i, "COSTO_UNITARIO")
                precioPromo = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_PROMO")
                porDiferencia = GridViewItemsPromocion.GetRowCellValue(i, "PORC_DIFERENCIA")
                difPrecio = GridViewItemsPromocion.GetRowCellValue(i, "DIFERENCIA_PRECIO")

                If contPromocion.insertarItemsPromocion(identificador, idPromocion, idProducto, precioActual, costoUnitario, precioPromo, difPrecio, porDiferencia, difPrecio) = False Then
                    ControlMensajes.mensaje("Items de promocion no registrados", titulo, "WAR")
                    Return
                End If
            End If
        Next

        ControlMensajes.mensaje("Promocion actualizada", titulo, "INF")
        limpiar()
    End Sub

    Sub eliminarItemsPromocion()

        If GridViewItemsPromocion.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe asignar items a la promocion", titulo, "WAR")
            GridViewItemsPromocion.AddNewRow()
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
            GridViewItemsPromocion.ShowEditor()
            Return
        End If

        Dim identificador As Integer = 0
        Dim eliminar As String = ""

        For i As Integer = 0 To GridViewItemsPromocion.RowCount - 1
            eliminar = GridViewItemsPromocion.GetRowCellValue(i, "ELIMINAR")

            If idPromocion > 0 Then
                If IsDBNull(GridViewItemsPromocion.GetRowCellValue(i, "ID_ITEM")) Then
                Else
                    identificador = GridViewItemsPromocion.GetRowCellValue(i, "ID_ITEM")

                    If eliminar = "S" Then
                        If contPromocion.eliminarItemPromocion(identificador) Then
                            GridViewItemsPromocion.DeleteRow(i)
                        Else
                            ControlMensajes.mensaje("Items de promocion no eliminado: " & identificador, titulo, "WAR")
                            Return
                        End If
                    End If
                End If
            Else
                If eliminar = "S" Then
                    GridViewItemsPromocion.DeleteRow(i)
                End If
            End If
        Next


    End Sub

    Sub abrirPromocion()
        If idPromocion <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar promocion", titulo, "WAR")
            btnBuscar.Focus()
            Return
        End If

        If GridViewItemsPromocion.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe asignar items a la promocion", titulo, "WAR")
            GridViewItemsPromocion.AddNewRow()
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
            GridViewItemsPromocion.ShowEditor()
            Return
        End If

        If validarPreciosPromo() = False Then
            Return
        End If

        If validarPreciosActual() = False Then
            Return
        End If

        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
            Return
        End If

        Dim idProducto As Integer = 0
        Dim precioVenta As Integer = 0

        Dim idPrecioAplicar As Integer = 0
        Dim idUnidadMedida As Integer = 0
        Dim idCaja As Integer = 0
        Dim precioNuevo As Integer = 0
        Dim fechaAplicacion As String = ""
        Dim precioAnterior As Integer = 0
        Dim codigoBarras As String = ""
        Dim porcRecargo As Integer = 0

        Dim idAudCambioPrecio As Integer = 0

        For i As Integer = 0 To GridViewItemsPromocion.RowCount - 1
            'Se registran los precios a plicar
            idProducto = GridViewItemsPromocion.GetRowCellValue(i, "ID_PRODUCTO")
            idUnidadMedida = GridViewItemsPromocion.GetRowCellValue(i, "ID_UNIDAD_MEDIDA")
            precioNuevo = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_PROMO")
            fechaAplicacion = txtFechaDesde.Text & " " & Now.ToString("hh:mm:ss")
            precioAnterior = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_ACTUAL")
            codigoBarras = GridViewItemsPromocion.GetRowCellValue(i, "CODIGO_BARRAS")
            porcRecargo = GridViewItemsPromocion.GetRowCellValue(i, "MARGEN")

            ''Se recorren todas las cajas para insertar los precio a aplicar
            Dim dtCajas As New DataTable
            Dim queryCajas As String
            If idSitio > 0 Then
                queryCajas = "SELECT IDENTIFICADOR, ID_SITIO FROM TC_CAJAS WHERE ID_SITIO=" & idSitio & " ORDER BY NUMERO ASC"
            Else
                queryCajas = "SELECT IDENTIFICADOR, ID_SITIO FROM TC_CAJAS ORDER BY NUMERO ASC"
            End If
            dtCajas = contPromocion.consultar(queryCajas)
            If dtCajas.Rows.Count > 0 Then
                For c As Integer = 0 To dtCajas.Rows.Count - 1
                    idPrecioAplicar = contPrecioAplicar.identificador()
                    idCaja = CInt(dtCajas.Rows(c).Item(0))
                    If contPrecioAplicar.insertarPrecioAplicar(idPrecioAplicar, idEmpresa, idUnidad, CInt(dtCajas.Rows(c).Item(1)), idProducto, idUnidad, idCaja, precioNuevo, fechaAplicacion, precioAnterior, codigoBarras) = False Then
                        ControlMensajes.mensaje("Precio a aplicar no registrado", titulo, "WAR")
                        Return
                    End If
                Next
            Else
                ControlMensajes.mensaje("No se encontraron cajas", titulo, "WAR")
                Return
            End If

            'Se registra la auditoria de cambio de precio
            Dim dtsitios As New DataTable
            Dim querySitios As String = ""
            If idSitio > 0 Then
                querySitios = "SELECT IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD FROM FND_SITIOS WHERE IDENTIFICADOR=" & idSitio
            Else
                querySitios = "SELECT IDENTIFICADOR, ID_EMPRESA, ID_UNIDAD FROM FND_SITIOS ORDER BY IDENTIFICADOR ASC"
            End If
            dtsitios = contAudiCambioPrecio.consultar(querySitios)
            If dtsitios.Rows.Count > 0 Then
                For s As Integer = 0 To dtsitios.Rows.Count - 1
                    idAudCambioPrecio = contAudiCambioPrecio.identificador()
                    If contAudiCambioPrecio.insertarAudCambio(idProducto, idUnidadMedida, "PV", precioNuevo, CStr(fechaAplicacion), precioAnterior, porcRecargo, "APPTRADE", codigoBarras, "N", idProveedor, "S", idEmpresa, idUnidad, dtsitios.Rows(s).Item(0), idAudCambioPrecio, fechaAplicacion) = False Then
                        ControlMensajes.mensaje("Auditoria de cambio de precio no registrado", titulo, "WAR")
                        Return
                    End If
                Next
            End If


            'Se actualizan los precios de ventas
            idProducto = GridViewItemsPromocion.GetRowCellValue(i, "ID_PRODUCTO")
            precioVenta = GridViewItemsPromocion.GetRowCellValue(i, "PRECIO_PROMO")

            If contProducto.actualizarPrecioVenta(idProducto, precioVenta) = False Then
                ControlMensajes.mensaje("Precio Venta no actualizado", titulo, "WAR")
                Return
            End If

            If contUmProducto.actualizarPrecioVenta(idProducto, precioVenta) = False Then
                ControlMensajes.mensaje("Precio Venta no actualizado (UM)", titulo, "WAR")
                Return
            End If
        Next

        If contPromocion.abrirPromocion(idPromocion) Then
            ControlMensajes.mensaje("Promocion activada", titulo, "INF")
            limpiar()
        Else
            ControlMensajes.mensaje("Promocion no activada", titulo, "WAR")
        End If

    End Sub

    Private Sub txtEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEmpresa.Text IsNot "" Then
                txtUnidadOperat.Focus()
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
                txtSucursal.Focus()
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
            cboTipoPromo.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub cboCostoUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoPromo.KeyDown
        If cboTipoPromo.SelectedIndex >= 0 Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDescripcion.Text.Replace(" ", "") IsNot "" Then
                txtProveedor.Focus()
            End If
        End If
    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaDesde.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PV")
        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
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

    Private Sub cldFechaDesde_DoubleClick(sender As Object, e As EventArgs) Handles cldFechaDesde.DoubleClick
        txtFechaDesde.Text = cldFechaDesde.DateTime.ToString
        txtFechaDesde.Focus()
        vistas("FD")
    End Sub

    Private Sub cldFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaDesde.Text = cldFechaDesde.DateTime.ToString
            txtFechaDesde.Focus()
            vistas("FD")
        End If
        If e.KeyCode = Keys.Escape Then
            vistas("FD")
        End If
    End Sub

    Private Sub txtFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFechaHasta.Text = "  /  /" Then
            Else
                crear_cursor()
                GridViewItemsPromocion.AddNewRow()
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
                GridViewItemsPromocion.ShowEditor()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FH")
        End If
    End Sub

    Private Sub btnFechaHasta_Click(sender As Object, e As EventArgs) Handles btnFechaHasta.Click
        vistas("FH")
    End Sub

    Private Sub cldFechaHasta_DoubleClick(sender As Object, e As EventArgs) Handles cldFechaHasta.DoubleClick
        txtFechaHasta.Text = cldFechaDesde.DateTime.ToString
        txtFechaHasta.Focus()
        vistas("FH")
    End Sub

    Private Sub cldFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaHasta.Text = cldFechaDesde.DateTime.ToString
            txtFechaHasta.Focus()
            vistas("FH")
        End If
        If e.KeyCode = Keys.Escape Then
            vistas("FH")
        End If
    End Sub


    Private Sub rpCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles rpCodBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(1)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)

            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "CODIGO_BARRAS")) Then
            Else
                getProducto(GridViewItemsPromocion.GetRowCellValue(rowhandle, "CODIGO_BARRAS"))
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(1)
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PR")
        End If
    End Sub

    Private Sub rpProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles rpProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(1)

            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRODUCTO")) Then
            Else
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)
            End If
        End If
    End Sub


    Private Sub rpPrecioActual_KeyDown(sender As Object, e As KeyEventArgs) Handles rpPrecioActual.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(3)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(2)

            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_ACTUAL")) Then
            Else
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(3)
            End If
        End If
    End Sub


    Private Sub rpCostoUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles rpCostoUnitario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(4)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(3)

            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "COSTO_UNITARIO")) Then
            Else
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(4)
            End If
        End If
    End Sub


    Private Sub rpMargen_KeyDown(sender As Object, e As KeyEventArgs) Handles rpMargen.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(5)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(4)

            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "MARGEN")) Then
            Else
                If CInt(GridViewItemsPromocion.GetRowCellValue(rowhandle, "MARGEN")) > 0 Then
                    calcularMargen()
                Else
                    GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(5)
                End If
            End If
        End If

    End Sub

    Private Sub rpPrecioPromo_KeyDown(sender As Object, e As KeyEventArgs) Handles rpPrecioPromo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(6)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(5)

            If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")) Then
            Else
                If IsDBNull(GridViewItemsPromocion.GetRowCellValue(rowhandle, "ID_PRODUCTO")) Then
                    ControlMensajes.mensaje("Debe ingresar un producto", titulo, "WAR")
                    GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(0)
                Else
                    Dim precio_promo As Integer = GridViewItemsPromocion.GetRowCellValue(rowhandle, "PRECIO_PROMO")
                    GridViewItemsPromocion.SetRowCellValue(rowhandle, "PRECIO_PROMO", redondeoPrecioPromocional(precio_promo))
                    GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(6)
                    GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(5)
                    calcularDiferencia()
                End If
            End If
        End If
    End Sub
    
    Private Sub rpDiferencia_KeyDown(sender As Object, e As KeyEventArgs) Handles rpDiferencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(7)
        End If
    End Sub

    Private Sub rpPorcDiferencia_KeyDown(sender As Object, e As KeyEventArgs) Handles rpPorcDiferencia.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim rowhandle As Integer = GridViewItemsPromocion.FocusedRowHandle
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(8)
            GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(7)

            If GridViewItemsPromocion.GetRowCellValue(rowhandle, "PORC_DIFERENCIA") <= 0 Then
                ControlMensajes.mensaje("Porc. diferencia debe ser mayor a cero(0)", titulo, "WAR")
                GridViewItemsPromocion.FocusedColumn = GridViewItemsPromocion.VisibleColumns(6)
                Return
            End If

            calcularDiferenciaPorc()

        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
            Return
        End If

        eliminarFilasVacias()
        eliminarItemsPromocion()

        If existePromocion = False Then
            insertarPromocion()
        Else
            If activo = "S" Then
                ControlMensajes.mensaje("La promocion no puede ser actualizada porque ya esta activa", titulo, "WAR")
            Else
                If cerrado = "S" Then
                    ControlMensajes.mensaje("La promocion no puede ser actualizada porque ya esta cerrada", titulo, "WAR")
                Else
                    If confirmado = "S" Then
                        ControlMensajes.mensaje("La promocion no puede ser actualizada porque ya esta confirmada", titulo, "WAR")
                    Else
                        actualizarItemsPromocion()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnActivarPromo_Click(sender As Object, e As EventArgs) Handles btnActivarPromo.Click
        abrirPromocion()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelar la operacion?", "Promociones") Then
            limpiar()
            txtEmpresa.Focus()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If GridViewItemsPromocion.RowCount <= 0 Or idPromocion <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim rowhandle As Integer = 0
        Dim promocion As String = ""
        Dim empresa As String = ""
        Dim unidad As String = ""
        Dim sucursal As String = ""
        Dim proveedor As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""

        rowhandle = GridViewItemsPromocion.FocusedRowHandle
        promocion = txtDescripcion.Text
        empresa = txtEmpresa.Text
        unidad = txtUnidadOperat.Text
        sucursal = txtSucursal.Text
        proveedor = txtProveedor.Text
        desde = txtFechaDesde.Text
        hasta = txtFechaHasta.Text

        Dim report As New RptAppPromociones

        report.DataSource = gridItemsPromocion.DataSource

        report.Parameters("promocion").Value = promocion
        report.Parameters("empresa").Value = empresa
        report.Parameters("unidad").Value = unidad
        report.Parameters("sucursal").Value = sucursal
        report.Parameters("proveedor").Value = proveedor
        report.Parameters("fechaDesde").Value = desde
        report.Parameters("fechaHasta").Value = hasta
        report.Parameters("activo").Value = activo
        report.Parameters("cerrado").Value = cerrado
        report.Parameters("confirmado").Value = confirmado
        report.Parameters("identificador").Value = idPromocion

        report.Parameters("promocion").Visible = False
        report.Parameters("empresa").Visible = False
        report.Parameters("unidad").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("proveedor").Visible = False
        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False
        report.Parameters("activo").Visible = False
        report.Parameters("cerrado").Visible = False
        report.Parameters("confirmado").Visible = False
        report.Parameters("identificador").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

        limpiar()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frm As New FrmVistaPromociones
        frm.setFrmActivo("FrmAppPromociones")
        frm.ShowDialog()
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------LIQUIDACION DE PROMOCION----------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------------

    Dim dtLiquidaciones As New DataTable
    Dim dtItemsLiquidacion As New DataTable

    Sub obtenerLiquidaciones()
        gridLiquidaciones.DataSource = Nothing
        dtLiquidaciones = contPromocion.consultar("SELECT APP.IDENTIFICADOR AS ID_PROMOCION, APP.DESCRIPCION AS PROMOCION, COALESCE(CP_PROVEEDORES.DENOMINACION, 'NO DEFINIDO') AS PROVEEDOR, 
                                                    APP.FECHA_DESDE, APP.FECHA_HASTA, APP.ACTIVO, APP.ID_EMPRESA, APP.ID_UNIDAD, APP.ID_SITIO,
                                                    COALESCE(APP_LIQUIDACIONES_PROMO.TOTAL_PAGADO, 0) AS TOTAL_PAGADO, APP.CONFIRMADO, COALESCE(APP.CERRADO, 'N') AS CERRADO,
                                                    FND_PARM_EMPRESAS.NOMBRE AS EMPRESA, CO_UNIDADES_OPERAT.DESCRIPCION AS UNIDAD, FND_SITIOS.DESCRIPCION AS SUCURSAL
                                                    FROM APP_PROMOCIONES APP
                                                    LEFT JOIN APP_LIQUIDACIONES_PROMO ON APP_LIQUIDACIONES_PROMO.ID_PROMOCION = APP.IDENTIFICADOR
                                                    LEFT JOIN CP_PROVEEDORES ON CP_PROVEEDORES.IDENTIFICADOR = APP.ID_PROVEEDOR 
                                                    LEFT JOIN FND_PARM_EMPRESAS ON FND_PARM_EMPRESAS.IDENTIFICADOR = APP.ID_EMPRESA
                                                    LEFT JOIN CO_UNIDADES_OPERAT ON CO_UNIDADES_OPERAT.IDENTIFICADOR = APP.ID_UNIDAD
                                                    LEFT JOIN FND_SITIOS ON FND_SITIOS.IDENTIFICADOR = APP.ID_SITIO
                                                    ORDER BY APP.IDENTIFICADOR DESC")

        gridLiquidaciones.DataSource = dtLiquidaciones
    End Sub

    Sub crear_cursor_liquidacion()
        dtItemsLiquidacion = New DataTable
        dtItemsLiquidacion.Columns.Add("ID_ITEM_PROMOCION")
        dtItemsLiquidacion.Columns.Add("ID_PRODUCTO")
        dtItemsLiquidacion.Columns.Add("CODIGO_BARRAS")
        dtItemsLiquidacion.Columns.Add("PRODUCTO")
        dtItemsLiquidacion.Columns.Add("PRECIO_ACTUAL")
        dtItemsLiquidacion.Columns.Add("COSTO_UNITARIO")
        dtItemsLiquidacion.Columns.Add("PRECIO_PROMO")
        dtItemsLiquidacion.Columns.Add("DIFERENCIA_PRECIO")
        dtItemsLiquidacion.Columns.Add("PORC_DIFERENCIA")
        dtItemsLiquidacion.Columns.Add("CANTIDAD_VENDIDA")
        dtItemsLiquidacion.Columns.Add("DIF_RECONOCER")
    End Sub

    Sub obtenerItemsLiquidacion(idPromocion As Integer, desde As String, hasta As String)
        crear_cursor_liquidacion()
        gridItemsLiquidacion.DataSource = Nothing

        Dim sitio As String = ""

        If idSitio > 0 Then
            sitio = " AND VTA_COMPROBANTES.ID_SITIO=" & CStr(idSitio) & " "
        End If

        dtItemsLiquidacion = contPromocion.consultar("SELECT APP.IDENTIFICADOR AS ID_ITEM_PROMOCION, APP.ID_PRODUCTO, PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION AS PRODUCTO, APP.PRECIO_ACTUAL, 
                                                        APP.COSTO_UNITARIO, APP.PRECIO_PROMO,
                                                        APP.DIFERENCIA_PRECIO, ROUND(APP.PORC_DIFERENCIA, 2) AS PORC_DIFERENCIA,
                                                        COALESCE((
                                                                  SELECT SUM(IT.CANTIDAD) FROM VTA_ITEMS_COMPROB IT
                                                                  LEFT JOIN VTA_COMPROBANTES ON VTA_COMPROBANTES.IDENTIFICADOR =  IT.ID_COMPROBANTE
                                                                  WHERE TRUNC(IT.FEC_CRE) >= TO_DATE('" & desde & "', 'dd/mm/yyyy')  AND TRUNC(IT.FEC_CRE) <= TO_DATE('" & hasta & "', 'dd/mm/yyyy')
                                                                  AND IT.ID_PRODUCTO=APP.ID_PRODUCTO AND VTA_COMPROBANTES.USR_ANULACION IS NULL " & sitio & "
                                                                  ), 0) AS CANTIDAD_VENDIDA,
                                                        COALESCE((
                                                                  SELECT (APP.DIFERENCIA_PRECIO * SUM(IT.CANTIDAD)) FROM VTA_ITEMS_COMPROB  IT
                                                                  LEFT JOIN VTA_COMPROBANTES ON VTA_COMPROBANTES.IDENTIFICADOR =  IT.ID_COMPROBANTE
                                                                  WHERE TRUNC(IT.FEC_CRE) >= TO_DATE('" & desde & "', 'dd/mm/yyyy') AND TRUNC(IT.FEC_CRE) <= TO_DATE('" & hasta & "', 'dd/mm/yyyy')
                                                                  AND IT.ID_PRODUCTO=APP.ID_PRODUCTO AND VTA_COMPROBANTES.USR_ANULACION IS NULL " & sitio & "
                                                                  ), 0) AS DIF_RECONOCER, 'N' AS IMPRIMIR
                                                        FROM APP_ITEMS_PROMOCION APP
                                                        LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = APP.ID_PRODUCTO
                                                        WHERE APP.ID_PROMOCION=" & idPromocion.ToString &
                                                        " GROUP BY APP.IDENTIFICADOR, APP.ID_PRODUCTO, PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, APP.PRECIO_ACTUAL, 
                                                        APP.COSTO_UNITARIO, APP.PRECIO_PROMO, APP.DIFERENCIA_PRECIO, APP.PORC_DIFERENCIA")

        gridItemsLiquidacion.DataSource = dtItemsLiquidacion
    End Sub

    Sub desactivarPromocion()
        If idPromocion <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar promocion", titulo, "WAR")
            gridLiquidaciones.Focus()
            Return
        End If

        If GridViewItemsLiquidacion.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar promocion", titulo, "WAR")
            gridItemsLiquidacion.Focus()
            Return
        End If

        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
            Return
        End If

        Dim idItemPromocion As Integer = 0
        Dim cantidadVendida As Double = 0
        Dim difReconocer As Integer = 0

        For i As Integer = 0 To GridViewItemsLiquidacion.RowCount - 1
            'Se actualiza las cantidades vendidas y la diferencia a reconocer por cada producto
            idItemPromocion = GridViewItemsLiquidacion.GetRowCellValue(i, "ID_ITEM_PROMOCION")
            cantidadVendida = GridViewItemsLiquidacion.GetRowCellValue(i, "CANTIDAD_VENDIDA")
            difReconocer = GridViewItemsLiquidacion.GetRowCellValue(i, "TOTAL_RECONOCER")
            If contPromocion.cerrarItemsPromocion(idItemPromocion, cantidadVendida, difReconocer) = False Then
                ControlMensajes.mensaje("Item de Promocion no actualizado", titulo, "WAR")
                Return
            End If

            Dim idProducto As Integer = 0
            Dim precioVenta As Integer = 0

            Dim idPrecioAplicar As Integer = 0
            Dim idUnidadMedida As Integer = 0
            Dim idCaja As Integer = 0
            Dim precioNuevo As Integer = 0
            Dim fechaAplicacion As Date = Nothing
            Dim precioAnterior As Integer = 0
            Dim codigoBarras As String = ""
            Dim porcRecargo As Integer = 0

            Dim idAudCambioPrecio As Integer = 0

            'Se registran los precios a plicar
            idProducto = GridViewItemsLiquidacion.GetRowCellValue(i, "ID_PRODUCTO")
            idUnidadMedida = GridViewItemsLiquidacion.GetRowCellValue(i, "ID_UNIDAD_MEDIDA")
            precioNuevo = GridViewItemsLiquidacion.GetRowCellValue(i, "PRECIO_ACTUAL")
            fechaAplicacion = Now.ToString("dd/MM/yyyy hh:mm:ss")
            precioAnterior = GridViewItemsLiquidacion.GetRowCellValue(i, "PRECIO_PROMO")
            codigoBarras = GridViewItemsLiquidacion.GetRowCellValue(i, "CODIGO_BARRAS")
            porcRecargo = GridViewItemsLiquidacion.GetRowCellValue(i, "MARGEN")

            ''Se recorren todas las cajas para insertar los precio a aplicar
            Dim dtCajas As New DataTable
            Dim queryCajas As String
            If idSitio > 0 Then
                queryCajas = "SELECT IDENTIFICADOR, ID_SITIO FROM TC_CAJAS WHERE ID_SITIO=" & idSitio & " ORDER BY NUMERO ASC"
            Else
                queryCajas = "SELECT IDENTIFICADOR, ID_SITIO FROM TC_CAJAS ORDER BY NUMERO ASC"
            End If
            dtCajas = contPromocion.consultar(queryCajas)
            If dtCajas.Rows.Count > 0 Then
                For c As Integer = 0 To dtCajas.Rows.Count - 1
                    idPrecioAplicar = contPrecioAplicar.identificador()
                    idCaja = CInt(dtCajas.Rows(c).Item(0))
                    If contPrecioAplicar.insertarPrecioAplicar(idPrecioAplicar, idEmpresa, idUnidad, CInt(dtCajas.Rows(c).Item(1)), idProducto, idUnidad, idCaja, precioNuevo, fechaAplicacion, precioAnterior, codigoBarras) = False Then
                        ControlMensajes.mensaje("Precio a aplicar no registrado", titulo, "WAR")
                        Return
                    End If
                Next
            Else
                ControlMensajes.mensaje("No se encontraron cajas", titulo, "WAR")
                Return
            End If

            'Se registra la auditoria de cambio de precio
            Dim dtsitios As New DataTable
            Dim querySitios As String = ""
            If idSitio > 0 Then
                querySitios = "SELECT IDENTIFICADOR FROM FND_SITIOS WHERE IDENTIFICADOR=" & idSitio
            Else
                querySitios = "SELECT IDENTIFICADOR FROM FND_SITIOS ORDER BY IDENTIFICADOR ASC"
            End If
            dtsitios = contAudiCambioPrecio.consultar(querySitios)
            If dtsitios.Rows.Count > 0 Then
                For s As Integer = 0 To dtsitios.Rows.Count - 1
                    idAudCambioPrecio = contAudiCambioPrecio.identificador()
                    If contAudiCambioPrecio.insertarAudCambio(idProducto, idUnidadMedida, "PV", precioNuevo, CStr(fechaAplicacion), precioAnterior, porcRecargo, "APPTRADE", codigoBarras, "N", idProveedor, "S", idEmpresa, idUnidad, dtsitios.Rows(s).Item(0), idAudCambioPrecio, fechaAplicacion) = False Then
                        ControlMensajes.mensaje("Auditoria de cambio de precio no registrado", titulo, "WAR")
                        Return
                    End If
                Next
            End If


            'idAudCambioPrecio = contAudiCambioPrecio.identificador()
            'If contAudiCambioPrecio.insertarAudCambio(idProducto, idUnidadMedida, "PV", precioNuevo, CStr(fechaAplicacion), precioAnterior, porcRecargo, "APPTRADE", codigoBarras, "N", idProveedor, "S", idEmpresa, idUnidad, idSitio, idAudCambioPrecio, fechaAplicacion) = False Then
            '    ControlMensajes.mensaje("Auditoria de cambio de precio no registrado", titulo, "WAR")
            '    Return
            'End If

            'Se actualizan los precios de ventas
            idProducto = GridViewItemsLiquidacion.GetRowCellValue(i, "ID_PRODUCTO")
            precioVenta = GridViewItemsLiquidacion.GetRowCellValue(i, "PRECIO_ACTUAL")

            If contProducto.actualizarPrecioVenta(idProducto, precioVenta) = False Then
                ControlMensajes.mensaje("Precio Venta no actualizado", titulo, "WAR")
                Return
            End If

            If contUmProducto.actualizarPrecioVenta(idProducto, precioVenta) = False Then
                ControlMensajes.mensaje("Precio Venta no actualizado (UM)", titulo, "WAR")
                Return
            End If
        Next


        Dim fechaLiquid As Date = Convert.ToDateTime(Now.ToString("dd/MM/yyyy"))
        Dim totalPagado As Integer = 0

        cantidadVendida = 0
        totalPagado = 0

        For i As Integer = 0 To GridViewItemsLiquidacion.RowCount - 1
            cantidadVendida += GridViewItemsLiquidacion.GetRowCellValue(i, "CANTIDAD_VENDIDA")
            totalPagado += GridViewItemsLiquidacion.GetRowCellValue(i, "DIF_RECONOCER")
        Next

        idLiquidacion = contLiquidacionPromo.identificador()

        If contLiquidacionPromo.insertarLiquidacion(idLiquidacion, fechaLiquid, idPromocion, cantidadVendida, totalPagado) = False Then
            ControlMensajes.mensaje("Liquidacion no registrada", titulo, "WAR")
            Return
        End If

        If contPromocion.cerrarPromocion(idPromocion) Then
            ControlMensajes.mensaje("Promocion desactivada", titulo, "INF")
            limpiar()
        Else
            ControlMensajes.mensaje("Promocion no desactivada", titulo, "WAR")
        End If

    End Sub

    Sub confirmarPromocion()
        If idPromocion <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar promocion", titulo, "WAR")
            gridLiquidaciones.Focus()
            Return
        End If

        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
            Return
        End If

        If contPromocion.confirmarPromocion(idPromocion) = False Then
            ControlMensajes.mensaje("Promocion no confirmada", titulo, "WAR")
            Return
        End If

        ControlMensajes.mensaje("Promocion confirmada", titulo, "INF")
        limpiar()
    End Sub

    Private Sub gridLiquidaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles gridLiquidaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = 0
            Dim desde As String = ""
            Dim hasta As String = ""

            rowhandle = GridViewLiquidaciones.FocusedRowHandle
            idEmpresa = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_EMPRESA")
            idUnidad = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_UNIDAD")
            idSitio = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_SITIO")

            idPromocion = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_PROMOCION")
            desde = GridViewLiquidaciones.GetRowCellValue(rowhandle, "FECHA_DESDE")
            hasta = GridViewLiquidaciones.GetRowCellValue(rowhandle, "FECHA_HASTA")

            obtenerItemsLiquidacion(idPromocion, desde, hasta)

            If GridViewLiquidaciones.GetRowCellValue(rowhandle, "ACTIVO") = "S" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CERRADO") = "N" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CONFIRMADO") = "N" Then
                btnDesactivarPromo.Enabled = True
            Else
                btnDesactivarPromo.Enabled = False
            End If

            If GridViewLiquidaciones.GetRowCellValue(rowhandle, "ACTIVO") = "S" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CERRADO") = "S" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CONFIRMADO") = "N" Then
                btnConfirmarPromo.Enabled = True
            Else
                btnConfirmarPromo.Enabled = False
            End If

        End If
    End Sub

    Private Sub gridLiquidaciones_DoubleClick(sender As Object, e As EventArgs) Handles gridLiquidaciones.DoubleClick
        Dim rowhandle As Integer = 0
        Dim desde As String = ""
        Dim hasta As String = ""

        rowhandle = GridViewLiquidaciones.FocusedRowHandle
        idEmpresa = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_EMPRESA")
        idUnidad = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_UNIDAD")
        idSitio = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_SITIO")

        idPromocion = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ID_PROMOCION")
        desde = GridViewLiquidaciones.GetRowCellValue(rowhandle, "FECHA_DESDE")
        hasta = GridViewLiquidaciones.GetRowCellValue(rowhandle, "FECHA_HASTA")

        obtenerItemsLiquidacion(idPromocion, desde, hasta)


        If GridViewLiquidaciones.GetRowCellValue(rowhandle, "ACTIVO") = "S" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CERRADO") = "N" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CONFIRMADO") = "N" Then
            btnDesactivarPromo.Enabled = True
        Else
            btnDesactivarPromo.Enabled = False
        End If

        If GridViewLiquidaciones.GetRowCellValue(rowhandle, "ACTIVO") = "S" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CERRADO") = "S" And GridViewLiquidaciones.GetRowCellValue(rowhandle, "CONFIRMADO") = "N" Then
            btnConfirmarPromo.Enabled = True
        Else
            btnConfirmarPromo.Enabled = False
        End If

    End Sub

    Private Sub btnDesactivarPromo_Click(sender As Object, e As EventArgs) Handles btnDesactivarPromo.Click
        desactivarPromocion()
    End Sub

    Private Sub btnConfirmarPromo_Click(sender As Object, e As EventArgs) Handles btnConfirmarPromo.Click
        confirmarPromocion()
    End Sub

    Private Sub btnCancelarLiquidacion_Click(sender As Object, e As EventArgs) Handles btnCancelarLiquidacion.Click
        limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        eliminarFilasVacias()

        If txtEmpresa.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo empresa no puede estar vacio", titulo, "WAR")
            txtEmpresa.Focus()
            Return
        End If
        If txtUnidadOperat.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo unidad operat. no puede estar vacio", titulo, "WAR")
            txtUnidadOperat.Focus()
            Return
        End If
        If txtSucursal.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo sucursal no puede estar vacio", titulo, "WAR")
            txtSucursal.Focus()
            Return
        End If
        If txtDescripcion.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo descripcion no puede estar vacio", titulo, "WAR")
            txtDescripcion.Focus()
            Return
        End If
        If txtFechaDesde.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha desde no puede estar vacio", titulo, "WAR")
            txtFechaDesde.Focus()
            Return
        End If
        If txtFechaHasta.Text.Replace(" ", "") = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha hasta no puede estar vacio", titulo, "WAR")
            txtFechaHasta.Focus()
            Return
        End If

        If GridViewItemsPromocion.RowCount <= 0 Then
            crear_cursor()
        End If

        GridViewItemsPromocion.AddNewRow()
    End Sub

    Private Sub btnAddProductos_Click(sender As Object, e As EventArgs) Handles btnAddProductos.Click

        eliminarFilasVacias()

        If txtEmpresa.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo empresa no puede estar vacio", titulo, "WAR")
            txtEmpresa.Focus()
            Return
        End If
        If txtUnidadOperat.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo unidad operat. no puede estar vacio", titulo, "WAR")
            txtUnidadOperat.Focus()
            Return
        End If
        If txtFechaHasta.Text.Replace(" ", "") = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha hasta no puede estar vacio", titulo, "WAR")
            txtFechaHasta.Focus()
            Return
        End If
        If txtDescripcion.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("El campo descripcion no puede estar vacio", titulo, "WAR")
            txtDescripcion.Focus()
            Return
        End If
        If txtFechaDesde.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha desde no puede estar vacio", titulo, "WAR")
            txtFechaDesde.Focus()
            Return
        End If
        If txtFechaHasta.Text.Replace(" ", "") = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha hasta no puede estar vacio", titulo, "WAR")
            txtFechaHasta.Focus()
            Return
        End If

        Dim frm As New FrmAgregarProductosPromo
        frm.ShowDialog()
    End Sub

    Private Sub btnImprimirLiquidacion_Click(sender As Object, e As EventArgs) Handles btnImprimirLiquidacion.Click

        If GridViewItemsLiquidacion.RowCount <= 0 Or idPromocion <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim rowhandle As Integer = 0
        Dim promocion As String = ""
        Dim empresa As String = ""
        Dim unidad As String = ""
        Dim sucursal As String = ""
        Dim proveedor As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim activo As String = ""
        Dim cerrado As String = ""
        Dim confirmado As String = ""

        rowhandle = GridViewLiquidaciones.FocusedRowHandle
        promocion = GridViewLiquidaciones.GetRowCellValue(rowhandle, "PROMOCION")
        empresa = GridViewLiquidaciones.GetRowCellValue(rowhandle, "EMPRESA")
        unidad = GridViewLiquidaciones.GetRowCellValue(rowhandle, "UNIDAD")
        sucursal = GridViewLiquidaciones.GetRowCellValue(rowhandle, "SUCURSAL")
        proveedor = GridViewLiquidaciones.GetRowCellValue(rowhandle, "PROVEEDOR")
        desde = GridViewLiquidaciones.GetRowCellValue(rowhandle, "FECHA_DESDE")
        hasta = GridViewLiquidaciones.GetRowCellValue(rowhandle, "FECHA_HASTA")
        activo = GridViewLiquidaciones.GetRowCellValue(rowhandle, "ACTIVO")
        cerrado = GridViewLiquidaciones.GetRowCellValue(rowhandle, "CERRADO")
        confirmado = GridViewLiquidaciones.GetRowCellValue(rowhandle, "CONFIRMADO")

        Dim report As New RptAppLiquidacionesPromo

        report.DataSource = gridItemsLiquidacion.DataSource

        report.Parameters("promocion").Value = promocion
        report.Parameters("empresa").Value = empresa
        report.Parameters("unidad").Value = unidad
        report.Parameters("sucursal").Value = sucursal
        report.Parameters("proveedor").Value = proveedor
        report.Parameters("fechaDesde").Value = desde
        report.Parameters("fechaHasta").Value = hasta
        report.Parameters("activo").Value = activo
        report.Parameters("cerrado").Value = cerrado
        report.Parameters("confirmado").Value = confirmado
        report.Parameters("identificador").Value = idPromocion

        report.Parameters("promocion").Visible = False
        report.Parameters("empresa").Visible = False
        report.Parameters("unidad").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("proveedor").Visible = False
        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False
        report.Parameters("activo").Visible = False
        report.Parameters("cerrado").Visible = False
        report.Parameters("confirmado").Visible = False
        report.Parameters("identificador").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

        limpiar()

    End Sub

    Private Sub btnImpPromociones_Click(sender As Object, e As EventArgs) Handles btnImpPromociones.Click
        GridViewLiquidaciones.ShowPrintPreview()

        limpiar()
    End Sub

    Private Sub RepositoryItemTextEdit4_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemTextEdit4.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            Dim rowhandle As Integer = 0
            Dim cantidad As Double = 0
            Dim diferencia As Integer = 0
            Dim reconocer As Integer = 0

            GridViewItemsLiquidacion.FocusedColumn = GridViewItemsLiquidacion.VisibleColumns(6)
            GridViewItemsLiquidacion.FocusedColumn = GridViewItemsLiquidacion.VisibleColumns(7)

            If IsDBNull(GridViewItemsLiquidacion.GetRowCellValue(rowhandle, "CANTIDAD_VENDIDA")) Or IsDBNull(GridViewItemsLiquidacion.GetRowCellValue(rowhandle, "DIFERENCIA_PRECIO")) Then
                Return
            End If

            rowhandle = GridViewItemsLiquidacion.FocusedRowHandle
            cantidad = GridViewItemsLiquidacion.GetRowCellValue(rowhandle, "CANTIDAD_VENDIDA")
            diferencia = GridViewItemsLiquidacion.GetRowCellValue(rowhandle, "DIFERENCIA_PRECIO")
            reconocer = diferencia * cantidad

            GridViewItemsLiquidacion.SetRowCellValue(rowhandle, "DIF_RECONOCER", reconocer)
            GridViewItemsLiquidacion.FocusedRowHandle = rowhandle
            GridViewItemsLiquidacion.FocusedColumn = GridViewItemsLiquidacion.VisibleColumns(7)
        End If
    End Sub

    Private Sub cboCostoUnitario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPromo.SelectedIndexChanged
        If cboTipoPromo.SelectedIndex = 0 Then
            rpsPorcDierencia.ReadOnly = True
            GridViewItemsPromocion.Columns(7).OptionsColumn.ReadOnly = True
            GridViewItemsPromocion.Columns("MARGEN").Visible = True
        End If
        If cboTipoPromo.SelectedIndex = 1 Then
            rpsPorcDierencia.ReadOnly = False
            GridViewItemsPromocion.Columns(7).OptionsColumn.ReadOnly = False
            GridViewItemsPromocion.Columns("MARGEN").Visible = False
        End If
    End Sub


    Function add_item_impresion() As DataTable
        Try
            Dim dt As New DataTable
            Dim column As DataColumn
            Dim row As DataRow

            column = New DataColumn()
            column.ColumnName = "PORC_DIFERENCIA"
            dt.Columns.Add(column)

            column = New DataColumn()
            column.ColumnName = "CODIGO_BARRAS"
            dt.Columns.Add(column)

            column = New DataColumn()
            column.ColumnName = "PRODUCTO"
            dt.Columns.Add(column)

            column = New DataColumn()
            column.ColumnName = "PRECIO_ACTUAL"
            dt.Columns.Add(column)

            column = New DataColumn()
            column.ColumnName = "PRECIO_PROMO"
            dt.Columns.Add(column)

            For i As Integer = 0 To GridViewItemsLiquidacion.RowCount - 1
                If GridViewItemsLiquidacion.GetRowCellValue(i, "IMPRIMIR") = "S" Then
                    row = dt.NewRow()
                    row("PORC_DIFERENCIA") = GridViewItemsLiquidacion.GetRowCellValue(i, "PORC_DIFERENCIA")
                    row("CODIGO_BARRAS") = GridViewItemsLiquidacion.GetRowCellValue(i, "CODIGO_BARRAS")
                    row("PRODUCTO") = GridViewItemsLiquidacion.GetRowCellValue(i, "PRODUCTO")
                    row("PRECIO_ACTUAL") = String.Format("{0:N0}", GridViewItemsLiquidacion.GetRowCellValue(i, "PRECIO_ACTUAL"))
                    row("PRECIO_PROMO") = String.Format("{0:N0}", GridViewItemsLiquidacion.GetRowCellValue(i, "PRECIO_PROMO"))
                    dt.Rows.Add(row)
                End If
            Next

            Return dt
        Catch ex As Exception
            ControlMensajes.mensaje(ex.Message, "Error", "ERR")
            Return Nothing
        End Try
    End Function

    Private Sub btnImprimirOfertas_Click(sender As Object, e As EventArgs) Handles btnImprimirOfertas.Click
        If GridViewItemsLiquidacion.RowCount <= 0 Or idPromocion <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If
        Dim rowhandle As Integer = 0
        Dim hasta As String = ""

        rowhandle = GridViewLiquidaciones.FocusedRowHandle
        hasta = GridViewLiquidaciones.GetRowCellValue(rowhandle, "FECHA_HASTA")

        Dim report As New RptOfertasPromocion
        Dim dt As New DataTable
        dt = add_item_impresion()
        If dt.Rows.Count <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If
        report.DataSource = dt
        report.Parameters("hasta").Value = hasta
        report.Parameters("hasta").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

End Class