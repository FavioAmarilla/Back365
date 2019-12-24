Public Class FrmVistaCpProveedores

    Dim contCpProveedor As New ContCpProveedores()
    Dim dtProveedores As New DataTable()
    Dim frmActivo

    Dim frmRptComprasProveedorMeses As FrmRptComprasProveedorMeses
    Dim frmRptPrMatrizProveedores As FrmRptPrMatrizProveedores
    Dim frmAppPromocionesProv As FrmAppPromocionesProv

    Private Sub FrmVistaProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProveedores()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub setFrmRptComprasProveedorMeses(frm As FrmRptComprasProveedorMeses)
        frmRptComprasProveedorMeses = frm
    End Sub

    Public Sub setFrmRptPrMatrizProveedores(frm As FrmRptPrMatrizProveedores)
        frmRptPrMatrizProveedores = frm
    End Sub

    Public Sub setFrmAppPromocionesProv(frm As FrmAppPromocionesProv)
        frmAppPromocionesProv = frm
    End Sub

    Sub listarProveedores()
        dtProveedores = New DataTable()
        dtProveedores = contCpProveedor.consultar("SELECT IDENTIFICADOR, DENOMINACION FROM CP_PROVEEDORES WHERE DENOMINACION LIKE '%" & txtBuscar.Text & "%'")
        If dtProveedores.Rows.Count > 0 Then
            gridProveedores.DataSource = dtProveedores
        End If
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmAppPromociones" Then
            FrmAppPromociones.setProveedor(id)
        End If
        If frmActivo = "FrmRptRecargoPreciosPorProveedor" Then
            FrmRptRecargoPreciosPorProveedor.getProveedor(id)
        End If
        If frmActivo = "FrmActivarDesactivarProducto" Then
            FrmActivarDesactivarProducto.getProveedor(id)
        End If
        If frmActivo = "FrmRptRecepcionProductos" Then
            FrmRptRecepcionProductos.getProveedor(id)
        End If
        If frmActivo = "FrmRptRecepcionProductosMargen" Then
            FrmRptRecepcionProductosMargen.getProveedor(id)
        End If
        If frmActivo = "FrmRptComprasProveedorMeses" Then
            frmRptComprasProveedorMeses.getProveedor(id)
        End If
        If frmActivo = "FrmRptPrMatrizProveedores" Then
            frmRptPrMatrizProveedores.getProveedor(id)
        End If
        If frmActivo = "FrmAppPromocionesProv" Then
            frmAppPromocionesProv.getProveedor(id)
        End If

        Close()
    End Sub

    Private Sub gridProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles gridProveedores.KeyDown
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

    Private Sub gridProveedores_DoubleClick(sender As Object, e As EventArgs) Handles gridProveedores.DoubleClick
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
        If dtProveedores.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtProveedores.DefaultView
            dv.RowFilter = "DENOMINACION LIKE '%" & Trim(txtBuscar.Text) & "%'"
            gridProveedores.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridProveedores.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

End Class