using DevExpress.XtraEditors;
using Horizon.Framework;
using System.Windows.Forms;

namespace Horizon.Interfaces.ViewModels
{
    public interface IHoaDonViewModel : IBaseDictionaryViewModel
    {
        GridLookUpEdit LookUpEditHoaDon { get; set; }
        BindingSource BindingSourceChiTiet { get; set; }
        BindingSource BindingSourceKhachHang { get; set; }
        BindingSource BindingSourceSanPham { get; set; }
        BindingSource BindingSourceNhanVien { get; set; }
        BindingSource BindingSourceHinhThucThanhToan { get; set; }
        BindingSource BindingSourceDonViVanChuyen { get; set; }

        void ShowHoaDonTimKiem(Views.ITimKiemView timKiemView);
        void ShowKhachHangTimKiem(Views.ITimKiemView timKiemView);

        void SetBindingSoucreByMaKhachHang(string maKH);
        void NewSanPham(object loaiSanPham, object donGia);
        void DeleteSanPham();

        Command PrintCommand { get; set; }
        Command PrintViewCommand { get; set; }

        Command PaymentCommand { get; set; }
        Command CancelCommand { get; set; }
        Command RefundCommand { get; set; }
        Command DeliveredCommand { get; set; }

    }
}
