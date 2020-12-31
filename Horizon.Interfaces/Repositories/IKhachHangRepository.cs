using Horizon.Models;
using System;

namespace Horizon.Interfaces.Repositories
{
    public interface IKhachHangRepository : IRepository<KhachHang>
    {
        string InitializationCodeByYear(DateTime datetime);
    }
}
