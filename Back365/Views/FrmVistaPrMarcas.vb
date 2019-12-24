Public Class FrmVistaPrMarcas

    Dim contPresentacion As New ContPrPresentacion
    Dim dtPresentaciones As New DataTable
    Dim frmActivo As String = ""

    Private Sub FrmVistaMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPresentaciones()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Sub listarPresentaciones()
        gridPresentaciones.DataSource = Nothing
        dtPresentaciones = New DataTable()
        dtPresentaciones = contPresentacion.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_MARCAS")
        If dtPresentaciones.Rows.Count > 0 Then
            gridPresentaciones.DataSource = dtPresentaciones
        End If
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmActivarDesactivarProducto" Then
            FrmActivarDesactivarProducto.getMarca(id)
        End If

        Close()
    End Sub

    Private Sub gridPresentaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles gridPresentaciones.KeyDown
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

    Private Sub gridPresentaciones_DoubleClick(sender As Object, e As EventArgs) Handles gridPresentaciones.DoubleClick
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
        If dtPresentaciones.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtPresentaciones.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
            gridPresentaciones.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridPresentaciones.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class