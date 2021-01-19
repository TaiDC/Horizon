using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horizon.AppHelper;
using Horizon.DataAccess;
using Horizon.Interfaces.ViewModels;
using Horizon.Models;

namespace Horizon.ViewModels
{
    public class NhaCungCapViewModel : BaseDictionaryViewModel , INhaCungCapViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public override void Load()
        {
            BindingSource.DataSource = UnitOfWork.NhaCungCap.GetList();
        }
        public override bool Add()
        {
            var obj = BindingSource.AddNew() as NhaCungCap;
            return base.Add();
        }
        public override bool Edit()
        {
            return base.Edit();
        }
        public override bool Delete()
        {
            var obj = BindingSource.Current as NhaCungCap;
            UnitOfWork.NhaCungCap.Remove(obj);
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
            var obj = BindingSource.Current as NhaCungCap;
            if (obj.Id == 0)
                UnitOfWork.NhaCungCap.Add(obj);
            else
                UnitOfWork.NhaCungCap.Update(obj);
            if (UnitOfWork.SaveChanges())
                MessageCustom.ShowNotify(Status.SaveComplete);
            else
                MessageCustom.ShowNotify(Status.SaveError);
            return base.Save();
        }
        public override bool Trash()
        {
            UnitOfWork.NhaCungCap.Reset();
            return base.Trash();
        }
    }
}
