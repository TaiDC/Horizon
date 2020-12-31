using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(NhanVien))]
    public class NhanVien : Common.BaseObject
    {
        private string maNhanVien;
        private string tenNhanVien;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string dienThoai;
        private string diaChi;
        private bool tamNgung;

        [Display(Name = "Mã NV")]
        public string MaNhanVien { get => maNhanVien; set => Set(ref maNhanVien , value); }
        [Display(Name = "Họ Tên")]
        public string TenNhanVien { get => tenNhanVien; set => Set(ref tenNhanVien, value); }
        [Display(Name = "Ngày Sinh")]
        public DateTime NgaySinh { get => ngaySinh; set => Set(ref ngaySinh, value); }
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get => gioiTinh; set => Set(ref gioiTinh, value); }
        [Display(Name = "Điện Thoại")]
        public string DienThoai { get => dienThoai; set => Set(ref dienThoai, value); }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get => diaChi; set => Set(ref diaChi, value); }
        [Display(Name = "Tạm Ngưng")]
        public bool TamNgung { get => tamNgung; set => Set(ref tamNgung, value); }

    }
}
