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

            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
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
                    ReportParameter pdfno = new ReportParameter("pdfno", numberPDF);
                    ReportParameter owner = new ReportParameter("owner", request.Owner);                    
                    ReportParameter date = new ReportParameter("date", thisDay.ToString("d"));
                    double tempRepairCost = request.ListOfParts.Count() * 100;
                    string repairCost = Convert.ToString(tempRepairCost);
                    ReportParameter repairprize = new ReportParameter("repaircost", repairCost);
                    string partsCost = request.GetTotalPrize().ToString();
                    double tempTotalCost = Convert.ToDouble(partsCost) + Convert.ToDouble(repairCost);
                    string totalCost = Convert.ToString(tempTotalCost);
                    ReportParameter totalPrize = new ReportParameter("totalprize", totalCost);
                    ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { owner, pdfno, date, repairprize, totalPrize });
                    byte[] byteViewer = ReportViewer1.LocalReport.Render("PDF");
                    myStream.Write(byteViewer, 0, byteViewer.Length);
                    myStream.Close();
                }
            }
        }

    }
}