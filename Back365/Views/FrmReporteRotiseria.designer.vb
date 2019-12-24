<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteRotiseria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteRotiseria))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_precio_costo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_precio_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_costo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_venta = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnImprimir)
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtFechaHasta)
        Me.GroupControl1.Controls.Add(Me.txtFechaDesde)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(416, 114)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Rango de Fechas de Reporte"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(305, 71)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(93, 23)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = " Imprimir"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(305, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = " Buscar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(7, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Fecha Hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Fecha Desde:"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(77, 71)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(185, 21)
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(77, 29)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(185, 21)
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'gridItems
        '
        GridLevelNode1.RelationName = "Level1"
        Me.gridItems.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gridItems.Location = New System.Drawing.Point(12, 141)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.Size = New System.Drawing.Size(954, 381)
        Me.gridItems.TabIndex = 1
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_descripcion, Me.col_fecha, Me.col_precio_costo, Me.col_cantidad, Me.col_precio_venta, Me.col_total_costo, Me.col_total_venta})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_descripcion
        '
        Me.col_descripcion.Caption = "DESCRIPCION"
        Me.col_descripcion.FieldName = "DESCRIPCION"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.Visible = True
        Me.col_descripcion.VisibleIndex = 0
        Me.col_descripcion.Width = 325
        '
        'col_fecha
        '
        Me.col_fecha.AppearanceCell.Options.UseTextOptions = True
        Me.col_fecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_fecha.AppearanceHeader.Options.UseTextOptions = True
        Me.col_fecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_fecha.Caption = "FECHA"
        Me.col_fecha.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.col_fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_fecha.FieldName = "FECHA"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.Visible = True
        Me.col_fecha.VisibleIndex = 1
        Me.col_fecha.Width = 105
        '
        'col_precio_costo
        '
        Me.col_precio_costo.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_costo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_precio_costo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_costo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_precio_costo.Caption = "PRECIO COSTO"
        Me.col_precio_costo.DisplayFormat.FormatString = "#,#"
        Me.col_precio_costo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio_costo.FieldName = "PRECIO_COSTO"
        Me.col_precio_costo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col_precio_costo.Name = "col_precio_costo"
        Me.col_precio_costo.Visible = True
        Me.col_precio_costo.VisibleIndex = 3
        Me.col_precio_costo.Width = 105
        '
        'col_cantidad
        '
        Me.col_cantidad.AppearanceCell.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_cantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_cantidad.Caption = "CANTIDAD"
        Me.col_cantidad.FieldName = "CANTIDAD"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CANTIDAD", "{0:0.00}")})
        Me.col_cantidad.Visible = True
        Me.col_cantidad.VisibleIndex = 2
        Me.col_cantidad.Width = 105
        '
        'col_precio_venta
        '
        Me.col_precio_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_precio_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_precio_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_precio_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_precio_venta.Caption = "PRECIO VENTA"
        Me.col_precio_venta.DisplayFormat.FormatString = "#,#"
        Me.col_precio_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_precio_venta.FieldName = "PRECIO_VENTA"
        Me.col_precio_venta.Name = "col_precio_venta"
        Me.col_precio_venta.Visible = True
        Me.col_precio_venta.VisibleIndex = 4
        Me.col_precio_venta.Width = 105
        '
        'col_total_costo
        '
        Me.col_total_costo.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_costo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_total_costo.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_costo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_total_costo.Caption = "TOTAL COSTO"
        Me.col_total_costo.DisplayFormat.FormatString = "#,#"
        Me.col_total_costo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_costo.FieldName = "TOTAL_COSTO"
        Me.col_total_costo.Name = "col_total_costo"
        Me.col_total_costo.OptionsColumn.AllowEdit = False
        Me.col_total_costo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_COSTO", "{0:#,#}")})
        Me.col_total_costo.Visible = True
        Me.col_total_costo.VisibleIndex = 5
        Me.col_total_costo.Width = 105
        '
        'col_total_venta
        '
        Me.col_total_venta.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_total_venta.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_venta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_total_venta.Caption = "TOTAL VENTA"
        Me.col_total_venta.DisplayFormat.FormatString = "#,#"
        Me.col_total_venta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_venta.FieldName = "TOTAL_VENTA"
        Me.col_total_venta.Name = "col_total_venta"
        Me.col_total_venta.OptionsColumn.AllowEdit = False
        Me.col_total_venta.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_VENTA", "{0:#,#}")})
        Me.col_total_venta.Visible = True
        Me.col_total_venta.VisibleIndex = 6
        Me.col_total_venta.Width = 86
        '
        'frm_reporte_rotiseria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 534)
        Me.Controls.Add(Me.gridItems)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_reporte_rotiseria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<<Reporte de Movimiento en Rotiseria>>"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_costo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_precio_venta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_total_costo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_venta As DevExpress.XtraGrid.Columns.GridColumn
End Class
