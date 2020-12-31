using Horizon.DataAccess.Repositories;
using Horizon.Interfaces;
using Horizon.Interfaces.Repositories;
using System;

namespace Horizon.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;
        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
        }
        public bool SaveChanges()
        {
            bool returnValue = true;
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message      
                    returnValue = false;
                    dbContextTransaction.Rollback();
                }
            }
            return returnValue;
        }

        #region Public Properties  

        private INhanVienRepository nhanVien;
        public INhanVienRepository NhanVien => nhanVien ?? (nhanVien = new NhanVienRepository(_context));

        private INhaCungCapRepository nhaCungCap;
        public INhaCungCapRepository NhaCungCap => nhaCungCap ?? (nhaCungCap = new NhaCungCapRepository(_context));

        private ILoaiSanPhamRepository loaiSanPham;
        public ILoaiSanPhamRepository LoaiSanPham => loaiSanPham ?? (loaiSanPham = new  LoaiSanPhamRepository(_context));

        private IDonViVanChuyenRepository donViVanChuyen;
        public IDonViVanChuyenRepository DonViVanChuyen => donViVanChuyen ?? (donViVanChuyen = new DonViVanChuyenRepository(_context));

        private IDanhMucRepository danhMuc;
        public IDanhMucRepository DanhMuc => danhMuc ?? (danhMuc = new DanhMucRepository(_context));

        private IDonViHanhChinhRepository donViHanhChinh;
        public IDonViHanhChinhRepository DonViHanhChinh => donViHanhChinh ?? (donViHanhChinh = new DonViHanhChinhRepository(_context));

        private IChungTuRepository chungTu;
        public IChungTuRepository ChungTu => chungTu ?? (chungTu = new ChungTuRepository(_context));

        private ISanPhamRepository sanPham;
        public ISanPhamRepository SanPham => sanPham ?? (sanPham = new SanPhamRepository(_context));

        private IKhachHangRepository khachHang;
        public IKhachHangRepository KhachHang => khachHang ?? (khachHang = new KhachHangRepository(_context));

        private IHoaDonRepository hoaDon;
        public IHoaDonRepository HoaDon => hoaDon ?? (hoaDon = new HoaDonRepository(_context));
        private IHoaDonChiTietRepository hoaDonChiTiet;
        public IHoaDonChiTietRepository HoaDonChiTiet => hoaDonChiTiet ?? (hoaDonChiTiet = new HoaDonChiTietRepository(_context));

        #endregion

        #region IDisposable Support  
        private bool _disposedValue = false; // To detect redundant calls  

        protected virtual void Dispose(bool disposing)
        {
            if (_disposedValue) return;

            if (disposing)
            {
                //dispose managed state (managed objects).  
                _context.Dispose();
            }

            // free unmanaged resources (unmanaged objects) and override a finalizer below.  
            // set large fields to null.  

            _disposedValue = true;
        }

        // override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.  
        // ~UnitOfWork() {  
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.  
        //   Dispose(false);  
        // }  

        // This code added to correctly implement the disposable pattern.  
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.  
            Dispose(true);
            // uncomment the following line if the finalizer is overridden above.  
            //GC.SuppressFinalize(this);
        }
        #endregion

    }
}
