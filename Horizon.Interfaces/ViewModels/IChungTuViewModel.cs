using Horizon.Models;
using System.Collections.Generic;
using Horizon.Framework;
using System.Windows.Forms;

namespace Horizon.Interfaces.ViewModels
{
    public interface IChungTuViewModel : IBaseDictionaryViewModel
    {
        BindingSource BindingSourceChiTiet { get; set; }
        BindingSource BindingSourceNhanVien { get; set; }
        BindingSource BindingSourceNhaCungCap { get; set; }
        BindingSource BindingSourceLoaiSanPham { get; set; }

        void ShowTimKiem(Views.ITimKiemView timKiemView);
        void NewSanPham(object loaiSanPham, object donGia);
        void DeleteSanPham();

        Command PrintCommand { get; set; }
        Command PrintViewCommand { get; set; }
    }
}
