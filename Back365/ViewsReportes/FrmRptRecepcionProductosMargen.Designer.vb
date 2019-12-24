<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptRecepcionProductosMargen
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cldFechaDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldFechaHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.chkCodigo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDescripcion = New DevExpress.XtraEditors.CheckEdit()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsFecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_NRO_FACTURA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_NRO_RECEPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_COD_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDecimal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PORC_DESCUENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPorcentaje = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_MARGEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodigoBarras = New DevExpress.XtraEditors.TextEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cldFechaDesde)
        Me.PanelControl1.Controls.Add(Me.cldFechaHasta)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1044, 557)
        Me.PanelControl1.TabIndex = 0
        '
        'cldFechaDesde
        '
        Me.cldFechaDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaDesde.Location = New System.Drawing.Point(405, 23)
        Me.cldFechaDesde.Name = "cldFechaDesde"
        Me.cldFechaDesde.Size = New System.Drawing.Size(270, 227)
        Me.cldFechaDesde.TabIndex = 21
        '
        'cldFechaHasta
        '
        Me.cldFechaHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaHasta.Location = New System.Drawing.Point(405, 54)
        Me.cldFechaHasta.Name = "cldFechaHasta"
        Me.cldFechaHasta.Size = New System.Drawing.Size(270, 227)
        Me.cldFechaHasta.TabIndex = 20
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(10, 151)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1019, 390)
        Me.PanelControl3.TabIndex = 1
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnImprimir)
        Me.PanelControl4.Controls.Add(Me.txtBuscar)
        Me.PanelControl4.Controls.Add(Me.chkCodigo)
        Me.PanelControl4.Controls.Add(Me.chkDescripcion)
        Me.PanelControl4.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(995, 69)
        Me.PanelControl4.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(836, 14)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(94, 30)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(6, 36)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Size = New System.Drawing.Size(322, 22)
        Me.txtBuscar.TabIndex = 2
        Me.txtBuscar.TabStop = False
        '
        'chkCodigo
        '
        Me.chkCodigo.Location = New System.Drawing.Point(89, 11)
        Me.chkCodigo.Name = "chkCodigo"
        Me.chkCodigo.Properties.Caption = "Cod. Barras:"
        Me.chkCodigo.Size = New System.Drawing.Size(77, 19)
        Me.chkCodigo.TabIndex = 1
        '
        'chkDescripcion
        '
        Me.chkDescripcion.Location = New System.Drawing.Point(6, 11)
        Me.chkDescripcion.Name = "chkDescripcion"
        Me.chkDescripcion.Properties.Caption = "Descripcion"
        Me.chkDescripcion.Size = New System.Drawing.Size(77, 19)
        Me.chkDescripcion.TabIndex = 0
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(12, 90)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracter, Me.rpsMiles, Me.rpsDecimal, Me.rpsFecha, Me.rpsPorcentaje})
        Me.gridItems.Size = New System.Drawing.Size(994, 287)
        Me.gridItems.TabIndex = 1
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_FECHA, Me.COL_PROVEEDOR, Me.COL_NRO_FACTURA, Me.COL_NRO_RECEPCION, Me.COL_COD_BARRAS, Me.COL_PRODUCTO, Me.COL_CANTIDAD, Me.COL_PRECIO_UNITARIO, Me.COL_PORC_DESCUENTO, Me.COL_TOTAL, Me.COL_COSTO, Me.COL_PRECIO_VENTA, Me.COL_MARGEN})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.COL_PROVEEDOR, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'COL_FECHA
        '
        Me.COL_FECHA.Caption = "Fecha"
        Me.COL_FECHA.ColumnEdit = Me.rpsFecha
        Me.COL_FECHA.FieldName = "FECHA"
        Me.COL_FECHA.Name = "COL_FECHA"
        Me.COL_FECHA.Visible = True
        Me.COL_FECHA.VisibleIndex = 0
        Me.COL_FECHA.Width = 65
        '
        'rpsFecha
        '
        Me.rpsFecha.AutoHeight = False
        Me.rpsFecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsFecha.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.rpsFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rpsFecha.Name = "rpsFecha"
        '
        'COL_PROVEEDOR
        '
        Me.COL_PROVEEDOR.Caption = "Proveedor"
        Me.COL_PROVEEDOR.ColumnEdit = Me.rpsCaracter
        Me.COL_PROVEEDOR.FieldName = "PROVEEDOR"
        Me.COL_PROVEEDOR.Name = "COL_PROVEEDOR"
        Me.COL_PROVEEDOR.Visible = True
        Me.COL_PROVEEDOR.VisibleIndex = 3
        Me.COL_PROVEEDOR.Width = 188
        '
        'rpsCaracter
        '
        Me.rpsCaracter.AutoHeight = False
        Me.rpsCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracter.Name = "rpsCaracter"
        '
        'COL_NRO_FACTURA
        '
        Me.COL_NRO_FACTURA.Caption = "Nro. factura"
        Me.COL_NRO_FACTURA.ColumnEdit = Me.rpsCaracter
        Me.COL_NRO_FACTURA.FieldName = "NRO_FACTURA"
        Me.COL_NRO_FACTURA.Name = "COL_NRO_FACTURA"
        Me.COL_NRO_FACTURA.Visible = True
        Me.COL_NRO_FACTURA.VisibleIndex = 1
        Me.COL_NRO_FACTURA.Width = 87
        '
        'COL_NRO_RECEPCION
        '
        Me.COL_NRO_RECEPCION.AppearanceCell.Options.UseTextOptions = True
        Me.COL_NRO_RECEPCION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_NRO_RECEPCION.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_NRO_RECEPCION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_NRO_RECEPCION.Caption = "Nro. recepcion"
        Me.COL_NRO_RECEPCION.ColumnEdit = Me.rpsCaracter
        Me.COL_NRO_RECEPCION.FieldName = "NRO_RECEPCION"
        Me.COL_NRO_RECEPCION.Name = "COL_NRO_RECEPCION"
        Me.COL_NRO_RECEPCION.Visible = True
        Me.COL_NRO_RECEPCION.VisibleIndex = 2
        Me.COL_NRO_RECEPCION.Width = 64
        '
        'COL_COD_BARRAS
        '
        Me.COL_COD_BARRAS.Caption = "Cod. barras"
        Me.COL_COD_BARRAS.ColumnEdit = Me.rpsCaracter
        Me.COL_COD_BARRAS.FieldName = "CODIGO_BARRA"
        Me.COL_COD_BARRAS.Name = "COL_COD_BARRAS"
        Me.COL_COD_BARRAS.Visible = True
        Me.COL_COD_BARRAS.VisibleIndex = 3
        Me.COL_COD_BARRAS.Width = 80
        '
        'COL_PRODUCTO
        '
        Me.COL_PRODUCTO.Caption = "Producto"
        Me.COL_PRODUCTO.ColumnEdit = Me.rpsCaracter
        Me.COL_PRODUCTO.FieldName = "PRODUCTO"
        Me.COL_PRODUCTO.Name = "COL_PRODUCTO"
        Me.COL_PRODUCTO.Visible = True
        Me.COL_PRODUCTO.VisibleIndex = 4
        Me.COL_PRODUCTO.Width = 216
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "Cantidad"
        Me.COL_CANTIDAD.ColumnEdit = Me.rpsDecimal
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 5
        Me.COL_CANTIDAD.Width = 71
        '
        'rpsDecimal
        '
        Me.rpsDecimal.AutoHeight = False
        Me.rpsDecimal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDecimal.DisplayFormat.FormatString = "0,0.00"
        Me.rpsDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsDecimal.Mask.EditMask = "n"
        Me.rpsDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDecimal.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDecimal.Name = "rpsDecimal"
        '
        'COL_PRECIO_UNITARIO
        '
        Me.COL_PRECIO_UNITARIO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_UNITARIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_UNITARIO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_UNITARIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_UNITARIO.Caption = "Precio unit."
        Me.COL_PRECIO_UNITARIO.ColumnEdit = Me.rpsMiles
        Me.COL_PRECIO_UNITARIO.FieldName = "PRECIO_UNITARIO"
        Me.COL_PRECIO_UNITARIO.Name = "COL_PRECIO_UNITARIO"
        Me.COL_PRECIO_UNITARIO.Visible = True
        Me.COL_PRECIO_UNITARIO.VisibleIndex = 7
        Me.COL_PRECIO_UNITARIO.Width = 63
        '
        'rpsMiles
        '
        Me.rpsMiles.AutoHeight = False
        Me.rpsMiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsMiles.DisplayFormat.FormatString = "#,#"
        Me.rpsMiles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsMiles.Mask.EditMask = "n0"
        Me.rpsMiles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsMiles.Mask.UseMaskAsDisplayFormat = True
        Me.rpsMiles.Name = "rpsMiles"
        '
        'COL_PORC_DESCUENTO
        '
        Me.COL_PORC_DESCUENTO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PORC_DESCUENTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PORC_DESCUENTO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PORC_DESCUENTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PORC_DESCUENTO.Caption = "Desc. (%)"
        Me.COL_PORC_DESCUENTO.ColumnEdit = Me.rpsPorcentaje
        Me.COL_PORC_DESCUENTO.FieldName = "PORC_DESCUENTO"
        Me.COL_PORC_DESCUENTO.Name = "COL_PORC_DESCUENTO"
        Me.COL_PORC_DESCUENTO.Visible = True
        Me.COL_PORC_DESCUENTO.VisibleIndex = 8
        Me.COL_PORC_DESCUENTO.Width = 66
        '
        'rpsPorcentaje
        '
        Me.rpsPorcentaje.AutoHeight = False
        Me.rpsPorcentaje.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPorcentaje.DisplayFormat.FormatString = "{0:0.00} %"
        Me.rpsPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsPorcentaje.Name = "rpsPorcentaje"
        '
        'COL_TOTAL
        '
        Me.COL_TOTAL.AppearanceCell.Options.UseTextOptions = True
        Me.COL_TOTAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_TOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL.Caption = "Total"
        Me.COL_TOTAL.ColumnEdit = Me.rpsMiles
        Me.COL_TOTAL.FieldName = "TOTAL"
        Me.COL_TOTAL.Name = "COL_TOTAL"
        Me.COL_TOTAL.Visible = True
        Me.COL_TOTAL.VisibleIndex = 11
        Me.COL_TOTAL.Width = 70
        '
        'COL_COSTO
        '
        Me.COL_COSTO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_COSTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_COSTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO.Caption = "Costo"
        Me.COL_COSTO.ColumnEdit = Me.rpsMiles
        Me.COL_COSTO.FieldName = "COSTO"
        Me.COL_COSTO.Name = "COL_COSTO"
        Me.COL_COSTO.Visible = True
        Me.COL_COSTO.VisibleIndex = 6
        Me.COL_COSTO.Width = 65
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.Caption = "Precio venta"
        Me.COL_PRECIO_VENTA.ColumnEdit = Me.rpsMiles
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Visible = True
        Me.COL_PRECIO_VENTA.VisibleIndex = 9
        Me.COL_PRECIO_VENTA.Width = 74
        '
        'COL_MARGEN
        '
        Me.COL_MARGEN.AppearanceCell.Options.UseTextOptions = True
        Me.COL_MARGEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_MARGEN.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_MARGEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_MARGEN.Caption = "Margen"
        Me.COL_MARGEN.ColumnEdit = Me.rpsDecimal
        Me.COL_MARGEN.FieldName = "MARGEN"
        Me.COL_MARGEN.Name = "COL_MARGEN"
        Me.COL_MARGEN.Visible = True
        Me.COL_MARGEN.VisibleIndex = 10
        Me.COL_MARGEN.Width = 55
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtProveedor)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.btnProveedor)
        Me.PanelControl2.Controls.Add(Me.txtProducto)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.btnBuscarProducto)
        Me.PanelControl2.Controls.Add(Me.txtCodigoBarras)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl2.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(10, 11)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1019, 134)
        Me.PanelControl2.TabIndex = 0
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(150, 95)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.Properties.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(241, 22)
        Me.txtProveedor.TabIndex = 3
        Me.txtProveedor.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Proveedor:"
        '
        'btnProveedor
        '
        Me.btnProveedor.Location = New System.Drawing.Point(395, 96)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(26, 21)
        Me.btnProveedor.TabIndex = 24
        Me.btnProveedor.Text = "+"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(264, 67)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProducto.Properties.Appearance.Options.UseBackColor = True
        Me.txtProducto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProducto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto.Properties.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(345, 22)
        Me.txtProducto.TabIndex = 1
        Me.txtProducto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Producto:"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Location = New System.Drawing.Point(612, 67)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(26, 21)
        Me.btnBuscarProducto.TabIndex = 20
        Me.btnBuscarProducto.Text = "+"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(150, 67)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodigoBarras.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarras.Size = New System.Drawing.Size(110, 22)
        Me.txtCodigoBarras.TabIndex = 2
        Me.txtCodigoBarras.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(848, 60)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(395, 12)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaDesde.TabIndex = 18
        Me.btnFechaDesde.Text = "+"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(395, 39)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaHasta.TabIndex = 19
        Me.btnFechaHasta.Text = "+"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(848, 24)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 30)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(150, 40)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(241, 21)
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(150, 13)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(241, 21)
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha desde:"
        '
        'FrmRptRecepcionProductosMargen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 578)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRptRecepcionProductosMargen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepcion de productos con margen"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cldFechaDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldFechaHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkCodigo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDescripcion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsFecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_NRO_FACTURA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_NRO_RECEPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COD_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsDecimal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_PRECIO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_PORC_DESCUENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsPorcentaje As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarProducto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_MARGEN As DevExpress.XtraGrid.Columns.GridColumn
End Class
