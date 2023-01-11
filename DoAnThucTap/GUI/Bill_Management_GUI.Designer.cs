namespace DoAnThucTap.GUI
{
    partial class Bill_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Management_GUI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvListBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Bill_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_Table = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_Staff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_DateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_Surchange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bill_TotalMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListBill)).BeginInit();
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
            this.barDockControl1.Size = new System.Drawing.Size(1429, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 675);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1429, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 645);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1429, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 645);
            // 
            // gcBill
            // 
            this.gcBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBill.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcBill.Location = new System.Drawing.Point(0, 30);
            this.gcBill.MainView = this.gvListBill;
            this.gcBill.Margin = new System.Windows.Forms.Padding(4);
            this.gcBill.MenuManager = this.barManager1;
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(1429, 645);
            this.gcBill.TabIndex = 12;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListBill});
            // 
            // gvListBill
            // 
            this.gvListBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Bill_ID,
            this.Bill_Type,
            this.Bill_Table,
            this.Bill_Staff,
            this.Bill_DateStart,
            this.Bill_DateEnd,
            this.Bill_Surchange,
            this.Bill_Discount,
            this.Bill_TotalMoney});
            this.gvListBill.DetailHeight = 437;
            this.gvListBill.GridControl = this.gcBill;
            this.gvListBill.Name = "gvListBill";
            this.gvListBill.OptionsFind.AlwaysVisible = true;
            this.gvListBill.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListBill.OptionsView.ShowAutoFilterRow = true;
            this.gvListBill.OptionsView.ShowGroupPanel = false;
            this.gvListBill.RowHeight = 20;
            // 
            // Bill_ID
            // 
            this.Bill_ID.Caption = "Số hóa đơn";
            this.Bill_ID.FieldName = "Bill_ID";
            this.Bill_ID.MinWidth = 12;
            this.Bill_ID.Name = "Bill_ID";
            this.Bill_ID.Visible = true;
            this.Bill_ID.VisibleIndex = 0;
            this.Bill_ID.Width = 100;
            // 
            // Bill_Type
            // 
            this.Bill_Type.Caption = "Loại hóa đơn";
            this.Bill_Type.FieldName = "Bill_Type";
            this.Bill_Type.MinWidth = 25;
            this.Bill_Type.Name = "Bill_Type";
            this.Bill_Type.Visible = true;
            this.Bill_Type.VisibleIndex = 1;
            this.Bill_Type.Width = 100;
            // 
            // Bill_Table
            // 
            this.Bill_Table.Caption = "Bàn số";
            this.Bill_Table.FieldName = "Bill_Table";
            this.Bill_Table.MinWidth = 31;
            this.Bill_Table.Name = "Bill_Table";
            this.Bill_Table.Visible = true;
            this.Bill_Table.VisibleIndex = 2;
            this.Bill_Table.Width = 100;
            // 
            // Bill_Staff
            // 
            this.Bill_Staff.Caption = "Nhân viên";
            this.Bill_Staff.FieldName = "Bill_Staff";
            this.Bill_Staff.MinWidth = 31;
            this.Bill_Staff.Name = "Bill_Staff";
            this.Bill_Staff.Visible = true;
            this.Bill_Staff.VisibleIndex = 3;
            this.Bill_Staff.Width = 200;
            // 
            // Bill_DateStart
            // 
            this.Bill_DateStart.Caption = "Thời gian vào";
            this.Bill_DateStart.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss:tt";
            this.Bill_DateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Bill_DateStart.FieldName = "Bill_DateStart";
            this.Bill_DateStart.MinWidth = 31;
            this.Bill_DateStart.Name = "Bill_DateStart";
            this.Bill_DateStart.Visible = true;
            this.Bill_DateStart.VisibleIndex = 4;
            this.Bill_DateStart.Width = 200;
            // 
            // Bill_DateEnd
            // 
            this.Bill_DateEnd.Caption = "Thời gian ra";
            this.Bill_DateEnd.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss:tt";
            this.Bill_DateEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Bill_DateEnd.FieldName = "Bill_DateEnd";
            this.Bill_DateEnd.MinWidth = 25;
            this.Bill_DateEnd.Name = "Bill_DateEnd";
            this.Bill_DateEnd.Visible = true;
            this.Bill_DateEnd.VisibleIndex = 5;
            this.Bill_DateEnd.Width = 200;
            // 
            // Bill_Surchange
            // 
            this.Bill_Surchange.Caption = "Phụ thu";
            this.Bill_Surchange.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.Bill_Surchange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Bill_Surchange.FieldName = "Bill_Surchange";
            this.Bill_Surchange.MinWidth = 25;
            this.Bill_Surchange.Name = "Bill_Surchange";
            this.Bill_Surchange.Visible = true;
            this.Bill_Surchange.VisibleIndex = 6;
            this.Bill_Surchange.Width = 150;
            // 
            // Bill_Discount
            // 
            this.Bill_Discount.Caption = "Khuyến mãi";
            this.Bill_Discount.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.Bill_Discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Bill_Discount.FieldName = "Bill_Discount";
            this.Bill_Discount.MinWidth = 25;
            this.Bill_Discount.Name = "Bill_Discount";
            this.Bill_Discount.Visible = true;
            this.Bill_Discount.VisibleIndex = 7;
            this.Bill_Discount.Width = 160;
            // 
            // Bill_TotalMoney
            // 
            this.Bill_TotalMoney.Caption = "Tổng tiền";
            this.Bill_TotalMoney.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.Bill_TotalMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Bill_TotalMoney.FieldName = "Bill_TotalMoney";
            this.Bill_TotalMoney.MinWidth = 25;
            this.Bill_TotalMoney.Name = "Bill_TotalMoney";
            this.Bill_TotalMoney.Visible = true;
            this.Bill_TotalMoney.VisibleIndex = 8;
            this.Bill_TotalMoney.Width = 189;
            // 
            // Bill_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 675);
            this.Controls.Add(this.gcBill);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Bill_Management_GUI.IconOptions.Icon")));
            this.Name = "Bill_Management_GUI";
            this.Text = "Quản lý hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListBill)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListBill;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_Type;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_Table;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_Staff;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_DateStart;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_DateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_Surchange;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_Discount;
        private DevExpress.XtraGrid.Columns.GridColumn Bill_TotalMoney;
    }
}