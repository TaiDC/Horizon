namespace Horizon.DataAccess.Repositories
{
    public class HoaDonChiTietRepository : Repository<Models.HoaDonChiTiet>, Interfaces.Repositories.IHoaDonChiTietRepository
    {
        public HoaDonChiTietRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
