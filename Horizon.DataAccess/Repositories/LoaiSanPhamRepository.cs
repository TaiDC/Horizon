using Horizon.Models;
namespace Horizon.DataAccess.Repositories
{
    public class LoaiSanPhamRepository : Repository<LoaiSanPham>, Interfaces.Repositories.ILoaiSanPhamRepository
    {
        public LoaiSanPhamRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
