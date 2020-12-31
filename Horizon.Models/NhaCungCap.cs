using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(NhaCungCap))]
    public class NhaCungCap : Common.BaseObject
    {
        private string maNCC;
        private string tenNhaCungCap;
        private string diaChi;
        private string dienThoai;
        private string taiKhoan;
        private string nguoiLienHe;
        private bool tamNgung;

        [Display(Name = "Mã NCC")]
        public string MaNCC { get => maNCC; set => Set(ref maNCC, value); }
        [Display(Name = "Tên NCC")]
        public string TenNhaCungCap { get => tenNhaCungCap; set => Set(ref tenNhaCungCap, value); }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get => diaChi; set => Set(ref diaChi, value); }
        [Display(Name = "Điện Thoại")]
        public string DienThoai { get => dienThoai; set => Set(ref dienThoai, value); }
        [Display(Name = "Tài Khoản")]
        public string TaiKhoan { get => taiKhoan; set => Set(ref taiKhoan, value); }
        [Display(Name = "Người Liên Hệ")]
        public string NguoiLienHe { get => nguoiLienHe; set => Set(ref nguoiLienHe, value); }
        [Display(Name = "Tạm Ngưng")]
        public bool TamNgung { get => tamNgung; set => Set(ref tamNgung, value); }
    }
}
