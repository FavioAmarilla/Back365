Public Class FrmVistaFndPerfiles

    Dim contFndUsuarios As New ContFndUsuarios()
    Dim dt As New DataTable()
    Dim frmActivo As String = ""

    Dim frmFndUsuarios As FrmFndUsuarios

    Private Sub FrmVistaFndPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Sub listar()
        dt = contFndUsuarios.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PERFILES ORDER BY NOMBRE ASC")
        If dt.Rows.Count > 0 Then
            gridUsuarios.DataSource = dt
        End If
    End Sub

    Public Sub setFrmFndUsuarios(frm As FrmFndUsuarios)
        frmFndUsuarios = frm
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmFndUsuarios" Then
            frmFndUsuarios.getPerfil(id)
        End If

        Close()
    End Sub

    Private Sub gridSitios_KeyDown(sender As Object, e As KeyEventArgs) Handles gridUsuarios.KeyDown
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

    Private Sub gridSitios_DoubleClick(sender As Object, e As EventArgs) Handles gridUsuarios.DoubleClick
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
            dv.RowFilter = "NOMBRE LIKE '%" & txtBuscar.Text & "%'"
            gridUsuarios.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridUsuarios.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class