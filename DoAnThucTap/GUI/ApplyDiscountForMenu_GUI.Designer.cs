namespace DoAnThucTap.GUI
{
    partial class ApplyDiscountForMenu_GUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyDiscountForMenu_GUI));
            this.gcApplyDiscount = new DevExpress.XtraGrid.GridControl();
            this.gvApplyDiscount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Product_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcApplyDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcApplyDiscount
            // 
            this.gcApplyDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcApplyDiscount.Location = new System.Drawing.Point(0, 31);
            this.gcApplyDiscount.MainView = this.gvApplyDiscount;
            this.gcApplyDiscount.Name = "gcApplyDiscount";
            this.gcApplyDiscount.Size = new System.Drawing.Size(1026, 596);
            this.gcApplyDiscount.TabIndex = 0;
            this.gcApplyDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvApplyDiscount});
            this.gcApplyDiscount.Click += new System.EventHandler(this.gcApplyDiscount_Click);
            // 
            // gvApplyDiscount
            // 
            this.gvApplyDiscount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Product_Unit,
            this.Product_Price});
            this.gvApplyDiscount.GridControl = this.gcApplyDiscount;
            this.gvApplyDiscount.Name = "gvApplyDiscount";
            // 
            // Product_ID
            // 
            this.Product_ID.Caption = "ID";
            this.Product_ID.FieldName = "Product_ID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Visible = true;
            this.Product_ID.VisibleIndex = 0;
            this.Product_ID.Width = 100;
            // 
            // Product_Name
            // 
            this.Product_Name.Caption = "Tên sản phẩm";
            this.Product_Name.FieldName = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Visible = true;
            this.Product_Name.VisibleIndex = 1;
            this.Product_Name.Width = 333;
            // 
            // Product_Unit
            // 
            this.Product_Unit.Caption = "Đơn vị tính";
            this.Product_Unit.FieldName = "Product_Unit";
            this.Product_Unit.Name = "Product_Unit";
            this.Product_Unit.Visible = true;
            this.Product_Unit.VisibleIndex = 2;
            this.Product_Unit.Width = 100;
            // 
            // Product_Price
            // 
            this.Product_Price.Caption = "Giá tiền";
            this.Product_Price.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.Product_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Product_Price.FieldName = "Product_Price";
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.Visible = true;
            this.Product_Price.VisibleIndex = 3;
            this.Product_Price.Width = 179;
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1026, 31);
            this.toolbarFormControl1.TabIndex = 1;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.barButtonItem1);
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.toolbarFormManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1026, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1026, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 596);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1026, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 596);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Xác nhận";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ApplyDiscountForMenu_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1026, 627);
            this.Controls.Add(this.gcApplyDiscount);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ApplyDiscountForMenu_GUI.IconOptions.Icon")));
            this.Name = "ApplyDiscountForMenu_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Áp dụng khuyến mãi";
            this.ToolbarFormControl = this.toolbarFormControl1;
            ((System.ComponentModel.ISupportInitialize)(this.gcApplyDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplyDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcApplyDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvApplyDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn Product_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Price;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}