<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrLineasProd
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
        Dim TreeListFormatRule1 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim TreeListFormatRule2 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim TreeListFormatRule3 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim TreeListFormatRule4 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
        Dim FormatConditionRuleExpression3 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression4 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression5 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.TreeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_NUMERO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.trFamilias = New DevExpress.XtraTreeList.TreeList()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.chkCodigo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDescripcion = New DevExpress.XtraEditors.CheckEdit()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CODIGO_INTERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.trFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeListColumn6
        '
        Me.TreeListColumn6.Caption = "Ultimo nivel"
        Me.TreeListColumn6.FieldName = "ULTIMO_NIVEL"
        Me.TreeListColumn6.Name = "TreeListColumn6"
        Me.TreeListColumn6.OptionsColumn.AllowEdit = False
        Me.TreeListColumn6.Visible = True
        Me.TreeListColumn6.VisibleIndex = 3
        Me.TreeListColumn6.Width = 73
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "Descripcion"
        Me.TreeListColumn2.FieldName = "DESCRIPCION"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowEdit = False
        Me.TreeListColumn2.Visible = True
        Me.TreeListColumn2.VisibleIndex = 0
        Me.TreeListColumn2.Width = 238
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Caption = "Codigo"
        Me.TreeListColumn3.FieldName = "CODIGO"
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.OptionsColumn.AllowEdit = False
        Me.TreeListColumn3.Visible = True
        Me.TreeListColumn3.VisibleIndex = 1
        Me.TreeListColumn3.Width = 72
        '
        'TreeListColumn5
        '
        Me.TreeListColumn5.Caption = "Nivel"
        Me.TreeListColumn5.FieldName = "NIVEL"
        Me.TreeListColumn5.Name = "TreeListColumn5"
        Me.TreeListColumn5.OptionsColumn.AllowEdit = False
        Me.TreeListColumn5.Visible = True
        Me.TreeListColumn5.VisibleIndex = 2
        Me.TreeListColumn5.Width = 73
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CODIGO_BARRAS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CODIGO_BARRAS.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CODIGO_BARRAS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CODIGO_BARRAS.Caption = "Codigo de barras"
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 4
        Me.COL_CODIGO_BARRAS.Width = 99
        '
        'COL_NUMERO
        '
        Me.COL_NUMERO.Caption = "Numero"
        Me.COL_NUMERO.FieldName = "NUMERO"
        Me.COL_NUMERO.Name = "COL_NUMERO"
        Me.COL_NUMERO.Visible = True
        Me.COL_NUMERO.VisibleIndex = 0
        Me.COL_NUMERO.Width = 134
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "Descripcion"
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 246
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "Identificador"
        Me.TreeListColumn1.FieldName = "IDENTIFICADOR"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "ID_LINEA_PADRE"
        Me.TreeListColumn4.FieldName = "ID_LINEA_PADRE"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.OptionsColumn.AllowEdit = False
        Me.TreeListColumn4.Width = 76
        '
        'trFamilias
        '
        Me.trFamilias.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.TreeListColumn3, Me.TreeListColumn4, Me.TreeListColumn5, Me.TreeListColumn6})
        Me.trFamilias.Cursor = System.Windows.Forms.Cursors.Default
        TreeListFormatRule1.Column = Me.TreeListColumn6
        TreeListFormatRule1.ColumnApplyTo = Me.TreeListColumn2
        TreeListFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        FormatConditionRuleExpression1.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression1.Expression = "[ULTIMO_NIVEL] = 'N'"
        FormatConditionRuleExpression1.PredefinedName = "Bold Text"
        TreeListFormatRule1.Rule = FormatConditionRuleExpression1
        TreeListFormatRule2.Column = Me.TreeListColumn6
        TreeListFormatRule2.ColumnApplyTo = Me.TreeListColumn6
        TreeListFormatRule2.Name = "Format1"
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.PredefinedName = "Bold Text"
        FormatConditionRuleValue1.Value1 = "N"
        TreeListFormatRule2.Rule = FormatConditionRuleValue1
        TreeListFormatRule3.Column = Me.TreeListColumn6
        TreeListFormatRule3.ColumnApplyTo = Me.TreeListColumn3
        TreeListFormatRule3.Name = "Format2"
        FormatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        FormatConditionRuleExpression2.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression2.Expression = "[ULTIMO_NIVEL] = 'N'"
        FormatConditionRuleExpression2.PredefinedName = "Bold Text"
        TreeListFormatRule3.Rule = FormatConditionRuleExpression2
        TreeListFormatRule4.Column = Me.TreeListColumn6
        TreeListFormatRule4.ColumnApplyTo = Me.TreeListColumn5
        TreeListFormatRule4.Name = "Format3"
        FormatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        FormatConditionRuleExpression3.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression3.Expression = "[ULTIMO_NIVEL] = 'N'"
        FormatConditionRuleExpression3.PredefinedName = "Green Bold Text"
        TreeListFormatRule4.Rule = FormatConditionRuleExpression3
        Me.trFamilias.FormatRules.Add(TreeListFormatRule1)
        Me.trFamilias.FormatRules.Add(TreeListFormatRule2)
        Me.trFamilias.FormatRules.Add(TreeListFormatRule3)
        Me.trFamilias.FormatRules.Add(TreeListFormatRule4)
        Me.trFamilias.Location = New System.Drawing.Point(13, 17)
        Me.trFamilias.Name = "trFamilias"
        Me.trFamilias.Size = New System.Drawing.Size(474, 469)
        Me.trFamilias.TabIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnImprimir)
        Me.PanelControl1.Controls.Add(Me.txtBuscar)
        Me.PanelControl1.Controls.Add(Me.chkCodigo)
        Me.PanelControl1.Controls.Add(Me.chkDescripcion)
        Me.PanelControl1.Location = New System.Drawing.Point(13, 14)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(643, 69)
        Me.PanelControl1.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(543, 18)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(84, 28)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(29, 37)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Size = New System.Drawing.Size(322, 22)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.TabStop = False
        '
        'chkCodigo
        '
        Me.chkCodigo.Location = New System.Drawing.Point(112, 12)
        Me.chkCodigo.Name = "chkCodigo"
        Me.chkCodigo.Properties.Caption = "Cod. Barras:"
        Me.chkCodigo.Size = New System.Drawing.Size(77, 19)
        Me.chkCodigo.TabIndex = 2
        '
        'chkDescripcion
        '
        Me.chkDescripcion.Location = New System.Drawing.Point(29, 12)
        Me.chkDescripcion.Name = "chkDescripcion"
        Me.chkDescripcion.Properties.Caption = "Descripcion"
        Me.chkDescripcion.Size = New System.Drawing.Size(77, 19)
        Me.chkDescripcion.TabIndex = 1
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(13, 89)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.Size = New System.Drawing.Size(643, 417)
        Me.gridItems.TabIndex = 1
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_NUMERO, Me.COL_DESCRIPCION, Me.COL_IDENTIFICADOR, Me.COL_CODIGO_INTERNO, Me.COL_CODIGO_BARRAS})
        GridFormatRule1.Column = Me.COL_CODIGO_BARRAS
        GridFormatRule1.ColumnApplyTo = Me.COL_NUMERO
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression4.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression4.Expression = "[CODIGO_BARRAS] = '-'"
        FormatConditionRuleExpression4.PredefinedName = "Bold Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression4
        GridFormatRule2.Column = Me.COL_CODIGO_BARRAS
        GridFormatRule2.ColumnApplyTo = Me.COL_DESCRIPCION
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression5.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression5.Expression = "[CODIGO_BARRAS] = '-'"
        FormatConditionRuleExpression5.PredefinedName = "Bold Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression5
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.FormatRules.Add(GridFormatRule2)
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.AppearanceCell.Options.UseTextOptions = True
        Me.COL_IDENTIFICADOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IDENTIFICADOR.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_IDENTIFICADOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_IDENTIFICADOR.Caption = "Identificador"
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Visible = True
        Me.COL_IDENTIFICADOR.VisibleIndex = 2
        '
        'COL_CODIGO_INTERNO
        '
        Me.COL_CODIGO_INTERNO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CODIGO_INTERNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CODIGO_INTERNO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CODIGO_INTERNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CODIGO_INTERNO.Caption = "Cod. Interno"
        Me.COL_CODIGO_INTERNO.FieldName = "CODIGO_INTERNO"
        Me.COL_CODIGO_INTERNO.Name = "COL_CODIGO_INTERNO"
        Me.COL_CODIGO_INTERNO.Visible = True
        Me.COL_CODIGO_INTERNO.VisibleIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.trFamilias)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(500, 523)
        Me.PanelControl2.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(401, 492)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 26)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Imprimir"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl1)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(521, 14)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(673, 523)
        Me.PanelControl3.TabIndex = 1
        '
        'FrmPrLineasProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 563)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmPrLineasProd"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lineas de productos"
        CType(Me.trFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trFamilias As DevExpress.XtraTreeList.TreeList
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkDescripcion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkCodigo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents COL_NUMERO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents COL_CODIGO_INTERNO As DevExpress.XtraGrid.Columns.GridColumn
End Class
