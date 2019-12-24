<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaGastosDiarios
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.gridGastos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CONCEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsConcepto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsTotal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtFecha = New DevExpress.XtraEditors.TextEdit()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(613, 367)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.gridGastos)
        Me.PanelControl2.Controls.Add(Me.txtFecha)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(583, 337)
        Me.PanelControl2.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(476, 295)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 31)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(376, 295)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 31)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'gridGastos
        '
        Me.gridGastos.Location = New System.Drawing.Point(15, 54)
        Me.gridGastos.MainView = Me.GridView1
        Me.gridGastos.Name = "gridGastos"
        Me.gridGastos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsConcepto, Me.rpsTotal})
        Me.gridGastos.Size = New System.Drawing.Size(555, 223)
        Me.gridGastos.TabIndex = 2
        Me.gridGastos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_CONCEPTO, Me.COL_TOTAL})
        Me.GridView1.GridControl = Me.gridGastos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.Caption = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        '
        'COL_CONCEPTO
        '
        Me.COL_CONCEPTO.Caption = "CONCEPTO"
        Me.COL_CONCEPTO.ColumnEdit = Me.rpsConcepto
        Me.COL_CONCEPTO.FieldName = "CONCEPTO"
        Me.COL_CONCEPTO.Name = "COL_CONCEPTO"
        Me.COL_CONCEPTO.Visible = True
        Me.COL_CONCEPTO.VisibleIndex = 0
        Me.COL_CONCEPTO.Width = 390
        '
        'rpsConcepto
        '
        Me.rpsConcepto.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rpsConcepto.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rpsConcepto.AppearanceFocused.Options.UseBackColor = True
        Me.rpsConcepto.AppearanceFocused.Options.UseFont = True
        Me.rpsConcepto.AutoHeight = False
        Me.rpsConcepto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rpsConcepto.Name = "rpsConcepto"
        '
        'COL_TOTAL
        '
        Me.COL_TOTAL.Caption = "TOTAL"
        Me.COL_TOTAL.ColumnEdit = Me.rpsTotal
        Me.COL_TOTAL.FieldName = "TOTAL"
        Me.COL_TOTAL.Name = "COL_TOTAL"
        Me.COL_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL", "{0:#,#}")})
        Me.COL_TOTAL.Visible = True
        Me.COL_TOTAL.VisibleIndex = 1
        Me.COL_TOTAL.Width = 147
        '
        'rpsTotal
        '
        Me.rpsTotal.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rpsTotal.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rpsTotal.AppearanceFocused.Options.UseBackColor = True
        Me.rpsTotal.AppearanceFocused.Options.UseFont = True
        Me.rpsTotal.AutoHeight = False
        Me.rpsTotal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTotal.Mask.EditMask = "n0"
        Me.rpsTotal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTotal.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTotal.Name = "rpsTotal"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(350, 15)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFecha.Properties.Appearance.Options.UseBackColor = True
        Me.txtFecha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtFecha.Properties.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(220, 22)
        Me.txtFecha.TabIndex = 1
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(64, 15)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(220, 22)
        Me.txtSucursal.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sucursal:"
        '
        'FrmCargaGastosDiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 391)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmCargaGastosDiarios"
        Me.Text = "Gastos diarios"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.gridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtFecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gridGastos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_CONCEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsConcepto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTotal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
