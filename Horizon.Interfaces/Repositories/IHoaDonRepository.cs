using Horizon.Models;
using System;
using System.Collections;

namespace Horizon.Interfaces.Repositories
{
    public interface IHoaDonRepository : IRepository<HoaDon>
    {
        int GetMaxSoHoaDonByDatetime(DateTime datetime);
    }
}
