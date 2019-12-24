<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFndMenues
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
        Me.gridListado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(626, 429)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridListado)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 137)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(597, 280)
        Me.PanelControl3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(30, 29)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(352, 22)
        Me.txtBuscar.TabIndex = 6
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(16, 18)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracteres})
        Me.gridListado.Size = New System.Drawing.Size(564, 245)
        Me.gridListado.TabIndex = 0
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_NOMBRE, Me.COL_DESCRIPCION})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_IDENTIFICADOR
        '
        Me.COL_IDENTIFICADOR.Caption = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.ColumnEdit = Me.rpsCaracteres
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        '
        'rpsCaracteres
        '
        Me.rpsCaracteres.AutoHeight = False
        Me.rpsCaracteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracteres.Name = "rpsCaracteres"
        '
        'COL_NOMBRE
        '
        Me.COL_NOMBRE.Caption = "NOMBRE"
        Me.COL_NOMBRE.ColumnEdit = Me.rpsCaracteres
        Me.COL_NOMBRE.FieldName = "NOMBRE"
        Me.COL_NOMBRE.Name = "COL_NOMBRE"
        Me.COL_NOMBRE.Visible = True
        Me.COL_NOMBRE.VisibleIndex = 0
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.rpsCaracteres
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.txtDescripcion)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.txtNombre)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(597, 110)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(490, 53)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 31)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(86, 50)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDescripcion.Size = New System.Drawing.Size(321, 22)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(490, 15)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 31)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(86, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNombre.Size = New System.Drawing.Size(321, 22)
        Me.txtNombre.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Descripcion:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(39, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre:"
        '
        'FrmFndMenues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 453)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmFndMenues"
        Me.Text = "Definicion de menues"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaracteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
End Class
