using Horizon.Models;
using System.Collections.Generic;

namespace Horizon.Interfaces.Repositories
{
    public interface IDonViHanhChinhRepository : IRepository<DonViHanhChinh>
    {
        IEnumerable<DonViHanhChinh> GetListByCapTren(DonViHanhChinh capTren);
    }
}
