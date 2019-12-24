Public Class FrmTraspasoProductosSuc

    Dim titulo As String = "Traspaso"
    Dim dtItems As New DataTable
    Dim contAppTraspasoProductosSuc As New ContAppTraspasoProductosSuc

    Dim idAlmOrigen As Integer = 0
    Dim idAlmDestino As Integer = 0
    Dim idRemision As Integer = 0

    Dim productosNoDef As New List(Of String)

    Private Sub FrmTraspasoProductosSuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cldFecha.Visible = False
        crearCursor()
        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = 0
    End Sub

    Sub limpiar()
        idAlmOrigen = 0
        idAlmDestino = 0
        idRemision = 0
        txtOrigen.Text = ""
        txtDestino.Text = ""
        txtFecha.Text = ""
        txtComentario.Text = ""

        dtItems = Nothing
        gridItems.DataSource = dtItems

        cldFecha.Visible = False
        crearCursor()
        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = 0
        productosNoDef.Clear()
    End Sub

    Sub crearCursor()
        dtItems = New DataTable
        dtItems.Columns.Add("ID_PRODUCTO")
        dtItems.Columns.Add("CODIGO_BARRAS")
        dtItems.Columns.Add("ID_PROVEEDOR")
        dtItems.Columns.Add("ID_UND_MEDIDA")
        dtItems.Columns.Add("ID_LINEA")
        dtItems.Columns.Add("DESCRIPCION")
        dtItems.Columns.Add("CANTIDAD", GetType(Double))
        dtItems.Columns.Add("COSTO_UNITARIO")
        dtItems.Columns.Add("PRECIO_VENTA")

        gridItems.DataSource = dtItems
    End Sub

    Sub vistas(verificador As String)
        If verificador = "ALD" Then
            Dim frm As New FrmVistaStkAlmacenes
            frm.seFrmTraspasoProductosSuc(Me, "FrmTraspasoProductosSucALD")
            frm.ShowDialog()
        End If

        If verificador = "ALO" Then
            Dim frm As New FrmVistaStkAlmacenes
            frm.seFrmTraspasoProductosSuc(Me, "FrmTraspasoProductosSucALO")
            frm.ShowDialog()
        End If

        If verificador = "FE" Then
            If cldFecha.Visible = True Then
                cldFecha.Visible = False
            Else
                cldFecha.Visible = True
                cldFecha.Focus()
            End If
        End If

        If verificador = "PR" Then
            Dim frm As New FrmVistaPrProductos
            frm.setFrmActivo("FrmTraspasoProductosSuc")
            frm.setFrmTraspasoProductosSuc(Me)
            frm.ShowDialog()
        End If
    End Sub

    Public Sub getAlmacen(id As String, verificador As String)
        Dim dt As New DataTable
        dt = contAppTraspasoProductosSuc.consultar("Select IDENTIFICADOR, DESCRIPCION FROM STK_ALMACENES WHERE IDENTIFICADOR=" & id)

        If dt.Rows.Count > 0 Then
            If verificador = "FrmTraspasoProductosSucALO" Then
                idAlmOrigen = CInt(dt.Rows(0).Item(0))
                txtOrigen.Text = CStr(dt.Rows(0).Item(1))
                txtOrigen.Focus()
            End If
            If verificador = "FrmTraspasoProductosSucALD" Then
                idAlmDestino = CInt(dt.Rows(0).Item(0))
                txtDestino.Text = CStr(dt.Rows(0).Item(1))
                txtDestino.Focus()
            End If

        Else
            ControlMensajes.mensaje("ALMACEN no DEFINIDO", titulo, "WAR")
        End If
    End Sub

    Public Sub getProducto(codigo As String)
        Dim dt As New DataTable
        dt = contAppTraspasoProductosSuc.consultar("SELECT COALESCE(PR.IDENTIFICADOR ,0), COALESCE(PR.CODIGO_BARRAS ,'-'), COALESCE(PR.ID_PROVEEDOR ,0), 
                                            COALESCE(PR.ID_UNIDAD_MEDIDA ,0), COALESCE(PR.ID_LINEA ,0),
                                            COALESCE(PR.DESCRIPCION ,'-'), COALESCE(PR.PRECIO_VENTA ,0), COALESCE(ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO, 0) ,0)
                                            FROM PR_PRODUCTOS PR
                                            INNER JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                                            WHERE CODIGO_BARRAS= '" & codigo & "'")

        If dt.Rows.Count > 0 Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle >= 0 Then
                GridView1.SetRowCellValue(rowhandle, "ID_PRODUCTO", dt.Rows(0).Item(0))
                GridView1.SetRowCellValue(rowhandle, "CODIGO_BARRAS", dt.Rows(0).Item(1))
                GridView1.SetRowCellValue(rowhandle, "ID_PROVEEDOR", dt.Rows(0).Item(2))
                GridView1.SetRowCellValue(rowhandle, "ID_UND_MEDIDA", dt.Rows(0).Item(3))
                GridView1.SetRowCellValue(rowhandle, "ID_LINEA", dt.Rows(0).Item(4))
                GridView1.SetRowCellValue(rowhandle, "DESCRIPCION", dt.Rows(0).Item(5))
                GridView1.SetRowCellValue(rowhandle, "PRECIO_VENTA", dt.Rows(0).Item(6))
                GridView1.SetRowCellValue(rowhandle, "COSTO_UNITARIO", dt.Rows(0).Item(7))
                GridView1.SetRowCellValue(rowhandle, "CANTIDAD", 0)

                GridView1.FocusedColumn = GridView1.Columns("DESCRIPCION")

            End If
        Else
            ControlMensajes.mensaje("Producto no definido", titulo, "WAR")
        End If
    End Sub

    Function validarCampos() As Boolean
        If idAlmOrigen <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar almacen de origen", titulo, "WAR")
            txtOrigen.Focus()
            Return False
        End If
        If idAlmDestino <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar almacen de destino", titulo, "WAR")
            txtDestino.Focus()
            Return False
        End If
        If txtFecha.Text = "  /  /" Then
            ControlMensajes.mensaje("El campo fecha no puede estar vacio", titulo, "WAR")
            txtFecha.Focus()
            Return False
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe agregar items a la transaccion", titulo, "WAR")
            txtFecha.Focus()
            Return False
        End If

        For i As Integer = 0 To GridView1.RowCount - 1
            Dim idItem As Integer = contAppTraspasoProductosSuc.getIdItemRemision()
            Dim cantidad As Double = CDbl(GridView1.GetRowCellValue(i, "CANTIDAD"))

            If cantidad <= 0 Then
                ControlMensajes.mensaje("Cantidad debe ser mayor a cero(0)", titulo, "WAR")
                Return False
            End If
        Next

        Return True
    End Function

    Sub generarRemision()
        If validarCampos() Then

            If ControlMensajes.msj_confirmacion("Deseas confirmar la operacion", titulo) = False Then
                ControlMensajes.mensaje("Operacion no confirmada", titulo, "INF")
            End If

            Dim fecha As Date = txtFecha.Text
            idRemision = contAppTraspasoProductosSuc.getIdRemision()

            If contAppTraspasoProductosSuc.insertar_remision(idRemision, fecha, idAlmOrigen, idAlmDestino) Then

                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim idItem As Integer = contAppTraspasoProductosSuc.getIdItemRemision()
                    Dim idProducto As Integer = CInt(GridView1.GetRowCellValue(i, "ID_PRODUCTO"))
                    Dim codigoBarras As String = CStr(GridView1.GetRowCellValue(i, "CODIGO_BARRAS"))
                    Dim idProveedor As Integer = CInt(GridView1.GetRowCellValue(i, "ID_PROVEEDOR"))
                    Dim idUndMedida As Integer = CInt(GridView1.GetRowCellValue(i, "ID_UND_MEDIDA"))
                    Dim idLinea As Integer = CInt(GridView1.GetRowCellValue(i, "ID_LINEA"))
                    Dim cantidad As Double = CDbl(GridView1.GetRowCellValue(i, "CANTIDAD"))
                    Dim precioVenta As Integer = CInt(GridView1.GetRowCellValue(i, "PRECIO_VENTA"))
                    Dim costoUnitario As Integer = CInt(GridView1.GetRowCellValue(i, "COSTO_UNITARIO"))

                    If contAppTraspasoProductosSuc.insertar_items(idItem, idRemision, idProducto, codigoBarras, idProveedor, idUndMedida, idLinea, cantidad, precioVenta, costoUnitario) = False Then
                        ControlMensajes.mensaje("Item de transaccion no registrada" & CStr(i + 1), titulo, "WAR")
                        Return
                    End If
                Next


                ControlMensajes.mensaje("Transaccion registrada", titulo, "INF")
                limpiar()
                txtOrigen.Focus()
            Else
                    ControlMensajes.mensaje("Transaccion no registrada", titulo, "WAR")
            End If


        End If
    End Sub

    Private Sub eliminar_filas_vacias()
        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "ID_PRODUCTO")) Then
                GridView1.DeleteRow(i)
            Else
                If CStr(GridView1.GetRowCellValue(i, "ID_PRODUCTO")) = "" Then
                    GridView1.DeleteRow(i)
                End If
            End If
        Next
    End Sub

    Public Sub addProducto(codigoBarras As String)
        eliminar_filas_vacias()

        Dim cantidad As String = CDbl(getCantidad(codigoBarras))
        codigoBarras = getCodigoBarras(codigoBarras)

        If codigoBarras.Replace(" ", "") = "" Then
            Return
        End If

        If GridView1.RowCount <= 0 Then
            crearCursor()
        End If

        Dim dt As New DataTable
        dt = contAppTraspasoProductosSuc.consultar("SELECT COALESCE(PR.IDENTIFICADOR ,0), COALESCE(PR.CODIGO_BARRAS ,'-'), COALESCE(PR.ID_PROVEEDOR ,0), 
                                            COALESCE(PR.ID_UNIDAD_MEDIDA ,0), COALESCE(PR.ID_LINEA ,0),
                                            COALESCE(PR.DESCRIPCION ,'-'), COALESCE(PR.PRECIO_VENTA ,0), COALESCE(ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO, 0) ,0)
                                            FROM PR_PRODUCTOS PR
                                            INNER JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR.IDENTIFICADOR
                                            WHERE CODIGO_BARRAS= '" & codigoBarras & "'")


        If dt.Rows.Count > 0 Then
            Dim newRow As DataRow = (TryCast(gridItems.DataSource, DataTable)).NewRow()

            newRow("ID_PRODUCTO") = dt.Rows(0).Item(0)
            newRow("CODIGO_BARRAS") = dt.Rows(0).Item(1)
            newRow("ID_PROVEEDOR") = dt.Rows(0).Item(2)
            newRow("ID_UND_MEDIDA") = dt.Rows(0).Item(3)
            newRow("ID_LINEA") = dt.Rows(0).Item(4)
            newRow("DESCRIPCION") = dt.Rows(0).Item(5)
            newRow("PRECIO_VENTA") = dt.Rows(0).Item(6)
            newRow("COSTO_UNITARIO") = dt.Rows(0).Item(7)
            newRow("CANTIDAD") = CStr(cantidad)

            TryCast(gridItems.DataSource, DataTable).Rows.Add(newRow)
            gridItems.RefreshDataSource()


        Else
            productosNoDef.Add(codigoBarras)
        End If

        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = GridView1.RowCount - 1
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
    End Sub

    Function getCodigoBarras(codigo As String) As String
        Try
            Dim vector As String() = codigo.Split(",")
            Return vector(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function getCantidad(codigo) As String
        Try
            Dim vector As String() = codigo.Split(",")
            Return CStr(vector(1))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub txtOrigen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrigen.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtOrigen.Text IsNot "" Then
                txtDestino.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("ALO")
        End If
    End Sub

    Private Sub btnOrigen_Click(sender As Object, e As EventArgs) Handles btnOrigen.Click
        vistas("ALO")
    End Sub

    Private Sub txtDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDestino.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDestino.Text IsNot "" Then
                txtFecha .Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("ALD")
        End If
    End Sub

    Private Sub btnDestino_Click(sender As Object, e As EventArgs) Handles btnDestino.Click
        vistas("ALD")
    End Sub


    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFecha.Text = "  /  /" Then
            Else
                txtComentario.Focus()
            End If
        End If
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            vistas("FE")
        End If
    End Sub


    Private Sub btnFechaDesde_Click(sender As Object, e As EventArgs) Handles btnFechaDesde.Click
        vistas("FE")
    End Sub

    Private Sub cldFecha_DoubleClick(sender As Object, e As EventArgs) Handles cldFecha.DoubleClick
        txtFecha.Text = cldFecha.DateTime.ToString
        txtFecha.Focus()
        vistas("FE")
    End Sub

    Private Sub cldFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles cldFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFecha.Text = cldFecha.DateTime.ToString
            txtFecha.Focus()
            vistas("FE")
        End If
        If e.KeyCode = Keys.Escape Then
            vistas("FE")
        End If
    End Sub

    Private Sub txtComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtComentario.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.Focus()
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            SendKeys.Send("{Enter}")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        eliminar_filas_vacias()
        generarRemision()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If ControlMensajes.msj_confirmacion("Deseas cancelar la operacion", titulo) Then
            limpiar()
        Else
            ControlMensajes.mensaje("Operacion no cancelada", titulo, "INF")
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If ControlMensajes.msj_confirmacion("Deseas quietar el item", titulo) Then
            Dim rowhandle As Integer = GridView1.FocusedRowHandle
            If rowhandle < 0 Then
                ControlMensajes.mensaje("Debe seleccionar un item para quitar", titulo, "WAR")
            Else
                GridView1.DeleteRow(rowhandle)
            End If
        End If
    End Sub

    Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) Then
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO") IsNot "" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                Else
                    If CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) > 0 Then
                        GridView1.FocusedColumn = GridView1.VisibleColumns(1)
                    End If
                End If
            End If

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS")) Then
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS") IsNot "" Then
                    getProducto(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CODIGO_BARRAS"))
                End If
            End If
        End If
        If e.KeyCode = Keys.F9 Or e.KeyCode = Keys.Space Then
            vistas("PR")
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(2)
            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DESCRIPCION")) Then
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DESCRIPCION") IsNot "" Then
                    GridView1.FocusedColumn = GridView1.VisibleColumns(2)
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.FocusedColumn = GridView1.VisibleColumns(4)
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) Then
                ControlMensajes.mensaje("Debe selecciconar un producto", titulo, "WAR")
                Return
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO") = "" Then
                    ControlMensajes.mensaje("Debe selecciconar un producto", titulo, "WAR")
                    Return
                Else
                    If CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID_PRODUCTO")) <= 0 Then
                        ControlMensajes.mensaje("Debe selecciconar un producto", titulo, "WAR")
                        Return
                    End If
                End If
            End If

            If IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CANTIDAD")) Then
                ControlMensajes.mensaje("cantidad debe ser mayor a cero(0)", titulo, "WAR")
                Return
            Else
                If CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CANTIDAD")) = "" Then
                    ControlMensajes.mensaje("cantidad debe ser mayor a cero(0)", titulo, "WAR")
                    Return
                Else
                    If CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CANTIDAD")) <= 0 Then
                        ControlMensajes.mensaje("cantidad debe ser mayor a cero(0)", titulo, "WAR")
                        Return
                    End If
                End If
            End If


            eliminar_filas_vacias()
            GridView1.AddNewRow()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            SendKeys.Send("{Enter}")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        eliminar_filas_vacias()
        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = GridView1.RowCount - 1
        GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub btnCargaRapida_Click(sender As Object, e As EventArgs) Handles btnCargaRapida.Click
        Dim frm As New FrmCargaRapidaProd
        frm.setFrmActivo("FrmTraspasoProductosSuc")
        frm.setFrmTraspasoProductosSuc(Me)
        frm.ShowDialog()
    End Sub

    Private Sub btnNoDefinidos_Click(sender As Object, e As EventArgs) Handles btnNoDefinidos.Click
        Dim frm As New FrmCargaRapidaProdNoDef
        frm.setNoDefinidos(productosNoDef)
        frm.ShowDialog()
    End Sub
End Class