using DevExpress.XtraGrid.Views.Grid;
using Horizon.Framework;
using System.Windows.Forms;

namespace Horizon.Interfaces.ViewModels
{
    public interface IBarcodeViewModel
    {
        BindingSource BindingSource { get; set; }
        void Load();
        void InitializeView();
        Command PrintCommand { get; set; }
        Command ViewCommand { get; set; }
        GridView GridViewCollection { get; set; }
    }
}
