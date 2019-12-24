Imports DevExpress
Imports DevExpress.XtraReports.UI

Public Class FrmReporteRotiseria

    Dim rotiseria As New ContReporteRotiseria()
    Dim dt_reporte_rotiseria As New DataTable("dt_reporte_rotiseria")

    Dim TOTAL_COSTO As Integer = 0
    Dim TOTAL_VENTA As Integer = 0

    Private Sub frm_reporte_rotiseria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaDesde.Focus()
    End Sub

    Private Sub cargarGrilla()
        If txtFechaDesde.Text = "  /  /" Then
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("El campo <<Fecha Desde>> no puede estar vacio", "Reporte de Mov. en Rotiseria", Utils.DefaultBoolean.Default)
            txtFechaDesde.Focus()
        ElseIf txtFechaHasta.Text = "  /  /" Then
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("El campo <<Fecha Hasta>> no puede estar vacio", "Reporte de Mov. en Rotiseria", Utils.DefaultBoolean.Default)
            txtFechaHasta.Focus()
        Else
            dt_reporte_rotiseria = rotiseria.listar("FECHA", txtFechaDesde.Text.ToString(), txtFechaHasta.Text.ToString())
            If dt_reporte_rotiseria.Rows.Count <> 0 Then
                gridItems.DataSource = dt_reporte_rotiseria
            Else
                dt_reporte_rotiseria.Clear()
                dt_reporte_rotiseria = rotiseria.listar("FEC_CRE", txtFechaDesde.Text.ToString(), txtFechaHasta.Text.ToString())
                If dt_reporte_rotiseria.Rows.Count <> 0 Then
                    gridItems.DataSource = dt_reporte_rotiseria
                Else
                    XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
                    XtraEditors.XtraMessageBox.Show("Materias primas eno utilizadas en el rango de fechas", "Reporte de Mov. en Rotiseria", Utils.DefaultBoolean.Default)
                End If
            End If
        End If
    End Sub

    Private Function reporte() As XtraReport
        Dim report As New RptRotiseria()

        report.DataSource = dt_reporte_rotiseria

        report.Parameters("fecha_desde").Value = txtFechaDesde.Text
        report.Parameters("fecha_hasta").Value = txtFechaHasta.Text

        report.Parameters("fecha_desde").Visible = False
        report.Parameters("fecha_hasta").Visible = False


        Return report
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TOTAL_COSTO = 0
        TOTAL_VENTA = 0
        cargarGrilla()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dt_reporte_rotiseria.Rows.Count <> 0 Then
            Dim printTool As New ReportPrintTool(reporte())
            printTool.ShowPreview()
        Else
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("Debe realizar una consulta para la impresion", "Reporte de Mov. en Rotiseria", Utils.DefaultBoolean.Default)
        End If
    End Sub

    Private Sub txtFechaDesde_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFechaHasta.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtFechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.Focus()
            SendKeys.Send("{ENTER}")
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
