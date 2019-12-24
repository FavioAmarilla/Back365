<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFndUsuarios
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
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_NOMBRE_COMPLETO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PERFIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ACTIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPerfiles = New DevExpress.XtraEditors.SimpleButton()
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtPerfil = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreCompleto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerfil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCompleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(699, 442)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridListado)
        Me.PanelControl3.Location = New System.Drawing.Point(13, 173)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(673, 256)
        Me.PanelControl3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(24, 30)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(353, 22)
        Me.txtBuscar.TabIndex = 13
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(11, 18)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemCheckEdit1})
        Me.gridListado.Size = New System.Drawing.Size(650, 221)
        Me.gridListado.TabIndex = 2
        Me.gridListado.TabStop = False
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_NOMBRE_COMPLETO, Me.COL_NOMBRE, Me.COL_PERFIL, Me.COL_ACTIVO})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
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
        Me.COL_IDENTIFICADOR.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'COL_NOMBRE_COMPLETO
        '
        Me.COL_NOMBRE_COMPLETO.Caption = "NOMBRE COMPLETO"
        Me.COL_NOMBRE_COMPLETO.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_NOMBRE_COMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.COL_NOMBRE_COMPLETO.Name = "COL_NOMBRE_COMPLETO"
        Me.COL_NOMBRE_COMPLETO.Visible = True
        Me.COL_NOMBRE_COMPLETO.VisibleIndex = 0
        '
        'COL_NOMBRE
        '
        Me.COL_NOMBRE.Caption = "NOMBRE"
        Me.COL_NOMBRE.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_NOMBRE.FieldName = "NOMBRE"
        Me.COL_NOMBRE.Name = "COL_NOMBRE"
        Me.COL_NOMBRE.Visible = True
        Me.COL_NOMBRE.VisibleIndex = 1
        '
        'COL_PERFIL
        '
        Me.COL_PERFIL.Caption = "PERFIL"
        Me.COL_PERFIL.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_PERFIL.FieldName = "PERFIL"
        Me.COL_PERFIL.Name = "COL_PERFIL"
        Me.COL_PERFIL.Visible = True
        Me.COL_PERFIL.VisibleIndex = 2
        '
        'COL_ACTIVO
        '
        Me.COL_ACTIVO.Caption = "ACTIVO"
        Me.COL_ACTIVO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.COL_ACTIVO.FieldName = "ACTIVO"
        Me.COL_ACTIVO.Name = "COL_ACTIVO"
        Me.COL_ACTIVO.Visible = True
        Me.COL_ACTIVO.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "S"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.btnPerfiles)
        Me.PanelControl2.Controls.Add(Me.chkActivo)
        Me.PanelControl2.Controls.Add(Me.txtClave)
        Me.PanelControl2.Controls.Add(Me.txtUsuario)
        Me.PanelControl2.Controls.Add(Me.txtPerfil)
        Me.PanelControl2.Controls.Add(Me.txtNombreCompleto)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(13, 13)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(673, 149)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(575, 50)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 29)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(575, 11)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 29)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnPerfiles
        '
        Me.btnPerfiles.Location = New System.Drawing.Point(321, 36)
        Me.btnPerfiles.Name = "btnPerfiles"
        Me.btnPerfiles.Size = New System.Drawing.Size(24, 22)
        Me.btnPerfiles.TabIndex = 12
        Me.btnPerfiles.Text = "..."
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(104, 120)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Caption = ""
        Me.chkActivo.Size = New System.Drawing.Size(18, 19)
        Me.chkActivo.TabIndex = 4
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(104, 92)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtClave.Size = New System.Drawing.Size(241, 22)
        Me.txtClave.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(104, 64)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUsuario.Size = New System.Drawing.Size(241, 22)
        Me.txtUsuario.TabIndex = 2
        '
        'txtPerfil
        '
        Me.txtPerfil.Location = New System.Drawing.Point(104, 37)
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPerfil.Properties.Appearance.Options.UseBackColor = True
        Me.txtPerfil.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtPerfil.Properties.ReadOnly = True
        Me.txtPerfil.Size = New System.Drawing.Size(213, 22)
        Me.txtPerfil.TabIndex = 1
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(104, 10)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNombreCompleto.Size = New System.Drawing.Size(349, 22)
        Me.txtNombreCompleto.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(64, 123)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Activo:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(31, 96)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Clave acceso:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(58, 68)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Usuario:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(70, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Perfil:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Nombre completo:"
        '
        'FrmFndUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 466)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmFndUsuarios"
        Me.Text = "Definicion de usuarios"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerfil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCompleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPerfil As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreCompleto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPerfiles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_NOMBRE_COMPLETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PERFIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ACTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
