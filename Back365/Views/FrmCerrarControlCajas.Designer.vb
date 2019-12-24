<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCerrarControlCajas
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
        Me.rpsFechaApertura = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsEmpresa = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsUnidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsCaja = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.chkArqueado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.chkCerrado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.gridControles = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdentificador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaApert = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadOperativa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCaja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArqueado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCerrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCaja = New DevExpress.XtraEditors.TextEdit()
        Me.btnCajas = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.cldFechaHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldFechaDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.rpsFechaApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkArqueado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCerrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridControles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpsFechaApertura
        '
        Me.rpsFechaApertura.AutoHeight = False
        Me.rpsFechaApertura.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsFechaApertura.Name = "rpsFechaApertura"
        Me.rpsFechaApertura.ReadOnly = True
        '
        'rpsEmpresa
        '
        Me.rpsEmpresa.AutoHeight = False
        Me.rpsEmpresa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsEmpresa.Name = "rpsEmpresa"
        Me.rpsEmpresa.ReadOnly = True
        '
        'rpsUnidad
        '
        Me.rpsUnidad.AutoHeight = False
        Me.rpsUnidad.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsUnidad.Name = "rpsUnidad"
        Me.rpsUnidad.ReadOnly = True
        '
        'rpsCaja
        '
        Me.rpsCaja.AutoHeight = False
        Me.rpsCaja.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaja.Name = "rpsCaja"
        Me.rpsCaja.ReadOnly = True
        '
        'chkArqueado
        '
        Me.chkArqueado.AutoHeight = False
        Me.chkArqueado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.chkArqueado.Name = "chkArqueado"
        Me.chkArqueado.ValueChecked = "S"
        Me.chkArqueado.ValueUnchecked = "N"
        '
        'chkCerrado
        '
        Me.chkCerrado.AutoHeight = False
        Me.chkCerrado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.chkCerrado.Name = "chkCerrado"
        Me.chkCerrado.ValueChecked = "S"
        Me.chkCerrado.ValueUnchecked = "N"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(15, 14)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(834, 450)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.gridControles)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 170)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(805, 263)
        Me.PanelControl3.TabIndex = 1
        '
        'gridControles
        '
        Me.gridControles.Location = New System.Drawing.Point(17, 18)
        Me.gridControles.MainView = Me.GridView1
        Me.gridControles.Name = "gridControles"
        Me.gridControles.Size = New System.Drawing.Size(768, 226)
        Me.gridControles.TabIndex = 0
        Me.gridControles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdentificador, Me.colFechaApert, Me.colEmpresa, Me.colUnidadOperativa, Me.colCaja, Me.colArqueado, Me.colCerrado})
        Me.GridView1.GridControl = Me.gridControles
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIdentificador
        '
        Me.colIdentificador.Caption = "Identificador"
        Me.colIdentificador.FieldName = "IDENTIFICADOR"
        Me.colIdentificador.Name = "colIdentificador"
        '
        'colFechaApert
        '
        Me.colFechaApert.Caption = "Fecha Apertura"
        Me.colFechaApert.ColumnEdit = Me.rpsFechaApertura
        Me.colFechaApert.FieldName = "FECHA_APERT"
        Me.colFechaApert.Name = "colFechaApert"
        Me.colFechaApert.Visible = True
        Me.colFechaApert.VisibleIndex = 0
        Me.colFechaApert.Width = 140
        '
        'colEmpresa
        '
        Me.colEmpresa.Caption = "Empresa"
        Me.colEmpresa.ColumnEdit = Me.rpsEmpresa
        Me.colEmpresa.FieldName = "EMPRESA"
        Me.colEmpresa.Name = "colEmpresa"
        Me.colEmpresa.Visible = True
        Me.colEmpresa.VisibleIndex = 1
        Me.colEmpresa.Width = 160
        '
        'colUnidadOperativa
        '
        Me.colUnidadOperativa.Caption = "Unidad Operativa"
        Me.colUnidadOperativa.ColumnEdit = Me.rpsUnidad
        Me.colUnidadOperativa.FieldName = "UNIDAD"
        Me.colUnidadOperativa.Name = "colUnidadOperativa"
        Me.colUnidadOperativa.Visible = True
        Me.colUnidadOperativa.VisibleIndex = 2
        Me.colUnidadOperativa.Width = 185
        '
        'colCaja
        '
        Me.colCaja.Caption = "Caja"
        Me.colCaja.ColumnEdit = Me.rpsCaja
        Me.colCaja.FieldName = "CAJA"
        Me.colCaja.Name = "colCaja"
        Me.colCaja.Visible = True
        Me.colCaja.VisibleIndex = 3
        Me.colCaja.Width = 80
        '
        'colArqueado
        '
        Me.colArqueado.Caption = "Arqueado"
        Me.colArqueado.ColumnEdit = Me.chkArqueado
        Me.colArqueado.FieldName = "ARQUEADO"
        Me.colArqueado.Name = "colArqueado"
        Me.colArqueado.Visible = True
        Me.colArqueado.VisibleIndex = 4
        Me.colArqueado.Width = 86
        '
        'colCerrado
        '
        Me.colCerrado.Caption = "Cerrado"
        Me.colCerrado.ColumnEdit = Me.chkCerrado
        Me.colCerrado.FieldName = "CERRADO"
        Me.colCerrado.Name = "colCerrado"
        Me.colCerrado.Visible = True
        Me.colCerrado.VisibleIndex = 5
        Me.colCerrado.Width = 99
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.txtCaja)
        Me.PanelControl2.Controls.Add(Me.btnCajas)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl2.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(805, 141)
        Me.PanelControl2.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(659, 53)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(659, 17)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 30)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(659, 89)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Fecha hasta:"
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(82, 17)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCaja.Properties.Appearance.Options.UseBackColor = True
        Me.txtCaja.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCaja.Size = New System.Drawing.Size(231, 22)
        Me.txtCaja.TabIndex = 0
        '
        'btnCajas
        '
        Me.btnCajas.Location = New System.Drawing.Point(317, 17)
        Me.btnCajas.Name = "btnCajas"
        Me.btnCajas.Size = New System.Drawing.Size(26, 22)
        Me.btnCajas.TabIndex = 18
        Me.btnCajas.TabStop = False
        Me.btnCajas.Text = "+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Caja:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(317, 74)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaHasta.TabIndex = 29
        Me.btnFechaHasta.Text = "+"
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(317, 45)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaDesde.TabIndex = 28
        Me.btnFechaDesde.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(82, 74)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaHasta.TabIndex = 2
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(82, 45)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaDesde.TabIndex = 1
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'cldFechaHasta
        '
        Me.cldFechaHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaHasta.Location = New System.Drawing.Point(353, 102)
        Me.cldFechaHasta.Name = "cldFechaHasta"
        Me.cldFechaHasta.Size = New System.Drawing.Size(237, 227)
        Me.cldFechaHasta.TabIndex = 32
        '
        'cldFechaDesde
        '
        Me.cldFechaDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaDesde.Location = New System.Drawing.Point(353, 73)
        Me.cldFechaDesde.Name = "cldFechaDesde"
        Me.cldFechaDesde.Size = New System.Drawing.Size(237, 227)
        Me.cldFechaDesde.TabIndex = 33
        '
        'FrmCerrarControlCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 480)
        Me.Controls.Add(Me.cldFechaHasta)
        Me.Controls.Add(Me.cldFechaDesde)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmCerrarControlCajas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre de controles de caja"
        CType(Me.rpsFechaApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkArqueado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCerrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridControles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCajas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents cldFechaHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldFechaDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridControles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdentificador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaApert As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArqueado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCerrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rpsFechaApertura As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsEmpresa As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsUnidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCaja As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents chkArqueado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkCerrado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
