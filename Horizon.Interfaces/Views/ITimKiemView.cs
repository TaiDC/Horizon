using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace Horizon.Interfaces.Views
{
    public interface ITimKiemView
    {
        BindingSource BindingSource { get; set; }
        GridView GridView { get; set; }
        DialogResult ShowFindDialog();
    }
}
