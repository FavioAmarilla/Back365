Public Class FrmFndPeriodosGestion

    Dim titulo As String = "Periodos de gestion"
    Dim contFdnPeriodosGestion As New ContFndPeriodosGestion

    Dim identificador As Integer = 0
    Dim idEmpresa As Integer = 0

    Private Sub FrmFndPeriodosGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        getAllPeriodosGestion()
    End Sub

    Sub limpiar()
        idEmpresa = 0
        txtEmpresa.Text = ""
        txtNombre.Text = ""
        txtAnho.Text = ""
        cboTrimestre.SelectedIndex = -1
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        chkEstado.Checked = False
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
    End Sub

    Sub cldDesde()
        If cldFechaDesde.Visible = True Then
            cldFechaDesde.Visible = False
        Else
            cldFechaDesde.Visible = True
            cldFechaDesde.Focus()
        End If
    End Sub

    Sub cldHasta()
        If cldFechaHasta.Visible = True Then
            cldFechaHasta.Visible = False
        Else
            cldFechaHasta.Visible = True
            cldFechaHasta.Focus()
        End If
    End Sub

    Sub listarEmpresas()
        Dim frm As New FrmVistaFndEmpresas
        frm.setFrmActivo("FrmFndPeriodosGestion")
        frm.setFrmFndPeriodosGestion(Me)
        frm.ShowDialog()
    End Sub

    Sub getEmpresa(id As String)
        Dim dt As New DataTable
        dt = contFdnPeriodosGestion.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PARM_EMPRESAS WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idEmpresa = CInt(dt.Rows(0).Item(0))
            txtEmpresa.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getAllPeriodosGestion()
        Dim dt As New DataTable
        dt = contFdnPeriodosGestion.consultar("SELECT PG.IDENTIFICADOR, FND_PARM_EMPRESAS.NOMBRE AS EMPRESA, PG.NOMBRE, PG.ANHO, 
                                                PG. TRIMESTRE, PG.FECHA_DESDE, PG.FECHA_HASTA, PG.VR_SITUACION AS ESTADO
                                                FROM FND_PERIODOS_GESTION PG
                                                INNER JOIN FND_PARM_EMPRESAS ON FND_PARM_EMPRESAS.IDENTIFICADOR = PG.ID_EMPRESA
                                                ORDER BY FND_PARM_EMPRESAS.IDENTIFICADOR ASC, FECHA_DESDE DESC")
        If dt.Rows.Count > 0 Then
            GridControl1.DataSource = dt
        End If
    End Sub

    Sub getPeriodoGestion()
        Dim rowhandle As Integer = CInt(GridView1.FocusedRowHandle)
        Dim id As String = CStr(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR"))
        Dim dt As New DataTable
        dt = contFdnPeriodosGestion.consultar("SELECT IDENTIFICADOR, ID_EMPRESA, NOMBRE, ANHO, TRIMESTRE, 
                                               FECHA_DESDE, FECHA_HASTA, VR_SITUACION 
                                                FROM FND_PERIODOS_GESTION WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            identificador = CInt(dt.Rows(0).Item(0))
            getEmpresa(CInt(dt.Rows(0).Item(1)))
            txtNombre.Text = CStr(dt.Rows(0).Item(2))
            txtAnho.Text = CStr(dt.Rows(0).Item(3))
            Dim trimestre As Integer = CInt(dt.Rows(0).Item(4))
            If trimestre = 1 Then
                cboTrimestre.SelectedIndex = 0
            ElseIf trimestre = 2 Then
                cboTrimestre.SelectedIndex = 1
            ElseIf trimestre = 3 Then
                cboTrimestre.SelectedIndex = 2
            ElseIf trimestre = 4 Then
                cboTrimestre.SelectedIndex = 3
            End If
            txtFechaDesde.Text = CStr(dt.Rows(0).Item(5))
            txtFechaHasta.Text = CStr(dt.Rows(0).Item(6))
            Dim estado As String = CStr(dt.Rows(0).Item(7))
            If estado = "AB" Then
                chkEstado.Checked = True
            ElseIf estado = "CE" Then
                chkEstado.Checked = False
            End If
        Else
            ControlMensajes.mensaje("Periodo de gestion no definido", titulo, "WAR")
        End If
    End Sub

    Sub insertarPeriodoGestion()
        If idEmpresa <= 0 Then
            ControlMensajes.mensaje("Debe ingresar empresa", titulo, "WAR")
            txtEmpresa.Focus()
            Return
        End If
        If txtNombre.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("Debe ingresar nombre", titulo, "WAR")
            txtNombre.Focus()
            Return
        End If
        If txtAnho.Text.Replace(" ", "") = "" Then
            ControlMensajes.mensaje("Debe ingresar anho", titulo, "WAR")
            txtAnho.Focus()
            Return
        End If
        If cboTrimestre.SelectedIndex < 0 Then
            ControlMensajes.mensaje("Debe ingresar trimestre", titulo, "WAR")
            cboTrimestre.Focus()
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

        identificador = contFdnPeriodosGestion.getIdPeriodoGestion()
        Dim nombre As String = txtNombre.Text
        Dim anho As Integer = CInt(txtAnho.Text)
        Dim trimestre As Integer = cboTrimestre.SelectedIndex + 1
        Dim fecha_desde As Date = CDate(txtFechaDesde.Text)
        Dim fecha_hasta As Date = CDate(txtFechaHasta.Text)
        Dim vr_situacion As String = ""
        If chkEstado.Checked Then
            vr_situacion = "AB"
        Else
            vr_situacion = "CE"
        End If

        If ControlMensajes.msj_confirmacion("Confirmar operacion", titulo) Then
            If contFdnPeriodosGestion.insrtarPeriodoGestion(identificador, idEmpresa, nombre, anho, trimestre, fecha_desde, fecha_hasta, vr_situacion) Then
                ControlMensajes.mensaje("Periodo de gestion registrado", titulo, "INF")
                limpiar()
                getAllPeriodosGestion()
            Else
                ControlMensajes.mensaje("Periodo de gestion no registrado", titulo, "INF")
            End If
        Else
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "INF")
        End If
    End Sub

    Private Sub txtEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpresa.KeyDown
        If e.KeyCode = Keys.Enter And idEmpresa > 0 Then
            txtNombre.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            listarEmpresas()
        End If
    End Sub

    Private Sub btnEmpresas_Click(sender As Object, e As EventArgs) Handles btnEmpresas.Click
        listarEmpresas()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter And txtNombre.Text.Replace(" ", "") IsNot "" Then
            txtAnho.Focus()
        End If
    End Sub

    Private Sub txtAnho_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAnho.KeyDown
        If e.KeyCode = Keys.Enter And txtAnho.Text.Replace(" ", "") IsNot "" Then
            cboTrimestre.Focus()
        End If
    End Sub

    Private Sub cboTrimestre_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTrimestre.KeyDown
        If e.KeyCode = Keys.Enter And cboTrimestre.SelectedIndex >= 0 Then
            txtFechaDesde.Focus()
        End If
    End Sub

    Private Sub txtFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFechaDesde.Text = "  /  /" Then
            Else
                txtFechaHasta.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            cldDesde()
        End If
    End Sub

    Private Sub btnFechaDesde_Click(sender As Object, e As EventArgs) Handles btnFechaDesde.Click
        cldDesde()
    End Sub

    Private Sub cldFechaDesde_DoubleClick(sender As Object, e As EventArgs) Handles cldFechaDesde.DoubleClick
        txtFechaDesde.Text = cldFechaDesde.DateTime.ToString
        txtFechaDesde.Focus()
        cldDesde()
    End Sub

    Private Sub cldFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaDesde.Text = cldFechaDesde.DateTime.ToString
            txtFechaDesde.Focus()
            cldDesde()
        End If
        If e.KeyCode = Keys.Escape Then
            cldDesde()
        End If
    End Sub

    Private Sub txtFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFechaHasta.Text = "  /  /" Then
            Else
                chkEstado.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            cldHasta()
        End If
    End Sub

    Private Sub btnFechaHasta_Click(sender As Object, e As EventArgs) Handles btnFechaHasta.Click
        cldHasta()
    End Sub

    Private Sub cldFechaHasta_DoubleClick(sender As Object, e As EventArgs) Handles cldFechaHasta.DoubleClick
        txtFechaHasta.Text = cldFechaHasta.DateTime.ToString
        txtFechaHasta.Focus()
        cldHasta()
    End Sub

    Private Sub cldFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaHasta.Text = cldFechaHasta.DateTime.ToString
            txtFechaHasta.Focus()
            cldHasta()
        End If
        If e.KeyCode = Keys.Escape Then
            cldHasta()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        insertarPeriodoGestion()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        getAllPeriodosGestion()
    End Sub

    Private Sub chkEstado_KeyDown(sender As Object, e As KeyEventArgs) Handles chkEstado.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            getPeriodoGestion()
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        getPeriodoGestion()
    End Sub

End Class