namespace Horizon.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhMuc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaDanhMuc = c.String(),
                        TenDanhMuc = c.String(),
                        LoaiDanhMuc = c.String(),
                        Idx = c.Int(nullable: false),
                        TamNgung = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DonViHanhChinh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaDonViHanhChinh = c.String(),
                        TenDonViHanhChinh = c.String(),
                        CapDonVi = c.Int(nullable: false),
                        CapTren_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DonViHanhChinh", t => t.CapTren_Id)
                .Index(t => t.CapTren_Id);
            
            CreateTable(
                "dbo.DonViVanChuyen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaDonViVanChuyen = c.String(),
                        TenDonViVanChuyen = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                        TamNgung = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoaiSanPham",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaLoaiSanPham = c.String(),
                        TenLoaiSanPham = c.String(),
                        TamNgung = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaNCC = c.String(),
                        TenNhaCungCap = c.String(),
                        DiaChi = c.String(),
                        DienThoai = c.String(),
                        TaiKhoan = c.String(),
                        NguoiLienHe = c.String(),
                        TamNgung = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaNhanVien = c.String(),
                        TenNhanVien = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.String(),
                        DienThoai = c.String(),
                        DiaChi = c.String(),
                        TamNgung = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DonViHanhChinh", "CapTren_Id", "dbo.DonViHanhChinh");
            DropIndex("dbo.DonViHanhChinh", new[] { "CapTren_Id" });
            DropTable("dbo.NhanVien");
            DropTable("dbo.NhaCungCap");
            DropTable("dbo.LoaiSanPham");
            DropTable("dbo.DonViVanChuyen");
            DropTable("dbo.DonViHanhChinh");
            DropTable("dbo.DanhMuc");
        }
    }
}
