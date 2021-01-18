using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(KhachHang))]
    public class KhachHang : Common.BaseObject
    {
        private string maKhachHang;
        private string tenKhachHang;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string dienThoai;
        private string diaChi;
        private string soTaiKhoan;
        private string ghiChu;
        private string email;
        private string soNha;
        private DonViHanhChinh tinh;
        private DonViHanhChinh huyen;
        private DonViHanhChinh xa;

        [Display(Name = "Mã Khách Hàng")]
        public string MaKhachHang { get => maKhachHang; set => Set(ref maKhachHang, value); }
        [Display(Name = "Họ Tên")]
        public string TenKhachHang { get => tenKhachHang; set => Set(ref tenKhachHang, value); }
        [Display(Name = "Ngày Sinh")]
        public DateTime NgaySinh { get => ngaySinh; set => Set(ref ngaySinh, value); }
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get => gioiTinh; set => Set(ref gioiTinh, value); }
        [Display(Name = "Số Nhà")]
        public string SoNha { get => soNha; set => Set(ref soNha, value); }
        [Display(Name = "Tỉnh")]
        public DonViHanhChinh Tinh { get => tinh; set => Set(ref tinh, value); }
        [Display(Name = "Huyện")]
        public DonViHanhChinh Huyen { get => huyen; set => Set(ref huyen, value); }
        [Display(Name = "Xã")]
        public DonViHanhChinh Xa { get => xa; set => Set(ref xa, value); }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get => DonViHanhChinh.DiaChi(Tinh, Huyen, Xa, SoNha); set => Set(ref diaChi, value); }
        [Display(Name = "Điện Thoại")]
        public string DienThoai { get => dienThoai; set => Set(ref dienThoai, value); }
        [Display(Name = "Email")]
        public string Email { get => email; set => Set(ref email, value); }
        [Display(Name = "Số Tài Khoản")]
        public string SoTaiKhoan { get => soTaiKhoan; set => Set(ref soTaiKhoan, value); }
        [Display(Name = "Ghi Chú")]
        public string GhiChu { get => ghiChu; set => Set(ref ghiChu, value); }
    }
}
