using Horizon.Interfaces.Repositories;
using Horizon.Models;
using System;
using System.Linq;

namespace Horizon.DataAccess.Repositories
{
    public class KhachHangRepository : Repository<KhachHang>, IKhachHangRepository
    {
        public KhachHangRepository(ApplicationDbContext context) : base(context)
        {
        }

        public string InitializationCodeByYear(DateTime datetime)
        {
            string code = "";
            var maxCode = DbSetEntity.Where(kh => kh.DateCreate.Value.Year == datetime.Year).Max(kh => kh.MaKhachHang);
            if (maxCode == null) maxCode = 0.ToString("D4");
            var num = Convert.ToInt32(maxCode.Substring(2)) +1;
            code = datetime.ToString("yy") + num.ToString("D4");
            return code;
        }
    }
}
