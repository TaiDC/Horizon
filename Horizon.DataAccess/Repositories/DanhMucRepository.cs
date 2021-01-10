using Horizon.Models;
using System.Collections.Generic;
using System.Linq;

namespace Horizon.DataAccess.Repositories
{
    public class DanhMucRepository : Repository<DanhMuc>, Interfaces.Repositories.IDanhMucRepository
    {
        public DanhMucRepository(ApplicationDbContext context) : base(context)
        {
        }

        public DanhMuc GetDanhMucByCode(string code)
        {
            return DbSetEntity.Where(dm => dm.MaDanhMuc == code).FirstOrDefault();
        }

        public IEnumerable<DanhMuc> GetListByLoaiSP(string loaidm)
        {
            return DbSetEntity.Where(dm => dm.LoaiDanhMuc == loaidm).ToList();
        }

        public IEnumerable<DanhMuc> GetListHinhThucThanhToan()
        {
            return DbSetEntity.Where(dm => dm.LoaiDanhMuc == "HinhThucThanhToan").ToList();
        }


    }
}