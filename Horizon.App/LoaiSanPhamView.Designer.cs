namespace Horizon.App
{
    partial class LoaiSanPhamView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSanPhamView));
            this.colMaLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.MaLoaiSanPhamTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForMaLoaiSanPham = new DevExpress.XtraLayout.LayoutControlItem();
            this.TenLoaiSanPhamTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTenLoaiSanPham = new DevExpress.XtraLayout.LayoutControlItem();
            this.TamNgungCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForTamNgung = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutDetail)).BeginInit();
            this.dataLayoutDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaLoaiSanPhamTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaLoaiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenLoaiSanPhamTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenLoaiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamNgungCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTamNgung)).BeginInit();
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
            this.bindingSource.DataSource = typeof(Horizon.Models.LoaiSanPham);
            // 
            // dataLayoutDetail
            // 
            this.dataLayoutDetail.Appearance.ControlReadOnly.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dataLayoutDetail.Appearance.ControlReadOnly.Options.UseForeColor = true;
            this.dataLayoutDetail.Controls.Add(this.MaLoaiSanPhamTextEdit);
            this.dataLayoutDetail.Controls.Add(this.TenLoaiSanPhamTextEdit);
            this.dataLayoutDetail.Controls.Add(this.TamNgungCheckEdit);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            // 
            // gridViewCollection
            // 
            this.gridViewCollection.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiSanPham,
            this.colTenLoaiSanPham});
            this.gridViewCollection.OptionsBehavior.Editable = false;
            // 
            // colMaLoaiSanPham
            // 
            this.colMaLoaiSanPham.FieldName = "MaLoaiSanPham";
            this.colMaLoaiSanPham.Name = "colMaLoaiSanPham";
            this.colMaLoaiSanPham.Visible = true;
            this.colMaLoaiSanPham.VisibleIndex = 0;
            // 
            // colTenLoaiSanPham
            // 
            this.colTenLoaiSanPham.FieldName = "TenLoaiSanPham";
            this.colTenLoaiSanPham.Name = "colTenLoaiSanPham";
            this.colTenLoaiSanPham.Visible = true;
            this.colTenLoaiSanPham.VisibleIndex = 1;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaLoaiSanPham,
            this.ItemForTenLoaiSanPham,
            this.ItemForTamNgung});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(280, 332);
            // 
            // MaLoaiSanPhamTextEdit
            // 
            this.MaLoaiSanPhamTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaLoaiSanPham", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaLoaiSanPhamTextEdit.Location = new System.Drawing.Point(79, 12);
            this.MaLoaiSanPhamTextEdit.MenuManager = this.ribbonControlMenu;
            this.MaLoaiSanPhamTextEdit.Name = "MaLoaiSanPhamTextEdit";
            this.MaLoaiSanPhamTextEdit.Size = new System.Drawing.Size(209, 20);
            this.MaLoaiSanPhamTextEdit.StyleController = this.dataLayoutDetail;
            this.MaLoaiSanPhamTextEdit.TabIndex = 4;
            // 
            // ItemForMaLoaiSanPham
            // 
            this.ItemForMaLoaiSanPham.Control = this.MaLoaiSanPhamTextEdit;
            this.ItemForMaLoaiSanPham.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaLoaiSanPham.Name = "ItemForMaLoaiSanPham";
            this.ItemForMaLoaiSanPham.Size = new System.Drawing.Size(280, 24);
            this.ItemForMaLoaiSanPham.TextSize = new System.Drawing.Size(55, 13);
            // 
            // TenLoaiSanPhamTextEdit
            // 
            this.TenLoaiSanPhamTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TenLoaiSanPham", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TenLoaiSanPhamTextEdit.Location = new System.Drawing.Point(79, 36);
            this.TenLoaiSanPhamTextEdit.MenuManager = this.ribbonControlMenu;
            this.TenLoaiSanPhamTextEdit.Name = "TenLoaiSanPhamTextEdit";
            this.TenLoaiSanPhamTextEdit.Size = new System.Drawing.Size(209, 20);
            this.TenLoaiSanPhamTextEdit.StyleController = this.dataLayoutDetail;
            this.TenLoaiSanPhamTextEdit.TabIndex = 5;
            // 
            // ItemForTenLoaiSanPham
            // 
            this.ItemForTenLoaiSanPham.Control = this.TenLoaiSanPhamTextEdit;
            this.ItemForTenLoaiSanPham.Location = new System.Drawing.Point(0, 24);
            this.ItemForTenLoaiSanPham.Name = "ItemForTenLoaiSanPham";
            this.ItemForTenLoaiSanPham.Size = new System.Drawing.Size(280, 24);
            this.ItemForTenLoaiSanPham.TextSize = new System.Drawing.Size(55, 13);
            // 
            // TamNgungCheckEdit
            // 
            this.TamNgungCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TamNgung", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TamNgungCheckEdit.Location = new System.Drawing.Point(12, 60);
            this.TamNgungCheckEdit.MenuManager = this.ribbonControlMenu;
            this.TamNgungCheckEdit.Name = "TamNgungCheckEdit";
            this.TamNgungCheckEdit.Properties.Caption = "Tạm Ngưng";
            this.TamNgungCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TamNgungCheckEdit.Size = new System.Drawing.Size(276, 20);
            this.TamNgungCheckEdit.StyleController = this.dataLayoutDetail;
            this.TamNgungCheckEdit.TabIndex = 6;
            // 
            // ItemForTamNgung
            // 
            this.ItemForTamNgung.Control = this.TamNgungCheckEdit;
            this.ItemForTamNgung.Location = new System.Drawing.Point(0, 48);
            this.ItemForTamNgung.Name = "ItemForTamNgung";
            this.ItemForTamNgung.Size = new System.Drawing.Size(280, 284);
            this.ItemForTamNgung.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForTamNgung.TextVisible = false;
            // 
            // LoaiSanPhamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LoaiSanPhamView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutDetail)).EndInit();
            this.dataLayoutDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaLoaiSanPhamTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaLoaiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenLoaiSanPhamTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenLoaiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamNgungCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTamNgung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiSanPham;
        private DevExpress.XtraEditors.TextEdit MaLoaiSanPhamTextEdit;
        private DevExpress.XtraEditors.TextEdit TenLoaiSanPhamTextEdit;
        private DevExpress.XtraEditors.CheckEdit TamNgungCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaLoaiSanPham;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenLoaiSanPham;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTamNgung;
    }
}
