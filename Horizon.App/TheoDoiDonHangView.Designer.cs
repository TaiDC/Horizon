namespace Horizon.App
{
    partial class TheoDoiDonHangView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHuyHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoanTraHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHinhThucThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViVanChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoaDonBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(927, 506);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(Horizon.Models.HoaDon);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHoaDon,
            this.colNgayHoaDon,
            this.colThanhTien,
            this.colNguoiXuat,
            this.colTinhTrang,
            this.colDaThanhToan,
            this.colDaChuyen,
            this.colHuyHoaDon,
            this.colHoanTraHoaDon,
            this.colHinhThucThanhToan,
            this.colDonViVanChuyen,
            this.colKhachHang,
            this.colGhiChu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TinhTrang", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.FieldName = "MaHoaDon";
            this.colMaHoaDon.MaxWidth = 100;
            this.colMaHoaDon.MinWidth = 100;
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Visible = true;
            this.colMaHoaDon.VisibleIndex = 0;
            this.colMaHoaDon.Width = 100;
            // 
            // colNgayHoaDon
            // 
            this.colNgayHoaDon.FieldName = "NgayHoaDon";
            this.colNgayHoaDon.MaxWidth = 100;
            this.colNgayHoaDon.MinWidth = 100;
            this.colNgayHoaDon.Name = "colNgayHoaDon";
            this.colNgayHoaDon.Visible = true;
            this.colNgayHoaDon.VisibleIndex = 1;
            this.colNgayHoaDon.Width = 100;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DisplayFormat.FormatString = "n0";
            this.colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.MinWidth = 50;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.OptionsColumn.FixedWidth = true;
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 2;
            this.colThanhTien.Width = 85;
            // 
            // colNguoiXuat
            // 
            this.colNguoiXuat.Caption = "Người Xuất";
            this.colNguoiXuat.FieldName = "NguoiXuat.TenNhanVien";
            this.colNguoiXuat.Name = "colNguoiXuat";
            this.colNguoiXuat.OptionsColumn.FixedWidth = true;
            this.colNguoiXuat.Visible = true;
            this.colNguoiXuat.VisibleIndex = 3;
            this.colNguoiXuat.Width = 85;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Caption = "Tình Trạng";
            this.colTinhTrang.FieldName = "TinhTrang.TenDanhMuc";
            this.colTinhTrang.MinWidth = 75;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.Visible = true;
            this.colTinhTrang.VisibleIndex = 4;
            this.colTinhTrang.Width = 100;
            // 
            // colDaThanhToan
            // 
            this.colDaThanhToan.FieldName = "DaThanhToan";
            this.colDaThanhToan.MaxWidth = 90;
            this.colDaThanhToan.MinWidth = 90;
            this.colDaThanhToan.Name = "colDaThanhToan";
            this.colDaThanhToan.Visible = true;
            this.colDaThanhToan.VisibleIndex = 5;
            this.colDaThanhToan.Width = 90;
            // 
            // colDaChuyen
            // 
            this.colDaChuyen.FieldName = "DaChuyen";
            this.colDaChuyen.MaxWidth = 65;
            this.colDaChuyen.MinWidth = 65;
            this.colDaChuyen.Name = "colDaChuyen";
            this.colDaChuyen.Visible = true;
            this.colDaChuyen.VisibleIndex = 6;
            this.colDaChuyen.Width = 65;
            // 
            // colHuyHoaDon
            // 
            this.colHuyHoaDon.FieldName = "HuyHoaDon";
            this.colHuyHoaDon.MaxWidth = 65;
            this.colHuyHoaDon.MinWidth = 65;
            this.colHuyHoaDon.Name = "colHuyHoaDon";
            this.colHuyHoaDon.Visible = true;
            this.colHuyHoaDon.VisibleIndex = 7;
            this.colHuyHoaDon.Width = 65;
            // 
            // colHoanTraHoaDon
            // 
            this.colHoanTraHoaDon.FieldName = "HoanTraHoaDon";
            this.colHoanTraHoaDon.MaxWidth = 65;
            this.colHoanTraHoaDon.MinWidth = 65;
            this.colHoanTraHoaDon.Name = "colHoanTraHoaDon";
            this.colHoanTraHoaDon.Visible = true;
            this.colHoanTraHoaDon.VisibleIndex = 8;
            this.colHoanTraHoaDon.Width = 65;
            // 
            // colHinhThucThanhToan
            // 
            this.colHinhThucThanhToan.Caption = "Hình Thức Thanh Toán";
            this.colHinhThucThanhToan.FieldName = "HinhThucThanhToan.TenDanhMuc";
            this.colHinhThucThanhToan.MinWidth = 75;
            this.colHinhThucThanhToan.Name = "colHinhThucThanhToan";
            this.colHinhThucThanhToan.Visible = true;
            this.colHinhThucThanhToan.VisibleIndex = 9;
            // 
            // colDonViVanChuyen
            // 
            this.colDonViVanChuyen.FieldName = "DonViVanChuyen.TenDonViVanChuyen";
            this.colDonViVanChuyen.MinWidth = 50;
            this.colDonViVanChuyen.Name = "colDonViVanChuyen";
            this.colDonViVanChuyen.Visible = true;
            this.colDonViVanChuyen.VisibleIndex = 10;
            this.colDonViVanChuyen.Width = 50;
            // 
            // colKhachHang
            // 
            this.colKhachHang.Caption = "Khách Hàng";
            this.colKhachHang.FieldName = "KhachHang.TenKhachHang";
            this.colKhachHang.MinWidth = 50;
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 11;
            this.colKhachHang.Width = 50;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 12;
            this.colGhiChu.Width = 20;
            // 
            // TheoDoiDonHangView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "TheoDoiDonHangView";
            this.Size = new System.Drawing.Size(927, 506);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colDaThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colHuyHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colDaChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colHoanTraHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colHinhThucThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViVanChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}
