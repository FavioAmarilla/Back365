Imports DevExpress.XtraReports.UI

Public Class FrmRptComprasProveedorMeses

    Dim consultas As New ContConsultasVarias
    Dim titulo As String = "Compras"
    Dim idProveedor As Integer = 0
    Dim idEmpresa As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idSucursal As Integer = 0


    Private Sub FrmRptComprasProveedorMeses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
    End Sub

    Sub limpiar()
        txtProveedor.Text = ""
        idProveedor = 0
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
        GridView1.Columns.Clear()
        GridControl1.DataSource = Nothing
    End Sub

    Sub getEmpresa(id As String)
        Dim dt As New DataTable
        dt = consultas.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PARM_EMPRESAS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idEmpresa = CInt(dt.Rows(0).Item(0))
            txtEmpresa.Text = CStr(dt.Rows(0).Item(1))
            txtEmpresa.Focus()
        Else
            ControlMensajes.mensaje("Empresa no definido", titulo, "WAR")
            txtEmpresa.Focus()
        End If
    End Sub

    Sub getUnidadOperat(id As String)
        Dim dt As New DataTable
        dt = consultas.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM CO_UNIDADES_OPERAT WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idUnidad = CInt(dt.Rows(0).Item(0))
            txtUnidad.Text = CStr(dt.Rows(0).Item(1))
            txtUnidad.Focus()
        Else
            ControlMensajes.mensaje("Unidad no definido", titulo, "WAR")
            txtUnidad.Focus()
        End If
    End Sub

    Sub getSitio(id As String)
        Dim dt As New DataTable
        dt = consultas.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idSucursal = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
            txtSucursal.Focus()
        Else
            ControlMensajes.mensaje("Proveedor no definido", titulo, "WAR")
            txtSucursal.Focus()
        End If
    End Sub

    Sub getProveedor(id As String)
        Dim dt As New DataTable
        dt = consultas.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idProveedor = CInt(dt.Rows(0).Item(0))
            txtProveedor.Text = CStr(dt.Rows(0).Item(1))
            txtProveedor.Focus()
        Else
            ControlMensajes.mensaje("Proveedor no definido", titulo, "WAR")
            txtProveedor.Focus()
        End If
    End Sub

    Sub listaEmpresas()
        Dim frm As New FrmVistaFndEmpresas
        frm.setFrmActivo("FrmRptComprasProveedorMeses")
        frm.setFrmRptComprasProveedorMeses(Me)
        frm.ShowDialog()
    End Sub

    Sub listarUnidades()
        Dim frm As New FrmVistaCoUnidadesOperat
        frm.setFrmActivo("FrmRptComprasProveedorMeses")
        frm.setFrmRptComprasProveedorMeses(Me)
        frm.ShowDialog()
    End Sub

    Sub listarSucursales()
        Dim frm As New FrmVistaFndSitios
        frm.setFrmActivo("FrmRptComprasProveedorMeses")
        frm.setFrmRptComprasProveedorMeses(Me)
        frm.ShowDialog()
    End Sub

    Sub listarProveedores()
        Dim frm As New FrmVistaCpProveedores
        frm.setFrmActivo("FrmRptComprasProveedorMeses")
        frm.setFrmRptComprasProveedorMeses(Me)
        frm.ShowDialog()
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

    Sub consultar()
        If idProveedor <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar proveedor", titulo, "WAR")
            txtProveedor.Focus()
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

        Dim desde As String = txtFechaDesde.Text
        Dim hasta As String = txtFechaHasta.Text

        Dim sql As String = "SELECT (X.MES || '  ' || EXTRACT(YEAR FROM X.FECHA)) AS MES,  SUM(X.FACTURA) AS FACTURA, SUM(X.NOTA_CREDITO) AS NOTA_CREDITO, SUM((X.FACTURA) - (X.NOTA_CREDITO)) AS MONTO_NETO
                                FROM (
                                        SELECT 
                                        CP.FECHA,
                                        EXTRACT(MONTH FROM CP.FECHA) AS NUMERO,
                                        CASE EXTRACT(MONTH FROM CP.FECHA) 
                                        WHEN 1 THEN 'ENERO'
                                        WHEN 2 THEN 'FEBRERO'
                                        WHEN 3 THEN 'MARZO'
                                        WHEN 4 THEN 'ABRIL'
                                        WHEN 5 THEN 'MAYO'
                                        WHEN 6 THEN 'JUNIO'
                                        WHEN 7 THEN 'JULIO'
                                        WHEN 8 THEN 'AGOSTO'
                                        WHEN 9 THEN 'SETIEMBRE'
                                        WHEN 10 THEN 'OCTUBRE'
                                        WHEN 11 THEN 'NOVIEMBRE'
                                        WHEN 12 THEN 'DICIEMBRE'
                                        END AS MES, 
                                        CP.MONTO_TOTAL,
                                        COALESCE((
                                        SELECT SUM(MONTO_TOTAL) FROM CP_COMPROBANTES 
                                        LEFT JOIN CP_TIPOS_COMPROB ON CP_TIPOS_COMPROB.IDENTIFICADOR = CP_COMPROBANTES.ID_TIPO_COMPROB
                                        WHERE CP_TIPOS_COMPROB.VR_CLASE_COMP = 'FA' AND CP_COMPROBANTES.IDENTIFICADOR= CP.IDENTIFICADOR
                                        ), 0) AS FACTURA,
                                        COALESCE((
                                        SELECT SUM(MONTO_TOTAL) FROM CP_COMPROBANTES 
                                        LEFT JOIN CP_TIPOS_COMPROB ON CP_TIPOS_COMPROB.IDENTIFICADOR = CP_COMPROBANTES.ID_TIPO_COMPROB
                                        WHERE CP_TIPOS_COMPROB.VR_CLASE_COMP = 'NC' AND CP_COMPROBANTES.IDENTIFICADOR= CP.IDENTIFICADOR
                                        ), 0) AS NOTA_CREDITO
                                        FROM CP_COMPROBANTES CP 
                                        WHERE CP.ID_PROVEEDOR=" & CStr(idProveedor) & " 
                                        AND CP.ID_EMPRESA = " & idEmpresa & "  
                                        AND CP.ID_UNIDAD = " & idUnidad & "  
                                        AND CP.ID_SITIO = " & idSucursal & "  
                                        AND TRUNC(CP.FECHA) >= TO_DATE('" & desde & "', 'dd/MM/yyyy') 
                                        AND TRUNC(CP.FECHA) <= TO_DATE('" & hasta & "', 'dd/MM/yyyy')
                                    ) X
                                GROUP BY (X.MES || '  ' || EXTRACT(YEAR FROM X.FECHA)), X.NUMERO
                                ORDER BY X.NUMERO ASC"

        Dim dt As New DataTable
        dt = consultas.consultar(sql)

        If dt.Rows.Count > 0 Then
            GridControl1.DataSource = dt
        Else
            ControlMensajes.mensaje("No se registraron compras", titulo, "INF") 
            GridControl1.DataSource = Nothing
            txtProveedor.Focus()
        End If
    End Sub

    Sub imprimir()
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim empresa As String = txtEmpresa.Text
        Dim unidad As String = txtUnidad.Text
        Dim sucursal As String = txtSucursal.Text
        Dim proveedor As String = txtProveedor.Text
        Dim desde As String = txtFechaDesde.Text
        Dim hasta As String = txtFechaHasta.Text
        Dim report As New RptComprasProveedorMeses

        report.DataSource = GridControl1.DataSource

        report.Parameters("empresa").Value = empresa
        report.Parameters("unidad").Value = unidad
        report.Parameters("sucursal").Value = sucursal
        report.Parameters("proveedor").Value = proveedor
        report.Parameters("desde").Value = desde
        report.Parameters("hasta").Value = hasta

        report.Parameters("empresa").Visible = False
        report.Parameters("unidad").Visible = False
        report.Parameters("sucursal").Visible = False
        report.Parameters("proveedor").Visible = False
        report.Parameters("desde").Visible = False
        report.Parameters("hasta").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarProveedores()
        End If
        If e.KeyCode = Keys.Enter And idProveedor > 0 Then
            txtFechaDesde.Focus()
        End If
    End Sub

    Private Sub btnFamilias_Click(sender As Object, e As EventArgs) Handles btnFamilias.Click
        listarProveedores()
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
                btnConsultar.Focus()
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

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        imprimir()
    End Sub

    Private Sub txtEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpresa.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listaEmpresas()
        End If
        If e.KeyCode = Keys.Enter And idEmpresa > 0 Then
            txtUnidad.Focus()
        End If
    End Sub

    Private Sub txtUnidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnidad.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarUnidades()
        End If
        If e.KeyCode = Keys.Enter And idUnidad > 0 Then
            txtSucursal.Focus()
        End If
    End Sub

    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarSucursales()
        End If
        If e.KeyCode = Keys.Enter And idSucursal > 0 Then
            txtProveedor.Focus()
        End If
    End Sub
End Class