<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreciosVentaAplicados
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
        Me.rpsCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridListado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_ANTERIOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_NUEVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_IMPRIMIR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpscheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
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
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpscheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpsCaracter
        '
        Me.rpsCaracter.AutoHeight = False
        Me.rpsCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracter.Name = "rpsCaracter"
        Me.rpsCaracter.ReadOnly = True
        '
        'rpsMiles
        '
        Me.rpsMiles.AutoHeight = False
        Me.rpsMiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsMiles.Mask.EditMask = "n0"
        Me.rpsMiles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsMiles.Mask.UseMaskAsDisplayFormat = True
        Me.rpsMiles.Name = "rpsMiles"
        Me.rpsMiles.ReadOnly = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(869, 495)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtBuscar)
        Me.PanelControl2.Controls.Add(Me.gridListado)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 165)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(838, 312)
        Me.PanelControl2.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(23, 25)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtBuscar.Properties.Appearance.Options.UseBackColor = True
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(358, 22)
        Me.txtBuscar.TabIndex = 12
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(11, 14)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpscheck})
        Me.gridListado.Size = New System.Drawing.Size(816, 282)
        Me.gridListado.TabIndex = 0
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_FECHA, Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_PRECIO_ANTERIOR, Me.COL_PRECIO_NUEVO, Me.COL_IMPRIMIR})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_FECHA
        '
        Me.COL_FECHA.Caption = "FECHA"
        Me.COL_FECHA.ColumnEdit = Me.rpsCaracter
        Me.COL_FECHA.FieldName = "FECHA"
        Me.COL_FECHA.Name = "COL_FECHA"
        Me.COL_FECHA.Visible = True
        Me.COL_FECHA.VisibleIndex = 0
        Me.COL_FECHA.Width = 95
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.rpsCaracter
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 1
        Me.COL_CODIGO_BARRAS.Width = 126
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsCaracter
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 2
        Me.COL_DESCRIPCION.Width = 361
        '
        'COL_PRECIO_ANTERIOR
        '
        Me.COL_PRECIO_ANTERIOR.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_ANTERIOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_ANTERIOR.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_ANTERIOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_ANTERIOR.Caption = "PRECIO ANTRERIOR"
        Me.COL_PRECIO_ANTERIOR.ColumnEdit = Me.rpsMiles
        Me.COL_PRECIO_ANTERIOR.FieldName = "PRECIO_ANTERIOR"
        Me.COL_PRECIO_ANTERIOR.Name = "COL_PRECIO_ANTERIOR"
        Me.COL_PRECIO_ANTERIOR.Visible = True
        Me.COL_PRECIO_ANTERIOR.VisibleIndex = 3
        Me.COL_PRECIO_ANTERIOR.Width = 102
        '
        'COL_PRECIO_NUEVO
        '
        Me.COL_PRECIO_NUEVO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_PRECIO_NUEVO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_NUEVO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_PRECIO_NUEVO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_PRECIO_NUEVO.Caption = "PRECIO NUEVO"
        Me.COL_PRECIO_NUEVO.ColumnEdit = Me.rpsMiles
        Me.COL_PRECIO_NUEVO.FieldName = "PRECIO_NUEVO"
        Me.COL_PRECIO_NUEVO.Name = "COL_PRECIO_NUEVO"
        Me.COL_PRECIO_NUEVO.Visible = True
        Me.COL_PRECIO_NUEVO.VisibleIndex = 4
        Me.COL_PRECIO_NUEVO.Width = 114
        '
        'COL_IMPRIMIR
        '
        Me.COL_IMPRIMIR.AppearanceCell.Options.UseTextOptions = True
        Me.COL_IMPRIMIR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_IMPRIMIR.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_IMPRIMIR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_IMPRIMIR.Caption = "IMPRIMIR"
        Me.COL_IMPRIMIR.ColumnEdit = Me.rpscheck
        Me.COL_IMPRIMIR.FieldName = "IMPRIMIR"
        Me.COL_IMPRIMIR.Name = "COL_IMPRIMIR"
        Me.COL_IMPRIMIR.Visible = True
        Me.COL_IMPRIMIR.VisibleIndex = 5
        '
        'rpscheck
        '
        Me.rpscheck.AutoHeight = False
        Me.rpscheck.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpscheck.Name = "rpscheck"
        Me.rpscheck.ValueChecked = "S"
        Me.rpscheck.ValueUnchecked = "F"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnImprimir)
        Me.PanelControl3.Controls.Add(Me.btnCancelar)
        Me.PanelControl3.Controls.Add(Me.btnAceptar)
        Me.PanelControl3.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl3.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl3.Controls.Add(Me.btnSucursal)
        Me.PanelControl3.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl3.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl3.Controls.Add(Me.txtsucursal)
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 13)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(838, 132)
        Me.PanelControl3.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(711, 53)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(94, 31)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(711, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 31)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(711, 16)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 31)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Consultar"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(387, 71)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaHasta.TabIndex = 8
        Me.btnFechaHasta.Text = "+"
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(387, 43)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(27, 21)
        Me.btnFechaDesde.TabIndex = 7
        Me.btnFechaDesde.Text = "+"
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(387, 16)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(27, 21)
        Me.btnSucursal.TabIndex = 6
        Me.btnSucursal.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(102, 72)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaHasta.TabIndex = 2
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(102, 43)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(279, 21)
        Me.txtFechaDesde.TabIndex = 1
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'txtsucursal
        '
        Me.txtsucursal.Location = New System.Drawing.Point(102, 16)
        Me.txtsucursal.Name = "txtsucursal"
        Me.txtsucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtsucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtsucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtsucursal.Properties.ReadOnly = True
        Me.txtsucursal.Size = New System.Drawing.Size(279, 22)
        Me.txtsucursal.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(36, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Fecha hasta:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(34, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Fecha desde:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(55, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Sucursal:"
        '
        'cldHasta
        '
        Me.cldHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldHasta.Location = New System.Drawing.Point(414, 95)
        Me.cldHasta.Name = "cldHasta"
        Me.cldHasta.Size = New System.Drawing.Size(245, 227)
        Me.cldHasta.TabIndex = 2
        '
        'cldDesde
        '
        Me.cldDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldDesde.Location = New System.Drawing.Point(414, 68)
        Me.cldDesde.Name = "cldDesde"
        Me.cldDesde.Size = New System.Drawing.Size(245, 227)
        Me.cldDesde.TabIndex = 1
        '
        'FrmPreciosVentaAplicados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 519)
        Me.Controls.Add(Me.cldHasta)
        Me.Controls.Add(Me.cldDesde)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmPreciosVentaAplicados"
        Me.Text = "Precios de ventas aplicados"
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpscheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtsucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_ANTERIOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_NUEVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rpsCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_IMPRIMIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpscheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
