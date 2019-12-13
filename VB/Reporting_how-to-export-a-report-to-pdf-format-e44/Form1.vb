Imports DevExpress.XtraPrinting
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
' ...

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ' A path to export a report.
            Dim reportPath As String = "c:\\Temp\Test.pdf"

            Using report As New XtraReport1()
                ' Specify PDF-specific export options.
                Dim pdfOptions As PdfExportOptions = report.ExportOptions.Pdf

                ' Specify the pages to be exported.
                pdfOptions.PageRange = "1, 3-5"

                ' Specify the quality of exported images.
                pdfOptions.ConvertImagesToJpeg = False
                pdfOptions.ImageQuality = PdfJpegImageQuality.Medium

                ' Specify the PDF/A-compatibility.
                pdfOptions.PdfACompatibility = PdfACompatibility.PdfA3b

                ' The following options are not compatible with PDF/A.
                ' The use of these options will result in errors on PDF validation.
                'pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                'pdfOptions.ShowPrintDialogOnOpen = true;

                ' If required, you can specify the security and signature options. 
                'pdfOptions.PasswordSecurityOptions
                'pdfOptions.SignatureOptions

                ' If required, specify necessary metadata and attachments
                ' (e.g., to produce a ZUGFeRD-compatible PDF).
                'pdfOptions.AdditionalMetadata
                'pdfOptions.Attachments

                ' Specify the document options.
                pdfOptions.DocumentOptions.Application = "Test Application"
                pdfOptions.DocumentOptions.Author = "DX Documentation Team"
                pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF"
                pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString()
                pdfOptions.DocumentOptions.Subject = "Document Subject"
                pdfOptions.DocumentOptions.Title = "Document Title"

                ' Checks the validity of PDF export options 
                ' and return a list of any detected inconsistencies.
                Dim result As IList(Of String) = pdfOptions.Validate()
                If result.Count > 0 Then
                    Console.WriteLine(String.Join(Environment.NewLine, result))
                Else
                    report.ExportToPdf(reportPath, pdfOptions)
                End If
            End Using

        End Sub

    End Class
End Namespace
