using Horizon.Interfaces.Repositories;
using Horizon.Models;
using System;
using System.Linq;

namespace Horizon.DataAccess.Repositories
{
    public class HoaDonRepository : Repository<HoaDon>, IHoaDonRepository
    {
        public HoaDonRepository(ApplicationDbContext context) : base(context)
        {
        }

        public int GetMaxSoHoaDonByDatetime(DateTime datetime)
        {
            var maxSoHoaDon = DbSetEntity.Where(hd => hd.NgayHoaDon.Year == datetime.Year && hd.NgayHoaDon.Month == datetime.Month).Max(ct => ct.SoHoaDon) ?? "0";
            return Convert.ToInt32(maxSoHoaDon);
        }
    }
}
