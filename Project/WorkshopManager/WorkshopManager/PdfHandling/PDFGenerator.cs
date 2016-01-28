using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager
{
    class PDFGenerator
    {
        void generatePDF(Request request)
        {
            //ReportViewer ReportViewer1 = new ReportViewer();
            //ReportViewer1.LocalReport.ReportPath = HttpContext.Current.Server.MapPath(@"\PDFGenerator.rdlc");
            //string owner = request.Owner;
            //DateTime thisDay = DateTime.Today;
            //string pdfNumber = request.ID + "//" + (thisDay.ToString("d"));
            //double totalPrize = request.ListOfParts;
            //ReportParameter data = new ReportParameter("@owner", owner);
            //ReportParameter data = new ReportParameter("@pdf", pdfNumber);
            //byte[] byteViewer = ReportViewer1.LocalReport.Render("PDF");
            //FileStream newFile;

            //string filename = Guid.NewGuid().ToString() + ".pdf";
            //string path = HttpContext.Current.Server.MapPath(@"\") + filename;
            //newFile = new FileStream(path, FileMode.Create);
            //newFile.Write(byteViewer, 0, byteViewer.Length);
            //newFile.Flush();
            //newFile.Close();
        }
    }
}
