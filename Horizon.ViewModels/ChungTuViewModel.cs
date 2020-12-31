using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Horizon.AppHelper;
using Horizon.DataAccess;
using Horizon.Framework;
using Horizon.Interfaces.ViewModels;
using Horizon.Interfaces.Views;
using Horizon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizon.ViewModels
{
    public class ChungTuViewModel : BaseDictionaryViewModel, IChungTuViewModel
    {
        UnitOfWork UnitOfWork = new UnitOfWork();
        public BindingSource BindingSourceChiTiet { get; set; }
        public BindingSource BindingSourceNhanVien { get; set; }
        public BindingSource BindingSourceNhaCungCap { get; set; }
        public BindingSource BindingSourceLoaiSanPham { get; set; }

        public Command PrintCommand { get; set; }
        public Command PrintViewCommand { get; set; }
        public void ShowTimKiem(ITimKiemView timKiemView)
        {
            #region Initalize Column
            // 
            // colMaChungTu
            //
            DevExpress.XtraGrid.Columns.GridColumn colMaChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            colMaChungTu.FieldName = "MaChungTu";
            colMaChungTu.OptionsColumn.ReadOnly = true;
            colMaChungTu.VisibleIndex = 0;
            // 
            // colNgayChungTu
            // 
            DevExpress.XtraGrid.Columns.GridColumn colNgayChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            colNgayChungTu.FieldName = "NgayChungTu";
            colNgayChungTu.VisibleIndex = 2;
            // 
            // colTongTien
            // 
            DevExpress.XtraGrid.Columns.GridColumn colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            colTongTien.FieldName = "TongTien";
            colTongTien.DisplayFormat.FormatString = "n0";
            colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTongTien.VisibleIndex = 5;
            // 
            // colNhanVien
            // 
            DevExpress.XtraGrid.Columns.GridColumn colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            colNhanVien.FieldName = "NguoiNhap.TenNhanVien";
            colNhanVien.VisibleIndex = 7;
            // 
            // colNhaCungCap
            // 
            DevExpress.XtraGrid.Columns.GridColumn colNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            colNhaCungCap.FieldName = "NhaCungCap.TenNhaCungCap";
            colNhaCungCap.VisibleIndex = 8;
            // 
            // colSoLuong
            // 
            DevExpress.XtraGrid.Columns.GridColumn colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            colSoLuong.Caption = "Số Lượng";
            colSoLuong.FieldName = "SoLuong";
            colSoLuong.Width = 50;
            colSoLuong.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            colSoLuong.VisibleIndex = 9;

            timKiemView.GridView.CustomUnboundColumnData+= (sender, e) =>
            {
                if (e.Column.FieldName == "SoLuong")
                {
                    ChungTu chungTu = e.Row as ChungTu;
                    if (chungTu == null) return;
                    e.Value = chungTu.ChungTuChiTiet.Count;
                }
            };

            #endregion
            timKiemView.GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colMaChungTu
            ,colNgayChungTu
            ,colTongTien
            ,colNhanVien
            ,colNhaCungCap
            ,colSoLuong
            });
            timKiemView.BindingSource.DataSource = UnitOfWork.ChungTu.GetList();
            if (timKiemView.ShowFindDialog() == DialogResult.OK && timKiemView.BindingSource.Current != null)
            {
                BindingSource.DataSource = timKiemView.BindingSource.Current;
                BindingSourceChiTiet.DataSource = (timKiemView.BindingSource.Current as ChungTu).ChungTuChiTiet.ToList();
            }

        }
        public override void InitializeView()
        {
            base.InitializeView();
            PrintCommand = new Command(PrintExcute);
            PrintViewCommand = new Command(ViewExcute);
        }
        public override void Load()
        {
            BindingSourceNhanVien.DataSource = UnitOfWork.NhanVien.GetList(nv => nv.TamNgung == false);
            BindingSourceNhaCungCap.DataSource = UnitOfWork.NhaCungCap.GetList(ncc => ncc.TamNgung == false);
            BindingSourceLoaiSanPham.DataSource = UnitOfWork.LoaiSanPham.GetList(lsp => lsp.TamNgung == false);
        }
        public override bool Add()
        {
            BindingSource.Clear();
            BindingSourceChiTiet.Clear();
            var obj = BindingSource.AddNew() as ChungTu;
            obj.SoChungTu = (UnitOfWork.ChungTu.GetMaxSoChungTuByDatetime(DateTime.Now)+1).ToString("D4") ;
            obj.MaChungTu = "CT" + DateTime.Now.ToString("yyMM")+obj.SoChungTu;
            obj.NgayChungTu = DateTime.Now.Date;
            obj.NgayHoaDon = DateTime.Now.Date;
            return base.Add();
        }
        public override bool Edit()
        {
            return base.Edit();
        }
        public override bool Delete()
        {
            var obj = BindingSource.Current as ChungTu;
            UnitOfWork.ChungTu.Remove(obj);
            if (UnitOfWork.SaveChanges())
            {
                BindingSource.RemoveCurrent();
                BindingSourceChiTiet.Clear();
                MessageCustom.ShowNotify(Status.DeleteComplete);
            }
            else
            {
                MessageCustom.ShowNotify(Status.DeleteError);
            }
            return base.Delete();
        }
        public override bool Save()
        {
            var obj = BindingSource.Current as ChungTu;
            if (obj.Id == 0)
                UnitOfWork.ChungTu.Add(obj);
            else
                UnitOfWork.ChungTu.Update(obj);
            if (UnitOfWork.SaveChanges())
                MessageCustom.ShowNotify(Status.SaveComplete);
            else
                MessageCustom.ShowNotify(Status.SaveError);
            return base.Save();
        }
        public override bool Trash()
        {
            var obj = BindingSource.Current as ChungTu;
            if (obj.Id == 0)
            {
                BindingSource.RemoveCurrent();
                BindingSourceChiTiet.Clear();
            }

            UnitOfWork.ChungTu.Reset();
            UnitOfWork.SanPham.Reset();

            if (obj.Id != 0)
            {
                BindingSource.Clear();
                BindingSourceChiTiet.Clear();
                BindingSource.Add( UnitOfWork.ChungTu.GetById(obj.Id));
                BindingSourceChiTiet.DataSource = (BindingSource.Current as ChungTu).ChungTuChiTiet.ToList();
            }
            return base.Trash();
        }

        public void NewSanPham(object loaiSanPham, object donGia)
        {
            if (loaiSanPham == null)
            {
                XtraMessageBox.Show("Bạn phải chọn sản phẩm", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (donGia == null)
            {
                XtraMessageBox.Show("Bạn phải nhập đơn giá sản phẩm", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var obj = BindingSource.Current as ChungTu;

            var objChiTiet = BindingSourceChiTiet.AddNew() as SanPham;
            objChiTiet.LoaiSanPham = loaiSanPham as LoaiSanPham;

            //Lấy SoSanPham lớn nhất theo LoaiSP trên SQL
            int maxsosanphamdb = UnitOfWork.SanPham.GetMaxSoSanPhamByLoaiAndDateTime(objChiTiet.LoaiSanPham, DateTime.Now);
            //Lấy SoSanPham lớn nhất theo LoaiSP trên BindingSource
            int maxsosanphamlc = Convert.ToInt32(BindingSourceChiTiet.List.OfType<SanPham>().Where(s => s.LoaiSanPham == loaiSanPham).Max(s => s.SoSanPham));
            objChiTiet.SoSanPham = (Math.Max(maxsosanphamdb, maxsosanphamlc) + 1).ToString("D4");

            objChiTiet.MaSanPham = objChiTiet.LoaiSanPham.MaLoaiSanPham +DateTime.Now.ToString("yy") + objChiTiet.SoSanPham;
            objChiTiet.DonGiaNhap = Convert.ToDouble(donGia);
            objChiTiet.ChungTu = obj;

            UnitOfWork.SanPham.Add(objChiTiet);
            obj.TongTien = obj.ChungTuChiTiet.Sum(s => s.DonGiaNhap);
        }
        public void DeleteSanPham()
        {
            var obj = BindingSource.Current as ChungTu;
            var objChiTiet = BindingSourceChiTiet.Current as SanPham;
            if (objChiTiet == null)
                return;
            BindingSourceChiTiet.RemoveCurrent();
            UnitOfWork.SanPham.Remove(objChiTiet);
            obj.TongTien = obj.ChungTuChiTiet.Sum(s => s.DonGiaNhap);
        }

        private void PrintExcute()
        {
            XtraReport report = XtraReport.FromFile(@"Report\\BC_001_ChungTu.repx", true);
            report.DataSource = BindingSource;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PrintDialog();
        }
        private void ViewExcute()
        {
            XtraReport report = XtraReport.FromFile(@"Report\\BC_001_ChungTu.repx", true);
            report.DataSource = BindingSource;
            // Show the report's Print Preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.PreviewForm.WindowState = FormWindowState.Maximized;
            printTool.ShowPreviewDialog();
        }
    }
}