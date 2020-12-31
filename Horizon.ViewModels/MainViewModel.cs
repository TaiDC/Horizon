using Horizon.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horizon.Interfaces;
using Horizon.DataAccess;
using System.Windows.Forms;

namespace Horizon.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public void BC_001_NhapXuatTon(DateTime tungay, DateTime denngay)
        {
            BindingSource bindingsource = new BindingSource();
            var query = (from s in UnitOfWork.SanPham.GetList()
                          join hdct in UnitOfWork.HoaDonChiTiet.GetList() on s.Id equals hdct.SanPham.Id into sgroup
                          from ct in sgroup.DefaultIfEmpty()
                         select new
                         {
                             NgayChungTu = s.ChungTu.NgayChungTu
                             ,MaSanPham = s.MaSanPham
                             ,TenSanPham =s.LoaiSanPham.TenLoaiSanPham
                             ,DonGiaNhap = s.DonGiaNhap
                             ,NgayHoaDon = (ct==null) ? "": ct.HoaDon.NgayHoaDon.ToString("dd/MM/yyyy")
                             ,DonGiaBan = (ct==null)?"": ct.DonGiaBan.ToString("n0")
                         }
                         ).Where(rs=>rs.NgayChungTu >=tungay && rs.NgayChungTu<= denngay );
            bindingsource.DataSource = query.ToList();
            AppHelper.PrintHelper.ViewReport(bindingsource, "BC_001_NhapXuatTon");
        }

        public void BC_002_TheKho(DateTime tungay, DateTime denngay)
        {
            BindingSource bindingsource = new BindingSource();
            AppHelper.PrintHelper.ViewReport(bindingsource, "BC_002_TheKho");
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
