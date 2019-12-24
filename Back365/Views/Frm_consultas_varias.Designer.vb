<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultas_varias
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
        Me.grid_consulta = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.btnFamilias = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFamilia = New DevExpress.XtraEditors.TextEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.cldFechaDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldFechaHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.grid_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_consulta
        '
        Me.grid_consulta.Location = New System.Drawing.Point(14, 21)
        Me.grid_consulta.MainView = Me.GridView1
        Me.grid_consulta.Name = "grid_consulta"
        Me.grid_consulta.Size = New System.Drawing.Size(932, 354)
        Me.grid_consulta.TabIndex = 2
        Me.grid_consulta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grid_consulta
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(838, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(94, 32)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "Imprimir"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(13, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(991, 547)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.grid_consulta)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 132)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(960, 397)
        Me.PanelControl3.TabIndex = 9
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnSucursal)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl2.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl2.Controls.Add(Me.btnFamilias)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.txtFamilia)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnImprimir)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 16)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(960, 100)
        Me.PanelControl2.TabIndex = 0
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(632, 47)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(25, 21)
        Me.btnSucursal.TabIndex = 32
        Me.btnSucursal.Text = "..."
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(370, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "Sucursal:"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(420, 47)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(210, 22)
        Me.txtSucursal.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha desde:"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(339, 47)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaHasta.TabIndex = 29
        Me.btnFechaHasta.Text = "+"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(104, 18)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaDesde.TabIndex = 0
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(339, 18)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaDesde.TabIndex = 28
        Me.btnFechaDesde.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(104, 47)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaHasta.TabIndex = 1
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'btnFamilias
        '
        Me.btnFamilias.Location = New System.Drawing.Point(632, 18)
        Me.btnFamilias.Name = "btnFamilias"
        Me.btnFamilias.Size = New System.Drawing.Size(25, 21)
        Me.btnFamilias.TabIndex = 11
        Me.btnFamilias.Text = "..."
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(378, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Familia:"
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(420, 18)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFamilia.Properties.Appearance.Options.UseBackColor = True
        Me.txtFamilia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFamilia.Properties.ReadOnly = True
        Me.txtFamilia.Size = New System.Drawing.Size(210, 22)
        Me.txtFamilia.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(742, 54)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 31)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(742, 17)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(90, 31)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.TabStop = False
        Me.btnConsultar.Text = "Consultar"
        '
        'cldFechaDesde
        '
        Me.cldFechaDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaDesde.Location = New System.Drawing.Point(367, 46)
        Me.cldFechaDesde.Name = "cldFechaDesde"
        Me.cldFechaDesde.Size = New System.Drawing.Size(253, 227)
        Me.cldFechaDesde.TabIndex = 31
        '
        'cldFechaHasta
        '
        Me.cldFechaHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaHasta.Location = New System.Drawing.Point(367, 75)
        Me.cldFechaHasta.Name = "cldFechaHasta"
        Me.cldFechaHasta.Size = New System.Drawing.Size(253, 227)
        Me.cldFechaHasta.TabIndex = 30
        '
        'Frm_consultas_varias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 571)
        Me.Controls.Add(Me.cldFechaDesde)
        Me.Controls.Add(Me.cldFechaHasta)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Frm_consultas_varias"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos vendidos por familia"
        CType(Me.grid_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_consulta As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFamilias As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents cldFechaDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldFechaHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
End Class
