using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReportExportPdfSample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.pdfViewer1.CloseDocument();
            XtraReport1 report = new XtraReport1();
            PdfExportOptions pdfOptions = report.ExportOptions.Pdf;

            // Specify the pages to export.
            pdfOptions.PageRange = "1, 3-5";

            // Specify the quality of exported images.
            pdfOptions.ConvertImagesToJpeg = false;
            pdfOptions.ImageQuality = PdfJpegImageQuality.Medium;

            // Specify the PDF/A-compatibility.
            pdfOptions.PdfACompatibility = PdfACompatibility.PdfA3b;

            // The following options are not compatible with PDF/A.
            // The use of these options will result in PDF validation errors.
            //pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
            //pdfOptions.ShowPrintDialogOnOpen = true;

            // (Optional) You can specify the security and signature options. 
            //pdfOptions.PasswordSecurityOptions
            //pdfOptions.SignatureOptions

            // (Optional) You can add metadata and attachments,
            // to produce a ZUGFeRD-compatible PDF.
            //pdfOptions.AdditionalMetadata
            //pdfOptions.Attachments

            // Specify the document options.
            pdfOptions.DocumentOptions.Application = "Test Application";
            pdfOptions.DocumentOptions.Author = "DX Documentation Team";
            pdfOptions.DocumentOptions.Keywords = "DevExpress, Reporting, PDF";
            pdfOptions.DocumentOptions.Producer = Environment.UserName.ToString();
            pdfOptions.DocumentOptions.Subject = "Document Subject";
            pdfOptions.DocumentOptions.Title = "Document Title";

            // Check the validity of PDF export options 
            // and return a list of any detected inconsistencies.
            IList<string> result = pdfOptions.Validate();
            if (result.Count > 0)
                Console.WriteLine(String.Join(Environment.NewLine, result));
            else
            {
                report.CreateDocument();
                if (ExportOptionsTool.EditExportOptions(pdfOptions, report.PrintingSystem)
                    == DialogResult.OK) {
                    report.ExportToPdf("result.pdf", pdfOptions);
                    this.pdfViewer1.LoadDocument("result.pdf");
                }
            }
        }
    }
}
