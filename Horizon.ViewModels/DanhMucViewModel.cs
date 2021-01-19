using Horizon.Models;
using Horizon.DataAccess;
using Horizon.Interfaces.ViewModels;
using Horizon.AppHelper;

namespace Horizon.ViewModels
{
    public class DanhMucViewModel : BaseDictionaryViewModel, IDanhMucViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public override void Load()
        {
            BindingSource.DataSource = UnitOfWork.DanhMuc.GetList();
        }
        public override bool Add()
        {
            var obj = BindingSource.AddNew() as DanhMuc;
            return base.Add();
        }
        public override bool Edit()
        {
            return base.Edit();
        }
        public override bool Delete()
        {
            var obj = BindingSource.Current as DanhMuc;
            UnitOfWork.DanhMuc.Remove(obj);
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
            var obj = BindingSource.Current as DanhMuc;
            if (obj.Id == 0)
                UnitOfWork.DanhMuc.Add(obj);
            else
                UnitOfWork.DanhMuc.Update(obj);
            if (UnitOfWork.SaveChanges())
                MessageCustom.ShowNotify(Status.SaveComplete);
            else
                MessageCustom.ShowNotify(Status.SaveError);
            return base.Save();
        }
        public override bool Trash()
        {
            UnitOfWork.DanhMuc.Reset();
            return base.Trash();
        }
    }
}
