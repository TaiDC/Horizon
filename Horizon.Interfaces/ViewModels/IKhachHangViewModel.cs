using System.Windows.Forms;

namespace Horizon.Interfaces.ViewModels
{
    public interface IKhachHangViewModel : IBaseDictionaryViewModel
    {
        BindingSource TinhBindingSource { get; set; }
        BindingSource HuyenBindingSource { get; set; }
        BindingSource XaBindingSource { get; set; }

    }
}
