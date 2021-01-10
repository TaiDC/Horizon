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
            AppHelper.PrintHelper.ViewReport(GetSelectedView(), "LabelReport");
        }

        private void PrintExcute()
        {
            AppHelper.PrintHelper.PrintReport(GetSelectedView(), "LabelReport");
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
