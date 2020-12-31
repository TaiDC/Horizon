using System;
using System.Threading.Tasks;
using Horizon.Interfaces.Repositories;

namespace Horizon.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        INhanVienRepository NhanVien { get; }
        INhaCungCapRepository NhaCungCap { get; }
        ILoaiSanPhamRepository LoaiSanPham { get; }
        IDonViVanChuyenRepository DonViVanChuyen { get; }
        IDanhMucRepository DanhMuc { get; }
        IChungTuRepository ChungTu { get; }
        ISanPhamRepository SanPham { get; }
        IKhachHangRepository KhachHang { get; }
        IHoaDonRepository HoaDon { get; }
        IHoaDonChiTietRepository HoaDonChiTiet { get; }

        bool SaveChanges();
    }
}
