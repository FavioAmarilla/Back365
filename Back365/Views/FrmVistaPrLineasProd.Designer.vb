<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVistaPrLineasProd
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
        Me.trFamilias = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.trFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.trFamilias)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(372, 440)
        Me.PanelControl1.TabIndex = 2
        '
        'trFamilias
        '
        Me.trFamilias.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.TreeListColumn3, Me.TreeListColumn4})
        Me.trFamilias.Cursor = System.Windows.Forms.Cursors.Default
        Me.trFamilias.Location = New System.Drawing.Point(14, 76)
        Me.trFamilias.Name = "trFamilias"
        Me.trFamilias.OptionsPrint.PrintFilledTreeIndent = True
        Me.trFamilias.OptionsPrint.PrintImages = False
        Me.trFamilias.OptionsPrint.UsePrintStyles = False
        Me.trFamilias.Size = New System.Drawing.Size(345, 349)
        Me.trFamilias.TabIndex = 1
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "CODIGO"
        Me.TreeListColumn1.FieldName = "ABREVIATURA"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.Visible = True
        Me.TreeListColumn1.VisibleIndex = 0
        Me.TreeListColumn1.Width = 96
        '
        'TreeListColumn2
        '
        Me.TreeListColumn2.Caption = "DESCRIPCION"
        Me.TreeListColumn2.FieldName = "DESCRIPCION"
        Me.TreeListColumn2.Name = "TreeListColumn2"
        Me.TreeListColumn2.OptionsColumn.AllowEdit = False
        Me.TreeListColumn2.Visible = True
        Me.TreeListColumn2.VisibleIndex = 1
        Me.TreeListColumn2.Width = 231
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Caption = "IDENTIFICADOR"
        Me.TreeListColumn3.FieldName = "IDENTIFICADOR"
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.OptionsColumn.AllowEdit = False
        '
        'TreeListColumn4
        '
        Me.TreeListColumn4.Caption = "ID LINEA PADRE"
        Me.TreeListColumn4.FieldName = "ID_LINEA_PADRE"
        Me.TreeListColumn4.Name = "TreeListColumn4"
        Me.TreeListColumn4.OptionsColumn.AllowEdit = False
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
        'FrmVistaPrLineasProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 466)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmVistaPrLineasProd"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lineas de productos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.trFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trFamilias As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
