<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRedondeo
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
        Me.txtResultado = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtResultado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
        Me.PanelControl1.Controls.Add(Me.txtResultado)
        Me.PanelControl1.Controls.Add(Me.txtNumero)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(478, 219)
        Me.PanelControl1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(241, 150)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 29)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(157, 150)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 29)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(125, 74)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtResultado.Properties.DisplayFormat.FormatString = "#,#"
        Me.txtResultado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtResultado.Properties.Mask.EditMask = "n0"
        Me.txtResultado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtResultado.Size = New System.Drawing.Size(231, 22)
        Me.txtResultado.TabIndex = 3
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(125, 33)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNumero.Properties.DisplayFormat.FormatString = "#,#"
        Me.txtNumero.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumero.Properties.Mask.EditMask = "n0"
        Me.txtNumero.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumero.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumero.Size = New System.Drawing.Size(231, 22)
        Me.txtNumero.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resultado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero:"
        '
        'FrmRedondeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 255)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmRedondeo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Redondeo"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtResultado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtResultado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
