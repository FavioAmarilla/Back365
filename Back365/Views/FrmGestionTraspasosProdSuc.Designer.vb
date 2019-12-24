<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionTraspasosProdSuc
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
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConfirmar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
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
        Me.COL_NUEVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD_RECEP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidadRecep = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtEstado = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsrRecepcion = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaRecepcion = New System.Windows.Forms.MaskedTextBox()
        Me.txtRemision = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemisiones = New DevExpress.XtraEditors.SimpleButton()
        Me.txtOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnOrigen = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtDestino = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDestino = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadRecep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsrRecepcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(921, 513)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnImprimir)
        Me.PanelControl4.Controls.Add(Me.btnAceptar)
        Me.PanelControl4.Controls.Add(Me.btnAnular)
        Me.PanelControl4.Controls.Add(Me.btnCancelar)
        Me.PanelControl4.Controls.Add(Me.btnConfirmar)
        Me.PanelControl4.Location = New System.Drawing.Point(767, 16)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(139, 481)
        Me.PanelControl4.TabIndex = 54
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(20, 124)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(99, 30)
        Me.btnImprimir.TabIndex = 54
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(20, 18)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Actualizar"
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(20, 88)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(99, 30)
        Me.btnAnular.TabIndex = 53
        Me.btnAnular.Text = "Anular"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(20, 160)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(20, 52)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(99, 30)
        Me.btnConfirmar.TabIndex = 52
        Me.btnConfirmar.Text = "Confirmar"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnAgregar)
        Me.PanelControl3.Controls.Add(Me.btnQuitar)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 163)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(747, 334)
        Me.PanelControl3.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(568, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 24)
        Me.btnAgregar.TabIndex = 37
        Me.btnAgregar.Text = "Agregar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(654, 10)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(80, 24)
        Me.btnQuitar.TabIndex = 36
        Me.btnQuitar.Text = "Quitar"
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(12, 42)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCodBarras, Me.txtDescripcion, Me.txtCantidad, Me.txtCantidadRecep})
        Me.gridItems.Size = New System.Drawing.Size(722, 275)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_ID_ITEM, Me.COL_ID_PRODUCTO, Me.COL_CODIGO_BARRAS, Me.COL_ID_PROVEEDOR, Me.COL_ID_UND_MEDIDA, Me.COL_ID_LINEA, Me.COL_DESCRIPCION, Me.COL_CANTIDAD, Me.COL_PRECIO_VENTA, Me.COL_COSTO, Me.COL_NUEVO, Me.COL_CANTIDAD_RECEP})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_ID_ITEM
        '
        Me.COL_ID_ITEM.Caption = "ID ITEM"
        Me.COL_ID_ITEM.FieldName = "ID_ITEM"
        Me.COL_ID_ITEM.Name = "COL_ID_ITEM"
        Me.COL_ID_ITEM.OptionsColumn.ReadOnly = True
        '
        'COL_ID_PRODUCTO
        '
        Me.COL_ID_PRODUCTO.Caption = "ID PRODUCTO"
        Me.COL_ID_PRODUCTO.FieldName = "ID_PRODUCTO"
        Me.COL_ID_PRODUCTO.Name = "COL_ID_PRODUCTO"
        Me.COL_ID_PRODUCTO.OptionsColumn.ReadOnly = True
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.txtCodBarras
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 119
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
        Me.COL_ID_PROVEEDOR.OptionsColumn.ReadOnly = True
        '
        'COL_ID_UND_MEDIDA
        '
        Me.COL_ID_UND_MEDIDA.Caption = "ID UND MEDIDA"
        Me.COL_ID_UND_MEDIDA.FieldName = "ID_UND_MEDIDA"
        Me.COL_ID_UND_MEDIDA.Name = "COL_ID_UND_MEDIDA"
        Me.COL_ID_UND_MEDIDA.OptionsColumn.ReadOnly = True
        '
        'COL_ID_LINEA
        '
        Me.COL_ID_LINEA.Caption = "ID LINEA"
        Me.COL_ID_LINEA.FieldName = "ID_LINEA"
        Me.COL_ID_LINEA.Name = "COL_ID_LINEA"
        Me.COL_ID_LINEA.OptionsColumn.ReadOnly = True
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.txtDescripcion
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.OptionsColumn.ReadOnly = True
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 390
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoHeight = False
        Me.txtDescripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDescripcion.Name = "txtDescripcion"
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
        Me.COL_CANTIDAD.Width = 89
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
        Me.COL_PRECIO_VENTA.OptionsColumn.ReadOnly = True
        Me.COL_PRECIO_VENTA.Width = 107
        '
        'COL_COSTO
        '
        Me.COL_COSTO.Caption = "COSTO UNITARIO"
        Me.COL_COSTO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO.Name = "COL_COSTO"
        Me.COL_COSTO.OptionsColumn.ReadOnly = True
        Me.COL_COSTO.Width = 105
        '
        'COL_NUEVO
        '
        Me.COL_NUEVO.Caption = "NUEVO"
        Me.COL_NUEVO.FieldName = "NUEVO"
        Me.COL_NUEVO.Name = "COL_NUEVO"
        Me.COL_NUEVO.OptionsColumn.ReadOnly = True
        '
        'COL_CANTIDAD_RECEP
        '
        Me.COL_CANTIDAD_RECEP.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD_RECEP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD_RECEP.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD_RECEP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD_RECEP.Caption = "RECEPCIONADO"
        Me.COL_CANTIDAD_RECEP.ColumnEdit = Me.txtCantidadRecep
        Me.COL_CANTIDAD_RECEP.FieldName = "CANTIDAD_RECEP"
        Me.COL_CANTIDAD_RECEP.Name = "COL_CANTIDAD_RECEP"
        Me.COL_CANTIDAD_RECEP.OptionsColumn.ReadOnly = True
        Me.COL_CANTIDAD_RECEP.Width = 106
        '
        'txtCantidadRecep
        '
        Me.txtCantidadRecep.AutoHeight = False
        Me.txtCantidadRecep.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCantidadRecep.Mask.EditMask = "n2"
        Me.txtCantidadRecep.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidadRecep.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidadRecep.Name = "txtCantidadRecep"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtEstado)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.txtUsrRecepcion)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.txtFechaRecepcion)
        Me.PanelControl2.Controls.Add(Me.txtRemision)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.btnRemisiones)
        Me.PanelControl2.Controls.Add(Me.txtOrigen)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.btnOrigen)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.txtFecha)
        Me.PanelControl2.Controls.Add(Me.txtDestino)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.btnDestino)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 16)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(747, 141)
        Me.PanelControl2.TabIndex = 0
        '
        'txtEstado
        '
        Me.txtEstado.EditValue = ""
        Me.txtEstado.Location = New System.Drawing.Point(477, 75)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEstado.Properties.Appearance.Options.UseBackColor = True
        Me.txtEstado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtEstado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Properties.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(231, 22)
        Me.txtEstado.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(427, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Estado:"
        '
        'txtUsrRecepcion
        '
        Me.txtUsrRecepcion.EditValue = ""
        Me.txtUsrRecepcion.Location = New System.Drawing.Point(477, 47)
        Me.txtUsrRecepcion.Name = "txtUsrRecepcion"
        Me.txtUsrRecepcion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUsrRecepcion.Properties.Appearance.Options.UseBackColor = True
        Me.txtUsrRecepcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUsrRecepcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsrRecepcion.Properties.ReadOnly = True
        Me.txtUsrRecepcion.Size = New System.Drawing.Size(231, 22)
        Me.txtUsrRecepcion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(391, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Usuario Recep.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "FechaRecep.:"
        '
        'txtFechaRecepcion
        '
        Me.txtFechaRecepcion.Location = New System.Drawing.Point(477, 15)
        Me.txtFechaRecepcion.Mask = "00/00/0000"
        Me.txtFechaRecepcion.Name = "txtFechaRecepcion"
        Me.txtFechaRecepcion.Size = New System.Drawing.Size(231, 21)
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
        Me.txtRemision.Size = New System.Drawing.Size(231, 22)
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
        'btnRemisiones
        '
        Me.btnRemisiones.Location = New System.Drawing.Point(356, 14)
        Me.btnRemisiones.Name = "btnRemisiones"
        Me.btnRemisiones.Size = New System.Drawing.Size(26, 20)
        Me.btnRemisiones.TabIndex = 45
        Me.btnRemisiones.Text = "+"
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
        Me.txtOrigen.Size = New System.Drawing.Size(231, 22)
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
        'btnOrigen
        '
        Me.btnOrigen.Location = New System.Drawing.Point(356, 45)
        Me.btnOrigen.Name = "btnOrigen"
        Me.btnOrigen.Size = New System.Drawing.Size(26, 20)
        Me.btnOrigen.TabIndex = 41
        Me.btnOrigen.Text = "+"
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
        Me.txtFecha.Location = New System.Drawing.Point(121, 101)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(261, 21)
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
        Me.txtDestino.Size = New System.Drawing.Size(231, 22)
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
        'btnDestino
        '
        Me.btnDestino.Location = New System.Drawing.Point(356, 73)
        Me.btnDestino.Name = "btnDestino"
        Me.btnDestino.Size = New System.Drawing.Size(26, 20)
        Me.btnDestino.TabIndex = 33
        Me.btnDestino.Text = "+"
        '
        'FrmGestionTraspasosProdSuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 537)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmGestionTraspasosProdSuc"
        Me.ShowIcon = False
        Me.ShowMdiChildCaptionInParentTitle = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de traspaso de producos a almacenes"
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadRecep, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDestino As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As MaskedTextBox
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
    Friend WithEvents COL_ID_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_LINEA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCodigoBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCodBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemisiones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUsrRecepcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFechaRecepcion As MaskedTextBox
    Friend WithEvents COL_NUEVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEstado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfirmar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents COL_CANTIDAD_RECEP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCantidadRecep As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
