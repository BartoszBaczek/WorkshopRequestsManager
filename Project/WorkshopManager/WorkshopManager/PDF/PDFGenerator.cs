using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace WorkshopManager
{
    class PDFGenerator
    {
        public void PDFGenerate(Request request)
        {
            ReportViewer ReportViewer1 = new ReportViewer();
            ReportViewer1.LocalReport.ReportEmbeddedResource = "WorkshopManager.PDF.PDF.rdlc";
            DateTime thisDay = DateTime.Today;
            string numberPDF = thisDay.ToString("d") + '/' + request.ID;
            ReportParameter owner = new ReportParameter("owner", request.Owner);
            ReportParameter pdfno = new ReportParameter("pdfno", numberPDF);

            ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { owner, pdfno });
            byte[] byteViewer = ReportViewer1.LocalReport.Render("PDF");
            FileStream newFile;
            string filename = request.ID.ToString() + ".pdf";
            string path = "C:\\Users\\Rafał\\Desktop" + filename;
            newFile = new FileStream(path, FileMode.Create);
            newFile.Write(byteViewer, 0, byteViewer.Length);
            newFile.Flush();
            newFile.Close();
        }
    }
}