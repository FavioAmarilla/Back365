Imports System.Threading

Public Class FrmActivarDesactivarProducto

    Dim titulo As String = "Activar/Desact. producto"
    Dim producto As New ContPrProductos

    Dim idProducto As Integer = 0
    Dim idProveedor As Integer = 0
    Dim idFamilia As Integer = 0
    Dim idMarca As Integer = 0
    Dim idPresentacion As Integer = 0

    Private Sub FrmActivarDesactivarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub vistas(vr As String)
        If vr = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmActivarDesactivarProducto")
            frm.ShowDialog()
        End If

        If vr = "LP" Then
            Dim frm As New FrmVistaPrFamilias
            frm.setFrmActivo("FrmActivarDesactivarProducto")
            frm.ShowDialog()
        End If

        If vr = "PE" Then
            Dim frm As New FrmVistaPrPresentaciones
            frm.setFrmActivo("FrmActivarDesactivarProducto")
            frm.ShowDialog()
        End If

        If vr = "MA" Then
            Dim frm As New FrmVistaPrMarcas
            frm.setFrmActivo("FrmActivarDesactivarProducto")
            frm.ShowDialog()
        End If

        If vr = "PV" Then
            Dim frm As New FrmVistaCpProveedores
            frm.setFrmActivo("FrmActivarDesactivarProducto")
            frm.ShowDialog()
        End If
    End Sub

    Sub limpiar()
        txtCodigoBarras.Text = ""
        txtDescripcion.Text = ""
        txtCodigo.Text = ""
        txtId.Text = ""
        txtProveedor.Text = ""
        txtFamilia.Text = ""
        txtMarca.Text = ""
        txtPresentacion.Text = ""
        chkActivo.Checked = False
        idProducto = 0
        idProveedor = 0
        idFamilia = 0
        idMarca = 0
        idPresentacion = 0

        txtCodigoBarras.Focus()
    End Sub

    Sub getProducto(id As String)
        Dim activo As String = "N"

        If id.Replace(" ", "") = "" Then
            txtCodigoBarras.Focus()
        End If

        Dim dt As New DataTable
        dt = producto.consultar("SELECT PR.CODIGO_BARRAS, PR.DESCRIPCION, PR.CODIGO, PR.IDENTIFICADOR, COALESCE(PR_LINEAS_PROD.DESCRIPCION, 'NO DEFINIDO'),
                                 COALESCE(PR_PRESENTACION.DESCRIPCION, 'NO DEFINIDO'), COALESCE(PR.ID_LINEA, 0), COALESCE(PR.ID_PRESENTACION, 0), COALESCE(PR.ACTIVO, 'N'),
                                 COALESCE( PR.ID_MARCA, 0), COALESCE(PR_MARCAS.DESCRIPCION, 'NO DEFINIDO'),
                                 COALESCE(PR.ID_PROVEEDOR, 0), COALESCE(CP_PROVEEDORES.DENOMINACION, 'NO DEFINIDO')
                                 FROM PR_PRODUCTOS  PR
                                 LEFT JOIN PR_LINEAS_PROD ON PR_LINEAS_PROD.IDENTIFICADOR = PR.ID_LINEA
                                 LEFT JOIN PR_MARCAS ON PR_MARCAS.IDENTIFICADOR = PR.ID_MARCA
                                 LEFT JOIN PR_PRESENTACION ON PR_PRESENTACION.IDENTIFICADOR = PR.ID_PRESENTACION
                                 LEFT JOIN CP_PROVEEDORES ON CP_PROVEEDORES.IDENTIFICADOR = PR.ID_PROVEEDOR
                                 WHERE PR.CODIGO_BARRAS='" & id & "' OR PR.IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            txtCodigoBarras.Text = CStr(dt.Rows(0).Item(0))
            txtDescripcion.Text = CStr(dt.Rows(0).Item(1))
            txtCodigo.Text = CStr(dt.Rows(0).Item(2))
            txtId.Text = CStr(dt.Rows(0).Item(3))
            txtFamilia.Text = CStr(dt.Rows(0).Item(4))
            txtPresentacion.Text = CStr(dt.Rows(0).Item(5))
            idProducto = CInt(txtId.Text)
            idFamilia = CInt(dt.Rows(0).Item(6))
            idPresentacion = CInt(dt.Rows(0).Item(7))
            activo = CStr(dt.Rows(0).Item(8))
            idMarca = CInt(dt.Rows(0).Item(9))
            txtMarca.Text = CStr(dt.Rows(0).Item(10))
            idProveedor = CInt(dt.Rows(0).Item(11))
            txtProveedor.Text = CStr(dt.Rows(0).Item(12))

            If activo = "S" Then
                chkActivo.Checked = True
            End If
            If activo = "N" Then
                chkActivo.Checked = False
            End If

            txtDescripcion.Focus()
        Else
            ControlMensajes.mensaje("Producto no definido", titulo, "WAR")
            txtCodigoBarras.Focus()
        End If
    End Sub

    Sub getFamilia(id As String)
        Dim dt As New DataTable
        dt = producto.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_LINEAS_PROD WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idFamilia = CInt(dt.Rows(0).Item(0))
            txtFamilia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getMarca(id As String)
        Dim dt As New DataTable
        dt = producto.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_MARCAS WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idMarca = CInt(dt.Rows(0).Item(0))
            txtMarca.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getPresentacion(id As String)
        Dim dt As New DataTable
        dt = producto.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_PRESENTACION WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idPresentacion = CInt(dt.Rows(0).Item(0))
            txtPresentacion.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getProveedor(id As String)
        Dim dt As New DataTable
        dt = producto.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idProveedor = CInt(dt.Rows(0).Item(0))
            txtProveedor.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub


    Sub actualizar()
        Dim activo As String

        If idProducto <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar producto", titulo, "WAR")
            txtCodigoBarras.Focus()
            Return
        End If

        If chkActivo.Checked Then
            activo = "S"
        Else
            activo = "N"
        End If

        If producto.actualizarParm(idProducto, txtDescripcion.Text, idFamilia, idMarca, idPresentacion, idProveedor, activo) Then
            ControlMensajes.mensaje("Producto actualizado", titulo, "INF")
            limpiar()
            txtCodigoBarras.Focus()
        Else
            ControlMensajes.mensaje("Producto no actualizado", titulo, "WAR")
        End If
    End Sub

    Private Sub txtCodigoBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigoBarras.Text IsNot "" Then
                getProducto(txtCodigoBarras.Text)
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PR")
        End If
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        vistas("PR")
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDescripcion.Text IsNot "" Then
                txtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigo.Text IsNot "" Then
                txtId.Focus()
            End If
        End If
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtId.Text IsNot "" Then
                txtProveedor.Focus()
            End If
        End If
    End Sub
    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtProveedor.Text IsNot "" Then
                txtFamilia.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PV")
        End If
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        vistas("PV")
    End Sub

    Private Sub txtFamilia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFamilia.Text IsNot "" Then
                txtMarca.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("LP")
        End If
    End Sub

    Private Sub btnFamilia_Click(sender As Object, e As EventArgs) Handles btnFamilia.Click
        vistas("LP")
    End Sub
    Private Sub txtMarca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarca.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtMarca.Text IsNot "" Then
                txtPresentacion.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("MA")
        End If
    End Sub

    Private Sub btnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        vistas("MA")
    End Sub


    Private Sub txtPresentacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPresentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPresentacion.Text IsNot "" Then
                chkActivo.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PE")
        End If
    End Sub

    Private Sub btnPresentacion_Click(sender As Object, e As EventArgs) Handles btnPresentacion.Click
        vistas("PE")
    End Sub

    Private Sub chkActivo_KeyDown(sender As Object, e As KeyEventArgs) Handles chkActivo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        actualizar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

End Class