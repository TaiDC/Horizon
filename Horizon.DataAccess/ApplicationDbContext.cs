using System.Data.Entity;
using Horizon.Models;
namespace Horizon.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(): base("name=ApplicationConnectionString")
        public ApplicationDbContext() : base(AppHelper.Connection.ConnectionString)
        {
            Database.SetInitializer(new Configuration());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChungTu>()
                .HasMany<SanPham>(s => s.ChungTuChiTiet)
                .WithRequired(sp => sp.ChungTu)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<HoaDon>()
                .HasMany<HoaDonChiTiet>(h => h.HoaDonChiTiet)
                .WithRequired(ct => ct.HoaDon)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
        #region DbSet Entity
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<DonViVanChuyen> DonViVanChuyens { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<DonViHanhChinh> DonViHanhChinhs { get; set; }
        public DbSet<ChungTu> ChungTus { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }


        #endregion
    }
}
