using Horizon.Models;
namespace Horizon.DataAccess.Repositories
{
    public class DonViVanChuyenRepository : Repository<DonViVanChuyen>, Interfaces.Repositories.IDonViVanChuyenRepository
    {
        public DonViVanChuyenRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}