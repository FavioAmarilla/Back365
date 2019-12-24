Public Class FrmAppVtaPromociones

    Dim contAppVtaPromociones As New ContAppVtaPromociones
    Dim titulo As String = "Promocion"

    Dim idSitio As Integer = 0
    Dim identificador As Integer = 0

    Private Sub FrmAppVtaPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldDesde.Visible = False
        cldHasta.Visible = False

        emitidos(False)
    End Sub

    Sub emitidos(flag As Boolean)
        lblEmitido.Visible = flag
        txtEmitido.Visible = flag
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
            frm.setFrmActivo("FrmAppVtaPromociones")
            frm.setFrmAppVtaPromociones(Me)
            frm.ShowDialog()
        End If

        If verificador = "PR" Then
            Dim frm As New FrmVistaVtaPromociones
            frm.setFrmActivo("FrmAppVtaPromociones")
            frm.setFrmAppVtaPromociones(Me)
            frm.ShowDialog()
        End If
    End Sub

    Sub limpiar()
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        txtsucursal.Text = ""
        txtNombre.Text = ""
        txtMonto.Text = ""
        txtEmitido.Text = ""
        emitidos(False)
        btnAceptar.Enabled = True
    End Sub

    Sub getSitio(id As Integer)
        Dim dt As New DataTable
        dt = contAppVtaPromociones.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtsucursal.Text = CStr(dt.Rows(0).Item(1))
        Else
            ControlMensajes.mensaje("Sucursal no definida", titulo, "WAR")
        End If
    End Sub

    Sub aceptar()
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
        If txtNombre.Text = "" Then
            ControlMensajes.mensaje("Debe ingresar nombre", titulo, "WAR")
            txtNombre.Focus()
            Return
        End If
        If txtMonto.Text = "" Then
            ControlMensajes.mensaje("Debe ingresar monto", titulo, "WAR")
            txtMonto.Focus()
            Return
        End If
        If CInt(txtMonto.Text) <= 0 Then
            ControlMensajes.mensaje("Monto debe ser mayor a cero(0)", titulo, "WAR")
            txtMonto.Focus()
            Return
        End If

        identificador = contAppVtaPromociones.getIdentificador()
        Dim fechaDesde As Date = txtFechaDesde.Text
        Dim fechaHasta As Date = txtFechaHasta.Text

        Dim queryCajas As String = ""
        Dim dtCajas As New DataTable
        Dim idCaja As Integer = 0
        If idSitio > 0 Then
            queryCajas = "SELECT IDENTIFICADOR, ID_SITIO FROM TC_CAJAS WHERE ACTIVO='S' AND ID_SITIO = " & CStr(idSitio)
        Else
            queryCajas = "SELECT IDENTIFICADOR, ID_SITIO  FROM TC_CAJAS WHERE ACTIVO='S'"
        End If

        dtCajas = contAppVtaPromociones.consultar(queryCajas)
        If dtCajas.Rows.Count > 0 Then
            For j As Integer = 0 To dtCajas.Rows.Count - 1
                idCaja = CInt(dtCajas.Rows(j).Item(0))
                If contAppVtaPromociones.insertar(identificador, dtCajas.Rows(j).Item(1), dtCajas.Rows(j).Item(0), CInt(txtMonto.Text), fechaDesde, fechaHasta, txtNombre.Text, 0) = False Then
                    ControlMensajes.mensaje("Promocion no registrada", titulo, "WAR")
                    Return
                End If
            Next
        Else
            ControlMensajes.mensaje("Cajas no definidas", titulo, "WAR")
        End If

        ControlMensajes.mensaje("Promocion registrada", titulo, "INF")
        limpiar()
    End Sub

    Sub getPromocion(id As Integer)
        Dim dt As New DataTable
        dt = contAppVtaPromociones.consultar("SELECT FECHA_DESDE, FECHA_HASTA, ID_SITIO, NOMBRE, MONTO, SUM(ULT_NUMERO) FROM APP_VTA_PROMOCIONES
                                                WHERE IDENTIFICADOR=" & CStr(id) & "
                                                GROUP BY FECHA_DESDE, FECHA_HASTA, ID_SITIO, NOMBRE, MONTO")

        If dt.Rows.Count > 0 Then
            txtFechaDesde.Text = CStr(dt.Rows(0).Item(0))
            txtFechaHasta.Text = CStr(dt.Rows(0).Item(1))
            getSitio(CInt(dt.Rows(0).Item(2)))
            txtNombre.Text = CStr(dt.Rows(0).Item(3))
            txtMonto.Text = CStr(dt.Rows(0).Item(4))
            txtEmitido.Text = CStr(dt.Rows(0).Item(5))
        End If

        emitidos(True)
        btnAceptar.Enabled = False
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
                txtsucursal.Focus()
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

    Private Sub txtsucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNombre.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        vistas("SI")
    End Sub
    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter And txtNombre.Text IsNot "" Then
            txtMonto.Focus()
        End If
    End Sub

    Private Sub txtMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter And txtMonto.Text IsNot "" Then
            If CInt(txtMonto.Text) > 0 Then
                btnAceptar.Focus()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        aceptar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        vistas("PR")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
End Class