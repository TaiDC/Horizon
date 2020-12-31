using DevExpress.XtraReports.UI;
using Horizon.Framework;
using Horizon.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Horizon.DataAccess;
using Horizon.Models;
using DevExpress.XtraGrid.Views.Grid;

namespace Horizon.ViewModels
{
    public class BarcodeViewModel : IBarcodeViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public BindingSource BindingSource { get; set; }
        public Command PrintCommand { get; set; }
        public Command ViewCommand { get; set; }
        public GridView GridViewCollection { get; set; }

        public void InitializeView()
        {
            PrintCommand = new Command(PrintExcute);
            ViewCommand = new Command(ViewExcute);
        }

        private void ViewExcute()
        {
            XtraReport report = XtraReport.FromFile(@"Report\\LabelReport.repx", true);
            report.DataSource = GetSelectedView();
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PreviewForm.WindowState = FormWindowState.Maximized;
            printTool.ShowPreviewDialog();
        }

        private void PrintExcute()
        {
            XtraReport report = XtraReport.FromFile(@"Report\\LabelReport.repx", true);
            report.DataSource = GetSelectedView();
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PrintDialog();
        }

        public void Load()
        {
            var lsSPDaBan = UnitOfWork.SanPham.GetSanPhamDaBan();

            var lstSP = UnitOfWork.SanPham.GetList().Except(lsSPDaBan, new SanPhamComparer()).ToList();
            BindingSource.DataSource = lstSP;
        }
        private List<SanPham> GetSelectedView()
        {
            List<SanPham> rs = new List<SanPham>();
            int[] selectedRowHandles = GridViewCollection.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                rs.Add( GridViewCollection.GetRow(selectedRowHandles[i]) as SanPham);
            }
            return rs;
        }
    }
}
