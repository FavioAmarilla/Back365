<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptComprasProveedorMeses
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
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.proveedor = New DevExpress.XtraReports.Parameters.Parameter()
        Me.hasta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.desde = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DtsComprasProveedor1 = New Back365.DtsComprasProveedor()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.empresa = New DevExpress.XtraReports.Parameters.Parameter()
        Me.sucursal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.unidad = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.DtsComprasProveedor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel11})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 22.91667!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.MONTO_NETO", "{0:#,#}")})
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(600.2233!, 0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.NullValueText = "0"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(104.7767!, 20.29!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.FACTURA", "{0:#,#}")})
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(390.67!, 0!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.NullValueText = "0"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(104.7766!, 20.29!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.NOTA_CREDITO", "{0:#,#}")})
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(495.4467!, 0!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.NullValueText = "0"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(104.7766!, 20.29!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.MES")})
        Me.XrLabel11.Dpi = 100.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(230.7777!, 20.29!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 35.0!
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrLabel8})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 167.7083!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'proveedor
        '
        Me.proveedor.Name = "proveedor"
        '
        'hasta
        '
        Me.hasta.Name = "hasta"
        '
        'desde
        '
        Me.desde.Name = "desde"
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 100.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(230.5625!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(421.875!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Compras a proveedores por meses"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DtsComprasProveedor1
        '
        Me.DtsComprasProveedor1.DataSetName = "DtsComprasProveedor"
        Me.DtsComprasProveedor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel16, Me.XrLabel14, Me.XrLabel10, Me.XrLabel9, Me.XrLine1})
        Me.PageHeader.Dpi = 100.0!
        Me.PageHeader.HeightF = 29.45503!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel16
        '
        Me.XrLabel16.Dpi = 100.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(230.7777!, 20.29!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = " Mes"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Dpi = 100.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(494.346!, 0!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(104.7766!, 20.29!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = " Nota credito"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(389.5693!, 0!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(104.7766!, 20.29!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Facturacion"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(600.2233!, 0!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(104.7767!, 20.29!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = " Monto Neto"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 100.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 20.58001!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(630.0!, 8.250002!)
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel13, Me.XrLabel15, Me.XrLabel38, Me.XrLine2})
        Me.ReportFooter.Dpi = 100.0!
        Me.ReportFooter.HeightF = 81.25!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.NOTA_CREDITO")})
        Me.XrLabel12.Dpi = 100.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(495.4467!, 18.25002!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.NullValueText = "0"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(104.7766!, 20.29!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel12.Summary = XrSummary1
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.FACTURA")})
        Me.XrLabel13.Dpi = 100.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(390.67!, 18.25002!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.NullValueText = "0"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(104.7766!, 20.29!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel13.Summary = XrSummary2
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.MONTO_NETO")})
        Me.XrLabel15.Dpi = 100.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(600.2233!, 18.25008!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.NullValueText = "0"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(104.7767!, 20.29!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,#}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel15.Summary = XrSummary3
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel38
        '
        Me.XrLabel38.Dpi = 100.0!
        Me.XrLabel38.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 18.25008!)
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
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 10.00001!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(630.0!, 8.250001!)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrPageInfo1, Me.XrLabel43, Me.XrPageInfo2})
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 100.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 100.0!
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(75.0!, 34.375!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(630.0!, 8.25!)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 100.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(621.2084!, 42.62498!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(83.79156!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel43
        '
        Me.XrLabel43.Dpi = 100.0!
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(75.00003!, 42.62498!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(75.10406!, 23.0!)
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "Fecha Imp.:"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Dpi = 100.0!
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(150.1041!, 42.62498!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(249.3808!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'empresa
        '
        Me.empresa.Name = "empresa"
        '
        'sucursal
        '
        Me.sucursal.Name = "sucursal"
        '
        'unidad
        '
        Me.unidad.Name = "unidad"
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel33, Me.XrLabel34, Me.XrLabel7, Me.XrLabel2, Me.XrLabel1, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17})
        Me.XrPanel1.Dpi = 100.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(22.41663!, 47.91667!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(747.3334!, 109.7916!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(5.291668!, 43.39581!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(95.44642!, 22.99998!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = " Unidad opert.:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.unidad, "Text", "{0:dd/MM/yy}")})
        Me.XrLabel33.Dpi = 100.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(112.1964!, 43.39581!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(222.0206!, 23.0!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.sucursal, "Text", "{0:dd/MM/yy}")})
        Me.XrLabel34.Dpi = 100.0!
        Me.XrLabel34.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(112.1964!, 66.39576!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(222.0206!, 23.0!)
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(15.36311!, 66.39586!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(85.45831!, 22.99998!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = " Sucursal:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.empresa, "Text", "")})
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(112.0297!, 20.39579!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(222.1872!, 23.00001!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(15.36308!, 20.39579!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(85.45831!, 22.99999!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Empresa:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel22.Dpi = 100.0!
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(390.8248!, 43.3958!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(85.45831!, 22.99999!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Fecha Desde:"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.proveedor, "Text", "")})
        Me.XrLabel21.Dpi = 100.0!
        Me.XrLabel21.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(487.5746!, 20.39579!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(232.5208!, 23.00001!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.Dpi = 100.0!
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(390.8248!, 66.39587!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(85.45831!, 22.99998!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Fecha Hasta:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.hasta, "Text", "{0:dd/MM/yy}")})
        Me.XrLabel19.Dpi = 100.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(487.7414!, 66.39575!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(203.2706!, 23.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.desde, "Text", "{0:dd/MM/yy}")})
        Me.XrLabel18.Dpi = 100.0!
        Me.XrLabel18.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(487.7414!, 43.3958!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(203.2706!, 23.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.Dpi = 100.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(390.8247!, 20.39577!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(85.45831!, 22.99999!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = " Proveedor:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'RptComprasProveedorMeses
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.DataSource = Me.DtsComprasProveedor1
        Me.Margins = New System.Drawing.Printing.Margins(23, 47, 35, 35)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.proveedor, Me.desde, Me.hasta, Me.empresa, Me.sucursal, Me.unidad})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.1"
        CType(Me.DtsComprasProveedor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents proveedor As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents hasta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents desde As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DtsComprasProveedor1 As DtsComprasProveedor
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents empresa As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents sucursal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents unidad As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
End Class
