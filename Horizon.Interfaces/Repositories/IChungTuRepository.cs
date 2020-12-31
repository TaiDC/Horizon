using Horizon.Models;
using System;

namespace Horizon.Interfaces.Repositories
{
    public interface IChungTuRepository : IRepository<ChungTu>
    {
        int GetMaxSoChungTuByDatetime(DateTime datetime);
    }
}
