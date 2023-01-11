namespace DoAnThucTap.GUI
{
    partial class Payment_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Management_GUI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcPayment = new DevExpress.XtraGrid.GridControl();
            this.gvListPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.payment_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.payment_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.payment_time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.payment_staff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.payment_money = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListPayment)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 752);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1422, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 722);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1422, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 722);
            // 
            // gcPayment
            // 
            this.gcPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPayment.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcPayment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcPayment.Location = new System.Drawing.Point(0, 30);
            this.gcPayment.MainView = this.gvListPayment;
            this.gcPayment.Margin = new System.Windows.Forms.Padding(4);
            this.gcPayment.MenuManager = this.barManager1;
            this.gcPayment.Name = "gcPayment";
            this.gcPayment.Size = new System.Drawing.Size(1422, 722);
            this.gcPayment.TabIndex = 15;
            this.gcPayment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListPayment});
            // 
            // gvListPayment
            // 
            this.gvListPayment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.payment_ID,
            this.payment_name,
            this.payment_time,
            this.payment_staff,
            this.payment_money});
            this.gvListPayment.DetailHeight = 437;
            this.gvListPayment.GridControl = this.gcPayment;
            this.gvListPayment.Name = "gvListPayment";
            this.gvListPayment.OptionsFind.AlwaysVisible = true;
            this.gvListPayment.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListPayment.OptionsView.ShowAutoFilterRow = true;
            this.gvListPayment.OptionsView.ShowGroupPanel = false;
            this.gvListPayment.RowHeight = 20;
            // 
            // payment_ID
            // 
            this.payment_ID.Caption = "Số phiếu chi";
            this.payment_ID.FieldName = "payment_ID";
            this.payment_ID.MinWidth = 12;
            this.payment_ID.Name = "payment_ID";
            this.payment_ID.Visible = true;
            this.payment_ID.VisibleIndex = 0;
            this.payment_ID.Width = 100;
            // 
            // payment_name
            // 
            this.payment_name.Caption = "Lý do lập";
            this.payment_name.FieldName = "payment_name";
            this.payment_name.MinWidth = 25;
            this.payment_name.Name = "payment_name";
            this.payment_name.Visible = true;
            this.payment_name.VisibleIndex = 1;
            this.payment_name.Width = 300;
            // 
            // payment_time
            // 
            this.payment_time.Caption = "Thời gian lập";
            this.payment_time.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss tt";
            this.payment_time.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.payment_time.FieldName = "payment_time";
            this.payment_time.MinWidth = 25;
            this.payment_time.Name = "payment_time";
            this.payment_time.Visible = true;
            this.payment_time.VisibleIndex = 2;
            this.payment_time.Width = 300;
            // 
            // payment_staff
            // 
            this.payment_staff.Caption = "Nhân viên lập";
            this.payment_staff.FieldName = "payment_staff";
            this.payment_staff.MinWidth = 25;
            this.payment_staff.Name = "payment_staff";
            this.payment_staff.Visible = true;
            this.payment_staff.VisibleIndex = 3;
            this.payment_staff.Width = 300;
            // 
            // payment_money
            // 
            this.payment_money.Caption = "Số tiền";
            this.payment_money.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.payment_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.payment_money.FieldName = "payment_money";
            this.payment_money.MinWidth = 31;
            this.payment_money.Name = "payment_money";
            this.payment_money.Visible = true;
            this.payment_money.VisibleIndex = 4;
            this.payment_money.Width = 242;
            // 
            // Payment_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1422, 752);
            this.Controls.Add(this.gcPayment);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Payment_Management_GUI.IconOptions.Icon")));
            this.Name = "Payment_Management_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu chi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListPayment)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcPayment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListPayment;
        private DevExpress.XtraGrid.Columns.GridColumn payment_ID;
        private DevExpress.XtraGrid.Columns.GridColumn payment_name;
        private DevExpress.XtraGrid.Columns.GridColumn payment_time;
        private DevExpress.XtraGrid.Columns.GridColumn payment_staff;
        private DevExpress.XtraGrid.Columns.GridColumn payment_money;
    }
}