using Horizon.Interfaces.ViewModels;
using Horizon.App.Common;
using Unity;

namespace Horizon.App
{
    public partial class LoaiSanPhamView : BaseDictionaryView
    {
        ILoaiSanPhamViewModel _vm = Config.Container.Resolve<ILoaiSanPhamViewModel>();
        public LoaiSanPhamView()
        {
            InitializeComponent();

            #region Initialize ViewModel
            _vm.BindingSource = bindingSource;
            _vm.DataLayoutControlDetail = dataLayoutDetail;
            _vm.GridControlCollection = gridControlCollection;
            _vm.InitializeView();
            Load += delegate { _vm.Load(); };
            #endregion

            #region Button Command
            btnRefresh.ItemClick += delegate { _vm.Load(); };

            btnAdd.ItemClick += delegate { _vm.AddCommand.Execute(); MaLoaiSanPhamTextEdit.Focus(); };
            btnEdit.ItemClick += delegate { _vm.EditCommand.Execute(); };
            btnDelete.ItemClick += delegate { _vm.DeleteCommand.Execute(); };
            btnSave.ItemClick += delegate { _vm.SaveCommand.Execute(); };
            btnTrash.ItemClick += delegate { _vm.TrashCommand.Execute(); };

            btnAdd.DataBindings.Add(_vm.AddCommand.EnabledBinding);
            btnEdit.DataBindings.Add(_vm.EditCommand.EnabledBinding);
            btnDelete.DataBindings.Add(_vm.DeleteCommand.EnabledBinding);
            btnSave.DataBindings.Add(_vm.SaveCommand.EnabledBinding);
            btnTrash.DataBindings.Add(_vm.TrashCommand.EnabledBinding);

            #endregion
        }
    }
}
