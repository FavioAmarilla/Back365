Imports DevExpress.XtraReports.UI

Public Class FrmRptArqueoCajas

    Dim contReportes As New ContReportes
    Dim titulo As String = "Arqueo de cajas"
    Dim idSitio As Integer = 0
    Dim cajaDesde As Integer = 0
    Dim cajaHasta As Integer = 0

    Dim dtConceptosArqueo As New DataTable
    Dim dtDeclaracionesEfect As New DataTable
    Dim dtGastosdiarios As New DataTable
    Dim totalEfectivo As Integer = 0
    Dim totalEntrega As Integer = 0
    Dim totalTicket As Integer = 0
    Dim diferencia As Integer = 0
    Dim totalGastos As Integer = 0


    Private Sub FrmRptArqueoCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldDesde.Visible = False
        cldHasta.Visible = False
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
            frm.setFrmActivo("FrmRptArqueoCajas")
            frm.setFrmRptArqueoCajas(Me)
            frm.ShowDialog()
        End If

        If verificador = "CD" Then
            Dim frm As New FrmVistaTcCajas
            frm.setFrmActivo("FrmRptArqueoCajasD")
            frm.setcondicion(" WHERE ID_SITIO=" & CStr(idSitio) & " ")
            frm.setFrmRptArqueoCajas(Me)
            frm.ShowDialog()
        End If

        If verificador = "CH" Then
            Dim frm As New FrmVistaTcCajas
            frm.setFrmActivo("FrmRptArqueoCajasH")
            frm.setcondicion(" WHERE ID_SITIO=" & CStr(idSitio) & " ")
            frm.setFrmRptArqueoCajas(Me)
            frm.ShowDialog()
        End If

    End Sub

    Sub getSitio(id As Integer)
        Dim dt As New DataTable
        dt = contReportes.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtsucursal.Text = CStr(dt.Rows(0).Item(1))
            cajaDesde = 0
            cajaHasta = 0
            txtCajaDesde.Text = ""
            txtCajaHasta.Text = ""
        Else
            ControlMensajes.mensaje("Sucursal no definida", titulo, "WAR")
        End If
    End Sub

    Sub getcaja(id As Integer, verificador As String)
        Dim dt As New DataTable
        dt = contReportes.consultar("SELECT DESCRIPCION, NUMERO FROM TC_CAJAS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            If verificador = "FrmRptArqueoCajasD" Then
                txtCajaDesde.Text = CStr(dt.Rows(0).Item(0))
                cajaDesde = CInt(dt.Rows(0).Item(1))
            End If
            If verificador = "FrmRptArqueoCajasH" Then
                txtCajaHasta.Text = CStr(dt.Rows(0).Item(0))
                cajaHasta = CInt(dt.Rows(0).Item(1))
            End If
        Else
            ControlMensajes.mensaje("Caja no definida", titulo, "WAR")
        End If
    End Sub

    Function getTotalTickets() As Boolean
        Dim sitio As String = ""
        Dim cjDesde As String = ""
        Dim cjHasta As String = ""

        If idSitio > 0 Then
            sitio = " AND TC_CAJAS.ID_SITIO=" & idSitio & " "
        End If
        If cajaDesde > 0 Then
            cjDesde = "AND TC_CAJAS.NUMERO >= " & cajaDesde & " "
        End If
        If cajaHasta > 0 Then
            cjHasta = " AND TC_CAJAS.NUMERO <= " & cajaHasta & " "
        End If

        dtConceptosArqueo = contReportes.consultar("Select COALESCE(SUM(MONTO_TOTAL), 0)
                                                    FROM VTA_COMPROBANTES VTA
                                                    INNER JOIN TC_CAJAS ON TC_CAJAS.IDENTIFICADOR = VTA.ID_CAJA
                                                    WHERE VTA.ID_CONTROL_CAJA IN (SELECT AR.ID_CONTROL
                                                    FROM TC_ARQUEO_CAJA AR
                                                    INNER JOIN TC_CAJAS ON TC_CAJAS.IDENTIFICADOR = AR.ID_CAJA
                                                    WHERE 
                                                    TRUNC(FECHA) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy') 
                                                    AND TRUNC(FECHA) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy') 
                                                    " & cjDesde & "
                                                    " & cjHasta & "
                                                    " & sitio & ")  AND VTA.USR_ANULACION IS NULL")


        If dtConceptosArqueo.Rows.Count > 0 Then
            totalTicket = CInt(dtConceptosArqueo.Rows(0).Item(0))
            Return True
        Else
            ControlMensajes.mensaje("No se determinaron totales de ticket", titulo, "WAR")
            Return False
        End If
    End Function

    Function getConceptosArqueo() As Boolean
        Dim sitio As String = ""
        Dim cjDesde As String = ""
        Dim cjHasta As String = ""

        If idSitio > 0 Then
            sitio = " AND TC_CAJAS.ID_SITIO=" & idSitio & " "
        End If
        If cajaDesde > 0 Then
            cjDesde = "AND TC_CAJAS.NUMERO >= " & cajaDesde & " "
        End If
        If cajaHasta > 0 Then
            cjHasta = " AND TC_CAJAS.NUMERO <= " & cajaHasta & " "
        End If

        dtConceptosArqueo = contReportes.consultar("SELECT 
                                                    VR_TIPO_CONCEPTO,
                                                    CASE VR_TIPO_CONCEPTO 
                                                    WHEN 'CO' THEN 'GRUPO CONCEPTO:  CO CONCEPTO'
                                                    WHEN 'VA' THEN 'GRUPO CONCEPTO:  VA VALOR'
                                                    END AS CONCEPTO,
                                                    DESCRIPCION, SUM(CALCULADO) AS CALCULADO, SUM(ENTREGADO) AS ENTREGADO FROM (
                                                    SELECT TC_CONCEPTOS_ARQUEO.VR_TIPO_CONCEPTO, TC_CONCEPTOS_ARQUEO.DESCRIPCION, 
                                                    DE.IMPORTE_CALC AS CALCULADO, DE.IMPORTE_DECL AS ENTREGADO
                                                    FROM TC_DETALLE_ARQUEO DE
                                                    INNER JOIN TC_CONCEPTOS_ARQUEO ON TC_CONCEPTOS_ARQUEO.IDENTIFICADOR = DE.ID_CONCEPTO
                                                    WHERE DE.ID_ARQUEO IN (SELECT AR.IDENTIFICADOR
                                                    FROM TC_ARQUEO_CAJA AR
                                                    INNER JOIN TC_CAJAS ON TC_CAJAS.IDENTIFICADOR = AR.ID_CAJA
                                                    WHERE 
                                                    TRUNC(FECHA) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy') 
                                                    AND TRUNC(FECHA) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy') 
                                                    " & cjDesde & "
                                                    " & cjHasta & "
                                                    " & sitio & ")
                                                    ORDER BY DE.ID_ARQUEO ASC
                                                    )
                                                    WHERE CALCULADO > 0
                                                    GROUP BY VR_TIPO_CONCEPTO, DESCRIPCION")


        If dtConceptosArqueo.Rows.Count > 0 Then
            For i As Integer = 0 To dtConceptosArqueo.Rows.Count - 1
                If CStr(dtConceptosArqueo.Rows(i).Item(0)) = "VA" Then
                    totalEntrega += CInt(dtConceptosArqueo.Rows(i).Item(4))
                End If
            Next
            Return True
        Else
            ControlMensajes.mensaje("No se determinaron conceptos de arqueo", titulo, "WAR")
            Return False
        End If
    End Function

    Function getDeclaracionEfectivo() As Boolean
        Dim sitio As String = ""
        Dim cjDesde As String = ""
        Dim cjHasta As String = ""

        If idSitio > 0 Then
            sitio = " AND TC_CAJAS.ID_SITIO=" & idSitio & " "
        End If
        If cajaDesde > 0 Then
            cjDesde = "AND TC_CAJAS.NUMERO >= " & cajaDesde & " "
        End If
        If cajaHasta > 0 Then
            cjHasta = " AND TC_CAJAS.NUMERO <= " & cajaHasta & " "
        End If

        dtDeclaracionesEfect = contReportes.consultar("SELECT DESCRIPCION, VALOR, SUM(CANTIDAD) AS CANTIDAD, SUM(IMPORTE) AS IMPORTE FROM (
                                                    SELECT TC_DENOM_MONEDA.DESCRIPCION, TC_DENOM_MONEDA.VALOR, DE.CANTIDAD, DE. IMPORTE
                                                    FROM TC_DECLARACION_EFEC DE
                                                    INNER JOIN TC_DENOM_MONEDA ON TC_DENOM_MONEDA.IDENTIFICADOR = DE.ID_DENOMINACION
                                                    WHERE DE.ID_ARQUEO IN (SELECT AR.IDENTIFICADOR
                                                    FROM TC_ARQUEO_CAJA AR
                                                    INNER JOIN TC_CAJAS ON TC_CAJAS.IDENTIFICADOR = AR.ID_CAJA
                                                    WHERE 
                                                    TRUNC(FECHA) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy') 
                                                    AND TRUNC(FECHA) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy') 
                                                    " & cjDesde & "
                                                    " & cjHasta & "
                                                    " & sitio & ")
                                                    ORDER BY DE.ID_ARQUEO ASC
                                                    )
                                                    WHERE CANTIDAD > 0
                                                    GROUP BY DESCRIPCION, VALOR
                                                    ORDER BY VALOR DESC")


        If dtDeclaracionesEfect.Rows.Count > 0 Then
            For i As Integer = 0 To dtDeclaracionesEfect.Rows.Count - 1
                totalEntrega += CInt(dtDeclaracionesEfect.Rows(i).Item(3))
                totalEfectivo += CInt(dtDeclaracionesEfect.Rows(i).Item(3))
            Next
            Return True
        Else
            ControlMensajes.mensaje("Declaracion de efectivos no definidas", titulo, "WAR")
            Return False
        End If
    End Function

    Function getGastosDiarios() As Boolean
        Dim sitio As String = ""

        If idSitio > 0 Then
            sitio = " AND ID_SITIO=" & idSitio & " "
        End If

        dtGastosdiarios = contReportes.consultar("SELECT CONCEPTO, TOTAL FROM APP_GASTOS_DIARIOS 
                                                       WHERE TRUNC(FECHA) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy') 
                                                       AND TRUNC(FECHA) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy')" & sitio)

        If dtGastosdiarios.Rows.Count > 0 Then
            For i As Integer = 0 To dtGastosdiarios.Rows.Count - 1
                totalGastos += CInt(dtGastosdiarios.Rows(i).Item(1))
            Next
        End If

        Return True
    End Function

    Sub crearReporte()
        Dim report As New RptArqueoCajas
        Dim dt As New DataTable
        dt = dtConceptosArqueo


        report.DataSource = dt

        report.Parameters("cajaDesde").Value = txtCajaDesde.Text
        report.Parameters("cajaHasta").Value = txtCajaHasta.Text
        report.Parameters("fechaDesde").Value = txtFechaDesde.Text
        report.Parameters("fechaHasta").Value = txtFechaHasta.Text
        report.Parameters("sucursal").Value = txtsucursal.Text
        report.Parameters("usuarioFechaImp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy hh:mm:ss")

        report.Parameters("cajaDesde").Visible = False
        report.Parameters("cajaHasta").Visible = False
        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("usuarioFechaImp").Visible = False


        Dim subreport As New RptSubArqueoCajas
        report.XrSubreport1.ReportSource = subreport

        subreport.DataSource = dtDeclaracionesEfect
        subreport.Parameters("totalEntrega").Value = totalEntrega
        subreport.Parameters("totalTicket").Value = totalTicket
        subreport.Parameters("diferencia").Value = totalEntrega - totalTicket

        subreport.Parameters("totalEntrega").Visible = False
        subreport.Parameters("totalTicket").Visible = False
        subreport.Parameters("diferencia").Visible = False


        Dim subreportGastos As New RptSubGastosDiarios
        report.XrSubreport2.ReportSource = subreportGastos

        subreportGastos.DataSource = dtGastosdiarios
        subreportGastos.Parameters("totalEntrega").Value = totalEfectivo
        subreportGastos.Parameters("totalGastos").Value = totalGastos
        subreportGastos.Parameters("total").Value = totalEfectivo - totalGastos

        subreportGastos.Parameters("totalEntrega").Visible = False
        subreportGastos.Parameters("totalGastos").Visible = False
        subreportGastos.Parameters("total").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Sub limpiar()
        totalEntrega = 0
        totalTicket = 0
        diferencia = 0
        idSitio = 0
        cajaDesde = 0
        cajaHasta = 0
        txtsucursal.Text = ""
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        txtCajaDesde.Text = ""
        txtCajaHasta.Text = ""
    End Sub

    Sub aceptar()
        If txtFechaDesde.Text = "  /  /" Then
            ControlMensajes.mensaje("Debe ingresar fecha desde", titulo, "WAR")
            Return
        End If
        If txtFechaHasta.Text = "  /  /" Then
            ControlMensajes.mensaje("Debe ingresar fecha hasta", titulo, "WAR")
            Return
        End If

        totalEfectivo = 0
        totalEntrega = 0
        totalTicket = 0
        diferencia = 0
        totalGastos = 0

        If getTotalTickets() = False Or getConceptosArqueo() = False Or getDeclaracionEfectivo() = False Or getGastosDiarios() = False Then
            Return
        End If
        crearReporte()
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
                txtCajaDesde.Focus()
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

    Private Sub txtCajaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCajaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCajaHasta.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("CD")
        End If
    End Sub

    Private Sub btnCajaDesde_Click(sender As Object, e As EventArgs) Handles btnCajaDesde.Click
        vistas("CD")
    End Sub

    Private Sub txtCajaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCajaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("CH")
        End If
    End Sub

    Private Sub btnCajaHasta_Click(sender As Object, e As EventArgs) Handles btnCajaHasta.Click
        vistas("CH")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        aceptar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

End Class