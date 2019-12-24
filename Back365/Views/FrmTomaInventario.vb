Public Class FrmTomaInventario

    Dim contTomaInventario As New ContAppTomaInventario
    Dim dtItems As New DataTable
    Dim titulo As String = "Toma de inventario"

    Dim idUnidad As Integer = 0
    Dim idEmpresa As Integer = 0
    Dim idSucursal As Integer = 0


    Private Sub FrmTomaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFecha.Visible = False
    End Sub

    Sub limpiar()
        txtSucursal.Text = ""
        txtDescripcion.Text = ""
        txtFecha.Text = ""
        txtApuntador.Text = ""
        txtNumero.Text = ""
        txtReferencia.Text = ""
        txtNoEncontrados.Text = ""
        gridProductos.DataSource = Nothing

        idEmpresa = 0
        idUnidad = 0
        idSucursal = 0
    End Sub

    Sub vistas(verificador As String)
        If verificador = "FE" Then
            If cldFecha.Visible = True Then
                cldFecha.Visible = False
            Else
                cldFecha.Visible = True
                cldFecha.Focus()
            End If
        End If

        If verificador = "EM" Then
            Dim frm As New FrmVistaFndEmpresas
            frm.setFrmActivo("FrmTomaInventario")
            frm.ShowDialog()
        End If

        If verificador = "UO" Then
            Dim frm As New FrmVistaCoUnidadesOperat
            frm.setFrmActivo("FrmTomaInventario")
            frm.ShowDialog()
        End If

        If verificador = "SI" Then
            Dim frm As New FrmVistaFndSitios
            frm.setFrmActivo("FrmTomaInventario")
            frm.ShowDialog()
        End If
    End Sub


    Public Sub getSucursal(id As String)
        Dim dt As New DataTable
        dt = contTomaInventario.consultar("SELECT IDENTIFICADOR, DESCRIPCION, ID_EMPRESA, ID_UNIDAD FROM FND_SITIOS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idSucursal = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))

            idEmpresa = CInt(dt.Rows(0).Item(2))
            idUnidad = CInt(dt.Rows(0).Item(3))

            txtSucursal.Focus()
        End If
    End Sub


    Private Sub crear_cursor()
        dtItems = New DataTable
        dtItems.Columns.Add("ID_PRODUCTO")
        dtItems.Columns.Add("ID_PROVEEDOR")
        dtItems.Columns.Add("CODIGO_BARRAS")
        dtItems.Columns.Add("DESCRIPCION")
        dtItems.Columns.Add("CANTIDAD")
        dtItems.Columns.Add("COSTO_UNITARIO")
        dtItems.Columns.Add("PRECIO_VENTA")
        dtItems.Columns.Add("TOTAL_COSTO")
        dtItems.Columns.Add("TOTAL_VENTA")

        gridProductos.DataSource = dtItems
    End Sub


    Public Sub getProducto(codigoBarras As String)
        Dim cantidad As Integer = getCantidad(codigoBarras)
        codigoBarras = getCodigoBarras(codigoBarras)

        If codigoBarras.Replace(" ", "") = "" Then
            Return
        End If

        If GridView1.RowCount <= 0 Then
            crear_cursor()
        End If

        Dim dt As New DataTable
        dt = contTomaInventario.consultar("SELECT PR.IDENTIFICADOR, PR.ID_PROVEEDOR, PR.CODIGO_BARRAS, PR.DESCRIPCION,
                                            COALESCE(ROUND((ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO) * FND_TIPOS_IMPUESTO.VALOR) / 100) + 
                                            ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO), 0) AS COSTO_UNITARIO,
                                            COALESCE(ROUND(PR.PRECIO_VENTA), 0)
                                            FROM PR_PRODUCTOS PR
                                            LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                                            LEFT JOIN FND_TIPOS_IMPUESTO ON FND_TIPOS_IMPUESTO.IDENTIFICADOR = PR.ID_TIPO_IMPUESTO
                                            WHERE PR.CODIGO_BARRAS= '" & codigoBarras & "'")


        If dt.Rows.Count > 0 Then
            Dim newRow As DataRow = (TryCast(gridProductos.DataSource, DataTable)).NewRow()

            newRow("ID_PRODUCTO") = dt.Rows(0).Item(0)
            newRow("ID_PROVEEDOR") = dt.Rows(0).Item(1)
            newRow("CODIGO_BARRAS") = dt.Rows(0).Item(2)
            newRow("DESCRIPCION") = dt.Rows(0).Item(3)
            newRow("CANTIDAD") = cantidad
            newRow("COSTO_UNITARIO") = dt.Rows(0).Item(4)
            newRow("PRECIO_VENTA") = dt.Rows(0).Item(5)
            newRow("TOTAL_COSTO") = dt.Rows(0).Item(4) * cantidad
            newRow("TOTAL_VENTA") = dt.Rows(0).Item(5) * cantidad

            TryCast(gridProductos.DataSource, DataTable).Rows.Add(newRow)
            gridProductos.RefreshDataSource()
        Else
            txtNoEncontrados.Text += "Producto no definido: " & codigoBarras & vbCrLf
        End If

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


    Sub insertarTomaInventario()
        If txtSucursal.Text = "" Then
            ControlMensajes.mensaje("El campo sucursal no puede estar vacio", titulo, "WAR")
            txtSucursal.Focus()
            Return
        End If
        If txtFecha.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha no puede estar vacio", titulo, "WAR")
            txtFecha.Focus()
            Return
        End If
        If txtApuntador.Text = "" Then
            ControlMensajes.mensaje("El campo apuntador no puede estar vacio", titulo, "WAR")
            txtApuntador.Focus()
            Return
        End If
        If txtNumero.Text = "" Then
            ControlMensajes.mensaje("El campo numero no puede estar vacio", titulo, "WAR")
            txtNumero.Focus()
            Return
        End If
        If txtReferencia.Text = "" Then
            ControlMensajes.mensaje("El campo referencia no puede estar vacio", titulo, "WAR")
            txtReferencia.Focus()
            Return
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("No se agregaron items a la toma de inventario", titulo, "WAR")
            btnCargarProd.Focus()
            Return
        End If

        Dim identificador As Integer = contTomaInventario.getIdTomaInventario()
        Dim numero As String = txtNumero.Text
        Dim fecha As String = txtFecha.Text
        Dim apuntador As String = txtApuntador.Text
        Dim descripcion As String = txtDescripcion.Text


        If contTomaInventario.insertarTomaInventario(identificador, numero, fecha, apuntador, idEmpresa, idSucursal, idUnidad, descripcion) = False Then
            ControlMensajes.mensaje("Toma de inventario no registrado", titulo, "WAR")
            Return
        End If

        insertarTomaInvItems(identificador)
    End Sub

    Sub insertarTomaInvItems(idTomaInventario As Integer)
        Dim identificador As Integer = 0
        Dim idProducto As Integer = 0
        Dim precioVenta As Integer = 0
        Dim costoUnitario As Integer = 0
        Dim cantidad As Double = 0
        Dim idProveedor As Integer = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            identificador = contTomaInventario.getIdTomaInvItem()
            idProducto = GridView1.GetRowCellValue(i, "ID_PRODUCTO")
            precioVenta = GridView1.GetRowCellValue(i, "PRECIO_VENTA")
            costoUnitario = GridView1.GetRowCellValue(i, "COSTO_UNITARIO")
            cantidad = GridView1.GetRowCellValue(i, "CANTIDAD")
            idProveedor = GridView1.GetRowCellValue(i, "ID_PROVEEDOR")

            If contTomaInventario.insertarTomaInvItem(identificador, idTomaInventario, idProducto, precioVenta, costoUnitario, cantidad, idProveedor) = False Then
                ControlMensajes.mensaje("Item de inventario no registrado: " & i, titulo, "WAR")
                Return
            End If
        Next

        ControlMensajes.mensaje("Toma de inventario registrado", titulo, "INF")
        limpiar()
    End Sub

    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSucursal.Text IsNot "" Then
                txtDescripcion.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub btnBuscarSucursal_Click(sender As Object, e As EventArgs) Handles btnBuscarSucursal.Click
        vistas("SI")
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        txtFecha.Focus()
    End Sub

    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFecha.Text = "  /  /" Then
            Else
                txtApuntador.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FE")
        End If
    End Sub

    Private Sub btnFechaDesde_Click(sender As Object, e As EventArgs) Handles btnFecha.Click
        vistas("FE")
    End Sub

    Private Sub cldFechaDesde_DoubleClick(sender As Object, e As EventArgs) Handles cldFecha.DoubleClick
        txtFecha.Text = cldFecha.DateTime.ToString
        txtFecha.Focus()
        vistas("FE")
    End Sub

    Private Sub cldFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFecha.Text = cldFecha.DateTime.ToString
            txtFecha.Focus()
            vistas("FE")
        End If
        If e.KeyCode = Keys.Escape Then
            vistas("FE")
        End If
    End Sub

    Private Sub txtApuntador_KeyDown(sender As Object, e As KeyEventArgs) Handles txtApuntador.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtApuntador.Text.Replace(" ", "") IsNot "" Then
                txtNumero.Text = contTomaInventario.getNroTomaInventario()
                txtNumero.Focus()
            End If
        End If
    End Sub

    Private Sub txtNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNumero.Text.Replace(" ", "") IsNot "" Then
                txtReferencia.Focus()
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReferencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtReferencia.Text.Replace(" ", "") IsNot "" Then
                btnCargarProd.Focus()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion?", titulo) = False Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "WAR")
        End If
        insertarTomaInventario()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnCargarProd_Click(sender As Object, e As EventArgs) Handles btnCargarProd.Click
        Dim frm As New FrmCargaRapidaProd
        frm.setFrmActivo("FrmTomaInventario")
        frm.setFrmTomaInventario(Me)
        frm.ShowDialog()
    End Sub

End Class