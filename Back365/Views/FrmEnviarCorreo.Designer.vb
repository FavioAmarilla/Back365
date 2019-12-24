<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnviarCorreo
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
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDe = New DevExpress.XtraEditors.TextEdit()
        Me.txtPara = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.txtDe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(49, 146)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "Enviar"
        '
        'txtDe
        '
        Me.txtDe.Location = New System.Drawing.Point(24, 36)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(235, 20)
        Me.txtDe.TabIndex = 1
        '
        'txtPara
        '
        Me.txtPara.Location = New System.Drawing.Point(25, 105)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(235, 20)
        Me.txtPara.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "De:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 86)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Para:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(25, 60)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(235, 20)
        Me.txtPass.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmEnviarCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 223)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.txtDe)
        Me.Controls.Add(Me.btnEnviar)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmEnviarCorreo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar correo"
        CType(Me.txtDe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Button1 As Button
End Class
