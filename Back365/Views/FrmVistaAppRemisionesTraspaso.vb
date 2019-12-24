Public Class FrmVistaAppRemisionesTraspaso

    Dim dt As New DataTable
    Dim contFndPaises As New ContFndPaises
    Dim frmActivo As String = ""
    Dim frmGestionTraspasosProdSuc As FrmGestionTraspasosProdSuc
    Dim frmRecepcionProdSuc As FrmRecepcionProdSuc


    Private Sub FrmVistaAppRemisionesTraspaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub setFrmGestionTraspasosProdSuc(formulario As FrmGestionTraspasosProdSuc)
        frmGestionTraspasosProdSuc = formulario
    End Sub
    Public Sub setFrmRecepcionProdSuc(formulario As FrmRecepcionProdSuc)
        frmRecepcionProdSuc = formulario
    End Sub

    Sub listar()
        dt = contFndPaises.consultar("SELECT RE.IDENTIFICADOR, RE.FECHA_CRE,
                                    (SELECT DESCRIPCION FROM STK_ALMACENES WHERE IDENTIFICADOR=RE.ID_ALM_DESTINO) AS DESTINO,
                                    CASE
                                       WHEN ESTADO = 0 THEN 'PENDIENTE'
                                       WHEN ESTADO = 1  THEN 'CONFIRMADO'
                                       WHEN ESTADO = 2  THEN 'RECIBIDO'
                                       WHEN ESTADO = 3  THEN 'ANULADO'
                                    END AS ESTADO
                                    FROM APP_REMISION RE
                                    WHERE RE.ID_PROVEEDOR IS NULL
                                    ORDER BY RE.IDENTIFICADOR DESC")
        If dt.Rows.Count > 0 Then
            gridListado.DataSource = dt
        End If
    End Sub

    Sub enviarID()
        Dim rowhandle As Integer = GridView1.FocusedRowHandle
        Dim id As Integer = CInt(GridView1.GetRowCellValue(rowhandle, "IDENTIFICADOR").ToString)

        If frmActivo = "FrmGestionTraspasosProdSuc" Then
            frmGestionTraspasosProdSuc.getRemision(id)
        End If
        If frmActivo = "FrmRecepcionProdSuc" Then
            frmRecepcionProdSuc.getRemision(id)
        End If
        Close()
    End Sub

    Private Sub gridListado_KeyDown(sender As Object, e As KeyEventArgs) Handles gridListado.KeyDown
        If e.KeyCode = Keys.Enter Then
            enviarID()
        End If
    End Sub

    Private Sub gridListado_DoubleClick(sender As Object, e As EventArgs) Handles gridListado.DoubleClick
        enviarID()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If GridView1.RowCount > 0 Then
            Dim dv As DataView
            Dim filter As String = ""
            filter += " IDENTIFICADOR LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR ORIGEN LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR DESTINO LIKE '%" & txtBuscar.Text & "%' "
            dv = dt.DefaultView
            dv.RowFilter = filter
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