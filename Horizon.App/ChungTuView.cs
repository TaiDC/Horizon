using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Horizon.Interfaces.ViewModels;
using Unity;
using Horizon.Models;

namespace Horizon.App
{
    public partial class ChungTuView : Common.BaseDictionaryView
    {
        IChungTuViewModel _vm = Config.Container.Resolve<IChungTuViewModel>();
        public ChungTuView()
        {
            InitializeComponent();

            #region Initialize ViewModel
            _vm.BindingSource = bindingSource;
            _vm.BindingSourceChiTiet = sanPhamBindingSource;
            _vm.BindingSourceLoaiSanPham = loaiSanPhamBindingSource;
            _vm.BindingSourceNhaCungCap = nhaCungCapBindingSource;
            _vm.BindingSourceNhanVien = nhanVienBindingSource;
            _vm.DataLayoutControlDetail = dataLayoutDetail;
            _vm.GridControlCollection = new DevExpress.XtraGrid.GridControl();
            _vm.InitializeView();
            Load += delegate { _vm.Load(); };
            #endregion

            #region Button Command
            btnRefresh.ItemClick += delegate { _vm.Load(); };

            btnAdd.ItemClick += delegate { _vm.AddCommand.Execute(); };
            btnEdit.ItemClick += delegate { _vm.EditCommand.Execute(); };
            btnDelete.ItemClick += delegate { _vm.DeleteCommand.Execute(); };
            btnSave.ItemClick += delegate { _vm.SaveCommand.Execute(); };
            btnTrash.ItemClick += delegate { _vm.TrashCommand.Execute(); };

            btnAddChiTiet.Click += delegate { _vm.NewSanPham(lookUpEditLoaiSanPham.EditValue, txtDonGia.EditValue); };
            btnDeleteChiTiet.Click += delegate { _vm.DeleteSanPham(); };

            btnFind.ItemClick += delegate { _vm.ShowTimKiem(Config.Container.Resolve<Interfaces.Views.ITimKiemView>()); };
            btnPrint.ItemClick += delegate { _vm.PrintCommand.Execute(); };
            btnView.ItemClick += delegate { _vm.PrintViewCommand.Execute(); };

            btnAdd.DataBindings.Add(_vm.AddCommand.EnabledBinding);
            btnEdit.DataBindings.Add(_vm.EditCommand.EnabledBinding);
            btnDelete.DataBindings.Add(_vm.DeleteCommand.EnabledBinding);
            btnSave.DataBindings.Add(_vm.SaveCommand.EnabledBinding);
            btnTrash.DataBindings.Add(_vm.TrashCommand.EnabledBinding);
           
            btnAddChiTiet.DataBindings.Add("Enabled",_vm.TrashCommand, "Enabled");
            btnDeleteChiTiet.DataBindings.Add("Enabled", _vm.TrashCommand, "Enabled");

            #endregion
        }
    }
}
