Public Class FrmVistaPrFamilias

    Dim contLineas As New ContPrLineasProd
    Dim dtLineas As New DataTable
    Dim frmActivo As String = ""

    Dim frmConsultasVarias As New Frm_consultas_varias

    Private Sub FrmVistaFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarFamilias()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub
    Public Sub setFrmConsultasVarias(frm As Frm_consultas_varias)
        frmConsultasVarias = frm
    End Sub

    Sub listarFamilias()
        dtLineas = contLineas.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_LINEAS_PROD WHERE ULTIMO_NIVEL='S'")
        If dtLineas.Rows.Count > 0 Then
            gridFamilias.DataSource = dtLineas
        End If
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmRptVentasPorFamilia" Then
            FrmRptVentasPorFamilia.getFamilia(id)
        End If
        If frmActivo = "FrmRptRecargoPreciosPorProveedor" Then
            FrmRptRecargoPreciosPorProveedor.getFamilia(id)
        End If
        If frmActivo = "FrmRptVentasPorMarca" Then
            FrmRptVentasPorMarca.getFamilia(id)
        End If
        If frmActivo = "FrmActivarDesactivarProducto" Then
            FrmActivarDesactivarProducto.getFamilia(id)
        End If
        If frmActivo = "FrmRptUnilever" Then
            FrmRptUnilever.getFamilia(id)
        End If
        If frmActivo = "FrmProductosPorFamilia" Then
            FrmProductosPorFamilia.getFamilia(id)
        End If
        If frmActivo = "Frm_consultas_varias" Then
            frmConsultasVarias.getFamilia(id)
        End If

        Close()
    End Sub

    Private Sub gridSitios_KeyDown(sender As Object, e As KeyEventArgs) Handles gridFamilias.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim fila As Integer = GridView1.FocusedRowHandle
            Dim id As String = ""

            If IsDBNull(GridView1.GetRowCellValue(fila, "IDENTIFICADOR").ToString) Then
                Return
            Else
                id = GridView1.GetRowCellValue(fila, "IDENTIFICADOR").ToString
            End If

            enviarID(id)
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub gridSitios_DoubleClick(sender As Object, e As EventArgs) Handles gridFamilias.DoubleClick
        Dim fila As Integer = GridView1.FocusedRowHandle
        Dim id As String = ""

        If IsDBNull(GridView1.GetRowCellValue(fila, "IDENTIFICADOR").ToString) Then
            Return
        Else
            id = GridView1.GetRowCellValue(fila, "IDENTIFICADOR").ToString
        End If

        enviarID(id)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtLineas.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtLineas.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
            gridFamilias.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridFamilias.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class