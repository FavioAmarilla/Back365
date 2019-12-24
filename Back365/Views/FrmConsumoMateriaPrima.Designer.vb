<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsumoMateriaPrima
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
        Me.btnQuitar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsString = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDouble = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsInteger = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_PRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_UND_MEDIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_COSTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtIdEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdUnidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdAlmacen = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdTransaccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlmacen = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAlmacenes = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTransaccion = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTransacciones = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUnidadOperat = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarUnidadOperat = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarEmpresa = New DevExpress.XtraEditors.SimpleButton()
        Me.cldFecha = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDouble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsInteger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtIdEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdUnidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdTransaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransaccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelControl3.Controls.Add(Me.btnQuitar)
        Me.PanelControl3.Controls.Add(Me.txtCantidad)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Controls.Add(Me.Label6)
        Me.PanelControl3.Controls.Add(Me.txtCodigoBarras)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 180)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(907, 317)
        Me.PanelControl3.TabIndex = 1
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(810, 12)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(80, 24)
        Me.btnQuitar.TabIndex = 36
        Me.btnQuitar.Text = "Quitar"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(438, 11)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCantidad.Size = New System.Drawing.Size(231, 24)
        Me.txtCantidad.TabIndex = 31
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(13, 53)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsString, Me.rpsInteger, Me.rpsDouble})
        Me.gridItems.Size = New System.Drawing.Size(877, 244)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_CANTIDAD, Me.COL_PRECIO_UNITARIO, Me.COL_TOTAL, Me.COL_ID_PRODUCTO, Me.COL_ID_UND_MEDIDA, Me.COL_COSTO})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
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
        Me.COL_CODIGO_BARRAS.Width = 132
        '
        'rpsString
        '
        Me.rpsString.AutoHeight = False
        Me.rpsString.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsString.Name = "rpsString"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsString
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 354
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "CANTIDAD"
        Me.COL_CANTIDAD.ColumnEdit = Me.rpsDouble
        Me.COL_CANTIDAD.DisplayFormat.FormatString = "0.000"
        Me.COL_CANTIDAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 2
        Me.COL_CANTIDAD.Width = 122
        '
        'rpsDouble
        '
        Me.rpsDouble.AutoHeight = False
        Me.rpsDouble.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDouble.DisplayFormat.FormatString = "0.000"
        Me.rpsDouble.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsDouble.Mask.EditMask = "n3"
        Me.rpsDouble.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDouble.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDouble.Name = "rpsDouble"
        '
        'COL_PRECIO_UNITARIO
        '
        Me.COL_PRECIO_UNITARIO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_UNITARIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_UNITARIO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_UNITARIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_UNITARIO.Caption = "PRECIO UNIT."
        Me.COL_PRECIO_UNITARIO.ColumnEdit = Me.rpsInteger
        Me.COL_PRECIO_UNITARIO.DisplayFormat.FormatString = "#,#"
        Me.COL_PRECIO_UNITARIO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_PRECIO_UNITARIO.FieldName = "PRECIO_UNITARIO"
        Me.COL_PRECIO_UNITARIO.Name = "COL_PRECIO_UNITARIO"
        Me.COL_PRECIO_UNITARIO.Visible = True
        Me.COL_PRECIO_UNITARIO.VisibleIndex = 3
        Me.COL_PRECIO_UNITARIO.Width = 122
        '
        'rpsInteger
        '
        Me.rpsInteger.AutoHeight = False
        Me.rpsInteger.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsInteger.DisplayFormat.FormatString = "#,#"
        Me.rpsInteger.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsInteger.Mask.EditMask = "n0"
        Me.rpsInteger.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsInteger.Mask.UseMaskAsDisplayFormat = True
        Me.rpsInteger.Name = "rpsInteger"
        '
        'COL_TOTAL
        '
        Me.COL_TOTAL.AppearanceCell.Options.UseTextOptions = True
        Me.COL_TOTAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_TOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_TOTAL.Caption = "TOTAL"
        Me.COL_TOTAL.ColumnEdit = Me.rpsInteger
        Me.COL_TOTAL.DisplayFormat.FormatString = "#,#"
        Me.COL_TOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.COL_TOTAL.FieldName = "TOTAL"
        Me.COL_TOTAL.Name = "COL_TOTAL"
        Me.COL_TOTAL.Visible = True
        Me.COL_TOTAL.VisibleIndex = 4
        Me.COL_TOTAL.Width = 129
        '
        'COL_ID_PRODUCTO
        '
        Me.COL_ID_PRODUCTO.Caption = "ID PRODUCTO"
        Me.COL_ID_PRODUCTO.ColumnEdit = Me.rpsString
        Me.COL_ID_PRODUCTO.FieldName = "ID_PRODUCTO"
        Me.COL_ID_PRODUCTO.Name = "COL_ID_PRODUCTO"
        Me.COL_ID_PRODUCTO.Visible = True
        Me.COL_ID_PRODUCTO.VisibleIndex = 5
        '
        'COL_ID_UND_MEDIDA
        '
        Me.COL_ID_UND_MEDIDA.Caption = "ID UND MEDIDA"
        Me.COL_ID_UND_MEDIDA.ColumnEdit = Me.rpsString
        Me.COL_ID_UND_MEDIDA.FieldName = "ID_UND_MEDIDA"
        Me.COL_ID_UND_MEDIDA.Name = "COL_ID_UND_MEDIDA"
        Me.COL_ID_UND_MEDIDA.Visible = True
        Me.COL_ID_UND_MEDIDA.VisibleIndex = 6
        '
        'COL_COSTO
        '
        Me.COL_COSTO.Caption = "COSTO UNITARIO"
        Me.COL_COSTO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO.Name = "COL_COSTO"
        Me.COL_COSTO.Visible = True
        Me.COL_COSTO.VisibleIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(368, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Cantidad:"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(118, 11)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtCodigoBarras.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoBarras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodigoBarras.Size = New System.Drawing.Size(231, 24)
        Me.txtCodigoBarras.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Codigo barras:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtIdEmpresa)
        Me.PanelControl2.Controls.Add(Me.txtIdUnidad)
        Me.PanelControl2.Controls.Add(Me.txtIdSucursal)
        Me.PanelControl2.Controls.Add(Me.txtIdAlmacen)
        Me.PanelControl2.Controls.Add(Me.txtIdTransaccion)
        Me.PanelControl2.Controls.Add(Me.txtComentario)
        Me.PanelControl2.Controls.Add(Me.Label9)
        Me.PanelControl2.Controls.Add(Me.txtAlmacen)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.btnAlmacenes)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.txtFecha)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.txtTransaccion)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.btnTransacciones)
        Me.PanelControl2.Controls.Add(Me.txtUnidadOperat)
        Me.PanelControl2.Controls.Add(Me.Label7)
        Me.PanelControl2.Controls.Add(Me.btnBuscarUnidadOperat)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.btnBuscarSucursal)
        Me.PanelControl2.Controls.Add(Me.txtEmpresa)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.btnBuscarEmpresa)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 16)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(907, 158)
        Me.PanelControl2.TabIndex = 0
        '
        'txtIdEmpresa
        '
        Me.txtIdEmpresa.EditValue = ""
        Me.txtIdEmpresa.Location = New System.Drawing.Point(88, 14)
        Me.txtIdEmpresa.Name = "txtIdEmpresa"
        Me.txtIdEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIdEmpresa.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtIdEmpresa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdEmpresa.Properties.DisplayFormat.FormatString = "#,#"
        Me.txtIdEmpresa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdEmpresa.Size = New System.Drawing.Size(52, 22)
        Me.txtIdEmpresa.TabIndex = 0
        '
        'txtIdUnidad
        '
        Me.txtIdUnidad.EditValue = ""
        Me.txtIdUnidad.Location = New System.Drawing.Point(88, 39)
        Me.txtIdUnidad.Name = "txtIdUnidad"
        Me.txtIdUnidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIdUnidad.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdUnidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtIdUnidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdUnidad.Properties.DisplayFormat.FormatString = "#,#"
        Me.txtIdUnidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdUnidad.Size = New System.Drawing.Size(52, 22)
        Me.txtIdUnidad.TabIndex = 2
        '
        'txtIdSucursal
        '
        Me.txtIdSucursal.EditValue = ""
        Me.txtIdSucursal.Location = New System.Drawing.Point(88, 67)
        Me.txtIdSucursal.Name = "txtIdSucursal"
        Me.txtIdSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIdSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtIdSucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdSucursal.Properties.DisplayFormat.FormatString = "#,#"
        Me.txtIdSucursal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdSucursal.Size = New System.Drawing.Size(52, 22)
        Me.txtIdSucursal.TabIndex = 4
        '
        'txtIdAlmacen
        '
        Me.txtIdAlmacen.EditValue = ""
        Me.txtIdAlmacen.Location = New System.Drawing.Point(88, 94)
        Me.txtIdAlmacen.Name = "txtIdAlmacen"
        Me.txtIdAlmacen.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIdAlmacen.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdAlmacen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtIdAlmacen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdAlmacen.Properties.DisplayFormat.FormatString = "#,#"
        Me.txtIdAlmacen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdAlmacen.Size = New System.Drawing.Size(52, 22)
        Me.txtIdAlmacen.TabIndex = 6
        '
        'txtIdTransaccion
        '
        Me.txtIdTransaccion.EditValue = ""
        Me.txtIdTransaccion.Location = New System.Drawing.Point(88, 122)
        Me.txtIdTransaccion.Name = "txtIdTransaccion"
        Me.txtIdTransaccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIdTransaccion.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdTransaccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtIdTransaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdTransaccion.Properties.DisplayFormat.FormatString = "#,#"
        Me.txtIdTransaccion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdTransaccion.Size = New System.Drawing.Size(52, 22)
        Me.txtIdTransaccion.TabIndex = 8
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
        'txtAlmacen
        '
        Me.txtAlmacen.EditValue = ""
        Me.txtAlmacen.Location = New System.Drawing.Point(146, 94)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.Properties.Appearance.Options.UseBackColor = True
        Me.txtAlmacen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtAlmacen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacen.Properties.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(173, 22)
        Me.txtAlmacen.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Almacen:"
        '
        'btnAlmacenes
        '
        Me.btnAlmacenes.Location = New System.Drawing.Point(323, 94)
        Me.btnAlmacenes.Name = "btnAlmacenes"
        Me.btnAlmacenes.Size = New System.Drawing.Size(26, 20)
        Me.btnAlmacenes.TabIndex = 41
        Me.btnAlmacenes.Text = "+"
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
        'txtTransaccion
        '
        Me.txtTransaccion.EditValue = ""
        Me.txtTransaccion.Location = New System.Drawing.Point(146, 122)
        Me.txtTransaccion.Name = "txtTransaccion"
        Me.txtTransaccion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTransaccion.Properties.Appearance.Options.UseBackColor = True
        Me.txtTransaccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtTransaccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransaccion.Properties.ReadOnly = True
        Me.txtTransaccion.Size = New System.Drawing.Size(173, 22)
        Me.txtTransaccion.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Transaccion:"
        '
        'btnTransacciones
        '
        Me.btnTransacciones.Location = New System.Drawing.Point(323, 122)
        Me.btnTransacciones.Name = "btnTransacciones"
        Me.btnTransacciones.Size = New System.Drawing.Size(26, 20)
        Me.btnTransacciones.TabIndex = 33
        Me.btnTransacciones.Text = "+"
        '
        'txtUnidadOperat
        '
        Me.txtUnidadOperat.EditValue = ""
        Me.txtUnidadOperat.Location = New System.Drawing.Point(146, 40)
        Me.txtUnidadOperat.Name = "txtUnidadOperat"
        Me.txtUnidadOperat.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnidadOperat.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnidadOperat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUnidadOperat.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadOperat.Properties.ReadOnly = True
        Me.txtUnidadOperat.Size = New System.Drawing.Size(173, 22)
        Me.txtUnidadOperat.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Unidad Oper.:"
        '
        'btnBuscarUnidadOperat
        '
        Me.btnBuscarUnidadOperat.Location = New System.Drawing.Point(323, 40)
        Me.btnBuscarUnidadOperat.Name = "btnBuscarUnidadOperat"
        Me.btnBuscarUnidadOperat.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarUnidadOperat.TabIndex = 30
        Me.btnBuscarUnidadOperat.Text = "+"
        '
        'txtSucursal
        '
        Me.txtSucursal.EditValue = ""
        Me.txtSucursal.Location = New System.Drawing.Point(146, 66)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(173, 22)
        Me.txtSucursal.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Sucursal:"
        '
        'btnBuscarSucursal
        '
        Me.btnBuscarSucursal.Location = New System.Drawing.Point(323, 66)
        Me.btnBuscarSucursal.Name = "btnBuscarSucursal"
        Me.btnBuscarSucursal.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarSucursal.TabIndex = 28
        Me.btnBuscarSucursal.Text = "+"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.EditValue = ""
        Me.txtEmpresa.Location = New System.Drawing.Point(146, 14)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEmpresa.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtEmpresa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresa.Properties.ReadOnly = True
        Me.txtEmpresa.Size = New System.Drawing.Size(173, 22)
        Me.txtEmpresa.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Empresa:"
        '
        'btnBuscarEmpresa
        '
        Me.btnBuscarEmpresa.Location = New System.Drawing.Point(323, 14)
        Me.btnBuscarEmpresa.Name = "btnBuscarEmpresa"
        Me.btnBuscarEmpresa.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarEmpresa.TabIndex = 26
        Me.btnBuscarEmpresa.Text = "+"
        '
        'cldFecha
        '
        Me.cldFecha.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFecha.Location = New System.Drawing.Point(708, 42)
        Me.cldFecha.Name = "cldFecha"
        Me.cldFecha.Size = New System.Drawing.Size(256, 227)
        Me.cldFecha.TabIndex = 39
        '
        'FrmConsumoMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 537)
        Me.Controls.Add(Me.cldFecha)
        Me.Controls.Add(Me.PanelControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmConsumoMateriaPrima"
        Me.ShowIcon = False
        Me.ShowMdiChildCaptionInParentTitle = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumo de materia prima"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDouble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsInteger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtIdEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdUnidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdTransaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransaccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFecha.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTransaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTransacciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUnidadOperat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscarUnidadOperat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscarEmpresa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cldFecha As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_PRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_UND_MEDIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsString As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDouble As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsInteger As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtAlmacen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAlmacenes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdAlmacen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdTransaccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdUnidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdSucursal As DevExpress.XtraEditors.TextEdit
End Class
