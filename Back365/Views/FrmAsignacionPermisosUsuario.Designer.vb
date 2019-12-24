<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignacionPermisosUsuario
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
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.btnUsuario = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.gridMenues = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDENTIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsIdentificador = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsNombre = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_NUEVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMenues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsIdentificador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(690, 357)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnEliminar)
        Me.PanelControl2.Controls.Add(Me.btnAgregar)
        Me.PanelControl2.Controls.Add(Me.txtBuscar)
        Me.PanelControl2.Controls.Add(Me.btnUsuario)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.gridMenues)
        Me.PanelControl2.Controls.Add(Me.txtUsuario)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(13, 13)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(665, 329)
        Me.PanelControl2.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(566, 65)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(496, 65)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(64, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(39, 66)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(350, 22)
        Me.txtBuscar.TabIndex = 6
        '
        'btnUsuario
        '
        Me.btnUsuario.Location = New System.Drawing.Point(518, 17)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(28, 22)
        Me.btnUsuario.TabIndex = 1
        Me.btnUsuario.Text = "+"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(555, 287)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(459, 287)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 30)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'gridMenues
        '
        Me.gridMenues.Location = New System.Drawing.Point(25, 54)
        Me.gridMenues.MainView = Me.GridView1
        Me.gridMenues.Name = "gridMenues"
        Me.gridMenues.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsIdentificador, Me.rpsNombre, Me.RepositoryItemTextEdit1})
        Me.gridMenues.Size = New System.Drawing.Size(620, 225)
        Me.gridMenues.TabIndex = 1
        Me.gridMenues.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDENTIFICADOR, Me.COL_NOMBRE, Me.COL_NUEVO})
        Me.GridView1.GridControl = Me.gridMenues
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
        Me.COL_IDENTIFICADOR.ColumnEdit = Me.rpsIdentificador
        Me.COL_IDENTIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.Name = "COL_IDENTIFICADOR"
        Me.COL_IDENTIFICADOR.OptionsColumn.ReadOnly = True
        Me.COL_IDENTIFICADOR.Width = 167
        '
        'rpsIdentificador
        '
        Me.rpsIdentificador.AutoHeight = False
        Me.rpsIdentificador.Name = "rpsIdentificador"
        Me.rpsIdentificador.NullText = "0"
        '
        'COL_NOMBRE
        '
        Me.COL_NOMBRE.Caption = "NOMBRE"
        Me.COL_NOMBRE.ColumnEdit = Me.rpsNombre
        Me.COL_NOMBRE.FieldName = "NOMBRE"
        Me.COL_NOMBRE.Name = "COL_NOMBRE"
        Me.COL_NOMBRE.Visible = True
        Me.COL_NOMBRE.VisibleIndex = 0
        Me.COL_NOMBRE.Width = 476
        '
        'rpsNombre
        '
        Me.rpsNombre.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rpsNombre.AppearanceFocused.Options.UseBackColor = True
        Me.rpsNombre.AutoHeight = False
        Me.rpsNombre.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsNombre.Name = "rpsNombre"
        '
        'COL_NUEVO
        '
        Me.COL_NUEVO.Caption = "NUEVO"
        Me.COL_NUEVO.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.COL_NUEVO.FieldName = "NUEVO"
        Me.COL_NUEVO.Name = "COL_NUEVO"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.NullText = "S"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(71, 18)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.txtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUsuario.Properties.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(444, 22)
        Me.txtUsuario.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Usuario:"
        '
        'FrmAsignacionPermisosUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 381)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmAsignacionPermisosUsuario"
        Me.Text = "Asignacion de permisos a usuarios"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMenues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsIdentificador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridMenues As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_IDENTIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUsuario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rpsIdentificador As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsNombre As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_NUEVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
