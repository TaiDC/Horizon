using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Horizon.Interfaces;
using Unity;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.XtraBars.Docking2010.Views.Widget;

namespace Horizon.App
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Interfaces.ViewModels.IMainViewModel _vm = Config.Container.Resolve<Interfaces.ViewModels.IMainViewModel>();

        public MainView()
        {
            #region Initialize and show a splashscreen.
            FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            op.Title = "HORIZON";
            op.Subtitle = "Phần mềm Quản lý Đơn hàng";
            op.RightFooter = "Starting...";
            op.LeftFooter = "Copyright © 2020 Developer Tai Dinh Cong." + Environment.NewLine + "All Rights reserved.";
            op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            op.OpacityColor = Color.DeepSkyBlue;
            op.Opacity = 130;
            //op.LogoImageOptions.SvgImage = Resources.Logo;

            SplashScreenManager.ShowFluentSplashScreen(
                op,
                parentForm: this,
                useFadeIn: true,
                useFadeOut: true
            );
            #endregion

            InitializeComponent();

            #region InitializeButton

            barButtonNhanVien.ItemClick += delegate { ShowUserControl(barButtonNhanVien.Caption, typeof(NhanVienView)); };
            barButtonNhaCungCap.ItemClick += delegate { ShowUserControl(barButtonNhaCungCap.Caption, typeof(NhaCungCapView)); };
            barButtonLoaiSanPham.ItemClick += delegate { ShowUserControl(barButtonLoaiSanPham.Caption, typeof(LoaiSanPhamView)); };
            barButtonDonViVanChuyen.ItemClick += delegate { ShowUserControl(barButtonDonViVanChuyen.Caption, typeof(DonViVanChuyenView)); };
            barButtonDanhMuc.ItemClick += delegate { ShowUserControl(barButtonDanhMuc.Caption, typeof(DanhMucView)); };
            barButtonNhapTuNCC.ItemClick += delegate { ShowUserControl(barButtonNhapTuNCC.Caption, typeof(ChungTuView)); };
            barButtonHoaDon.ItemClick += delegate { ShowUserControl(barButtonHoaDon.Caption, typeof(HoaDonView)); };
            barButtonKhachHang.ItemClick += delegate { ShowUserControl(barButtonKhachHang.Caption, typeof(KhachHangView)); };
            barButtonDesign.ItemClick += delegate
            {
                using (DesignView designView = new DesignView())
                {
                    designView.ShowDialog();
                }
            };
            barButtonBarcode.ItemClick += delegate { ShowUserControl(barButtonBarcode.Caption, typeof(BarcodeView)); };
            barButtonHome.ItemClick += delegate { };
            #endregion

            barEditTuNgay.EditValue = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            barEditDenNgay.EditValue = DateTime.Today;

            op.RightFooter = "Load database...";
            SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, op);
            _vm.Load();

            op.RightFooter = "Done...!";
            SplashScreenManager.Default.SendCommand(FluentSplashScreenCommand.UpdateOptions, op);
            Thread.Sleep(1000);

            //Close the splashscreen
            SplashScreenManager.CloseForm();
            WindowState = FormWindowState.Maximized;
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView.QueryControl += tabbedView_QueryControl;
        }

        public void ShowUserControl(string caption, Type type)
        {
            foreach (BaseDocument item in documentManager.View.Documents)
            {
                if (item.Control.GetType() == type)
                {
                    documentManager.View.ActivateDocument(item.Control);
                    return;
                }
            }
            XtraUserControl childForm = (XtraUserControl)Activator.CreateInstance(type);
            childForm.Text = caption;
            documentManager.View.AddDocument(childForm);
            documentManager.View.ActivateDocument(childForm);
            try
            {
                ribbon.SelectedPage = ribbon.MergedCategories[0].Pages[0];
            }
            catch (Exception)
            {
            }
        }

        // Assigning a required content for each auto generated Document
        void tabbedView_QueryControl(object sender, QueryControlEventArgs e)
        {
            //if (e.Document == document1)
            //    e.Control = new HomeView();

            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
    }
}