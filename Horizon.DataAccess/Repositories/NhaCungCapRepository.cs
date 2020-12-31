using Horizon.Models;
using Horizon.Interfaces.Repositories;
namespace Horizon.DataAccess.Repositories
{
    public class NhaCungCapRepository : Repository<NhaCungCap> , INhaCungCapRepository
    {
        public NhaCungCapRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
