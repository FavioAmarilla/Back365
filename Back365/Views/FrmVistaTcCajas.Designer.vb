<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaTcCajas
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridCajas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.gridCajas)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(372, 440)
        Me.PanelControl1.TabIndex = 2
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtBuscar)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(345, 54)
        Me.PanelControl2.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Descripcion"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(5, 21)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Size = New System.Drawing.Size(267, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'gridCajas
        '
        Me.gridCajas.Location = New System.Drawing.Point(14, 74)
        Me.gridCajas.MainView = Me.GridView1
        Me.gridCajas.Name = "gridCajas"
        Me.gridCajas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.gridCajas.Size = New System.Drawing.Size(345, 353)
        Me.gridCajas.TabIndex = 1
        Me.gridCajas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_DESCRIPCION})
        Me.GridView1.GridControl = Me.gridCajas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.AppearanceCell.Options.UseTextOptions = True
        Me.COL_IDENTIFICADOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_IDENTIFICADOR.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_IDENTIFICADOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_IDENTIFICADOR.Caption = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Visible = True
        Me.COL_IDENTIFICADOR.VisibleIndex = 0
        Me.COL_IDENTIFICADOR.Width = 110
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.AppearanceCell.Options.UseTextOptions = True
        Me.COL_DESCRIPCION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_DESCRIPCION.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_DESCRIPCION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 217
        '
        'FrmVistaCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 465)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmVistaCajas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridCajas As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
