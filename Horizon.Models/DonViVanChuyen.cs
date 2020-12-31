using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(DonViVanChuyen))]
    public class DonViVanChuyen : Common.BaseObject
    {
        private string maDonViVanChuyen;
        private string tenDonViVanChuyen;
        private string soDienThoai;
        private string diaChi;
        private bool tamNgung;

        [Display(Name = "Mã ĐVVC")]
        public string MaDonViVanChuyen { get => maDonViVanChuyen; set => Set(ref maDonViVanChuyen, value); }
        [Display(Name = "Tên ĐVVC")]
        public string TenDonViVanChuyen { get => tenDonViVanChuyen; set => Set(ref tenDonViVanChuyen, value); }
        [Display(Name = "Số Điện Thoại")]
        public string SoDienThoai { get => soDienThoai; set => Set(ref soDienThoai, value); }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get => diaChi; set => Set(ref diaChi, value); }
        [Display(Name = "Tạm Ngưng")]
        public bool TamNgung { get => tamNgung; set => Set(ref tamNgung, value); }
    }
}
