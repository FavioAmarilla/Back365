<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptSubArqueoCajas
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DtsDeclaracionEfectivo1 = New Back365.DtsDeclaracionEfectivo()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.totalEntrega = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.diferencia = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.totalTicket = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        CType(Me.DtsDeclaracionEfectivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel5})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 19.79167!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.DESCRIPCION")})
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(69.5!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(321.9167!, 19.70835!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.VALOR", "{0:#,#}")})
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(412.2091!, 0.08331934!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(95.16647!, 19.70835!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.IMPORTE", "{0:#,#}")})
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(602.5421!, 0.08331934!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(95.1665!, 19.70835!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.CANTIDAD", "{0:#,#}")})
        Me.XrLabel5.Dpi = 100.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(507.3756!, 0.08331934!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(95.16647!, 19.70835!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 14.83329!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12})
        Me.PageHeader.Dpi = 100.0!
        Me.PageHeader.HeightF = 21.875!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(507.3756!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(95.16647!, 19.70835!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Cantidad"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 100.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(69.5!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(321.9167!, 19.70835!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Descripcion"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 100.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(412.2091!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(95.16647!, 19.70835!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Valor"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel12
        '
        Me.XrLabel12.Dpi = 100.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(602.5421!, 0!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(95.1665!, 19.70835!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Importe"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 100.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(23.66673!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(674.0419!, 22.99998!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "DECLARACION DE EFECTIVO"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DtsDeclaracionEfectivo1
        '
        Me.DtsDeclaracionEfectivo1.DataSetName = "DtsDeclaracionEfectivo"
        Me.DtsDeclaracionEfectivo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 100.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(602.5421!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(95.1665!, 4.249986!)
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "dt.IMPORTE")})
        Me.XrLabel7.Dpi = 100.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(602.5421!, 4.249986!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(95.1665!, 19.70835!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel7.Summary = XrSummary1
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrLabel7, Me.XrLine1})
        Me.ReportFooter.Dpi = 100.0!
        Me.ReportFooter.HeightF = 107.2917!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLabel16, Me.XrLabel17, Me.XrLabel13, Me.XrLabel9, Me.XrLabel8})
        Me.XrPanel1.Dpi = 100.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(411.7508!, 23.95833!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(285.4995!, 78.12499!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.totalEntrega, "Text", "{0:#,#}")})
        Me.XrLabel14.Dpi = 100.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(140.2084!, 9.250004!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.NullValueText = "0"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(135.2911!, 19.87498!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'totalEntrega
        '
        Me.totalEntrega.Name = "totalEntrega"
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.diferencia, "Text", "{0:#,#}")})
        Me.XrLabel16.Dpi = 100.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(140.2084!, 48.99998!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.NullValueText = "0"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(135.2911!, 19.87501!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'diferencia
        '
        Me.diferencia.Name = "diferencia"
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.totalTicket, "Text", "{0:#,#}")})
        Me.XrLabel17.Dpi = 100.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(140.2084!, 29.12501!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.NullValueText = "0"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(135.2911!, 19.87498!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'totalTicket
        '
        Me.totalTicket.Name = "totalTicket"
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.Dpi = 100.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 48.99998!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(130.2083!, 19.87501!)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "DIFERENCIA:"
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.Dpi = 100.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 29.12501!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(130.2083!, 19.87498!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "TOTAL S/TICKET:"
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Dpi = 100.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(10.00004!, 9.250004!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(130.2083!, 19.875!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "TOTAL ENTREGA:"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6})
        Me.ReportHeader.Dpi = 100.0!
        Me.ReportHeader.HeightF = 26.04167!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'RptSubArqueoCajas
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.ReportFooter, Me.ReportHeader})
        Me.DataSource = Me.DtsDeclaracionEfectivo1
        Me.Margins = New System.Drawing.Printing.Margins(39, 45, 20, 15)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.totalEntrega, Me.totalTicket, Me.diferencia})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "16.1"
        CType(Me.DtsDeclaracionEfectivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DtsDeclaracionEfectivo1 As DtsDeclaracionEfectivo
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents diferencia As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalTicket As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents totalEntrega As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
End Class
