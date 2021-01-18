namespace Horizon.App
{
    partial class BarcodeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonView = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonPrint,
            this.barButtonView,
            this.btnClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Size = new System.Drawing.Size(836, 133);
            // 
            // barButtonPrint
            // 
            this.barButtonPrint.Caption = "In";
            this.barButtonPrint.Id = 1;
            this.barButtonPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonPrint.ImageOptions.SvgImage")));
            this.barButtonPrint.Name = "barButtonPrint";
            // 
            // barButtonView
            // 
            this.barButtonView.Caption = "Xem";
            this.barButtonView.Id = 2;
            this.barButtonView.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonView.ImageOptions.SvgImage")));
            this.barButtonView.Name = "barButtonView";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 3;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonPageCategory1.Text = "CHỨC NĂNG";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "NGHIỆP VỤ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonPrint);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonView);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Print";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Horizon.Models.SanPham);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 133);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(836, 452);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSanPham,
            this.colLoaiSanPham,
            this.colDonGiaNhap});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "LoaiSanPham.TenLoaiSanPham", null, "(Tên Loại SP: Count={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.FieldName = "MaSanPham";
            this.colMaSanPham.MaxWidth = 150;
            this.colMaSanPham.MinWidth = 100;
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.OptionsColumn.AllowEdit = false;
            this.colMaSanPham.Visible = true;
            this.colMaSanPham.VisibleIndex = 1;
            this.colMaSanPham.Width = 137;
            // 
            // colLoaiSanPham
            // 
            this.colLoaiSanPham.FieldName = "LoaiSanPham.TenLoaiSanPham";
            this.colLoaiSanPham.MinWidth = 150;
            this.colLoaiSanPham.Name = "colLoaiSanPham";
            this.colLoaiSanPham.OptionsColumn.AllowEdit = false;
            this.colLoaiSanPham.Visible = true;
            this.colLoaiSanPham.VisibleIndex = 2;
            this.colLoaiSanPham.Width = 502;
            // 
            // colDonGiaNhap
            // 
            this.colDonGiaNhap.DisplayFormat.FormatString = "n0";
            this.colDonGiaNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGiaNhap.FieldName = "DonGiaNhap";
            this.colDonGiaNhap.MaxWidth = 100;
            this.colDonGiaNhap.MinWidth = 50;
            this.colDonGiaNhap.Name = "colDonGiaNhap";
            this.colDonGiaNhap.OptionsColumn.AllowEdit = false;
            this.colDonGiaNhap.Visible = true;
            this.colDonGiaNhap.VisibleIndex = 3;
            this.colDonGiaNhap.Width = 100;
            // 
            // BarcodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BarcodeView";
            this.Size = new System.Drawing.Size(836, 585);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonView;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGiaNhap;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}
