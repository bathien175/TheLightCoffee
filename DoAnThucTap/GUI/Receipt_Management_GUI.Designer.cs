namespace DoAnThucTap.GUI
{
    partial class Receipt_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Management_GUI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcReceipt = new DevExpress.XtraGrid.GridControl();
            this.gvListReceipt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.receipt_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receipt_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receipt_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receipt_time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receipt_staff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receipt_money = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListReceipt)).BeginInit();
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
            this.barDockControl1.Size = new System.Drawing.Size(1422, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 729);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1422, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 699);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1422, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 699);
            // 
            // gcReceipt
            // 
            this.gcReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReceipt.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcReceipt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcReceipt.Location = new System.Drawing.Point(0, 30);
            this.gcReceipt.MainView = this.gvListReceipt;
            this.gcReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.gcReceipt.MenuManager = this.barManager1;
            this.gcReceipt.Name = "gcReceipt";
            this.gcReceipt.Size = new System.Drawing.Size(1422, 699);
            this.gcReceipt.TabIndex = 14;
            this.gcReceipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListReceipt});
            // 
            // gvListReceipt
            // 
            this.gvListReceipt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.receipt_ID,
            this.receipt_name,
            this.receipt_type,
            this.receipt_time,
            this.receipt_staff,
            this.receipt_money});
            this.gvListReceipt.DetailHeight = 437;
            this.gvListReceipt.GridControl = this.gcReceipt;
            this.gvListReceipt.Name = "gvListReceipt";
            this.gvListReceipt.OptionsFind.AlwaysVisible = true;
            this.gvListReceipt.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListReceipt.OptionsView.ShowAutoFilterRow = true;
            this.gvListReceipt.OptionsView.ShowGroupPanel = false;
            this.gvListReceipt.RowHeight = 20;
            // 
            // receipt_ID
            // 
            this.receipt_ID.Caption = "Số phiếu thu";
            this.receipt_ID.FieldName = "receipt_ID";
            this.receipt_ID.MinWidth = 12;
            this.receipt_ID.Name = "receipt_ID";
            this.receipt_ID.Visible = true;
            this.receipt_ID.VisibleIndex = 0;
            this.receipt_ID.Width = 100;
            // 
            // receipt_name
            // 
            this.receipt_name.Caption = "Lý do lập";
            this.receipt_name.FieldName = "receipt_name";
            this.receipt_name.MinWidth = 25;
            this.receipt_name.Name = "receipt_name";
            this.receipt_name.Visible = true;
            this.receipt_name.VisibleIndex = 1;
            this.receipt_name.Width = 300;
            // 
            // receipt_type
            // 
            this.receipt_type.Caption = "Loại phiếu";
            this.receipt_type.FieldName = "receipt_type";
            this.receipt_type.MinWidth = 31;
            this.receipt_type.Name = "receipt_type";
            this.receipt_type.Visible = true;
            this.receipt_type.VisibleIndex = 2;
            this.receipt_type.Width = 150;
            // 
            // receipt_time
            // 
            this.receipt_time.Caption = "Thời gian lập";
            this.receipt_time.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss tt";
            this.receipt_time.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.receipt_time.FieldName = "receipt_time";
            this.receipt_time.MinWidth = 25;
            this.receipt_time.Name = "receipt_time";
            this.receipt_time.Visible = true;
            this.receipt_time.VisibleIndex = 3;
            this.receipt_time.Width = 300;
            // 
            // receipt_staff
            // 
            this.receipt_staff.Caption = "Nhân viên lập";
            this.receipt_staff.FieldName = "receipt_staff";
            this.receipt_staff.MinWidth = 25;
            this.receipt_staff.Name = "receipt_staff";
            this.receipt_staff.Visible = true;
            this.receipt_staff.VisibleIndex = 4;
            this.receipt_staff.Width = 300;
            // 
            // receipt_money
            // 
            this.receipt_money.Caption = "Số tiền";
            this.receipt_money.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.receipt_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.receipt_money.FieldName = "receipt_money";
            this.receipt_money.MinWidth = 31;
            this.receipt_money.Name = "receipt_money";
            this.receipt_money.Visible = true;
            this.receipt_money.VisibleIndex = 5;
            this.receipt_money.Width = 242;
            // 
            // Receipt_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1422, 729);
            this.Controls.Add(this.gcReceipt);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Receipt_Management_GUI.IconOptions.Icon")));
            this.Name = "Receipt_Management_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListReceipt)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListReceipt;
        private DevExpress.XtraGrid.Columns.GridColumn receipt_ID;
        private DevExpress.XtraGrid.Columns.GridColumn receipt_name;
        private DevExpress.XtraGrid.Columns.GridColumn receipt_type;
        private DevExpress.XtraGrid.Columns.GridColumn receipt_time;
        private DevExpress.XtraGrid.Columns.GridColumn receipt_staff;
        private DevExpress.XtraGrid.Columns.GridColumn receipt_money;
    }
}