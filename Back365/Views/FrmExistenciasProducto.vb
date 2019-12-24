Public Class FrmExistenciasProducto

    Dim titulo As String = "Existencia"
    Dim contStkMovimStock As New ContStkMovimStock

    Private Sub FrmExistenciasProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        txtCodigoBarras.Text = ""
        txtdescripcion.Text = ""

        gridExistencia.DataSource = Nothing
    End Sub

    Sub getProducto(codigoBarras As String)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("SELECT STK_ALMACENES.DESCRIPCION AS ALMACEN, STK.EXISTENCIA, PR_PRODUCTOS.DESCRIPCION
                                            FROM STK_STOCK_PROD STK
                                            INNER JOIN STK_ALMACENES ON STK_ALMACENES.IDENTIFICADOR = STK.ID_ALMACEN
                                            INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = STK.ID_PRODUCTO
                                            WHERE PR_PRODUCTOS.CODIGO_BARRAS = '" & codigoBarras & "'")

        If dt.Rows.Count > 0 Then
            txtCodigoBarras.Text = codigoBarras
            txtdescripcion.Text = dt.Rows(0).Item(2)
            gridExistencia.DataSource = dt
        Else
            ControlMensajes.mensaje("Producto no definido en almacenes", titulo, "INF")
        End If
    End Sub

    Sub listarProductos()
        Dim frm As New FrmVistaPrProductos
        frm.setFrmExistenciasProducto(Me)
        frm.setFrmActivo("FrmExistenciasProducto")
        frm.ShowDialog()
    End Sub

    Private Sub txtCodigoBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarras.KeyDown
        If e.KeyCode = Keys.Enter And txtCodigoBarras.Text.Replace(" ", "") IsNot "" Then
            getProducto(txtCodigoBarras.Text)
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarProductos()
        End If

    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        listarProductos()
    End Sub

    Private Sub txtdescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdescripcion.KeyDown
        If e.KeyCode = Keys.Enter And txtdescripcion.Text.Replace(" ", "") IsNot "" Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtCodigoBarras.Text.Replace(" ", "") IsNot "" Then
            getProducto(txtCodigoBarras.Text)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelar", titulo) Then
            limpiar()
        End If
    End Sub
End Class