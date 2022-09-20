Imports DevExpress.XtraPrinting
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace ReportExportPdfSample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Me.pdfViewer1.CloseDocument()
			Dim report As New XtraReport1()
			Dim pdfOptions As PdfExportOptions = report.ExportOptions.Pdf

			' Specify the pages to export.
			pdfOptions.PageRange = "1, 3-5"

			' Specify the quality of exported images.
			pdfOptions.ConvertImagesToJpeg = False
			pdfOptions.ImageQuality = PdfJpegImageQuality.Medium

			' Specify the PDF/A-compatibility.
			pdfOptions.PdfACompatibility = PdfACompatibility.PdfA3b

			' The following options are not compatible with PDF/A.
			' The use of these options will result in PDF validation errors.
			'pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
			'pdfOptions.ShowPrintDialogOnOpen = true;

			' (Optional) You can specify the security and signature options. 
			'pdfOptions.PasswordSecurityOptions
			'pdfOptions.SignatureOptions

			' (Optional) You can add metadata and attachments,
			' to produce a ZUGFeRD-compatible PDF.
			'pdfOptions.AdditionalMetadata
			'pdfOptions.Attachments

			' Specify the document options.
			pdfOptions.DocumentOptions.Application = "Test Application"
			pdfOptions.DocumentOptions.Author = "DX Documentation Team"
			pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF"
			pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString()
			pdfOptions.DocumentOptions.Subject = "Document Subject"
			pdfOptions.DocumentOptions.Title = "Document Title"

			' Check the validity of PDF export options 
			' and return a list of any detected inconsistencies.
			Dim result As IList(Of String) = pdfOptions.Validate()
			If result.Count > 0 Then
				Console.WriteLine(String.Join(Environment.NewLine, result))
			Else
				report.CreateDocument()
				If ExportOptionsTool.EditExportOptions(pdfOptions, report.PrintingSystem) = DialogResult.OK Then
					report.ExportToPdf("result.pdf", pdfOptions)
					Me.pdfViewer1.LoadDocument("result.pdf")
				End If
			End If
		End Sub
	End Class
End Namespace
