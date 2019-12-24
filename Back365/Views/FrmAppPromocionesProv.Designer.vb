<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAppPromocionesProv
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
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCodigoBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_COSTO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cldHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(872, 463)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 144)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(849, 307)
        Me.PanelControl3.TabIndex = 1
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(16, 17)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCodigoBarras, Me.rpsDescripcion, Me.RepositoryItemTextEdit1})
        Me.gridItems.Size = New System.Drawing.Size(709, 274)
        Me.gridItems.TabIndex = 0
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LemonChiffon
        Me.GridView1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_COSTO_UNITARIO, Me.COL_PRECIO_VENTA, Me.COL_IDENTIFICADOR, Me.COL_CANTIDAD})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.rpsCodigoBarras
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 130
        '
        'rpsCodigoBarras
        '
        Me.rpsCodigoBarras.AutoHeight = False
        Me.rpsCodigoBarras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCodigoBarras.Name = "rpsCodigoBarras"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsDescripcion
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 378
        '
        'rpsDescripcion
        '
        Me.rpsDescripcion.AutoHeight = False
        Me.rpsDescripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDescripcion.Name = "rpsDescripcion"
        Me.rpsDescripcion.ReadOnly = True
        '
        'COL_COSTO_UNITARIO
        '
        Me.COL_COSTO_UNITARIO.Caption = "COSTO"
        Me.COL_COSTO_UNITARIO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Name = "COL_COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Width = 89
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.Caption = "PRECIO VENTA"
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Width = 94
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.Caption = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "CANTIDAD"
        Me.COL_CANTIDAD.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnImprimir)
        Me.PanelControl2.Controls.Add(Me.btnBuscar)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.btnProveedor)
        Me.PanelControl2.Controls.Add(Me.btnSucursal)
        Me.PanelControl2.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl2.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl2.Controls.Add(Me.txtProveedor)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.txtNombre)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(849, 126)
        Me.PanelControl2.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(725, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 33)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(632, 58)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 33)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(557, 70)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(27, 22)
        Me.btnFechaHasta.TabIndex = 15
        Me.btnFechaHasta.Text = "+"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(632, 17)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 33)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(557, 42)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(27, 22)
        Me.btnFechaDesde.TabIndex = 14
        Me.btnFechaDesde.Text = "+"
        '
        'btnProveedor
        '
        Me.btnProveedor.Location = New System.Drawing.Point(261, 69)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(27, 22)
        Me.btnProveedor.TabIndex = 13
        Me.btnProveedor.Text = "+"
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(261, 41)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(27, 22)
        Me.btnSucursal.TabIndex = 12
        Me.btnSucursal.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(373, 69)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(178, 21)
        Me.txtFechaHasta.TabIndex = 11
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(373, 43)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(178, 21)
        Me.txtFechaDesde.TabIndex = 10
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(80, 69)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProveedor.Size = New System.Drawing.Size(177, 22)
        Me.txtProveedor.TabIndex = 9
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(80, 42)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Size = New System.Drawing.Size(177, 22)
        Me.txtSucursal.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(80, 14)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNombre.Size = New System.Drawing.Size(504, 22)
        Me.txtNombre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'cldHasta
        '
        Me.cldHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldHasta.Location = New System.Drawing.Point(353, 92)
        Me.cldHasta.Name = "cldHasta"
        Me.cldHasta.Size = New System.Drawing.Size(258, 227)
        Me.cldHasta.TabIndex = 2
        '
        'cldDesde
        '
        Me.cldDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldDesde.Location = New System.Drawing.Point(353, 64)
        Me.cldDesde.Name = "cldDesde"
        Me.cldDesde.Size = New System.Drawing.Size(258, 227)
        Me.cldDesde.TabIndex = 18
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(725, 57)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(87, 33)
        Me.btnImprimir.TabIndex = 19
        Me.btnImprimir.Text = "Imprimir"
        '
        'FrmAppPromocionesProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 538)
        Me.Controls.Add(Me.cldDesde)
        Me.Controls.Add(Me.cldHasta)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmAppPromocionesProv"
        Me.Text = "Promociones por proveedor"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCodigoBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cldHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
End Class
