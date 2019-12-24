Imports DevExpress.XtraReports.UI

Public Class FrmRptVentasPorMarca

    Dim reporte As New ContReportes
    Dim dtVentas As New DataTable
    Dim titulo As String = "Reporte de Ventas p/ Marca"

    Dim idUnidadOperat As Integer = 0
    Dim idFamilia As Integer = 0
    Dim idSucursal As Integer = 0

    Private Sub FrmRptVentasPorMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
    End Sub

    Sub vistas(vr As String)
        If vr = "UO" Then
            Dim frm As New FrmVistaCoUnidadesOperat
            frm.setFrmActivo("FrmRptVentasPorMarca")
            frm.ShowDialog()
        End If

        If vr = "SU" Then
            Dim frm As New FrmVistaFndSitios
            frm.setFrmActivo("FrmRptVentasPorMarca")
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
            frm.setFrmActivo("FrmRptVentasPorMarca")
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

        gridItems.DataSource = Nothing
        Dim desde As String = txtFechaDesde.Text
        Dim hasta As String = txtFechaHasta.Text

        Dim sql As String = "SELECT * FROM(SELECT ID_LINEA, FAMILIA, ID_MARCA, MARCA, CANTIDAD, COSTO_UNITARIO, PRECIO_VENTA, 
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
                                    SELECT PR_PRODUCTOS.ID_LINEA, PR_LINEAS_PROD.DESCRIPCION AS FAMILIA, 
                                    COALESCE(PR_MARCAS.IDENTIFICADOR, 0) AS ID_MARCA, COALESCE(PR_MARCAS.DESCRIPCION, 'NO DEFINIDO') AS MARCA, 
                                    SUM(IT.CANTIDAD)AS CANTIDAD,
                                    SUM(ROUND((IT.COSTO_UNITARIO * IT.CANTIDAD)  + (IT.COSTO_UNITARIO * IT.PORCENTAJE_IMP)/100 * IT.CANTIDAD,0)) AS COSTO_UNITARIO, 
                                    ROUND(SUM((IT.PRECIO_UNITARIO * IT.CANTIDAD)),0)AS PRECIO_VENTA 
                                    FROM VTA_ITEMS_COMPROB IT
                                    LEFT JOIN VTA_COMPROBANTES ON VTA_COMPROBANTES.IDENTIFICADOR = IT.ID_COMPROBANTE
                                    LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                    LEFT JOIN PR_LINEAS_PROD ON PR_LINEAS_PROD.IDENTIFICADOR = PR_PRODUCTOS.ID_LINEA
                                    LEFT JOIN PR_MARCAS ON PR_MARCAS.IDENTIFICADOR = PR_PRODUCTOS.ID_MARCA
                                    WHERE PR_PRODUCTOS.ID_LINEA=" & idFamilia & " AND VTA_COMPROBANTES.FEC_ANULACION IS NULL 
                                    AND VTA_COMPROBANTES.ID_UNIDAD=" & idUnidadOperat & " AND VTA_COMPROBANTES.ID_SITIO=" & idSucursal & "
                                    AND TRUNC(IT.FEC_CRE) >= TO_DATE('" & desde & "', 'DD/MM/YYYY')  
                                    AND TRUNC(IT.FEC_CRE) <= TO_DATE('" & hasta & "', 'DD/MM/YYYY')
                                    GROUP BY PR_PRODUCTOS.ID_LINEA, PR_LINEAS_PROD.DESCRIPCION, 
                                    PR_MARCAS.IDENTIFICADOR, PR_MARCAS.DESCRIPCION
                            )  ) ORDER BY PARTICIPACION DESC"


        dtVentas = reporte.consultar(sql)
        If dtVentas.Rows.Count > 0 Then
            gridVentas.DataSource = dtVentas
        Else
            ControlMensajes.mensaje("No se registraron ventas en el rango de fechas", titulo, "WAR")
        End If

    End Sub

    Sub getItems(idMarca As String)
        Dim dt As New DataTable
        Dim sql As String = ""
        Dim desde As String = txtFechaDesde.Text
        Dim hasta As String = txtFechaHasta.Text

        If idMarca = "0" Then
            idMarca = " AND PR_PRODUCTOS.ID_MARCA IS NULL "
        Else
            idMarca = " AND PR_PRODUCTOS.ID_MARCA=" & idMarca
        End If

        sql = "SELECT CODIGO_BARRAS, PRODUCTO, MARCA, CANTIDAD_VENDIDA, TOTAL_COSTO, TOTAL_VENTA, 
                    CASE 
                      WHEN TOTAL_COSTO > 0 THEN ROUND((((TOTAL_VENTA / TOTAL_COSTO) * 100)-100), 2) ELSE 0 
                    END AS RENTABILIDAD  
                FROM (
                    SELECT PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION AS PRODUCTO, COALESCE(PR_MARCAS.DESCRIPCION, 'NO DEFINIDO') AS MARCA, 
                    SUM(IT.CANTIDAD) AS CANTIDAD_VENDIDA, 
                    SUM(ROUND((IT.COSTO_UNITARIO * IT.CANTIDAD)  + (IT.COSTO_UNITARIO * IT.PORCENTAJE_IMP)/100 * IT.CANTIDAD,0)) AS TOTAL_COSTO,
                    ROUND(SUM((IT.PRECIO_UNITARIO * IT.CANTIDAD)),0)AS TOTAL_VENTA 
                    FROM VTA_ITEMS_COMPROB IT 
                    LEFT JOIN VTA_COMPROBANTES ON VTA_COMPROBANTES.IDENTIFICADOR = IT.ID_COMPROBANTE
                    LEFT JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                    LEFT JOIN PR_MARCAS ON PR_MARCAS.IDENTIFICADOR = PR_PRODUCTOS.ID_MARCA
                    LEFT JOIN PR_LINEAS_PROD ON PR_LINEAS_PROD.IDENTIFICADOR = PR_PRODUCTOS.ID_LINEA
                    WHERE PR_PRODUCTOS.ID_LINEA=" & idFamilia & idMarca & " AND VTA_COMPROBANTES.FEC_ANULACION IS NULL 
                    AND VTA_COMPROBANTES.ID_UNIDAD=" & idUnidadOperat & " AND VTA_COMPROBANTES.ID_SITIO=" & idSucursal & "
                    AND TRUNC(IT.FEC_CRE) >= TO_DATE('" & desde & "', 'DD/MM/YYYY')  
                    AND TRUNC(IT.FEC_CRE) <= TO_DATE('" & hasta & "', 'DD/MM/YYYY')
                    GROUP BY PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, PR_MARCAS.DESCRIPCION
                ) ORDER BY CANTIDAD_VENDIDA DESC, MARCA ASC"

        dt = reporte.consultar(sql)

        If dt.Rows.Count > 0 Then
            gridItems.DataSource = dt
            txtUnidadIt.Text = txtUnidadOperat.Text
            txtSucursalIt.Text = txtSucursal.Text
            txtFamiliaIt.Text = txtFamilia.Text
            txtMarcaIt.Text = CStr(dt.Rows(0).Item(2))
            txtFechaDesdeIt.Text = txtFechaDesde.Text
            txtFechaHastaIt.Text = txtFechaHasta.Text
        Else
            ControlMensajes.mensaje("No se registraron items de venta", titulo, "WAR")
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

        Dim report As New RptVentasPorMarca

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

    Private Sub gridVentas_DoubleClick(sender As Object, e As EventArgs) Handles gridVentas.DoubleClick
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim idProveedor As Integer = GridView1.GetRowCellValue(rowhandle, "ID_MARCA")

        getItems(idProveedor)
    End Sub

    Private Sub btnImprimirIt_Click(sender As Object, e As EventArgs) Handles btnImprimirIt.Click
        If GridView2.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim unidad As String = ""
        Dim sucursal As String = ""
        Dim familia As String = ""
        Dim marca As String = ""
        Dim desde As String = ""
        Dim hasta As String = ""

        unidad = txtUnidadIt.Text
        sucursal = txtSucursalIt.Text
        familia = txtFamiliaIt.Text
        marca = txtMarcaIt.Text
        desde = txtFechaDesdeIt.Text
        hasta = txtFechaHastaIt.Text

        Dim report As New RptItemsVentasPorMarca

        report.DataSource = gridItems.DataSource

        report.Parameters("unidad").Value = unidad
        report.Parameters("sucursal").Value = sucursal
        report.Parameters("familia").Value = familia
        report.Parameters("marca").Value = marca
        report.Parameters("fechaDesde").Value = desde
        report.Parameters("fechaHasta").Value = hasta

        report.Parameters("unidad").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("familia").Visible = False
        report.Parameters("marca").Visible = False
        report.Parameters("fechaDesde").Visible = False
        report.Parameters("fechaHasta").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub
End Class