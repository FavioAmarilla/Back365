Imports DevExpress
Imports DevExpress.XtraReports.UI

Public Class FrmBuscarEnCaja

    Private dtBuscarEnCaja As New DataTable
    Private idProducto As Integer
    Private buscarEnCaja As String

    Dim funciones As New ContBuscarEnCaja

    Private Sub frm_buscar_en_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        lblDescripcion.Text = ""
        lblPrecioVenta.Text = ""
        txtCodigo.Focus()
    End Sub

    Private Sub listar()
        Try
            dtBuscarEnCaja.Clear()
            dtBuscarEnCaja = funciones.listar()

            If dtBuscarEnCaja.Rows.Count <> 0 Then
                tablaProductos.DataSource = dtBuscarEnCaja
            Else
                XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
                XtraEditors.XtraMessageBox.Show("No existen items activos para caja", "Buscar en Caja", Utils.DefaultBoolean.Default)
            End If

        Catch ex As Exception
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("Error al listar Productos: " + ex.Message, "Buscar en Caja", Utils.DefaultBoolean.Default)
        End Try
    End Sub


    Private Sub buscar()
        Try
            If txtCodigo.Text.Substring(0, 3) = "200" Or txtCodigo.Text.Substring(0, 3) = "240" Then
                dtBuscarEnCaja = funciones.buscar(codBarras(txtCodigo.Text))
            Else
                dtBuscarEnCaja = funciones.buscar(txtCodigo.Text)
            End If

            If dtBuscarEnCaja.Rows.Count <> 0 Then
                idProducto = dtBuscarEnCaja.Rows(0).Item(0)
                lblDescripcion.Text = dtBuscarEnCaja.Rows(0).Item(1)
                lblPrecioVenta.Text = dtBuscarEnCaja.Rows(0).Item(3) + " Gs."
                buscarEnCaja = dtBuscarEnCaja.Rows(0).Item(4)
                tablaProductos.DataSource = dtBuscarEnCaja
            Else
                XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
                XtraEditors.XtraMessageBox.Show("Producto no Definido", "Buscar en Caja", Utils.DefaultBoolean.Default)

                txtCodigo.Focus()
            End If
        Catch ex As Exception
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("Error al buscar producto: " + ex.Message, "Buscar en Caja", Utils.DefaultBoolean.Default)

        End Try
    End Sub

    Private Function codBarras(ByVal codigo As String) As String
        Dim ceros As String = ""

        For index As Integer = 13 - 7 To 5
            ceros = ceros + "0"
        Next

        Return codigo.Substring(0, 7) + ceros
    End Function

    Private Function createReport() As XtraReport
        Dim reporte As New RptBuscarEnCaja()

        reporte.DataSource = dtBuscarEnCaja

        Return reporte

    End Function

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            buscar()
        ElseIf e.KeyCode = Keys.F10 Then
            btnAgregar.Focus()
            SendKeys.Send("{ENTER}")
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If idProducto <= 0 Then
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("Seleccione un Producto para activar/desactivar", "Buscar en Caja", Utils.DefaultBoolean.Default)
        Else
            If funciones.update(buscarEnCaja, idProducto) Then
                XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
                XtraEditors.XtraMessageBox.Show("Producto Actualizado", "Buscar en Caja", Utils.DefaultBoolean.Default)
                listar()
                txtCodigo.Text = ""
                lblDescripcion.Text = ""
                lblPrecioVenta.Text = ""
                txtCodigo.Focus()
            Else
                XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
                XtraEditors.XtraMessageBox.Show("Producto no Actualizado", "Buscar en Caja", Utils.DefaultBoolean.Default)
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dtBuscarEnCaja.Rows.Count <> 0 Then
            Dim printTool As New ReportPrintTool(createReport())
            printTool.ShowPreview()
        Else
            XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
            XtraEditors.XtraMessageBox.Show("No existen productos activos para la impresion", "Buscar en Caja", Utils.DefaultBoolean.Default)
        End If
    End Sub

    Private Sub tablaProductos_Click(sender As Object, e As EventArgs) Handles tablaProductos.Click
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        txtCodigo.Text = GridView1.GetRowCellValue(rowhandle, "CODIGO_BARRAS")

        txtCodigo.Focus()
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub tablaProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaProductos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            txtCodigo.Text = GridView1.GetRowCellValue(rowhandle, "CODIGO_BARRAS")

            txtCodigo.Focus()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        listar()
        txtCodigo.Text = ""
        txtBuscar.Text = ""
        lblDescripcion.Text = ""
        lblPrecioVenta.Text = ""
        txtCodigo.Focus()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtBuscarEnCaja.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtBuscarEnCaja.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%' OR CODIGO_BARRAS LIKE '%" & txtBuscar.Text & "%'"
            tablaProductos.DataSource = dv
        End If
    End Sub

End Class