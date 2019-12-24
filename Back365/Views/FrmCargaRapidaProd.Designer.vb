<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCargaRapidaProd
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
        Me.lstProductos = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.lstProductos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lstProductos)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 14)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(325, 340)
        Me.PanelControl1.TabIndex = 3
        '
        'lstProductos
        '
        Me.lstProductos.Location = New System.Drawing.Point(15, 17)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(295, 307)
        Me.lstProductos.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 360)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(325, 56)
        Me.PanelControl2.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(165, 13)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(60, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        '
        'FrmCargaRapidaProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 434)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmCargaRapidaProd"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga rapida de productos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.lstProductos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lstProductos As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
End Class
