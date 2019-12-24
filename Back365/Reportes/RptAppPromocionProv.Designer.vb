<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptAppPromocionProv
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.fechaDesde = New DevExpress.XtraReports.Parameters.Parameter()
        Me.fechaHasta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.sucursal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.proveedor = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DtsPrProductos1 = New Back365.DtsPrProductos()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.usuarioFechaImp = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.DtsPrProductos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel2, Me.XrLabel3})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 16.74833!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 34.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 35.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel33, Me.XrLabel34, Me.XrLabel6, Me.XrLabel7, Me.XrLabel32, Me.XrLabel5, Me.XrLabel31, Me.XrLabel4, Me.XrLabel8})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 150.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrLabel15, Me.XrLabel9, Me.XrLine1})
        Me.PageHeader.Dpi = 100.0!
        Me.PageHeader.HeightF = 26.04167!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 100.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(320.8334!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Pomociones de Productos"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'fechaDesde
        '
        Me.fechaDesde.Name = "fechaDesde"
        '
        'fechaHasta
        '
        Me.fechaHasta.Name = "fechaHasta"
        '
        'sucursal
        '
        Me.sucursal.Name = "sucursal"
        '
        'proveedor
        '
        Me.proveedor.Name = "proveedor"
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.proveedor, "Text", "")})
        Me.XrLabel32.Dpi = 100.0!
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(137.4211!, 65.45821!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(575.688!, 22.99998!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(47.95185!, 65.45824!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(88.62499!, 22.99998!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Proveedor:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.sucursal, "Text", "")})
        Me.XrLabel31.Dpi = 100.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(136.5352!, 42.45818!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(576.6155!, 23.00003!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(47.95185!, 42.45818!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(88.58331!, 23.00003!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Sucursal:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel33
        '
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.fechaDesde, "Text", "")})
        Me.XrLabel33.Dpi = 100.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(136.5352!, 88.45822!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(214.7289!, 23.0!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.fechaHasta, "Text", "")})
        Me.XrLabel34.Dpi = 100.0!
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(136.5352!, 111.4581!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(214.7289!, 23.0!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(47.95185!, 88.45822!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(88.58331!, 22.99999!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Fecha Desde:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(47.95185!, 111.4582!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(88.58331!, 22.99998!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Fecha Hasta:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 100.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(149.0769!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(462.1111!, 16.74833!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Producto"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 100.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(48.53528!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100.5!, 16.74833!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Codigo Barras"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(611.188!, 0!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(91.23499!, 16.74833!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Cantidad"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 100.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(48.53528!, 16.74833!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(653.9294!, 8.249996!)
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.CANTIDAD", "{0:0.00}")})
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(612.5421!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(91.23499!, 16.74833!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.CODIGO_BARRAS")})
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(49.88946!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100.5!, 16.74833!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.DESCRIPCION")})
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(150.4311!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(462.1111!, 16.74833!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DtsPrProductos1
        '
        Me.DtsPrProductos1.DataSetName = "DtsPrProductos"
        Me.DtsPrProductos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel38, Me.XrLine2, Me.XrLabel12, Me.XrLabel45, Me.XrLabel44})
        Me.ReportFooter.Dpi = 100.0!
        Me.ReportFooter.HeightF = 65.625!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrPageInfo1, Me.XrLabel43})
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 100.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'usuarioFechaImp
        '
        Me.usuarioFechaImp.Name = "usuarioFechaImp"
        '
        'XrLabel38
        '
        Me.XrLabel38.Dpi = 100.0!
        Me.XrLabel38.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(49.88946!, 10.00001!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(98.43745!, 23.0!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "Totales:"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 100.0!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(47.91019!, 0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(653.8459!, 8.25!)
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.CANTIDAD")})
        Me.XrLabel12.Dpi = 100.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(611.7714!, 9.916687!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.NullValueText = "0"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(91.27655!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:0.00}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel12.Summary = XrSummary1
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel45
        '
        Me.XrLabel45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.DESCRIPCION")})
        Me.XrLabel45.Dpi = 100.0!
        Me.XrLabel45.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(611.7714!, 32.91671!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.NullValueText = "0"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(91.31836!, 23.0!)
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel45.Summary = XrSummary2
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel44
        '
        Me.XrLabel44.Dpi = 100.0!
        Me.XrLabel44.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(49.1604!, 32.99999!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(99.1665!, 23.0!)
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "Recuento:"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 100.0!
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(5.041667!, 36.54168!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(740.9583!, 8.250004!)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 100.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(662.2084!, 44.79167!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(83.79156!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel43
        '
        Me.XrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.usuarioFechaImp, "Text", "")})
        Me.XrLabel43.Dpi = 100.0!
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 44.79167!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(491.7708!, 23.0!)
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RptAppPromocionProv
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.DataSource = Me.DtsPrProductos1
        Me.Margins = New System.Drawing.Printing.Margins(51, 48, 34, 35)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.fechaDesde, Me.fechaHasta, Me.sucursal, Me.proveedor, Me.usuarioFechaImp})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.1"
        CType(Me.DtsPrProductos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents fechaDesde As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents fechaHasta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents sucursal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents proveedor As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DtsPrProductos1 As DtsPrProductos
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents usuarioFechaImp As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
End Class
