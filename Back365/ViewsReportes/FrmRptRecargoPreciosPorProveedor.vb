Imports DevExpress.XtraReports.UI

Public Class FrmRptRecargoPreciosPorProveedor

    Dim reporte As New ContReportes
    Dim dtItems As New DataTable
    Dim titulo As String = "Recargo de precio p/Proveedor"
    Dim dv As DataView

    Dim idProveedor As Integer = 0
    Dim idFamilia As Integer = 0

    Private Sub FrmRptRecargoPreciosPorProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkDescripcion.Checked = True
    End Sub

    Sub vistas(vr As String)
        If vr = "PR" Then
            Dim frm As New FrmVistaCpProveedores
            frm.setFrmActivo("FrmRptRecargoPreciosPorProveedor")
            frm.ShowDialog()
        End If
        If vr = "FA" Then
            Dim frm As New FrmVistaPrFamilias
            frm.setFrmActivo("FrmRptRecargoPreciosPorProveedor")
            frm.ShowDialog()
        End If
    End Sub

    Sub limpiar()
        idProveedor = 0
        txtProveedor.Text = ""
        idFamilia = 0
        txtFamilia.Text = ""
        chkCodigo.Checked = False
        chkDescripcion.Checked = False
        txtBuscar.Text = ""
        gridItems.DataSource = Nothing
    End Sub

    Sub getProveedor(id As String)
        Dim dt As New DataTable
        dt = reporte.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idProveedor = CInt(dt.Rows(0).Item(0))
            txtProveedor.Text = CStr(dt.Rows(0).Item(1))
        End If
        txtFamilia.Focus()
    End Sub

    Sub getFamilia(id As String)
        Dim dt As New DataTable
        dt = reporte.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_LINEAS_PROD WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idFamilia = CInt(dt.Rows(0).Item(0))
            txtFamilia.Text = CStr(dt.Rows(0).Item(1))
        End If
        txtFamilia.Focus()
    End Sub


    Sub consultar()
        Dim familia As String = ""

        If txtProveedor.Text = "" Then
            ControlMensajes.mensaje("El campo proveedor no puede estar vacio", titulo, "WAR")
            txtProveedor.Focus()
            Return
        End If

        If idFamilia > 0 Then
            familia = " AND PR.ID_LINEA=" & idFamilia
        End If

        Dim sql As String = "SELECT IDENTIFICADOR, CODIGO_BARRAS, DESCRIPCION, FAMILIA, ULTIMO_COSTO, PRECIO_VENTA, IMPUESTO,
                                CASE 
                                  WHEN ULTIMO_COSTO > 0 THEN ROUND((((PRECIO_VENTA / ULTIMO_COSTO) * 100) - 100), 2) ELSE 0 
                                    END AS PORC_RECARGO
                                FROM (
                                      SELECT PR.IDENTIFICADOR, PR.CODIGO_BARRAS, PR.DESCRIPCION, PR_LINEAS_PROD.DESCRIPCION AS FAMILIA,
                                      ROUND(((PR_UM_PRODUCTO.COSTO_REMPLAZO * FND_TIPOS_IMPUESTO.VALOR) / 100 )+ PR_UM_PRODUCTO.COSTO_REMPLAZO) AS ULTIMO_COSTO,
                                      PR.PRECIO_VENTA, FND_TIPOS_IMPUESTO.VALOR AS IMPUESTO, 0 AS PORC_RECARGO
                                      FROM PR_PRODUCTOS PR
                                      LEFT JOIN PR_LINEAS_PROD ON PR_LINEAS_PROD.IDENTIFICADOR = PR.ID_LINEA
                                      LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                                      LEFT JOIN FND_TIPOS_IMPUESTO ON FND_TIPOS_IMPUESTO.IDENTIFICADOR = PR.ID_TIPO_IMPUESTO
                                      WHERE PR.ACTIVO='S' AND ID_PROVEEDOR=" & idProveedor.ToString & familia & ") ORDER BY DESCRIPCION"

        dtItems = reporte.consultar(sql)

        If dtItems.Rows.Count > 0 Then
            gridItems.DataSource = dtItems
        Else
            ControlMensajes.mensaje("Items no definidos para proveedor", titulo, "WAR")
            txtProveedor.Focus()
        End If
    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtProveedor.Text IsNot "" Then
                txtFamilia.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("PR")
        End If
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        vistas("PR")
    End Sub

    Private Sub txtFamilia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConsultar.Focus()
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FA")
        End If
    End Sub

    Private Sub btnBuscarFamilia_Click(sender As Object, e As EventArgs) Handles btnBuscarFamilia.Click
        vistas("FA")
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        Dim proveedor As String = ""
        proveedor = txtProveedor.Text

        Dim report As New RptRecargoPreciosPorProveedor
        report.DataSource = dtItems
        report.Parameters("proveedor").Value = proveedor
        report.Parameters("proveedor").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub chkDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescripcion.CheckedChanged
        If chkDescripcion.Checked Then
            chkCodigo.Checked = False
        End If
        txtBuscar.Text = ""
    End Sub

    Private Sub chkCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCodigo.CheckedChanged
        If chkCodigo.Checked Then
            chkDescripcion.Checked = False
        End If
        txtBuscar.Text = ""
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
                dv.RowFilter = "CODIGO_BARRAS LIKE '" & txtBuscar.Text & "%'"
                gridItems.DataSource = dv

            End If
            If chkDescripcion.Checked Then
                dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
                gridItems.DataSource = dv
            End If
        End If
    End Sub

    Private Sub btnImprimirGrilla_Click(sender As Object, e As EventArgs) Handles btnImprimirGrilla.Click
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        GridView1.ShowPrintPreview()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
End Class