Public Class FrmProductosPorFamilia

    Dim contProducto As New ContPrProductos
    Dim titulo As String = "Productos por familia"
    Dim dtProductos As New DataTable
    Dim noDefinidos As New ArrayList

    Dim idFamilia As Integer = 0

    Private Sub FrmProductosPorFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub vistas(vr As String)
        If vr = "LP" Then
            Dim frm As New FrmVistaPrFamilias
            frm.setFrmActivo("FrmProductosPorFamilia")
            frm.ShowDialog()
        End If
    End Sub

    Sub limpiar()
        txtFamilia.Text = ""
        idFamilia = 0
        noDefinidos.Clear()
        gridProductos.DataSource = Nothing
        dtProductos = Nothing
    End Sub

    Sub getFamilia(id As String)
        Dim dt As New DataTable
        dt = contProducto.consultar("SELECT IDENTIFICADOR, DESCRIPCION FROM PR_LINEAS_PROD WHERE IDENTIFICADOR=" & id)
        If dt.Rows.Count > 0 Then
            idFamilia = CInt(dt.Rows(0).Item(0))
            txtFamilia.Text = CStr(dt.Rows(0).Item(1))
        End If
    End Sub

    Sub consultar()
        Dim familia As String = ""
        If txtFamilia.Text IsNot "" Then
            familia = " AND PR.ID_LINEA=" & idFamilia.ToString
        End If

        dtProductos = contProducto.consultar("SELECT * FROM(
                                               SELECT PR.IDENTIFICADOR, PR.CODIGO, LPAD(PR.CODIGO_BARRAS, 13, '0') AS CODIGO_BARRAS, PR.DESCRIPCION, 
                                               COALESCE(PR.PRECIO_VENTA, 0) AS PRECIO_VENTA,
                                               ROUND(COALESCE(((PR_UM_PRODUCTO.COSTO_REMPLAZO * FND_TIPOS_IMPUESTO.VALOR) / 100) ,0)) + ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO) AS COSTO_UNITARIO,
                                               (SELECT MAX(FEC_CRE) FROM CP_ITEMS_COMPROB WHERE ID_PRODUCTO=PR.IDENTIFICADOR)AS ULTIMA_COMPRA,
                                               (SELECT MAX(FEC_CRE) FROM VTA_ITEMS_COMPROB WHERE ID_PRODUCTO=PR.IDENTIFICADOR)AS ULTIMA_VENTA,
                                               'N' AS EXISTE
                                               FROM PR_PRODUCTOS PR
                                               LEFT JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                                               LEFT JOIN FND_TIPOS_IMPUESTO ON FND_TIPOS_IMPUESTO.IDENTIFICADOR = PR.ID_TIPO_IMPUESTO
                                               WHERE PR.ACTIVO = 'S' " & familia & "
                                             ) ORDER BY ULTIMA_VENTA DESC")

        If dtProductos.Rows.Count > 0 Then
            gridProductos.DataSource = dtProductos
        Else
            ControlMensajes.mensaje("No se registraron productos para la familia", titulo, "WAR")
        End If
    End Sub

    Public Sub getProductos(codigo As String)
        If dtProductos.Rows.Count > 0 Then
            Dim dr() As DataRow
            dr = dtProductos.Select("CODIGO_BARRAS = '" & codigo & "'")

            If dr.Length > 0 Then
                dr(0)("EXISTE") = "S"
            Else
                noDefinidos.Add(codigo)
            End If
        End If
    End Sub

    Private Sub txtFamilia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFamilia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFamilia.Text IsNot "" Then
                btnConsultar.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("LP")
        End If
    End Sub

    Private Sub btnBuscarFamilia_Click(sender As Object, e As EventArgs) Handles btnBuscarFamilia.Click
        vistas("LP")
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        gridProductos.DataSource = Nothing
        dtProductos = Nothing
        consultar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim frm As New FrmAgregarProductosFamilia
        frm.ShowDialog()
    End Sub

    Private Sub btnNoDefinidos_Click(sender As Object, e As EventArgs) Handles btnNoDefinidos.Click
        Dim str As String = 0
        Dim frm As New FrmProductosFamiliaInexistente

        For Each str In noDefinidos
            frm.addProducto(str)
        Next
        frm.ShowDialog()
    End Sub

End Class