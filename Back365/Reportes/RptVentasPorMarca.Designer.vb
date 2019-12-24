<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptVentasPorMarca
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
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.unidad = New DevExpress.XtraReports.Parameters.Parameter()
        Me.sucursal = New DevExpress.XtraReports.Parameters.Parameter()
        Me.familia = New DevExpress.XtraReports.Parameters.Parameter()
        Me.fechaDesde = New DevExpress.XtraReports.Parameters.Parameter()
        Me.fechaHasta = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.DtsVentasPorFamilia1 = New Back365.DtsVentasPorFamilia()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me.DtsVentasPorFamilia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.XrLabel14, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel20
        '
        Me.XrLabel20.Dpi = 100.0!
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(740.4644!, 0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(16.97986!, 23.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "%"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.CANTIDAD", "{0:0.00}")})
        Me.XrLabel14.Dpi = 100.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(348.8894!, 0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.COSTO_UNITARIO", "{0:#,#}")})
        Me.XrLabel16.Dpi = 100.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(448.8894!, 0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "XrLabel16"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.PRECIO_VENTA", "{0:#,#}")})
        Me.XrLabel17.Dpi = 100.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(548.8895!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.PARTICIPACION", "{0:0.00}")})
        Me.XrLabel18.Dpi = 100.0!
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(654.0842!, 0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(86.38013!, 23.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.MARCA")})
        Me.XrLabel19.Dpi = 100.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(13.84741!, 0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(334.4833!, 23.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 32.0!
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
        'unidad
        '
        Me.unidad.Name = "unidad"
        '
        'sucursal
        '
        Me.sucursal.Name = "sucursal"
        '
        'familia
        '
        Me.familia.Name = "familia"
        '
        'fechaDesde
        '
        Me.fechaDesde.Name = "fechaDesde"
        '
        'fechaHasta
        '
        Me.fechaHasta.Name = "fechaHasta"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel2, Me.XrLabel33, Me.XrLabel34, Me.XrLabel31, Me.XrLabel3, Me.XrLabel6, Me.XrLabel7, Me.XrLabel4, Me.XrLabel30, Me.XrLabel8})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 126.9166!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.333332!, 91.41658!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(98.16266!, 23.00003!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Familia:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.familia, "Text", "")})
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(107.5792!, 91.41652!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(441.6045!, 23.00003!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel33
        '
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.fechaDesde, "Text", "")})
        Me.XrLabel33.Dpi = 100.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(625.2037!, 45.41669!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(126.1871!, 23.0!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.fechaHasta, "Text", "")})
        Me.XrLabel34.Dpi = 100.0!
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(625.2037!, 68.4166!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(126.1871!, 23.0!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel31
        '
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.sucursal, "Text", "")})
        Me.XrLabel31.Dpi = 100.0!
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(107.496!, 68.41647!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(268.584!, 23.00003!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(9.666665!, 45.41658!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(97.82932!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Unidad Operat.:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(518.4121!, 45.4166!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(106.2917!, 22.99999!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Fecha Desde:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(518.4121!, 68.4166!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(106.2917!, 22.99998!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Fecha Hasta:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(9.666665!, 68.41653!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(97.82932!, 23.00003!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Sucursal:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel30
        '
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.unidad, "Text", "")})
        Me.XrLabel30.Dpi = 100.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(107.5792!, 45.41645!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(268.5006!, 23.00001!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 100.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(124.9979!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(427.0833!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Reporte de ventas por familia"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel11, Me.XrLabel15, Me.XrLabel10, Me.XrLabel13, Me.XrLine2})
        Me.PageHeader.Dpi = 100.0!
        Me.PageHeader.HeightF = 31.24999!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 100.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(548.7797!, 0!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(100.1099!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Total venta"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 100.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(648.8896!, 0!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(107.888!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Participacion (%)"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 100.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(13.8474!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(334.7124!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Marca"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(448.6698!, 0!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(100.1099!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Total Costo"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Dpi = 100.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(348.5599!, 0!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(100.1099!, 23.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = " Cantidad"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 100.0!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(11.55573!, 22.99999!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(745.8885!, 8.250001!)
        '
        'DtsVentasPorFamilia1
        '
        Me.DtsVentasPorFamilia1.DataSetName = "DtsVentasPorFamilia"
        Me.DtsVentasPorFamilia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel35, Me.XrLabel32, Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLine1, Me.XrLabel5, Me.XrLabel9, Me.XrLabel21})
        Me.ReportFooter.Dpi = 100.0!
        Me.ReportFooter.HeightF = 79.16666!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel35
        '
        Me.XrLabel35.Dpi = 100.0!
        Me.XrLabel35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(11.44113!, 10.0!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(147.8333!, 23.00003!)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "Total General:"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.COSTO_UNITARIO")})
        Me.XrLabel32.Dpi = 100.0!
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(448.775!, 10.0!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(99.2027!, 23.0!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel32.Summary = XrSummary1
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel29
        '
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.PRECIO_VENTA")})
        Me.XrLabel29.Dpi = 100.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(547.9777!, 9.999964!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(100.1099!, 23.0!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel29.Summary = XrSummary2
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.PARTICIPACION")})
        Me.XrLabel28.Dpi = 100.0!
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(655.2298!, 9.999974!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(85.23438!, 23.0!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:0.00}"
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Avg
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel28.Summary = XrSummary3
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel27
        '
        Me.XrLabel27.Dpi = 100.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(740.4644!, 9.999974!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(16.97986!, 23.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "%"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 100.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(11.89947!, 1.749983!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(745.8885!, 8.250001!)
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.CANTIDAD")})
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(348.3166!, 10.00006!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:#,#.00}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel5.Summary = XrSummary4
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(11.21207!, 33.00001!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(148.0624!, 23.00003!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Recuento:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dtVentas.MARCA")})
        Me.XrLabel21.Dpi = 100.0!
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(655.2298!, 33.00002!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(102.2248!, 23.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,#}"
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel21.Summary = XrSummary5
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel23, Me.XrPageInfo2, Me.XrPageInfo1, Me.XrLine3})
        Me.PageFooter.Dpi = 100.0!
        Me.PageFooter.HeightF = 100.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel23
        '
        Me.XrLabel23.Dpi = 100.0!
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(8.500061!, 41.74996!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(77.60412!, 23.0!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Fecha Imp.:"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Dpi = 100.0!
        Me.XrPageInfo2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(86.10418!, 41.74996!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(249.3808!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 100.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(646.063!, 43.50003!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(114.3535!, 23.00001!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine3
        '
        Me.XrLine3.Dpi = 100.0!
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(9.541581!, 33.49996!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(750.9583!, 8.25!)
        '
        'RptVentasPorMarca
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.DataSource = Me.DtsVentasPorFamilia1
        Me.Margins = New System.Drawing.Printing.Margins(42, 39, 32, 35)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.unidad, Me.sucursal, Me.familia, Me.fechaDesde, Me.fechaHasta})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.1"
        CType(Me.DtsVentasPorFamilia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents unidad As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents sucursal As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents familia As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents fechaDesde As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents fechaHasta As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DtsVentasPorFamilia1 As DtsVentasPorFamilia
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
End Class
