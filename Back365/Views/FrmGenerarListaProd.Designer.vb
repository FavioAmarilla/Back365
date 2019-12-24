<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarListaProd
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
        Me.btnCargarProd = New DevExpress.XtraEditors.SimpleButton()
        Me.gridProductos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_COD_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCosto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(736, 473)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnQuitar)
        Me.PanelControl3.Controls.Add(Me.btnCargarProd)
        Me.PanelControl3.Controls.Add(Me.gridProductos)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 132)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(706, 327)
        Me.PanelControl3.TabIndex = 1
        '
        'btnCargarProd
        '
        Me.btnCargarProd.Location = New System.Drawing.Point(525, 9)
        Me.btnCargarProd.Name = "btnCargarProd"
        Me.btnCargarProd.Size = New System.Drawing.Size(80, 25)
        Me.btnCargarProd.TabIndex = 43
        Me.btnCargarProd.Text = "Cargar Prod."
        '
        'gridProductos
        '
        Me.gridProductos.Location = New System.Drawing.Point(14, 40)
        Me.gridProductos.MainView = Me.GridView1
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCodigo, Me.rpsDescripcion, Me.rpsCosto, Me.rpsPrecio, Me.rpsCantidad})
        Me.gridProductos.Size = New System.Drawing.Size(677, 273)
        Me.gridProductos.TabIndex = 0
        Me.gridProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_COD_BARRAS, Me.COL_DESCRIPCION, Me.COL_COSTO, Me.COL_PRECIO_VENTA, Me.COL_CANTIDAD})
        Me.GridView1.GridControl = Me.gridProductos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_COD_BARRAS
        '
        Me.COL_COD_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_COD_BARRAS.ColumnEdit = Me.rpsCodigo
        Me.COL_COD_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_COD_BARRAS.Name = "COL_COD_BARRAS"
        Me.COL_COD_BARRAS.Visible = True
        Me.COL_COD_BARRAS.VisibleIndex = 0
        Me.COL_COD_BARRAS.Width = 107
        '
        'rpsCodigo
        '
        Me.rpsCodigo.AutoHeight = False
        Me.rpsCodigo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCodigo.Name = "rpsCodigo"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsDescripcion
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 255
        '
        'rpsDescripcion
        '
        Me.rpsDescripcion.AutoHeight = False
        Me.rpsDescripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDescripcion.Name = "rpsDescripcion"
        '
        'COL_COSTO
        '
        Me.COL_COSTO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_COSTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_COSTO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO.Caption = "COSTO UNIT."
        Me.COL_COSTO.ColumnEdit = Me.rpsCosto
        Me.COL_COSTO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO.Name = "COL_COSTO"
        Me.COL_COSTO.Visible = True
        Me.COL_COSTO.VisibleIndex = 3
        Me.COL_COSTO.Width = 97
        '
        'rpsCosto
        '
        Me.rpsCosto.AutoHeight = False
        Me.rpsCosto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCosto.Mask.EditMask = "n0"
        Me.rpsCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsCosto.Mask.UseMaskAsDisplayFormat = True
        Me.rpsCosto.Name = "rpsCosto"
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.Caption = "PRECIO VENTA"
        Me.COL_PRECIO_VENTA.ColumnEdit = Me.rpsPrecio
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Visible = True
        Me.COL_PRECIO_VENTA.VisibleIndex = 2
        Me.COL_PRECIO_VENTA.Width = 97
        '
        'rpsPrecio
        '
        Me.rpsPrecio.AutoHeight = False
        Me.rpsPrecio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPrecio.Mask.EditMask = "n0"
        Me.rpsPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPrecio.Name = "rpsPrecio"
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
        Me.COL_CANTIDAD.VisibleIndex = 4
        Me.COL_CANTIDAD.Width = 103
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
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnExportar)
        Me.PanelControl2.Controls.Add(Me.btnBuscarSucursal)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(706, 108)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(596, 58)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 32)
        Me.btnCancelar.TabIndex = 43
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(596, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(95, 33)
        Me.btnExportar.TabIndex = 42
        Me.btnExportar.Text = "Exportar"
        '
        'btnBuscarSucursal
        '
        Me.btnBuscarSucursal.Location = New System.Drawing.Point(366, 24)
        Me.btnBuscarSucursal.Name = "btnBuscarSucursal"
        Me.btnBuscarSucursal.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscarSucursal.TabIndex = 2
        Me.btnBuscarSucursal.Text = "+"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(89, 25)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(271, 22)
        Me.txtSucursal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursal:"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(611, 9)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(80, 25)
        Me.btnQuitar.TabIndex = 44
        Me.btnQuitar.Text = "Quitar"
        '
        'FrmGenerarListaProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 497)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmGenerarListaProd"
        Me.Text = "Generar listado de productos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBuscarSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_COD_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCargarProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rpsCodigo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCosto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
End Class
