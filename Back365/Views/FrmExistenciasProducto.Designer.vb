<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExistenciasProducto
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
        Me.gridExistencia = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_ALMACEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_EXISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDecimal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProducto = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoBarras = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gridExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtdescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(547, 357)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.gridExistencia)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 118)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(521, 220)
        Me.PanelControl3.TabIndex = 5
        '
        'gridExistencia
        '
        Me.gridExistencia.Location = New System.Drawing.Point(11, 13)
        Me.gridExistencia.MainView = Me.GridView1
        Me.gridExistencia.Name = "gridExistencia"
        Me.gridExistencia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracter, Me.rpsDecimal})
        Me.gridExistencia.Size = New System.Drawing.Size(493, 196)
        Me.gridExistencia.TabIndex = 4
        Me.gridExistencia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_ALMACEN, Me.COL_EXISTENCIA})
        Me.GridView1.GridControl = Me.gridExistencia
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_ALMACEN
        '
        Me.COL_ALMACEN.Caption = "ALMACEN"
        Me.COL_ALMACEN.ColumnEdit = Me.rpsCaracter
        Me.COL_ALMACEN.FieldName = "ALMACEN"
        Me.COL_ALMACEN.Name = "COL_ALMACEN"
        Me.COL_ALMACEN.Visible = True
        Me.COL_ALMACEN.VisibleIndex = 0
        Me.COL_ALMACEN.Width = 322
        '
        'rpsCaracter
        '
        Me.rpsCaracter.AutoHeight = False
        Me.rpsCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracter.Name = "rpsCaracter"
        '
        'COL_EXISTENCIA
        '
        Me.COL_EXISTENCIA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_EXISTENCIA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_EXISTENCIA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_EXISTENCIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_EXISTENCIA.Caption = "EXISTENCIA"
        Me.COL_EXISTENCIA.ColumnEdit = Me.rpsDecimal
        Me.COL_EXISTENCIA.FieldName = "EXISTENCIA"
        Me.COL_EXISTENCIA.Name = "COL_EXISTENCIA"
        Me.COL_EXISTENCIA.Visible = True
        Me.COL_EXISTENCIA.VisibleIndex = 1
        Me.COL_EXISTENCIA.Width = 153
        '
        'rpsDecimal
        '
        Me.rpsDecimal.AutoHeight = False
        Me.rpsDecimal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDecimal.Mask.EditMask = "n3"
        Me.rpsDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDecimal.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDecimal.Name = "rpsDecimal"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.btnProducto)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.txtdescripcion)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txtCodigoBarras)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(521, 94)
        Me.PanelControl2.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(425, 45)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(79, 26)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(425, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(79, 26)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(279, 13)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(25, 22)
        Me.btnProducto.TabIndex = 4
        Me.btnProducto.Text = "+"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Codigo barras:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(91, 40)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.Properties.Appearance.Options.UseBackColor = True
        Me.txtdescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtdescripcion.Properties.ReadOnly = True
        Me.txtdescripcion.Size = New System.Drawing.Size(307, 22)
        Me.txtdescripcion.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Descripcion:"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(91, 14)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigoBarras.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoBarras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodigoBarras.Size = New System.Drawing.Size(184, 22)
        Me.txtCodigoBarras.TabIndex = 2
        '
        'FrmExistenciasProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 381)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmExistenciasProducto"
        Me.Text = "Existencia de productos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.gridExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtdescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridExistencia As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnProducto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents COL_ALMACEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_EXISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDecimal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
End Class
