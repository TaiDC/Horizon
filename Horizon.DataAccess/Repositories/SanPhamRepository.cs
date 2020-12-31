using System;
using System.Linq;
using Horizon.Models;
using Horizon.Interfaces.Repositories;
using System.Collections.Generic;

namespace Horizon.DataAccess.Repositories
{
    public class SanPhamRepository : Repository<SanPham>, ISanPhamRepository
    {
        public SanPhamRepository(ApplicationDbContext context) : base(context)
        {
        }

        public int GetMaxSoSanPhamByLoaiAndDateTime(LoaiSanPham loaiSanPham, DateTime dateTime)
        {
            string maxsp = DbSetEntity.Where(sp => sp.LoaiSanPham.Id == loaiSanPham.Id && sp.DateCreate.Value.Year == dateTime.Year).Max(sp => sp.SoSanPham) ?? "0";
            return Convert.ToInt32(maxsp);
        }

        public ICollection<SanPham> GetSanPhamDaBan()
        {
            return (from hd in _dataContext.HoaDons.Where(hd => hd.HoanTraHoaDon == false && hd.HuyHoaDon == false)
                             join hdct in _dataContext.HoaDonChiTiets on hd.Id equals hdct.HoaDon.Id
                             select hdct)
                             .Select(hdct=>hdct.SanPham).ToList();
        }
    }
}
