using Horizon.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horizon.Interfaces;
using Horizon.DataAccess;

namespace Horizon.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public void Load()
        {
            using (IUnitOfWork unitOfWork = new UnitOfWork())
            {
                var lst = unitOfWork.DanhMuc.GetList();
            }
        }
    }
}
