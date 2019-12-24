<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptUnilever
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_FAMILIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_MARCA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDecimales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_COSTO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PARTICIPACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPorcentaje = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_GRAMAJE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridVentas = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.cldFechaDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldFechaHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscarUnidadOperat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarFamilia = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFamilia = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnidadOperat = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_FAMILIA, Me.COL_MARCA, Me.COL_PRODUCTO, Me.COL_CANTIDAD, Me.COL_COSTO_UNITARIO, Me.COL_PRECIO_VENTA, Me.COL_PARTICIPACION, Me.COL_CODIGO_BARRAS, Me.COL_GRAMAJE, Me.COL_PROVEEDOR})
        Me.GridView1.GridControl = Me.gridVentas
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.COL_GRAMAJE, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'COL_FAMILIA
        '
        Me.COL_FAMILIA.Caption = "Familia"
        Me.COL_FAMILIA.ColumnEdit = Me.txtCaracter
        Me.COL_FAMILIA.FieldName = "FAMILIA"
        Me.COL_FAMILIA.Name = "COL_FAMILIA"
        Me.COL_FAMILIA.Width = 107
        '
        'txtCaracter
        '
        Me.txtCaracter.AutoHeight = False
        Me.txtCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCaracter.Name = "txtCaracter"
        '
        'COL_MARCA
        '
        Me.COL_MARCA.Caption = "Marca"
        Me.COL_MARCA.ColumnEdit = Me.txtCaracter
        Me.COL_MARCA.FieldName = "MARCA"
        Me.COL_MARCA.Name = "COL_MARCA"
        Me.COL_MARCA.Visible = True
        Me.COL_MARCA.VisibleIndex = 0
        Me.COL_MARCA.Width = 101
        '
        'COL_PRODUCTO
        '
        Me.COL_PRODUCTO.Caption = "Producto"
        Me.COL_PRODUCTO.ColumnEdit = Me.txtCaracter
        Me.COL_PRODUCTO.FieldName = "PRODUCTO"
        Me.COL_PRODUCTO.Name = "COL_PRODUCTO"
        Me.COL_PRODUCTO.Visible = True
        Me.COL_PRODUCTO.VisibleIndex = 3
        Me.COL_PRODUCTO.Width = 302
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "Cantidad"
        Me.COL_CANTIDAD.ColumnEdit = Me.txtDecimales
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CANTIDAD", "{0:#,#.00}")})
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 4
        Me.COL_CANTIDAD.Width = 76
        '
        'txtDecimales
        '
        Me.txtDecimales.AutoHeight = False
        Me.txtDecimales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDecimales.DisplayFormat.FormatString = "{0:0.00}"
        Me.txtDecimales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDecimales.Mask.EditMask = "n"
        Me.txtDecimales.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDecimales.Mask.UseMaskAsDisplayFormat = True
        Me.txtDecimales.Name = "txtDecimales"
        '
        'COL_COSTO_UNITARIO
        '
        Me.COL_COSTO_UNITARIO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_COSTO_UNITARIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_UNITARIO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_COSTO_UNITARIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_UNITARIO.Caption = "Total costo"
        Me.COL_COSTO_UNITARIO.ColumnEdit = Me.txtMiles
        Me.COL_COSTO_UNITARIO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Name = "COL_COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COSTO_UNITARIO", "{0:#,#}")})
        Me.COL_COSTO_UNITARIO.Width = 80
        '
        'txtMiles
        '
        Me.txtMiles.AutoHeight = False
        Me.txtMiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtMiles.DisplayFormat.FormatString = "{0:#,#}"
        Me.txtMiles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMiles.Mask.EditMask = "n0"
        Me.txtMiles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMiles.Mask.UseMaskAsDisplayFormat = True
        Me.txtMiles.Name = "txtMiles"
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.Caption = "Total venta"
        Me.COL_PRECIO_VENTA.ColumnEdit = Me.txtMiles
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PRECIO_VENTA", "{0:#,#}")})
        Me.COL_PRECIO_VENTA.Visible = True
        Me.COL_PRECIO_VENTA.VisibleIndex = 5
        Me.COL_PRECIO_VENTA.Width = 68
        '
        'COL_PARTICIPACION
        '
        Me.COL_PARTICIPACION.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PARTICIPACION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PARTICIPACION.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PARTICIPACION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PARTICIPACION.Caption = "Participacion (%)"
        Me.COL_PARTICIPACION.ColumnEdit = Me.txtPorcentaje
        Me.COL_PARTICIPACION.FieldName = "PARTICIPACION"
        Me.COL_PARTICIPACION.Name = "COL_PARTICIPACION"
        Me.COL_PARTICIPACION.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PARTICIPACION", "{0:#,#.00} %")})
        Me.COL_PARTICIPACION.Visible = True
        Me.COL_PARTICIPACION.VisibleIndex = 6
        Me.COL_PARTICIPACION.Width = 94
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.AutoHeight = False
        Me.txtPorcentaje.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtPorcentaje.DisplayFormat.FormatString = "{0:0.00} %"
        Me.txtPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorcentaje.Mask.EditMask = "n"
        Me.txtPorcentaje.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentaje.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentaje.Name = "txtPorcentaje"
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "Cod. barras"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.txtCaracter
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 2
        Me.COL_CODIGO_BARRAS.Width = 94
        '
        'COL_GRAMAJE
        '
        Me.COL_GRAMAJE.Caption = "Gramaje"
        Me.COL_GRAMAJE.FieldName = "VALOR"
        Me.COL_GRAMAJE.Name = "COL_GRAMAJE"
        Me.COL_GRAMAJE.Visible = True
        Me.COL_GRAMAJE.VisibleIndex = 7
        '
        'COL_PROVEEDOR
        '
        Me.COL_PROVEEDOR.Caption = "Proveedor"
        Me.COL_PROVEEDOR.ColumnEdit = Me.txtCaracter
        Me.COL_PROVEEDOR.FieldName = "PROVEEDOR"
        Me.COL_PROVEEDOR.Name = "COL_PROVEEDOR"
        Me.COL_PROVEEDOR.Visible = True
        Me.COL_PROVEEDOR.VisibleIndex = 1
        Me.COL_PROVEEDOR.Width = 190
        '
        'gridVentas
        '
        Me.gridVentas.Location = New System.Drawing.Point(15, 20)
        Me.gridVentas.MainView = Me.GridView1
        Me.gridVentas.Name = "gridVentas"
        Me.gridVentas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCaracter, Me.txtMiles, Me.txtDecimales, Me.txtPorcentaje})
        Me.gridVentas.Size = New System.Drawing.Size(943, 288)
        Me.gridVentas.TabIndex = 0
        Me.gridVentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gridVentas
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Detalles de Reporte"
        Me.TabNavigationPage1.Controls.Add(Me.cldFechaDesde)
        Me.TabNavigationPage1.Controls.Add(Me.cldFechaHasta)
        Me.TabNavigationPage1.Controls.Add(Me.GroupBox2)
        Me.TabNavigationPage1.Controls.Add(Me.GroupBox1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(979, 466)
        '
        'cldFechaDesde
        '
        Me.cldFechaDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaDesde.Location = New System.Drawing.Point(624, 27)
        Me.cldFechaDesde.Name = "cldFechaDesde"
        Me.cldFechaDesde.Size = New System.Drawing.Size(270, 227)
        Me.cldFechaDesde.TabIndex = 17
        '
        'cldFechaHasta
        '
        Me.cldFechaHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaHasta.Location = New System.Drawing.Point(624, 58)
        Me.cldFechaHasta.Name = "cldFechaHasta"
        Me.cldFechaHasta.Size = New System.Drawing.Size(270, 227)
        Me.cldFechaHasta.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gridVentas)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(973, 324)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados de reporte"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnBuscarSucursal)
        Me.GroupBox1.Controls.Add(Me.txtSucursal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.txtFechaHasta)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesde)
        Me.GroupBox1.Controls.Add(Me.btnBuscarUnidadOperat)
        Me.GroupBox1.Controls.Add(Me.btnBuscarFamilia)
        Me.GroupBox1.Controls.Add(Me.btnFechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnFechaDesde)
        Me.GroupBox1.Controls.Add(Me.txtFamilia)
        Me.GroupBox1.Controls.Add(Me.txtUnidadOperat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de reporte"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(770, 61)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(94, 30)
        Me.btnImprimir.TabIndex = 17
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnBuscarSucursal
        '
        Me.btnBuscarSucursal.Location = New System.Drawing.Point(351, 51)
        Me.btnBuscarSucursal.Name = "btnBuscarSucursal"
        Me.btnBuscarSucursal.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarSucursal.TabIndex = 16
        Me.btnBuscarSucursal.Text = "+"
        '
        'txtSucursal
        '
        Me.txtSucursal.EditValue = " "
        Me.txtSucursal.Location = New System.Drawing.Point(117, 50)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(228, 22)
        Me.txtSucursal.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Sucursal:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(770, 19)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 30)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.Text = "Consultar"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(463, 55)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(153, 21)
        Me.txtFechaHasta.TabIndex = 4
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(463, 24)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(153, 21)
        Me.txtFechaDesde.TabIndex = 3
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'btnBuscarUnidadOperat
        '
        Me.btnBuscarUnidadOperat.Location = New System.Drawing.Point(352, 25)
        Me.btnBuscarUnidadOperat.Name = "btnBuscarUnidadOperat"
        Me.btnBuscarUnidadOperat.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarUnidadOperat.TabIndex = 13
        Me.btnBuscarUnidadOperat.Text = "+"
        '
        'btnBuscarFamilia
        '
        Me.btnBuscarFamilia.Location = New System.Drawing.Point(351, 78)
        Me.btnBuscarFamilia.Name = "btnBuscarFamilia"
        Me.btnBuscarFamilia.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarFamilia.TabIndex = 12
        Me.btnBuscarFamilia.Text = "+"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(620, 55)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaHasta.TabIndex = 11
        Me.btnFechaHasta.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha Hasta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(620, 24)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaDesde.TabIndex = 8
        Me.btnFechaDesde.Text = "+"
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(117, 76)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFamilia.Properties.Appearance.Options.UseBackColor = True
        Me.txtFamilia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFamilia.Properties.ReadOnly = True
        Me.txtFamilia.Size = New System.Drawing.Size(228, 22)
        Me.txtFamilia.TabIndex = 2
        '
        'txtUnidadOperat
        '
        Me.txtUnidadOperat.Location = New System.Drawing.Point(118, 24)
        Me.txtUnidadOperat.Name = "txtUnidadOperat"
        Me.txtUnidadOperat.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnidadOperat.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnidadOperat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUnidadOperat.Properties.ReadOnly = True
        Me.txtUnidadOperat.Size = New System.Drawing.Size(228, 22)
        Me.txtUnidadOperat.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Desde:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Familia:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unidad Operat.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Location = New System.Drawing.Point(12, 12)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1})
        Me.TabPane1.RegularSize = New System.Drawing.Size(997, 511)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(997, 511)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'FrmRptUnilever
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 536)
        Me.Controls.Add(Me.TabPane1)
        Me.Name = "FrmRptUnilever"
        Me.Text = "Unilever"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage1.PerformLayout()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_FAMILIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_MARCA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDecimales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_COSTO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PARTICIPACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPorcentaje As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gridVentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents cldFechaDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldFechaHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents btnBuscarUnidadOperat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarFamilia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnidadOperat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents COL_PRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_GRAMAJE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
End Class
