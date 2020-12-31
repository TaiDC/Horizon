namespace Horizon.App.Common
{
    partial class BaseDictionaryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDictionaryView));
            this.ribbonControlMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrash = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageMajor = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgCommand = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgRefresh = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutDetail = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlCollection = new DevExpress.XtraGrid.GridControl();
            this.gridViewCollection = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlMenu
            // 
            this.ribbonControlMenu.ExpandCollapseItem.Id = 0;
            this.ribbonControlMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMenu.ExpandCollapseItem,
            this.ribbonControlMenu.SearchEditItem,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnTrash,
            this.btnClose,
            this.btnRefresh});
            this.ribbonControlMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlMenu.MaxItemId = 8;
            this.ribbonControlMenu.Name = "ribbonControlMenu";
            this.ribbonControlMenu.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory});
            this.ribbonControlMenu.Size = new System.Drawing.Size(830, 150);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnAdd.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.btnAdd.Name = "btnAdd";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnDelete.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.btnDelete.Name = "btnDelete";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 4;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnSave.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.btnSave.Name = "btnSave";
            // 
            // btnTrash
            // 
            this.btnTrash.Caption = "Bỏ Qua";
            this.btnTrash.Id = 5;
            this.btnTrash.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrash.ImageOptions.SvgImage")));
            this.btnTrash.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.btnTrash.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.btnTrash.Name = "btnTrash";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 6;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q));
            this.btnClose.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.btnClose.Name = "btnClose";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm Mới";
            this.btnRefresh.Id = 7;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.btnRefresh.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.btnRefresh.Name = "btnRefresh";
            // 
            // ribbonPageCategory
            // 
            this.ribbonPageCategory.Name = "ribbonPageCategory";
            this.ribbonPageCategory.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMajor});
            this.ribbonPageCategory.Text = "CHỨC NĂNG";
            // 
            // ribbonPageMajor
            // 
            this.ribbonPageMajor.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAction,
            this.rpgCommand,
            this.rpgClose,
            this.rpgRefresh});
            this.ribbonPageMajor.Name = "ribbonPageMajor";
            this.ribbonPageMajor.Text = "NGHIỆP VỤ";
            // 
            // rpgAction
            // 
            this.rpgAction.ItemLinks.Add(this.btnAdd);
            this.rpgAction.ItemLinks.Add(this.btnEdit);
            this.rpgAction.ItemLinks.Add(this.btnDelete);
            this.rpgAction.Name = "rpgAction";
            // 
            // rpgCommand
            // 
            this.rpgCommand.ItemLinks.Add(this.btnSave);
            this.rpgCommand.ItemLinks.Add(this.btnTrash);
            this.rpgCommand.Name = "rpgCommand";
            // 
            // rpgClose
            // 
            this.rpgClose.ItemLinks.Add(this.btnClose);
            this.rpgClose.Name = "rpgClose";
            // 
            // rpgRefresh
            // 
            this.rpgRefresh.ItemLinks.Add(this.btnRefresh);
            this.rpgRefresh.Name = "rpgRefresh";
            // 
            // dataLayoutDetail
            // 
            this.dataLayoutDetail.AllowCustomization = false;
            this.dataLayoutDetail.Appearance.ControlReadOnly.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dataLayoutDetail.Appearance.ControlReadOnly.Options.UseForeColor = true;
            this.dataLayoutDetail.DataSource = this.bindingSource;
            this.dataLayoutDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataLayoutDetail.Location = new System.Drawing.Point(530, 150);
            this.dataLayoutDetail.Name = "dataLayoutDetail";
            this.dataLayoutDetail.Root = this.layoutControlGroup1;
            this.dataLayoutDetail.Size = new System.Drawing.Size(300, 352);
            this.dataLayoutDetail.TabIndex = 7;
            this.dataLayoutDetail.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(300, 352);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gridControlCollection
            // 
            this.gridControlCollection.DataSource = this.bindingSource;
            this.gridControlCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCollection.Location = new System.Drawing.Point(0, 150);
            this.gridControlCollection.MainView = this.gridViewCollection;
            this.gridControlCollection.Name = "gridControlCollection";
            this.gridControlCollection.Size = new System.Drawing.Size(530, 352);
            this.gridControlCollection.TabIndex = 8;
            this.gridControlCollection.UseDisabledStatePainter = false;
            this.gridControlCollection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCollection});
            // 
            // gridViewCollection
            // 
            this.gridViewCollection.GridControl = this.gridControlCollection;
            this.gridViewCollection.Name = "gridViewCollection";
            this.gridViewCollection.OptionsBehavior.Editable = false;
            // 
            // BaseDictionaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCollection);
            this.Controls.Add(this.dataLayoutDetail);
            this.Controls.Add(this.ribbonControlMenu);
            this.Name = "BaseDictionaryView";
            this.Size = new System.Drawing.Size(830, 502);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMenu;
        public DevExpress.XtraBars.BarButtonItem btnAdd;
        public DevExpress.XtraBars.BarButtonItem btnEdit;
        public DevExpress.XtraBars.BarButtonItem btnDelete;
        public DevExpress.XtraBars.BarButtonItem btnSave;
        public DevExpress.XtraBars.BarButtonItem btnTrash;
        public DevExpress.XtraBars.BarButtonItem btnClose;
        public DevExpress.XtraBars.BarButtonItem btnRefresh;
        public System.Windows.Forms.BindingSource bindingSource;
        public DevExpress.XtraDataLayout.DataLayoutControl dataLayoutDetail;
        public DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        public DevExpress.XtraGrid.GridControl gridControlCollection;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCollection;
        public DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMajor;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAction;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCommand;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgClose;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRefresh;
    }
}
