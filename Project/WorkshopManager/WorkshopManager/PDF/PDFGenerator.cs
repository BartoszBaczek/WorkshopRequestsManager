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
using WorkshopManager.Models;

namespace WorkshopManager
{
    class PDFGenerator
    {
        public void PDFGenerate(Request request)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    ReportViewer ReportViewer1 = new ReportViewer();
                    ReportViewer1.LocalReport.ReportEmbeddedResource = "WorkshopManager.PDF.PDF.rdlc";
                    var parts = Request.GetAllParts(request);
                    ReportViewer1.LocalReport.DataSources.Add(new
                    Microsoft.Reporting.WinForms.ReportDataSource()
                    {
                        Name = "DataSetListOfParts",
                        Value = parts
                    });
                    
                    DateTime thisDay = DateTime.Today;
                    string numberPDF = thisDay.ToString("dd'/'MM'/'yyyy") + '/' + request.ID;
                    ReportParameter owner = new ReportParameter("owner", request.Owner);
                    ReportParameter pdfno = new ReportParameter("pdfno", numberPDF);
                    ReportParameter date = new ReportParameter("date", thisDay.ToString("d"));
                    double tempcost1 = request.ListOfParts.Count() * 100;
                    string repaircost = Convert.ToString(tempcost1);
                    ReportParameter repairprize = new ReportParameter("repaircost", repaircost);
                    string partscost = request.GetTotalPrize().ToString();
                    double tempcost2 = Convert.ToDouble(partscost) + Convert.ToDouble(repaircost);
                    string totalcost = Convert.ToString(tempcost2);
                    ReportParameter totalprize = new ReportParameter("totalprize", totalcost);
                    ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { owner, pdfno, date, repairprize, totalprize });
                    byte[] byteViewer = ReportViewer1.LocalReport.Render("PDF");
                    myStream.Write(byteViewer, 0, byteViewer.Length);
                    myStream.Close();
                }
            }
        }

    }
}