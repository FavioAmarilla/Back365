<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRptPrMatrizProveedores
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridListado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_LINEA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ULT_COMPRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDecimal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_VENDIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(783, 453)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridListado)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 143)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(752, 299)
        Me.PanelControl3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(25, 26)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(357, 22)
        Me.txtBuscar.TabIndex = 6
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(13, 14)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracter, Me.rpsDecimal})
        Me.gridListado.Size = New System.Drawing.Size(727, 272)
        Me.gridListado.TabIndex = 0
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_LINEA, Me.COL_ULT_COMPRA, Me.COL_CANTIDAD, Me.COL_VENDIDO})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.COL_LINEA, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.rpsCaracter
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 101
        '
        'rpsCaracter
        '
        Me.rpsCaracter.AutoHeight = False
        Me.rpsCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracter.Name = "rpsCaracter"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsCaracter
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 175
        '
        'COL_LINEA
        '
        Me.COL_LINEA.Caption = "LINEA"
        Me.COL_LINEA.ColumnEdit = Me.rpsCaracter
        Me.COL_LINEA.FieldName = "LINEA"
        Me.COL_LINEA.Name = "COL_LINEA"
        Me.COL_LINEA.Visible = True
        Me.COL_LINEA.VisibleIndex = 2
        Me.COL_LINEA.Width = 168
        '
        'COL_ULT_COMPRA
        '
        Me.COL_ULT_COMPRA.Caption = "ULT. COMPRA"
        Me.COL_ULT_COMPRA.ColumnEdit = Me.rpsCaracter
        Me.COL_ULT_COMPRA.FieldName = "FEC_ULTIMA_COMPRA"
        Me.COL_ULT_COMPRA.Name = "COL_ULT_COMPRA"
        Me.COL_ULT_COMPRA.Visible = True
        Me.COL_ULT_COMPRA.VisibleIndex = 2
        Me.COL_ULT_COMPRA.Width = 94
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.AppearanceCell.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_CANTIDAD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_CANTIDAD.Caption = "CANTIDAD"
        Me.COL_CANTIDAD.ColumnEdit = Me.rpsDecimal
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CANTIDAD", "{0:0.00}")})
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 3
        Me.COL_CANTIDAD.Width = 80
        '
        'rpsDecimal
        '
        Me.rpsDecimal.AutoHeight = False
        Me.rpsDecimal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDecimal.Mask.EditMask = "n"
        Me.rpsDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDecimal.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDecimal.Name = "rpsDecimal"
        Me.rpsDecimal.NullText = "0"
        '
        'COL_VENDIDO
        '
        Me.COL_VENDIDO.AppearanceCell.Options.UseTextOptions = True
        Me.COL_VENDIDO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_VENDIDO.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_VENDIDO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_VENDIDO.Caption = "VENDIDO"
        Me.COL_VENDIDO.ColumnEdit = Me.rpsDecimal
        Me.COL_VENDIDO.FieldName = "VENTA_ULTIMA_COMPRA"
        Me.COL_VENDIDO.Name = "COL_VENDIDO"
        Me.COL_VENDIDO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VENTA_ULTIMA_COMPRA", "{0:0.00}")})
        Me.COL_VENDIDO.Visible = True
        Me.COL_VENDIDO.VisibleIndex = 4
        Me.COL_VENDIDO.Width = 91
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnImprimir)
        Me.PanelControl2.Controls.Add(Me.btnConsultar)
        Me.PanelControl2.Controls.Add(Me.btnProveedor)
        Me.PanelControl2.Controls.Add(Me.txtProveedor)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 11)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(752, 123)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(608, 82)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(608, 46)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 30)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(608, 10)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(91, 30)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        '
        'btnProveedor
        '
        Me.btnProveedor.Location = New System.Drawing.Point(388, 17)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(28, 23)
        Me.btnProveedor.TabIndex = 2
        Me.btnProveedor.Text = "..."
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(113, 19)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProveedor.Properties.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(269, 22)
        Me.txtProveedor.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(53, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Proveedor:"
        '
        'FrmRptPrMatrizProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 477)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRptPrMatrizProveedores"
        Me.Text = "Matriz de proveedores"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_LINEA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ULT_COMPRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_VENDIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDecimal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
End Class
