<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTomaInventario
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cldFecha = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtNoEncontrados = New DevExpress.XtraEditors.MemoEdit()
        Me.btnCargarProd = New DevExpress.XtraEditors.SimpleButton()
        Me.gridProductos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_ID_PRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsIdProducto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ID_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsIdProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCodigoBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_COSTO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCostoUnitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPrecioVenta = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_TOTAL_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsTotalCosto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_TOTAL_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTotalVenta = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.txtApuntador = New DevExpress.XtraEditors.TextEdit()
        Me.btnFecha = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cldFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtNoEncontrados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsIdProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsIdProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCostoUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTotalCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApuntador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cldFecha)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(993, 597)
        Me.PanelControl1.TabIndex = 0
        '
        'cldFecha
        '
        Me.cldFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFecha.Location = New System.Drawing.Point(363, 79)
        Me.cldFecha.Name = "cldFecha"
        Me.cldFecha.Size = New System.Drawing.Size(234, 227)
        Me.cldFecha.TabIndex = 24
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtNoEncontrados)
        Me.PanelControl3.Controls.Add(Me.btnCargarProd)
        Me.PanelControl3.Controls.Add(Me.gridProductos)
        Me.PanelControl3.Location = New System.Drawing.Point(17, 159)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(959, 422)
        Me.PanelControl3.TabIndex = 1
        '
        'txtNoEncontrados
        '
        Me.txtNoEncontrados.Location = New System.Drawing.Point(13, 332)
        Me.txtNoEncontrados.Name = "txtNoEncontrados"
        Me.txtNoEncontrados.Size = New System.Drawing.Size(933, 75)
        Me.txtNoEncontrados.TabIndex = 0
        '
        'btnCargarProd
        '
        Me.btnCargarProd.Location = New System.Drawing.Point(851, 7)
        Me.btnCargarProd.Name = "btnCargarProd"
        Me.btnCargarProd.Size = New System.Drawing.Size(95, 25)
        Me.btnCargarProd.TabIndex = 42
        Me.btnCargarProd.Text = "Cargar Prod."
        '
        'gridProductos
        '
        Me.gridProductos.Location = New System.Drawing.Point(13, 38)
        Me.gridProductos.MainView = Me.GridView1
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsIdProveedor, Me.rpsIdProducto, Me.rpsCodigoBarras, Me.rpsDescripcion, Me.rpsCantidad, Me.rpsCostoUnitario, Me.rpsPrecioVenta, Me.rpsTotalCosto, Me.txtTotalVenta})
        Me.gridProductos.Size = New System.Drawing.Size(933, 278)
        Me.gridProductos.TabIndex = 0
        Me.gridProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_ID_PRODUCTO, Me.COL_ID_PROVEEDOR, Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_CANTIDAD, Me.COL_COSTO_UNITARIO, Me.COL_PRECIO_VENTA, Me.COL_TOTAL_COSTO, Me.COL_TOTAL_VENTA})
        Me.GridView1.GridControl = Me.gridProductos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_ID_PRODUCTO
        '
        Me.COL_ID_PRODUCTO.Caption = "ID Producto"
        Me.COL_ID_PRODUCTO.ColumnEdit = Me.rpsIdProducto
        Me.COL_ID_PRODUCTO.FieldName = "ID_PRODUCTO"
        Me.COL_ID_PRODUCTO.Name = "COL_ID_PRODUCTO"
        Me.COL_ID_PRODUCTO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID_PRODUCTO", "{0}")})
        Me.COL_ID_PRODUCTO.Visible = True
        Me.COL_ID_PRODUCTO.VisibleIndex = 0
        Me.COL_ID_PRODUCTO.Width = 79
        '
        'rpsIdProducto
        '
        Me.rpsIdProducto.AutoHeight = False
        Me.rpsIdProducto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsIdProducto.Name = "rpsIdProducto"
        '
        'COL_ID_PROVEEDOR
        '
        Me.COL_ID_PROVEEDOR.Caption = "ID Proveedor"
        Me.COL_ID_PROVEEDOR.ColumnEdit = Me.rpsIdProveedor
        Me.COL_ID_PROVEEDOR.FieldName = "ID_PROVEEDOR"
        Me.COL_ID_PROVEEDOR.Name = "COL_ID_PROVEEDOR"
        Me.COL_ID_PROVEEDOR.Width = 73
        '
        'rpsIdProveedor
        '
        Me.rpsIdProveedor.AutoHeight = False
        Me.rpsIdProveedor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsIdProveedor.Name = "rpsIdProveedor"
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "Codigo barras"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.rpsCodigoBarras
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 1
        Me.COL_CODIGO_BARRAS.Width = 108
        '
        'rpsCodigoBarras
        '
        Me.rpsCodigoBarras.AutoHeight = False
        Me.rpsCodigoBarras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCodigoBarras.Name = "rpsCodigoBarras"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "Descripcion"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsDescripcion
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 2
        Me.COL_DESCRIPCION.Width = 283
        '
        'rpsDescripcion
        '
        Me.rpsDescripcion.AutoHeight = False
        Me.rpsDescripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDescripcion.Name = "rpsDescripcion"
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "Cantidad"
        Me.COL_CANTIDAD.ColumnEdit = Me.rpsCantidad
        Me.COL_CANTIDAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 3
        '
        'rpsCantidad
        '
        Me.rpsCantidad.AutoHeight = False
        Me.rpsCantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCantidad.DisplayFormat.FormatString = "0.00"
        Me.rpsCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsCantidad.Mask.EditMask = "n"
        Me.rpsCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.rpsCantidad.Name = "rpsCantidad"
        '
        'COL_COSTO_UNITARIO
        '
        Me.COL_COSTO_UNITARIO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_COSTO_UNITARIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_UNITARIO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_COSTO_UNITARIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_UNITARIO.Caption = "Costo unit."
        Me.COL_COSTO_UNITARIO.ColumnEdit = Me.rpsCostoUnitario
        Me.COL_COSTO_UNITARIO.DisplayFormat.FormatString = "#,#"
        Me.COL_COSTO_UNITARIO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_COSTO_UNITARIO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Name = "COL_COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Visible = True
        Me.COL_COSTO_UNITARIO.VisibleIndex = 4
        '
        'rpsCostoUnitario
        '
        Me.rpsCostoUnitario.AutoHeight = False
        Me.rpsCostoUnitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCostoUnitario.DisplayFormat.FormatString = "#,#"
        Me.rpsCostoUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsCostoUnitario.Mask.EditMask = "n0"
        Me.rpsCostoUnitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsCostoUnitario.Mask.UseMaskAsDisplayFormat = True
        Me.rpsCostoUnitario.Name = "rpsCostoUnitario"
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.Caption = "Precio venta"
        Me.COL_PRECIO_VENTA.ColumnEdit = Me.rpsPrecioVenta
        Me.COL_PRECIO_VENTA.DisplayFormat.FormatString = "#,#"
        Me.COL_PRECIO_VENTA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Visible = True
        Me.COL_PRECIO_VENTA.VisibleIndex = 5
        '
        'rpsPrecioVenta
        '
        Me.rpsPrecioVenta.AutoHeight = False
        Me.rpsPrecioVenta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPrecioVenta.DisplayFormat.FormatString = "#,#"
        Me.rpsPrecioVenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsPrecioVenta.Mask.EditMask = "n0"
        Me.rpsPrecioVenta.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPrecioVenta.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPrecioVenta.Name = "rpsPrecioVenta"
        '
        'COL_TOTAL_COSTO
        '
        Me.COL_TOTAL_COSTO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_TOTAL_COSTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL_COSTO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_TOTAL_COSTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL_COSTO.Caption = "Total costo"
        Me.COL_TOTAL_COSTO.ColumnEdit = Me.rpsTotalCosto
        Me.COL_TOTAL_COSTO.DisplayFormat.FormatString = "#,#"
        Me.COL_TOTAL_COSTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_TOTAL_COSTO.FieldName = "TOTAL_COSTO"
        Me.COL_TOTAL_COSTO.Name = "COL_TOTAL_COSTO"
        Me.COL_TOTAL_COSTO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_COSTO", "{0:#,#}")})
        Me.COL_TOTAL_COSTO.Visible = True
        Me.COL_TOTAL_COSTO.VisibleIndex = 6
        '
        'rpsTotalCosto
        '
        Me.rpsTotalCosto.AutoHeight = False
        Me.rpsTotalCosto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTotalCosto.DisplayFormat.FormatString = "#,#"
        Me.rpsTotalCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsTotalCosto.Mask.EditMask = "n0"
        Me.rpsTotalCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTotalCosto.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTotalCosto.Name = "rpsTotalCosto"
        '
        'COL_TOTAL_VENTA
        '
        Me.COL_TOTAL_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_TOTAL_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_TOTAL_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL_VENTA.Caption = "Total venta"
        Me.COL_TOTAL_VENTA.ColumnEdit = Me.txtTotalVenta
        Me.COL_TOTAL_VENTA.DisplayFormat.FormatString = "#,#"
        Me.COL_TOTAL_VENTA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_TOTAL_VENTA.FieldName = "TOTAL_VENTA"
        Me.COL_TOTAL_VENTA.Name = "COL_TOTAL_VENTA"
        Me.COL_TOTAL_VENTA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_VENTA", "{0:#,#}")})
        Me.COL_TOTAL_VENTA.Visible = True
        Me.COL_TOTAL_VENTA.VisibleIndex = 7
        Me.COL_TOTAL_VENTA.Width = 96
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.AutoHeight = False
        Me.txtTotalVenta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtTotalVenta.DisplayFormat.FormatString = "#,#"
        Me.txtTotalVenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalVenta.Mask.EditMask = "n0"
        Me.txtTotalVenta.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalVenta.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalVenta.Name = "txtTotalVenta"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.txtReferencia)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.txtFecha)
        Me.PanelControl2.Controls.Add(Me.txtNumero)
        Me.PanelControl2.Controls.Add(Me.txtApuntador)
        Me.PanelControl2.Controls.Add(Me.btnFecha)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.btnBuscarSucursal)
        Me.PanelControl2.Controls.Add(Me.txtDescripcion)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(17, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(959, 127)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(829, 52)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 32)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtReferencia
        '
        Me.txtReferencia.EditValue = ""
        Me.txtReferencia.Location = New System.Drawing.Point(470, 63)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtReferencia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Size = New System.Drawing.Size(261, 22)
        Me.txtReferencia.TabIndex = 7
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(829, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 33)
        Me.btnAceptar.TabIndex = 40
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(111, 65)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(231, 21)
        Me.txtFecha.TabIndex = 4
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtNumero
        '
        Me.txtNumero.EditValue = ""
        Me.txtNumero.Location = New System.Drawing.Point(470, 37)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumero.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNumero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Properties.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(261, 22)
        Me.txtNumero.TabIndex = 6
        '
        'txtApuntador
        '
        Me.txtApuntador.EditValue = ""
        Me.txtApuntador.Location = New System.Drawing.Point(470, 12)
        Me.txtApuntador.Name = "txtApuntador"
        Me.txtApuntador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtApuntador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApuntador.Size = New System.Drawing.Size(261, 22)
        Me.txtApuntador.TabIndex = 5
        '
        'btnFecha
        '
        Me.btnFecha.Location = New System.Drawing.Point(346, 65)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(26, 21)
        Me.btnFecha.TabIndex = 38
        Me.btnFecha.Text = "+"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Referencia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(405, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Apuntador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Numero:"
        '
        'txtSucursal
        '
        Me.txtSucursal.EditValue = ""
        Me.txtSucursal.Location = New System.Drawing.Point(111, 12)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSucursal.Size = New System.Drawing.Size(231, 22)
        Me.txtSucursal.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Sucursal:"
        '
        'btnBuscarSucursal
        '
        Me.btnBuscarSucursal.Location = New System.Drawing.Point(346, 12)
        Me.btnBuscarSucursal.Name = "btnBuscarSucursal"
        Me.btnBuscarSucursal.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarSucursal.TabIndex = 30
        Me.btnBuscarSucursal.Text = "+"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EditValue = ""
        Me.txtDescripcion.Location = New System.Drawing.Point(111, 38)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Size = New System.Drawing.Size(261, 22)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Comentario:"
        '
        'FrmTomaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 621)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmTomaInventario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toma de inventario"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cldFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtNoEncontrados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsIdProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsIdProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCostoUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTotalCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApuntador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents btnFecha As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApuntador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_ID_PRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_TOTAL_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_TOTAL_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsIdProducto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_ID_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsIdProveedor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCodigoBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCostoUnitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPrecioVenta As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTotalCosto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTotalVenta As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnCargarProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cldFecha As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents txtNoEncontrados As DevExpress.XtraEditors.MemoEdit
End Class
