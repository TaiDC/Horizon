using Horizon.AppHelper;
using Horizon.DataAccess;
using Horizon.Interfaces.ViewModels;
using Horizon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.ViewModels
{
    public class KhachHangViewModel: BaseDictionaryViewModel, IKhachHangViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public override void Load()
        {
            BindingSource.DataSource = UnitOfWork.KhachHang.GetList();
        }
        public override bool Add()
        {
            var obj = BindingSource.AddNew() as KhachHang;
            return base.Add();
        }
        public override bool Edit()
        {
            return base.Edit();
        }
        public override bool Delete()
        {
            var obj = BindingSource.Current as KhachHang;
            UnitOfWork.KhachHang.Remove(obj);
            if (UnitOfWork.SaveChanges())
            {
                BindingSource.RemoveCurrent();
                MessageCustom.ShowNotify(Status.DeleteComplete);
            }
            else
                MessageCustom.ShowNotify(Status.DeleteError);
            return base.Delete();
        }
        public override bool Save()
        {
            var obj = BindingSource.Current as KhachHang;
            if (obj.Id == 0)
                UnitOfWork.KhachHang.Add(obj);
            else
                UnitOfWork.KhachHang.Update(obj);
            if (UnitOfWork.SaveChanges())
                MessageCustom.ShowNotify(Status.SaveComplete);
            else
                MessageCustom.ShowNotify(Status.SaveError);
            return base.Save();
        }
        public override bool Trash()
        {
            return base.Trash();
        }
    }
}
