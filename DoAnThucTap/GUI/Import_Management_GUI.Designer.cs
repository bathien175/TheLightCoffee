namespace DoAnThucTap.GUI
{
    partial class Import_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_Management_GUI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcImport = new DevExpress.XtraGrid.GridControl();
            this.gvListImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Import_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Import_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Import_Staff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Import_TotalMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListImport)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPrinter,
            this.btnClose});
            this.barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrinter),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar1.Text = "Tools";
            // 
            // btnPrinter
            // 
            this.btnPrinter.Caption = "In đầy đủ";
            this.btnPrinter.Id = 5;
            this.btnPrinter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinter.ImageOptions.Image")));
            this.btnPrinter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrinter.ImageOptions.LargeImage")));
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrinter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrinter_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 6;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1417, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 703);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1417, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 673);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1417, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 673);
            // 
            // gcImport
            // 
            this.gcImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcImport.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcImport.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcImport.Location = new System.Drawing.Point(0, 30);
            this.gcImport.MainView = this.gvListImport;
            this.gcImport.Margin = new System.Windows.Forms.Padding(4);
            this.gcImport.MenuManager = this.barManager1;
            this.gcImport.Name = "gcImport";
            this.gcImport.Size = new System.Drawing.Size(1417, 673);
            this.gcImport.TabIndex = 13;
            this.gcImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListImport});
            // 
            // gvListImport
            // 
            this.gvListImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Import_ID,
            this.Import_Date,
            this.Import_Staff,
            this.Import_TotalMoney});
            this.gvListImport.DetailHeight = 437;
            this.gvListImport.GridControl = this.gcImport;
            this.gvListImport.Name = "gvListImport";
            this.gvListImport.OptionsFind.AlwaysVisible = true;
            this.gvListImport.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListImport.OptionsView.ShowAutoFilterRow = true;
            this.gvListImport.OptionsView.ShowGroupPanel = false;
            this.gvListImport.RowHeight = 20;
            // 
            // Import_ID
            // 
            this.Import_ID.Caption = "Số phiếu nhập";
            this.Import_ID.FieldName = "Import_ID";
            this.Import_ID.MinWidth = 12;
            this.Import_ID.Name = "Import_ID";
            this.Import_ID.Visible = true;
            this.Import_ID.VisibleIndex = 0;
            this.Import_ID.Width = 250;
            // 
            // Import_Date
            // 
            this.Import_Date.Caption = "Ngày nhập";
            this.Import_Date.FieldName = "Import_Date";
            this.Import_Date.MinWidth = 25;
            this.Import_Date.Name = "Import_Date";
            this.Import_Date.Visible = true;
            this.Import_Date.VisibleIndex = 1;
            this.Import_Date.Width = 300;
            // 
            // Import_Staff
            // 
            this.Import_Staff.Caption = "Nhân viên";
            this.Import_Staff.FieldName = "Import_Staff";
            this.Import_Staff.MinWidth = 31;
            this.Import_Staff.Name = "Import_Staff";
            this.Import_Staff.Visible = true;
            this.Import_Staff.VisibleIndex = 2;
            this.Import_Staff.Width = 350;
            // 
            // Import_TotalMoney
            // 
            this.Import_TotalMoney.Caption = "Số tiền";
            this.Import_TotalMoney.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.Import_TotalMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Import_TotalMoney.FieldName = "Import_TotalMoney";
            this.Import_TotalMoney.MinWidth = 31;
            this.Import_TotalMoney.Name = "Import_TotalMoney";
            this.Import_TotalMoney.Visible = true;
            this.Import_TotalMoney.VisibleIndex = 3;
            this.Import_TotalMoney.Width = 487;
            // 
            // Import_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 703);
            this.Controls.Add(this.gcImport);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Import_Management_GUI.IconOptions.Icon")));
            this.Name = "Import_Management_GUI";
            this.Text = "Quản lý nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListImport;
        private DevExpress.XtraGrid.Columns.GridColumn Import_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Import_Date;
        private DevExpress.XtraGrid.Columns.GridColumn Import_Staff;
        private DevExpress.XtraGrid.Columns.GridColumn Import_TotalMoney;
    }
}