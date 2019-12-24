<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcionProdSuc
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
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_ID_ITEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_PRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaraceteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ID_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_UND_MEDIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_LINEA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDecimales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_COSTO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_NUEVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD_RECEP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConfirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnRemisiones = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEstado = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsrRecepcion = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaRecepcion = New System.Windows.Forms.MaskedTextBox()
        Me.txtRemision = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtDestino = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaraceteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsrRecepcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(915, 503)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(11, 158)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(747, 334)
        Me.PanelControl3.TabIndex = 4
        '
        'txtBuscar
        '
        Me.txtBuscar.EditValue = ""
        Me.txtBuscar.Location = New System.Drawing.Point(27, 26)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Properties.Appearance.Options.UseBackColor = True
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Size = New System.Drawing.Size(353, 22)
        Me.txtBuscar.TabIndex = 53
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(15, 15)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaraceteres, Me.rpsDecimales, Me.rpsCantidad})
        Me.gridItems.Size = New System.Drawing.Size(717, 304)
        Me.gridItems.TabIndex = 0
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_ID_ITEM, Me.COL_ID_PRODUCTO, Me.COL_CODIGO_BARRAS, Me.COL_ID_PROVEEDOR, Me.COL_ID_UND_MEDIDA, Me.COL_ID_LINEA, Me.COL_DESCRIPCION, Me.COL_CANTIDAD, Me.COL_PRECIO_VENTA, Me.COL_COSTO_UNITARIO, Me.COL_NUEVO, Me.COL_CANTIDAD_RECEP})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_ID_ITEM
        '
        Me.COL_ID_ITEM.Caption = "IDITEM"
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
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.rpsCaraceteres
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 116
        '
        'rpsCaraceteres
        '
        Me.rpsCaraceteres.AutoHeight = False
        Me.rpsCaraceteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaraceteres.Name = "rpsCaraceteres"
        Me.rpsCaraceteres.ReadOnly = True
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
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsCaraceteres
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 359
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "CANTIDAD"
        Me.COL_CANTIDAD.ColumnEdit = Me.rpsDecimales
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 2
        Me.COL_CANTIDAD.Width = 110
        '
        'rpsDecimales
        '
        Me.rpsDecimales.AutoHeight = False
        Me.rpsDecimales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDecimales.Mask.EditMask = "n"
        Me.rpsDecimales.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDecimales.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDecimales.Name = "rpsDecimales"
        Me.rpsDecimales.ReadOnly = True
        '
        'COL_PRECIO_VENTA
        '
        Me.COL_PRECIO_VENTA.Caption = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.FieldName = "PRECIO_VENTA"
        Me.COL_PRECIO_VENTA.Name = "COL_PRECIO_VENTA"
        '
        'COL_COSTO_UNITARIO
        '
        Me.COL_COSTO_UNITARIO.Caption = "COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Name = "COL_COSTO_UNITARIO"
        '
        'COL_NUEVO
        '
        Me.COL_NUEVO.Caption = "NUEVO"
        Me.COL_NUEVO.FieldName = "NUEVO"
        Me.COL_NUEVO.Name = "COL_NUEVO"
        '
        'COL_CANTIDAD_RECEP
        '
        Me.COL_CANTIDAD_RECEP.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD_RECEP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD_RECEP.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD_RECEP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD_RECEP.Caption = "RECEPCIONADO"
        Me.COL_CANTIDAD_RECEP.ColumnEdit = Me.rpsCantidad
        Me.COL_CANTIDAD_RECEP.FieldName = "CANTIDAD_RECEP"
        Me.COL_CANTIDAD_RECEP.Name = "COL_CANTIDAD_RECEP"
        Me.COL_CANTIDAD_RECEP.Visible = True
        Me.COL_CANTIDAD_RECEP.VisibleIndex = 3
        Me.COL_CANTIDAD_RECEP.Width = 114
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
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnImprimir)
        Me.PanelControl4.Controls.Add(Me.btnCancelar)
        Me.PanelControl4.Controls.Add(Me.btnConfirmar)
        Me.PanelControl4.Location = New System.Drawing.Point(764, 11)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(139, 481)
        Me.PanelControl4.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(20, 54)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(99, 30)
        Me.btnImprimir.TabIndex = 54
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(20, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(20, 18)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(99, 30)
        Me.btnConfirmar.TabIndex = 52
        Me.btnConfirmar.Text = "Confirmar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnRemisiones)
        Me.PanelControl2.Controls.Add(Me.txtEstado)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.txtUsrRecepcion)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.txtFechaRecepcion)
        Me.PanelControl2.Controls.Add(Me.txtRemision)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.txtOrigen)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.txtFecha)
        Me.PanelControl2.Controls.Add(Me.txtDestino)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 11)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(747, 141)
        Me.PanelControl2.TabIndex = 2
        '
        'btnRemisiones
        '
        Me.btnRemisiones.Location = New System.Drawing.Point(338, 14)
        Me.btnRemisiones.Name = "btnRemisiones"
        Me.btnRemisiones.Size = New System.Drawing.Size(30, 22)
        Me.btnRemisiones.TabIndex = 52
        Me.btnRemisiones.Text = "..."
        '
        'txtEstado
        '
        Me.txtEstado.EditValue = ""
        Me.txtEstado.Location = New System.Drawing.Point(471, 75)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEstado.Properties.Appearance.Options.UseBackColor = True
        Me.txtEstado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtEstado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Properties.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(247, 22)
        Me.txtEstado.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(421, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Estado:"
        '
        'txtUsrRecepcion
        '
        Me.txtUsrRecepcion.EditValue = ""
        Me.txtUsrRecepcion.Location = New System.Drawing.Point(471, 47)
        Me.txtUsrRecepcion.Name = "txtUsrRecepcion"
        Me.txtUsrRecepcion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUsrRecepcion.Properties.Appearance.Options.UseBackColor = True
        Me.txtUsrRecepcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUsrRecepcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsrRecepcion.Properties.ReadOnly = True
        Me.txtUsrRecepcion.Size = New System.Drawing.Size(247, 22)
        Me.txtUsrRecepcion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(385, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Usuario Recep.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "FechaRecep.:"
        '
        'txtFechaRecepcion
        '
        Me.txtFechaRecepcion.BackColor = System.Drawing.Color.White
        Me.txtFechaRecepcion.Location = New System.Drawing.Point(471, 15)
        Me.txtFechaRecepcion.Mask = "00/00/0000"
        Me.txtFechaRecepcion.Name = "txtFechaRecepcion"
        Me.txtFechaRecepcion.ReadOnly = True
        Me.txtFechaRecepcion.Size = New System.Drawing.Size(247, 21)
        Me.txtFechaRecepcion.TabIndex = 4
        Me.txtFechaRecepcion.ValidatingType = GetType(Date)
        '
        'txtRemision
        '
        Me.txtRemision.EditValue = ""
        Me.txtRemision.Location = New System.Drawing.Point(121, 14)
        Me.txtRemision.Name = "txtRemision"
        Me.txtRemision.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRemision.Properties.Appearance.Options.UseBackColor = True
        Me.txtRemision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtRemision.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemision.Size = New System.Drawing.Size(212, 22)
        Me.txtRemision.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Remision Nro.:"
        '
        'txtOrigen
        '
        Me.txtOrigen.EditValue = ""
        Me.txtOrigen.Location = New System.Drawing.Point(121, 45)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtOrigen.Properties.Appearance.Options.UseBackColor = True
        Me.txtOrigen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtOrigen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrigen.Properties.ReadOnly = True
        Me.txtOrigen.Size = New System.Drawing.Size(247, 22)
        Me.txtOrigen.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Origen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Fecha registro:"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(121, 101)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(247, 21)
        Me.txtFecha.TabIndex = 3
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtDestino
        '
        Me.txtDestino.EditValue = ""
        Me.txtDestino.Location = New System.Drawing.Point(121, 73)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDestino.Properties.Appearance.Options.UseBackColor = True
        Me.txtDestino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDestino.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDestino.Properties.ReadOnly = True
        Me.txtDestino.Size = New System.Drawing.Size(247, 22)
        Me.txtDestino.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Destino:"
        '
        'FrmRecepcionProdSuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 527)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRecepcionProdSuc"
        Me.Text = "Recepcion de remisiones de productos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaraceteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsrRecepcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnRemisiones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEstado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsrRecepcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFechaRecepcion As MaskedTextBox
    Friend WithEvents txtRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents txtDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents COL_ID_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_PRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaraceteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_ID_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_UND_MEDIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_LINEA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsDecimales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_PRECIO_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_NUEVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD_RECEP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
