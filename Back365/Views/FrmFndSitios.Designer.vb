<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFndSitios
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
        Me.colUnidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCiudad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCiudades = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPaises = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUnidadesOperat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodCtrlComprob = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCiudad = New DevExpress.XtraEditors.TextEdit()
        Me.txtPais = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtUnidadOperat = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtCodCtrlComprob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(852, 466)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridListado)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 207)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 245)
        Me.PanelControl3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(21, 23)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Size = New System.Drawing.Size(392, 22)
        Me.txtBuscar.TabIndex = 11
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(15, 16)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.Size = New System.Drawing.Size(794, 213)
        Me.gridListado.TabIndex = 0
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnidad, Me.colDescripcion, Me.colPais, Me.colCiudad, Me.colDireccion, Me.colCodigo})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        '
        'colUnidad
        '
        Me.colUnidad.Caption = "UNIDAD"
        Me.colUnidad.FieldName = "UNIDAD"
        Me.colUnidad.Name = "colUnidad"
        Me.colUnidad.Visible = True
        Me.colUnidad.VisibleIndex = 0
        Me.colUnidad.Width = 129
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "DESCRIPCION"
        Me.colDescripcion.FieldName = "DESCRIPCION"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 129
        '
        'colPais
        '
        Me.colPais.Caption = "PAIS"
        Me.colPais.FieldName = "PAIS"
        Me.colPais.Name = "colPais"
        Me.colPais.Visible = True
        Me.colPais.VisibleIndex = 2
        Me.colPais.Width = 129
        '
        'colCiudad
        '
        Me.colCiudad.Caption = "CIUDAD"
        Me.colCiudad.FieldName = "CIUDAD"
        Me.colCiudad.Name = "colCiudad"
        Me.colCiudad.Visible = True
        Me.colCiudad.VisibleIndex = 3
        Me.colCiudad.Width = 129
        '
        'colDireccion
        '
        Me.colDireccion.Caption = "DIRECCION"
        Me.colDireccion.FieldName = "DIRECCION"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 4
        Me.colDireccion.Width = 152
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "CODIGO COMPROB."
        Me.colCodigo.FieldName = "CODIGO_CTRL_COMP"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 5
        Me.colCodigo.Width = 108
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCiudades)
        Me.PanelControl2.Controls.Add(Me.btnPaises)
        Me.PanelControl2.Controls.Add(Me.btnUnidadesOperat)
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.txtCodCtrlComprob)
        Me.PanelControl2.Controls.Add(Me.txtDireccion)
        Me.PanelControl2.Controls.Add(Me.txtCiudad)
        Me.PanelControl2.Controls.Add(Me.txtPais)
        Me.PanelControl2.Controls.Add(Me.txtDescripcion)
        Me.PanelControl2.Controls.Add(Me.txtUnidadOperat)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 14)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 184)
        Me.PanelControl2.TabIndex = 0
        '
        'btnCiudades
        '
        Me.btnCiudades.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnCiudades.Location = New System.Drawing.Point(481, 95)
        Me.btnCiudades.Name = "btnCiudades"
        Me.btnCiudades.Size = New System.Drawing.Size(29, 22)
        Me.btnCiudades.TabIndex = 15
        Me.btnCiudades.Text = "..."
        '
        'btnPaises
        '
        Me.btnPaises.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnPaises.Location = New System.Drawing.Point(481, 69)
        Me.btnPaises.Name = "btnPaises"
        Me.btnPaises.Size = New System.Drawing.Size(29, 22)
        Me.btnPaises.TabIndex = 14
        Me.btnPaises.Text = "..."
        '
        'btnUnidadesOperat
        '
        Me.btnUnidadesOperat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnUnidadesOperat.Location = New System.Drawing.Point(481, 15)
        Me.btnUnidadesOperat.Name = "btnUnidadesOperat"
        Me.btnUnidadesOperat.Size = New System.Drawing.Size(29, 22)
        Me.btnUnidadesOperat.TabIndex = 13
        Me.btnUnidadesOperat.Text = "..."
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(707, 59)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 33)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(707, 20)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(91, 33)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtCodCtrlComprob
        '
        Me.txtCodCtrlComprob.Location = New System.Drawing.Point(118, 147)
        Me.txtCodCtrlComprob.Name = "txtCodCtrlComprob"
        Me.txtCodCtrlComprob.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodCtrlComprob.Size = New System.Drawing.Size(392, 22)
        Me.txtCodCtrlComprob.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(118, 121)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDireccion.Size = New System.Drawing.Size(392, 22)
        Me.txtDireccion.TabIndex = 4
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(118, 95)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCiudad.Properties.Appearance.Options.UseBackColor = True
        Me.txtCiudad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCiudad.Properties.ReadOnly = True
        Me.txtCiudad.Size = New System.Drawing.Size(359, 22)
        Me.txtCiudad.TabIndex = 3
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(118, 69)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPais.Properties.Appearance.Options.UseBackColor = True
        Me.txtPais.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtPais.Properties.ReadOnly = True
        Me.txtPais.Size = New System.Drawing.Size(359, 22)
        Me.txtPais.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 43)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDescripcion.Size = New System.Drawing.Size(392, 22)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtUnidadOperat
        '
        Me.txtUnidadOperat.Location = New System.Drawing.Point(118, 17)
        Me.txtUnidadOperat.Name = "txtUnidadOperat"
        Me.txtUnidadOperat.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnidadOperat.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnidadOperat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUnidadOperat.Properties.ReadOnly = True
        Me.txtUnidadOperat.Size = New System.Drawing.Size(359, 22)
        Me.txtUnidadOperat.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(22, 151)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Codigo comprob.:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(60, 125)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Direccion:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(70, 99)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Ciudad:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(84, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Pais:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Unidad Operat.:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(49, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Descripcion:"
        '
        'FrmFndSitios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 490)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmFndSitios"
        Me.Text = "Definicion de sucursales"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtCodCtrlComprob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCodCtrlComprob As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCiudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUnidadOperat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCiudades As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPaises As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUnidadesOperat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colUnidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiudad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
End Class
