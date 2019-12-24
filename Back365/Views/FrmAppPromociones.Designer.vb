<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAppPromociones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAppPromociones))
        Me.rpsTxtCodigoBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsTxtProducto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsTxtPrecioActual = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsTxtCostoUnitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsTxtPrecioPromo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsTxtDiferenciaPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsTxtPorcDiferencia = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.chkEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemTextEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsCodigoBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsProducto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsPrecioActual = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsCostoUnitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsPrecioPromo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsDiferenciaPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rpsPorcDierencia = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.cldFechaDesde = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.cldFechaHasta = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.btnActivarPromo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAddProductos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.gridItemsPromocion = New DevExpress.XtraGrid.GridControl()
        Me.GridViewItemsPromocion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodBarras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpCodBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpProducto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecioActual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpPrecioActual = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_margen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpMargen = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCostoUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpCostoUnitario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecioPromo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpPrecioPromo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDiferenciaPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpDiferencia = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPorcDiferencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpPorcDiferencia = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colIdUnidadMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNuevo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rpEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboTipoPromo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUnidadOperat = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarUnidadOperat = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarEmpresa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaHasta = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.btnFechaDesde = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscarProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImprimirOfertas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImpPromociones = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimirLiquidacion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelarLiquidacion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConfirmarPromo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDesactivarPromo = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.gridItemsLiquidacion = New DevExpress.XtraGrid.GridControl()
        Me.GridViewItemsLiquidacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colReconocer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdItemPromocion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_imprimir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkImprimir = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gridLiquidaciones = New DevExpress.XtraGrid.GridControl()
        Me.GridViewLiquidaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDesde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colHasta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPagado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colConfirmado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colIdPromocion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsitio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCerrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreUnidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreSucursal = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.rpsTxtCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtPrecioActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtCostoUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtPrecioPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtDiferenciaPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsTxtPorcDiferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPrecioActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsCostoUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPrecioPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsDiferenciaPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpsPorcDierencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gridItemsPromocion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewItemsPromocion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCodBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPrecioActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpMargen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpCostoUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPrecioPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpDiferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpPorcDiferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboTipoPromo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.gridItemsLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewItemsLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpsTxtCodigoBarras
        '
        Me.rpsTxtCodigoBarras.AutoHeight = False
        Me.rpsTxtCodigoBarras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtCodigoBarras.Name = "rpsTxtCodigoBarras"
        '
        'rpsTxtProducto
        '
        Me.rpsTxtProducto.AutoHeight = False
        Me.rpsTxtProducto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtProducto.Name = "rpsTxtProducto"
        Me.rpsTxtProducto.ReadOnly = True
        '
        'rpsTxtPrecioActual
        '
        Me.rpsTxtPrecioActual.AllowMouseWheel = False
        Me.rpsTxtPrecioActual.AutoHeight = False
        Me.rpsTxtPrecioActual.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtPrecioActual.DisplayFormat.FormatString = "#,#"
        Me.rpsTxtPrecioActual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsTxtPrecioActual.Mask.EditMask = "n0"
        Me.rpsTxtPrecioActual.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTxtPrecioActual.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTxtPrecioActual.Name = "rpsTxtPrecioActual"
        '
        'rpsTxtCostoUnitario
        '
        Me.rpsTxtCostoUnitario.AllowMouseWheel = False
        Me.rpsTxtCostoUnitario.AutoHeight = False
        Me.rpsTxtCostoUnitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtCostoUnitario.DisplayFormat.FormatString = "#,#"
        Me.rpsTxtCostoUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsTxtCostoUnitario.Mask.EditMask = "n0"
        Me.rpsTxtCostoUnitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTxtCostoUnitario.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTxtCostoUnitario.Name = "rpsTxtCostoUnitario"
        Me.rpsTxtCostoUnitario.ReadOnly = True
        '
        'rpsTxtPrecioPromo
        '
        Me.rpsTxtPrecioPromo.AllowMouseWheel = False
        Me.rpsTxtPrecioPromo.AutoHeight = False
        Me.rpsTxtPrecioPromo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtPrecioPromo.DisplayFormat.FormatString = "#,#"
        Me.rpsTxtPrecioPromo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsTxtPrecioPromo.Mask.EditMask = "n0"
        Me.rpsTxtPrecioPromo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTxtPrecioPromo.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTxtPrecioPromo.Name = "rpsTxtPrecioPromo"
        '
        'rpsTxtDiferenciaPrecio
        '
        Me.rpsTxtDiferenciaPrecio.AllowMouseWheel = False
        Me.rpsTxtDiferenciaPrecio.AutoHeight = False
        Me.rpsTxtDiferenciaPrecio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtDiferenciaPrecio.DisplayFormat.FormatString = "#,#"
        Me.rpsTxtDiferenciaPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsTxtDiferenciaPrecio.Mask.EditMask = "n0"
        Me.rpsTxtDiferenciaPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTxtDiferenciaPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTxtDiferenciaPrecio.Name = "rpsTxtDiferenciaPrecio"
        Me.rpsTxtDiferenciaPrecio.ReadOnly = True
        '
        'rpsTxtPorcDiferencia
        '
        Me.rpsTxtPorcDiferencia.AllowMouseWheel = False
        Me.rpsTxtPorcDiferencia.AutoHeight = False
        Me.rpsTxtPorcDiferencia.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsTxtPorcDiferencia.DisplayFormat.FormatString = "0.00"
        Me.rpsTxtPorcDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsTxtPorcDiferencia.Mask.EditMask = "n2"
        Me.rpsTxtPorcDiferencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsTxtPorcDiferencia.Mask.UseMaskAsDisplayFormat = True
        Me.rpsTxtPorcDiferencia.Name = "rpsTxtPorcDiferencia"
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoHeight = False
        Me.chkEliminar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.ValueChecked = "S"
        Me.chkEliminar.ValueUnchecked = "N"
        '
        'RepositoryItemTextEdit12
        '
        Me.RepositoryItemTextEdit12.AutoHeight = False
        Me.RepositoryItemTextEdit12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit12.Name = "RepositoryItemTextEdit12"
        '
        'RepositoryItemTextEdit13
        '
        Me.RepositoryItemTextEdit13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemTextEdit13.Appearance.Options.UseFont = True
        Me.RepositoryItemTextEdit13.AutoHeight = False
        Me.RepositoryItemTextEdit13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit13.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit13.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit13.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit13.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit13.Name = "RepositoryItemTextEdit13"
        '
        'RepositoryItemTextEdit14
        '
        Me.RepositoryItemTextEdit14.AutoHeight = False
        Me.RepositoryItemTextEdit14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit14.DisplayFormat.FormatString = "{0:0.00} %"
        Me.RepositoryItemTextEdit14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit14.Name = "RepositoryItemTextEdit14"
        Me.RepositoryItemTextEdit14.NullText = "0"
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemTextEdit8.Appearance.Options.UseFont = True
        Me.RepositoryItemTextEdit8.AutoHeight = False
        Me.RepositoryItemTextEdit8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit8.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit8.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit8.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'rpsCodigoBarras
        '
        Me.rpsCodigoBarras.AutoHeight = False
        Me.rpsCodigoBarras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCodigoBarras.Name = "rpsCodigoBarras"
        '
        'rpsProducto
        '
        Me.rpsProducto.AutoHeight = False
        Me.rpsProducto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsProducto.Name = "rpsProducto"
        '
        'rpsPrecioActual
        '
        Me.rpsPrecioActual.AutoHeight = False
        Me.rpsPrecioActual.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPrecioActual.DisplayFormat.FormatString = "#,#"
        Me.rpsPrecioActual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsPrecioActual.Mask.EditMask = "n0"
        Me.rpsPrecioActual.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPrecioActual.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPrecioActual.Name = "rpsPrecioActual"
        Me.rpsPrecioActual.NullText = "0"
        '
        'rpsCostoUnitario
        '
        Me.rpsCostoUnitario.AutoHeight = False
        Me.rpsCostoUnitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsCostoUnitario.DisplayFormat.FormatString = "#,#"
        Me.rpsCostoUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsCostoUnitario.Mask.EditMask = "n0"
        Me.rpsCostoUnitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsCostoUnitario.Mask.UseMaskAsDisplayFormat = True
        Me.rpsCostoUnitario.Name = "rpsCostoUnitario"
        Me.rpsCostoUnitario.NullText = "0"
        '
        'rpsPrecioPromo
        '
        Me.rpsPrecioPromo.AutoHeight = False
        Me.rpsPrecioPromo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPrecioPromo.DisplayFormat.FormatString = "#,#"
        Me.rpsPrecioPromo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsPrecioPromo.Mask.EditMask = "n0"
        Me.rpsPrecioPromo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPrecioPromo.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPrecioPromo.Name = "rpsPrecioPromo"
        Me.rpsPrecioPromo.NullText = "0"
        '
        'rpsDiferenciaPrecio
        '
        Me.rpsDiferenciaPrecio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rpsDiferenciaPrecio.Appearance.Options.UseFont = True
        Me.rpsDiferenciaPrecio.AutoHeight = False
        Me.rpsDiferenciaPrecio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsDiferenciaPrecio.DisplayFormat.FormatString = "#,#"
        Me.rpsDiferenciaPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsDiferenciaPrecio.Mask.EditMask = "n0"
        Me.rpsDiferenciaPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsDiferenciaPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.rpsDiferenciaPrecio.Name = "rpsDiferenciaPrecio"
        Me.rpsDiferenciaPrecio.NullText = "0"
        '
        'rpsPorcDierencia
        '
        Me.rpsPorcDierencia.AutoHeight = False
        Me.rpsPorcDierencia.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpsPorcDierencia.DisplayFormat.FormatString = "{0:#.##} %"
        Me.rpsPorcDierencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpsPorcDierencia.Mask.EditMask = "P"
        Me.rpsPorcDierencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpsPorcDierencia.Mask.UseMaskAsDisplayFormat = True
        Me.rpsPorcDierencia.Name = "rpsPorcDierencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(378, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha desde:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha hasta:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EditValue = ""
        Me.txtDescripcion.Location = New System.Drawing.Point(453, 11)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Size = New System.Drawing.Size(261, 22)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtProveedor
        '
        Me.txtProveedor.EditValue = ""
        Me.txtProveedor.Location = New System.Drawing.Point(453, 37)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProveedor.Properties.Appearance.Options.UseBackColor = True
        Me.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtProveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.Properties.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(231, 22)
        Me.txtProveedor.TabIndex = 5
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Location = New System.Drawing.Point(12, 12)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1133, 579)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1133, 579)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Promociones"
        Me.TabNavigationPage1.Controls.Add(Me.cldFechaDesde)
        Me.TabNavigationPage1.Controls.Add(Me.cldFechaHasta)
        Me.TabNavigationPage1.Controls.Add(Me.PanelControl3)
        Me.TabNavigationPage1.Controls.Add(Me.PanelControl2)
        Me.TabNavigationPage1.Controls.Add(Me.PanelControl1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1115, 534)
        '
        'cldFechaDesde
        '
        Me.cldFechaDesde.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaDesde.Location = New System.Drawing.Point(691, 66)
        Me.cldFechaDesde.Name = "cldFechaDesde"
        Me.cldFechaDesde.Size = New System.Drawing.Size(253, 227)
        Me.cldFechaDesde.TabIndex = 23
        '
        'cldFechaHasta
        '
        Me.cldFechaHasta.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cldFechaHasta.Location = New System.Drawing.Point(691, 95)
        Me.cldFechaHasta.Name = "cldFechaHasta"
        Me.cldFechaHasta.Size = New System.Drawing.Size(253, 227)
        Me.cldFechaHasta.TabIndex = 22
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnActivarPromo)
        Me.PanelControl3.Controls.Add(Me.btnBuscar)
        Me.PanelControl3.Controls.Add(Me.btnAceptar)
        Me.PanelControl3.Controls.Add(Me.btnImprimir)
        Me.PanelControl3.Controls.Add(Me.btnCancelar)
        Me.PanelControl3.Location = New System.Drawing.Point(915, 3)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(136, 528)
        Me.PanelControl3.TabIndex = 2
        '
        'btnActivarPromo
        '
        Me.btnActivarPromo.Location = New System.Drawing.Point(19, 50)
        Me.btnActivarPromo.Name = "btnActivarPromo"
        Me.btnActivarPromo.Size = New System.Drawing.Size(99, 30)
        Me.btnActivarPromo.TabIndex = 4
        Me.btnActivarPromo.Text = "Abrir Promo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(19, 161)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 30)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(19, 14)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(19, 125)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(99, 30)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(19, 89)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnAddProductos)
        Me.PanelControl2.Controls.Add(Me.btnAgregar)
        Me.PanelControl2.Controls.Add(Me.gridItemsPromocion)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 139)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(905, 392)
        Me.PanelControl2.TabIndex = 1
        '
        'btnAddProductos
        '
        Me.btnAddProductos.Location = New System.Drawing.Point(695, 33)
        Me.btnAddProductos.Name = "btnAddProductos"
        Me.btnAddProductos.Size = New System.Drawing.Size(94, 24)
        Me.btnAddProductos.TabIndex = 6
        Me.btnAddProductos.Text = "Cargar Productos"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(795, 33)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(85, 24)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar fila"
        '
        'gridItemsPromocion
        '
        Me.gridItemsPromocion.Location = New System.Drawing.Point(12, 18)
        Me.gridItemsPromocion.MainView = Me.GridViewItemsPromocion
        Me.gridItemsPromocion.Name = "gridItemsPromocion"
        Me.gridItemsPromocion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpCodBarras, Me.rpProducto, Me.rpPrecioActual, Me.rpMargen, Me.rpCostoUnitario, Me.rpPrecioPromo, Me.rpDiferencia, Me.rpPorcDiferencia, Me.rpEliminar})
        Me.gridItemsPromocion.Size = New System.Drawing.Size(878, 360)
        Me.gridItemsPromocion.TabIndex = 0
        Me.gridItemsPromocion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewItemsPromocion})
        '
        'GridViewItemsPromocion
        '
        Me.GridViewItemsPromocion.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewItemsPromocion.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewItemsPromocion.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridViewItemsPromocion.Appearance.FocusedCell.Options.UseFont = True
        Me.GridViewItemsPromocion.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewItemsPromocion.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewItemsPromocion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewItemsPromocion.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewItemsPromocion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdProducto, Me.colCodBarras, Me.colProducto, Me.colPrecioActual, Me.col_margen, Me.colCostoUnitario, Me.colPrecioPromo, Me.colDiferenciaPrecio, Me.colPorcDiferencia, Me.colIdUnidadMedida, Me.colIdItem, Me.colNuevo, Me.colEliminar})
        Me.GridViewItemsPromocion.GridControl = Me.gridItemsPromocion
        Me.GridViewItemsPromocion.Name = "GridViewItemsPromocion"
        Me.GridViewItemsPromocion.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridViewItemsPromocion.OptionsFind.AlwaysVisible = True
        Me.GridViewItemsPromocion.OptionsView.ShowGroupPanel = False
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "ID Producto"
        Me.colIdProducto.FieldName = "ID_PRODUCTO"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.OptionsColumn.ReadOnly = True
        '
        'colCodBarras
        '
        Me.colCodBarras.Caption = "Codigo Barras"
        Me.colCodBarras.ColumnEdit = Me.rpCodBarras
        Me.colCodBarras.FieldName = "CODIGO_BARRAS"
        Me.colCodBarras.Name = "colCodBarras"
        Me.colCodBarras.Visible = True
        Me.colCodBarras.VisibleIndex = 0
        Me.colCodBarras.Width = 107
        '
        'rpCodBarras
        '
        Me.rpCodBarras.AutoHeight = False
        Me.rpCodBarras.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpCodBarras.Name = "rpCodBarras"
        Me.rpCodBarras.NullText = "0"
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.ColumnEdit = Me.rpProducto
        Me.colProducto.FieldName = "PRODUCTO"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.OptionsColumn.ReadOnly = True
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        Me.colProducto.Width = 221
        '
        'rpProducto
        '
        Me.rpProducto.AutoHeight = False
        Me.rpProducto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpProducto.Name = "rpProducto"
        Me.rpProducto.NullText = "0"
        '
        'colPrecioActual
        '
        Me.colPrecioActual.AppearanceCell.Options.UseTextOptions = True
        Me.colPrecioActual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioActual.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioActual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioActual.Caption = "Precio Actual"
        Me.colPrecioActual.ColumnEdit = Me.rpPrecioActual
        Me.colPrecioActual.FieldName = "PRECIO_ACTUAL"
        Me.colPrecioActual.Name = "colPrecioActual"
        Me.colPrecioActual.Visible = True
        Me.colPrecioActual.VisibleIndex = 2
        Me.colPrecioActual.Width = 79
        '
        'rpPrecioActual
        '
        Me.rpPrecioActual.AutoHeight = False
        Me.rpPrecioActual.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpPrecioActual.DisplayFormat.FormatString = "#,#"
        Me.rpPrecioActual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpPrecioActual.Mask.EditMask = "n0"
        Me.rpPrecioActual.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpPrecioActual.Mask.UseMaskAsDisplayFormat = True
        Me.rpPrecioActual.Name = "rpPrecioActual"
        Me.rpPrecioActual.NullText = "0"
        '
        'col_margen
        '
        Me.col_margen.AppearanceCell.Options.UseTextOptions = True
        Me.col_margen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_margen.AppearanceHeader.Options.UseTextOptions = True
        Me.col_margen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_margen.Caption = "Margen (%)"
        Me.col_margen.ColumnEdit = Me.rpMargen
        Me.col_margen.DisplayFormat.FormatString = "{0:0.00} %"
        Me.col_margen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_margen.FieldName = "MARGEN"
        Me.col_margen.Name = "col_margen"
        Me.col_margen.Visible = True
        Me.col_margen.VisibleIndex = 4
        Me.col_margen.Width = 74
        '
        'rpMargen
        '
        Me.rpMargen.AutoHeight = False
        Me.rpMargen.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpMargen.DisplayFormat.FormatString = "#.##"
        Me.rpMargen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpMargen.Mask.EditMask = "n"
        Me.rpMargen.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpMargen.Mask.UseMaskAsDisplayFormat = True
        Me.rpMargen.Name = "rpMargen"
        Me.rpMargen.NullText = "0"
        '
        'colCostoUnitario
        '
        Me.colCostoUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colCostoUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCostoUnitario.AppearanceHeader.Options.UseTextOptions = True
        Me.colCostoUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCostoUnitario.Caption = "Costo Unitario"
        Me.colCostoUnitario.ColumnEdit = Me.rpCostoUnitario
        Me.colCostoUnitario.FieldName = "COSTO_UNITARIO"
        Me.colCostoUnitario.Name = "colCostoUnitario"
        Me.colCostoUnitario.OptionsColumn.ReadOnly = True
        Me.colCostoUnitario.Visible = True
        Me.colCostoUnitario.VisibleIndex = 3
        Me.colCostoUnitario.Width = 78
        '
        'rpCostoUnitario
        '
        Me.rpCostoUnitario.AutoHeight = False
        Me.rpCostoUnitario.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpCostoUnitario.DisplayFormat.FormatString = "#,#"
        Me.rpCostoUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpCostoUnitario.Mask.EditMask = "n0"
        Me.rpCostoUnitario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpCostoUnitario.Mask.UseMaskAsDisplayFormat = True
        Me.rpCostoUnitario.Name = "rpCostoUnitario"
        Me.rpCostoUnitario.NullText = "0"
        '
        'colPrecioPromo
        '
        Me.colPrecioPromo.AppearanceCell.Options.UseTextOptions = True
        Me.colPrecioPromo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioPromo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioPromo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioPromo.Caption = "Precio Promocional"
        Me.colPrecioPromo.ColumnEdit = Me.rpPrecioPromo
        Me.colPrecioPromo.FieldName = "PRECIO_PROMO"
        Me.colPrecioPromo.Name = "colPrecioPromo"
        Me.colPrecioPromo.Visible = True
        Me.colPrecioPromo.VisibleIndex = 5
        Me.colPrecioPromo.Width = 74
        '
        'rpPrecioPromo
        '
        Me.rpPrecioPromo.AutoHeight = False
        Me.rpPrecioPromo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpPrecioPromo.DisplayFormat.FormatString = "#,#"
        Me.rpPrecioPromo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpPrecioPromo.Mask.EditMask = "n0"
        Me.rpPrecioPromo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpPrecioPromo.Mask.UseMaskAsDisplayFormat = True
        Me.rpPrecioPromo.Name = "rpPrecioPromo"
        Me.rpPrecioPromo.NullText = "0"
        '
        'colDiferenciaPrecio
        '
        Me.colDiferenciaPrecio.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferenciaPrecio.AppearanceCell.Options.UseFont = True
        Me.colDiferenciaPrecio.AppearanceCell.Options.UseTextOptions = True
        Me.colDiferenciaPrecio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiferenciaPrecio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferenciaPrecio.AppearanceHeader.Options.UseFont = True
        Me.colDiferenciaPrecio.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiferenciaPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiferenciaPrecio.Caption = "Diferencia (Gs)"
        Me.colDiferenciaPrecio.ColumnEdit = Me.rpDiferencia
        Me.colDiferenciaPrecio.FieldName = "DIFERENCIA_PRECIO"
        Me.colDiferenciaPrecio.Name = "colDiferenciaPrecio"
        Me.colDiferenciaPrecio.OptionsColumn.ReadOnly = True
        Me.colDiferenciaPrecio.Visible = True
        Me.colDiferenciaPrecio.VisibleIndex = 6
        Me.colDiferenciaPrecio.Width = 83
        '
        'rpDiferencia
        '
        Me.rpDiferencia.AutoHeight = False
        Me.rpDiferencia.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpDiferencia.DisplayFormat.FormatString = "#,#"
        Me.rpDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpDiferencia.Mask.EditMask = "n0"
        Me.rpDiferencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpDiferencia.Mask.UseMaskAsDisplayFormat = True
        Me.rpDiferencia.Name = "rpDiferencia"
        Me.rpDiferencia.NullText = "0"
        '
        'colPorcDiferencia
        '
        Me.colPorcDiferencia.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcDiferencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcDiferencia.AppearanceHeader.Options.UseTextOptions = True
        Me.colPorcDiferencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcDiferencia.Caption = "Diferencia (%)"
        Me.colPorcDiferencia.ColumnEdit = Me.rpPorcDiferencia
        Me.colPorcDiferencia.DisplayFormat.FormatString = "{0:0.00} %"
        Me.colPorcDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPorcDiferencia.FieldName = "PORC_DIFERENCIA"
        Me.colPorcDiferencia.Name = "colPorcDiferencia"
        Me.colPorcDiferencia.Visible = True
        Me.colPorcDiferencia.VisibleIndex = 7
        Me.colPorcDiferencia.Width = 83
        '
        'rpPorcDiferencia
        '
        Me.rpPorcDiferencia.AutoHeight = False
        Me.rpPorcDiferencia.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpPorcDiferencia.DisplayFormat.FormatString = "#.##"
        Me.rpPorcDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rpPorcDiferencia.Mask.EditMask = "n"
        Me.rpPorcDiferencia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rpPorcDiferencia.Mask.UseMaskAsDisplayFormat = True
        Me.rpPorcDiferencia.Name = "rpPorcDiferencia"
        Me.rpPorcDiferencia.NullText = "0"
        '
        'colIdUnidadMedida
        '
        Me.colIdUnidadMedida.Caption = "Id Unidad Medida"
        Me.colIdUnidadMedida.FieldName = "ID_UNIDAD_MEDIDA"
        Me.colIdUnidadMedida.Name = "colIdUnidadMedida"
        Me.colIdUnidadMedida.OptionsColumn.ReadOnly = True
        '
        'colIdItem
        '
        Me.colIdItem.Caption = "Id Item"
        Me.colIdItem.FieldName = "ID_ITEM"
        Me.colIdItem.Name = "colIdItem"
        '
        'colNuevo
        '
        Me.colNuevo.AppearanceCell.Options.UseTextOptions = True
        Me.colNuevo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNuevo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNuevo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNuevo.Caption = "Nuevo"
        Me.colNuevo.FieldName = "NUEVO"
        Me.colNuevo.Name = "colNuevo"
        '
        'colEliminar
        '
        Me.colEliminar.AppearanceCell.Options.UseTextOptions = True
        Me.colEliminar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEliminar.AppearanceHeader.Options.UseTextOptions = True
        Me.colEliminar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEliminar.Caption = "Eliminar"
        Me.colEliminar.ColumnEdit = Me.rpEliminar
        Me.colEliminar.FieldName = "ELIMINAR"
        Me.colEliminar.Name = "colEliminar"
        Me.colEliminar.Visible = True
        Me.colEliminar.VisibleIndex = 8
        Me.colEliminar.Width = 61
        '
        'rpEliminar
        '
        Me.rpEliminar.AutoHeight = False
        Me.rpEliminar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.rpEliminar.Name = "rpEliminar"
        Me.rpEliminar.NullText = "N"
        Me.rpEliminar.ValueChecked = "S"
        Me.rpEliminar.ValueUnchecked = "N"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboTipoPromo)
        Me.PanelControl1.Controls.Add(Me.Label8)
        Me.PanelControl1.Controls.Add(Me.txtUnidadOperat)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.btnBuscarUnidadOperat)
        Me.PanelControl1.Controls.Add(Me.txtSucursal)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.btnBuscarSucursal)
        Me.PanelControl1.Controls.Add(Me.txtEmpresa)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.btnBuscarEmpresa)
        Me.PanelControl1.Controls.Add(Me.txtDescripcion)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.txtProveedor)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.btnFechaHasta)
        Me.PanelControl1.Controls.Add(Me.txtFechaDesde)
        Me.PanelControl1.Controls.Add(Me.btnFechaDesde)
        Me.PanelControl1.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl1.Controls.Add(Me.btnBuscarProveedor)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(905, 130)
        Me.PanelControl1.TabIndex = 0
        '
        'cboTipoPromo
        '
        Me.cboTipoPromo.Location = New System.Drawing.Point(90, 91)
        Me.cboTipoPromo.Name = "cboTipoPromo"
        Me.cboTipoPromo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboTipoPromo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoPromo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cboTipoPromo.Properties.ImmediatePopup = True
        Me.cboTipoPromo.Properties.Items.AddRange(New Object() {"SOBRE PRECIO PROMOCIONAL", "SOBRE COSTO UNITARIO"})
        Me.cboTipoPromo.Size = New System.Drawing.Size(261, 22)
        Me.cboTipoPromo.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Tipo Promo.:"
        '
        'txtUnidadOperat
        '
        Me.txtUnidadOperat.EditValue = ""
        Me.txtUnidadOperat.Location = New System.Drawing.Point(90, 37)
        Me.txtUnidadOperat.Name = "txtUnidadOperat"
        Me.txtUnidadOperat.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUnidadOperat.Properties.Appearance.Options.UseBackColor = True
        Me.txtUnidadOperat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUnidadOperat.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadOperat.Properties.ReadOnly = True
        Me.txtUnidadOperat.Size = New System.Drawing.Size(231, 22)
        Me.txtUnidadOperat.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Unidad Oper.:"
        '
        'btnBuscarUnidadOperat
        '
        Me.btnBuscarUnidadOperat.Location = New System.Drawing.Point(325, 37)
        Me.btnBuscarUnidadOperat.Name = "btnBuscarUnidadOperat"
        Me.btnBuscarUnidadOperat.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarUnidadOperat.TabIndex = 21
        Me.btnBuscarUnidadOperat.Text = "+"
        '
        'txtSucursal
        '
        Me.txtSucursal.EditValue = ""
        Me.txtSucursal.Location = New System.Drawing.Point(90, 63)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtSucursal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSucursal.Properties.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(231, 22)
        Me.txtSucursal.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Sucursal:"
        '
        'btnBuscarSucursal
        '
        Me.btnBuscarSucursal.Location = New System.Drawing.Point(325, 63)
        Me.btnBuscarSucursal.Name = "btnBuscarSucursal"
        Me.btnBuscarSucursal.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarSucursal.TabIndex = 18
        Me.btnBuscarSucursal.Text = "+"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.EditValue = ""
        Me.txtEmpresa.Location = New System.Drawing.Point(90, 11)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtEmpresa.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtEmpresa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresa.Properties.ReadOnly = True
        Me.txtEmpresa.Size = New System.Drawing.Size(231, 22)
        Me.txtEmpresa.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Empresa:"
        '
        'btnBuscarEmpresa
        '
        Me.btnBuscarEmpresa.Location = New System.Drawing.Point(325, 11)
        Me.btnBuscarEmpresa.Name = "btnBuscarEmpresa"
        Me.btnBuscarEmpresa.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarEmpresa.TabIndex = 15
        Me.btnBuscarEmpresa.Text = "+"
        '
        'btnFechaHasta
        '
        Me.btnFechaHasta.Location = New System.Drawing.Point(688, 92)
        Me.btnFechaHasta.Name = "btnFechaHasta"
        Me.btnFechaHasta.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaHasta.TabIndex = 12
        Me.btnFechaHasta.Text = "+"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(453, 63)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaDesde.TabIndex = 6
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'btnFechaDesde
        '
        Me.btnFechaDesde.Location = New System.Drawing.Point(688, 63)
        Me.btnFechaDesde.Name = "btnFechaDesde"
        Me.btnFechaDesde.Size = New System.Drawing.Size(26, 21)
        Me.btnFechaDesde.TabIndex = 11
        Me.btnFechaDesde.Text = "+"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(453, 92)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(231, 21)
        Me.txtFechaHasta.TabIndex = 7
        Me.txtFechaHasta.ValidatingType = GetType(Date)
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(688, 37)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(26, 20)
        Me.btnBuscarProveedor.TabIndex = 10
        Me.btnBuscarProveedor.Text = "+"
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Liquidaciones"
        Me.TabNavigationPage2.Controls.Add(Me.PanelControl5)
        Me.TabNavigationPage2.Controls.Add(Me.PanelControl4)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1115, 534)
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.btnImprimirOfertas)
        Me.PanelControl5.Controls.Add(Me.btnImpPromociones)
        Me.PanelControl5.Controls.Add(Me.btnImprimirLiquidacion)
        Me.PanelControl5.Controls.Add(Me.btnCancelarLiquidacion)
        Me.PanelControl5.Controls.Add(Me.btnConfirmarPromo)
        Me.PanelControl5.Controls.Add(Me.btnDesactivarPromo)
        Me.PanelControl5.Location = New System.Drawing.Point(968, 3)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(147, 528)
        Me.PanelControl5.TabIndex = 32
        '
        'btnImprimirOfertas
        '
        Me.btnImprimirOfertas.Location = New System.Drawing.Point(24, 157)
        Me.btnImprimirOfertas.Name = "btnImprimirOfertas"
        Me.btnImprimirOfertas.Size = New System.Drawing.Size(99, 30)
        Me.btnImprimirOfertas.TabIndex = 34
        Me.btnImprimirOfertas.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ofertas"
        '
        'btnImpPromociones
        '
        Me.btnImpPromociones.Location = New System.Drawing.Point(24, 85)
        Me.btnImpPromociones.Name = "btnImpPromociones"
        Me.btnImpPromociones.Size = New System.Drawing.Size(99, 30)
        Me.btnImpPromociones.TabIndex = 33
        Me.btnImpPromociones.Text = "Imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Promociones"
        '
        'btnImprimirLiquidacion
        '
        Me.btnImprimirLiquidacion.Location = New System.Drawing.Point(24, 121)
        Me.btnImprimirLiquidacion.Name = "btnImprimirLiquidacion"
        Me.btnImprimirLiquidacion.Size = New System.Drawing.Size(98, 30)
        Me.btnImprimirLiquidacion.TabIndex = 32
        Me.btnImprimirLiquidacion.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Liquidacion"
        '
        'btnCancelarLiquidacion
        '
        Me.btnCancelarLiquidacion.Location = New System.Drawing.Point(24, 193)
        Me.btnCancelarLiquidacion.Name = "btnCancelarLiquidacion"
        Me.btnCancelarLiquidacion.Size = New System.Drawing.Size(98, 30)
        Me.btnCancelarLiquidacion.TabIndex = 31
        Me.btnCancelarLiquidacion.Text = "Cancelar"
        '
        'btnConfirmarPromo
        '
        Me.btnConfirmarPromo.Location = New System.Drawing.Point(24, 49)
        Me.btnConfirmarPromo.Name = "btnConfirmarPromo"
        Me.btnConfirmarPromo.Size = New System.Drawing.Size(99, 30)
        Me.btnConfirmarPromo.TabIndex = 30
        Me.btnConfirmarPromo.Text = "Confirmar Promo"
        '
        'btnDesactivarPromo
        '
        Me.btnDesactivarPromo.Location = New System.Drawing.Point(24, 13)
        Me.btnDesactivarPromo.Name = "btnDesactivarPromo"
        Me.btnDesactivarPromo.Size = New System.Drawing.Size(99, 30)
        Me.btnDesactivarPromo.TabIndex = 29
        Me.btnDesactivarPromo.Text = "Cerrar Promo"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.gridItemsLiquidacion)
        Me.PanelControl4.Controls.Add(Me.gridLiquidaciones)
        Me.PanelControl4.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(955, 528)
        Me.PanelControl4.TabIndex = 31
        '
        'gridItemsLiquidacion
        '
        Me.gridItemsLiquidacion.Location = New System.Drawing.Point(15, 211)
        Me.gridItemsLiquidacion.MainView = Me.GridViewItemsLiquidacion
        Me.gridItemsLiquidacion.Name = "gridItemsLiquidacion"
        Me.gridItemsLiquidacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.chkImprimir})
        Me.gridItemsLiquidacion.Size = New System.Drawing.Size(925, 304)
        Me.gridItemsLiquidacion.TabIndex = 27
        Me.gridItemsLiquidacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewItemsLiquidacion})
        '
        'GridViewItemsLiquidacion
        '
        Me.GridViewItemsLiquidacion.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewItemsLiquidacion.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewItemsLiquidacion.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridViewItemsLiquidacion.Appearance.FocusedCell.Options.UseFont = True
        Me.GridViewItemsLiquidacion.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewItemsLiquidacion.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewItemsLiquidacion.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewItemsLiquidacion.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewItemsLiquidacion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.colVendidos, Me.colReconocer, Me.colIdItemPromocion, Me.col_imprimir})
        Me.GridViewItemsLiquidacion.GridControl = Me.gridItemsLiquidacion
        Me.GridViewItemsLiquidacion.Name = "GridViewItemsLiquidacion"
        Me.GridViewItemsLiquidacion.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridViewItemsLiquidacion.OptionsFind.AlwaysVisible = True
        Me.GridViewItemsLiquidacion.OptionsView.ShowFooter = True
        Me.GridViewItemsLiquidacion.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID Producto"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn1.FieldName = "ID_PRODUCTO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Codigo Barras"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn2.FieldName = "CODIGO_BARRAS"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 106
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Producto"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn3.FieldName = "PRODUCTO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 212
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Precio Actual"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn4.FieldName = "PRECIO_ACTUAL"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 86
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.NullText = "0"
        Me.RepositoryItemTextEdit2.ReadOnly = True
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Costo Unitario"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn5.FieldName = "COSTO_UNITARIO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 86
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn6.Caption = "Precio Promocional"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn6.FieldName = "PRECIO_PROMO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 83
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn7.Caption = "Diferencia (Gs)"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn7.FieldName = "DIFERENCIA_PRECIO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 81
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn8.Caption = "Diferencia (%)"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GridColumn8.DisplayFormat.FormatString = "0.00"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "PORC_DIFERENCIA"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "PORC_DIFERENCIA", "0.00")})
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 82
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "0"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Id Unidad Medida"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn9.FieldName = "ID_UNIDAD_MEDIDA"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        '
        'colVendidos
        '
        Me.colVendidos.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVendidos.AppearanceCell.Options.UseFont = True
        Me.colVendidos.AppearanceCell.Options.UseTextOptions = True
        Me.colVendidos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVendidos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVendidos.AppearanceHeader.Options.UseFont = True
        Me.colVendidos.AppearanceHeader.Options.UseTextOptions = True
        Me.colVendidos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVendidos.Caption = "Cant. Vendida"
        Me.colVendidos.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.colVendidos.FieldName = "CANTIDAD_VENDIDA"
        Me.colVendidos.Name = "colVendidos"
        Me.colVendidos.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CANTIDAD_VENDIDA", "{0:0.00}")})
        Me.colVendidos.Visible = True
        Me.colVendidos.VisibleIndex = 7
        Me.colVendidos.Width = 83
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        Me.RepositoryItemTextEdit4.ValidateOnEnterKey = True
        '
        'colReconocer
        '
        Me.colReconocer.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colReconocer.AppearanceCell.Options.UseFont = True
        Me.colReconocer.AppearanceCell.Options.UseTextOptions = True
        Me.colReconocer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colReconocer.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colReconocer.AppearanceHeader.Options.UseFont = True
        Me.colReconocer.AppearanceHeader.Options.UseTextOptions = True
        Me.colReconocer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colReconocer.Caption = "Dif. Reconocer"
        Me.colReconocer.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colReconocer.DisplayFormat.FormatString = "#,#"
        Me.colReconocer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colReconocer.FieldName = "DIF_RECONOCER"
        Me.colReconocer.Name = "colReconocer"
        Me.colReconocer.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DIF_RECONOCER", "{0:#,#}")})
        Me.colReconocer.Visible = True
        Me.colReconocer.VisibleIndex = 8
        Me.colReconocer.Width = 88
        '
        'colIdItemPromocion
        '
        Me.colIdItemPromocion.Caption = "colIdItemPromocion"
        Me.colIdItemPromocion.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colIdItemPromocion.FieldName = "ID_ITEM_PROMOCION"
        Me.colIdItemPromocion.Name = "colIdItemPromocion"
        '
        'col_imprimir
        '
        Me.col_imprimir.Caption = "Imprimir"
        Me.col_imprimir.ColumnEdit = Me.chkImprimir
        Me.col_imprimir.FieldName = "IMPRIMIR"
        Me.col_imprimir.Name = "col_imprimir"
        Me.col_imprimir.Visible = True
        Me.col_imprimir.VisibleIndex = 9
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoHeight = False
        Me.chkImprimir.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.ValueChecked = "S"
        Me.chkImprimir.ValueUnchecked = "N"
        '
        'gridLiquidaciones
        '
        Me.gridLiquidaciones.Location = New System.Drawing.Point(15, 14)
        Me.gridLiquidaciones.MainView = Me.GridViewLiquidaciones
        Me.gridLiquidaciones.Name = "gridLiquidaciones"
        Me.gridLiquidaciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit10, Me.RepositoryItemTextEdit11})
        Me.gridLiquidaciones.Size = New System.Drawing.Size(925, 187)
        Me.gridLiquidaciones.TabIndex = 26
        Me.gridLiquidaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLiquidaciones})
        '
        'GridViewLiquidaciones
        '
        Me.GridViewLiquidaciones.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridViewLiquidaciones.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridViewLiquidaciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridViewLiquidaciones.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridViewLiquidaciones.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewLiquidaciones.Appearance.FocusedRow.Options.UseFont = True
        Me.GridViewLiquidaciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.colProveedor, Me.colDesde, Me.colHasta, Me.colTotalPagado, Me.colConfirmado, Me.colIdPromocion, Me.colActivo, Me.colEmpresa, Me.colUnidad, Me.colsitio, Me.colCerrado, Me.colNombreEmpresa, Me.colNombreUnidad, Me.colNombreSucursal})
        Me.GridViewLiquidaciones.GridControl = Me.gridLiquidaciones
        Me.GridViewLiquidaciones.Name = "GridViewLiquidaciones"
        Me.GridViewLiquidaciones.OptionsBehavior.Editable = False
        Me.GridViewLiquidaciones.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
        Me.GridViewLiquidaciones.OptionsPrint.PrintHorzLines = False
        Me.GridViewLiquidaciones.OptionsPrint.PrintVertLines = False
        Me.GridViewLiquidaciones.OptionsPrint.RtfReportHeader = resources.GetString("GridViewLiquidaciones.OptionsPrint.RtfReportHeader")
        Me.GridViewLiquidaciones.OptionsView.ShowFooter = True
        Me.GridViewLiquidaciones.OptionsView.ShowGroupPanel = False
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Promocion"
        Me.GridColumn17.FieldName = "PROMOCION"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Width = 238
        '
        'colProveedor
        '
        Me.colProveedor.Caption = "Proveedor"
        Me.colProveedor.ColumnEdit = Me.RepositoryItemTextEdit9
        Me.colProveedor.FieldName = "PROVEEDOR"
        Me.colProveedor.Name = "colProveedor"
        Me.colProveedor.Visible = True
        Me.colProveedor.VisibleIndex = 1
        Me.colProveedor.Width = 238
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = False
        Me.RepositoryItemTextEdit9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'colDesde
        '
        Me.colDesde.Caption = "Fecha Desde"
        Me.colDesde.ColumnEdit = Me.RepositoryItemTextEdit10
        Me.colDesde.FieldName = "FECHA_DESDE"
        Me.colDesde.Name = "colDesde"
        Me.colDesde.Visible = True
        Me.colDesde.VisibleIndex = 2
        Me.colDesde.Width = 100
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = False
        Me.RepositoryItemTextEdit10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit10.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.RepositoryItemTextEdit10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'colHasta
        '
        Me.colHasta.Caption = "Fecha Hasta"
        Me.colHasta.ColumnEdit = Me.RepositoryItemTextEdit10
        Me.colHasta.FieldName = "FECHA_HASTA"
        Me.colHasta.Name = "colHasta"
        Me.colHasta.Visible = True
        Me.colHasta.VisibleIndex = 3
        Me.colHasta.Width = 100
        '
        'colTotalPagado
        '
        Me.colTotalPagado.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalPagado.AppearanceCell.Options.UseFont = True
        Me.colTotalPagado.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalPagado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalPagado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTotalPagado.AppearanceHeader.Options.UseFont = True
        Me.colTotalPagado.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalPagado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalPagado.Caption = "Total Pagado"
        Me.colTotalPagado.ColumnEdit = Me.RepositoryItemTextEdit11
        Me.colTotalPagado.FieldName = "TOTAL_PAGADO"
        Me.colTotalPagado.Name = "colTotalPagado"
        Me.colTotalPagado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL_PAGADO", "{0:#,#}")})
        Me.colTotalPagado.Visible = True
        Me.colTotalPagado.VisibleIndex = 4
        Me.colTotalPagado.Width = 100
        '
        'RepositoryItemTextEdit11
        '
        Me.RepositoryItemTextEdit11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RepositoryItemTextEdit11.Appearance.Options.UseFont = True
        Me.RepositoryItemTextEdit11.AutoHeight = False
        Me.RepositoryItemTextEdit11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemTextEdit11.DisplayFormat.FormatString = "#,#"
        Me.RepositoryItemTextEdit11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit11.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit11.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit11.Name = "RepositoryItemTextEdit11"
        Me.RepositoryItemTextEdit11.NullText = "0"
        '
        'colConfirmado
        '
        Me.colConfirmado.AppearanceCell.Options.UseTextOptions = True
        Me.colConfirmado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConfirmado.AppearanceHeader.Options.UseTextOptions = True
        Me.colConfirmado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConfirmado.Caption = "Confirmado"
        Me.colConfirmado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colConfirmado.FieldName = "CONFIRMADO"
        Me.colConfirmado.Name = "colConfirmado"
        Me.colConfirmado.Visible = True
        Me.colConfirmado.VisibleIndex = 7
        Me.colConfirmado.Width = 100
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "S"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'colIdPromocion
        '
        Me.colIdPromocion.AppearanceCell.Options.UseTextOptions = True
        Me.colIdPromocion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colIdPromocion.AppearanceHeader.Options.UseTextOptions = True
        Me.colIdPromocion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colIdPromocion.Caption = "ID"
        Me.colIdPromocion.ColumnEdit = Me.RepositoryItemTextEdit9
        Me.colIdPromocion.FieldName = "ID_PROMOCION"
        Me.colIdPromocion.Name = "colIdPromocion"
        Me.colIdPromocion.Visible = True
        Me.colIdPromocion.VisibleIndex = 0
        '
        'colActivo
        '
        Me.colActivo.AppearanceCell.Options.UseTextOptions = True
        Me.colActivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActivo.AppearanceHeader.Options.UseTextOptions = True
        Me.colActivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActivo.Caption = "Activo"
        Me.colActivo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActivo.FieldName = "ACTIVO"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 5
        '
        'colEmpresa
        '
        Me.colEmpresa.Caption = "GridColumn11"
        Me.colEmpresa.FieldName = "id_empresa"
        Me.colEmpresa.Name = "colEmpresa"
        '
        'colUnidad
        '
        Me.colUnidad.Caption = "GridColumn12"
        Me.colUnidad.FieldName = "id_unidad"
        Me.colUnidad.Name = "colUnidad"
        '
        'colsitio
        '
        Me.colsitio.Caption = "GridColumn13"
        Me.colsitio.FieldName = "id_sitio"
        Me.colsitio.Name = "colsitio"
        '
        'colCerrado
        '
        Me.colCerrado.AppearanceCell.Options.UseTextOptions = True
        Me.colCerrado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCerrado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCerrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCerrado.Caption = "Cerrado"
        Me.colCerrado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colCerrado.FieldName = "CERRADO"
        Me.colCerrado.Name = "colCerrado"
        Me.colCerrado.Visible = True
        Me.colCerrado.VisibleIndex = 6
        '
        'colNombreEmpresa
        '
        Me.colNombreEmpresa.Caption = "Empresa"
        Me.colNombreEmpresa.FieldName = "EMPRESA"
        Me.colNombreEmpresa.Name = "colNombreEmpresa"
        '
        'colNombreUnidad
        '
        Me.colNombreUnidad.Caption = "Unidad"
        Me.colNombreUnidad.FieldName = "UNIDAD"
        Me.colNombreUnidad.Name = "colNombreUnidad"
        '
        'colNombreSucursal
        '
        Me.colNombreSucursal.Caption = "Sucursal"
        Me.colNombreSucursal.FieldName = "d"
        Me.colNombreSucursal.Name = "colNombreSucursal"
        '
        'FrmAppPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 592)
        Me.Controls.Add(Me.TabPane1)
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FrmAppPromociones"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promociones"
        CType(Me.rpsTxtCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtPrecioActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtCostoUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtPrecioPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtDiferenciaPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsTxtPorcDiferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPrecioActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsCostoUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPrecioPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsDiferenciaPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpsPorcDierencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage1.PerformLayout()
        CType(Me.cldFechaDesde.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cldFechaHasta.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gridItemsPromocion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewItemsPromocion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCodBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPrecioActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpMargen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpCostoUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPrecioPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpDiferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpPorcDiferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboTipoPromo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadOperat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.gridItemsLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewItemsLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents btnFechaHasta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaDesde As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As MaskedTextBox
    Friend WithEvents txtFechaDesde As MaskedTextBox
    Friend WithEvents gridItemsPromocion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewItemsPromocion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioActual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioPromo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiferenciaPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcDiferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridLiquidaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewLiquidaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPagado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConfirmado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCodBarras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDesactivarPromo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cldFechaDesde As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents cldFechaHasta As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnActivarPromo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUnidadOperat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscarUnidadOperat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscarEmpresa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIdUnidadMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnConfirmarPromo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridItemsLiquidacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewItemsLiquidacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReconocer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdItemPromocion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPromocion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsitio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsCodigoBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsProducto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPrecioActual As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsCostoUnitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPrecioPromo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsDiferenciaPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsPorcDierencia As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCerrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancelarLiquidacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddProductos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colNombreEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreUnidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreSucursal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImprimirLiquidacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnImpPromociones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIdItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cboTipoPromo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents btnImprimirOfertas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colNuevo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpsTxtCodigoBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTxtProducto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTxtPrecioActual As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTxtCostoUnitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTxtPrecioPromo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTxtDiferenciaPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpsTxtPorcDiferencia As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents chkEliminar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_margen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpCodBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpProducto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpPrecioActual As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpMargen As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpCostoUnitario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpPrecioPromo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpDiferencia As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpPorcDiferencia As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rpEliminar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_imprimir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkImprimir As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
