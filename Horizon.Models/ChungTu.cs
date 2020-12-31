using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(ChungTu))]
    public class ChungTu : Common.BaseObject
    {
        private string maChungTu;
        private string soChungTu;
        private DateTime ngayChungTu;
        private string soHoaDon;
        private DateTime ngayHoaDon;
        private string ghiChu;
        private double tongTien;
        private NhanVien nguoiNhap;
        private NhaCungCap nhaCungCap;

        public ChungTu()
        {
            ChungTuChiTiet = new HashSet<SanPham>();
        }

        [Display(Name = "Mã Chứng Từ")]
        public string MaChungTu { get => maChungTu; set => Set(ref maChungTu, value); }
        [Display(Name = "Số Chứng Từ")]
        public string SoChungTu { get => soChungTu; set => Set(ref soChungTu, value); }
        [Display(Name = "Ngày Chứng Từ")]
        public DateTime NgayChungTu { get => ngayChungTu; set => Set(ref ngayChungTu, value); }
        [Display(Name = "Số Hóa Đơn")]
        public string SoHoaDon { get => soHoaDon; set => Set(ref soHoaDon, value); }
        [Display(Name = "Ngày Hóa Đơn")]
        public DateTime NgayHoaDon { get => ngayHoaDon; set => Set(ref ngayHoaDon, value); }
        [Display(Name = "Ghi Chú")]
        public string GhiChu { get => ghiChu; set => Set(ref ghiChu, value); }
        [Display(Name = "Tổng Tiền")]
        public double TongTien { get => tongTien; set => Set(ref tongTien, value); }
        [Display(Name = "Người Nhập")]
        public virtual NhanVien NguoiNhap { get => nguoiNhap; set => Set(ref nguoiNhap, value); }
        [Display(Name = "Nhà Cung Cấp")]
        public virtual NhaCungCap NhaCungCap { get => nhaCungCap; set => Set(ref nhaCungCap, value); }

        public virtual ICollection<SanPham> ChungTuChiTiet { get; set; }

    }
}
