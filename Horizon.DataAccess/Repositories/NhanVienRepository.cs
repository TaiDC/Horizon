using Horizon.Models;
namespace Horizon.DataAccess.Repositories
{
    public class NhanVienRepository : Repository<NhanVien>, Interfaces.Repositories.INhanVienRepository
    {
        public NhanVienRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
