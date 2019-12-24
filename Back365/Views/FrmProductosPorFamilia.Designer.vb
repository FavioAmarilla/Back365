<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductosPorFamilia
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
        Me.btnNoDefinidos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnVerificar = New DevExpress.XtraEditors.SimpleButton()
        Me.gridProductos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCaracteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_COSTO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ULTIMA_COMPRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFechas = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ULTIMA_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_EXISTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkExiste = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.txtDecimales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarFamilia = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFamilia = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaracteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExiste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(978, 507)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnNoDefinidos)
        Me.PanelControl3.Controls.Add(Me.btnVerificar)
        Me.PanelControl3.Controls.Add(Me.gridProductos)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 127)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(947, 365)
        Me.PanelControl3.TabIndex = 3
        '
        'btnNoDefinidos
        '
        Me.btnNoDefinidos.Location = New System.Drawing.Point(772, 5)
        Me.btnNoDefinidos.Name = "btnNoDefinidos"
        Me.btnNoDefinidos.Size = New System.Drawing.Size(75, 23)
        Me.btnNoDefinidos.TabIndex = 2
        Me.btnNoDefinidos.Text = "No definidos"
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(853, 5)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 1
        Me.btnVerificar.Text = "Verificar"
        '
        'gridProductos
        '
        Me.gridProductos.Location = New System.Drawing.Point(17, 34)
        Me.gridProductos.MainView = Me.GridView1
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCaracteres, Me.txtMiles, Me.txtDecimales, Me.chkExiste, Me.txtFechas})
        Me.gridProductos.Size = New System.Drawing.Size(911, 311)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_CODIGO, Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_PRECIO_VENTA, Me.COL_COSTO_UNITARIO, Me.COL_ULTIMA_COMPRA, Me.COL_ULTIMA_VENTA, Me.COL_EXISTE})
        Me.GridView1.GridControl = Me.gridProductos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.Caption = "Identificador"
        Me.COL_IDENTIFICADOR.ColumnEdit = Me.txtCaracteres
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Visible = True
        Me.COL_IDENTIFICADOR.VisibleIndex = 0
        Me.COL_IDENTIFICADOR.Width = 69
        '
        'txtCaracteres
        '
        Me.txtCaracteres.AutoHeight = False
        Me.txtCaracteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCaracteres.Name = "txtCaracteres"
        '
        'COL_CODIGO
        '
        Me.COL_CODIGO.Caption = "Codigo"
        Me.COL_CODIGO.ColumnEdit = Me.txtCaracteres
        Me.COL_CODIGO.FieldName = "CODIGO"
        Me.COL_CODIGO.Name = "COL_CODIGO"
        Me.COL_CODIGO.Visible = True
        Me.COL_CODIGO.VisibleIndex = 1
        Me.COL_CODIGO.Width = 63
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "Codigo barras"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.txtCaracteres
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 2
        Me.COL_CODIGO_BARRAS.Width = 108
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "Descripcion"
        Me.COL_DESCRIPCION.ColumnEdit = Me.txtCaracteres
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 3
        Me.COL_DESCRIPCION.Width = 281
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.Caption = "Precio venta"
        Me.COL_PRECIO_VENTA.ColumnEdit = Me.txtMiles
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Visible = True
        Me.COL_PRECIO_VENTA.VisibleIndex = 4
        Me.COL_PRECIO_VENTA.Width = 71
        '
        'txtMiles
        '
        Me.txtMiles.AutoHeight = False
        Me.txtMiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtMiles.DisplayFormat.FormatString = "#,#"
        Me.txtMiles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMiles.Name = "txtMiles"
        '
        'COL_COSTO_UNITARIO
        '
        Me.COL_COSTO_UNITARIO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_COSTO_UNITARIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_UNITARIO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_COSTO_UNITARIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_UNITARIO.Caption = "Costo unitario"
        Me.COL_COSTO_UNITARIO.ColumnEdit = Me.txtMiles
        Me.COL_COSTO_UNITARIO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Name = "COL_COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Visible = True
        Me.COL_COSTO_UNITARIO.VisibleIndex = 5
        Me.COL_COSTO_UNITARIO.Width = 80
        '
        'COL_ULTIMA_COMPRA
        '
        Me.COL_ULTIMA_COMPRA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_ULTIMA_COMPRA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_ULTIMA_COMPRA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_ULTIMA_COMPRA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_ULTIMA_COMPRA.Caption = "Ultima compra"
        Me.COL_ULTIMA_COMPRA.ColumnEdit = Me.txtFechas
        Me.COL_ULTIMA_COMPRA.FieldName = "ULTIMA_COMPRA"
        Me.COL_ULTIMA_COMPRA.Name = "COL_ULTIMA_COMPRA"
        Me.COL_ULTIMA_COMPRA.Visible = True
        Me.COL_ULTIMA_COMPRA.VisibleIndex = 6
        Me.COL_ULTIMA_COMPRA.Width = 84
        '
        'txtFechas
        '
        Me.txtFechas.AutoHeight = False
        Me.txtFechas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFechas.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechas.Name = "txtFechas"
        '
        'COL_ULTIMA_VENTA
        '
        Me.COL_ULTIMA_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_ULTIMA_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_ULTIMA_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_ULTIMA_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_ULTIMA_VENTA.Caption = "Ultima venta"
        Me.COL_ULTIMA_VENTA.ColumnEdit = Me.txtFechas
        Me.COL_ULTIMA_VENTA.FieldName = "ULTIMA_VENTA"
        Me.COL_ULTIMA_VENTA.Name = "COL_ULTIMA_VENTA"
        Me.COL_ULTIMA_VENTA.Visible = True
        Me.COL_ULTIMA_VENTA.VisibleIndex = 7
        Me.COL_ULTIMA_VENTA.Width = 78
        '
        'COL_EXISTE
        '
        Me.COL_EXISTE.AppearanceCell.Options.UseTextOptions = True
        Me.COL_EXISTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_EXISTE.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_EXISTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_EXISTE.Caption = "Existe"
        Me.COL_EXISTE.ColumnEdit = Me.chkExiste
        Me.COL_EXISTE.FieldName = "EXISTE"
        Me.COL_EXISTE.Name = "COL_EXISTE"
        Me.COL_EXISTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EXISTE", "{0}")})
        Me.COL_EXISTE.Visible = True
        Me.COL_EXISTE.VisibleIndex = 8
        Me.COL_EXISTE.Width = 59
        '
        'chkExiste
        '
        Me.chkExiste.AutoHeight = False
        Me.chkExiste.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.chkExiste.Name = "chkExiste"
        Me.chkExiste.ValueChecked = "S"
        Me.chkExiste.ValueUnchecked = "N"
        '
        'txtDecimales
        '
        Me.txtDecimales.AutoHeight = False
        Me.txtDecimales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDecimales.Name = "txtDecimales"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.btnBuscarFamilia)
        Me.PanelControl2.Controls.Add(Me.txtFamilia)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(947, 100)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(840, 48)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 29)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(840, 13)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(88, 29)
        Me.btnConsultar.TabIndex = 16
        Me.btnConsultar.Text = "Consultar"
        '
        'btnBuscarFamilia
        '
        Me.btnBuscarFamilia.Location = New System.Drawing.Point(293, 23)
        Me.btnBuscarFamilia.Name = "btnBuscarFamilia"
        Me.btnBuscarFamilia.Size = New System.Drawing.Size(26, 19)
        Me.btnBuscarFamilia.TabIndex = 15
        Me.btnBuscarFamilia.Text = "+"
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(59, 21)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFamilia.Properties.Appearance.Options.UseBackColor = True
        Me.txtFamilia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFamilia.Properties.ReadOnly = True
        Me.txtFamilia.Size = New System.Drawing.Size(228, 22)
        Me.txtFamilia.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Familia:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmProductosPorFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 531)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmProductosPorFamilia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos por familia"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaracteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExiste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarFamilia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents gridProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ULTIMA_COMPRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ULTIMA_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCaracteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDecimales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_EXISTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkExiste As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtFechas As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnVerificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNoDefinidos As DevExpress.XtraEditors.SimpleButton
End Class
