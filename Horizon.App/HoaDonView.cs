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
    public partial class HoaDonView : Common.BaseDictionaryView
    {
        IHoaDonViewModel _vm = Config.Container.Resolve<IHoaDonViewModel>();
        public HoaDonView()
        {
            InitializeComponent();
            #region Initialize ViewModel
            _vm.BindingSource = bindingSource;
            _vm.BindingSourceChiTiet = hoaDonChiTietBindingSource;
            _vm.BindingSourceKhachHang = khachHangBindingSource;
            _vm.BindingSourceSanPham = sanPhamBindingSource;
            _vm.BindingSourceDonViVanChuyen = donViVanChuyenBindingSource;
            _vm.BindingSourceNhanVien = nhanVienBindingSource;
            _vm.BindingSourceHinhThucThanhToan = danhMucBindingSource;
            _vm.LookUpEditHoaDon = lookUpHoaDon;
            _vm.DataLayoutControlDetail = dataLayoutDetail;
            _vm.GridControlCollection = new DevExpress.XtraGrid.GridControl();
            _vm.InitializeView();
            Load += delegate { _vm.Load(); ReadOnlyInfo(_vm.AddCommand.Enabled); };
            #endregion

            #region Button Command

            btnRefresh.ItemClick += delegate {/* _vm.Load();*/ };

            btnAdd.ItemClick += delegate {  _vm.AddCommand.Execute(); ReadOnlyInfo(_vm.SaveCommand.Enabled); };
            btnEdit.ItemClick += delegate { ReadOnlyInfo(_vm.AddCommand.Enabled); _vm.EditCommand.Execute(); };
            btnDelete.ItemClick += delegate { _vm.DeleteCommand.Execute(); };
            btnSave.ItemClick += delegate { _vm.SaveCommand.Execute(); ReadOnlyInfo(_vm.AddCommand.Enabled); };
            btnTrash.ItemClick += delegate { _vm.TrashCommand.Execute(); ReadOnlyInfo(!_vm.TrashCommand.Enabled); };
            btnPayment.ItemClick += delegate { _vm.PaymentCommand.Execute(); };
            btnCancel.ItemClick += delegate { _vm.CancelCommand.Execute(); };
            btnRefund.ItemClick += delegate { _vm.RefundCommand.Execute(); };

            btnAdd.DataBindings.Add(_vm.AddCommand.EnabledBinding);
            btnEdit.DataBindings.Add(_vm.EditCommand.EnabledBinding);
            btnDelete.DataBindings.Add(_vm.DeleteCommand.EnabledBinding);
            btnSave.DataBindings.Add(_vm.SaveCommand.EnabledBinding);
            btnTrash.DataBindings.Add(_vm.TrashCommand.EnabledBinding);
            btnPayment.DataBindings.Add(_vm.PaymentCommand.EnabledBinding);
            btnCancel.DataBindings.Add(_vm.CancelCommand.EnabledBinding);
            btnRefund.DataBindings.Add(_vm.RefundCommand.EnabledBinding);


            btnAddChild.Click += delegate { _vm.NewSanPham(lookUpSanPham.EditValue, txtThanhTien.EditValue); lookUpSanPham.EditValue = null; };
            btnDeleteChild.Click += delegate { _vm.DeleteSanPham(); };
            
            btnAddChild.DataBindings.Add("Enabled", _vm.TrashCommand, "Enabled");
            btnDeleteChild.DataBindings.Add("Enabled", _vm.TrashCommand, "Enabled");

            btnFind.ItemClick += delegate { _vm.ShowHoaDonTimKiem(Config.Container.Resolve<Interfaces.Views.ITimKiemView>()); };
            btnPrint.ItemClick += delegate { _vm.PrintCommand.Execute(); };
            btnView.ItemClick += delegate { _vm.PrintViewCommand.Execute(); };

            #endregion

            maKhachHangTextEdit.ButtonClick += MaKhachHangTextEdit_ButtonClick;
            maKhachHangTextEdit.EditValueChanged += delegate { _vm.SetBindingSoucreByMaKhachHang(maKhachHangTextEdit.Text); };

            maKhachHangTextEdit.DataBindings.Add("Enabled", _vm.AddCommand, "Enabled");
            lookUpHoaDon.DataBindings.Add("ReadOnly", _vm.TrashCommand, "Enabled");

            khachHangBindingSource.CurrentChanged += KhachHangBindingSource_CurrentChanged;
            lookUpHoaDon.EditValueChanged += delegate { bindingSource.Position = lookUpHoaDon.Properties.GetIndexByKeyValue(lookUpHoaDon.EditValue); };
            lookUpSanPham.EditValueChanged += delegate { sanPhamBindingSource.Position = lookUpSanPham.Properties.GetIndexByKeyValue(lookUpSanPham.EditValue); };
        }

        private void MaKhachHangTextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraEditors.Controls.EditorButton Button = e.Button;
            if(Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Search)
                _vm.ShowKhachHangTimKiem(Config.Container.Resolve<Interfaces.Views.ITimKiemView>());
            else if (Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                khachHangBindingSource.DataSource = typeof(KhachHang);
                bindingSource.Clear();
                hoaDonChiTietBindingSource.Clear();
            }
        }

        private void KhachHangBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var kh = khachHangBindingSource.Current as KhachHang;
            maKhachHangTextEdit.Properties.Buttons.Clear();
            if (kh == null)
                maKhachHangTextEdit.Properties.Buttons.Add(new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search));
            else
                maKhachHangTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                , new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
        }

        public void ReadOnlyInfo(bool val)
        {
            if ((khachHangBindingSource.Current as KhachHang)?.Id ==0)
                val = false;
            tenKhachHangTextEdit.Properties.ReadOnly = val;
            ngaySinhDateEdit.Properties.ReadOnly = val;
            gioiTinhTextEdit.Properties.ReadOnly = val;
        }

    }
}
