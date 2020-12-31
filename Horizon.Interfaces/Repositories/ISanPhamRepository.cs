using Horizon.Models;
using System;
using System.Collections.Generic;

namespace Horizon.Interfaces.Repositories
{
    public interface ISanPhamRepository : IRepository<SanPham>
    {
        int GetMaxSoSanPhamByLoaiAndDateTime(LoaiSanPham loaiSanPham, DateTime dateTime);
        ICollection<SanPham> GetSanPhamDaBan();
    }
}
