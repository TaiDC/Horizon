namespace Horizon.App
{
    partial class DanhMucView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucView));
            this.colMaDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMaDanhMuc = new DevExpress.XtraLayout.LayoutControlItem();
            this.MaDanhMucTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTenDanhMuc = new DevExpress.XtraLayout.LayoutControlItem();
            this.TenDanhMucTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForLoaiDanhMuc = new DevExpress.XtraLayout.LayoutControlItem();
            this.LoaiDanhMucTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForIdx = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdxTextEdit = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaDanhMucTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenDanhMucTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLoaiDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiDanhMucTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdxTextEdit.Properties)).BeginInit();
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
            this.bindingSource.DataSource = typeof(Horizon.Models.DanhMuc);
            // 
            // dataLayoutDetail
            // 
            this.dataLayoutDetail.Appearance.ControlReadOnly.ForeColor = System.Drawing.Color.SaddleBrown;
            this.dataLayoutDetail.Appearance.ControlReadOnly.Options.UseForeColor = true;
            this.dataLayoutDetail.Controls.Add(this.MaDanhMucTextEdit);
            this.dataLayoutDetail.Controls.Add(this.TenDanhMucTextEdit);
            this.dataLayoutDetail.Controls.Add(this.LoaiDanhMucTextEdit);
            this.dataLayoutDetail.Controls.Add(this.IdxTextEdit);
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
            this.colMaDanhMuc,
            this.colTenDanhMuc,
            this.colLoaiDanhMuc,
            this.colIdx});
            this.gridViewCollection.OptionsBehavior.Editable = false;
            // 
            // colMaDanhMuc
            // 
            this.colMaDanhMuc.FieldName = "MaDanhMuc";
            this.colMaDanhMuc.Name = "colMaDanhMuc";
            this.colMaDanhMuc.Visible = true;
            this.colMaDanhMuc.VisibleIndex = 0;
            // 
            // colTenDanhMuc
            // 
            this.colTenDanhMuc.FieldName = "TenDanhMuc";
            this.colTenDanhMuc.Name = "colTenDanhMuc";
            this.colTenDanhMuc.Visible = true;
            this.colTenDanhMuc.VisibleIndex = 1;
            // 
            // colLoaiDanhMuc
            // 
            this.colLoaiDanhMuc.FieldName = "LoaiDanhMuc";
            this.colLoaiDanhMuc.Name = "colLoaiDanhMuc";
            this.colLoaiDanhMuc.Visible = true;
            this.colLoaiDanhMuc.VisibleIndex = 2;
            // 
            // colIdx
            // 
            this.colIdx.FieldName = "Idx";
            this.colIdx.Name = "colIdx";
            this.colIdx.Visible = true;
            this.colIdx.VisibleIndex = 3;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMaDanhMuc,
            this.ItemForTenDanhMuc,
            this.ItemForLoaiDanhMuc,
            this.ItemForIdx,
            this.ItemForTamNgung});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(280, 332);
            // 
            // ItemForMaDanhMuc
            // 
            this.ItemForMaDanhMuc.Control = this.MaDanhMucTextEdit;
            this.ItemForMaDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaDanhMuc.Name = "ItemForMaDanhMuc";
            this.ItemForMaDanhMuc.Size = new System.Drawing.Size(280, 24);
            this.ItemForMaDanhMuc.TextSize = new System.Drawing.Size(101, 13);
            // 
            // MaDanhMucTextEdit
            // 
            this.MaDanhMucTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "MaDanhMuc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MaDanhMucTextEdit.Location = new System.Drawing.Point(125, 12);
            this.MaDanhMucTextEdit.MenuManager = this.ribbonControlMenu;
            this.MaDanhMucTextEdit.Name = "MaDanhMucTextEdit";
            this.MaDanhMucTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MaDanhMucTextEdit.Size = new System.Drawing.Size(163, 20);
            this.MaDanhMucTextEdit.StyleController = this.dataLayoutDetail;
            this.MaDanhMucTextEdit.TabIndex = 4;
            // 
            // ItemForTenDanhMuc
            // 
            this.ItemForTenDanhMuc.Control = this.TenDanhMucTextEdit;
            this.ItemForTenDanhMuc.Location = new System.Drawing.Point(0, 24);
            this.ItemForTenDanhMuc.Name = "ItemForTenDanhMuc";
            this.ItemForTenDanhMuc.Size = new System.Drawing.Size(280, 24);
            this.ItemForTenDanhMuc.TextSize = new System.Drawing.Size(101, 13);
            // 
            // TenDanhMucTextEdit
            // 
            this.TenDanhMucTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TenDanhMuc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TenDanhMucTextEdit.Location = new System.Drawing.Point(125, 36);
            this.TenDanhMucTextEdit.MenuManager = this.ribbonControlMenu;
            this.TenDanhMucTextEdit.Name = "TenDanhMucTextEdit";
            this.TenDanhMucTextEdit.Size = new System.Drawing.Size(163, 20);
            this.TenDanhMucTextEdit.StyleController = this.dataLayoutDetail;
            this.TenDanhMucTextEdit.TabIndex = 5;
            // 
            // ItemForLoaiDanhMuc
            // 
            this.ItemForLoaiDanhMuc.Control = this.LoaiDanhMucTextEdit;
            this.ItemForLoaiDanhMuc.Location = new System.Drawing.Point(0, 48);
            this.ItemForLoaiDanhMuc.Name = "ItemForLoaiDanhMuc";
            this.ItemForLoaiDanhMuc.Size = new System.Drawing.Size(280, 24);
            this.ItemForLoaiDanhMuc.TextSize = new System.Drawing.Size(101, 13);
            // 
            // LoaiDanhMucTextEdit
            // 
            this.LoaiDanhMucTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "LoaiDanhMuc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LoaiDanhMucTextEdit.Location = new System.Drawing.Point(125, 60);
            this.LoaiDanhMucTextEdit.MenuManager = this.ribbonControlMenu;
            this.LoaiDanhMucTextEdit.Name = "LoaiDanhMucTextEdit";
            this.LoaiDanhMucTextEdit.Size = new System.Drawing.Size(163, 20);
            this.LoaiDanhMucTextEdit.StyleController = this.dataLayoutDetail;
            this.LoaiDanhMucTextEdit.TabIndex = 6;
            // 
            // ItemForIdx
            // 
            this.ItemForIdx.Control = this.IdxTextEdit;
            this.ItemForIdx.Location = new System.Drawing.Point(0, 72);
            this.ItemForIdx.Name = "ItemForIdx";
            this.ItemForIdx.Size = new System.Drawing.Size(280, 24);
            this.ItemForIdx.TextSize = new System.Drawing.Size(101, 13);
            // 
            // IdxTextEdit
            // 
            this.IdxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Idx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdxTextEdit.Location = new System.Drawing.Point(125, 84);
            this.IdxTextEdit.MenuManager = this.ribbonControlMenu;
            this.IdxTextEdit.Name = "IdxTextEdit";
            this.IdxTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdxTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdxTextEdit.Properties.Mask.EditMask = "N0";
            this.IdxTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdxTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdxTextEdit.Size = new System.Drawing.Size(163, 20);
            this.IdxTextEdit.StyleController = this.dataLayoutDetail;
            this.IdxTextEdit.TabIndex = 7;
            // 
            // ItemForTamNgung
            // 
            this.ItemForTamNgung.Control = this.TamNgungCheckEdit;
            this.ItemForTamNgung.Location = new System.Drawing.Point(0, 96);
            this.ItemForTamNgung.Name = "ItemForTamNgung";
            this.ItemForTamNgung.Size = new System.Drawing.Size(280, 236);
            this.ItemForTamNgung.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForTamNgung.TextVisible = false;
            // 
            // TamNgungCheckEdit
            // 
            this.TamNgungCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TamNgung", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TamNgungCheckEdit.Location = new System.Drawing.Point(12, 108);
            this.TamNgungCheckEdit.MenuManager = this.ribbonControlMenu;
            this.TamNgungCheckEdit.Name = "TamNgungCheckEdit";
            this.TamNgungCheckEdit.Properties.Caption = "Tạm Ngưng";
            this.TamNgungCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.TamNgungCheckEdit.Size = new System.Drawing.Size(276, 20);
            this.TamNgungCheckEdit.StyleController = this.dataLayoutDetail;
            this.TamNgungCheckEdit.TabIndex = 8;
            // 
            // DanhMucView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DanhMucView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutDetail)).EndInit();
            this.dataLayoutDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaDanhMucTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenDanhMucTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLoaiDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiDanhMucTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTamNgung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TamNgungCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colMaDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdx;
        private DevExpress.XtraEditors.TextEdit MaDanhMucTextEdit;
        private DevExpress.XtraEditors.TextEdit TenDanhMucTextEdit;
        private DevExpress.XtraEditors.TextEdit LoaiDanhMucTextEdit;
        private DevExpress.XtraEditors.TextEdit IdxTextEdit;
        private DevExpress.XtraEditors.CheckEdit TamNgungCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaDanhMuc;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenDanhMuc;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLoaiDanhMuc;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdx;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTamNgung;
    }
}
