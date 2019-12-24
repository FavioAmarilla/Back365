<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptArqueoCajas
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
        Me.cldHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCajaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCajaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCajaHasta = New DevExpress.XtraEditors.TextEdit()
        Me.txtCajaDesde = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.txtsucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCajaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCajaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cldHasta)
        Me.PanelControl1.Controls.Add(Me.cldDesde)
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
        Me.PanelControl1.Controls.Add(Me.btnCajaDesde)
        Me.PanelControl1.Controls.Add(Me.btnCajaHasta)
        Me.PanelControl1.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl1.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl1.Controls.Add(Me.btnSucursal)
        Me.PanelControl1.Controls.Add(Me.txtCajaHasta)
        Me.PanelControl1.Controls.Add(Me.txtCajaDesde)
        Me.PanelControl1.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl1.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl1.Controls.Add(Me.txtsucursal)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(504, 315)
        Me.PanelControl1.TabIndex = 0
        '
        'cldHasta
        '
        Me.cldHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldHasta.Location = New System.Drawing.Point(204, 75)
        Me.cldHasta.Name = "cldHasta"
        Me.cldHasta.Size = New System.Drawing.Size(238, 227)
        Me.cldHasta.TabIndex = 13
        '
        'cldDesde
        '
        Me.cldDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldDesde.Location = New System.Drawing.Point(204, 48)
        Me.cldDesde.Name = "cldDesde"
        Me.cldDesde.Size = New System.Drawing.Size(238, 227)
        Me.cldDesde.TabIndex = 12
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(395, 271)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 31)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(295, 271)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 31)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCajaDesde
        '
        Me.btnCajaDesde.Location = New System.Drawing.Point(415, 103)
        Me.btnCajaDesde.Name = "btnCajaDesde"
        Me.btnCajaDesde.Size = New System.Drawing.Size(27, 21)
        Me.btnCajaDesde.TabIndex = 10
        Me.btnCajaDesde.Text = "+"
        '
        'btnCajaHasta
        '
        Me.btnCajaHasta.Location = New System.Drawing.Point(415, 130)
        Me.btnCajaHasta.Name = "btnCajaHasta"
        Me.btnCajaHasta.Size = New System.Drawing.Size(27, 21)
        Me.btnCajaHasta.TabIndex = 11
        Me.btnCajaHasta.Text = "+"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(415, 76)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaHasta.TabIndex = 9
        Me.btnFechaHasta.Text = "+"
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(415, 48)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaDesde.TabIndex = 8
        Me.btnFechaDesde.Text = "+"
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(415, 21)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(27, 21)
        Me.btnSucursal.TabIndex = 7
        Me.btnSucursal.Text = "+"
        '
        'txtCajaHasta
        '
        Me.txtCajaHasta.Location = New System.Drawing.Point(130, 130)
        Me.txtCajaHasta.Name = "txtCajaHasta"
        Me.txtCajaHasta.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCajaHasta.Properties.Appearance.Options.UseBackColor = True
        Me.txtCajaHasta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCajaHasta.Size = New System.Drawing.Size(279, 22)
        Me.txtCajaHasta.TabIndex = 4
        '
        'txtCajaDesde
        '
        Me.txtCajaDesde.Location = New System.Drawing.Point(130, 104)
        Me.txtCajaDesde.Name = "txtCajaDesde"
        Me.txtCajaDesde.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCajaDesde.Properties.Appearance.Options.UseBackColor = True
        Me.txtCajaDesde.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCajaDesde.Size = New System.Drawing.Size(279, 22)
        Me.txtCajaDesde.TabIndex = 3
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(130, 77)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaHasta.TabIndex = 2
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(130, 48)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaDesde.TabIndex = 1
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'txtsucursal
        '
        Me.txtsucursal.Location = New System.Drawing.Point(130, 21)
        Me.txtsucursal.Name = "txtsucursal"
        Me.txtsucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtsucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtsucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtsucursal.Size = New System.Drawing.Size(279, 22)
        Me.txtsucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(71, 133)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Caja hasta:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(69, 107)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 17
        Me.LabelControl5.Text = "Caja desde:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(64, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Fecha hasta:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(62, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Fecha desde:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(83, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Sucursal:"
        '
        'FrmRptArqueoCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 339)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRptArqueoCajas"
        Me.Text = "Reporte de arqueo de cajas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCajaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCajaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCajaHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCajaDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents txtsucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCajaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCajaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cldDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldHasta As DevExpress.XtraEditors.Controls.CalendarControl
End Class
