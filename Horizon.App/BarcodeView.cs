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
    public partial class BarcodeView : DevExpress.XtraEditors.XtraUserControl
    {
        IBarcodeViewModel _vm = Config.Container.Resolve<IBarcodeViewModel>();
        public BarcodeView()
        {
            InitializeComponent();
            #region Initialize ViewModel
            _vm.BindingSource = bindingSource;
            _vm.GridViewCollection = gridView1;
            _vm.InitializeView();
            Load += delegate { _vm.Load(); };
            #endregion
            #region Button Command
            barButtonPrint.ItemClick += delegate { _vm.PrintCommand.Execute(); };
            barButtonView.ItemClick += delegate { _vm.ViewCommand.Execute(); };
            btnClose.ItemClick += delegate { this.Parent.Controls.Remove(this); this.Dispose(); };
            #endregion
        }
    }
}
