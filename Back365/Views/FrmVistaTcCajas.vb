Public Class FrmVistaTcCajas

    Dim contSitio As New ContFndSitios()
    Dim dtCajas As New DataTable()
    Dim frmActivo As String = ""
    Dim condicion As String = ""

    Dim frmRptArqueoCajas As FrmRptArqueoCajas

    Private Sub FrmVistaCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarSitios()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub setcondicion(str As String)
        condicion = str
    End Sub

    Public Sub setFrmRptArqueoCajas(frm As FrmRptArqueoCajas)
        frmRptArqueoCajas = frm
    End Sub

    Sub listarSitios()
        gridCajas.DataSource = Nothing
        dtCajas = New DataTable()
        dtCajas = contSitio.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM TC_CAJAS " & condicion & " ORDER BY NUMERO ASC")
        If dtCajas.Rows.Count > 0 Then
            gridCajas.DataSource = dtCajas
        End If
    End Sub

    Sub enviarID()
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim id As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR").ToString)

        If frmActivo = "FrmCerrarControlCajas" Then
            FrmCerrarControlCajas.getCaja(id)
        End If
        If frmActivo = "FrmRptArqueoCajasD" Or frmActivo = "FrmRptArqueoCajasH" Then
            frmRptArqueoCajas.getcaja(id, frmActivo)
        End If
        Close()
    End Sub

    Private Sub gridCajas_KeyDown(sender As Object, e As KeyEventArgs) Handles gridCajas.KeyDown
        If e.KeyCode = Keys.Enter Then
            enviarID()
        End If
    End Sub

    Private Sub gridCajas_DoubleClick(sender As Object, e As EventArgs) Handles gridCajas.DoubleClick
        enviarID()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtCajas.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtCajas.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
            gridCajas.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridCajas.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class