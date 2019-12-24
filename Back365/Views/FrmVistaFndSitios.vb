Public Class FrmVistaFndSitios

    Dim contSitio As New ContFndSitios()
    Dim dtSitios As New DataTable()
    Dim frmActivo As String = ""
    Dim idEmpresa As Integer = 0
    Dim idUnidad As Integer = 0

    Dim frmConsumoMateriaPrima As FrmConsumoMateriaPrima
    Dim frmRptcomprasProveedorMeses As FrmRptComprasProveedorMeses
    Dim frmGenerarArchivoBalanza As FrmGenerarArchivoBalanza
    Dim frmCambioPrecioVenta As FrmCambioPrecioVenta
    Dim frmRptArqueoCajas As FrmRptArqueoCajas
    Dim frmPreciosVentaAplicados As FrmPreciosVentaAplicados
    Dim frmRptRankingProdVendidos As FrmRptRankingProdVendidos
    Dim frmAppVtaPromociones As FrmAppVtaPromociones
    Dim frm_consultas_varias As Frm_consultas_varias
    Dim frmTcControlCaja As FrmTcControlCaja
    Dim frmAppPromocionesProv As FrmAppPromocionesProv
    Dim frmGenerarListaProd As FrmGenerarListaProd

    Private Sub FrmVistaSitios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarSitios()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub setFrmRptComprasProveedorMeses(frm As FrmRptComprasProveedorMeses)
        frmRptcomprasProveedorMeses = frm
    End Sub

    Public Sub setFrmCambioPrecioVenta(frm As FrmCambioPrecioVenta)
        frmCambioPrecioVenta = frm
    End Sub

    Public Sub setFrmGenerarArchivoBalanza(frm As FrmGenerarArchivoBalanza)
        frmGenerarArchivoBalanza = frm
    End Sub

    Public Sub setFrmConsumoMateriaPrima(frm As FrmConsumoMateriaPrima, activo As String)
        frmConsumoMateriaPrima = frm
        frmActivo = activo
    End Sub

    Public Sub setFrmRptArqueoCajas(frm As FrmRptArqueoCajas)
        frmRptArqueoCajas = frm
    End Sub

    Public Sub setFrmPreciosVentaAplicados(frm As FrmPreciosVentaAplicados)
        frmPreciosVentaAplicados = frm
    End Sub

    Public Sub setFrmRptRankingProdVendidos(frm As FrmRptRankingProdVendidos)
        frmRptRankingProdVendidos = frm
    End Sub

    Public Sub setFrmAppVtaPromociones(frm As FrmAppVtaPromociones)
        frmAppVtaPromociones = frm
    End Sub

    Public Sub setFrm_consultas_varias(frm As Frm_consultas_varias)
        frm_consultas_varias = frm
    End Sub

    Public Sub setFrmTcControlCaja(frm As FrmTcControlCaja)
        frmTcControlCaja = frm
    End Sub

    Public Sub setFrmAppPromocionesProv(frm As FrmAppPromocionesProv)
        frmAppPromocionesProv = frm
    End Sub

    Public Sub setFrmGenerarListaProd(frm As FrmGenerarListaProd)
        frmGenerarListaProd = frm
    End Sub

    Sub listarSitios()
        dtSitios = contSitio.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM FND_SITIOS")
        If dtSitios.Rows.Count > 0 Then
            gridSitios.DataSource = dtSitios
        End If
    End Sub

    Sub enviarID(id As String)
        If frmActivo = "FrmAppPromociones" Then
            FrmAppPromociones.setSitio(id)
        End If
        If frmActivo = "FrmRptVentasPorFamilia" Then
            FrmRptVentasPorFamilia.getSucursal(id)
        End If
        If frmActivo = "FrmRptVentasPorMarca" Then
            FrmRptVentasPorMarca.getSucursal(id)
        End If
        If frmActivo = "FrmRptUnilever" Then
            FrmRptUnilever.getSucursal(id)
        End If
        If frmActivo = "FrmTomaInventario" Then
            FrmTomaInventario.getSucursal(id)
        End If
        If frmActivo = "FrmConsumoMateriaPrima" Then
            frmConsumoMateriaPrima.getSitio(id)
        End If
        If frmActivo = "FrmRptComprasProveedorMeses" Then
            FrmRptComprasProveedorMeses.getSitio(id)
        End If
        If frmActivo = "FrmGenerarArchivoBalanza" Then
            frmGenerarArchivoBalanza.getSitio(id)
        End If
        If frmActivo = "FrmCambioPrecioVenta" Then
            frmCambioPrecioVenta.getSitio(id)
        End If
        If frmActivo = "FrmRptArqueoCajas" Then
            frmRptArqueoCajas.getSitio(id)
        End If
        If frmActivo = "FrmPreciosVentaAplicados" Then
            frmPreciosVentaAplicados.getSitio(id)
        End If
        If frmActivo = "FrmPreciosVentaAplicados" Then
            frmPreciosVentaAplicados.getSitio(id)
        End If
        If frmActivo = "FrmRptRankingProdVendidos" Then
            frmRptRankingProdVendidos.getSitio(id)
        End If
        If frmActivo = "FrmAppVtaPromociones" Then
            frmAppVtaPromociones.getSitio(id)
        End If
        If frmActivo = "Frm_consultas_varias" Then
            frm_consultas_varias.getSitio(id)
        End If
        If frmActivo = "FrmTcControlCaja" Then
            frmTcControlCaja.getSitio(id)
        End If
        If frmActivo = "FrmAppPromocionesProv" Then
            frmAppPromocionesProv.getSitio(id)
        End If
        If frmActivo = "FrmGenerarListaProd" Then
            frmGenerarListaProd.getSucursal(id)
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
        If dtSitios.Rows.Count > 0 Then
            Dim dv As DataView
            dv = dtSitios.DefaultView
            dv.RowFilter = "DESCRIPCION LIKE '%" & txtBuscar.Text & "%'"
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