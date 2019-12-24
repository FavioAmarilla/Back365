<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGenerarArchivoBalanza
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
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSucursales = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gridProductos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_CODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(658, 430)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnConsultar)
        Me.PanelControl3.Controls.Add(Me.txtSucursal)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.btnGenerar)
        Me.PanelControl3.Controls.Add(Me.btnSucursales)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 13)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(630, 107)
        Me.PanelControl3.TabIndex = 6
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(529, 16)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(88, 31)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.Text = "Consultar"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(71, 21)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(276, 22)
        Me.txtSucursal.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Sucursal:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(529, 53)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(88, 31)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        '
        'btnSucursales
        '
        Me.btnSucursales.Location = New System.Drawing.Point(353, 20)
        Me.btnSucursales.Name = "btnSucursales"
        Me.btnSucursales.Size = New System.Drawing.Size(27, 22)
        Me.btnSucursales.TabIndex = 2
        Me.btnSucursales.Text = "+"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gridProductos)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 134)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(630, 282)
        Me.PanelControl2.TabIndex = 5
        '
        'gridProductos
        '
        Me.gridProductos.Location = New System.Drawing.Point(13, 14)
        Me.gridProductos.MainView = Me.GridView1
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.gridProductos.Size = New System.Drawing.Size(604, 255)
        Me.gridProductos.TabIndex = 3
        Me.gridProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_CODIGO, Me.COL_DESCRIPCION, Me.COL_PRECIO_VENTA, Me.COL_PRECIO})
        Me.GridView1.GridControl = Me.gridProductos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_CODIGO
        '
        Me.COL_CODIGO.Caption = "CODIGO"
        Me.COL_CODIGO.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_CODIGO.FieldName = "CODIGO_BALANZA"
        Me.COL_CODIGO.Name = "COL_CODIGO"
        Me.COL_CODIGO.Visible = True
        Me.COL_CODIGO.VisibleIndex = 0
        Me.COL_CODIGO.Width = 115
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 318
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.Caption = "PRECIO VENTA"
        Me.COL_PRECIO_VENTA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Visible = True
        Me.COL_PRECIO_VENTA.VisibleIndex = 2
        Me.COL_PRECIO_VENTA.Width = 153
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'COL_PRECIO
        '
        Me.COL_PRECIO.Caption = "PRECIO"
        Me.COL_PRECIO.FieldName = "PRECIO"
        Me.COL_PRECIO.Name = "COL_PRECIO"
        '
        'FrmGenerarArchivoBalanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 455)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmGenerarArchivoBalanza"
        Me.Text = "Generar Archivo de balanza"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_CODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSucursales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_PRECIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
End Class
