using System;
using System.Windows.Forms;
using WorkshopManager.Forms.RequestsDatabaseView;

namespace WorkshopManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RequestsDatabaseView());
        }
    }
}