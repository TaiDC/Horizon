using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Horizon.App
{
    public partial class TimKiemView : DevExpress.XtraEditors.XtraForm ,Interfaces.Views.ITimKiemView
    {
        public TimKiemView()
        {
            InitializeComponent();
            gridControl.MouseDoubleClick += delegate { this.DialogResult = DialogResult.OK; };
        }

        public BindingSource BindingSource { get => bindingSource; set => bindingSource = value; }
        public GridView GridView { get => gridView1; set => gridView1 = value; }

        public DialogResult ShowFindDialog()
        {
            return this.ShowDialog();
        }
    }
}