Public Class FrmTomaInventarioGestion

    Dim contStkMovimStock As New ContStkMovimStock
    Dim contStkStockProd As New ContStkStockProd

    Dim identificador As Integer = 0
    Dim idAlmacen As Integer = 0
    Dim idSitio As Integer = 0
    Dim idUnidad As Integer = 0
    Dim idEmpresa As Integer = 0
    Dim idTransIngreso As Integer = 0
    Dim idTransEgreso As Integer = 0

    Private Sub FrmTomaInventarioGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub limpiar()
        identificador = 0
        idAlmacen = 0
        idSitio = 0
        idUnidad = 0
        idEmpresa = 0
        idTransIngreso = 0
        idTransEgreso = 0

        txtNumero.Text = ""
        txtSucursal.Text = ""
        txtComentario.Text = ""
        txtFecha.Text = ""
        txtApuntador.Text = ""

        gridItems.DataSource = Nothing
    End Sub

    Sub listarTomaInventario()
        Dim frm As New FrmVistaAppTomaInventario
        frm.setFrmActivo("FrmTomaInventarioGestion")
        frm.setFrmTomaInventarioGestion(Me)
        frm.ShowDialog()
    End Sub

    Sub getTomaInventario(id As Integer)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("SELECT TI.NUMERO, FND_SITIOS.DESCRIPCION, COALESCE(TI.DESCRIPCION, ' '), TI.FECHA, TI.APUNTADOR, 
                                    TI.IDENTIFICADOR, TI.ID_SUCURSAL
                                    FROM APP_TOMA_INVENTARIO TI
                                    INNER JOIN FND_SITIOS ON FND_SITIOS.IDENTIFICADOR = TI.ID_SUCURSAL
                                    WHERE TI.IDENTIFICADOR= " & CStr(id))

        If dt.Rows.Count > 0 Then
            txtNumero.Text = CStr(dt.Rows(0).Item(0))
            txtSucursal.Text = CStr(dt.Rows(0).Item(1))
            txtComentario.Text = CStr(dt.Rows(0).Item(2))
            txtFecha.Text = CStr(dt.Rows(0).Item(3))
            txtApuntador.Text = CStr(dt.Rows(0).Item(4))
            identificador = CInt(dt.Rows(0).Item(5))
            idSitio = CInt(dt.Rows(0).Item(6))

            parametrosEmpresa(idSitio)
            getParametrosStock(idSitio)
            getItemsInventario(identificador)
        End If

    End Sub

    Sub getItemsInventario(id As Integer)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("SELECT PR_PRODUCTOS.IDENTIFICADOR, PR_PRODUCTOS.CODIGO_BARRAS, PR_PRODUCTOS.DESCRIPCION, 
                                        IT.CANTIDAD, STK_STOCK_PROD.EXISTENCIA, (IT.CANTIDAD - STK_STOCK_PROD.EXISTENCIA) AS DIFERENCIA,
                                        PR_PRODUCTOS.ID_UNIDAD_MEDIDA AS ID_UND_MEDIDA, COALESCE(ROUND(PR_UM_PRODUCTO.COSTO_REMPLAZO), 0) AS COSTO_UNITARIO, 
                                        COALESCE(ROUND(PR_PRODUCTOS.PRECIO_VENTA), 0) AS PRECIO_UNITARIO
                                        FROM APP_TOMA_INV_ITEMS IT
                                        INNER JOIN PR_PRODUCTOS ON PR_PRODUCTOS.IDENTIFICADOR = IT.ID_PRODUCTO
                                        INNER JOIN PR_UM_PRODUCTO ON PR_UM_PRODUCTO.ID_PRODUCTO = PR_PRODUCTOS.IDENTIFICADOR
                                        INNER JOIN STK_STOCK_PROD ON STK_STOCK_PROD.ID_PRODUCTO = PR_PRODUCTOS.IDENTIFICADOR
                                        WHERE ID_TOMA_INV=" & CStr(id) & " AND STK_STOCK_PROD.ID_ALMACEN= " & CStr(idAlmacen) &
                                        "ORDER BY (IT.CANTIDAD - STK_STOCK_PROD.EXISTENCIA) ASC")

        If dt.Rows.Count > 0 Then
            gridItems.DataSource = dt
        End If
    End Sub

    Sub parametrosEmpresa(id As Integer)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("SELECT ID_EMPRESA, ID_UNIDAD FROM FND_SITIOS WHERE IDENTIFICADOR=" & CStr(id))

        If dt.Rows.Count > 0 Then
            idEmpresa = CInt(dt.Rows(0).Item(0))
            idUnidad = CInt(dt.Rows(0).Item(1))
        Else
            ControlMensajes.mensaje("Parametros de empresa no definidos", "", "WAR")
        End If
    End Sub

    Sub getParametrosStock(sucursal As Integer)
        Dim dt As New DataTable
        dt = contStkMovimStock.consultar("SELECT ID_ALMACEN_REC, ID_TRANS_EGR_INV, ID_TRANS_ING_INV FROM STK_PARAMETROS WHERE ID_SITIO=" & CStr(sucursal))

        If dt.Rows.Count > 0 Then
            idAlmacen = CInt(dt.Rows(0).Item(0))
            idTransEgreso = CInt(dt.Rows(0).Item(1))
            idTransIngreso = CInt(dt.Rows(0).Item(2))
        Else
            ControlMensajes.mensaje("Parametros de stock no definido", "", "WAR")
        End If
    End Sub

    Sub insertarMovimientostock()
        Dim idMovimiento As Integer = contStkMovimStock.idMovimStock
        Dim transaccion As Integer = 0
        Dim accion As String = ""
        Dim ingreso As Boolean = False
        Dim egreso As Boolean = False

        Dim idItemsTransaccion As Integer = 0
        Dim id_producto As Integer = 0
        Dim id_und_medida As Integer = 0
        Dim cantidad As Double = 0
        Dim precio_unitario As Integer = 0
        Dim costo_unitario As Integer = 0
        Dim codigo_barra As String = 0
        Dim existencia As Double = 0

        Dim diferencia As Double = 0

        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "DIFERENCIA")) Then
                diferencia = 0
            Else
                diferencia = CDbl(GridView1.GetRowCellValue(i, "DIFERENCIA"))
            End If


            idItemsTransaccion = contStkMovimStock.idItemMovimStock()
            id_producto = GridView1.GetRowCellValue(i, "IDENTIFICADOR")
            id_und_medida = GridView1.GetRowCellValue(i, "ID_UND_MEDIDA")
            cantidad = GridView1.GetRowCellValue(i, "DIFERENCIA")
            precio_unitario = GridView1.GetRowCellValue(i, "PRECIO_UNITARIO")
            costo_unitario = GridView1.GetRowCellValue(i, "COSTO_UNITARIO")
            codigo_barra = GridView1.GetRowCellValue(i, "CODIGO_BARRAS")
            existencia = GridView1.GetRowCellValue(i, "EXISTENCIA")


            If diferencia >= 0 And egreso = False Then
                If contStkMovimStock.insertarMovimStock(idMovimiento, idEmpresa, idUnidad, txtFecha.Text, "00", idSitio, FrmMenuPrincipal.USUARIO, FrmMenuPrincipal.USUARIO, "0", "ST", idTransIngreso, "N", txtComentario.Text) = False Then
                    ControlMensajes.mensaje("Movimiento de stock no registrado", "", "WAR")
                    Return
                End If
                transaccion = idTransEgreso
                accion = "EG"
                egreso = False
            End If

            If diferencia < 0 And ingreso = False Then
                If contStkMovimStock.insertarMovimStock(idMovimiento, idEmpresa, idUnidad, txtFecha.Text, "00", idSitio, FrmMenuPrincipal.USUARIO, FrmMenuPrincipal.USUARIO, "0", "ST", idTransEgreso, "N", txtComentario.Text) = False Then
                    ControlMensajes.mensaje("Movimiento de stock no registrado", "", "WAR")
                    Return
                End If
                transaccion = idTransIngreso
                accion = "IN"
                ingreso = True
            End If

            If contStkMovimStock.insertarItemsMovimStock(idItemsTransaccion, idMovimiento, idEmpresa, idUnidad, transaccion, idAlmacen, accion, id_producto, id_und_medida, cantidad, cantidad, precio_unitario, costo_unitario, precio_unitario, costo_unitario, codigo_barra, txtFecha.Text) = False Then
                ControlMensajes.mensaje("Item de stock no registrado: " & CStr(i), "", "WAR")
                Return
            End If

            If contStkStockProd.actualizarExistencia(diferencia, id_producto, idAlmacen, accion) = False Then
                ControlMensajes.mensaje("Existencia no actualizada " & CStr(i), "", "WAR")
            End If
        Next

        ControlMensajes.mensaje("Transaccion realizada", "", "INF")
        limpiar()

    End Sub

    Sub aceptar()
        If identificador <= 0 Then
            ControlMensajes.mensaje("Debe seleccionar toma de inventario", "", "WAR")
            txtNumero.Focus()
            Return
        End If
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("Debe agregar items a la transaccion", "", "WAR")
            txtNumero.Focus()
            Return
        End If
        If ControlMensajes.msj_confirmacion("Confirmar transaccion?", "") = False Then
            ControlMensajes.mensaje("Transaccion no confirmada", "", "WAR")
            txtNumero.Focus()
            Return
        End If



        insertarMovimientostock()
    End Sub

    Sub cancelar()
        If ControlMensajes.msj_confirmacion("Cancelar transaccion?", "") Then
            limpiar()
            txtNumero.Focus()
        End If
    End Sub

    Private Sub txtNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.F9 Then
            listarTomaInventario()
        End If
    End Sub

    Private Sub btnTomaInventario_Click(sender As Object, e As EventArgs) Handles btnTomaInventario.Click
        listarTomaInventario()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        aceptar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub
End Class