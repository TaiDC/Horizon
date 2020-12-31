using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(DanhMuc))]
    public class DanhMuc : Common.BaseObject
    {
        private string maDanhMuc;
        private string tenDanhMuc;
        private string loaiDanhMuc;
        private int idx;
        private bool tamNgung;

        [Display(Name = "Mã Danh Mục")]
        public string MaDanhMuc { get => maDanhMuc; set => Set(ref maDanhMuc, value); }
        [Display(Name = "Tên Danh Mục")]
        public string TenDanhMuc { get => tenDanhMuc; set => Set(ref tenDanhMuc, value); }
        [Display(Name = "Loại Danh Mục")]
        public string LoaiDanhMuc { get => loaiDanhMuc; set => Set(ref loaiDanhMuc, value); }
        [Display(Name = "Idx")]
        public int Idx { get => idx; set => Set(ref idx, value); }
        [Display(Name = "Tạm Ngưng")]
        public bool TamNgung { get => tamNgung; set => Set(ref tamNgung, value); }
    }
}
