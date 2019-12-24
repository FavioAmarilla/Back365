<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
        Me.PanelControl1.Controls.Add(Me.txtClave)
        Me.PanelControl1.Controls.Add(Me.txtUsuario)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(453, 213)
        Me.PanelControl1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(236, 153)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(124, 153)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(92, 30)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(112, 98)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Properties.Appearance.Options.UseFont = True
        Me.txtClave.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(228, 24)
        Me.txtClave.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(112, 49)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUsuario.Size = New System.Drawing.Size(228, 24)
        Me.txtUsuario.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(173, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Clave de Acceso"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(202, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 18)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Usuario"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 237)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al Sistema"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
End Class
