using System;
using Horizon.DataAccess;
using Horizon.Models;
using Horizon.AppHelper;

namespace Horizon.ViewModels
{
    public class NhanVienViewModel: BaseDictionaryViewModel , Interfaces.ViewModels.INhanVienViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public override void Load()
        {
            BindingSource.DataSource = UnitOfWork.NhanVien.GetList();
        }
        public override bool Add()
        {
            var obj = BindingSource.AddNew() as NhanVien;
            obj.NgaySinh = DateTime.Now;
            return base.Add();
        }
        public override bool Edit()
        {
            return base.Edit();
        }
        public override bool Delete()
        {
            var obj = BindingSource.Current as NhanVien;
            UnitOfWork.NhanVien.Remove(obj);
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
            var obj = BindingSource.Current as NhanVien;
            if (obj.Id == 0)
                UnitOfWork.NhanVien.Add(obj);
            else
                UnitOfWork.NhanVien.Update(obj);
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
