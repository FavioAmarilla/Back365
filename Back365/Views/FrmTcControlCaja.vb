Public Class FrmTcControlCaja

    Dim contReportes As New ContReportes
    Dim titulo As String = "Control de cajas"
    Dim idSitio As Integer = 0



    Private Sub FrmTcControlCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldDesde.Visible = False
        cldHasta.Visible = False
    End Sub

    Sub limpiar()
        idSitio = 0
        txtsucursal.Text = ""
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
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
            frm.setFrmActivo("FrmTcControlCaja")
            frm.setFrmTcControlCaja(Me)
            frm.ShowDialog()
        End If

    End Sub

    Sub getSitio(id As Integer)
        Dim dt As New DataTable
        dt = contReportes.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtsucursal.Text = CStr(dt.Rows(0).Item(1))
            txtsucursal.Focus()
        Else
            ControlMensajes.mensaje("Sucursal no definida", titulo, "WAR")
        End If
    End Sub

    Sub consultar()
        Dim sitio As String = ""
        Dim cjDesde As String = ""
        Dim cjHasta As String = ""

        If idSitio > 0 Then
            sitio = " AND TC_CAJAS.ID_SITIO=" & idSitio & " "
        End If

        Dim dt As New DataTable
        dt = contReportes.consultar("SELECT TC.FECHA_APERT, TC_CAJAS.DESCRIPCION AS CAJA, TC.USR_APERTURA AS USUARIO, TC_ARQUEO_CAJA.DIFERENCIA,
                                        COALESCE(TC.ARQUEADO, 'N') AS ARQUEADO, COALESCE(TC.CERRADO, 'N') AS CERRADO, 
                                        CASE
                                            WHEN TC.FECHA_ENVIO_SRV IS NULL
                                            THEN 'N'
                                            ELSE 'S'
                                          END AS FECHA_ENVIO_SRV
                                        FROM TC_CONTROL_CAJA TC
                                        LEFT JOIN TC_ARQUEO_CAJA ON TC_ARQUEO_CAJA.ID_CONTROL = TC.IDENTIFICADOR
                                        LEFT JOIN TC_CAJAS ON TC_CAJAS.IDENTIFICADOR = TC.ID_CAJA
                                        WHERE TRUNC(TC.FECHA_APERT) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy')
                                        AND TRUNC(TC.FECHA_APERT) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy') " & sitio &
                                        " ORDER BY TC_CAJAS.ID_SITIO ASC, TC_CAJAS.DESCRIPCION ASC ")


        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        Else
            ControlMensajes.mensaje("No se determinaron controles para la fecha", titulo, "WAR")
        End If
    End Sub

    Private Sub txtsucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaDesde.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SI")
        End If
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        vistas("SI")
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
                btnAceptar.Focus()
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        consultar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

End Class