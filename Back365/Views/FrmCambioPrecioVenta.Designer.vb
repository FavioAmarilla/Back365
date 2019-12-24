<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCambioPrecioVenta
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
        Me.rpsCaracter = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsMiles = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsDecimal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.gridListado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.COL_SUCURSAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsSucursal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_COSTO_REAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCostoReal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_COSTO_LISTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsCostoLista = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_DESCUENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PORC_REAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPorcReal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PORC_LISTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPorcLista = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ULT_CAMBIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsUltimoCambio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_PRECIO_ACTUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPrecioActual = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_NUEVO_PRECIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsPrecioNuevo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.COL_ID_SITIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_EMPRESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_ID_UNIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.COL_MARGEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpsMargen = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHistorial = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.btnSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtIdentificador = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoBalanza = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New DevExpress.XtraEditors.TextEdit()
        Me.btnProducto = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCostoReal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCostoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPorcReal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPorcLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsUltimoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPrecioActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPrecioNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsMargen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentificador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBalanza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpsCaracter
        '
        Me.rpsCaracter.AutoHeight = False
        Me.rpsCaracter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCaracter.Name = "rpsCaracter"
        '
        'rpsMiles
        '
        Me.rpsMiles.AutoHeight = False
        Me.rpsMiles.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsMiles.Mask.EditMask = "n0"
        Me.rpsMiles.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsMiles.Mask.UseMaskAsDisplayFormat = True
        Me.rpsMiles.Name = "rpsMiles"
        '
        'rpsDecimal
        '
        Me.rpsDecimal.AutoHeight = False
        Me.rpsDecimal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDecimal.Mask.EditMask = "n"
        Me.rpsDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDecimal.Name = "rpsDecimal"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(829, 462)
        Me.PanelControl1.TabIndex = 0
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.gridListado)
        Me.PanelControl4.Location = New System.Drawing.Point(11, 205)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(805, 243)
        Me.PanelControl4.TabIndex = 4
        '
        'gridListado
        '
        Me.gridListado.Location = New System.Drawing.Point(13, 16)
        Me.gridListado.MainView = Me.GridView1
        Me.gridListado.Name = "gridListado"
        Me.gridListado.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpsSucursal, Me.rpsCostoReal, Me.rpsCostoLista, Me.rpsDescuento, Me.rpsPorcReal, Me.rpsPorcLista, Me.rpsUltimoCambio, Me.rpsPrecioActual, Me.rpsPrecioNuevo, Me.rpsMargen})
        Me.gridListado.Size = New System.Drawing.Size(778, 212)
        Me.gridListado.TabIndex = 1
        Me.gridListado.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.COL_SUCURSAL, Me.COL_COSTO_REAL, Me.COL_COSTO_LISTA, Me.COL_DESCUENTO, Me.COL_PORC_REAL, Me.COL_PORC_LISTA, Me.COL_ULT_CAMBIO, Me.COL_PRECIO_ACTUAL, Me.COL_NUEVO_PRECIO, Me.COL_ID_SITIO, Me.COL_ID_EMPRESA, Me.COL_ID_UNIDAD, Me.COL_MARGEN})
        Me.GridView1.GridControl = Me.gridListado
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'COL_SUCURSAL
        '
        Me.COL_SUCURSAL.AppearanceCell.Options.UseTextOptions = True
        Me.COL_SUCURSAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_SUCURSAL.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_SUCURSAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.COL_SUCURSAL.Caption = "SUCURSAL"
        Me.COL_SUCURSAL.ColumnEdit = Me.rpsSucursal
        Me.COL_SUCURSAL.FieldName = "SUCURSAL"
        Me.COL_SUCURSAL.Name = "COL_SUCURSAL"
        Me.COL_SUCURSAL.Visible = True
        Me.COL_SUCURSAL.VisibleIndex = 0
        Me.COL_SUCURSAL.Width = 122
        '
        'rpsSucursal
        '
        Me.rpsSucursal.AutoHeight = False
        Me.rpsSucursal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsSucursal.Name = "rpsSucursal"
        Me.rpsSucursal.ReadOnly = True
        '
        'COL_COSTO_REAL
        '
        Me.COL_COSTO_REAL.AppearanceCell.Options.UseTextOptions = True
        Me.COL_COSTO_REAL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_REAL.AppearanceHeader.Options.UseTextOptions = True
        Me.COL_COSTO_REAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.COL_COSTO_REAL.Caption = "COSTO REAL"
        Me.COL_COSTO_REAL.ColumnEdit = Me.rpsCostoReal
        Me.COL_COSTO_REAL.FieldName = "COSTO_REAL"
        Me.COL_COSTO_REAL.Name = "COL_COSTO_REAL"
        Me.COL_COSTO_REAL.Visible = True
        Me.COL_COSTO_REAL.VisibleIndex = 3
        Me.COL_COSTO_REAL.Width = 74
        '
        'rpsCostoReal
        '
        Me.rpsCostoReal.AutoHeight = False
        Me.rpsCostoReal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCostoReal.Mask.EditMask = "n0"
        Me.rpsCostoReal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsCostoReal.Mask.UseMaskAsDisplayFormat = True
        Me.rpsCostoReal.Name = "rpsCostoReal"
        Me.rpsCostoReal.NullText = "0"
        Me.rpsCostoReal.ReadOnly = True
        '
        'COL_COSTO_LISTA
        '
        Me.COL_COSTO_LISTA.Caption = "COSTO LISTA"
        Me.COL_COSTO_LISTA.ColumnEdit = Me.rpsCostoLista
        Me.COL_COSTO_LISTA.FieldName = "COSTO_LISTA"
        Me.COL_COSTO_LISTA.Name = "COL_COSTO_LISTA"
        Me.COL_COSTO_LISTA.Visible = True
        Me.COL_COSTO_LISTA.VisibleIndex = 1
        Me.COL_COSTO_LISTA.Width = 71
        '
        'rpsCostoLista
        '
        Me.rpsCostoLista.AutoHeight = False
        Me.rpsCostoLista.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCostoLista.Mask.EditMask = "n0"
        Me.rpsCostoLista.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsCostoLista.Mask.UseMaskAsDisplayFormat = True
        Me.rpsCostoLista.Name = "rpsCostoLista"
        Me.rpsCostoLista.NullText = "0"
        Me.rpsCostoLista.ReadOnly = True
        '
        'COL_DESCUENTO
        '
        Me.COL_DESCUENTO.Caption = "DESCUENTO"
        Me.COL_DESCUENTO.ColumnEdit = Me.rpsDescuento
        Me.COL_DESCUENTO.FieldName = "PORC_DESCUENTO"
        Me.COL_DESCUENTO.Name = "COL_DESCUENTO"
        Me.COL_DESCUENTO.Visible = True
        Me.COL_DESCUENTO.VisibleIndex = 2
        Me.COL_DESCUENTO.Width = 71
        '
        'rpsDescuento
        '
        Me.rpsDescuento.AutoHeight = False
        Me.rpsDescuento.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDescuento.Mask.EditMask = "n"
        Me.rpsDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDescuento.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDescuento.Name = "rpsDescuento"
        Me.rpsDescuento.NullText = "0"
        Me.rpsDescuento.ReadOnly = True
        '
        'COL_PORC_REAL
        '
        Me.COL_PORC_REAL.Caption = "PORC REAL"
        Me.COL_PORC_REAL.ColumnEdit = Me.rpsPorcReal
        Me.COL_PORC_REAL.FieldName = "PORC_REAL"
        Me.COL_PORC_REAL.Name = "COL_PORC_REAL"
        Me.COL_PORC_REAL.Visible = True
        Me.COL_PORC_REAL.VisibleIndex = 4
        Me.COL_PORC_REAL.Width = 71
        '
        'rpsPorcReal
        '
        Me.rpsPorcReal.AutoHeight = False
        Me.rpsPorcReal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPorcReal.Mask.EditMask = "n"
        Me.rpsPorcReal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPorcReal.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPorcReal.Name = "rpsPorcReal"
        Me.rpsPorcReal.NullText = "0"
        Me.rpsPorcReal.ReadOnly = True
        '
        'COL_PORC_LISTA
        '
        Me.COL_PORC_LISTA.Caption = "PORC LISTA"
        Me.COL_PORC_LISTA.ColumnEdit = Me.rpsPorcLista
        Me.COL_PORC_LISTA.FieldName = "PORC_LISTA"
        Me.COL_PORC_LISTA.Name = "COL_PORC_LISTA"
        Me.COL_PORC_LISTA.Visible = True
        Me.COL_PORC_LISTA.VisibleIndex = 5
        Me.COL_PORC_LISTA.Width = 90
        '
        'rpsPorcLista
        '
        Me.rpsPorcLista.AutoHeight = False
        Me.rpsPorcLista.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPorcLista.Mask.EditMask = "n"
        Me.rpsPorcLista.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPorcLista.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPorcLista.Name = "rpsPorcLista"
        Me.rpsPorcLista.NullText = "0"
        Me.rpsPorcLista.ReadOnly = True
        '
        'COL_ULT_CAMBIO
        '
        Me.COL_ULT_CAMBIO.Caption = "ULT. CAMBIO"
        Me.COL_ULT_CAMBIO.ColumnEdit = Me.rpsUltimoCambio
        Me.COL_ULT_CAMBIO.FieldName = "ULTIMO_CAMBIO"
        Me.COL_ULT_CAMBIO.Name = "COL_ULT_CAMBIO"
        Me.COL_ULT_CAMBIO.Visible = True
        Me.COL_ULT_CAMBIO.VisibleIndex = 6
        Me.COL_ULT_CAMBIO.Width = 83
        '
        'rpsUltimoCambio
        '
        Me.rpsUltimoCambio.AutoHeight = False
        Me.rpsUltimoCambio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsUltimoCambio.Name = "rpsUltimoCambio"
        Me.rpsUltimoCambio.NullText = "0"
        Me.rpsUltimoCambio.ReadOnly = True
        '
        'COL_PRECIO_ACTUAL
        '
        Me.COL_PRECIO_ACTUAL.Caption = "PREC. ACTUAL"
        Me.COL_PRECIO_ACTUAL.ColumnEdit = Me.rpsPrecioActual
        Me.COL_PRECIO_ACTUAL.FieldName = "PRECIO_ACTUAL"
        Me.COL_PRECIO_ACTUAL.Name = "COL_PRECIO_ACTUAL"
        Me.COL_PRECIO_ACTUAL.Visible = True
        Me.COL_PRECIO_ACTUAL.VisibleIndex = 7
        Me.COL_PRECIO_ACTUAL.Width = 83
        '
        'rpsPrecioActual
        '
        Me.rpsPrecioActual.AutoHeight = False
        Me.rpsPrecioActual.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPrecioActual.Mask.EditMask = "n0"
        Me.rpsPrecioActual.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPrecioActual.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPrecioActual.Name = "rpsPrecioActual"
        Me.rpsPrecioActual.NullText = "0"
        Me.rpsPrecioActual.ReadOnly = True
        '
        'COL_NUEVO_PRECIO
        '
        Me.COL_NUEVO_PRECIO.Caption = "PREC. NUEVO"
        Me.COL_NUEVO_PRECIO.ColumnEdit = Me.rpsPrecioNuevo
        Me.COL_NUEVO_PRECIO.FieldName = "PRECIO_NUEVO"
        Me.COL_NUEVO_PRECIO.Name = "COL_NUEVO_PRECIO"
        Me.COL_NUEVO_PRECIO.Visible = True
        Me.COL_NUEVO_PRECIO.VisibleIndex = 9
        Me.COL_NUEVO_PRECIO.Width = 95
        '
        'rpsPrecioNuevo
        '
        Me.rpsPrecioNuevo.AutoHeight = False
        Me.rpsPrecioNuevo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPrecioNuevo.Mask.EditMask = "n0"
        Me.rpsPrecioNuevo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPrecioNuevo.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPrecioNuevo.Name = "rpsPrecioNuevo"
        Me.rpsPrecioNuevo.NullText = "0"
        '
        'COL_ID_SITIO
        '
        Me.COL_ID_SITIO.Caption = "ID SITIO"
        Me.COL_ID_SITIO.FieldName = "ID_SITIO"
        Me.COL_ID_SITIO.Name = "COL_ID_SITIO"
        '
        'COL_ID_EMPRESA
        '
        Me.COL_ID_EMPRESA.Caption = "ID EMPRESA"
        Me.COL_ID_EMPRESA.FieldName = "ID_EMPRESA"
        Me.COL_ID_EMPRESA.Name = "COL_ID_EMPRESA"
        '
        'COL_ID_UNIDAD
        '
        Me.COL_ID_UNIDAD.Caption = "ID UNIDAD"
        Me.COL_ID_UNIDAD.FieldName = "ID_UNIDAD"
        Me.COL_ID_UNIDAD.Name = "COL_ID_UNIDAD"
        '
        'COL_MARGEN
        '
        Me.COL_MARGEN.Caption = "MARGEN"
        Me.COL_MARGEN.ColumnEdit = Me.rpsMargen
        Me.COL_MARGEN.FieldName = "MARGEN"
        Me.COL_MARGEN.Name = "COL_MARGEN"
        Me.COL_MARGEN.Visible = True
        Me.COL_MARGEN.VisibleIndex = 8
        '
        'rpsMargen
        '
        Me.rpsMargen.AutoHeight = False
        Me.rpsMargen.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsMargen.Mask.EditMask = "n"
        Me.rpsMargen.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsMargen.Mask.UseMaskAsDisplayFormat = True
        Me.rpsMargen.Name = "rpsMargen"
        Me.rpsMargen.NullText = "0"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnCancelar)
        Me.PanelControl3.Controls.Add(Me.btnAceptar)
        Me.PanelControl3.Controls.Add(Me.btnHistorial)
        Me.PanelControl3.Location = New System.Drawing.Point(639, 12)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(177, 183)
        Me.PanelControl3.TabIndex = 3
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(43, 52)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 31)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(43, 15)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 31)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.TabStop = False
        Me.btnAceptar.Text = " Aceptar"
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(43, 89)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(90, 33)
        Me.btnHistorial.TabIndex = 2
        Me.btnHistorial.Text = "Historial"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label10)
        Me.PanelControl2.Controls.Add(Me.txtProveedor)
        Me.PanelControl2.Controls.Add(Me.txtSucursal)
        Me.PanelControl2.Controls.Add(Me.btnSucursal)
        Me.PanelControl2.Controls.Add(Me.Label11)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.chkActivo)
        Me.PanelControl2.Controls.Add(Me.txtIdentificador)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.txtCodigoBalanza)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.txtCodigoBarras)
        Me.PanelControl2.Controls.Add(Me.btnProducto)
        Me.PanelControl2.Controls.Add(Me.txtDescripcion)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(611, 183)
        Me.PanelControl2.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(106, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Proveedor:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(174, 100)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProveedor.Properties.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(350, 22)
        Me.txtProveedor.TabIndex = 13
        Me.txtProveedor.TabStop = False
        '
        'txtSucursal
        '
        Me.txtSucursal.EditValue = " "
        Me.txtSucursal.Location = New System.Drawing.Point(174, 16)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Size = New System.Drawing.Size(322, 22)
        Me.txtSucursal.TabIndex = 0
        Me.txtSucursal.TabStop = False
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(498, 16)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(26, 22)
        Me.btnSucursal.TabIndex = 6
        Me.btnSucursal.TabStop = False
        Me.btnSucursal.Text = "+"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(117, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Sucursal:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Activo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(174, 155)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Caption = ""
        Me.chkActivo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkActivo.Size = New System.Drawing.Size(17, 19)
        Me.chkActivo.TabIndex = 5
        Me.chkActivo.TabStop = False
        '
        'txtIdentificador
        '
        Me.txtIdentificador.Location = New System.Drawing.Point(364, 128)
        Me.txtIdentificador.Name = "txtIdentificador"
        Me.txtIdentificador.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIdentificador.Properties.Appearance.Options.UseBackColor = True
        Me.txtIdentificador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtIdentificador.Properties.ReadOnly = True
        Me.txtIdentificador.Size = New System.Drawing.Size(160, 22)
        Me.txtIdentificador.TabIndex = 4
        Me.txtIdentificador.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descripcion:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigoBalanza
        '
        Me.txtCodigoBalanza.Location = New System.Drawing.Point(174, 128)
        Me.txtCodigoBalanza.Name = "txtCodigoBalanza"
        Me.txtCodigoBalanza.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCodigoBalanza.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoBalanza.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodigoBalanza.Properties.ReadOnly = True
        Me.txtCodigoBalanza.Size = New System.Drawing.Size(160, 22)
        Me.txtCodigoBalanza.TabIndex = 3
        Me.txtCodigoBalanza.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Codigo balanza:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(174, 44)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodigoBarras.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodigoBarras.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtCodigoBarras.Size = New System.Drawing.Size(322, 22)
        Me.txtCodigoBarras.TabIndex = 1
        Me.txtCodigoBarras.TabStop = False
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(498, 44)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(26, 22)
        Me.btnProducto.TabIndex = 7
        Me.btnProducto.TabStop = False
        Me.btnProducto.Text = "+"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(174, 72)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDescripcion.Properties.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(350, 22)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Producto:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCambioPrecioVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 485)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmCambioPrecioVenta"
        Me.Text = "Cambio de precio de venta"
        CType(Me.rpsCaracter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsMiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.gridListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCostoReal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCostoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPorcReal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPorcLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsUltimoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPrecioActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPrecioNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsMargen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentificador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBalanza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtIdentificador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoBalanza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnProducto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHistorial As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gridListado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COL_SUCURSAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_COSTO_LISTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_DESCUENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PORC_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PORC_LISTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ULT_CAMBIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_PRECIO_ACTUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_NUEVO_PRECIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCaracter As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsMiles As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDecimal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsSucursal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCostoReal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCostoLista As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPorcReal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPorcLista As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsUltimoCambio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPrecioActual As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPrecioNuevo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents COL_ID_SITIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_EMPRESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_ID_UNIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents COL_MARGEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsMargen As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
