using DevExpress.XtraDataLayout;
using DevExpress.XtraGrid;
using Horizon.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizon.Interfaces.ViewModels
{
    public interface IBaseDictionaryViewModel
    {
        BindingSource BindingSource { get; set; }
        Command AddCommand { get; set; }
        Command EditCommand { get; set; }
        Command DeleteCommand { get; set; }
        Command SaveCommand { get; set; }
        Command TrashCommand { get; set; }
        void Load();
        void InitializeView();
        DataLayoutControl DataLayoutControlDetail { get; set; }
        GridControl GridControlCollection { get; set; }
    }
}
