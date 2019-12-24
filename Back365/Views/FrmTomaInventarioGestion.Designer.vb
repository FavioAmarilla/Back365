<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTomaInventarioGestion
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
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.txtApuntador = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTomaInventario = New DevExpress.XtraEditors.SimpleButton()
        Me.txtComentario = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtBuscar = New DevExpress.XtraEditors.TextEdit()
        Me.gridItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_IDNETIFICADOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.miles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_CODIGO_BARRAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.carecteres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_CANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.decimales = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_EXISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_DIFERENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fecha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ID_UNIDAD_MEDIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_COSTO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_PRECIO_UNITARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApuntador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.miles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carecteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decimales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 474)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnAceptar)
        Me.PanelControl2.Controls.Add(Me.txtFecha)
        Me.PanelControl2.Controls.Add(Me.txtNumero)
        Me.PanelControl2.Controls.Add(Me.txtApuntador)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.btnTomaInventario)
        Me.PanelControl2.Controls.Add(Me.txtComentario)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 13)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(797, 127)
        Me.PanelControl2.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(690, 64)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 32)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(690, 25)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 33)
        Me.btnAceptar.TabIndex = 40
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(404, 25)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(242, 21)
        Me.txtFecha.TabIndex = 4
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtNumero
        '
        Me.txtNumero.EditValue = ""
        Me.txtNumero.Location = New System.Drawing.Point(80, 24)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumero.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtNumero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Properties.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(212, 22)
        Me.txtNumero.TabIndex = 6
        '
        'txtApuntador
        '
        Me.txtApuntador.EditValue = ""
        Me.txtApuntador.Location = New System.Drawing.Point(404, 52)
        Me.txtApuntador.Name = "txtApuntador"
        Me.txtApuntador.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtApuntador.Properties.Appearance.Options.UseBackColor = True
        Me.txtApuntador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtApuntador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApuntador.Properties.ReadOnly = True
        Me.txtApuntador.Size = New System.Drawing.Size(242, 22)
        Me.txtApuntador.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(339, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Apuntador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Numero:"
        '
        'txtSucursal
        '
        Me.txtSucursal.EditValue = ""
        Me.txtSucursal.Location = New System.Drawing.Point(80, 52)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(242, 22)
        Me.txtSucursal.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Sucursal:"
        '
        'btnTomaInventario
        '
        Me.btnTomaInventario.Location = New System.Drawing.Point(296, 25)
        Me.btnTomaInventario.Name = "btnTomaInventario"
        Me.btnTomaInventario.Size = New System.Drawing.Size(26, 20)
        Me.btnTomaInventario.TabIndex = 30
        Me.btnTomaInventario.Text = "+"
        '
        'txtComentario
        '
        Me.txtComentario.EditValue = ""
        Me.txtComentario.Location = New System.Drawing.Point(80, 78)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtComentario.Properties.Appearance.Options.UseBackColor = True
        Me.txtComentario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtComentario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComentario.Properties.ReadOnly = True
        Me.txtComentario.Size = New System.Drawing.Size(242, 22)
        Me.txtComentario.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Comentario:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtBuscar)
        Me.PanelControl3.Controls.Add(Me.gridItems)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 153)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(797, 307)
        Me.PanelControl3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.EditValue = ""
        Me.txtBuscar.Location = New System.Drawing.Point(29, 24)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtBuscar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Size = New System.Drawing.Size(351, 22)
        Me.txtBuscar.TabIndex = 4
        '
        'gridItems
        '
        Me.gridItems.Location = New System.Drawing.Point(15, 12)
        Me.gridItems.MainView = Me.GridView1
        Me.gridItems.Name = "gridItems"
        Me.gridItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.carecteres, Me.miles, Me.decimales, Me.fecha})
        Me.gridItems.Size = New System.Drawing.Size(770, 283)
        Me.gridItems.TabIndex = 0
        Me.gridItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_IDNETIFICADOR, Me.COL_CODIGO_BARRAS, Me.COL_DESCRIPCION, Me.COL_CANTIDAD, Me.COL_EXISTENCIA, Me.COL_DIFERENCIA, Me.COL_ID_UNIDAD_MEDIDA, Me.COL_COSTO_UNITARIO, Me.COL_PRECIO_UNITARIO})
        Me.GridView1.GridControl = Me.gridItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowClearButton = False
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsFind.ShowFindButton = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_IDNETIFICADOR
        '
        Me.COL_IDNETIFICADOR.Caption = "IDENTIFICADOR"
        Me.COL_IDNETIFICADOR.ColumnEdit = Me.miles
        Me.COL_IDNETIFICADOR.FieldName = "IDENTIFICADOR"
        Me.COL_IDNETIFICADOR.Name = "COL_IDNETIFICADOR"
        '
        'miles
        '
        Me.miles.AutoHeight = False
        Me.miles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.miles.Mask.EditMask = "n0"
        Me.miles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.miles.Mask.UseMaskAsDisplayFormat = True
        Me.miles.Name = "miles"
        '
        'COL_CODIGO_BARRAS
        '
        Me.COL_CODIGO_BARRAS.Caption = "CODIGO BARRAS"
        Me.COL_CODIGO_BARRAS.ColumnEdit = Me.carecteres
        Me.COL_CODIGO_BARRAS.FieldName = "CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Name = "COL_CODIGO_BARRAS"
        Me.COL_CODIGO_BARRAS.Visible = True
        Me.COL_CODIGO_BARRAS.VisibleIndex = 0
        Me.COL_CODIGO_BARRAS.Width = 108
        '
        'carecteres
        '
        Me.carecteres.AutoHeight = False
        Me.carecteres.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.carecteres.Name = "carecteres"
        '
        'COL_DESCRIPCION
        '
        Me.COL_DESCRIPCION.Caption = "DESCRIPCION"
        Me.COL_DESCRIPCION.ColumnEdit = Me.carecteres
        Me.COL_DESCRIPCION.FieldName = "DESCRIPCION"
        Me.COL_DESCRIPCION.Name = "COL_DESCRIPCION"
        Me.COL_DESCRIPCION.Visible = True
        Me.COL_DESCRIPCION.VisibleIndex = 1
        Me.COL_DESCRIPCION.Width = 343
        '
        'COL_CANTIDAD
        '
        Me.COL_CANTIDAD.Caption = "CONTEO FISICO"
        Me.COL_CANTIDAD.ColumnEdit = Me.decimales
        Me.COL_CANTIDAD.FieldName = "CANTIDAD"
        Me.COL_CANTIDAD.Name = "COL_CANTIDAD"
        Me.COL_CANTIDAD.Visible = True
        Me.COL_CANTIDAD.VisibleIndex = 2
        Me.COL_CANTIDAD.Width = 100
        '
        'decimales
        '
        Me.decimales.AutoHeight = False
        Me.decimales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.decimales.Mask.EditMask = "n"
        Me.decimales.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.decimales.Mask.UseMaskAsDisplayFormat = True
        Me.decimales.Name = "decimales"
        '
        'COL_EXISTENCIA
        '
        Me.COL_EXISTENCIA.Caption = "EXISTENCIA"
        Me.COL_EXISTENCIA.ColumnEdit = Me.decimales
        Me.COL_EXISTENCIA.FieldName = "EXISTENCIA"
        Me.COL_EXISTENCIA.Name = "COL_EXISTENCIA"
        Me.COL_EXISTENCIA.Visible = True
        Me.COL_EXISTENCIA.VisibleIndex = 3
        Me.COL_EXISTENCIA.Width = 100
        '
        'COL_DIFERENCIA
        '
        Me.COL_DIFERENCIA.AppearanceCell.Options.UseTextOptions = True
        Me.COL_DIFERENCIA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_DIFERENCIA.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_DIFERENCIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_DIFERENCIA.Caption = "DIFERENCIA"
        Me.COL_DIFERENCIA.ColumnEdit = Me.decimales
        Me.COL_DIFERENCIA.FieldName = "DIFERENCIA"
        Me.COL_DIFERENCIA.Name = "COL_DIFERENCIA"
        Me.COL_DIFERENCIA.Visible = True
        Me.COL_DIFERENCIA.VisibleIndex = 4
        Me.COL_DIFERENCIA.Width = 100
        '
        'fecha
        '
        Me.fecha.AutoHeight = False
        Me.fecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.fecha.Mask.EditMask = "g"
        Me.fecha.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.fecha.Mask.UseMaskAsDisplayFormat = True
        Me.fecha.Name = "fecha"
        '
        'COL_ID_UNIDAD_MEDIDA
        '
        Me.COL_ID_UNIDAD_MEDIDA.Caption = "GridColumn1"
        Me.COL_ID_UNIDAD_MEDIDA.CustomizationCaption = "ID_UND_MEDIDA"
        Me.COL_ID_UNIDAD_MEDIDA.FieldName = "ID_UND_MEDIDA"
        Me.COL_ID_UNIDAD_MEDIDA.Name = "COL_ID_UNIDAD_MEDIDA"
        '
        'COL_COSTO_UNITARIO
        '
        Me.COL_COSTO_UNITARIO.Caption = "COSTO"
        Me.COL_COSTO_UNITARIO.FieldName = "COSTO_UNITARIO"
        Me.COL_COSTO_UNITARIO.Name = "COL_COSTO_UNITARIO"
        '
        'COL_PRECIO_UNITARIO
        '
        Me.COL_PRECIO_UNITARIO.Caption = "PRECIO_UNITARIO"
        Me.COL_PRECIO_UNITARIO.FieldName = "PRECIO_UNITARIO"
        Me.COL_PRECIO_UNITARIO.Name = "COL_PRECIO_UNITARIO"
        '
        'FrmTomaInventarioGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 498)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmTomaInventarioGestion"
        Me.Text = "Gestion de toma de inventario"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApuntador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.txtBuscar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.miles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carecteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decimales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApuntador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTomaInventario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtComentario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents gridItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_IDNETIFICADOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CODIGO_BARRAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_CANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBuscar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents COL_EXISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents carecteres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents miles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents decimales As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents fecha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_DIFERENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_UNIDAD_MEDIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_UNITARIO As DevExpress.XtraGrid.Columns.GridColumn
End Class
