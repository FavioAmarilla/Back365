Imports DevExpress.XtraEditors
Imports Oracle.DataAccess.Client

Public Class frm_transacciones_inventario

    Dim controlador As New ContReportes

    Dim dt_productos As New DataTable
    Dim dt_precio_pr As New DataTable
    Public dt_cursor As New DataTable
    Public dt_sucursal As New DataTable
    Public dt_deposito As New DataTable
    Public dt_deposito_destino As New DataTable
    Public dt_transaccion As New DataTable
    Public dt_items_transacciones As New DataTable
    Public dt_transacciones_contrpda As New DataTable
    Public dt_existencias As New DataTable
    Public dt_existencias_des As New DataTable

    Dim id_deposito As Integer
    Dim id_deposito_destino As Integer
    Dim id_sucursales As Integer
    Dim id_transacciones As Integer
    Dim id_trans_contpda As Integer
    Dim accion_items As String
    Dim accion_items_contpda As String
    Dim transaccion As Integer
    Dim vr_accion_contrapd As Integer
    Dim existencias As Integer = 0
    Dim id_producto As Integer
    Dim id_movimiento As Integer
    Dim contrapartida As Boolean
    Dim reg_exist As Boolean
    Dim fecha_act As String

    Dim conexion As New Conexion


    Sub consulta_dt_depositos()

        dt_deposito = controlador.consultar("select t.identificador, t.descripcion from stk_almacenes t")

        For Each row As DataRow In dt_deposito.Rows
            ComboBoxEdit3.Properties.Items.Add(row("descripcion"))
        Next
    End Sub

    Sub consulta_dt_sucursales()
        dt_sucursal = controlador.consultar("select t.identificador,t.descripcion from fnd_sitios t")

        For Each row As DataRow In dt_sucursal.Rows
            ComboBoxEdit1.Properties.Items.Add(row("descripcion"))
        Next
    End Sub

    Sub consulta_dt_transacciones()
        dt_transaccion = controlador.consultar("select identificador,nombre,coalesce(id_trans_contpda,0), vr_accion from stk_transacciones where vr_origen_trans='ST' AND ACTIVO = 'S'")

        For Each row As DataRow In dt_transaccion.Rows
            ComboBoxEdit2.Properties.Items.Add(row("nombre"))
        Next
    End Sub

    Sub consulta_dt_deposito2()
        dt_deposito_destino = controlador.consultar("select t.identificador,t.descripcion from stk_almacenes t")

        For Each row As DataRow In dt_deposito_destino.Rows
            ComboBoxEdit4.Properties.Items.Add(row("descripcion"))
        Next
    End Sub

    Sub listarProductos()
        Dim frm As New FrmVistaPrProductos
        frm.setFrm_transacciones_inventario(Me)
        frm.setFrmActivo("frm_transacciones_inventario")
        frm.ShowDialog()
    End Sub

    Private Sub frm_transacciones_inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ocultar_columnas()
        fecha()
        consulta_dt_depositos()
        consulta_dt_sucursales()
        consulta_dt_transacciones()
        consulta_dt_deposito2()
        crea_cursor()

        eliminar_filas_filas_vacias()
        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = 0
    End Sub

    '==================================================================================================================================
    '==================================================================================================================================

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MaskedTextBox1.Text = "" Then
                XtraMessageBox.AllowCustomLookAndFeel = True
                XtraMessageBox.Show("INGRESE LA FECHA", "ATENCION", DevExpress.Utils.DefaultBoolean.Default)
                MaskedTextBox1.Focus()
                Return
            Else
                ComboBoxEdit1.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        End If
    End Sub

    Private Sub ComboBoxEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEdit1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        End If
    End Sub

    Private Sub ComboBoxEdit2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEdit2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        End If
    End Sub

    Private Sub ComboBoxEdit3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEdit3.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        End If
    End Sub

    Private Sub ComboBoxEdit4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEdit4.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        End If
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS QUITAR EL PRODUCTO DE LA LISTA?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                'eliminar_filas()
            Else
                'do something if not
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS GUARDAR LA TRANSACCION?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                SimpleButton1.Enabled = True
                SimpleButton1.Focus()
                SendKeys.Send("{ENTER}")
            Else
                'do something if not
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            listarProductos()
        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedValueChanged
        Dim index As Integer
        index = ComboBoxEdit1.SelectedIndex
        If ComboBoxEdit1.SelectedIndex = -1 Then
            Return
        Else
            id_sucursales = dt_sucursal.Rows(index).Item(0).ToString
        End If
    End Sub

    Private Sub ComboBoxEdit2_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit2.SelectedValueChanged
        Dim index As Integer
        index = ComboBoxEdit2.SelectedIndex
        If ComboBoxEdit2.SelectedIndex = -1 Then
            Return
        Else
            id_transacciones = dt_transaccion.Rows(index).Item(0).ToString
            id_trans_contpda = dt_transaccion.Rows(index).Item(2)
            accion_items = dt_transaccion.Rows(index).Item(3)

            If id_trans_contpda > 0 Then
                ComboBoxEdit4.Enabled = True
                contrapartida = True
                'OBTENEMOS LA ACCION QUE SE REALIZARA PARA LA CONTRAPARTIDA
                dt_transacciones_contrpda = controlador.consultar("select identificador,nombre,coalesce(id_trans_contpda,0), vr_accion from stk_transacciones where identificador = " & id_trans_contpda & " ")


                'GUARDAMOS LA ACCIÓN EN LA VARIABLE
                accion_items_contpda = dt_transacciones_contrpda.Rows(0).Item(3).ToString
                ' MsgBox(accion_items_contpda)

            Else
                ComboBoxEdit4.Enabled = False
                id_deposito_destino = 0
                ComboBoxEdit4.SelectedIndex = -1
                contrapartida = False
            End If
        End If
    End Sub

    Private Sub ComboBoxEdit3_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit3.SelectedValueChanged
        Dim index As Integer
        index = ComboBoxEdit3.SelectedIndex
        If ComboBoxEdit3.SelectedIndex = -1 Then
            Return
        Else
            id_deposito = dt_deposito.Rows(index).Item(0).ToString
        End If
    End Sub

    Private Sub ComboBoxEdit4_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit4.SelectedValueChanged
        Dim index As Integer
        index = ComboBoxEdit4.SelectedIndex
        If ComboBoxEdit4.SelectedIndex = -1 Then
            Return
        Else
            id_deposito_destino = dt_deposito_destino.Rows(index).Item(0).ToString
            If id_deposito = id_deposito_destino Then
                ComboBoxEdit4.SelectedIndex = -1
                MsgBox("DEPOSITO DE DESTINO NO PUEDE SER IGUAL AL ORIGEN")
                Return
            End If
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        End If
    End Sub

    '==================================================================================================================================
    '==================================================================================================================================
    Private Sub ComboBoxEdit1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBoxEdit1.Validating
        If ComboBoxEdit1.SelectedIndex = -1 Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show("SELECCIONE UNA SUCURSAL", "ATENCION", DevExpress.Utils.DefaultBoolean.Default)
            ComboBoxEdit1.Focus()
            Return
        End If

    End Sub

    Private Sub ComboBoxEdit2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBoxEdit2.Validating
        If ComboBoxEdit2.SelectedIndex = -1 Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show("SELECCIONE TIPO DE TRANSACCION", "ATENCION", DevExpress.Utils.DefaultBoolean.Default)
            ComboBoxEdit2.Focus()
            Return
        Else
            ComboBoxEdit3.Focus()
        End If
    End Sub

    Private Sub ComboBoxEdit3_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBoxEdit3.Validating
        If ComboBoxEdit3.SelectedIndex = -1 Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show("SELECCIONE DEPOSITO DE ORIGEN", "ATENCION", DevExpress.Utils.DefaultBoolean.Default)
            ComboBoxEdit3.Focus()
            Return
        Else
            If ComboBoxEdit2.SelectedIndex = 4 Then
                If ComboBoxEdit3.SelectedIndex = 0 Then
                    ComboBoxEdit4.SelectedIndex = 1
                ElseIf ComboBoxEdit3.SelectedIndex = 1 Then
                    ComboBoxEdit4.SelectedIndex = 0
                End If

                GridView1.Focus()
                eliminar_filas_filas_vacias()
                GridView1.AddNewRow()
                GridView1.FocusedRowHandle = 0
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                SendKeys.Send("{ENTER}")
            End If
            Return
        End If
    End Sub

    Private Sub ComboBoxEdit4_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBoxEdit4.Validating
        If ComboBoxEdit4.SelectedIndex = -1 Then
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show("SELECCIONE DEPOSITO DE DESTINO", "ATENCION", DevExpress.Utils.DefaultBoolean.Default)
            ComboBoxEdit4.Focus()
            Return
        Else
            eliminar_filas_filas_vacias()
            GridView1.AddNewRow()
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        End If
    End Sub

    '==================================================================================================================================
    '==================================================================================================================================

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If GridView1.RowCount <= 0 Then
            ControlMensajes.mensaje("debe agregar items", "", "WAR")
            Return
        End If

        eliminar_filas_filas_vacias()

        Dim lc_id_empresa = 1
        Dim lc_id_unidad = id_sucursales  '' VERIFICAR SI CORRESPONDE A SUCURSAL EN LA BD
        Dim lc_vr_situacion As String = "00"
        Dim lc_id_sitio = id_sucursales
        Dim lc_usuario As String = "APPUSR"
        Dim lc_usr_cre As String = "APPUSR"
        Dim lc_vr_origen_trans = "ST"  'ST CORRESPONDE AL PROGRAMA ING-EGR MANUAL
        Dim lc_id_transaccion = id_transacciones
        Dim lc_reversado As String = "N"
        Dim lc_fecha As Date = MaskedTextBox1.Text.ToString

        conexion.conectar()
        Dim comand As New OracleCommand("APP_STK_MOVIM_STOCK", conexion.cnn)
        comand.CommandType = CommandType.StoredProcedure
        comand.Parameters.Add(":identificador", 0)
        comand.Parameters.Add(":id_empresa", lc_id_empresa)
        comand.Parameters.Add(":id_unidad", lc_id_unidad)
        comand.Parameters.Add(":fecha", lc_fecha)
        comand.Parameters.Add(":vr_situacion", lc_vr_situacion)
        comand.Parameters.Add(":id_sitio", lc_id_sitio)
        comand.Parameters.Add(":usuario", lc_usuario)
        comand.Parameters.Add(":usr_cre", lc_usr_cre)
        comand.Parameters.Add(":fec_cre", 0)
        comand.Parameters.Add(":numero", 0)
        comand.Parameters.Add(":vr_origen_trans", lc_vr_origen_trans)
        comand.Parameters.Add(":id_transaccion", lc_id_transaccion)
        comand.Parameters.Add(":reversado", lc_reversado)
        comand.ExecuteNonQuery()
        conexion.desconectar()


        Dim dt_secuencia_stock As New DataTable
        Dim lc_secuencia As String
        dt_secuencia_stock = controlador.consultar("select sq_app_stk_num.currval from dual")
        lc_secuencia = dt_secuencia_stock.Rows(0).Item(0).ToString

        XtraMessageBox.AllowCustomLookAndFeel = True
        XtraMessageBox.Show("REGISTRO EXITOSO," + Chr(13) + " EL NUMERO DE COMPROBANTE ES: " + Chr(13) + lc_secuencia, "PROCESO CORRECTO", DevExpress.Utils.DefaultBoolean.Default)


        Try
            Dim dt_stk_movimiento_stock As New DataTable
            dt_stk_movimiento_stock = controlador.consultar("select sq_stk_movim.currval from dual")
            id_movimiento = dt_stk_movimiento_stock.Rows(0).Item(0)
        Catch ex As Exception

        End Try

        insert_items()


        limpiar_variables()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        CalendarControl1.Visible = True
    End Sub

    Private Sub CalendarControl1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarControl1.DoubleClick
        Me.MaskedTextBox1.Text = CalendarControl1.DateTime
        CalendarControl1.Visible = False
    End Sub

    '==================================================================================================================================
    '==================================================================================================================================

    Sub crea_cursor()
        dt_cursor = New DataTable

        dt_cursor.Columns.Add("CODIGO", Type.GetType("System.String"))
        dt_cursor.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        dt_cursor.Columns.Add("UNIDAD", Type.GetType("System.String"))
        dt_cursor.Columns.Add("CANTIDAD", Type.GetType("System.Double"))
        dt_cursor.Columns.Add("IDPRODUCTO", Type.GetType("System.String"))
        dt_cursor.Columns.Add("IDUNIDAD", Type.GetType("System.String"))
        dt_cursor.Columns.Add("PRECIOUNITARIO", Type.GetType("System.String"))
        dt_cursor.Columns.Add("COSTOUNITARIO", Type.GetType("System.Double"))
        dt_cursor.Columns.Add("EXISTENCIA", Type.GetType("System.Double"))

        GridControl1.DataSource = dt_cursor
        GridControl1.Focus()

    End Sub

    Sub ocultar_columnas()
        GridView1.Columns(4).Visible = False
        GridView1.Columns(5).Visible = False
        GridView1.Columns(6).Visible = False
        GridView1.Columns(7).Visible = False
        GridView1.Columns(8).Visible = False
    End Sub

    Sub productos(ByVal codigo As String)

        Dim lcsql As String = "SELECT pr.descripcion, pr_unidades_medida.descripcion AS unidad, pr.identificador, pr.id_unidad_medida," &
        "round(pr_um_producto.costo_remplazo, 2) AS COSTO_UNITARIO, " &
        "round(pr_um_producto.precio_venta, 2) AS PRECIO_UNITARIO, pr.codigo_barras " &
        "FROM pr_productos  pr " &
        "LEFT JOIN fnd_tipos_impuesto on pr.id_tipo_impuesto = fnd_tipos_impuesto.identificador " &
        "LEFT JOIN pr_unidades_medida ON pr.id_unidad_medida = pr_unidades_medida.identificador " &
        "LEFT JOIN pr_um_producto on pr.identificador = pr_um_producto.id_producto " &
        "WHERE pr.codigo_barras = '" & codigo & "'"


        dt_productos = controlador.consultar(lcsql)


        If dt_productos.Rows.Count <> 0 Then
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "CODIGO", dt_productos.Rows(0).Item(6))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "CODIGOBARRAS", dt_productos.Rows(0).Item(6))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "DESCRIPCION", dt_productos.Rows(0).Item(0))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "UNIDAD", dt_productos.Rows(0).Item(1))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDPRODUCTO", dt_productos.Rows(0).Item(2))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDUNIDAD", dt_productos.Rows(0).Item(3))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "COSTOUNITARIO", dt_productos.Rows(0).Item(4))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "PRECIOUNITARIO", dt_productos.Rows(0).Item(5))

            id_producto = dt_productos.Rows(0).Item(2)
        Else

            lcsql = "SELECT pr.descripcion, pr_unidades_medida.descripcion AS unidad, pr.identificador, pr.id_unidad_medida," &
            "COALESCE(round(pr_um_producto.costo_remplazo, 2), 0) AS COSTO_UNITARIO, " &
            "COALESCE(round(pr_um_producto.precio_venta, 2), 0) AS PRECIO_UNITARIO, pr.codigo_barras " &
            "FROM pr_productos  pr " &
            "LEFT JOIN fnd_tipos_impuesto on pr.id_tipo_impuesto = fnd_tipos_impuesto.identificador " &
            "LEFT JOIN pr_unidades_medida ON pr.id_unidad_medida = pr_unidades_medida.identificador " &
            "LEFT JOIN pr_um_producto on pr.identificador = pr_um_producto.id_producto " &
            "WHERE pr.identificador = '" & codigo & "'"

            dt_productos = controlador.consultar(lcsql)


            If dt_productos.Rows.Count <> 0 Then
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "CODIGO", dt_productos.Rows(0).Item(6))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "CODIGOBARRAS", dt_productos.Rows(0).Item(6))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "DESCRIPCION", dt_productos.Rows(0).Item(0))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "UNIDAD", dt_productos.Rows(0).Item(1))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDPRODUCTO", dt_productos.Rows(0).Item(2))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDUNIDAD", dt_productos.Rows(0).Item(3))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "COSTOUNITARIO", dt_productos.Rows(0).Item(4))
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "PRECIOUNITARIO", dt_productos.Rows(0).Item(5))

                id_producto = dt_productos.Rows(0).Item(2)

            Else
                XtraMessageBox.AllowCustomLookAndFeel = True
                XtraMessageBox.Show("PRODUCTO NO ENCONTRADO", "VERIFIQUE CODIGO", DevExpress.Utils.DefaultBoolean.Default)
            End If
        End If

    End Sub

    Private Sub cantidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            'ENVIAMOS EL FOCO A LA COLUMNA CODIGO_BARRAS
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            'VOLVEMOS A ENVIAR EL FOCO A LA COLUMNA CANTIDAD 
            'PARA TOMAR LOS DATOS.. 
            GridView1.FocusedColumn = GridView1.VisibleColumns(3)

            'VALIDAMOS QUE SE HAYA INGRESADO UN PRODUCTO
            Dim rowhandle2 As Integer = Me.GridView1.FocusedRowHandle

            If IsDBNull(Me.GridView1.GetRowCellValue(rowhandle2, "CODIGO")) Then
                XtraMessageBox.AllowCustomLookAndFeel = True
                XtraMessageBox.Show("INGRESE PRODUCTO", "VERIFIQUE CODIGO ", DevExpress.Utils.DefaultBoolean.Default)
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            ElseIf IsDBNull(Me.GridView1.GetRowCellValue(rowhandle2, "DESCRIPCION")) Then
                XtraMessageBox.AllowCustomLookAndFeel = True
                XtraMessageBox.Show("INGRESE PRODUCTO", "VERIFIQUE DESCRIPCION ", DevExpress.Utils.DefaultBoolean.Default)
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            Else
                'VALIDAMOS SI NO SE INGRESA CANTIDAD
                'DEVOLVEMOS EL FOCO
                'CASO CONTRARIO  AGREGAMOS UNA NUEVA FILA
                Dim n As String
                n = GridView1.GetFocusedDisplayText()
                If n = "" Then
                    XtraMessageBox.AllowCustomLookAndFeel = True
                    XtraMessageBox.Show("INGRESE CANTIDAD", "VERIFIQUE CANTIDAD", DevExpress.Utils.DefaultBoolean.Default)
                Else

                    eliminar_filas_filas_vacias()
                    GridView1.AddNewRow()
                    GridView1.FocusedColumn = GridView1.VisibleColumns(0)
                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        End If
    End Sub

    Private Sub codigo_barras_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles codigo_barras.KeyDown
        If e.KeyCode = Keys.Enter Then

            GridView1.FocusedColumn = GridView1.VisibleColumns(1)
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)

            Dim codigo As String
            Dim rowhandle2 As Integer = Me.GridView1.FocusedRowHandle

            If IsDBNull(Me.GridView1.GetRowCellValue(rowhandle2, "CODIGO")) Then
                XtraMessageBox.AllowCustomLookAndFeel = True
                XtraMessageBox.Show("INGRESE CODIGO DE BARRAS", "VERIFIQUE CODIGO", DevExpress.Utils.DefaultBoolean.Default)
                Return
            End If
            codigo = Me.GridView1.GetRowCellValue(rowhandle2, "CODIGO")
            productos(codigo)


            If dt_productos.Rows.Count = 0 Then
                Return
            Else
                GridView1.FocusedColumn = GridView1.VisibleColumns(3)
            End If

        ElseIf e.KeyCode = Keys.Escape Then
            Dim result As DialogResult = XtraMessageBox.Show("¿DESEAS SALIR?", "¡CONFIRMACION!", MessageBoxButtons.YesNo)
            If result = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            Else
                'do something if not
            End If
        ElseIf e.KeyCode = Keys.F9
            listarProductos()
        End If
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        'eliminar_filas()
    End Sub

#Region "INSERTAR ITEMS"
    Sub insert_items()
        Try
            'For Each dataRow As DataRow In dt_cursor.Rows
            For j As Integer = 0 To GridView1.RowCount - 1

                Dim lc_identificador As Integer = 0
                Dim lc_id_movimiento As Integer = id_movimiento
                Dim lc_id_empresa As Integer = 1
                Dim lc_id_unidad As Integer = id_sucursales
                Dim lc_id_transaccion As Integer = id_transacciones
                Dim lc_id_almacen As Integer = id_deposito
                Dim lc_vr_accion As String = accion_items
                Dim lc_vr_accion_ctda As String = accion_items_contpda
                Dim lc_id_producto As Integer = GridView1.GetRowCellValue(j, "IDPRODUCTO")
                Dim lc_und_medida As Integer = GridView1.GetRowCellValue(j, "IDUNIDAD")
                Dim lc_cantidad As Double = GridView1.GetRowCellValue(j, "CANTIDAD")
                Dim lc_usr_cre As String = "APPUSR"
                Dim lc_fec_cre As Integer = 0
                Dim lc_cantidad_ub As Double = GridView1.GetRowCellValue(j, "CANTIDAD")
                Dim lc_precio_unitario As Integer = GridView1.GetRowCellValue(j, "PRECIOUNITARIO")
                Dim lc_costo_unitario As Integer = 0
                If IsDBNull(GridView1.GetRowCellValue(j, "COSTOUNITARIO")) Then
                    lc_costo_unitario = 0
                Else
                    lc_costo_unitario = GridView1.GetRowCellValue(j, "COSTOUNITARIO")
                End If
                Dim lc_codigo_barra As String = GridView1.GetRowCellValue(j, "CODIGOBARRA")
                Dim lc_id_estado As Integer = 0
                Dim lc_id_motivo As String = 0

                Dim x As Integer = 0
                If contrapartida = True Then
                    x = 2
                Else
                    x = 1
                End If

                For i = 1 To x

                    conexion.conectar()
                    Dim comand As New OracleCommand("APP_STK_ITEMS_MOVIM_STOCK", conexion.cnn)
                    comand.CommandType = CommandType.StoredProcedure

                    comand.Parameters.Add(":identificador", lc_identificador)
                    comand.Parameters.Add(":lc_id_movimiento", lc_id_movimiento)
                    comand.Parameters.Add(":lc_id_empresa", lc_id_empresa)
                    comand.Parameters.Add(":lc_id_unidad", lc_id_unidad)

                    If i = 1 Then
                        comand.Parameters.Add(":lc_id_transaccion", lc_id_transaccion)
                        comand.Parameters.Add(":lc_id_almacen", lc_id_almacen)
                        comand.Parameters.Add(":lc_vr_accion", lc_vr_accion)
                    Else
                        comand.Parameters.Add(":lc_id_transaccion", id_trans_contpda)
                        comand.Parameters.Add(":lc_id_almacen", id_deposito_destino)
                        comand.Parameters.Add(":lc_vr_accion", lc_vr_accion_ctda)
                    End If

                    comand.Parameters.Add(":lc_id_producto", lc_id_producto)
                    comand.Parameters.Add(":lc_und_medida", lc_und_medida)
                    comand.Parameters.Add(":lc_cantidad", lc_cantidad)
                    comand.Parameters.Add(":lc_usr_cre", lc_usr_cre)
                    comand.Parameters.Add(":lc_fec_cre", lc_fec_cre)
                    comand.Parameters.Add(":lc_cantidad_ub", lc_cantidad_ub)
                    comand.Parameters.Add(":lc_precio_unitario_ub", lc_costo_unitario)
                    comand.Parameters.Add(":lc_costo_unitario_ub", lc_precio_unitario)
                    comand.Parameters.Add(":lc_precio_unitario", lc_precio_unitario)
                    comand.Parameters.Add(":lc_costo_unitario", lc_costo_unitario)
                    comand.Parameters.Add(":lc_codigo_barra", lc_codigo_barra)
                    comand.Parameters.Add(":lc_id_estado", lc_id_estado)
                    comand.Parameters.Add(":lc_id_motivo", lc_id_motivo)

                    comand.ExecuteNonQuery()
                    conexion.desconectar()


                    Dim dt_secuencia_stock As New DataTable
                    dt_secuencia_stock = controlador.consultar("select sq_items_stkm.currval from dual")


                    If i = 1 Then
                        existencia_dep(lc_id_producto, lc_id_almacen)
                    Else
                        existencia_dep(lc_id_producto, id_deposito_destino)
                    End If


                    If reg_exist = True Then
                        If i = 1 Then
                            update_exist(existencias, lc_cantidad, lc_vr_accion, id_deposito, lc_id_producto)
                        Else
                            update_exist(existencias, lc_cantidad, lc_vr_accion_ctda, id_deposito_destino, lc_id_producto)
                        End If
                    Else
                        Dim dt_sec_stock As New DataTable
                        dt_secuencia_stock = controlador.consultar("select sq_stock.nextval from dual")
                        Dim identificador = dt_sec_stock.Rows(0).Item(0)

                        If i = 1 Then
                            insert_exis(identificador, lc_id_empresa, lc_id_unidad, id_deposito, lc_id_producto, lc_und_medida, lc_cantidad, lc_usr_cre)
                        Else
                            insert_exis(identificador, lc_id_empresa, lc_id_unidad, id_deposito_destino, lc_id_producto, lc_und_medida, lc_cantidad, lc_usr_cre)
                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            XtraMessageBox.AllowCustomLookAndFeel = True
            XtraMessageBox.Show("ITEMS NO INSERTADOS: " + ex.Message, "ERROR!", DevExpress.Utils.DefaultBoolean.Default)
        End Try
    End Sub

#End Region

#Region "Validar validar Punto y la Coma"
    Private Sub cantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cantidad.KeyPress
        If e.KeyChar = "," Then

        ElseIf e.KeyChar = "." Then
            SendKeys.Send(Microsoft.VisualBasic.Chr(44)) 'envia pulsacion de coma (,)
            e.Handled = True
        ElseIf e.KeyChar = "a" Then
            SimpleButton1.Focus()
        Else
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
#End Region


    Sub fecha()
        MaskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy")
        fecha_act = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Sub limpiar_variables()
        Dim fila As Integer = 0
        MaskedTextBox1.Clear()
        ComboBoxEdit1.SelectedIndex = -1
        ComboBoxEdit2.SelectedIndex = -1
        ComboBoxEdit3.SelectedIndex = -1
        ComboBoxEdit4.SelectedIndex = -1

        dt_cursor.Rows.Clear()

        MaskedTextBox1.Focus()

        fecha()

        SimpleButton1.Enabled = False

        crea_cursor()
        eliminar_filas_filas_vacias()
        GridView1.AddNewRow()
        GridView1.FocusedRowHandle = 0
    End Sub

#Region "Elimina Filas Vacias"
    Sub eliminar_filas_filas_vacias()
        For i As Integer = 0 To GridView1.RowCount - 1
            If IsDBNull(GridView1.GetRowCellValue(i, "DESCRIPCION")) Then
                GridView1.DeleteRow(i)
            End If
        Next
    End Sub
#End Region

#Region "Consultar Existencia"
    Sub existencia_dep(ByVal productoPar As Integer, ByVal almacenPar As Integer)
        Try
            dt_existencias = controlador.consultar("select existencia from stk_stock_prod where id_producto = " & productoPar & " AND id_almacen = " & almacenPar & "")

            If dt_existencias.Rows.Count <> 0 Then
                reg_exist = True
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "EXISTENCIA", dt_existencias.Rows(0).Item(0))
                existencias = dt_existencias.Rows(0).Item(0)
            Else
                reg_exist = False
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Actualizar Existencia"

    Sub update_exist(ByVal exist As Double, ByVal cantidad As Integer, ByVal accion As String, ByVal almacen As Integer, ByVal prod As Integer)
        Dim lcsql As String = ""

        If accion = "IN" Then
            lcsql = "UPDATE stk_stock_prod SET existencia = existencia + " & cantidad & ",usr_mod='APPUSR', fec_mod=sysdate WHERE id_almacen = " & almacen & " AND id_producto = " & prod & ""
        ElseIf accion = "EG" Then
            lcsql = "UPDATE stk_stock_prod SET existencia = existencia - " & cantidad & ",usr_mod='APPUSR', fec_mod=sysdate WHERE id_almacen = " & almacen & " AND id_producto = " & prod & ""
        End If

        conexion.conectar()
        Dim comand As New OracleCommand(lcsql, conexion.cnn)
        comand.ExecuteNonQuery()
        conexion.desconectar()
    End Sub

#End Region

#Region "Insertar Existencia"
    Sub insert_exis(ByVal identificador As Integer, ByVal id_empresa As Integer, ByVal id_unidad As Integer, ByVal almacen As Integer, ByVal prod As Integer, ByVal unid_med As Integer, ByVal exist As Double, ByVal usr_cre As String)


        Dim lcsql As String = "INSERT INTO stk_stock_prod(identificador, id_empresa, id_unidad, id_almacen, id_producto, id_und_medida, existencia, usr_cre, fec_cre)" &
        "VALUES(" & identificador & ", " & id_empresa & ", " & id_unidad & ", " & almacen & ", " & prod & ", " & unid_med & ", " & exist & ", '" & usr_cre & "' ,sysdate)"

        conexion.conectar()
        Dim comand As New OracleCommand(lcsql, conexion.cnn)
        comand.ExecuteNonQuery()
        conexion.desconectar()

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
#End Region

End Class