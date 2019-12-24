<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTraspasoProductosSuc
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
        Me.rpsCodigoBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnNoDefinidos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCargaRapida = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_ID_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_PRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCodBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ID_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_UND_MEDIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_LINEA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnOrigen = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDestino = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDestino = New DevExpress.XtraEditors.SimpleButton()
        Me.cldFecha = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpsCodigoBarras
        '
        Me.rpsCodigoBarras.AutoHeight = False
        Me.rpsCodigoBarras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCodigoBarras.Name = "rpsCodigoBarras"
        '
        'rpsDescripcion
        '
        Me.rpsDescripcion.AutoHeight = False
        Me.rpsDescripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDescripcion.Name = "rpsDescripcion"
        Me.rpsDescripcion.ReadOnly = True
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(937, 513)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnNoDefinidos)
        Me.PanelControl3.Controls.Add(Me.btnCargaRapida)
        Me.PanelControl3.Controls.Add(Me.btnAgregar)
        Me.PanelControl3.Controls.Add(Me.btnQuitar)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 164)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(907, 333)
        Me.PanelControl3.TabIndex = 1
        '
        'btnNoDefinidos
        '
        Me.btnNoDefinidos.Location = New System.Drawing.Point(554, 297)
        Me.btnNoDefinidos.Name = "btnNoDefinidos"
        Me.btnNoDefinidos.Size = New System.Drawing.Size(80, 24)
        Me.btnNoDefinidos.TabIndex = 39
        Me.btnNoDefinidos.Text = "No definidos"
        '
        'btnCargaRapida
        '
        Me.btnCargaRapida.Location = New System.Drawing.Point(640, 297)
        Me.btnCargaRapida.Name = "btnCargaRapida"
        Me.btnCargaRapida.Size = New System.Drawing.Size(80, 24)
        Me.btnCargaRapida.TabIndex = 38
        Me.btnCargaRapida.Text = "Carga rapida"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(726, 297)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 24)
        Me.btnAgregar.TabIndex = 37
        Me.btnAgregar.Text = "Agregar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(812, 297)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(80, 24)
        Me.btnQuitar.TabIndex = 36
        Me.btnQuitar.Text = "Quitar"
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(15, 15)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCodBarras, Me.txtDescripcion, Me.txtCantidad})
        Me.gridItems.Size = New System.Drawing.Size(877, 269)
        Me.gridItems.TabIndex = 0
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_ID_ITEM, Me.COL_ID_PRODUCTO, Me.COL_CODIGO_BARRAS, Me.COL_ID_PROVEEDOR, Me.COL_ID_UND_MEDIDA, Me.COL_ID_LINEA, Me.COL_DESCRIPCION, Me.COL_CANTIDAD, Me.COL_PRECIO_VENTA, Me.COL_COSTO})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_ID_ITEM
        '
        Me.COL_ID_ITEM.Caption = "ID ITEM"
        Me.COL_ID_ITEM.FieldName = "ID_ITEM"
        Me.COL_ID_ITEM.Name = "COL_ID_ITEM"
        '
        'COL_ID_PRODUCTO
        '
        Me.COL_ID_PRODUCTO.Caption = "ID PRODUCTO"
        Me.COL_ID_PRODUCTO.FieldName = "ID_PRODUCTO"
        Me.COL_ID_PRODUCTO.Name = "COL_ID_PRODUCTO"
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.txtCodBarras
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CODIGO_BARRAS", "Items: {#,#}")})
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 123
        '
        'txtCodBarras
        '
        Me.txtCodBarras.AutoHeight = False
        Me.txtCodBarras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodBarras.Name = "txtCodBarras"
        '
        'COL_ID_PROVEEDOR
        '
        Me.COL_ID_PROVEEDOR.Caption = "ID PROVEEDOR"
        Me.COL_ID_PROVEEDOR.FieldName = "ID_PROVEEDOR"
        Me.COL_ID_PROVEEDOR.Name = "COL_ID_PROVEEDOR"
        '
        'COL_ID_UND_MEDIDA
        '
        Me.COL_ID_UND_MEDIDA.Caption = "ID UND MEDIDA"
        Me.COL_ID_UND_MEDIDA.FieldName = "ID_UND_MEDIDA"
        Me.COL_ID_UND_MEDIDA.Name = "COL_ID_UND_MEDIDA"
        '
        'COL_ID_LINEA
        '
        Me.COL_ID_LINEA.Caption = "ID LINEA"
        Me.COL_ID_LINEA.FieldName = "ID_LINEA"
        Me.COL_ID_LINEA.Name = "COL_ID_LINEA"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 414
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "CANTIDAD"
        Me.COL_CANTIDAD.ColumnEdit = Me.txtCantidad
        Me.COL_CANTIDAD.DisplayFormat.FormatString = "n2"
        Me.COL_CANTIDAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 2
        Me.COL_CANTIDAD.Width = 110
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoHeight = False
        Me.txtCantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCantidad.Mask.EditMask = "n2"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_VENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_VENTA.Caption = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.DisplayFormat.FormatString = "#,#"
        Me.COL_PRECIO_VENTA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Width = 107
        '
        'COL_COSTO
        '
        Me.COL_COSTO.Caption = "COSTO UNITARIO"
        Me.COL_COSTO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO.Name = "COL_COSTO"
        Me.COL_COSTO.Width = 105
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtComentario)
        Me.PanelControl2.Controls.Add(Me.Label9)
        Me.PanelControl2.Controls.Add(Me.txtOrigen)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.btnOrigen)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.txtFecha)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.txtDestino)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.btnDestino)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 16)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(907, 142)
        Me.PanelControl2.TabIndex = 0
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(446, 43)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(229, 73)
        Me.txtComentario.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(374, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Comentario:"
        '
        'txtOrigen
        '
        Me.txtOrigen.EditValue = ""
        Me.txtOrigen.Location = New System.Drawing.Point(92, 13)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtOrigen.Properties.Appearance.Options.UseBackColor = True
        Me.txtOrigen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtOrigen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrigen.Properties.ReadOnly = True
        Me.txtOrigen.Size = New System.Drawing.Size(231, 22)
        Me.txtOrigen.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Origen:"
        '
        'btnOrigen
        '
        Me.btnOrigen.Location = New System.Drawing.Point(327, 13)
        Me.btnOrigen.Name = "btnOrigen"
        Me.btnOrigen.Size = New System.Drawing.Size(26, 20)
        Me.btnOrigen.TabIndex = 41
        Me.btnOrigen.Text = "+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(446, 14)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(231, 21)
        Me.txtFecha.TabIndex = 10
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(681, 14)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaDesde.TabIndex = 38
        Me.btnFechaDesde.Text = "+"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(783, 14)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(783, 50)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtDestino
        '
        Me.txtDestino.EditValue = ""
        Me.txtDestino.Location = New System.Drawing.Point(92, 41)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDestino.Properties.Appearance.Options.UseBackColor = True
        Me.txtDestino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDestino.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDestino.Properties.ReadOnly = True
        Me.txtDestino.Size = New System.Drawing.Size(231, 22)
        Me.txtDestino.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Destino:"
        '
        'btnDestino
        '
        Me.btnDestino.Location = New System.Drawing.Point(327, 41)
        Me.btnDestino.Name = "btnDestino"
        Me.btnDestino.Size = New System.Drawing.Size(26, 20)
        Me.btnDestino.TabIndex = 33
        Me.btnDestino.Text = "+"
        '
        'cldFecha
        '
        Me.cldFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFecha.Location = New System.Drawing.Point(708, 42)
        Me.cldFecha.Name = "cldFecha"
        Me.cldFecha.Size = New System.Drawing.Size(242, 227)
        Me.cldFecha.TabIndex = 39
        '
        'FrmTraspasoProductosSuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 537)
        Me.Controls.Add(Me.cldFecha)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmTraspasoProductosSuc"
        Me.ShowIcon = False
        Me.ShowMdiChildCaptionInParentTitle = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traspaso de producos a sucursales"
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDestino As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cldFecha As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_PRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_UND_MEDIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents btnOrigen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As Label
    Friend WithEvents COL_ID_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_LINEA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents rpsCodigoBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCodBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNoDefinidos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCargaRapida As DevExpress.XtraEditors.SimpleButton
End Class
