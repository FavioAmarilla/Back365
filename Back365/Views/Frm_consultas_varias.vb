Imports DevExpress.XtraPrinting

Public Class Frm_consultas_varias

    Dim titulo As String = "Consultas varias"
    Dim contConsultasVarias As New ContConsultasVarias
    Dim dt As New DataTable
    Dim idFamilia As Integer = 0
    Dim idSitio As Integer = 0

    Private Sub Frm_consultas_varias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
    End Sub

    Sub limpiar()
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
        txtFamilia.Text = ""
        idFamilia = 0
        idSitio = 0
        cldFechaDesde.Visible = False
        cldFechaHasta.Visible = False
        GridView1.Columns.Clear()
        grid_consulta.DataSource = Nothing
        txtFechaDesde.Focus()
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

    Sub listarSucursales()
        Dim frm As New FrmVistaFndSitios
        frm.setFrmActivo("Frm_consultas_varias")
        frm.setFrm_consultas_varias(Me)
        frm.ShowDialog()
    End Sub

    Public Sub getSitio(id As String)
        Dim dt As New DataTable
        dt = contConsultasVarias.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            idSitio = CInt(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
            txtSucursal.Focus()
        Else
            idSitio = 0
            txtSucursal.Text = ""
            txtSucursal.Focus()
        End If
    End Sub

    Sub listarFamilias()
        Dim frm As New FrmVistaPrFamilias
        frm.setFrmActivo("Frm_consultas_varias")
        frm.setFrmConsultasVarias(Me)
        frm.ShowDialog()
    End Sub

    Sub getFamilia(id As String)
        Dim dt As New DataTable
        dt = contConsultasVarias.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_LINEAS_PROD WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idFamilia = CInt(dt.Rows(0).Item(0))
            txtFamilia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub consultar()
        grid_consulta.DataSource = Nothing

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
        If idFamilia <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar familia", titulo, "WAR")
            txtFamilia.Focus()
            Return
        End If

        GridView1.Columns.Clear()
        grid_consulta.DataSource = Nothing

        Dim sql As String = ""
        Dim sitio As String = ""
        Dim xRow As Integer = 0
        Dim x As Integer = 0
        Dim desde As DateTime = txtFechaDesde.Text
        Dim hasta As DateTime = txtFechaHasta.Text
        Dim ticksDiarios As Long = 86400L * 1000L * 10000L

        sql = "SELECT x.id_producto, descripcion, precio_venta "
        For ticks As Long = desde.Ticks To hasta.Ticks Step ticksDiarios
            Dim fecha As DateTime = New DateTime(ticks)
            sql = sql + " ,round(max(decode(x.fecha,'" & fecha & "',x.cantidad)), 2)" & Chr(34) & fecha & Chr(34) & "  "

        Next

        If idSitio > 0 Then
            sitio = " and vta_comprobantes.id_sitio=" & CStr(idSitio) & " "
        End If

        sql = sql + ",  
            round((
               select sum(cantidad) 
               from vta_items_comprob it 
               left join vta_comprobantes on vta_comprobantes.identificador = it.id_comprobante 
               where it.id_producto=x.id_producto and trunc(it.fec_cre) >= to_date ('" & desde & "','dd/mm/yyyy') 
               and trunc(it.fec_cre) <= to_date ('" & hasta & "','dd/mm/yyyy') " & sitio & "
            ), 2) as total  FROM
             (
            select to_char(vta_items_comprob.fec_cre,'dd/mm/yyyy') as fecha, sum(cantidad)as cantidad,
            id_producto, pr_productos.descripcion, precio_venta, segmento3
            from vta_items_comprob 
            left join vta_comprobantes on vta_comprobantes.identificador = vta_items_comprob.id_comprobante
            left join pr_productos on pr_productos.identificador = vta_items_comprob.id_producto
            where pr_productos.id_linea=" & idFamilia & " 
            and trunc(vta_items_comprob.fec_cre) >= to_date ('" & desde & "','dd/mm/yyyy') 
            and trunc(vta_items_comprob.fec_cre) <= to_date ('" & hasta & "','dd/mm/yyyy')
            " & sitio & "
            group by to_char(vta_items_comprob.fec_cre,'dd/mm/yyyy'), id_producto, pr_productos.descripcion, precio_venta,segmento3
            ) x
            group by x.id_producto, x.segmento3, descripcion, precio_venta order by x.segmento3 asc, x.descripcion asc"

        dt = contConsultasVarias.consultar(sql)

        If dt.Rows.Count > 0 Then
            grid_consulta.DataSource = dt
        Else
            ControlMensajes.mensaje("No se registraron ventas en el rango de fecha", titulo, "WAR")
        End If

    End Sub

    Private Sub GridView1_PrintInitialize(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView1.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        grid_consulta.ShowPrintPreview()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        consultar()
    End Sub

    Private Sub btnFamilias_Click(sender As Object, e As EventArgs) Handles btnFamilias.Click
        listarFamilias()
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
                txtFamilia.Focus()
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

    Private Sub txtFamilia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarFamilias()
        End If
        If e.KeyCode = Keys.Enter Then
            If idFamilia > 0 Then
                txtSucursal.Focus()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub txtSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSucursal.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarSucursales()
        End If
        If e.KeyCode = Keys.Enter Then
            btnConsultar.Focus()
        End If
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        listarSucursales()
    End Sub
End Class