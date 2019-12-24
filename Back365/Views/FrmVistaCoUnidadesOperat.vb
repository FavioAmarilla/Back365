Public Class FrmVistaCoUnidadesOperat

    Dim contUnidades As New ContCoUnidadesOperat()
    Dim dtUnidades As New DataTable()
    Dim frmActivo As String = ""
    Dim idEmpresa As Integer = 0

    Dim frmConsumoMateriaPrima As FrmConsumoMateriaPrima
    Dim frmRptcomprasProveedorMeses As FrmRptComprasProveedorMeses
    Dim frmFndSitios As FrmFndSitios

    Private Sub FrmVistaUnidadesOperat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUnidadesOperat()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Sub listarUnidadesOperat()
        gridUnidadesOperat.DataSource = Nothing
        dtUnidades = New DataTable()
        dtUnidades = contUnidades.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM CO_UNIDADES_OPERAT")
        If dtUnidades.Rows.Count > 0 Then
            gridUnidadesOperat.DataSource = dtUnidades
        End If
    End Sub

    Public Sub setFrmConsumoMateriaPrima(frm As FrmConsumoMateriaPrima, activo As String)
        frmConsumoMateriaPrima = frm
        frmActivo = activo
    End Sub

    Public Sub setFrmRptComprasProveedorMeses(frm As FrmRptComprasProveedorMeses)
        frmRptcomprasProveedorMeses = frm
    End Sub
    Public Sub setFrmFndSitios(frm As FrmFndSitios)
        frmFndSitios = frm
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmAppPromociones" Then
            FrmAppPromociones.setUnidadOperat(id)
        End If
        If frmActivo = "FrmRptVentasPorFamilia" Then
            FrmRptVentasPorFamilia.getUnidadOperat(id)
        End If
        If frmActivo = "FrmRptVentasPorMarca" Then
            FrmRptVentasPorMarca.getUnidadOperat(id)
        End If
        If frmActivo = "FrmRptUnilever" Then
            FrmRptUnilever.getUnidadOperat(id)
        End If
        If frmActivo = "FrmConsumoMateriaPrima" Then
            frmConsumoMateriaPrima.getUnidadOperat(id)
        End If
        If frmActivo = "FrmRptComprasProveedorMeses" Then
            frmRptcomprasProveedorMeses.getUnidadOperat(id)
        End If
        If frmActivo = "FrmFndSitios" Then
            frmFndSitios.getUnidadOperat(id)
        End If
        Close()
    End Sub

    Private Sub gridUnidadesOperat_KeyDown(sender As Object, e As KeyEventArgs) Handles gridUnidadesOperat.KeyDown
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

    Private Sub gridUnidadesOperat_DoubleClick(sender As Object, e As EventArgs) Handles gridUnidadesOperat.DoubleClick
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
        If dtUnidades.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtUnidades.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
            gridUnidadesOperat.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridUnidadesOperat.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class