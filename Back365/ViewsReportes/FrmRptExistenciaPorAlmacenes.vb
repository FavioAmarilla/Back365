Imports DevExpress.XtraReports.UI

Public Class FrmRptExistenciaPorAlmacenes

    Dim contStkStock As New ContStkStockProd
    Dim titulo As String = "Reporte"
    Dim dt As New DataTable

    Dim idalmacen As Integer = 0
    Dim codigoLinea As String = ""

    Private Sub FrmRptExistenciaPorAlmacenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkExistencia.Checked = True
    End Sub

    Private Sub limpiar()
        idalmacen = 0
        txtAlmacen.Text = ""
        txtBuscar.Text = ""
        chkExistencia.Checked = False
        dt = Nothing
        gridProductos.DataSource = dt
    End Sub

    Private Sub consultar()
        Dim lineas As String = ""

        If codigoLinea IsNot "" Then
            lineas = " AND PR_LINEAS_PROD.ABREVIATURA Like '" & codigoLinea & "%'"
        End If

        Dim sql As String = "Select PR_PRODUCTOS.IDENTIFICADOR, PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, ST.EXISTENCIA, 
                                (PR_LINEAS_PROD.ABREVIATURA  || ' - ' || PR_LINEAS_PROD.DESCRIPCION) AS LINEA
                                FROM STK_STOCK_PROD ST
                                INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = ST.ID_PRODUCTO
                                INNER JOIN PR_LINEAS_PROD ON PR_LINEAS_PROD.IDENTIFICADOR = PR_PRODUCTOS.ID_LINEA
                                WHERE ST.ID_ALMACEN=" & CStr(idalmacen) & lineas

        dt = contStkStock.consultar(sql)

        If dt.Rows.Count > 0 Then
            gridProductos.DataSource = dt
        Else
            ControlMensajes.mensaje("No existen productos en almacen", titulo, "WAR")
        End If
    End Sub

    Private Sub vistas(verificador As String)
        If verificador = "AL" Then
            Dim frm As New FrmVistaStkAlmacenes
            frm.seFrmRptExistenciaPorAlmacenes(Me, "FrmRptExistenciaPorAlmacenes")
            frm.ShowDialog()
        End If
        If verificador = "LI" Then
            Dim frm As New FrmVistaPrLineasProd
            frm.seFrmRptExistenciaPorAlmacenes(Me)
            frm.setFrmActivo("FrmRptExistenciaPorAlmacenes")
            frm.ShowDialog()
        End If
    End Sub

    Public Sub getAlmacen(id As Integer)
        Dim dt As New DataTable
        dt = contStkStock.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM STK_ALMACENES WHERE IDENTIFICADOR=" & CStr(id))

        idalmacen = CInt(dt.Rows(0).Item(0))
        txtAlmacen.Text = CStr(dt.Rows(0).Item(1))
        txtAlmacen.Focus()
    End Sub

    Public Sub getLineaProd(codigo As String)
        Dim dt As New DataTable
        dt = contStkStock.consultar("SELECT ABREVIATURA, DESCRIPCION FROM PR_LINEAS_PROD WHERE ABREVIATURA='" & codigo & "'")

        codigoLinea = codigo
        txtLinea.Text = codigo & " - " & CStr(dt.Rows(0).Item(1))
    End Sub

    Private Sub crearReporte()
        If ControlMensajes.msj_confirmacion("Impirmir reporte?", titulo) = False Then
            Return
        End If
        If chkExistencia.Checked Then
            Dim report As New RptExistenciaPorAlmacenes

            report.DataSource = gridProductos.DataSource

            report.Parameters("almacen").Value = txtAlmacen.Text
            report.Parameters("linea").Value = txtLinea.Text
            report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy HH:mm:ss")

            report.Parameters("almacen").Visible = False
            report.Parameters("linea").Visible = False
            report.Parameters("usuario_fecha_imp").Visible = False

            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreview()
        Else
            Dim report As New RptProductosPorAlmacen

            report.DataSource = gridProductos.DataSource

            report.Parameters("almacen").Value = txtAlmacen.Text
            report.Parameters("linea").Value = txtLinea.Text
            report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy HH:mm:ss")

            report.Parameters("almacen").Visible = False
            report.Parameters("linea").Visible = False
            report.Parameters("usuario_fecha_imp").Visible = False

            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreview()
        End If



    End Sub

    Private Sub txtAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAlmacen.Text IsNot "" Then
                txtLinea.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("AL")
        End If
    End Sub

    Private Sub btnAlmacenes_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        vistas("AL")
    End Sub

    Private Sub txtLinea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLinea.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtLinea.Text IsNot "" Then
                chkExistencia.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("LI")
        End If
    End Sub
    Private Sub btnLineas_Click(sender As Object, e As EventArgs) Handles btnLineas.Click
        vistas("LI")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        consultar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelar la operacion", titulo) Then
            limpiar()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dt.Rows.Count > 0 Then
            Dim dv As DataView
            Dim filter As String = ""
            filter += " CODIGO_BARRAS LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR DESCRIPCION LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR EXISTENCIA LIKE '%" & txtBuscar.Text & "%' "
            dv = dt.DefaultView
            dv.RowFilter = filter
            gridProductos.DataSource = dv
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
        Else
            crearReporte()
        End If
    End Sub

    Private Sub chkExistencia_KeyDown(sender As Object, e As KeyEventArgs) Handles chkExistencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub chkExistencia_CheckedChanged(sender As Object, e As EventArgs) Handles chkExistencia.CheckedChanged
        If chkExistencia.Checked Then
            GridView1.Columns("EXISTENCIA").Visible = True
        Else
            GridView1.Columns("EXISTENCIA").Visible = False
        End If
    End Sub
End Class