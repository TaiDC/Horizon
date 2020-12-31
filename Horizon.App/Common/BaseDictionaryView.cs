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
using Horizon.AppHelper;
using Unity;
using Horizon.Interfaces.ViewModels;

namespace Horizon.App.Common
{
    public partial class BaseDictionaryView : DevExpress.XtraEditors.XtraUserControl
    {
        public BaseDictionaryView()
        {
            InitializeComponent();

            #region Button Command
            btnClose.ItemClick += delegate { this.Parent.Controls.Remove(this); this.Dispose(); };
            #endregion
        }
        public void NotifyChanged(bool value)
        {
            
        }
    }
}
