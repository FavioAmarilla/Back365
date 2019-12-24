Public Class FrmVistaPrLineasProd

    Dim contLineas As New ContPrLineasProd
    Dim dtLineas As New DataTable
    Dim frmActivo As String = ""

    Dim frmRptExistenciaPorAlmacenes As New FrmRptExistenciaPorAlmacenes
    Dim frmRptRankingProdVendidos As New FrmRptRankingProdVendidos

    Private Sub FrmVistaFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarFamilias()
    End Sub

    Public Sub setFrmActivo(formulario As String)
        frmActivo = formulario
    End Sub

    Public Sub seFrmRptExistenciaPorAlmacenes(frm As FrmRptExistenciaPorAlmacenes)
        FrmRptExistenciaPorAlmacenes = frm
    End Sub

    Public Sub setFrmRptRankingProdVendidos(frm As FrmRptRankingProdVendidos)
        frmRptRankingProdVendidos = frm
    End Sub

    Sub listarFamilias()
        dtLineas = contLineas.consultar("SELECT IDENTIFICADOR, DESCRIPCION, ABREVIATURA, ID_LINEA_PADRE, NIVEL, ULTIMO_NIVEL FROM PR_LINEAS_PROD ORDER BY ABREVIATURA ASC")

        trFamilias.DataSource = dtLineas
        trFamilias.KeyFieldName = "IDENTIFICADOR"
        trFamilias.ParentFieldName = "ID_LINEA_PADRE"
    End Sub

    Sub enviarID(codigo As String)
        If frmActivo = "FrmRptExistenciaPorAlmacenes" Then
            frmRptExistenciaPorAlmacenes.getLineaProd(codigo)
        End If
        If frmActivo = "FrmRptRankingProdVendidos" Then
            frmRptRankingProdVendidos.getLineaProd(codigo)
        End If

        Close()
    End Sub

    Private Sub trFamilias_KeyDown(sender As Object, e As KeyEventArgs) Handles trFamilias.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim codigo As String = ""

            If IsDBNull(trFamilias.FocusedNode(0).ToString) Then
                Return
            Else
                codigo = trFamilias.FocusedNode(0).ToString
            End If

            enviarID(codigo)
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub trFamilias_DoubleClick(sender As Object, e As EventArgs) Handles trFamilias.DoubleClick
        Dim codigo As String = ""

        If IsDBNull(trFamilias.FocusedNode(0).ToString) Then
            Return
        Else
            codigo = trFamilias.FocusedNode(0).ToString
        End If

        enviarID(codigo)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If dtLineas.Rows.Count > 0 Then
            Dim dv As DataView
            Dim filter As String = ""
            filter += " ABREVIATURA LIKE '%" & txtBuscar.Text & "%' "
            filter += " OR DESCRIPCION LIKE '%" & txtBuscar.Text & "%' "
            dv = dtLineas.DefaultView
            dv.RowFilter = filter
            trFamilias.DataSource = dv
        End If
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            trFamilias.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub


End Class