using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Unity;
using Horizon.Interfaces;
using Horizon.ViewModels;

namespace Horizon.App
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();

        public static void Register()
        {
            Container.RegisterType<Interfaces.ViewModels.IMainViewModel, MainViewModel>();
            Container.RegisterType<Interfaces.ViewModels.IBaseDictionaryViewModel, BaseDictionaryViewModel>();
            Container.RegisterType<Interfaces.ViewModels.INhanVienViewModel, NhanVienViewModel>();
            Container.RegisterType<Interfaces.ViewModels.INhaCungCapViewModel, NhaCungCapViewModel>();
            Container.RegisterType<Interfaces.ViewModels.ILoaiSanPhamViewModel, LoaiSanPhamViewModel>();
            Container.RegisterType<Interfaces.ViewModels.IDonViVanChuyenViewModel, DonViVanChuyenViewModel>();
            Container.RegisterType<Interfaces.ViewModels.IDanhMucViewModel, DanhMucViewModel>();
            Container.RegisterType<Interfaces.ViewModels.IChungTuViewModel, ChungTuViewModel>();
            Container.RegisterType<Interfaces.Views.ITimKiemView, TimKiemView>();
            Container.RegisterType<Interfaces.ViewModels.IHoaDonViewModel, HoaDonViewModel>();
            Container.RegisterType<Interfaces.ViewModels.IKhachHangViewModel, KhachHangViewModel>();
            Container.RegisterType<Interfaces.ViewModels.IBarcodeViewModel, BarcodeViewModel>();




        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config.Register();

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                MessageBox.Show((e.ExceptionObject as Exception).Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.ThreadException += (s, e) =>
                MessageBox.Show(e.Exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
