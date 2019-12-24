<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptRankingProdVendidos
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
        Me.rpsString = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cldHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridProductos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_IMPORTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsImporteItem = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLineas = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLinea = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.txtsucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.rpsString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsImporteItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpsString
        '
        Me.rpsString.AutoHeight = False
        Me.rpsString.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsString.Name = "rpsString"
        '
        'rpsMiles
        '
        Me.rpsMiles.AutoHeight = False
        Me.rpsMiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsMiles.Mask.EditMask = "n0"
        Me.rpsMiles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsMiles.Mask.UseMaskAsDisplayFormat = True
        Me.rpsMiles.Name = "rpsMiles"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cldHasta)
        Me.PanelControl1.Controls.Add(Me.cldDesde)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(683, 441)
        Me.PanelControl1.TabIndex = 0
        '
        'cldHasta
        '
        Me.cldHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldHasta.Location = New System.Drawing.Point(371, 76)
        Me.cldHasta.Name = "cldHasta"
        Me.cldHasta.Size = New System.Drawing.Size(272, 227)
        Me.cldHasta.TabIndex = 2
        '
        'cldDesde
        '
        Me.cldDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldDesde.Location = New System.Drawing.Point(371, 49)
        Me.cldDesde.Name = "cldDesde"
        Me.cldDesde.Size = New System.Drawing.Size(272, 227)
        Me.cldDesde.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridProductos)
        Me.PanelControl3.Location = New System.Drawing.Point(13, 156)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(655, 274)
        Me.PanelControl3.TabIndex = 3
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(26, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Properties.Appearance.Options.UseBackColor = True
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(381, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'gridProductos
        '
        Me.gridProductos.Location = New System.Drawing.Point(17, 17)
        Me.gridProductos.MainView = Me.GridView1
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsImporteItem, Me.rpsCantidad})
        Me.gridProductos.Size = New System.Drawing.Size(622, 240)
        Me.gridProductos.TabIndex = 0
        Me.gridProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_PRECIO_VENTA, Me.COL_CANTIDAD, Me.COL_IMPORTE})
        Me.GridView1.GridControl = Me.gridProductos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.rpsString
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 100
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsString
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 249
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.Caption = "PRECIO VENTA"
        Me.COL_PRECIO_VENTA.ColumnEdit = Me.rpsMiles
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Visible = True
        Me.COL_PRECIO_VENTA.VisibleIndex = 2
        Me.COL_PRECIO_VENTA.Width = 91
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "CANTIDAD"
        Me.COL_CANTIDAD.ColumnEdit = Me.rpsCantidad
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 3
        Me.COL_CANTIDAD.Width = 81
        '
        'rpsCantidad
        '
        Me.rpsCantidad.AutoHeight = False
        Me.rpsCantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCantidad.Mask.EditMask = "n"
        Me.rpsCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.rpsCantidad.Name = "rpsCantidad"
        '
        'COL_IMPORTE
        '
        Me.COL_IMPORTE.AppearanceCell.Options.UseTextOptions = True
        Me.COL_IMPORTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IMPORTE.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_IMPORTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IMPORTE.Caption = "IMPORTE"
        Me.COL_IMPORTE.ColumnEdit = Me.rpsImporteItem
        Me.COL_IMPORTE.FieldName = "IMPORTE"
        Me.COL_IMPORTE.Name = "COL_IMPORTE"
        Me.COL_IMPORTE.Visible = True
        Me.COL_IMPORTE.VisibleIndex = 4
        Me.COL_IMPORTE.Width = 83
        '
        'rpsImporteItem
        '
        Me.rpsImporteItem.AutoHeight = False
        Me.rpsImporteItem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsImporteItem.Mask.EditMask = "n0"
        Me.rpsImporteItem.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsImporteItem.Mask.UseMaskAsDisplayFormat = True
        Me.rpsImporteItem.Name = "rpsImporteItem"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnLineas)
        Me.PanelControl2.Controls.Add(Me.txtLinea)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.btnImprimir)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.btnSucursal)
        Me.PanelControl2.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl2.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl2.Controls.Add(Me.txtsucursal)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(13, 13)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(655, 133)
        Me.PanelControl2.TabIndex = 0
        '
        'btnLineas
        '
        Me.btnLineas.Location = New System.Drawing.Point(358, 93)
        Me.btnLineas.Name = "btnLineas"
        Me.btnLineas.Size = New System.Drawing.Size(27, 21)
        Me.btnLineas.TabIndex = 11
        Me.btnLineas.Text = "+"
        '
        'txtLinea
        '
        Me.txtLinea.Location = New System.Drawing.Point(73, 93)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtLinea.Properties.Appearance.Options.UseBackColor = True
        Me.txtLinea.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtLinea.Size = New System.Drawing.Size(279, 22)
        Me.txtLinea.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(41, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Linea:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(535, 50)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(94, 31)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(535, 13)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 31)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(535, 88)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 31)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(358, 64)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaHasta.TabIndex = 9
        Me.btnFechaHasta.Text = "+"
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(358, 36)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaDesde.TabIndex = 8
        Me.btnFechaDesde.Text = "+"
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(358, 9)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(27, 21)
        Me.btnSucursal.TabIndex = 7
        Me.btnSucursal.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(73, 65)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaHasta.TabIndex = 2
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(73, 36)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaDesde.TabIndex = 1
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'txtsucursal
        '
        Me.txtsucursal.Location = New System.Drawing.Point(73, 9)
        Me.txtsucursal.Name = "txtsucursal"
        Me.txtsucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtsucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtsucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtsucursal.Size = New System.Drawing.Size(279, 22)
        Me.txtsucursal.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(7, 68)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Fecha hasta:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Fecha desde:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Sucursal:"
        '
        'FrmRptRankingProdVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 465)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRptRankingProdVendidos"
        Me.Text = "Reporte de productos vendidos"
        CType(Me.rpsString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsImporteItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cldHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents txtsucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cldDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLineas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rpsCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_IMPORTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsImporteItem As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsString As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
