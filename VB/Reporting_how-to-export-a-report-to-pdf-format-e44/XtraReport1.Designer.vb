Namespace WindowsFormsApplication1
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 36.45833F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Dpi = 100F
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(133.3333F, 23F)
            Me.xrLabel1.Text = "A sample report..."
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrRichText1, Me.xrPictureBox1})
            Me.ReportHeader.Dpi = 100F
            Me.ReportHeader.HeightF = 148.9583F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Dpi = 100F
            Me.xrPictureBox1.Image = (CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(435.8334F, 10.00001F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(204.1666F, 138.9583F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' xrRichText1
            ' 
            Me.xrRichText1.Dpi = 100F
            Me.xrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75F)
            Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrRichText1.Name = "xrRichText1"
            Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
            Me.xrRichText1.SizeF = New System.Drawing.SizeF(403.125F, 87.58332F)
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Dpi = 100F
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 12F)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 111.7917F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(403.125F, 27.16669F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "Tahoma font sample"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
            Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 55
            Me.Version = "16.2"
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrRichText1 As DevExpress.XtraReports.UI.XRRichText
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
