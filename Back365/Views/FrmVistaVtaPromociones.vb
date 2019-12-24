Public Class FrmVistaVtaPromociones
    Dim controlador As New ContAppPromocionesProv
    Dim dt As New DataTable
    Dim frmActivo As String = ""

    Dim frmAppVtaPromociones As FrmAppVtaPromociones

    Private Sub FrmVistaVtaPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Sub listar()
        dt = controlador.consultar("SELECT IDENTIFICADOR, NOMBRE FROM APP_VTA_PROMOCIONES GROUP BY IDENTIFICADOR, NOMBRE")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        End If
    End Sub

    Public Sub setFrmConsumoMateriaPrima(frm As FrmConsumoMateriaPrima, activo As String)
        FrmConsumoMateriaPrima = frm
        frmActivo = activo
    End Sub

    Public Sub setFrmAppVtaPromociones(frm As FrmAppVtaPromociones)
        frmAppVtaPromociones = frm
    End Sub


    Sub enviarID(id As String)
        If frmActivo = "FrmAppVtaPromociones" Then
            frmAppVtaPromociones.getPromocion(id)
        End If

        Close()
    End Sub

    Private Sub gridListado_KeyDown(sender As Object, e As KeyEventArgs) Handles gridListado.KeyDown
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

    Private Sub gridListado_DoubleClick(sender As Object, e As EventArgs) Handles gridListado.DoubleClick
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
            gridListado.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dt.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dt.DefaultView
            dv.RowFilter = "NOMBRE LIKE '%" & txtBuscar.Text & "%'"
            gridListado.DataSource = dv
        End If
    End Sub

End Class