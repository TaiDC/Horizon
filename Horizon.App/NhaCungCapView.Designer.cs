namespace Horizon.App
{
    partial class NhaCungCapView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCapView));
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaNCC = new DevExpress.XtraLayout.LayoutControlItem();
            this.MaNCCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTenNhaCungCap = new DevExpress.XtraLayout.LayoutControlItem();
            this.TenNhaCungCapTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.DiaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDienThoai = new DevExpress.XtraLayout.LayoutControlItem();
            this.DienThoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTaiKhoan = new DevExpress.XtraLayout.LayoutControlItem();
            this.TaiKhoanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForNguoiLienHe = new DevExpress.XtraLayout.LayoutControlItem();
            this.NguoiLienHeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTamNgung = new DevExpress.XtraLayout.LayoutControlItem();
            this.TamNgungCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutDetail)).BeginInit();
            this.dataLayoutDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNCCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNhaCungCapTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DienThoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNguoiLienHe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiLienHeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTamNgung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamNgungCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMenu
            // 
            this.ribbonControlMenu.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControlMenu.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControlMenu.SearchEditItem.EditWidth = 150;
            this.ribbonControlMenu.SearchEditItem.Id = -5000;
            this.ribbonControlMenu.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControlMenu.Size = new System.Drawing.Size(791, 150);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            // 
            // btnTrash
            // 
            this.btnTrash.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrash.ImageOptions.SvgImage")));
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Horizon.Models.NhaCungCap);
            // 
            // dataLayoutDetail
            // 
            this.dataLayoutDetail.Appearance.ControlReadOnly.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dataLayoutDetail.Appearance.ControlReadOnly.Options.UseForeColor = true;
            this.dataLayoutDetail.Controls.Add(this.MaNCCTextEdit);
            this.dataLayoutDetail.Controls.Add(this.TenNhaCungCapTextEdit);
            this.dataLayoutDetail.Controls.Add(this.DiaChiTextEdit);
            this.dataLayoutDetail.Controls.Add(this.DienThoaiTextEdit);
            this.dataLayoutDetail.Controls.Add(this.TaiKhoanTextEdit);
            this.dataLayoutDetail.Controls.Add(this.NguoiLienHeTextEdit);
            this.dataLayoutDetail.Controls.Add(this.TamNgungCheckEdit);
            this.dataLayoutDetail.Location = new System.Drawing.Point(491, 150);
            this.dataLayoutDetail.Size = new System.Drawing.Size(300, 235);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(300, 235);
            // 
            // gridControlCollection
            // 
            this.gridControlCollection.Size = new System.Drawing.Size(491, 235);
            // 
            // gridViewCollection
            // 
            this.gridViewCollection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNCC,
            this.colTenNhaCungCap,
            this.colNguoiLienHe,
            this.colDienThoai,
            this.colTaiKhoan,
            this.colDiaChi});
            this.gridViewCollection.OptionsBehavior.Editable = false;
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 0;
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.FieldName = "TenNhaCungCap";
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.Visible = true;
            this.colTenNhaCungCap.VisibleIndex = 1;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            // 
            // colDienThoai
            // 
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 3;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.FieldName = "TaiKhoan";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.Visible = true;
            this.colTaiKhoan.VisibleIndex = 4;
            // 
            // colNguoiLienHe
            // 
            this.colNguoiLienHe.FieldName = "NguoiLienHe";
            this.colNguoiLienHe.Name = "colNguoiLienHe";
            this.colNguoiLienHe.Visible = true;
            this.colNguoiLienHe.VisibleIndex = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaNCC,
            this.ItemForTenNhaCungCap,
            this.ItemForDiaChi,
            this.ItemForDienThoai,
            this.ItemForTaiKhoan,
            this.ItemForNguoiLienHe,
            this.ItemForTamNgung});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(280, 215);
            // 
            // ItemForMaNCC
            // 
            this.ItemForMaNCC.Control = this.MaNCCTextEdit;
            this.ItemForMaNCC.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaNCC.Name = "ItemForMaNCC";
            this.ItemForMaNCC.Size = new System.Drawing.Size(280, 24);
            this.ItemForMaNCC.TextSize = new System.Drawing.Size(119, 13);
            // 
            // MaNCCTextEdit
            // 
            this.MaNCCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaNCC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaNCCTextEdit.Location = new System.Drawing.Point(143, 12);
            this.MaNCCTextEdit.MenuManager = this.ribbonControlMenu;
            this.MaNCCTextEdit.Name = "MaNCCTextEdit";
            this.MaNCCTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MaNCCTextEdit.Size = new System.Drawing.Size(145, 20);
            this.MaNCCTextEdit.StyleController = this.dataLayoutDetail;
            this.MaNCCTextEdit.TabIndex = 4;
            // 
            // ItemForTenNhaCungCap
            // 
            this.ItemForTenNhaCungCap.Control = this.TenNhaCungCapTextEdit;
            this.ItemForTenNhaCungCap.Location = new System.Drawing.Point(0, 24);
            this.ItemForTenNhaCungCap.Name = "ItemForTenNhaCungCap";
            this.ItemForTenNhaCungCap.Size = new System.Drawing.Size(280, 24);
            this.ItemForTenNhaCungCap.TextSize = new System.Drawing.Size(119, 13);
            // 
            // TenNhaCungCapTextEdit
            // 
            this.TenNhaCungCapTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TenNhaCungCap", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TenNhaCungCapTextEdit.Location = new System.Drawing.Point(143, 36);
            this.TenNhaCungCapTextEdit.MenuManager = this.ribbonControlMenu;
            this.TenNhaCungCapTextEdit.Name = "TenNhaCungCapTextEdit";
            this.TenNhaCungCapTextEdit.Size = new System.Drawing.Size(145, 20);
            this.TenNhaCungCapTextEdit.StyleController = this.dataLayoutDetail;
            this.TenNhaCungCapTextEdit.TabIndex = 5;
            // 
            // ItemForDiaChi
            // 
            this.ItemForDiaChi.Control = this.DiaChiTextEdit;
            this.ItemForDiaChi.Location = new System.Drawing.Point(0, 48);
            this.ItemForDiaChi.Name = "ItemForDiaChi";
            this.ItemForDiaChi.Size = new System.Drawing.Size(280, 24);
            this.ItemForDiaChi.TextSize = new System.Drawing.Size(119, 13);
            // 
            // DiaChiTextEdit
            // 
            this.DiaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "DiaChi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DiaChiTextEdit.Location = new System.Drawing.Point(143, 60);
            this.DiaChiTextEdit.MenuManager = this.ribbonControlMenu;
            this.DiaChiTextEdit.Name = "DiaChiTextEdit";
            this.DiaChiTextEdit.Size = new System.Drawing.Size(145, 20);
            this.DiaChiTextEdit.StyleController = this.dataLayoutDetail;
            this.DiaChiTextEdit.TabIndex = 6;
            // 
            // ItemForDienThoai
            // 
            this.ItemForDienThoai.Control = this.DienThoaiTextEdit;
            this.ItemForDienThoai.Location = new System.Drawing.Point(0, 72);
            this.ItemForDienThoai.Name = "ItemForDienThoai";
            this.ItemForDienThoai.Size = new System.Drawing.Size(280, 24);
            this.ItemForDienThoai.TextSize = new System.Drawing.Size(119, 13);
            // 
            // DienThoaiTextEdit
            // 
            this.DienThoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "DienThoai", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DienThoaiTextEdit.Location = new System.Drawing.Point(143, 84);
            this.DienThoaiTextEdit.MenuManager = this.ribbonControlMenu;
            this.DienThoaiTextEdit.Name = "DienThoaiTextEdit";
            this.DienThoaiTextEdit.Size = new System.Drawing.Size(145, 20);
            this.DienThoaiTextEdit.StyleController = this.dataLayoutDetail;
            this.DienThoaiTextEdit.TabIndex = 7;
            // 
            // ItemForTaiKhoan
            // 
            this.ItemForTaiKhoan.Control = this.TaiKhoanTextEdit;
            this.ItemForTaiKhoan.Location = new System.Drawing.Point(0, 96);
            this.ItemForTaiKhoan.Name = "ItemForTaiKhoan";
            this.ItemForTaiKhoan.Size = new System.Drawing.Size(280, 24);
            this.ItemForTaiKhoan.TextSize = new System.Drawing.Size(119, 13);
            // 
            // TaiKhoanTextEdit
            // 
            this.TaiKhoanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TaiKhoan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TaiKhoanTextEdit.Location = new System.Drawing.Point(143, 108);
            this.TaiKhoanTextEdit.MenuManager = this.ribbonControlMenu;
            this.TaiKhoanTextEdit.Name = "TaiKhoanTextEdit";
            this.TaiKhoanTextEdit.Size = new System.Drawing.Size(145, 20);
            this.TaiKhoanTextEdit.StyleController = this.dataLayoutDetail;
            this.TaiKhoanTextEdit.TabIndex = 8;
            // 
            // ItemForNguoiLienHe
            // 
            this.ItemForNguoiLienHe.Control = this.NguoiLienHeTextEdit;
            this.ItemForNguoiLienHe.Location = new System.Drawing.Point(0, 120);
            this.ItemForNguoiLienHe.Name = "ItemForNguoiLienHe";
            this.ItemForNguoiLienHe.Size = new System.Drawing.Size(280, 24);
            this.ItemForNguoiLienHe.TextSize = new System.Drawing.Size(119, 13);
            // 
            // NguoiLienHeTextEdit
            // 
            this.NguoiLienHeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "NguoiLienHe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NguoiLienHeTextEdit.Location = new System.Drawing.Point(143, 132);
            this.NguoiLienHeTextEdit.MenuManager = this.ribbonControlMenu;
            this.NguoiLienHeTextEdit.Name = "NguoiLienHeTextEdit";
            this.NguoiLienHeTextEdit.Size = new System.Drawing.Size(145, 20);
            this.NguoiLienHeTextEdit.StyleController = this.dataLayoutDetail;
            this.NguoiLienHeTextEdit.TabIndex = 9;
            // 
            // ItemForTamNgung
            // 
            this.ItemForTamNgung.Control = this.TamNgungCheckEdit;
            this.ItemForTamNgung.Location = new System.Drawing.Point(0, 144);
            this.ItemForTamNgung.Name = "ItemForTamNgung";
            this.ItemForTamNgung.Size = new System.Drawing.Size(280, 71);
            this.ItemForTamNgung.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForTamNgung.TextVisible = false;
            // 
            // TamNgungCheckEdit
            // 
            this.TamNgungCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TamNgung", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TamNgungCheckEdit.Location = new System.Drawing.Point(12, 156);
            this.TamNgungCheckEdit.MenuManager = this.ribbonControlMenu;
            this.TamNgungCheckEdit.Name = "TamNgungCheckEdit";
            this.TamNgungCheckEdit.Properties.Caption = "Tạm Ngưng";
            this.TamNgungCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TamNgungCheckEdit.Size = new System.Drawing.Size(276, 20);
            this.TamNgungCheckEdit.StyleController = this.dataLayoutDetail;
            this.TamNgungCheckEdit.TabIndex = 10;
            // 
            // NhaCungCapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NhaCungCapView";
            this.Size = new System.Drawing.Size(791, 385);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutDetail)).EndInit();
            this.dataLayoutDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNCCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNhaCungCapTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DienThoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNguoiLienHe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiLienHeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTamNgung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamNgungCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit MaNCCTextEdit;
        private DevExpress.XtraEditors.TextEdit TenNhaCungCapTextEdit;
        private DevExpress.XtraEditors.TextEdit DiaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit DienThoaiTextEdit;
        private DevExpress.XtraEditors.TextEdit TaiKhoanTextEdit;
        private DevExpress.XtraEditors.TextEdit NguoiLienHeTextEdit;
        private DevExpress.XtraEditors.CheckEdit TamNgungCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaNCC;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenNhaCungCap;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDienThoai;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaiKhoan;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNguoiLienHe;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTamNgung;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
    }
}
