Public Class FrmVistaPrAudCambiosPrecio

    Dim contFndUsuarios As New ContFndUsuarios()
    Dim dtSitios As New DataTable()
    Dim frmActivo As String = ""
    Dim codigoBarras As String = ""

    Dim frmCambioPrecioVenta As FrmCambioPrecioVenta

    Private Sub FrmVistaPrAudCambiosPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub
    Public Sub setCodigoBarras(codigo As String)
        codigoBarras = codigo
    End Sub

    Sub listar()
        dtSitios = contFndUsuarios.consultar("SELECT FND_SITIOS.DESCRIPCION AS SUCURSAL, PR.FECHA_APLICACION AS FECHA, PR.PRECIO_NUEVO AS PRECIO_VENTA FROM PR_AUD_CAMBIOS_PREC PR
                                                INNER JOIN FND_SITIOS ON FND_SITIOS.IDENTIFICADOR = PR.ID_SITIO
                                                WHERE CODIGO_BARRA='" & codigoBarras & "' ORDER BY FECHA_APLICACION DESC")
        If dtSitios.Rows.Count > 0 Then
            gridUsuarios.DataSource = dtSitios
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtSitios.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtSitios.DefaultView
            dv.RowFilter = "FECHA LIKE '%" & txtBuscar.Text & "%'"
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