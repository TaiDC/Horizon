using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Horizon.DataAccess;
using Horizon.Interfaces.ViewModels;
namespace Horizon.ViewModels
{
    public class TheoDoiDonHangViewModel : ITheoDoiDonHangViewModel
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public BindingSource BindingSource { get; set; }

        public void InitializeView()
        {
        }

        public void Load()
        {
            BindingSource.DataSource = unitOfWork.HoaDon.GetList();
        }
    }
}
