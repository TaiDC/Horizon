using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.Models
{
    [Table(nameof(HoaDon))]
    public class HoaDon : Common.BaseObject
    {
        private string maHoaDon;
        private string soHoaDon;
        private DateTime ngayHoaDon;
        private double thanhTien;
        private NhanVien nguoiXuat;
        private DanhMuc tinhTrang;
        private bool huyHoaDon;
        private bool daThanhToan;
        private bool daChuyen;
        private bool hoanTraHoaDon;
        private DanhMuc hinhThucThanhToan;
        private DonViVanChuyen donViVanChuyen;
        private KhachHang khachHang;
        private string ghiChu;

        public HoaDon()
        {
            HoaDonChiTiet = new HashSet<HoaDonChiTiet>();
        }
        [Display(Name = "Mã Hóa Đơn")]
        public string MaHoaDon { get => maHoaDon; set => Set(ref maHoaDon, value); }
        [Display(Name = "Số Hóa Đơn")]
        public string SoHoaDon { get => soHoaDon; set => Set(ref soHoaDon, value); }
        [Display(Name = "Ngày Hóa Đơn")]
        public DateTime NgayHoaDon { get => ngayHoaDon; set => Set(ref ngayHoaDon, value); }
        [Display(Name = "Thành Tiền")]
        public double ThanhTien { get => thanhTien; set => Set(ref thanhTien, value); }
        [Display(Name = "Nhân Viên Xuất")]
        public virtual NhanVien NguoiXuat { get => nguoiXuat; set => Set(ref nguoiXuat, value); }
        [Display(Name = "Tình Trạng")]
        public virtual DanhMuc TinhTrang { get => tinhTrang; set => Set(ref tinhTrang, value); }
        //Trạng Thái đơn hàng
        [Display(Name = "Đã Thanh Toán")]
        public bool DaThanhToan { get => daThanhToan; set => Set(ref daThanhToan, value); }
        [Display(Name = "Hủy")]
        public bool HuyHoaDon { get => huyHoaDon; set => Set(ref huyHoaDon, value); }
        [Display(Name = "Đã Chuyển")]
        public bool DaChuyen { get => daChuyen; set => Set(ref daChuyen, value); }
        [Display(Name = "Hoàn Trả")]
        public bool HoanTraHoaDon { get => hoanTraHoaDon; set => Set(ref hoanTraHoaDon, value); }


        [Display(Name = "Hình Thức Thanh Toán")]
        public virtual DanhMuc HinhThucThanhToan { get => hinhThucThanhToan; set => Set(ref hinhThucThanhToan, value); }
        [Display(Name = "Đơn Vị Vận Chuyển")]
        public virtual DonViVanChuyen DonViVanChuyen { get => donViVanChuyen; set => Set(ref donViVanChuyen, value); }
        [Display(Name = "Khách Hàng")]
        public virtual KhachHang KhachHang { get => khachHang; set => Set(ref khachHang, value); }
        [Display(Name = "Ghi Chú")]
        public string GhiChu { get => ghiChu; set => Set(ref ghiChu, value); }

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }


    }
}
