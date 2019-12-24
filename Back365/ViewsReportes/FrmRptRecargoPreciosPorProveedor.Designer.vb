<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptRecargoPreciosPorProveedor
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
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimirGrilla = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.chkCodigo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDescripcion = New DevExpress.XtraEditors.CheckEdit()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ULTIMO_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_IMPUESTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPorcEntero = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_POR_RECARGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPorcentaje = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_FAMILIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDecimal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarFamilia = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFamilia = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPorcEntero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1142, 515)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(318, 13)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(811, 487)
        Me.PanelControl3.TabIndex = 1
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnImprimirGrilla)
        Me.PanelControl4.Controls.Add(Me.txtBuscar)
        Me.PanelControl4.Controls.Add(Me.chkCodigo)
        Me.PanelControl4.Controls.Add(Me.chkDescripcion)
        Me.PanelControl4.Location = New System.Drawing.Point(14, 14)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(784, 69)
        Me.PanelControl4.TabIndex = 1
        '
        'btnImprimirGrilla
        '
        Me.btnImprimirGrilla.Location = New System.Drawing.Point(676, 24)
        Me.btnImprimirGrilla.Name = "btnImprimirGrilla"
        Me.btnImprimirGrilla.Size = New System.Drawing.Size(94, 30)
        Me.btnImprimirGrilla.TabIndex = 20
        Me.btnImprimirGrilla.Text = "Imprimir"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(29, 37)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Size = New System.Drawing.Size(322, 22)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.TabStop = False
        '
        'chkCodigo
        '
        Me.chkCodigo.Location = New System.Drawing.Point(112, 12)
        Me.chkCodigo.Name = "chkCodigo"
        Me.chkCodigo.Properties.Caption = "Cod. Barras:"
        Me.chkCodigo.Size = New System.Drawing.Size(77, 19)
        Me.chkCodigo.TabIndex = 2
        '
        'chkDescripcion
        '
        Me.chkDescripcion.Location = New System.Drawing.Point(29, 12)
        Me.chkDescripcion.Name = "chkDescripcion"
        Me.chkDescripcion.Properties.Caption = "Descripcion"
        Me.chkDescripcion.Size = New System.Drawing.Size(77, 19)
        Me.chkDescripcion.TabIndex = 1
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(14, 89)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracteres, Me.rpsMiles, Me.rpsDecimal, Me.rpsPorcentaje, Me.rpsPorcEntero})
        Me.gridItems.Size = New System.Drawing.Size(784, 384)
        Me.gridItems.TabIndex = 0
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_ULTIMO_COSTO, Me.COL_PRECIO_VENTA, Me.COL_IMPUESTO, Me.COL_POR_RECARGO, Me.COL_FAMILIA})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.COL_FAMILIA, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.AppearanceCell.Options.UseTextOptions = True
        Me.COL_IDENTIFICADOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IDENTIFICADOR.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_IDENTIFICADOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IDENTIFICADOR.Caption = "Identificador"
        Me.COL_IDENTIFICADOR.ColumnEdit = Me.rpsMiles
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IDENTIFICADOR", "{0:#,#}")})
        Me.COL_IDENTIFICADOR.Visible = True
        Me.COL_IDENTIFICADOR.VisibleIndex = 0
        Me.COL_IDENTIFICADOR.Width = 83
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
        Me.rpsMiles.NullText = "0"
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CODIGO_BARRAS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_CODIGO_BARRAS.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CODIGO_BARRAS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_CODIGO_BARRAS.Caption = "Codigo barras"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.rpsCaracteres
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 1
        Me.COL_CODIGO_BARRAS.Width = 94
        '
        'rpsCaracteres
        '
        Me.rpsCaracteres.AutoHeight = False
        Me.rpsCaracteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracteres.Name = "rpsCaracteres"
        Me.rpsCaracteres.NullText = "-"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "Descripcion"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsCaracteres
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 2
        Me.COL_DESCRIPCION.Width = 260
        '
        'COL_ULTIMO_COSTO
        '
        Me.COL_ULTIMO_COSTO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_ULTIMO_COSTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_ULTIMO_COSTO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_ULTIMO_COSTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_ULTIMO_COSTO.Caption = "Ultimo costo"
        Me.COL_ULTIMO_COSTO.ColumnEdit = Me.rpsMiles
        Me.COL_ULTIMO_COSTO.FieldName = "ULTIMO_COSTO"
        Me.COL_ULTIMO_COSTO.Name = "COL_ULTIMO_COSTO"
        Me.COL_ULTIMO_COSTO.Visible = True
        Me.COL_ULTIMO_COSTO.VisibleIndex = 3
        Me.COL_ULTIMO_COSTO.Width = 84
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
        Me.COL_PRECIO_VENTA.VisibleIndex = 4
        Me.COL_PRECIO_VENTA.Width = 81
        '
        'COL_IMPUESTO
        '
        Me.COL_IMPUESTO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_IMPUESTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IMPUESTO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_IMPUESTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IMPUESTO.Caption = "Impuesto (%)"
        Me.COL_IMPUESTO.ColumnEdit = Me.rpsPorcEntero
        Me.COL_IMPUESTO.FieldName = "IMPUESTO"
        Me.COL_IMPUESTO.Name = "COL_IMPUESTO"
        Me.COL_IMPUESTO.Visible = True
        Me.COL_IMPUESTO.VisibleIndex = 5
        Me.COL_IMPUESTO.Width = 81
        '
        'rpsPorcEntero
        '
        Me.rpsPorcEntero.AutoHeight = False
        Me.rpsPorcEntero.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPorcEntero.DisplayFormat.FormatString = "{0:#,#} %"
        Me.rpsPorcEntero.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsPorcEntero.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPorcEntero.Name = "rpsPorcEntero"
        Me.rpsPorcEntero.NullText = "0"
        '
        'COL_POR_RECARGO
        '
        Me.COL_POR_RECARGO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_POR_RECARGO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_POR_RECARGO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_POR_RECARGO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_POR_RECARGO.Caption = "Recargo (%)"
        Me.COL_POR_RECARGO.ColumnEdit = Me.rpsPorcentaje
        Me.COL_POR_RECARGO.FieldName = "PORC_RECARGO"
        Me.COL_POR_RECARGO.Name = "COL_POR_RECARGO"
        Me.COL_POR_RECARGO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "PORC_RECARGO", "{0:0.0,00}")})
        Me.COL_POR_RECARGO.Visible = True
        Me.COL_POR_RECARGO.VisibleIndex = 6
        Me.COL_POR_RECARGO.Width = 83
        '
        'rpsPorcentaje
        '
        Me.rpsPorcentaje.AutoHeight = False
        Me.rpsPorcentaje.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPorcentaje.DisplayFormat.FormatString = "{0:0,0.00} %"
        Me.rpsPorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsPorcentaje.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPorcentaje.Name = "rpsPorcentaje"
        Me.rpsPorcentaje.NullText = "0"
        '
        'COL_FAMILIA
        '
        Me.COL_FAMILIA.Caption = "Familia"
        Me.COL_FAMILIA.FieldName = "FAMILIA"
        Me.COL_FAMILIA.Name = "COL_FAMILIA"
        Me.COL_FAMILIA.Visible = True
        Me.COL_FAMILIA.VisibleIndex = 7
        '
        'rpsDecimal
        '
        Me.rpsDecimal.AutoHeight = False
        Me.rpsDecimal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDecimal.DisplayFormat.FormatString = "{0:0,0.00}"
        Me.rpsDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsDecimal.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDecimal.Name = "rpsDecimal"
        Me.rpsDecimal.NullText = "0"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnBuscarFamilia)
        Me.PanelControl2.Controls.Add(Me.txtFamilia)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.btnImprimir)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.btnBuscarProveedor)
        Me.PanelControl2.Controls.Add(Me.txtProveedor)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(13, 13)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(299, 183)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(206, 134)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 30)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnBuscarFamilia
        '
        Me.btnBuscarFamilia.Location = New System.Drawing.Point(259, 88)
        Me.btnBuscarFamilia.Name = "btnBuscarFamilia"
        Me.btnBuscarFamilia.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarFamilia.TabIndex = 22
        Me.btnBuscarFamilia.Text = "+"
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(15, 88)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFamilia.Properties.Appearance.Options.UseBackColor = True
        Me.txtFamilia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFamilia.Properties.ReadOnly = True
        Me.txtFamilia.Size = New System.Drawing.Size(242, 22)
        Me.txtFamilia.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Familia:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(110, 134)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 30)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(13, 134)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(80, 30)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(257, 43)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarProveedor.TabIndex = 14
        Me.btnBuscarProveedor.Text = "+"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(13, 43)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProveedor.Properties.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(242, 22)
        Me.txtProveedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        '
        'FrmRptRecargoPreciosPorProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 539)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRptRecargoPreciosPorProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de recargo de precios p/Proveedor"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPorcEntero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ULTIMO_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_IMPUESTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCaracteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDecimal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPorcentaje As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_POR_RECARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkCodigo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDescripcion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rpsPorcEntero As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_FAMILIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimirGrilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarFamilia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
End Class
