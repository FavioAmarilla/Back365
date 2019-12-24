Public Class FrmVistaFndPaises

    Dim dt As New DataTable
    Dim contFndPaises As New ContFndPaises
    Dim frmActivo As String = ""
    Dim frmFndTerritorios As FrmFndTerritorios
    Dim frmFndSitios As FrmFndSitios

    Private Sub FrmVistaPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub setFrmFndSitios(formulario As FrmFndSitios)
        frmFndSitios = formulario
    End Sub

    Public Sub setFrmFndTerritorios(formulario As FrmFndTerritorios)
        frmFndTerritorios = formulario
    End Sub

    Sub listar()
        dt = contFndPaises.consultar("SELECT IDENTIFICADOR, DESCRIPCION, ABREVIATURA FROM FND_PAISES ORDER BY DESCRIPCION ASC")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        End If
    End Sub

    Sub enviarID()
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim id As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR").ToString)

        If frmActivo = "FrmFndTerritorios" Then
            frmFndTerritorios.getPais(id)
        End If
        If frmActivo = "FrmFndSitios" Then
            frmFndSitios.getPais(id)
        End If
        Close()
    End Sub

    Private Sub gridListado_KeyDown(sender As Object, e As KeyEventArgs) Handles gridListado.KeyDown
        enviarID()
    End Sub

    Private Sub gridListado_DoubleClick(sender As Object, e As EventArgs) Handles gridListado.DoubleClick
        enviarID()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If GridView1.RowCount > 0 Then
            Dim dv As DataView
            dv = dt.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%' OR ABREVIATURA LIKE '%" & txtBuscar.Text & "%'"
            gridListado.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridListado.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class