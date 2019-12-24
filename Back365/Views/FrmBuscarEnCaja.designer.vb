<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarEnCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarEnCaja))
        Me.lblPrecioVenta = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescripcion = New DevExpress.XtraEditors.LabelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.tablaProductos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodBarras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecioVenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colBuscarEnCaja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioVenta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPrecioVenta.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblPrecioVenta.Location = New System.Drawing.Point(17, 55)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(142, 19)
        Me.lblPrecioVenta.TabIndex = 1
        Me.lblPrecioVenta.Text = " PRECIO DE VENTA"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(17, 18)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(292, 25)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "DESCRIPCION DEL PRODUCTO"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(117, 55)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(90, 30)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnAgregar
        '
        Me.btnAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Appearance.Options.UseFont = True
        Me.btnAgregar.Location = New System.Drawing.Point(11, 55)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 30)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = " Aceptar"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(87, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodigo.Size = New System.Drawing.Size(219, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'tablaProductos
        '
        Me.tablaProductos.Location = New System.Drawing.Point(15, 51)
        Me.tablaProductos.MainView = Me.GridView1
        Me.tablaProductos.Name = "tablaProductos"
        Me.tablaProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.tablaProductos.Size = New System.Drawing.Size(827, 245)
        Me.tablaProductos.TabIndex = 4
        Me.tablaProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodBarras, Me.colDescripcion, Me.colPrecioVenta, Me.colBuscarEnCaja})
        Me.GridView1.GridControl = Me.tablaProductos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsPrint.RtfPageFooter = resources.GetString("GridView1.OptionsPrint.RtfPageFooter")
        Me.GridView1.OptionsPrint.RtfReportHeader = resources.GetString("GridView1.OptionsPrint.RtfReportHeader")
        Me.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodBarras
        '
        Me.colCodBarras.AppearanceCell.Options.UseTextOptions = True
        Me.colCodBarras.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodBarras.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodBarras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodBarras.Caption = "CODIGO BARRAS"
        Me.colCodBarras.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodBarras.FieldName = "CODIGO_BARRAS"
        Me.colCodBarras.Name = "colCodBarras"
        Me.colCodBarras.OptionsColumn.AllowEdit = False
        Me.colCodBarras.OptionsColumn.ReadOnly = True
        Me.colCodBarras.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "CODIGO_BARRAS", "Total Items", "<Null>")})
        Me.colCodBarras.Visible = True
        Me.colCodBarras.VisibleIndex = 0
        Me.colCodBarras.Width = 164
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "DESCRIPCION"
        Me.colDescripcion.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colDescripcion.FieldName = "DESCRIPCION"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 365
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colPrecioVenta
        '
        Me.colPrecioVenta.AppearanceCell.Options.UseTextOptions = True
        Me.colPrecioVenta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioVenta.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioVenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioVenta.Caption = "PRECIO VENTA"
        Me.colPrecioVenta.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colPrecioVenta.FieldName = "PRECIO_VENTA"
        Me.colPrecioVenta.Name = "colPrecioVenta"
        Me.colPrecioVenta.OptionsColumn.AllowEdit = False
        Me.colPrecioVenta.OptionsColumn.ReadOnly = True
        Me.colPrecioVenta.Visible = True
        Me.colPrecioVenta.VisibleIndex = 2
        Me.colPrecioVenta.Width = 193
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colBuscarEnCaja
        '
        Me.colBuscarEnCaja.AppearanceCell.Options.UseTextOptions = True
        Me.colBuscarEnCaja.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBuscarEnCaja.AppearanceHeader.Options.UseTextOptions = True
        Me.colBuscarEnCaja.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBuscarEnCaja.Caption = "BUSCAR EN CAJA"
        Me.colBuscarEnCaja.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colBuscarEnCaja.FieldName = "BUSCAR_EN_CAJA"
        Me.colBuscarEnCaja.Name = "colBuscarEnCaja"
        Me.colBuscarEnCaja.OptionsColumn.AllowEdit = False
        Me.colBuscarEnCaja.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BUSCAR_EN_CAJA", "{0}")})
        Me.colBuscarEnCaja.Visible = True
        Me.colBuscarEnCaja.VisibleIndex = 3
        Me.colBuscarEnCaja.Width = 156
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "S"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnImprimir)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.btnAgregar)
        Me.PanelControl1.Controls.Add(Me.txtCodigo)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(325, 117)
        Me.PanelControl1.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(220, 56)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod. barras:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblPrecioVenta)
        Me.PanelControl2.Controls.Add(Me.lblDescripcion)
        Me.PanelControl2.Location = New System.Drawing.Point(343, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(526, 117)
        Me.PanelControl2.TabIndex = 7
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.tablaProductos)
        Me.PanelControl3.Location = New System.Drawing.Point(11, 135)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(858, 313)
        Me.PanelControl3.TabIndex = 8
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(67, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(344, 22)
        Me.txtBuscar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Buscar:"
        '
        'FrmBuscarEnCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 463)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmBuscarEnCaja"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar productos en caja"
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPrecioVenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tablaProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodBarras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuscarEnCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
End Class
