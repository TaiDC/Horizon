using Horizon.Models;
using System.Collections.Generic;

namespace Horizon.Interfaces.Repositories
{
    public interface IDanhMucRepository : IRepository<DanhMuc>
    {
        IEnumerable<DanhMuc> GetListByLoaiSP(string loaidm);
        DanhMuc TrangThaiDaThanhToan();
        DanhMuc TrangThaiChuaThanhToan();
        IEnumerable<DanhMuc> GetListHinhThucThanhToan();
    }
}
