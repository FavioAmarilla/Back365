Public Class FrmVistaStkTransaccionesStock

    Dim contTransacciones As New ContStkTransaccionesStock
    Dim dtTransacciones As New DataTable
    Dim frmActivo

    Dim frmConsumoMateriaPrima As FrmConsumoMateriaPrima


    Private Sub FrmStkTransaccionesStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTransacciones()
    End Sub

    Public Sub setFrmConsumoMateriaPrima(frm As FrmConsumoMateriaPrima, activo As String)
        frmConsumoMateriaPrima = frm
        frmActivo = activo
    End Sub

    Sub listarTransacciones()
        gridEmpresas.DataSource = Nothing
        dtTransacciones = New DataTable()
        dtTransacciones = contTransacciones.consultar("SELECT IDENTIFICADOR, NOMBRE FROM STK_TRANSACCIONES")
        If dtTransacciones.Rows.Count > 0 Then
            gridEmpresas.DataSource = dtTransacciones
        End If
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmConsumoMateriaPrima" Then
            frmConsumoMateriaPrima.getTransaccion(id)
        End If

        Close()
    End Sub

    Private Sub gridEmpresas_KeyDown(sender As Object, e As KeyEventArgs) Handles gridEmpresas.KeyDown
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

    Private Sub gridEmpresas_DoubleClick(sender As Object, e As EventArgs) Handles gridEmpresas.DoubleClick
        Dim fila As Integer = GridView1.FocusedRowHandle
        Dim id As String = ""

        If IsDBNull(GridView1.GetRowCellValue(fila, "IDENTIFICADOR").ToString) Then
            Return
        Else
            id = GridView1.GetRowCellValue(fila, "IDENTIFICADOR").ToString
        End If

        enviarID(id)
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridEmpresas.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtTransacciones.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtTransacciones.DefaultView
            dv.RowFilter = "NOMBRE LIKE '%" & txtBuscar.Text & "%'"
            gridEmpresas.DataSource = dv
        End If
    End Sub

End Class