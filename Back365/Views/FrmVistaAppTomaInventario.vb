Public Class FrmVistaAppTomaInventario

    Dim contAppTomaInventario As New ContAppTomaInventario
    Dim dt As New DataTable
    Dim frmActivo As String = ""

    Dim frmTomaInventarioGestion As FrmTomaInventarioGestion

    Private Sub FrmVistaAppTomaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub setFrmTomaInventarioGestion(frm As FrmTomaInventarioGestion)
        frmTomaInventarioGestion = frm
    End Sub

    Sub listar()
        dt = contAppTomaInventario.consultar("SELECT IDENTIFICADOR, NUMERO, FECHA FROM APP_TOMA_INVENTARIO ORDER BY IDENTIFICADOR DESC")
        If dt.Rows.Count > 0 Then
            gridSitios.DataSource = dt
        End If
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmTomaInventarioGestion" Then
            frmTomaInventarioGestion.getTomaInventario(id)
        End If

        Close()
    End Sub

    Private Sub gridSitios_KeyDown(sender As Object, e As KeyEventArgs) Handles gridSitios.KeyDown
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

    Private Sub gridSitios_DoubleClick(sender As Object, e As EventArgs) Handles gridSitios.DoubleClick
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
        If dt.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dt.DefaultView
            dv.RowFilter = " NUMERO LIKE '%" & txtBuscar.Text & "%' "
            gridSitios.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridSitios.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class