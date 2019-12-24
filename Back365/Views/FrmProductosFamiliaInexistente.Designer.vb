<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductosFamiliaInexistente
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblRecuento = New DevExpress.XtraEditors.LabelControl()
        Me.lstProductos = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lstProductos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.lblRecuento)
        Me.PanelControl1.Controls.Add(Me.lstProductos)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(325, 381)
        Me.PanelControl1.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(17, 341)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Recuento:"
        '
        'lblRecuento
        '
        Me.lblRecuento.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuento.Location = New System.Drawing.Point(86, 341)
        Me.lblRecuento.Name = "lblRecuento"
        Me.lblRecuento.Size = New System.Drawing.Size(28, 14)
        Me.lblRecuento.TabIndex = 1
        Me.lblRecuento.Text = "1000"
        '
        'lstProductos
        '
        Me.lstProductos.Location = New System.Drawing.Point(17, 15)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(295, 307)
        Me.lstProductos.TabIndex = 0
        '
        'FrmProductosFamiliaInexistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 411)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmProductosFamiliaInexistente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos no definidos en familia"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.lstProductos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Public WithEvents lstProductos As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblRecuento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
