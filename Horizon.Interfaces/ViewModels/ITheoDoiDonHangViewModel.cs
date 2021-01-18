using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizon.Interfaces.ViewModels
{
    public interface ITheoDoiDonHangViewModel
    {
        BindingSource BindingSource { get; set; }
        void Load();
        void InitializeView();
    }
}
