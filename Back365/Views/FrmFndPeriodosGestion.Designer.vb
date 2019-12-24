<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFndPeriodosGestion
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsFecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colHasta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsChek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.btnEmpresas = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.cboTrimestre = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtAnho = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cldFechaHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldFechaDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsChek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cboTrimestre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(893, 472)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 172)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(859, 287)
        Me.PanelControl3.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(14, 18)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracter, Me.rpsFecha, Me.rpsChek})
        Me.GridControl1.Size = New System.Drawing.Size(832, 254)
        Me.GridControl1.TabIndex = 100
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmpresa, Me.colNombre, Me.colAnho, Me.colDesde, Me.colHasta, Me.colEstado})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindDelay = 500
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colEmpresa
        '
        Me.colEmpresa.Caption = "EMPRESA"
        Me.colEmpresa.ColumnEdit = Me.rpsCaracter
        Me.colEmpresa.FieldName = "EMPRESA"
        Me.colEmpresa.Name = "colEmpresa"
        Me.colEmpresa.Visible = True
        Me.colEmpresa.VisibleIndex = 0
        Me.colEmpresa.Width = 211
        '
        'rpsCaracter
        '
        Me.rpsCaracter.AutoHeight = False
        Me.rpsCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracter.Name = "rpsCaracter"
        '
        'colNombre
        '
        Me.colNombre.Caption = "NOMBRE"
        Me.colNombre.ColumnEdit = Me.rpsCaracter
        Me.colNombre.FieldName = "NOMBRE"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 176
        '
        'colAnho
        '
        Me.colAnho.Caption = "ANHO"
        Me.colAnho.ColumnEdit = Me.rpsCaracter
        Me.colAnho.FieldName = "ANHO"
        Me.colAnho.Name = "colAnho"
        Me.colAnho.Visible = True
        Me.colAnho.VisibleIndex = 2
        Me.colAnho.Width = 74
        '
        'colDesde
        '
        Me.colDesde.Caption = "FECHA DESDE"
        Me.colDesde.ColumnEdit = Me.rpsFecha
        Me.colDesde.FieldName = "FECHA_DESDE"
        Me.colDesde.Name = "colDesde"
        Me.colDesde.Visible = True
        Me.colDesde.VisibleIndex = 3
        Me.colDesde.Width = 150
        '
        'rpsFecha
        '
        Me.rpsFecha.AutoHeight = False
        Me.rpsFecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsFecha.Mask.EditMask = "d"
        Me.rpsFecha.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.rpsFecha.Mask.UseMaskAsDisplayFormat = True
        Me.rpsFecha.Name = "rpsFecha"
        '
        'colHasta
        '
        Me.colHasta.Caption = "FECHA HASTA"
        Me.colHasta.ColumnEdit = Me.rpsFecha
        Me.colHasta.FieldName = "FECHA_HASTA"
        Me.colHasta.Name = "colHasta"
        Me.colHasta.Visible = True
        Me.colHasta.VisibleIndex = 4
        Me.colHasta.Width = 150
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.Caption = "ESTADO"
        Me.colEstado.ColumnEdit = Me.rpsChek
        Me.colEstado.FieldName = "ESTADO"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 5
        '
        'rpsChek
        '
        Me.rpsChek.AutoHeight = False
        Me.rpsChek.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsChek.Name = "rpsChek"
        Me.rpsChek.ValueChecked = "AB"
        Me.rpsChek.ValueUnchecked = "CE"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.chkEstado)
        Me.PanelControl2.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl2.Controls.Add(Me.btnEmpresas)
        Me.PanelControl2.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl2.Controls.Add(Me.cboTrimestre)
        Me.PanelControl2.Controls.Add(Me.txtAnho)
        Me.PanelControl2.Controls.Add(Me.txtNombre)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.txtEmpresa)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(859, 146)
        Me.PanelControl2.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(347, 68)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "Abierto:"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEstado.Location = New System.Drawing.Point(390, 68)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(15, 14)
        Me.chkEstado.TabIndex = 6
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(608, 38)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(26, 20)
        Me.btnFechaHasta.TabIndex = 16
        Me.btnFechaHasta.Text = "..."
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(608, 13)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 20)
        Me.btnFechaDesde.TabIndex = 15
        Me.btnFechaDesde.Text = "..."
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(390, 38)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(212, 21)
        Me.txtFechaHasta.TabIndex = 5
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'btnEmpresas
        '
        Me.btnEmpresas.Location = New System.Drawing.Point(278, 13)
        Me.btnEmpresas.Name = "btnEmpresas"
        Me.btnEmpresas.Size = New System.Drawing.Size(26, 20)
        Me.btnEmpresas.TabIndex = 1
        Me.btnEmpresas.Text = "..."
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(390, 13)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(212, 21)
        Me.txtFechaDesde.TabIndex = 4
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'cboTrimestre
        '
        Me.cboTrimestre.Location = New System.Drawing.Point(63, 91)
        Me.cboTrimestre.Name = "cboTrimestre"
        Me.cboTrimestre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboTrimestre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTrimestre.Properties.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboTrimestre.Size = New System.Drawing.Size(241, 22)
        Me.cboTrimestre.TabIndex = 3
        '
        'txtAnho
        '
        Me.txtAnho.Location = New System.Drawing.Point(63, 65)
        Me.txtAnho.Name = "txtAnho"
        Me.txtAnho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtAnho.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAnho.Size = New System.Drawing.Size(241, 22)
        Me.txtAnho.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(63, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Size = New System.Drawing.Size(241, 22)
        Me.txtNombre.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(744, 52)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 33)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(744, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(91, 33)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(63, 13)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEmpresa.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtEmpresa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresa.Properties.ReadOnly = True
        Me.txtEmpresa.Size = New System.Drawing.Size(212, 22)
        Me.txtEmpresa.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(321, 46)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl7.TabIndex = 5
        Me.LabelControl7.Text = "Fecha hasta:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(319, 16)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Fecha desde:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 94)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Trimestre:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(28, 68)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Anho:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Nombre"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Empresa:"
        '
        'cldFechaHasta
        '
        Me.cldFechaHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaHasta.Location = New System.Drawing.Point(635, 64)
        Me.cldFechaHasta.Name = "cldFechaHasta"
        Me.cldFechaHasta.Size = New System.Drawing.Size(270, 227)
        Me.cldFechaHasta.TabIndex = 19
        '
        'cldFechaDesde
        '
        Me.cldFechaDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaDesde.Location = New System.Drawing.Point(635, 39)
        Me.cldFechaDesde.Name = "cldFechaDesde"
        Me.cldFechaDesde.Size = New System.Drawing.Size(270, 227)
        Me.cldFechaDesde.TabIndex = 20
        '
        'FrmFndPeriodosGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 496)
        Me.Controls.Add(Me.cldFechaDesde)
        Me.Controls.Add(Me.cldFechaHasta)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmFndPeriodosGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodos de gestion"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsChek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cboTrimestre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEmpresas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents cboTrimestre As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtAnho As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsFecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsChek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cldFechaHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldFechaDesde As DevExpress.XtraEditors.Controls.CalendarControl
End Class
