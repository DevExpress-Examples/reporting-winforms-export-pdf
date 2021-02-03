Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System

Namespace PdfExportExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a report.
			Dim report As New XtraReport() With {
				.Name = "Report Example",
				.Bands = {
					New DetailBand() With {
						.Controls = {
							New XRLabel() With {.Text = "Some content goes here..."}
						}
					}
				}
			}

			' Specify export options.
			Dim pdfExportOptions As New PdfExportOptions() With {.PdfACompatibility = PdfACompatibility.PdfA1b}

			' Specify the path for the exported PDF file.  
			Dim pdfExportFile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\" & report.Name & ".pdf"

			' Export the report.
			report.ExportToPdf(pdfExportFile, pdfExportOptions)
		End Sub
	End Class
End Namespace
