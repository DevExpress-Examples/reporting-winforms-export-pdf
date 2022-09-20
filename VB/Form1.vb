Imports System
Imports System.Windows.Forms
Imports System.Diagnostics
Imports DevExpress.XtraPrinting

' ...
Namespace ExportToPdfCS

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' A path to export a report.
            Dim reportPath As String = "c:\Test.pdf"
            ' Create a report instance.
            Dim report As XtraReport1 = New XtraReport1()
            ' Get its PDF export options.
            Dim pdfOptions As PdfExportOptions = report.ExportOptions.Pdf
            ' Set PDF-specific export options.
            pdfOptions.Compressed = True
            pdfOptions.ImageQuality = PdfJpegImageQuality.Low
            pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New"
            pdfOptions.DocumentOptions.Application = "Test Application"
            pdfOptions.DocumentOptions.Author = "DX Documentation Team"
            pdfOptions.DocumentOptions.Keywords = "XtraReports, XtraPrinting"
            pdfOptions.DocumentOptions.Subject = "Test Subject"
            pdfOptions.DocumentOptions.Title = "Test Title"
            ' Set the pages to be exported.
            pdfOptions.PageRange = "1, 3-5"
            ' Export the report to PDF.
            report.ExportToPdf(reportPath)
            ' Show the result.
            StartProcess(reportPath)
        End Sub

        ' Use this method if you want to automaically open
        ' the created PDF file in the default program.
        Public Sub StartProcess(ByVal path As String)
            Dim process As Process = New Process()
            Try
                process.StartInfo.FileName = path
                process.Start()
                process.WaitForInputIdle()
            Catch
            End Try
        End Sub
    End Class
End Namespace
