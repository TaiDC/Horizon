using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Horizon.AppHelper
{
    public static class PrintHelper
    {
        private static readonly string reportPatch = @"Report\\";
        public static void PrintReport(IEnumerable<object> source, string reportName)
        {
            XtraReport report = XtraReport.FromFile( $"{reportPatch}{reportName}.repx", true);
            report.DataSource = source;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PrintDialog();
        }
        public static void ViewReport(IEnumerable<object> source, string reportName)
        {
            XtraReport report = XtraReport.FromFile( $"{reportPatch}{reportName}.repx", true);
            report.DataSource = source;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PreviewForm.WindowState = FormWindowState.Maximized;
            printTool.ShowPreviewDialog();
        }
        public static void PrintReport(BindingSource bindingSource, string reportName)
        {
            XtraReport report = XtraReport.FromFile($"{reportPatch}{reportName}.repx", true);
            report.DataSource = bindingSource;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PrintDialog();
        }
        public static void ViewReport(BindingSource bindingSource, string reportName)
        {
            XtraReport report = XtraReport.FromFile($"{reportPatch}{reportName}.repx", true);
            report.DataSource = bindingSource;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PreviewForm.WindowState = FormWindowState.Maximized;
            printTool.ShowPreviewDialog();
        }
    }
}
