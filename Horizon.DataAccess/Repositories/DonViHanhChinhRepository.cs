using Horizon.Models;
using Horizon.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Horizon.DataAccess.Repositories
{
    public class DonViHanhChinhRepository : Repository<DonViHanhChinh>, IDonViHanhChinhRepository
    {
        public DonViHanhChinhRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<DonViHanhChinh> GetListByCapTren(DonViHanhChinh capTren)
        {
            return DbSetEntity.Where(dm => dm.CapTren.Id == capTren.Id).ToList();
        }
    }
}
