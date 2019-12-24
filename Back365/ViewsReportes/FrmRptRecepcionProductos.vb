Imports DevExpress.XtraReports.UI

Public Class FrmRptRecepcionProductos

    Dim titulo As String = "Recepcion de productos"
    Dim reporte As New ContReportes
    Dim dtItems As New DataTable
    Dim dv As DataView
    Dim idProveedor As Integer = 0

    Private Sub FrmRptRecepcionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
        txtCodigoBarras.Focus()
    End Sub

    Sub vistas(vr As String)
        If vr = "FD" Then
            If cldFechaDesde.Visible = True Then
                cldFechaDesde.Visible = False
                txtFechaDesde.Focus()
            Else
                cldFechaDesde.Visible = True
                cldFechaDesde.Focus()
            End If
        End If

        If vr = "FH" Then
            If cldFechaHasta.Visible = True Then
                cldFechaHasta.Visible = False
                txtFechaHasta.Focus()
            Else
                cldFechaHasta.Visible = True
                cldFechaHasta.Focus()
            End If
        End If

        If vr = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmRptRecepcionProductos")
            frm.ShowDialog()
        End If

        If vr = "PV" Then
            Dim frm As New FrmVistaCpProveedores
            frm.setFrmActivo("FrmRptRecepcionProductos")
            frm.ShowDialog()
        End If

    End Sub

    Sub limpiar()
        txtCodigoBarras.Text = ""
        txtProducto.Text = ""
        txtFechaDesde.Text = ""
        cldFechaDesde.Visible = False
        txtFechaHasta.Text = ""
        cldFechaHasta.Visible = False
        gridItems.DataSource = Nothing
        txtCodigoBarras.Focus()
    End Sub

    Sub getProducto(id As String)
        If id.Replace(" ", "") = "" Then
            btnConsultar.Focus()
            Return
        End If

        Dim dt As New DataTable
        dt = reporte.consultar("SELECT CODIGO_BARRAS, DESCRIPCION FROM PR_PRODUCTOS WHERE CODIGO_BARRAS='" & id & "' OR IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            txtCodigoBarras.Text = CStr(dt.Rows(0).Item(0))
            txtProducto.Text = CStr(dt.Rows(0).Item(1))
            txtProveedor.Focus()
        Else
            txtCodigoBarras.Focus()
        End If

    End Sub

    Sub getProveedor(id As String)
        Dim dt As New DataTable
        dt = reporte.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            txtProveedor.Text = CStr(dt.Rows(0).Item(1))
            idProveedor = CInt(dt.Rows(0).Item(0))
            btnConsultar.Focus()
        Else
            txtProveedor.Focus()
        End If
    End Sub

    Sub consultar()
        Dim sql As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""
        Dim producto As String = ""
        Dim proveedor As String = ""

        If txtProducto.Text IsNot "" Then
            producto = " AND IT.CODIGO_BARRA='" & txtCodigoBarras.Text & "' "
        End If

        If txtProveedor.Text IsNot "" Then
            proveedor = " AND CP_COMPROBANTES.ID_PROVEEDOR=" & idProveedor.ToString
        End If

        If txtFechaDesde.Text = "  /  /" Then
        Else
            desde = " AND TRUNC(IT.FEC_CRE) >= TO_DATE('" & txtFechaDesde.Text & "','dd/mm/yyyy') "
        End If

        If txtFechaHasta.Text = "  /  /" Then
        Else
            hasta = " AND TRUNC(IT.FEC_CRE) <= TO_DATE('" & txtFechaHasta.Text & "','dd/mm/yyyy') "
        End If

        sql = "SELECT FECHA, NUMERO AS NRO_FACTURA, NRO_RECEPCION, PROVEEDOR, CODIGO_BARRA, PRODUCTO, CANTIDAD, PRECIO_UNITARIO,
                    CASE 
                     WHEN COALESCE(COSTO, 0) <= 0 THEN COALESCE(PRECIO_UNITARIO, 0) ELSE COALESCE(COSTO, 0)
                    END AS COSTO,
                    PORC_DESCUENTO, 
                    CASE 
                     WHEN COALESCE(COSTO, 0) > 0 THEN COALESCE((COSTO * CANTIDAD), 0) ELSE COALESCE((PRECIO_UNITARIO * CANTIDAD), 0) 
                    END AS TOTAL 
                    FROM (
                         SELECT CP_COMPROBANTES.FECHA, CP_COMPROBANTES.NUMERO, IT.ID_RECEPCION AS NRO_RECEPCION,
                        COALESCE(CP_PROVEEDORES.DENOMINACION, 'NO DEFINIDO') AS PROVEEDOR,
                        IT.CODIGO_BARRA,
                        COALESCE(PR_PRODUCTOS.DESCRIPCION, 'NO DEFINIDO') AS PRODUCTO,
                        IT.CANTIDAD,
                        ROUND(IT.PRECIO_UNITARIO) AS PRECIO_UNITARIO,
                        (ROUND(IT.PRECIO_UNITARIO) - ((ROUND(IT.PRECIO_UNITARIO) * IT.PORC_DESCUENTO) / 100)) AS COSTO,
                        COALESCE(IT.PORC_DESCUENTO, 0) AS PORC_DESCUENTO
                        FROM STK_ITEMS_RECEP IT
                        LEFT JOIN CP_COMPROBANTES ON CP_COMPROBANTES.IDENTIFICADOR = IT.ID_COMPROBANTE
                        LEFT JOIN CP_PROVEEDORES ON CP_PROVEEDORES.IDENTIFICADOR = CP_COMPROBANTES.ID_PROVEEDOR
                        LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                        LEFT JOIN STK_RECEPCIONES ON STK_RECEPCIONES.IDENTIFICADOR = IT.ID_RECEPCION
                        WHERE STK_RECEPCIONES.VR_SITUACION='CO'" & desde & hasta & producto & proveedor & "
                )"

        dtItems = reporte.consultar(sql)

        If dtItems.Rows.Count > 0 Then
            gridItems.DataSource = dtItems
        Else
            ControlMensajes.mensaje("No registraron recepciones para el rango de fechas", titulo, "WAR")
            txtFechaDesde.Focus()
        End If
    End Sub

    Private Sub txtCodigoBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigoBarras.Text IsNot "" Then
                getProducto(txtCodigoBarras.Text)
            Else
                txtProveedor.Focus()
            End If

        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("PR")
        End If
    End Sub

    Private Sub txtFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaHasta.Focus()
        End If
        If e.KeyCode = Keys.Space Then
            vistas("FD")
        End If
    End Sub

    Private Sub btnFechaDesde_Click(sender As Object, e As EventArgs) Handles btnFechaDesde.Click
        vistas("FD")
    End Sub

    Private Sub txtFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCodigoBarras.Focus()
        End If
        If e.KeyCode = Keys.Space Then
            vistas("FH")
        End If
    End Sub

    Private Sub btnFechaHasta_Click(sender As Object, e As EventArgs) Handles btnFechaHasta.Click
        vistas("FH")
    End Sub

    Private Sub cldFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaDesde.Text = cldFechaDesde.DateTime.ToString
            vistas("FD")
        End If
        If e.KeyCode = Keys.Escape Then
            vistas("FD")
        End If
    End Sub

    Private Sub cldFechaHasta_DoubleClick(sender As Object, e As EventArgs) Handles cldFechaHasta.DoubleClick
        txtFechaHasta.Text = cldFechaHasta.DateTime.ToString
        vistas("FH")
    End Sub

    Private Sub cldFechaDesde_DoubleClick(sender As Object, e As EventArgs) Handles cldFechaDesde.DoubleClick
        txtFechaDesde.Text = cldFechaDesde.DateTime.ToString
        vistas("FD")
    End Sub

    Private Sub cldFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaHasta.Text = cldFechaHasta.DateTime.ToString
            vistas("FH")
        End If
        If e.KeyCode = Keys.Escape Then
            vistas("FH")
        End If
    End Sub

    Private Sub chkDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescripcion.CheckedChanged
        If chkDescripcion.Checked Then
            chkCodigo.Checked = False
        End If
    End Sub

    Private Sub chkCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigo.CheckedChanged
        If chkCodigo.Checked Then
            chkDescripcion.Checked = False
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtItems.Rows.Count > 0 Then
            dv = dtItems.DefaultView
            If chkCodigo.Checked = False And chkDescripcion.Checked = False Then
                ControlMensajes.mensaje("Debe seleccionar tipo de busqueda", titulo, "WAR")
                txtBuscar.Text = ""
                chkDescripcion.Focus()
            End If
            If chkCodigo.Checked Then
                dv.RowFilter = "CODIGO_BARRA LIKE '" & txtBuscar.Text & "%'"
                gridItems.DataSource = dv

            End If
            If chkDescripcion.Checked Then
                dv.RowFilter = "PRODUCTO LIKE '%" & txtBuscar.Text & "%'"
                gridItems.DataSource = dv
            End If
        End If
    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtProveedor.Text IsNot "" Then
                btnConsultar.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PV")
        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        vistas("PV")
    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim producto As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""

        producto = txtCodigoBarras.Text & " - " & txtProducto.Text
        desde = txtFechaDesde.Text
        hasta = txtFechaHasta.Text

        Dim report As New RptRecepcionProductos
        report.DataSource = dtItems

        report.Parameters("producto").Value = producto
        report.Parameters("fechaDesde").Value = desde
        report.Parameters("fechaHasta").Value = hasta

        report.Parameters("producto").Visible = False
        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

End Class