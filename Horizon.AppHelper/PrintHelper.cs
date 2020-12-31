using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizon.AppHelper
{
    public static class PrintHelper
    {
        private static readonly string reportPatch = @"Report\\";
        public static void PrintReport(BindingSource bindingSource, string reportName)
        {
            XtraReport report = XtraReport.FromFile( $"{reportPatch}{reportName}.repx", true);
            report.DataSource = bindingSource;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PrintDialog();
        }
        public static void ViewReport(BindingSource bindingSource, string reportName)
        {
            XtraReport report = XtraReport.FromFile( $"{reportPatch}{reportName}.repx", true);
            report.DataSource = bindingSource;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PreviewForm.WindowState = FormWindowState.Maximized;
            printTool.ShowPreviewDialog();
        }
    }
}
