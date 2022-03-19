using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SimpleInvoice.Models.ViewModels;
using SimpleInvoice.PDF;
namespace SimpleInvoice
{
    public  class PDFServices
    {

        public void RotatePDF(PdfPageRotateAngle angle
            ,string oldFilename,string newFileName)
        {

            //Load a PDF document
            PdfLoadedDocument ldoc = new PdfLoadedDocument(oldFilename);
            //Create a new instance of PdfDocument class 
            PdfDocument doc = new PdfDocument();
            //Set document rotation angle as 90 degrees
            doc.PageSettings.Rotate = angle;
            
            //Import PDF document
            doc.ImportPageRange(ldoc, 0, ldoc.Pages.Count - 1);
            //Save and Close the document
            doc.Save(newFileName );
            doc.Close(true);
        }
     


        public void SavePdf(string filePath,InvoicesViewModel model)
        {
            var document = new InvoiceDocument(model);
            document.GeneratePdf(filePath);

        }
    }
}
