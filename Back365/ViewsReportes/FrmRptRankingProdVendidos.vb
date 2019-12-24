Imports DevExpress.XtraReports.UI

Public Class FrmRptRankingProdVendidos

    Dim contReportes As New ContReportes
    Dim dtProductos As New DataTable
    Dim titulo As String = "Reporte"
    Dim idSitio As Integer = 0
    Dim idLinea As Integer = 0
    Dim codigoLinea As String = ""

    Private Sub FrmRptRankingProdVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            frm.setFrmActivo("FrmRptRankingProdVendidos")
            frm.setFrmRptRankingProdVendidos(Me)
            frm.ShowDialog()
        End If

        If verificador = "LI" Then
            Dim frm As New FrmVistaPrLineasProd
            frm.setFrmActivo("FrmRptRankingProdVendidos")
            frm.setFrmRptRankingProdVendidos(Me)
            frm.ShowDialog()
        End If

    End Sub

    Sub getSitio(id As Integer)
        Dim dt As New DataTable
        dt = contReportes.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))
        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtsucursal.Text = CStr(dt.Rows(0).Item(1))
        Else
            ControlMensajes.mensaje("Sucursal no definida", titulo, "WAR")
        End If
    End Sub

    Sub getLineaProd(id As String)
        Dim dt As New DataTable
        dt = contReportes.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_LINEAS_PROD WHERE ABREVIATURA='" & id & "'")
        If dt.Rows.Count > 0 Then
            codigoLinea = id
            idLinea = CInt(dt.Rows(0).Item(0))
            txtLinea.Text = CStr(dt.Rows(0).Item(1))
        Else
            ControlMensajes.mensaje("Linea no definida", titulo, "WAR")
        End If
    End Sub

    Sub limpiar()
        idSitio = 0
        idLinea = 0
        codigoLinea = ""
        txtsucursal.Text = ""
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
    End Sub

    Sub consultar()
        Dim sql As String = ""
        Dim sitio As String = ""
        Dim linea As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""

        If idSitio > 0 Then
            sitio = " AND VTA.ID_SITIO=" & CStr(idSitio) & " "
        End If
        If idLinea > 0 Then
            linea = " AND PR_LINEAS_PROD.ABREVIATURA LIKE '" & codigoLinea & "' "
        End If

        sql = "SELECT PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, PR_PRODUCTOS.PRECIO_VENTA, 
                SUM(VTA_ITEMS_COMPROB.CANTIDAD) AS CANTIDAD,  SUM(VTA_ITEMS_COMPROB.IMPORTE_ITEM) AS IMPORTE
                FROM VTA_COMPROBANTES VTA
                INNER JOIN VTA_ITEMS_COMPROB ON VTA_ITEMS_COMPROB.ID_COMPROBANTE = VTA.IDENTIFICADOR
                INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = VTA_ITEMS_COMPROB.ID_PRODUCTO
                INNER JOIN PR_LINEAS_PROD ON PR_PRODUCTOS.ID_LINEA = PR_LINEAS_PROD.IDENTIFICADOR
                WHERE TRUNC(VTA_ITEMS_COMPROB.FEC_CRE) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy') 
                AND TRUNC(VTA_ITEMS_COMPROB.FEC_CRE) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy')
                " & sitio & " AND VTA.USR_ANULACION IS NULL AND VTA_ITEMS_COMPROB.CANTIDAD > 0 
                " & linea & "
                GROUP BY PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, PR_PRODUCTOS.PRECIO_VENTA
                ORDER BY SUM(VTA_ITEMS_COMPROB.CANTIDAD) DESC"


        dtProductos = contReportes.consultar(sql)

        If dtProductos.Rows.Count > 0 Then
            gridProductos.DataSource = dtProductos
        Else
            ControlMensajes.mensaje("Productos no definidos", titulo, "WAR")
        End If
    End Sub


    Sub crearReporte()
        Dim report As New RptRankingProdVendidos
        Dim dt As New DataTable
        dt = dtProductos

        report.DataSource = dt

        report.Parameters("fechaDesde").Value = txtFechaDesde.Text
        report.Parameters("fechaHasta").Value = txtFechaHasta.Text
        report.Parameters("sucursal").Value = txtsucursal.Text
        report.Parameters("linea").Value = txtLinea.Text
        report.Parameters("usuarioFechaImp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy hh:mm:ss")

        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("linea").Visible = False
        report.Parameters("usuarioFechaImp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
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
                txtLinea.Focus()
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

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        crearReporte()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtProductos.Rows.Count > 0 Then
            If txtBuscar.Text IsNot "" Then
                Dim dv As DataView
                Dim filter As String = " DESCRIPCION LIKE '%" & txtBuscar.Text & "%' "
                filter += " OR CODIGO_BARRAS LIKE '%" & txtBuscar.Text & "%' "
                dv = dtProductos.DefaultView
                dv.RowFilter = filter
                gridProductos.DataSource = dv
            Else
                gridProductos.DataSource = dtProductos
            End If
        End If
    End Sub

    Private Sub btnLineas_Click(sender As Object, e As EventArgs) Handles btnLineas.Click
        vistas("LI")
    End Sub

    Private Sub txtLinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLinea.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConsultar.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("LI")
        End If
    End Sub

End Class