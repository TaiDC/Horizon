using Horizon.Models;
using Horizon.DataAccess;
using Horizon.Interfaces.ViewModels;
using Horizon.AppHelper;

namespace Horizon.ViewModels
{
    public class DonViVanChuyenViewModel : BaseDictionaryViewModel, IDonViVanChuyenViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public override void Load()
        {
            BindingSource.DataSource = UnitOfWork.DonViVanChuyen.GetList();
        }
        public override bool Add()
        {
            var obj = BindingSource.AddNew() as DonViVanChuyen;
            return base.Add();
        }
        public override bool Edit()
        {
            return base.Edit();
        }
        public override bool Delete()
        {
            var obj = BindingSource.Current as DonViVanChuyen;
            UnitOfWork.DonViVanChuyen.Remove(obj);
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
            var obj = BindingSource.Current as DonViVanChuyen;
            if (obj.Id == 0)
                UnitOfWork.DonViVanChuyen.Add(obj);
            else
                UnitOfWork.DonViVanChuyen.Update(obj);
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
