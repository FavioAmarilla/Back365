Public Class FrmCerrarControlCajas

    Dim titulo As String = "Cerrar controles de caja"
    Dim util As New Util
    Dim contControlCaja As New ContTcControlCaja

    Dim idCaja As Integer = 0
    Dim ipCaja As String = 0

    Private Sub FrmCerrarControlCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFechaHasta.Visible = False
        cldFechaDesde.Visible = False
        txtCaja.Focus()
    End Sub

    Sub cancelar()
        txtCaja.Text = ""
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
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

        If verificador = "CA" Then
            Dim frm As New FrmVistaTcCajas
            frm.setFrmActivo("FrmCerrarControlCajas")
            frm.ShowDialog()
        End If
    End Sub

    Public Sub getCaja(id As String)
        Dim contCaja As New ContTcCajas
        Dim dt As New DataTable
        dt = contCaja.consultar("SELECT IDENTIFICADOR, DIRECCION_IP, DESCRIPCION FROM TC_CAJAS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idCaja = CInt(dt.Rows(0).Item(0))
            ipCaja = CStr(dt.Rows(0).Item(1))
            txtCaja.Text = CStr(dt.Rows(0).Item(2))
            txtCaja.Focus()
        End If
    End Sub

    Public Sub getControlesCaja()
        If util.ping(ipCaja) = False Then
            Return
        End If

        Dim desde As String = ""
        Dim hasta As String = ""
        Dim dt As New DataTable

        If txtFechaDesde.Text = "  /  /" Then
        Else
            desde = " AND TRUNC(TC.FECHA_APERT) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy') "
        End If

        If txtFechaHasta.Text = "  /  /" Then
        Else
            hasta = " AND TRUNC(TC.FECHA_APERT) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy') "
        End If

        dt = contControlCaja.consultar("SELECT TC.IDENTIFICADOR, TC.FECHA_APERT, FND_PARM_EMPRESAS.NOMBRE AS EMPRESA, CO_UNIDADES_OPERAT.DESCRIPCION AS UNIDAD,
                                        TC_CAJAS.DESCRIPCION AS CAJA, COALESCE(TC.ARQUEADO, 'N') AS ARQUEADO,  COALESCE(CERRADO, 'N') AS CERRADO
                                        FROM TC_CONTROL_CAJA TC
                                        LEFT JOIN FND_PARM_EMPRESAS ON FND_PARM_EMPRESAS.IDENTIFICADOR = TC.ID_EMPRESA
                                        LEFT JOIN CO_UNIDADES_OPERAT ON CO_UNIDADES_OPERAT.IDENTIFICADOR = TC.ID_UNIDAD
                                        LEFT JOIN TC_CAJAS ON TC_CAJAS.IDENTIFICADOR = TC.ID_CAJA
                                        WHERE COALESCE(CERRADO, 'N') = 'N' " &
                                        desde &
                                        hasta &
                                        "ORDER BY TC.FECHA_APERT ASC", ipCaja)

        If dt.Rows.Count > 0 Then
            gridControles.DataSource = dt
        Else
            ControlMensajes.mensaje("No existen controles de caja abiertos", titulo, "INF")
        End If
    End Sub

    Public Sub cerrarControles()
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("No se seleccionaron controles de caja", titulo, "ERR")
            Return
        End If
        If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) Then
            ControlMensajes.mensaje("Operacion no confirmada", titulo, "ERR")
            Return
        End If

        Dim identificador As Integer = 0
        Dim cerrado As String = ""
        Dim arqueado As String = ""

        For i As Integer = 0 To GridView1.RowCount - 1
            identificador = CInt(GridView1.GetRowCellValue(i, "IDENTIFICADOR").ToString)
            cerrado = GridView1.GetRowCellValue(i, "CERRADO").ToString
            cerrado = GridView1.GetRowCellValue(i, "ARQUEADO").ToString

            If cerrado = "S" Then
                If contControlCaja.cerrarControl(identificador, cerrado, arqueado) = False Then
                    ControlMensajes.mensaje("Controles de caja no cerrados: " & identificador.ToString, titulo, "ERR")
                    Return
                End If
            End If
        Next

        ControlMensajes.mensaje("Controles de caja cerrados", titulo, "ERR")
    End Sub

    Private Sub txtCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCaja.KeyDown
        If e.KeyCode = Keys.Enter And txtCaja.Text IsNot "" Then
            txtFechaDesde.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("CA")
        End If
    End Sub

    Private Sub btnCajas_Click(sender As Object, e As EventArgs) Handles btnCajas.Click
        vistas("CA")
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
                btnConsultar.Focus()
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        getControlesCaja()
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        cerrarControles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub
End Class