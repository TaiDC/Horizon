using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Models
{
    [Table(nameof(HoaDonChiTiet))]
    public class HoaDonChiTiet : Common.BaseObject
    {
        private SanPham sanPham;
        private HoaDon hoaDon;
        private double donGiaBan;

        [Display(Name = "Sản Phẩm")]
        public virtual SanPham SanPham { get => sanPham; set => sanPham = value; }
        [Display(Name = "Hóa Đơn")]
        public virtual HoaDon HoaDon { get => hoaDon; set => hoaDon = value; }
        [Display(Name = "Đơn Giá Bán")]
        public double DonGiaBan { get => donGiaBan; set => Set(ref donGiaBan, value); }
    }
}
