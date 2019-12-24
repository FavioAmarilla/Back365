<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transacciones_inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_transacciones_inventario))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CalendarControl1 = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit4 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.codigo_barras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.IDPRODUCTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDUNIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PRECIOUNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COSTOUNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EXISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_eliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.codigo_barras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(197, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "FECHA"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(241, 17)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBox1.TabIndex = 0
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(178, 57)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "SUCURSAL"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(157, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "TRANSACCION"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(137, 113)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "DEPOSITO ORIGEN"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(132, 148)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "DEPOSITO DESTINO"
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.AllowDrop = True
        Me.ComboBoxEdit2.EnterMoveNextControl = True
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(241, 81)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComboBoxEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.ComboBoxEdit2.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.LightGray
        Me.ComboBoxEdit2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit2.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit2.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.ComboBoxEdit2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.ComboBoxEdit2.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.ComboBoxEdit2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.ComboBoxEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ComboBoxEdit2.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComboBoxEdit2.Properties.ImmediatePopup = True
        Me.ComboBoxEdit2.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit2.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(202, 22)
        Me.ComboBoxEdit2.TabIndex = 2
        '
        'CalendarControl1
        '
        Me.CalendarControl1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalendarControl1.Location = New System.Drawing.Point(377, 43)
        Me.CalendarControl1.Name = "CalendarControl1"
        Me.CalendarControl1.Size = New System.Drawing.Size(242, 227)
        Me.CalendarControl1.TabIndex = 21
        Me.CalendarControl1.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(588, 17)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(90, 32)
        Me.SimpleButton1.TabIndex = 22
        Me.SimpleButton1.Text = "ACEPTAR"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.AllowDrop = True
        Me.ComboBoxEdit1.EnterMoveNextControl = True
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(241, 51)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComboBoxEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.LightGray
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.ComboBoxEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ComboBoxEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComboBoxEdit1.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.ComboBoxEdit1.Properties.ImmediatePopup = True
        Me.ComboBoxEdit1.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit1.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(202, 22)
        Me.ComboBoxEdit1.TabIndex = 1
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.AllowDrop = True
        Me.ComboBoxEdit3.EnterMoveNextControl = True
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(241, 110)
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComboBoxEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.ComboBoxEdit3.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.LightGray
        Me.ComboBoxEdit3.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit3.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit3.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.ComboBoxEdit3.Properties.AppearanceDropDown.Options.UseFont = True
        Me.ComboBoxEdit3.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.ComboBoxEdit3.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit3.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.ComboBoxEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ComboBoxEdit3.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComboBoxEdit3.Properties.ImmediatePopup = True
        Me.ComboBoxEdit3.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit3.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(202, 22)
        Me.ComboBoxEdit3.TabIndex = 3
        '
        'ComboBoxEdit4
        '
        Me.ComboBoxEdit4.AllowDrop = True
        Me.ComboBoxEdit4.Enabled = False
        Me.ComboBoxEdit4.EnterMoveNextControl = True
        Me.ComboBoxEdit4.Location = New System.Drawing.Point(241, 143)
        Me.ComboBoxEdit4.Name = "ComboBoxEdit4"
        Me.ComboBoxEdit4.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComboBoxEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.ComboBoxEdit4.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBoxEdit4.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit4.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEdit4.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.ComboBoxEdit4.Properties.AppearanceDropDown.Options.UseFont = True
        Me.ComboBoxEdit4.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.ComboBoxEdit4.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit4.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.ComboBoxEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ComboBoxEdit4.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ComboBoxEdit4.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComboBoxEdit4.Properties.ImmediatePopup = True
        Me.ComboBoxEdit4.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBoxEdit4.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat
        Me.ComboBoxEdit4.Size = New System.Drawing.Size(202, 22)
        Me.ComboBoxEdit4.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(347, 19)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(30, 19)
        Me.SimpleButton2.TabIndex = 23
        Me.SimpleButton2.Text = "+"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(10, 43)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cantidad, Me.codigo_barras, Me.descripcion, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(788, 254)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.IDPRODUCTO, Me.IDUNIDAD, Me.PRECIOUNITARIO, Me.COSTOUNITARIO, Me.EXISTENCIA})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsPrint.PrintSelectedRowsOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridColumn1.AppearanceHeader.Options.UseBackColor = True
        Me.GridColumn1.Caption = "CODIGO BARRAS"
        Me.GridColumn1.ColumnEdit = Me.codigo_barras
        Me.GridColumn1.FieldName = "CODIGO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.TabStop = False
        Me.GridColumn1.ToolTip = "Codigo de Barras de Productos"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 91
        '
        'codigo_barras
        '
        Me.codigo_barras.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.codigo_barras.AppearanceFocused.Options.UseBackColor = True
        Me.codigo_barras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.codigo_barras.Name = "codigo_barras"
        Me.codigo_barras.NullValuePromptShowForEmptyValue = True
        Me.codigo_barras.ValidateOnEnterKey = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "DESCRIPCION"
        Me.GridColumn2.ColumnEdit = Me.descripcion
        Me.GridColumn2.FieldName = "DESCRIPCION"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 283
        '
        'descripcion
        '
        Me.descripcion.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.descripcion.AppearanceFocused.Options.UseBackColor = True
        Me.descripcion.AutoHeight = False
        Me.descripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.descripcion.Name = "descripcion"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "UNIDAD MEDIDA"
        Me.GridColumn3.ColumnEdit = Me.descripcion
        Me.GridColumn3.FieldName = "UNIDAD"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 76
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "CANTIDAD"
        Me.GridColumn4.ColumnEdit = Me.cantidad
        Me.GridColumn4.DisplayFormat.FormatString = "0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn4.FieldName = "CANTIDAD"
        Me.GridColumn4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 72
        '
        'cantidad
        '
        Me.cantidad.AllowFocused = False
        Me.cantidad.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cantidad.Appearance.Options.UseBackColor = True
        Me.cantidad.AppearanceFocused.BackColor = System.Drawing.Color.LemonChiffon
        Me.cantidad.AppearanceFocused.Options.UseBackColor = True
        Me.cantidad.AutoHeight = False
        Me.cantidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ValidateOnEnterKey = True
        '
        'IDPRODUCTO
        '
        Me.IDPRODUCTO.Caption = "ID PRODUCTO"
        Me.IDPRODUCTO.FieldName = "IDPRODUCTO"
        Me.IDPRODUCTO.Name = "IDPRODUCTO"
        Me.IDPRODUCTO.Visible = True
        Me.IDPRODUCTO.VisibleIndex = 4
        Me.IDPRODUCTO.Width = 67
        '
        'IDUNIDAD
        '
        Me.IDUNIDAD.Caption = "ID UNIDAD"
        Me.IDUNIDAD.FieldName = "IDUNIDAD"
        Me.IDUNIDAD.Name = "IDUNIDAD"
        Me.IDUNIDAD.Visible = True
        Me.IDUNIDAD.VisibleIndex = 5
        Me.IDUNIDAD.Width = 62
        '
        'PRECIOUNITARIO
        '
        Me.PRECIOUNITARIO.Caption = "PRECIO UNITARIO"
        Me.PRECIOUNITARIO.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.PRECIOUNITARIO.FieldName = "PRECIOUNITARIO"
        Me.PRECIOUNITARIO.Name = "PRECIOUNITARIO"
        Me.PRECIOUNITARIO.Visible = True
        Me.PRECIOUNITARIO.VisibleIndex = 6
        Me.PRECIOUNITARIO.Width = 53
        '
        'COSTOUNITARIO
        '
        Me.COSTOUNITARIO.Caption = "COSTO UNITARIO"
        Me.COSTOUNITARIO.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.COSTOUNITARIO.FieldName = "COSTOUNITARIO"
        Me.COSTOUNITARIO.Name = "COSTOUNITARIO"
        Me.COSTOUNITARIO.Visible = True
        Me.COSTOUNITARIO.VisibleIndex = 7
        Me.COSTOUNITARIO.Width = 63
        '
        'EXISTENCIA
        '
        Me.EXISTENCIA.Caption = "EXISTENCIA"
        Me.EXISTENCIA.FieldName = "EXISTENCIA"
        Me.EXISTENCIA.Name = "EXISTENCIA"
        Me.EXISTENCIA.Visible = True
        Me.EXISTENCIA.VisibleIndex = 8
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(723, 12)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 33
        Me.btn_eliminar.Text = "Eliminar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(14, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(838, 537)
        Me.PanelControl1.TabIndex = 34
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Controls.Add(Me.btn_eliminar)
        Me.PanelControl3.Location = New System.Drawing.Point(13, 211)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(813, 314)
        Me.PanelControl3.TabIndex = 35
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.ComboBoxEdit1)
        Me.PanelControl2.Controls.Add(Me.ComboBoxEdit2)
        Me.PanelControl2.Controls.Add(Me.MaskedTextBox1)
        Me.PanelControl2.Controls.Add(Me.ComboBoxEdit3)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.ComboBoxEdit4)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Location = New System.Drawing.Point(16, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(810, 178)
        Me.PanelControl2.TabIndex = 34
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = "0"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.NullText = "0"
        '
        'frm_transacciones_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 561)
        Me.Controls.Add(Me.CalendarControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "frm_transacciones_inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transacciones de iventario"
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.codigo_barras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CalendarControl1 As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents codigo_barras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_eliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IDPRODUCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDUNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PRECIOUNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COSTOUNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EXISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents descripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
