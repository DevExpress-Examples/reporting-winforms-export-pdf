using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
// ...

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // A path to export a report.
            string reportPath = @"c:\\Temp\Test.pdf";

            using (XtraReport1 report = new XtraReport1()) {
                // Specify PDF-specific export options.
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;

                // Specify the pages to be exported.
                pdfOptions.PageRange = "1, 3-5";

                // Specify the quality of exported images.
                pdfOptions.ConvertImagesToJpeg = false;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Medium;

                // Specify the PDF/A-compatibility.
                pdfOptions.PdfACompatibility = PdfACompatibility.PdfA3b;

                // The following options are not compatible with PDF/A.
                // The use of these options will result in errors on PDF validation.
                //pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                //pdfOptions.ShowPrintDialogOnOpen = true;

                // If required, you can specify the security and signature options. 
                //pdfOptions.PasswordSecurityOptions
                //pdfOptions.SignatureOptions

                // If required, specify necessary metadata and attachments
                // (e.g., to produce a ZUGFeRD-compatible PDF).
                //pdfOptions.AdditionalMetadata
                //pdfOptions.Attachments

                // Specify the document options.
                pdfOptions.DocumentOptions.Application = "Test Application";
                pdfOptions.DocumentOptions.Author = "DX Documentation Team";
                pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
                pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
                pdfOptions.DocumentOptions.Subject = "Document Subject";
                pdfOptions.DocumentOptions.Title = "Document Title";

                // Checks the validity of PDF export options 
                // and return a list of any detected inconsistencies.
                IList<string> result = pdfOptions.Validate();
                if (result.Count > 0)
                    Console.WriteLine(String.Join(Environment.NewLine, result));
                else
                    report.ExportToPdf(reportPath, pdfOptions);
            }

        }

    }
}
