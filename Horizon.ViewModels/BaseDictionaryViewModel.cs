using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Horizon.Framework;
using Horizon.Interfaces.ViewModels;
namespace Horizon.ViewModels
{
    public class BaseDictionaryViewModel : Bindable, IBaseDictionaryViewModel
    {
        private bool enabledAction;
        public bool EnabledAction { get => enabledAction; set => Set(ref enabledAction, value); }
        public System.Windows.Forms.BindingSource BindingSource { get; set; }
        public Command AddCommand { get; set; }
        public Command EditCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public Command SaveCommand { get; set; }
        public Command TrashCommand { get; set; }
        public DataLayoutControl DataLayoutControlDetail { get; set; }
        public GridControl GridControlCollection { get; set; }

        public virtual void InitializeView()
        {

            BindingSource.CurrentChanged += delegate { NotifyCommand(EnabledAction); };
            BindingSource.CurrentItemChanged += delegate { NotifyCommand(EnabledAction); };
            AddCommand = new Command(AddExecute,AddCanExecute);
            EditCommand = new Command(EditExecute, EditCanExecute);
            DeleteCommand = new Command(DeleteExecute,DeleteCanExecute);
            SaveCommand = new Command(SaveExecute, SaveCanExecute);
            TrashCommand = new Command(TrashExecute, TrashCanExecute);
            NotifyCommand(true);

        }
        private void NotifyCommand(bool result)
        {
            EnabledAction = result;
            AddCommand.NotifyChange();
            EditCommand.NotifyChange();
            DeleteCommand.NotifyChange();
            SaveCommand.NotifyChange();
            TrashCommand.NotifyChange();
            if (result)
                DataLayoutControlDetail.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            else
                DataLayoutControlDetail.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False;

            GridControlCollection.Enabled = result;
        }

        #region Initalize Command
        #region Add Command
        private void AddExecute()
        {
            EnabledAction = Add();
            NotifyCommand(EnabledAction);
        }
        private bool AddCanExecute()
        {
            return EnabledAction;
        }
        #endregion
        #region Edit Command
        private void EditExecute()
        {
            EnabledAction = Edit();
            NotifyCommand(EnabledAction);
        }
        private bool EditCanExecute()
        {
            return BindingSource.Current != null && EnabledAction ? true : false;
        }
        #endregion
        #region Delete Command
        private void DeleteExecute()
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu?", "Cảnh báo!!", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                EnabledAction = Delete();
        }
        private bool DeleteCanExecute()
        {
            return BindingSource.Current != null && EnabledAction ? true : false;
        }
        #endregion
        #region Save Command
        private void SaveExecute()
        {
            EnabledAction = Save();
            NotifyCommand(EnabledAction);
        }
        private bool SaveCanExecute()
        {
            return !EnabledAction;
        }
        #endregion
        #region Trash Command
        private void TrashExecute()
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn bỏ qua thay đổi?", "Cảnh báo!!", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                EnabledAction = Trash();
                NotifyCommand(EnabledAction);
            }
        }
        private bool TrashCanExecute()
        {
            return !EnabledAction;
        }
        #endregion

        #endregion

        public virtual void Load()
        {

        }
        public virtual bool Add()
        {
            return false;
        }
        public virtual bool Edit()
        {
            return false;
        }
        public virtual bool Delete()
        {
            return true;
        }
        public virtual bool Save()
        {
            return true;
        }
        public virtual bool Trash()
        {
            return true;
        }
    }
}
