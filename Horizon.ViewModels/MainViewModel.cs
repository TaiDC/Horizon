using Horizon.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horizon.Interfaces;
using Horizon.DataAccess;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Horizon.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public void BC_001_NhapXuatTon(DateTime tungay, DateTime denngay)
        {
            var ttdtt = UnitOfWork.DanhMuc.TrangThaiDaThanhToan();
            var query = (from s in UnitOfWork.SanPham.GetList()
                          join hdct in UnitOfWork.HoaDonChiTiet.GetList(hdct=>hdct.HoaDon.HuyHoaDon==false && hdct.HoaDon.HoanTraHoaDon==false && hdct.HoaDon.TinhTrang.Id == ttdtt.Id) on s.Id equals hdct.SanPham.Id into sgroup
                          from ct in sgroup.DefaultIfEmpty()
                         select new
                         {
                             NgayChungTu = s.ChungTu.NgayChungTu
                             ,MaSanPham = s.MaSanPham
                             ,TenSanPham =s.LoaiSanPham.TenLoaiSanPham
                             ,DonGiaNhap = s.DonGiaNhap
                             ,NgayHoaDon = (ct==null) ? "": ct.HoaDon.NgayHoaDon.ToString("dd/MM/yyyy")
                             ,DonGiaBan = (ct==null)? 0 : ct.DonGiaBan
                         }
                         ).Where(rs=>rs.NgayChungTu >=tungay && rs.NgayChungTu<= denngay );
            AppHelper.PrintHelper.ViewReport(query, "BC_001_NhapXuatTon");
        }

        public void BC_002_TheKho(DateTime tungay, DateTime denngay)
        {
            var ttdtt = UnitOfWork.DanhMuc.TrangThaiDaThanhToan();
            var query = UnitOfWork.HoaDonChiTiet.GetList(hdct => hdct.HoaDon.HuyHoaDon == false && hdct.HoaDon.HoanTraHoaDon == false && hdct.HoaDon.TinhTrang.Id == ttdtt.Id
            && hdct.HoaDon.NgayHoaDon >= tungay && hdct.HoaDon.NgayHoaDon <= denngay);
            XtraReport report = XtraReport.FromFile(@"Report\BC_002_TheKho.repx", true);
            var rb= report.Band.Controls[1].Controls["crosstab"] as XRCrossTab ;
            rb.DataSource = query;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PreviewForm.WindowState = FormWindowState.Maximized;
            printTool.ShowPreviewDialog();
        }

        public void Load()
        {
            using (IUnitOfWork unitOfWork = new UnitOfWork())
            {
                var lst = unitOfWork.DanhMuc.GetList();
            }
        }
    }
}
