Imports DevExpress.XtraReports.UI

Public Class FrmRptUnilever

    Dim reporte As New ContReportes
    Dim dtVentas As New DataTable
    Dim titulo As String = "Reporte de Ventas Unilever"

    Dim idUnidadOperat As Integer = 0
    Dim idFamilia As Integer = 0
    Dim idSucursal As Integer = 0

    Private Sub FrmRptUnilever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
    End Sub

    Sub vistas(vr As String)
        If vr = "UO" Then
            Dim frm As New FrmVistaCoUnidadesOperat
            frm.setFrmActivo("FrmRptUnilever")
            frm.ShowDialog()
        End If

        If vr = "SU" Then
            Dim frm As New FrmVistaFndSitios
            frm.setFrmActivo("FrmRptUnilever")
            frm.ShowDialog()
        End If

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

        If vr = "LP" Then
            Dim frm As New FrmVistaPrFamilias
            frm.setFrmActivo("FrmRptUnilever")
            frm.ShowDialog()
        End If
    End Sub

    Sub limpiar()
        txtUnidadOperat.Text = ""
        idUnidadOperat = 0
        txtFamilia.Text = ""
        idFamilia = 0
        txtFechaDesde.Text = ""
        cldFechaDesde.Visible = False
        txtFechaHasta.Text = ""
        cldFechaHasta.Visible = False
    End Sub

    Sub getUnidadOperat(id As String)
        Dim dt As New DataTable
        dt = reporte.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM CO_UNIDADES_OPERAT WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idUnidadOperat = CInt(dt.Rows(0).Item(0))
            txtUnidadOperat.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getSucursal(id As String)
        Dim dt As New DataTable
        dt = reporte.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idSucursal = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub getFamilia(id As String)
        Dim dt As New DataTable
        dt = reporte.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_LINEAS_PROD WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idFamilia = CInt(dt.Rows(0).Item(0))
            txtFamilia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub consultar()
        If txtUnidadOperat.Text = "" Then
            ControlMensajes.mensaje("El campo unidad operativa no puede estar vacio", titulo, "WAR")
            txtUnidadOperat.Focus()
            Return
        End If
        If txtSucursal.Text = "" Then
            ControlMensajes.mensaje("El campo sucursal no puede estar vacio", titulo, "WAR")
            txtSucursal.Focus()
            Return
        End If
        If txtFamilia.Text = "" Then
            ControlMensajes.mensaje("El campo familia no puede estar vacio", titulo, "WAR")
            txtFamilia.Focus()
            Return
        End If
        If txtFechaDesde.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha desde no puede estar vacio", titulo, "WAR")
            txtFechaDesde.Focus()
            Return
        End If
        If txtFechaHasta.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha hasta no puede estar vacio", titulo, "WAR")
            txtFechaHasta.Focus()
            Return
        End If

        Dim desde As String = txtFechaDesde.Text
        Dim hasta As String = txtFechaHasta.Text

        Dim sql As String = "SELECT * FROM(SELECT GRAMAJE, VALOR, FAMILIA, MARCA, PROVEEDOR, CODIGO_BARRAS, PRODUCTO, CANTIDAD, COSTO_UNITARIO, PRECIO_VENTA, 
                            ROUND(((PRECIO_VENTA / (SELECT SUM(VIT.PRECIO_UNITARIO * VIT.CANTIDAD)
                                            FROM VTA_ITEMS_COMPROB VIT
                                            LEFT JOIN VTA_COMPROBANTES ON VTA_COMPROBANTES.IDENTIFICADOR = VIT.ID_COMPROBANTE
                                            LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = VIT.ID_PRODUCTO
                                            WHERE PR_PRODUCTOS.ID_LINEA=" & idFamilia & " AND VTA_COMPROBANTES.FEC_ANULACION IS NULL 
                                            AND VTA_COMPROBANTES.ID_UNIDAD=" & idUnidadOperat & " AND VTA_COMPROBANTES.ID_SITIO=" & idSucursal & "
                                            AND TRUNC(VIT.FEC_CRE) >= TO_DATE('" & desde & "', 'DD/MM/YYYY')  
                                            AND TRUNC(VIT.FEC_CRE) <= TO_DATE('" & hasta & "', 'DD/MM/YYYY')
                                            )) *100),2) AS PARTICIPACION
                            FROM (
                                    SELECT 
                                    COALESCE(PR_PRESENTACION.VALOR, 0) AS VALOR,
                                    COALESCE(PR_PRESENTACION.DESCRIPCION, 'NO DEFINIDO') AS GRAMAJE,
                                    COALESCE(PR_LINEAS_PROD.DESCRIPCION, 'NO DEFINIDO') AS FAMILIA, 
                                    COALESCE(PR_MARCAS.DESCRIPCION, 'NO DEFINIDO') AS MARCA, 
                                    COALESCE(CP_PROVEEDORES.DENOMINACION, 'NO DEFINIDO') AS PROVEEDOR,
                                    COALESCE(PR_PRODUCTOS.CODIGO_BARRAS, 'NO DEFINIDO') AS CODIGO_BARRAS, 
                                    COALESCE(PR_PRODUCTOS.DESCRIPCION, 'NO DEFINIDO') AS PRODUCTO,
                                    SUM(IT.CANTIDAD)AS CANTIDAD,
                                    SUM(ROUND((IT.COSTO_UNITARIO * IT.CANTIDAD)  + (IT.COSTO_UNITARIO * IT.PORCENTAJE_IMP)/100 * IT.CANTIDAD,0)) AS COSTO_UNITARIO, 
                                    ROUND(SUM((IT.PRECIO_UNITARIO * IT.CANTIDAD)),0)AS PRECIO_VENTA 
                                    FROM VTA_ITEMS_COMPROB IT
                                    LEFT JOIN VTA_COMPROBANTES ON VTA_COMPROBANTES.IDENTIFICADOR = IT.ID_COMPROBANTE
                                    LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                    LEFT JOIN PR_LINEAS_PROD ON PR_LINEAS_PROD.IDENTIFICADOR = PR_PRODUCTOS.ID_LINEA
                                    LEFT JOIN PR_PRESENTACION ON PR_PRESENTACION.IDENTIFICADOR = PR_PRODUCTOS.ID_PRESENTACION
                                    LEFT JOIN PR_MARCAS ON PR_MARCAS.IDENTIFICADOR = PR_PRODUCTOS.ID_MARCA
                                    LEFT JOIN CP_PROVEEDORES ON CP_PROVEEDORES.IDENTIFICADOR = IT.ID_PROVEEDOR
                                    WHERE PR_PRODUCTOS.ID_LINEA=" & idFamilia & " AND VTA_COMPROBANTES.FEC_ANULACION IS NULL 
                                    AND VTA_COMPROBANTES.ID_UNIDAD=" & idUnidadOperat & " AND VTA_COMPROBANTES.ID_SITIO=" & idSucursal & "
                                    AND TRUNC(IT.FEC_CRE) >= TO_DATE('" & desde & "', 'DD/MM/YYYY')  
                                    AND TRUNC(IT.FEC_CRE) <= TO_DATE('" & hasta & "', 'DD/MM/YYYY')
                                    GROUP BY 
                                    PR_PRESENTACION.VALOR,
                                    COALESCE(PR_PRESENTACION.DESCRIPCION, 'NO DEFINIDO'), 
                                    COALESCE(PR_LINEAS_PROD.DESCRIPCION, 'NO DEFINIDO'),
                                    COALESCE(PR_MARCAS.DESCRIPCION, 'NO DEFINIDO'),
                                    COALESCE(CP_PROVEEDORES.DENOMINACION, 'NO DEFINIDO'),
                                    COALESCE(PR_PRODUCTOS.CODIGO_BARRAS, 'NO DEFINIDO'), 
                                    COALESCE(PR_PRODUCTOS.DESCRIPCION, 'NO DEFINIDO')
                            )  ) ORDER BY VALOR ASC, CANTIDAD DESC"


        dtVentas = reporte.consultar(sql)
        If dtVentas.Rows.Count > 0 Then
            gridVentas.DataSource = dtVentas
        Else
            ControlMensajes.mensaje("No se registraron ventas en el rango de fechas", titulo, "WAR")
        End If

    End Sub

    Private Sub txtUnidadOperat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnidadOperat.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUnidadOperat.Text IsNot "" Then
                txtSucursal.Focus()
                txtSucursal.Text = ""
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("UO")
        End If
    End Sub

    Private Sub btnBuscarUnidadOperat_Click(sender As Object, e As EventArgs) Handles btnBuscarUnidadOperat.Click
        vistas("UO")
    End Sub

    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSucursal.Text IsNot "" Then
                txtFamilia.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("SU")
        End If
    End Sub

    Private Sub btnBuscarSucursal_Click(sender As Object, e As EventArgs) Handles btnBuscarSucursal.Click
        vistas("SU")
    End Sub

    Private Sub txtFamilia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFamilia.Text IsNot "" Then
                txtFechaDesde.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("LP")
        End If
    End Sub

    Private Sub btnBuscarFamilia_Click(sender As Object, e As EventArgs) Handles btnBuscarFamilia.Click
        vistas("LP")
    End Sub

    Private Sub txtFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFechaDesde.Text = "  /  /" Then
                Return
            End If
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
            If txtFechaHasta.Text = "  /  /" Then
                Return
            End If
            btnConsultar.Focus()
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

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim unidad As String = ""
        Dim sucursal As String = ""
        Dim familia As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""

        unidad = txtUnidadOperat.Text
        sucursal = txtSucursal.Text
        familia = txtFamilia.Text
        desde = txtFechaDesde.Text
        hasta = txtFechaHasta.Text

        Dim report As New RptUnilever

        report.DataSource = gridVentas.DataSource

        report.Parameters("unidad").Value = unidad
        report.Parameters("sucursal").Value = sucursal
        report.Parameters("familia").Value = familia
        report.Parameters("fechaDesde").Value = desde
        report.Parameters("fechaHasta").Value = hasta

        report.Parameters("unidad").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("familia").Visible = False
        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()

    End Sub

End Class