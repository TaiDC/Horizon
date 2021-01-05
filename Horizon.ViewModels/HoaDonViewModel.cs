using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Horizon.AppHelper;
using Horizon.DataAccess;
using Horizon.Framework;
using Horizon.Interfaces;
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
    public class HoaDonViewModel : BaseDictionaryViewModel, IHoaDonViewModel
    {
        readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        public BindingSource BindingSourceChiTiet { get; set; }
        public BindingSource BindingSourceKhachHang { get; set; }
        public GridLookUpEdit LookUpEditHoaDon { get ; set ; }
        public Command PrintCommand { get; set; }
        public Command PrintViewCommand { get; set; }
        public BindingSource BindingSourceSanPham { get; set; }
        public Command PaymentCommand { get; set; }
        public Command CancelCommand { get; set; }
        public Command RefundCommand { get; set; }
        public BindingSource BindingSourceNhanVien { get; set; }
        public BindingSource BindingSourceHinhThucThanhToan { get; set; }
        public BindingSource BindingSourceDonViVanChuyen { get; set; }

        public override void InitializeView()
        {
            BindingSource.CurrentItemChanged += delegate { NotifyCommand(); };
            BindingSource.CurrentChanged += delegate { NotifyCommand(); LookUpEditHoaDon.EditValue = BindingSource.Current; BindingSourceChiTiet.DataSource = (BindingSource.Current as HoaDon)?.HoaDonChiTiet.ToList(); };
            BindingSource.PositionChanged += delegate { NotifyCommand(); LookUpEditHoaDon.EditValue = BindingSource.Current; BindingSourceChiTiet.DataSource = (BindingSource.Current as HoaDon)?.HoaDonChiTiet.ToList(); };
            
            PrintCommand = new Command(PrintExcute);
            PrintViewCommand = new Command(ViewExcute);
            PaymentCommand = new Command(PaymentExcute, PaymentCanExcute);
            CancelCommand = new Command(CancelExcute, CancelCanExcute);
            RefundCommand = new Command(RefundExcute, RefundCanExcute);

            base.InitializeView();
        }

        #region Command Excute / Command CanExcute

        private bool RefundCanExcute()
        {
            var obj = BindingSource.Current as HoaDon;
            if (obj == null) return false;
            if (obj.TinhTrang == null) return false;

            var objTT = UnitOfWork.DanhMuc.TrangThaiChuaThanhToan();
            if (obj.TinhTrang.Equals(objTT)) return false;
            if (obj.HuyHoaDon == true) return false;
            return !obj.HoanTraHoaDon;
        }
        private void RefundExcute()
        {
            if (XtraMessageBox.Show("Bạn có muốn hoàn trả hóa đơn?", "Thông Báo", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var obj = BindingSource.Current as HoaDon;
                obj.HoanTraHoaDon = true;
                UnitOfWork.HoaDon.Update(obj);
                if (UnitOfWork.SaveChanges())
                    AppHelper.MessageCustom.ShowNotify("Đã HOÀN TRẢ hóa đơn", "THÔNG BÁO");
                else
                    AppHelper.MessageCustom.ShowNotify("Đã xảy ra lỗi trong quá trình thực hiện", "THÔNG BÁO");
            }
            Load();
        }
        private bool CancelCanExcute()
        {
            var obj = BindingSource.Current as HoaDon;
            if (obj == null) return false;
            if (obj.TinhTrang == null) return false;

            var objTT = UnitOfWork.DanhMuc.TrangThaiChuaThanhToan();
            if (obj.TinhTrang.Equals(objTT)) return false;
            if (obj.HoanTraHoaDon == true) return false;
            return !obj.HuyHoaDon;
        }
        private void CancelExcute()
        {
            if (XtraMessageBox.Show("Bạn có hủy hóa đơn?", "Thông Báo", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var obj = BindingSource.Current as HoaDon;
                obj.HuyHoaDon = true;
                UnitOfWork.HoaDon.Update(obj);
                if (UnitOfWork.SaveChanges())
                    AppHelper.MessageCustom.ShowNotify("Đã HỦY hóa đơn", "THÔNG BÁO");
                else
                    AppHelper.MessageCustom.ShowNotify("Đã xảy ra lỗi trong quá trình thực hiện", "THÔNG BÁO");
            }
            Load();
        }
        private bool PaymentCanExcute()
        {
            var obj = BindingSource.Current as HoaDon;
            if (obj == null) return false;
            if (obj.TinhTrang == null) return false;
            if (obj.Id == 0) return false;
            var ttHoanTat = UnitOfWork.DanhMuc.TrangThaiDaThanhToan();
            
            return !obj.TinhTrang.Equals(ttHoanTat);
        }
        private void PaymentExcute()
        {
            if (XtraMessageBox.Show("Bạn có muốn xác nhận thanh toán?","Thông Báo", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var obj = BindingSource.Current as HoaDon;
                obj.TinhTrang = UnitOfWork.DanhMuc.TrangThaiDaThanhToan();
                UnitOfWork.HoaDon.Update(obj);
                if (UnitOfWork.SaveChanges())
                    AppHelper.MessageCustom.ShowNotify("Đã XÁC NHẬN THANH TOÁN hóa đơn", "THÔNG BÁO");
                else
                    AppHelper.MessageCustom.ShowNotify("Đã xảy ra lỗi trong quá trình thực hiện", "THÔNG BÁO");
            }
        }
        private void PrintExcute()
        {
            AppHelper.PrintHelper.PrintReport(BindingSource, "BC_002_HoaDon");
        }
        private void ViewExcute()
        {
            AppHelper.PrintHelper.ViewReport(BindingSource, "BC_002_HoaDon");
        }
        #endregion

        public override void Load()
        {
            var lsSPDaBan = UnitOfWork.SanPham.GetSanPhamDaBan();

            var lstSP= UnitOfWork.SanPham.GetList().Except(lsSPDaBan, new SanPhamComparer()).ToList();
            BindingSourceSanPham.DataSource = lstSP;
            BindingSourceNhanVien.DataSource = UnitOfWork.NhanVien.GetList(nv => nv.TamNgung == false);
            BindingSourceHinhThucThanhToan.DataSource = UnitOfWork.DanhMuc.GetListHinhThucThanhToan();
            BindingSourceDonViVanChuyen.DataSource = UnitOfWork.DonViVanChuyen.GetList(vc => vc.TamNgung == false);
        }
        public override bool Add()
        {
            BindingSourceChiTiet.Clear();
            if (BindingSourceKhachHang.Current == null)
            {
                var objKH = BindingSourceKhachHang.AddNew() as KhachHang;
                objKH.NgaySinh = DateTime.Now.Date;
            }
            var ttCHoanTat = UnitOfWork.DanhMuc.TrangThaiChuaThanhToan();

            var obj = BindingSource.AddNew() as HoaDon;
            obj.SoHoaDon = (UnitOfWork.HoaDon.GetMaxSoHoaDonByDatetime(DateTime.Now) + 1).ToString("D3");
            obj.MaHoaDon = "HD" + DateTime.Now.ToString("/yy/MM/") + obj.SoHoaDon; //   HD/21/01/xxx
            obj.NgayHoaDon = DateTime.Now.Date;
            obj.KhachHang = BindingSourceKhachHang.Current as KhachHang;
            obj.TinhTrang = ttCHoanTat;
            //LookUpEditHoaDon.EditValue = obj;
            return base.Add();
        }
        public override bool Edit()
        {
            var objTT = UnitOfWork.DanhMuc.TrangThaiDaThanhToan();
            var obj = BindingSource.Current as HoaDon;
            if (obj.HuyHoaDon ==true || obj.HoanTraHoaDon ==true || obj.TinhTrang.Equals(objTT))
            {
                XtraMessageBox.Show("Phiếu đã phát sinh nghiệp vụ, Không thể chỉnh sửa", "Cảnh Báo");
                return true;
            }    
            return base.Edit();
        }
        public override bool Delete()
        {
            var objTT = UnitOfWork.DanhMuc.TrangThaiDaThanhToan();
            var obj = BindingSource.Current as HoaDon;
            if (obj.HuyHoaDon == true || obj.HoanTraHoaDon == true || obj.TinhTrang.Equals(objTT))
            {
                XtraMessageBox.Show("Phiếu đã phát sinh nghiệp vụ, Không thể xóa", "Cảnh Báo");
                return true;
            }
            UnitOfWork.HoaDon.Remove(obj);
            if (UnitOfWork.SaveChanges())
            {
                BindingSource.RemoveCurrent();
                BindingSourceChiTiet.Clear();
                MessageCustom.ShowNotify(Status.DeleteComplete);
            }
            else
                MessageCustom.ShowNotify(Status.DeleteError);
            return base.Delete();
        }
        public override bool Save()
        {
            var objKH = BindingSourceKhachHang.Current as KhachHang;
            var obj = BindingSource.Current as HoaDon;
            if(obj.NguoiXuat == null)
            {
                XtraMessageBox.Show("Bạn phải chọn người xuất", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (obj.DonViVanChuyen == null)
            {
                XtraMessageBox.Show("Bạn phải chọn đơn vị vận chuyển", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (objKH.Id == 0)
            {
                objKH.MaKhachHang = UnitOfWork.KhachHang.InitializationCodeByYear(DateTime.Now);
                UnitOfWork.KhachHang.Add(objKH);
            }
            if (obj.Id == 0)
                UnitOfWork.HoaDon.Add(obj);
            else
                UnitOfWork.HoaDon.Update(obj);
            if (UnitOfWork.SaveChanges())
                MessageCustom.ShowNotify(Status.SaveComplete);
            else
                MessageCustom.ShowNotify(Status.SaveError);
            return base.Save();
        }
        public override bool Trash()
        {
            var objKH = BindingSourceKhachHang.Current as KhachHang;
            var obj = BindingSource.Current as HoaDon;
            if (objKH.Id == 0)
                BindingSourceKhachHang.RemoveCurrent();
            if (obj.Id == 0)
            {
                BindingSource.RemoveCurrent();
                BindingSourceChiTiet.Clear();
            }

            UnitOfWork.HoaDonChiTiet.Reset();
            UnitOfWork.KhachHang.Reset();
            UnitOfWork.HoaDon.Reset();

            if (obj.Id != 0)
            {
                //LookUpEditHoaDon.EditValue = obj;
                BindingSourceChiTiet.Clear();
                BindingSourceChiTiet.DataSource = obj.HoaDonChiTiet.ToList();
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
            var objHoadon = BindingSource.Current as HoaDon;
            var objHoadonChiTiet = BindingSourceChiTiet.AddNew() as HoaDonChiTiet;
            objHoadonChiTiet.HoaDon = objHoadon;
            objHoadonChiTiet.SanPham = loaiSanPham as SanPham;
            objHoadonChiTiet.DonGiaBan = Convert.ToDouble(donGia);


            UnitOfWork.HoaDonChiTiet.Add(objHoadonChiTiet);
            BindingSourceSanPham.RemoveCurrent();
            objHoadon.ThanhTien = objHoadon.HoaDonChiTiet.Sum(s => s.DonGiaBan);
        }
        public void DeleteSanPham()
        {
            var objChiTiet = BindingSourceChiTiet.Current as HoaDonChiTiet;
            if (objChiTiet == null) return;
            BindingSourceChiTiet.RemoveCurrent();
            BindingSourceSanPham.Add(objChiTiet.SanPham);
            UnitOfWork.HoaDonChiTiet.Remove(objChiTiet);
        }

        public void ShowKhachHangTimKiem(ITimKiemView timKiemView)
        {
            #region Initalize Column
            // 
            // colMaKhachHang
            //
            DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            colMaKhachHang.FieldName = "MaKhachHang";
            colMaKhachHang.OptionsColumn.ReadOnly = true;
            colMaKhachHang.VisibleIndex = 0;
            // 
            // colTenKhachHang
            // 
            DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            colTenKhachHang.FieldName = "TenKhachHang";
            colTenKhachHang.VisibleIndex = 1;
            // 
            // colNgaySinh
            // 
            DevExpress.XtraGrid.Columns.GridColumn colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            colNgaySinh.FieldName = "NgaySinh";
            colNgaySinh.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            DevExpress.XtraGrid.Columns.GridColumn colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            colDiaChi.FieldName = "DiaChi";
            colDiaChi.Width = 150;
            colDiaChi.VisibleIndex = 3;

            //timKiemView.GridView.CustomUnboundColumnData += (sender, e) =>
            //{
            //    if (e.Column.FieldName == "SoLuong")
            //    {
            //        ChungTu chungTu = e.Row as ChungTu;
            //        if (chungTu == null) return;
            //        e.Value = chungTu.ChungTuChiTiet.Count;
            //    }
            //};

            #endregion
            timKiemView.GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colMaKhachHang
            ,colNgaySinh
            ,colTenKhachHang
            ,colDiaChi
            });
            timKiemView.BindingSource.DataSource = UnitOfWork.KhachHang.GetList();
            if (timKiemView.ShowFindDialog() == DialogResult.OK && timKiemView.BindingSource.Current != null)
            {
                var objKH = timKiemView.BindingSource.Current as KhachHang;
                BindingSourceKhachHang.DataSource = objKH;
                BindingSource.DataSource = UnitOfWork.HoaDon.GetList(hd => hd.KhachHang.Id == objKH.Id).ToList();

            }
        }
        public void ShowHoaDonTimKiem(ITimKiemView timKiemView)
        {
            #region Initalize Column
            // 
            // colMaHoaDon
            //
            DevExpress.XtraGrid.Columns.GridColumn colMaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            colMaHoaDon.FieldName = "MaHoaDon";
            colMaHoaDon.OptionsColumn.ReadOnly = true;
            colMaHoaDon.VisibleIndex = 0;
            // 
            // colNgayHoaDon
            // 
            DevExpress.XtraGrid.Columns.GridColumn colNgayHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            colNgayHoaDon.FieldName = "NgayHoaDon";
            colNgayHoaDon.VisibleIndex = 2;
            // 
            // colTenKhachHang
            // 
            DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            colTenKhachHang.FieldName = "KhachHang.TenKhachHang";
            colTenKhachHang.VisibleIndex = 1;
            // 
            // colThanhTien
            // 
            DevExpress.XtraGrid.Columns.GridColumn colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            colThanhTien.FieldName = "ThanhTien";
            colThanhTien.VisibleIndex = 3;
            // 
            // colTinhTrang
            // 
            DevExpress.XtraGrid.Columns.GridColumn colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            colTinhTrang.FieldName = "TinhTrang.TenDanhMuc";
            colTinhTrang.Caption = "Trạng Thái";
            colTinhTrang.Width = 150;
            colTinhTrang.VisibleIndex = 4;
            // 
            // colSoLuong
            // 
            DevExpress.XtraGrid.Columns.GridColumn colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            colSoLuong.Caption = "Số Lượng";
            colSoLuong.FieldName = "SoLuong";
            colSoLuong.Width = 50;
            colSoLuong.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            colSoLuong.VisibleIndex = 9;

            timKiemView.GridView.CustomUnboundColumnData += (sender, e) =>
            {
                if (e.Column.FieldName == "SoLuong")
                {
                    HoaDon obj = e.Row as HoaDon;
                    if (obj == null) return;
                    e.Value = obj.HoaDonChiTiet.Count;
                }
            };

            #endregion
            timKiemView.GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colMaHoaDon
            ,colTenKhachHang
            ,colNgayHoaDon
            ,colThanhTien
            ,colSoLuong
            ,colTinhTrang
            });
            timKiemView.BindingSource.DataSource = UnitOfWork.HoaDon.GetList();
            if (timKiemView.ShowFindDialog() == DialogResult.OK && timKiemView.BindingSource.Current != null)
            {
                var objHD = timKiemView.BindingSource.Current as HoaDon;
                var objKH = objHD.KhachHang;
                BindingSourceKhachHang.DataSource = objKH;
                BindingSource.DataSource = UnitOfWork.HoaDon.GetList(hd => hd.KhachHang.Id == objKH.Id).ToList();
                LookUpEditHoaDon.EditValue = objHD;
            }
        }
        public void SetBindingSoucreByMaKhachHang(string maKH)
        {
            var objKH = UnitOfWork.KhachHang.Find(kh => kh.MaKhachHang == maKH);
            if (objKH != null)
            {
                BindingSourceKhachHang.DataSource = objKH;

                BindingSource.DataSource = UnitOfWork.HoaDon.GetList(hd => hd.KhachHang.Id == objKH.Id).ToList();
                //LookUpEditHoaDon.EditValue = BindingSource.Current;
            }
        }
        private void NotifyCommand()
        {
            PaymentCommand.NotifyChange();
            CancelCommand.NotifyChange();
            RefundCommand.NotifyChange();
        }
    }
}
