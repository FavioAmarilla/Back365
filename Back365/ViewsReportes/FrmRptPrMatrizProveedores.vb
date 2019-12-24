Imports DevExpress.XtraReports.UI

Public Class FrmRptPrMatrizProveedores

    Dim contReportes As New ContReportes
    Dim dtListado As New DataTable

    Dim titulo As String = "Matriz de proveedores"
    Dim idProveedor As Integer = 0

    Private Sub FrmRptPrMatrizProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        dtListado = Nothing
        gridListado.DataSource = dtListado
        idProveedor = 0
        txtProveedor.Text = ""
    End Sub

    Sub listarProveedores()
        Dim frm As New FrmVistaCpProveedores
        frm.setFrmActivo("FrmRptPrMatrizProveedores")
        frm.setFrmRptPrMatrizProveedores(Me)
        frm.ShowDialog()
    End Sub

    Sub getProveedor(id As Integer)
        Dim dt As New DataTable
        dt = contReportes.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idProveedor = CInt(dt.Rows(0).Item(0))
            txtProveedor.Text = CStr(dt.Rows(0).Item(1))
            txtProveedor.Focus()
        Else
            ControlMensajes.mensaje("Proveedor no definido", titulo, "WAR")
            txtProveedor.Focus()
        End If
    End Sub

    Sub consultar()
        If idProveedor <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar proveedor", titulo, "WAR")
            txtProveedor.Focus()
            Return
        End If

        Dim sql As String = "SELECT PR.IDENTIFICADOR, CODIGO,CODIGO_BARRAS, PR.DESCRIPCION, PR.ID_LINEA, PR_LINEAS_PROD.DESCRIPCION AS LINEA, 
                                TO_CHAR((SELECT MAX(CP_ITEMS_COMPROB.FEC_CRE) AS FEC_CRE 
                                FROM CP_ITEMS_COMPROB  
                                LEFT JOIN CP_COMPROBANTES ON CP_COMPROBANTES.IDENTIFICADOR=CP_ITEMS_COMPROB.ID_COMPROBANTE 
                                WHERE CP_ITEMS_COMPROB.ID_PRODUCTO=PR.IDENTIFICADOR AND CP_COMPROBANTES.ID_TIPO_COMPROB != 3 ),'DD/MM/YYYY') AS FEC_ULTIMA_COMPRA, 
                                (
                                SELECT CANTIDAD 
                                FROM CP_ITEMS_COMPROB 
                                WHERE CP_ITEMS_COMPROB.ID_PRODUCTO=PR.IDENTIFICADOR 
                                AND IDENTIFICADOR=(
                                                   SELECT MAX(CP_ITEMS_COMPROB.IDENTIFICADOR) 
                                                   FROM CP_ITEMS_COMPROB 
                                                   LEFT JOIN CP_COMPROBANTES ON CP_COMPROBANTES.IDENTIFICADOR=CP_ITEMS_COMPROB.ID_COMPROBANTE 
                                                   WHERE CP_ITEMS_COMPROB.ID_PRODUCTO=PR.IDENTIFICADOR 
                                                   AND CP_COMPROBANTES.ID_TIPO_COMPROB != 3 ))AS CANTIDAD,
                                                   (
                                                       SELECT SUM(CANTIDAD) 
                                                       FROM STK_ITEMS_MV_STOCK 
                                                       WHERE ID_PRODUCTO=PR.IDENTIFICADOR AND ID_TRANSACCION=19 AND FEC_CRE > =(SELECT MAX(CP_ITEMS_COMPROB.FEC_CRE) AS FEC_CRE 
                                                       FROM CP_ITEMS_COMPROB 
                                                       LEFT JOIN CP_COMPROBANTES ON CP_COMPROBANTES.IDENTIFICADOR=CP_ITEMS_COMPROB.ID_COMPROBANTE 
                                                       WHERE CP_ITEMS_COMPROB.ID_PRODUCTO=PR.IDENTIFICADOR AND CP_COMPROBANTES.ID_TIPO_COMPROB != 3   ))AS VENTA_ULTIMA_COMPRA 
                                                       FROM PR_PRODUCTOS PR 
                                                       LEFT JOIN PR_LINEAS_PROD ON PR_LINEAS_PROD.IDENTIFICADOR=PR.ID_LINEA 
                                                       WHERE PR.ID_PROVEEDOR=" & CStr(idProveedor) & " AND ACTIVO='S'"

        dtListado = contReportes.consultar(sql)

        If dtListado.Rows.Count > 0 Then
            gridListado.DataSource = dtListado
        Else
            ControlMensajes.mensaje("Registros no definidos", titulo, "WAR")
        End If

    End Sub

    Private Sub crearReporte()
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("El documento no contiene paginas", titulo, "WAR")
            Return
        End If

        If ControlMensajes.msj_confirmacion("Impirmir reporte?", titulo) = False Then
            Return
        End If

        Dim report As New RptPrMatrizProveedores

        report.DataSource = dtListado

        report.Parameters("proveedor").Value = txtProveedor.Text
        report.Parameters("usuario_fecha_imp").Value = "Usuario Imp.:" + FrmMenuPrincipal.USUARIO + "   Fecha Imp.: " + Now.ToString("dd/MM/yyyy HH:mm:ss")

        report.Parameters("proveedor").Visible = False
        report.Parameters("usuario_fecha_imp").Visible = False

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowPreview()
    End Sub

    Private Sub txtProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProveedor.KeyDown
        If e.KeyCode = Keys.Enter And idProveedor > 0 Then
            btnConsultar.Focus()
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            listarProveedores()
        End If
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        listarProveedores()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        crearReporte()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelarla operacion", titulo) Then
            limpiar()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtListado.Rows.Count > 0 Then
            Dim dv As DataView
            Dim filter As String = ""
            filter = " CODIGO_BARRAS LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR DESCRIPCION LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR LINEA LIKE '%" & txtBuscar.Text & "%' "
            dv = dtListado.DefaultView
            dv.RowFilter = filter
            gridListado.DataSource = dv
        End If
    End Sub
End Class