<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptExistenciaPorAlmacenes
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
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridProductos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_EXISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_LINEA_PROD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsDecimales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLineas = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLinea = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAlmacenes = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAlmacen = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkExistencia = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDecimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(637, 417)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridProductos)
        Me.PanelControl3.Location = New System.Drawing.Point(10, 140)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(611, 268)
        Me.PanelControl3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(21, 20)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(352, 22)
        Me.txtBuscar.TabIndex = 5
        '
        'gridProductos
        '
        Me.gridProductos.Location = New System.Drawing.Point(14, 10)
        Me.gridProductos.MainView = Me.GridView1
        Me.gridProductos.Name = "gridProductos"
        Me.gridProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracteres, Me.rpsDecimales})
        Me.gridProductos.Size = New System.Drawing.Size(583, 249)
        Me.gridProductos.TabIndex = 0
        Me.gridProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_EXISTENCIA, Me.COL_LINEA_PROD})
        Me.GridView1.GridControl = Me.gridProductos
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.COL_LINEA_PROD, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.Caption = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Width = 91
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 98
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 290
        '
        'COL_EXISTENCIA
        '
        Me.COL_EXISTENCIA.Caption = "EXISTENCIA"
        Me.COL_EXISTENCIA.FieldName = "EXISTENCIA"
        Me.COL_EXISTENCIA.Name = "COL_EXISTENCIA"
        Me.COL_EXISTENCIA.Visible = True
        Me.COL_EXISTENCIA.VisibleIndex = 2
        Me.COL_EXISTENCIA.Width = 86
        '
        'COL_LINEA_PROD
        '
        Me.COL_LINEA_PROD.Caption = "LINEA"
        Me.COL_LINEA_PROD.FieldName = "LINEA"
        Me.COL_LINEA_PROD.Name = "COL_LINEA_PROD"
        Me.COL_LINEA_PROD.Visible = True
        Me.COL_LINEA_PROD.VisibleIndex = 3
        '
        'rpsCaracteres
        '
        Me.rpsCaracteres.AutoHeight = False
        Me.rpsCaracteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracteres.Name = "rpsCaracteres"
        '
        'rpsDecimales
        '
        Me.rpsDecimales.AutoHeight = False
        Me.rpsDecimales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDecimales.Mask.EditMask = "n"
        Me.rpsDecimales.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDecimales.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDecimales.Name = "rpsDecimales"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.chkExistencia)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.btnLineas)
        Me.PanelControl2.Controls.Add(Me.txtLinea)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.btnAlmacenes)
        Me.PanelControl2.Controls.Add(Me.txtAlmacen)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 9)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(612, 125)
        Me.PanelControl2.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(504, 46)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 31)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "Imprimir"
        '
        'btnLineas
        '
        Me.btnLineas.Location = New System.Drawing.Point(359, 41)
        Me.btnLineas.Name = "btnLineas"
        Me.btnLineas.Size = New System.Drawing.Size(28, 22)
        Me.btnLineas.TabIndex = 5
        Me.btnLineas.Text = "+"
        '
        'txtLinea
        '
        Me.txtLinea.EditValue = " "
        Me.txtLinea.Location = New System.Drawing.Point(125, 42)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtLinea.Properties.Appearance.Options.UseBackColor = True
        Me.txtLinea.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtLinea.Properties.ReadOnly = True
        Me.txtLinea.Size = New System.Drawing.Size(228, 22)
        Me.txtLinea.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(61, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Linea prod.:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(504, 83)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 31)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(504, 11)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 31)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnAlmacenes
        '
        Me.btnAlmacenes.Location = New System.Drawing.Point(359, 13)
        Me.btnAlmacenes.Name = "btnAlmacenes"
        Me.btnAlmacenes.Size = New System.Drawing.Size(28, 22)
        Me.btnAlmacenes.TabIndex = 4
        Me.btnAlmacenes.Text = "+"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.Location = New System.Drawing.Point(125, 14)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAlmacen.Properties.Appearance.Options.UseBackColor = True
        Me.txtAlmacen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtAlmacen.Properties.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(228, 22)
        Me.txtAlmacen.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(75, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Almacen:"
        '
        'chkExistencia
        '
        Me.chkExistencia.Location = New System.Drawing.Point(125, 70)
        Me.chkExistencia.Name = "chkExistencia"
        Me.chkExistencia.Properties.Caption = ""
        Me.chkExistencia.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkExistencia.Size = New System.Drawing.Size(17, 19)
        Me.chkExistencia.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(67, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Existencia:"
        '
        'FrmRptExistenciaPorAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 441)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRptExistenciaPorAlmacenes"
        Me.Text = "Existencia de productos por almacenes"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDecimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_EXISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAlmacenes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAlmacen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rpsCaracteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDecimales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnLineas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents COL_LINEA_PROD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkExistencia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
