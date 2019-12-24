Imports DevExpress.XtraReports.UI

Public Class FrmPreciosVentaAplicados

    Dim contReportes As New ContReportes
    Dim dtListado As New DataTable
    Dim titulo As String = ""

    Dim idSitio As Integer = 0

    Private Sub FrmPreciosVentaAplicados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldDesde.Visible = False
        cldHasta.Visible = False
    End Sub

    Sub limpiar()
        idSitio = 0
        txtsucursal.Text = ""
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        cldDesde.Visible = False
        cldHasta.Visible = False
        dtListado = Nothing
        gridListado.DataSource = dtListado
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
            frm.setFrmActivo("FrmPreciosVentaAplicados")
            frm.setFrmPreciosVentaAplicados(Me)
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

    Sub consultar()
        dtListado = contReportes.consultar("SELECT TO_CHAR(AU.FECHA,'dd/MM/yyyy') AS FECHA, PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, 
                                                AU.PRECIO_ANTERIOR, AU.PRECIO_NUEVO, 'S' AS IMPRIMIR
                                                FROM PR_AUD_CAMBIOS_PREC AU
                                                INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = AU.ID_PRODUCTO
                                                WHERE AU.IDENTIFICADOR IN (
                                                    SELECT IDENTIFICADOR FROM (
                                                        SELECT MAX(AU.IDENTIFICADOR) AS IDENTIFICADOR, AU.ID_PRODUCTO
                                                        FROM PR_AUD_CAMBIOS_PREC AU
                                                        INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = AU.ID_PRODUCTO
                                                        WHERE AU.ID_SITIO=" & CStr(idSitio) & "
                                                        AND TRUNC(AU.FECHA_APLICACION) >= TO_DATE('" & txtFechaDesde.Text & "','dd/MM/yyyy')
                                                        AND TRUNC(AU.FECHA_APLICACION) <= TO_DATE('" & txtFechaHasta.Text & "','dd/MM/yyyy')
                                                        GROUP BY AU.ID_PRODUCTO
                                                    )
                                                )
                                                AND AU.PRECIO_ANTERIOR <> AU.PRECIO_NUEVO
                                                ORDER BY AU.IDENTIFICADOR DESC")

        If dtListado.Rows.Count > 0 Then
            gridListado.DataSource = dtListado
        Else
            ControlMensajes.mensaje("No se encontraron cambios de precio de venta", titulo, "WAR")
        End If
    End Sub

    Function getItemsReporte()

        Dim dt As New DataTable

        dt.Columns.Add("FECHA")
        dt.Columns.Add("CODIGO_BARRAS")
        dt.Columns.Add("DESCRIPCION")
        dt.Columns.Add("PRECIO_ANTERIOR")
        dt.Columns.Add("PRECIO_NUEVO")

        For i As Integer = 0 To GridView1.RowCount - 1
            If CStr(GridView1.GetRowCellValue(i, "IMPRIMIR")) = "S" Then
                Dim newRow As DataRow = dt.NewRow()
                newRow("FECHA") = CStr(GridView1.GetRowCellValue(i, "FECHA"))
                newRow("CODIGO_BARRAS") = CStr(GridView1.GetRowCellValue(i, "CODIGO_BARRAS"))
                newRow("DESCRIPCION") = CStr(GridView1.GetRowCellValue(i, "DESCRIPCION"))
                newRow("PRECIO_ANTERIOR") = CStr(GridView1.GetRowCellValue(i, "PRECIO_ANTERIOR"))
                newRow("PRECIO_NUEVO") = CStr(GridView1.GetRowCellValue(i, "PRECIO_NUEVO"))

                dt.Rows.Add(newRow)
            End If
        Next

        Return dt
    End Function

    Sub crearReporte()
        Dim report As New RptPreciosVentaAplicados

        report.DataSource = getItemsReporte()

        report.Parameters("fechaDesde").Value = txtFechaDesde.Text
        report.Parameters("fechaHasta").Value = txtFechaHasta.Text
        report.Parameters("sucursal").Value = txtsucursal.Text
        report.Parameters("usuarioFechaImp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy hh:mm:ss")

        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False
        report.Parameters("sucursal").Visible = False
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtListado.Rows.Count > 0 Then
            Dim dv As DataView
            Dim filter As String = ""
            filter = "FECHA LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR CODIGO_BARRAS LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR DESCRIPCION LIKE '%" & txtBuscar.Text & "%' "
            dv = dtListado.DefaultView
            dv.RowFilter = filter
            gridListado.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridListado.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        consultar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        txtsucursal.Focus()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        crearReporte()
    End Sub
End Class