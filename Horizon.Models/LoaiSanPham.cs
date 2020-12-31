using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(LoaiSanPham))]
    public class LoaiSanPham : Common.BaseObject
    {
        private string maLoaiSanPham;
        private string tenLoaiSanPham;
        private bool tamNgung;

        [Display(Name = "Mã Loại SP")]
        public string MaLoaiSanPham { get => maLoaiSanPham; set => Set(ref maLoaiSanPham, value); }
        [Display(Name = "Tên Loại SP")]
        public string TenLoaiSanPham { get => tenLoaiSanPham; set => Set(ref tenLoaiSanPham, value); }
        [Display(Name = "Tạm Ngưng")]
        public bool TamNgung { get => tamNgung; set => Set(ref tamNgung, value); }
    }
}
