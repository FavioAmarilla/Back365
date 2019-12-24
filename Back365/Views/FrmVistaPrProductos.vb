Public Class FrmVistaPrProductos

    Dim contProducto As New ContPrProductos()
    Dim dtProductos As New DataTable()
    Dim frmActivo As String = ""
    Dim idProveedor As Integer = 0
    Dim condicion As String = ""

    Dim frmTraspasoProductosSuc As FrmTraspasoProductosSuc
    Dim frmCambioPrecioVenta As FrmCambioPrecioVenta
    Dim frmExistenciasProducto As FrmExistenciasProducto
    Dim frm_transacciones_inventario As frm_transacciones_inventario
    Dim frmAppPromocionesProv As FrmAppPromocionesProv
    Dim frmGenerarListaProd As FrmGenerarListaProd

    Private Sub FrmVistaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProductos()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub setFrmTraspasoProductosSuc(formulario As FrmTraspasoProductosSuc)
        frmTraspasoProductosSuc = formulario
    End Sub

    Public Sub setFrmCambioPrecioVenta(formulario As FrmCambioPrecioVenta)
        frmCambioPrecioVenta = formulario
    End Sub

    Public Sub setFrmExistenciasProducto(formulario As FrmExistenciasProducto)
        frmExistenciasProducto = formulario
    End Sub

    Public Sub setFrm_transacciones_inventario(formulario As frm_transacciones_inventario)
        frm_transacciones_inventario = formulario
    End Sub

    Public Sub setFrmGenerarListaProd(formulario As FrmGenerarListaProd)
        frmGenerarListaProd = formulario
    End Sub

    Public Sub setFrmAppPromocionesProv(formulario As FrmAppPromocionesProv)
        frmAppPromocionesProv = formulario
    End Sub


    Public Sub setIdProveedor(id)
        idProveedor = id
    End Sub
    Public Sub setCondicion(value As String)
        condicion = value
    End Sub

    Sub listarProductos()
        gridProductos.DataSource = Nothing
        dtProductos = New DataTable()

        Dim proveedor As String = ""
        If idProveedor > 0 Then
            proveedor = " WHERE ID_PROVEEDOR=" & idProveedor.ToString & " AND PROD_ACTIVO='S'"
        End If

        If proveedor = "" And condicion IsNot "" Then
            proveedor = " WHERE PROD_ACTIVO= 'S'"
        End If

        dtProductos = contProducto.consultar("SELECT COD_BARRA AS CODIGO_BARRAS, DES_PRODUCTO AS DESCRIPCION FROM PR_PRODUCTOS_VW " & proveedor)
        If dtProductos.Rows.Count > 0 Then
            gridProductos.DataSource = dtProductos
        End If
    End Sub

    Sub enviarID(codigoBarras As String)
        If frmActivo = "FrmAppPromociones" Then
            FrmAppPromociones.getProducto(codigoBarras)
        End If
        If frmActivo = "FrmRptRecepcionProductos" Then
            FrmRptRecepcionProductos.getProducto(codigoBarras)
        End If
        If frmActivo = "FrmActivarDesactivarProducto" Then
            FrmActivarDesactivarProducto.getProducto(codigoBarras)
        End If
        If frmActivo = "FrmRptRecepcionProductosMargen" Then
            FrmRptRecepcionProductosMargen.getProducto(codigoBarras)
        End If
        If frmActivo = "FrmTraspasoProductosSuc" Then
            frmTraspasoProductosSuc.getProducto(codigoBarras)
        End If
        If frmActivo = "FrmCambioPrecioVenta" Then
            frmCambioPrecioVenta.getProducto(codigoBarras)
        End If
        If frmActivo = "FrmExistenciasProducto" Then
            frmExistenciasProducto.getProducto(codigoBarras)
        End If
        If frmActivo = "frm_transacciones_inventario" Then
            frm_transacciones_inventario.productos(codigoBarras)
        End If
        If frmActivo = "FrmAppPromocionesProv" Then
            frmAppPromocionesProv.getProducto(codigoBarras)
        End If
        If frmActivo = "FrmGenerarListaProd" Then
            frmGenerarListaProd.getProducto(codigoBarras)
        End If

        Close()
    End Sub

    Private Sub gridProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles gridProductos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim fila As Integer = GridView1.FocusedRowHandle
            Dim id As String = ""

            If IsDBNull(GridView1.GetRowCellValue(fila, "CODIGO_BARRAS").ToString) Then
                Return
            Else
                id = GridView1.GetRowCellValue(fila, "CODIGO_BARRAS").ToString
            End If

            enviarID(id)
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub gridProductos_DoubleClick(sender As Object, e As EventArgs) Handles gridProductos.DoubleClick
        Dim fila As Integer = GridView1.FocusedRowHandle
        Dim id As String = ""

        If IsDBNull(GridView1.GetRowCellValue(fila, "CODIGO_BARRAS").ToString) Then
            Return
        Else
            id = GridView1.GetRowCellValue(fila, "CODIGO_BARRAS").ToString
        End If

        enviarID(id)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtProductos.Rows.Count > 0 Then
            Dim dv As DataView
            Dim filter As String = ""
            filter += "DESCRIPCION LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR CODIGO_BARRAS LIKE '%" & txtBuscar.Text & "%'"
            dv = dtProductos.DefaultView
            dv.RowFilter = filter
            gridProductos.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridProductos.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class