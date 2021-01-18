using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Horizon.Interfaces.ViewModels;
using Unity;

namespace Horizon.App
{
    public partial class TheoDoiDonHangView : DevExpress.XtraEditors.XtraUserControl
    {
        ITheoDoiDonHangViewModel _vm = Config.Container.Resolve<ITheoDoiDonHangViewModel>();
        public TheoDoiDonHangView()
        {
            InitializeComponent();
            _vm.BindingSource = hoaDonBindingSource;
            Load += delegate { _vm.Load(); };
        }
    }
}
