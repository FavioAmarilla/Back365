Public Class FrmVistaPromociones

    Dim contPromociones As New ContAppPromociones
    Dim dtPromociones As New DataTable
    Dim frmActivo

    Private Sub FrmVistaPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPromociones()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Sub listarPromociones()
        dtPromociones = contPromociones.consultar("SELECT APP.IDENTIFICADOR, APP.DESCRIPCION, APP.FECHA_DESDE, APP.FECHA_HASTA, COALESCE(APP.CERRADO, 'N') AS CERRADO,
                                                CP_PROVEEDORES.DENOMINACION AS PROVEEDOR
                                                FROM APP_PROMOCIONES APP
                                                LEFT JOIN CP_PROVEEDORES ON CP_PROVEEDORES.IDENTIFICADOR = APP.ID_PROVEEDOR
                                                WHERE APP.DESCRIPCION LIKE '%" & txtBuscar.Text & "%' ORDER BY APP.IDENTIFICADOR DESC")
        If dtPromociones.Rows.Count > 0 Then
            gridPromociones.DataSource = dtPromociones
        End If
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmAppPromociones" Then
            FrmAppPromociones.getPromocion(id)
        End If

        Close()
    End Sub

    Private Sub gridEmpresas_KeyDown(sender As Object, e As KeyEventArgs) Handles gridPromociones.KeyDown
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

    Private Sub gridEmpresas_DoubleClick(sender As Object, e As EventArgs) Handles gridPromociones.DoubleClick
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
        If dtPromociones.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtPromociones.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
            gridPromociones.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridPromociones.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

End Class