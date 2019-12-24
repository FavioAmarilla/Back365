<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptComprasProveedorMeses
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
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_mes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsTxtCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMontoTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsTxtMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotaCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSucursales = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.btnUnidades = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnidad = New DevExpress.XtraEditors.TextEdit()
        Me.btnEmpresas = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFamilias = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.cldFechaDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldFechaHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cldFechaDesde)
        Me.PanelControl1.Controls.Add(Me.cldFechaHasta)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(938, 448)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnImprimir)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Location = New System.Drawing.Point(13, 137)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(915, 296)
        Me.PanelControl3.TabIndex = 1
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(802, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 31)
        Me.btnImprimir.TabIndex = 42
        Me.btnImprimir.Text = "Imprimir"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(15, 16)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsTxtCaracter, Me.rpsTxtMiles})
        Me.GridControl1.Size = New System.Drawing.Size(772, 265)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_mes, Me.colMontoTotal, Me.colFactura, Me.colNotaCredito})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col_mes
        '
        Me.col_mes.Caption = "MES"
        Me.col_mes.ColumnEdit = Me.rpsTxtCaracter
        Me.col_mes.FieldName = "MES"
        Me.col_mes.Name = "col_mes"
        Me.col_mes.Visible = True
        Me.col_mes.VisibleIndex = 0
        Me.col_mes.Width = 210
        '
        'rpsTxtCaracter
        '
        Me.rpsTxtCaracter.AutoHeight = False
        Me.rpsTxtCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtCaracter.Name = "rpsTxtCaracter"
        '
        'colMontoTotal
        '
        Me.colMontoTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colMontoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMontoTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMontoTotal.Caption = "MONTO NETO"
        Me.colMontoTotal.ColumnEdit = Me.rpsTxtMiles
        Me.colMontoTotal.FieldName = "MONTO_NETO"
        Me.colMontoTotal.Name = "colMontoTotal"
        Me.colMontoTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONTO_NETO", "{0:#,#}", CType(0, Long))})
        Me.colMontoTotal.Visible = True
        Me.colMontoTotal.VisibleIndex = 3
        Me.colMontoTotal.Width = 80
        '
        'rpsTxtMiles
        '
        Me.rpsTxtMiles.AutoHeight = False
        Me.rpsTxtMiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtMiles.Mask.EditMask = "n0"
        Me.rpsTxtMiles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTxtMiles.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTxtMiles.Name = "rpsTxtMiles"
        '
        'colFactura
        '
        Me.colFactura.AppearanceCell.Options.UseTextOptions = True
        Me.colFactura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colFactura.AppearanceHeader.Options.UseTextOptions = True
        Me.colFactura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colFactura.Caption = "FACTURACION"
        Me.colFactura.ColumnEdit = Me.rpsTxtMiles
        Me.colFactura.FieldName = "FACTURA"
        Me.colFactura.Name = "colFactura"
        Me.colFactura.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FACTURA", "{0:#,#}", CType(0, Long))})
        Me.colFactura.Visible = True
        Me.colFactura.VisibleIndex = 1
        Me.colFactura.Width = 80
        '
        'colNotaCredito
        '
        Me.colNotaCredito.AppearanceCell.Options.UseTextOptions = True
        Me.colNotaCredito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNotaCredito.AppearanceHeader.Options.UseTextOptions = True
        Me.colNotaCredito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNotaCredito.Caption = "NOTA DE CREDITO"
        Me.colNotaCredito.ColumnEdit = Me.rpsTxtMiles
        Me.colNotaCredito.FieldName = "NOTA_CREDITO"
        Me.colNotaCredito.Name = "colNotaCredito"
        Me.colNotaCredito.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NOTA_CREDITO", "{0:#,#}", CType(0, Long))})
        Me.colNotaCredito.Visible = True
        Me.colNotaCredito.VisibleIndex = 2
        Me.colNotaCredito.Width = 80
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnSucursales)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.btnUnidades)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txtUnidad)
        Me.PanelControl2.Controls.Add(Me.btnEmpresas)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtEmpresa)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnFamilias)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.txtProveedor)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl2.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl2.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl2.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl2.Location = New System.Drawing.Point(13, 15)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(915, 110)
        Me.PanelControl2.TabIndex = 0
        '
        'btnSucursales
        '
        Me.btnSucursales.Location = New System.Drawing.Point(301, 72)
        Me.btnSucursales.Name = "btnSucursales"
        Me.btnSucursales.Size = New System.Drawing.Size(25, 21)
        Me.btnSucursales.TabIndex = 50
        Me.btnSucursales.Text = "..."
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 75)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 49
        Me.LabelControl4.Text = "Sucursal:"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(65, 71)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(231, 22)
        Me.txtSucursal.TabIndex = 2
        '
        'btnUnidades
        '
        Me.btnUnidades.Location = New System.Drawing.Point(301, 44)
        Me.btnUnidades.Name = "btnUnidades"
        Me.btnUnidades.Size = New System.Drawing.Size(25, 21)
        Me.btnUnidades.TabIndex = 47
        Me.btnUnidades.Text = "..."
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Unidad:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(65, 43)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnidad.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUnidad.Properties.ReadOnly = True
        Me.txtUnidad.Size = New System.Drawing.Size(231, 22)
        Me.txtUnidad.TabIndex = 1
        '
        'btnEmpresas
        '
        Me.btnEmpresas.Location = New System.Drawing.Point(301, 16)
        Me.btnEmpresas.Name = "btnEmpresas"
        Me.btnEmpresas.Size = New System.Drawing.Size(25, 21)
        Me.btnEmpresas.TabIndex = 44
        Me.btnEmpresas.Text = "..."
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 43
        Me.LabelControl1.Text = "Empresa:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.EditValue = " "
        Me.txtEmpresa.Location = New System.Drawing.Point(65, 15)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEmpresa.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtEmpresa.Properties.ReadOnly = True
        Me.txtEmpresa.Size = New System.Drawing.Size(231, 22)
        Me.txtEmpresa.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(802, 52)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 31)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnFamilias
        '
        Me.btnFamilias.Location = New System.Drawing.Point(659, 16)
        Me.btnFamilias.Name = "btnFamilias"
        Me.btnFamilias.Size = New System.Drawing.Size(25, 21)
        Me.btnFamilias.TabIndex = 41
        Me.btnFamilias.Text = "..."
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(802, 15)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(95, 31)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(366, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 40
        Me.LabelControl3.Text = "Proveedor:"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(423, 15)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProveedor.Properties.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(231, 22)
        Me.txtProveedor.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Fecha hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Fecha desde:"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(658, 72)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaHasta.TabIndex = 38
        Me.btnFechaHasta.Text = "+"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(423, 43)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaDesde.TabIndex = 4
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(658, 43)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaDesde.TabIndex = 37
        Me.btnFechaDesde.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(423, 72)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaHasta.TabIndex = 5
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'cldFechaDesde
        '
        Me.cldFechaDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaDesde.Location = New System.Drawing.Point(672, 58)
        Me.cldFechaDesde.Name = "cldFechaDesde"
        Me.cldFechaDesde.Size = New System.Drawing.Size(255, 227)
        Me.cldFechaDesde.TabIndex = 40
        '
        'cldFechaHasta
        '
        Me.cldFechaHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaHasta.Location = New System.Drawing.Point(671, 87)
        Me.cldFechaHasta.Name = "cldFechaHasta"
        Me.cldFechaHasta.Size = New System.Drawing.Size(255, 227)
        Me.cldFechaHasta.TabIndex = 39
        '
        'FrmRptComprasProveedorMeses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 472)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRptComprasProveedorMeses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras por meses"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents cldFechaDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldFechaHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents btnFamilias As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_mes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotaCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsTxtCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTxtMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMontoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEmpresas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSucursales As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnUnidades As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnidad As DevExpress.XtraEditors.TextEdit
End Class
