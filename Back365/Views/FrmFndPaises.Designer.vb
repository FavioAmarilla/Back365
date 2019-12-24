<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFndPaises
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
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAbreviatura = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridListado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdentificador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCaracteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbreviatura = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtAbreviatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 10)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(656, 358)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.txtAbreviatura)
        Me.PanelControl2.Controls.Add(Me.txtNombre)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 11)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(629, 100)
        Me.PanelControl2.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(526, 53)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 33)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(526, 14)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(91, 33)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Location = New System.Drawing.Point(93, 37)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtAbreviatura.Size = New System.Drawing.Size(197, 22)
        Me.txtAbreviatura.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(93, 11)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNombre.Size = New System.Drawing.Size(333, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Abreviatura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridListado)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 122)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(629, 223)
        Me.PanelControl3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(18, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(300, 22)
        Me.txtBuscar.TabIndex = 12
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(11, 11)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsCaracteres})
        Me.gridListado.Size = New System.Drawing.Size(606, 200)
        Me.gridListado.TabIndex = 0
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdentificador, Me.colNombre, Me.colAbreviatura})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        '
        'colIdentificador
        '
        Me.colIdentificador.Caption = "IDENTIFICADOR"
        Me.colIdentificador.ColumnEdit = Me.rpsCaracteres
        Me.colIdentificador.FieldName = "IDENTIFICADOR"
        Me.colIdentificador.Name = "colIdentificador"
        '
        'rpsCaracteres
        '
        Me.rpsCaracteres.AutoHeight = False
        Me.rpsCaracteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracteres.Name = "rpsCaracteres"
        '
        'colNombre
        '
        Me.colNombre.Caption = "NOMBRE"
        Me.colNombre.ColumnEdit = Me.rpsCaracteres
        Me.colNombre.FieldName = "NOMBRE"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 422
        '
        'colAbreviatura
        '
        Me.colAbreviatura.Caption = "ABREVIATURA"
        Me.colAbreviatura.ColumnEdit = Me.rpsCaracteres
        Me.colAbreviatura.FieldName = "ABREVIATURA"
        Me.colAbreviatura.Name = "colAbreviatura"
        Me.colAbreviatura.Visible = True
        Me.colAbreviatura.VisibleIndex = 1
        Me.colAbreviatura.Width = 166
        '
        'FrmFndPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 379)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmFndPaises"
        Me.Text = "Definicion de paises"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtAbreviatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCaracteres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtAbreviatura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colIdentificador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaracteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbreviatura As DevExpress.XtraGrid.Columns.GridColumn
End Class
