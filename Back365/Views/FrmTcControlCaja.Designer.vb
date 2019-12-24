<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTcControlCaja
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gridListado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_FECHA_APERTURA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.caja = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_USUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DIFERENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.diferencia = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ARQUEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.arqueado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.COL_CERRADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cerrado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.COL_ENV_SERVER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.enviado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arqueado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enviado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCancelar)
        Me.PanelControl1.Controls.Add(Me.btnAceptar)
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
        Me.PanelControl1.Size = New System.Drawing.Size(808, 149)
        Me.PanelControl1.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(602, 59)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 31)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(602, 21)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 31)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Consultar"
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
        'cldHasta
        '
        Me.cldHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldHasta.Location = New System.Drawing.Point(439, 99)
        Me.cldHasta.Name = "cldHasta"
        Me.cldHasta.Size = New System.Drawing.Size(250, 227)
        Me.cldHasta.TabIndex = 13
        '
        'cldDesde
        '
        Me.cldDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldDesde.Location = New System.Drawing.Point(439, 72)
        Me.cldDesde.Name = "cldDesde"
        Me.cldDesde.Size = New System.Drawing.Size(250, 227)
        Me.cldDesde.TabIndex = 12
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.gridListado)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 167)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(808, 311)
        Me.PanelControl2.TabIndex = 14
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(13, 16)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.fecha, Me.caja, Me.usuario, Me.arqueado, Me.cerrado, Me.enviado, Me.diferencia})
        Me.gridListado.Size = New System.Drawing.Size(783, 278)
        Me.gridListado.TabIndex = 0
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_FECHA_APERTURA, Me.COL_CAJA, Me.COL_USUARIO, Me.COL_DIFERENCIA, Me.COL_ARQUEADO, Me.COL_CERRADO, Me.COL_ENV_SERVER})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_FECHA_APERTURA
        '
        Me.COL_FECHA_APERTURA.Caption = "FECHA APERT."
        Me.COL_FECHA_APERTURA.ColumnEdit = Me.fecha
        Me.COL_FECHA_APERTURA.FieldName = "FECHA_APERT"
        Me.COL_FECHA_APERTURA.Name = "COL_FECHA_APERTURA"
        Me.COL_FECHA_APERTURA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FECHA_APERT", "{0}")})
        Me.COL_FECHA_APERTURA.Visible = True
        Me.COL_FECHA_APERTURA.VisibleIndex = 0
        Me.COL_FECHA_APERTURA.Width = 112
        '
        'fecha
        '
        Me.fecha.AutoHeight = False
        Me.fecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.fecha.Mask.EditMask = "G"
        Me.fecha.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.fecha.Name = "fecha"
        '
        'COL_CAJA
        '
        Me.COL_CAJA.Caption = "CAJA"
        Me.COL_CAJA.ColumnEdit = Me.caja
        Me.COL_CAJA.FieldName = "CAJA"
        Me.COL_CAJA.Name = "COL_CAJA"
        Me.COL_CAJA.Visible = True
        Me.COL_CAJA.VisibleIndex = 1
        Me.COL_CAJA.Width = 130
        '
        'caja
        '
        Me.caja.AutoHeight = False
        Me.caja.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.caja.Name = "caja"
        '
        'COL_USUARIO
        '
        Me.COL_USUARIO.Caption = "USUARIO"
        Me.COL_USUARIO.ColumnEdit = Me.usuario
        Me.COL_USUARIO.FieldName = "USUARIO"
        Me.COL_USUARIO.Name = "COL_USUARIO"
        Me.COL_USUARIO.Visible = True
        Me.COL_USUARIO.VisibleIndex = 2
        Me.COL_USUARIO.Width = 128
        '
        'usuario
        '
        Me.usuario.AutoHeight = False
        Me.usuario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.usuario.Name = "usuario"
        '
        'COL_DIFERENCIA
        '
        Me.COL_DIFERENCIA.Caption = "DIFERENCIA"
        Me.COL_DIFERENCIA.ColumnEdit = Me.diferencia
        Me.COL_DIFERENCIA.FieldName = "DIFERENCIA"
        Me.COL_DIFERENCIA.Name = "COL_DIFERENCIA"
        Me.COL_DIFERENCIA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DIFERENCIA", "{0:#,#}")})
        Me.COL_DIFERENCIA.Visible = True
        Me.COL_DIFERENCIA.VisibleIndex = 3
        Me.COL_DIFERENCIA.Width = 100
        '
        'diferencia
        '
        Me.diferencia.AutoHeight = False
        Me.diferencia.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.diferencia.Mask.EditMask = "n0"
        Me.diferencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.diferencia.Mask.UseMaskAsDisplayFormat = True
        Me.diferencia.Name = "diferencia"
        '
        'COL_ARQUEADO
        '
        Me.COL_ARQUEADO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_ARQUEADO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_ARQUEADO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_ARQUEADO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_ARQUEADO.Caption = "ARQUEADO"
        Me.COL_ARQUEADO.ColumnEdit = Me.arqueado
        Me.COL_ARQUEADO.FieldName = "ARQUEADO"
        Me.COL_ARQUEADO.Name = "COL_ARQUEADO"
        Me.COL_ARQUEADO.Visible = True
        Me.COL_ARQUEADO.VisibleIndex = 4
        Me.COL_ARQUEADO.Width = 100
        '
        'arqueado
        '
        Me.arqueado.AutoHeight = False
        Me.arqueado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.arqueado.Name = "arqueado"
        Me.arqueado.ValueChecked = "S"
        Me.arqueado.ValueUnchecked = "N"
        '
        'COL_CERRADO
        '
        Me.COL_CERRADO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CERRADO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_CERRADO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CERRADO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_CERRADO.Caption = "CERRADO"
        Me.COL_CERRADO.ColumnEdit = Me.cerrado
        Me.COL_CERRADO.FieldName = "CERRADO"
        Me.COL_CERRADO.Name = "COL_CERRADO"
        Me.COL_CERRADO.Visible = True
        Me.COL_CERRADO.VisibleIndex = 5
        Me.COL_CERRADO.Width = 100
        '
        'cerrado
        '
        Me.cerrado.AutoHeight = False
        Me.cerrado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cerrado.Name = "cerrado"
        Me.cerrado.ValueChecked = "S"
        Me.cerrado.ValueUnchecked = "N"
        '
        'COL_ENV_SERVER
        '
        Me.COL_ENV_SERVER.AppearanceCell.Options.UseTextOptions = True
        Me.COL_ENV_SERVER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_ENV_SERVER.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_ENV_SERVER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_ENV_SERVER.Caption = "ENVIADO SRV"
        Me.COL_ENV_SERVER.ColumnEdit = Me.enviado
        Me.COL_ENV_SERVER.FieldName = "FECHA_ENVIO_SRV"
        Me.COL_ENV_SERVER.Name = "COL_ENV_SERVER"
        Me.COL_ENV_SERVER.Visible = True
        Me.COL_ENV_SERVER.VisibleIndex = 6
        Me.COL_ENV_SERVER.Width = 100
        '
        'enviado
        '
        Me.enviado.AutoHeight = False
        Me.enviado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.enviado.Name = "enviado"
        Me.enviado.ValueChecked = "S"
        Me.enviado.ValueUnchecked = "N"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl2)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(833, 492)
        Me.PanelControl3.TabIndex = 15
        '
        'FrmTcControlCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 516)
        Me.Controls.Add(Me.cldHasta)
        Me.Controls.Add(Me.cldDesde)
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "FrmTcControlCaja"
        Me.Text = "Controles de caja"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arqueado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enviado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents txtsucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cldHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_CAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ARQUEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CERRADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_FECHA_APERTURA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ENV_SERVER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents caja As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents usuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents arqueado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cerrado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents enviado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents COL_DIFERENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents diferencia As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
