
Public Class FrmVistaFndEmpresas

    Dim contEmpresa As New ContFndParmEmpresas()
    Dim dtEmpresas As New DataTable()
    Dim frmActivo As String = ""

    Dim frmConsumoMateriaPrima As FrmConsumoMateriaPrima
    Dim frmRptcomprasProveedorMeses As FrmRptComprasProveedorMeses
    Dim frmFndPeriodosGestion As FrmFndPeriodosGestion


    Private Sub FrmVistaEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarEmpresas()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Sub listarEmpresas()
        dtEmpresas = contEmpresa.consultar("SELECT IDENTIFICADOR, NOMBRE FROM FND_PARM_EMPRESAS")
        If dtEmpresas.Rows.Count > 0 Then
            gridEmpresas.DataSource = dtEmpresas
        End If
    End Sub

    Public Sub setFrmConsumoMateriaPrima(frm As FrmConsumoMateriaPrima, activo As String)
        frmConsumoMateriaPrima = frm
        frmActivo = activo
    End Sub

    Public Sub setFrmRptComprasProveedorMeses(frm As FrmRptComprasProveedorMeses)
        frmRptcomprasProveedorMeses = frm
    End Sub

    Public Sub setFrmFndPeriodosGestion(frm As FrmFndPeriodosGestion)
        frmFndPeriodosGestion = frm
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmAppPromociones" Then
            FrmAppPromociones.setEmpresa(id)
        End If
        If frmActivo = "FrmConsumoMateriaPrima" Then
            frmConsumoMateriaPrima.getEmpresa(id)
        End If

        If frmActivo = "FrmRptComprasProveedorMeses" Then
            frmRptcomprasProveedorMeses.getEmpresa(id)
        End If

        If frmActivo = "FrmFndPeriodosGestion" Then
            frmFndPeriodosGestion.getEmpresa(id)
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
        If dtEmpresas.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtEmpresas.DefaultView
            dv.RowFilter = "NOMBRE LIKE '%" & txtBuscar.Text & "%'"
            gridEmpresas.DataSource = dv
        End If
    End Sub

End Class