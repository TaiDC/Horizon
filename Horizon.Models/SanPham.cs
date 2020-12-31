using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon.Models
{
    [Table(nameof(SanPham))]
    public class SanPham : Common.BaseObject
    {
        private string maSanPham;
        private string soSanPham;
        private ChungTu chungTu;
        private LoaiSanPham loaiSanPham;
        private double donGiaNhap;

        [Display(Name = "Mã Sản Phẩm")]
        public string MaSanPham { get => maSanPham; set => Set(ref maSanPham, value); }
        [Display(Name = "Số Sản Phẩm")]
        public string SoSanPham { get => soSanPham; set => Set(ref soSanPham, value); }
        [Display(Name = "Chứng Từ")]
        public ChungTu ChungTu { get => chungTu; set => Set(ref chungTu, value); }
        [Display(Name = "Loại Sản Phẩm")]
        public virtual LoaiSanPham LoaiSanPham { get => loaiSanPham; set => Set(ref loaiSanPham, value); }
        [Display(Name = "Đơn Giá Nhập")]
        public double DonGiaNhap { get => donGiaNhap; set => Set(ref donGiaNhap, value); }
    }
    public class SanPhamComparer : System.Collections.Generic.IEqualityComparer<SanPham>
    {
        public bool Equals(SanPham x, SanPham y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(SanPham obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
