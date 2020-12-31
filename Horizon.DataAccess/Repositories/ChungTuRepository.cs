using Horizon.Models;
using System;
using System.Linq;
using Horizon.Interfaces.Repositories;

namespace Horizon.DataAccess.Repositories
{
    public class ChungTuRepository : Repository<ChungTu>, IChungTuRepository
    {
        public ChungTuRepository(ApplicationDbContext context) : base(context)
        {
        }

        public int GetMaxSoChungTuByDatetime(DateTime datetime)
        {
            var maxSoChungTu= DbSetEntity.Where(ct => ct.NgayChungTu.Year == datetime.Year && ct.NgayChungTu.Month == datetime.Month).Max(ct => ct.SoChungTu) ?? "0";
            return Convert.ToInt32(maxSoChungTu);
        }
    }
}
