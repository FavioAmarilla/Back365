<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAppVtaPromociones
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
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.txtsucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cldHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.txtEmitido = New DevExpress.XtraEditors.TextEdit()
        Me.lblEmitido = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmitido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtEmitido)
        Me.PanelControl1.Controls.Add(Me.lblEmitido)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
        Me.PanelControl1.Controls.Add(Me.btnBuscar)
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.txtMonto)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtNombre)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl1.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl1.Controls.Add(Me.btnSucursal)
        Me.PanelControl1.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl1.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl1.Controls.Add(Me.txtsucursal)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(543, 249)
        Me.PanelControl1.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(419, 14)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 31)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(419, 51)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 31)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(419, 88)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 31)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(101, 125)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtMonto.Properties.Mask.EditMask = "n0"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Size = New System.Drawing.Size(312, 22)
        Me.txtMonto.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(61, 129)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Monto:"
        '
        'txtNombre
        '
        Me.txtNombre.EditValue = " "
        Me.txtNombre.Location = New System.Drawing.Point(101, 97)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNombre.Size = New System.Drawing.Size(312, 22)
        Me.txtNombre.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(54, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Nombre:"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(386, 39)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaHasta.TabIndex = 9
        Me.btnFechaHasta.Text = "+"
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(386, 11)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaDesde.TabIndex = 8
        Me.btnFechaDesde.Text = "+"
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(386, 70)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(27, 21)
        Me.btnSucursal.TabIndex = 10
        Me.btnSucursal.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(101, 40)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(101, 11)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'txtsucursal
        '
        Me.txtsucursal.Location = New System.Drawing.Point(101, 70)
        Me.txtsucursal.Name = "txtsucursal"
        Me.txtsucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtsucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtsucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtsucursal.Size = New System.Drawing.Size(279, 22)
        Me.txtsucursal.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Fecha hasta:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(30, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Fecha desde:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(51, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Sucursal:"
        '
        'cldHasta
        '
        Me.cldHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldHasta.Location = New System.Drawing.Point(167, 50)
        Me.cldHasta.Name = "cldHasta"
        Me.cldHasta.Size = New System.Drawing.Size(258, 227)
        Me.cldHasta.TabIndex = 2
        '
        'cldDesde
        '
        Me.cldDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldDesde.Location = New System.Drawing.Point(167, 23)
        Me.cldDesde.Name = "cldDesde"
        Me.cldDesde.Size = New System.Drawing.Size(258, 227)
        Me.cldDesde.TabIndex = 1
        '
        'txtEmitido
        '
        Me.txtEmitido.Location = New System.Drawing.Point(101, 153)
        Me.txtEmitido.Name = "txtEmitido"
        Me.txtEmitido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtEmitido.Properties.Mask.EditMask = "n0"
        Me.txtEmitido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEmitido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEmitido.Size = New System.Drawing.Size(312, 22)
        Me.txtEmitido.TabIndex = 16
        '
        'lblEmitido
        '
        Me.lblEmitido.Location = New System.Drawing.Point(52, 157)
        Me.lblEmitido.Name = "lblEmitido"
        Me.lblEmitido.Size = New System.Drawing.Size(43, 13)
        Me.lblEmitido.TabIndex = 17
        Me.lblEmitido.Text = "Emitidos:"
        '
        'FrmAppVtaPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 281)
        Me.Controls.Add(Me.cldDesde)
        Me.Controls.Add(Me.cldHasta)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmAppVtaPromociones"
        Me.Text = "Promociones por ventas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmitido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cldHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents txtsucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmitido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEmitido As DevExpress.XtraEditors.LabelControl
End Class
