<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPromociones
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridPromociones = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdentificador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_HASTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CERRADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.COL_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.gridPromociones)
        Me.PanelControl1.Location = New System.Drawing.Point(13, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(549, 440)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtBuscar)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(522, 54)
        Me.PanelControl2.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Descripcion"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(5, 21)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Size = New System.Drawing.Size(281, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'gridPromociones
        '
        Me.gridPromociones.Location = New System.Drawing.Point(14, 74)
        Me.gridPromociones.MainView = Me.GridView1
        Me.gridPromociones.Name = "gridPromociones"
        Me.gridPromociones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.gridPromociones.Size = New System.Drawing.Size(522, 353)
        Me.gridPromociones.TabIndex = 1
        Me.gridPromociones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdentificador, Me.COL_DESCRIPCION, Me.COL_DESDE, Me.COL_HASTA, Me.COL_CERRADO, Me.COL_PROVEEDOR})
        Me.GridView1.GridControl = Me.gridPromociones
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIdentificador
        '
        Me.colIdentificador.AppearanceCell.Options.UseTextOptions = True
        Me.colIdentificador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colIdentificador.AppearanceHeader.Options.UseTextOptions = True
        Me.colIdentificador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colIdentificador.Caption = "Identificador"
        Me.colIdentificador.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colIdentificador.FieldName = "IDENTIFICADOR"
        Me.colIdentificador.Name = "colIdentificador"
        Me.colIdentificador.Width = 110
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.AppearanceCell.Options.UseTextOptions = True
        Me.COL_DESCRIPCION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_DESCRIPCION.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_DESCRIPCION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 0
        Me.COL_DESCRIPCION.Width = 153
        '
        'COL_DESDE
        '
        Me.COL_DESDE.Caption = "DESDE"
        Me.COL_DESDE.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.COL_DESDE.FieldName = "FECHA_DESDE"
        Me.COL_DESDE.Name = "COL_DESDE"
        Me.COL_DESDE.Visible = True
        Me.COL_DESDE.VisibleIndex = 2
        Me.COL_DESDE.Width = 72
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'COL_HASTA
        '
        Me.COL_HASTA.Caption = "HASTA"
        Me.COL_HASTA.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.COL_HASTA.FieldName = "FECHA_HASTA"
        Me.COL_HASTA.Name = "COL_HASTA"
        Me.COL_HASTA.Visible = True
        Me.COL_HASTA.VisibleIndex = 3
        Me.COL_HASTA.Width = 72
        '
        'COL_CERRADO
        '
        Me.COL_CERRADO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CERRADO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_CERRADO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CERRADO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.COL_CERRADO.Caption = "CERRADO"
        Me.COL_CERRADO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.COL_CERRADO.FieldName = "CERRADO"
        Me.COL_CERRADO.Name = "COL_CERRADO"
        Me.COL_CERRADO.Visible = True
        Me.COL_CERRADO.VisibleIndex = 4
        Me.COL_CERRADO.Width = 64
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "S"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "N"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "S"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'COL_PROVEEDOR
        '
        Me.COL_PROVEEDOR.Caption = "PROVEEDOR"
        Me.COL_PROVEEDOR.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_PROVEEDOR.FieldName = "PROVEEDOR"
        Me.COL_PROVEEDOR.Name = "COL_PROVEEDOR"
        Me.COL_PROVEEDOR.Visible = True
        Me.COL_PROVEEDOR.VisibleIndex = 1
        Me.COL_PROVEEDOR.Width = 143
        '
        'FrmVistaPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 464)
        Me.Controls.Add(Me.PanelControl1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmVistaPromociones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promociones"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridPromociones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdentificador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_HASTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents COL_CERRADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
