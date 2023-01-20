namespace DoAnThucTap.GUI
{
    partial class Date_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Date_Management_GUI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnReserved = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cbbType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvListProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StaffExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoneyExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.moneyDate = new DoAnThucTap.userControl.itemMoneyDate();
            this.moneyAll = new DoAnThucTap.userControl.itemMoneyDate();
            this.moneyOut = new DoAnThucTap.userControl.itemMoneyDate();
            this.moneyIn = new DoAnThucTap.userControl.itemMoneyDate();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProduct)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.btnIn,
            this.btnReserved,
            this.btnSave,
            this.btnCancel,
            this.btnPrinter,
            this.btnClose});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReserved),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrinter),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar1.Text = "Tools";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "Lập phiếu";
            this.btnIn.Id = 0;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Hủy";
            this.btnCancel.Id = 4;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnReserved
            // 
            this.btnReserved.Caption = "Kiểm kê tồn kho";
            this.btnReserved.Id = 2;
            this.btnReserved.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReserved.ImageOptions.SvgImage")));
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReserved.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReserved_ItemClick);
            // 
            // btnPrinter
            // 
            this.btnPrinter.Caption = "In báo cáo ngày";
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
            this.barDockControl1.Size = new System.Drawing.Size(1636, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 677);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1636, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 653);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1636, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 653);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.splitContainerControl1);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 24);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(1636, 653);
            this.bunifuPanel1.TabIndex = 11;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 165);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.cbbType);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtTotalMoney);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel4);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtName);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel6);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcProduct);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1636, 488);
            this.splitContainerControl1.SplitterPosition = 109;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // cbbType
            // 
            this.cbbType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbType.BackColor = System.Drawing.Color.Transparent;
            this.cbbType.BackgroundColor = System.Drawing.Color.White;
            this.cbbType.BorderColor = System.Drawing.Color.Silver;
            this.cbbType.BorderRadius = 1;
            this.cbbType.Color = System.Drawing.Color.Silver;
            this.cbbType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbType.FillDropDown = true;
            this.cbbType.FillIndicator = false;
            this.cbbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbType.ForeColor = System.Drawing.Color.Black;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Icon = null;
            this.cbbType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbType.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbType.ItemBackColor = System.Drawing.Color.White;
            this.cbbType.ItemBorderColor = System.Drawing.Color.White;
            this.cbbType.ItemForeColor = System.Drawing.Color.Black;
            this.cbbType.ItemHeight = 26;
            this.cbbType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbType.Items.AddRange(new object[] {
            "Phiếu thu",
            "Nhập tiền thêm",
            "Phiếu chi"});
            this.cbbType.ItemTopMargin = 3;
            this.cbbType.Location = new System.Drawing.Point(1019, 39);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(174, 32);
            this.cbbType.TabIndex = 10;
            this.cbbType.Text = null;
            this.cbbType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbType.TextLeftMargin = 5;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotalMoney.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.Location = new System.Drawing.Point(1282, 41);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(351, 26);
            this.txtTotalMoney.TabIndex = 7;
            this.txtTotalMoney.Enter += new System.EventHandler(this.txtTotalMoney_Enter);
            this.txtTotalMoney.Leave += new System.EventHandler(this.txtTotalMoney_Leave);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(1199, 46);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(61, 19);
            this.bunifuLabel4.TabIndex = 6;
            this.bunifuLabel4.Text = "Tổng tiền:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel4.Click += new System.EventHandler(this.bunifuLabel4_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(930, 48);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(66, 19);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Loại phiếu:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(257, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(667, 26);
            this.txtName.TabIndex = 1;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(130, 46);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(97, 19);
            this.bunifuLabel6.TabIndex = 0;
            this.bunifuLabel6.Text = "Lý do lập phiếu:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gcProduct
            // 
            this.gcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduct.Location = new System.Drawing.Point(0, 0);
            this.gcProduct.MainView = this.gvListProduct;
            this.gcProduct.MenuManager = this.barManager1;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.Size = new System.Drawing.Size(1636, 369);
            this.gcProduct.TabIndex = 0;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListProduct});
            // 
            // gvListProduct
            // 
            this.gvListProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDExport,
            this.NameExport,
            this.StaffExport,
            this.TypeExport,
            this.MoneyExport});
            this.gvListProduct.GridControl = this.gcProduct;
            this.gvListProduct.Name = "gvListProduct";
            this.gvListProduct.OptionsFind.AlwaysVisible = true;
            this.gvListProduct.OptionsView.ShowAutoFilterRow = true;
            this.gvListProduct.OptionsView.ShowGroupPanel = false;
            this.gvListProduct.RowHeight = 10;
            // 
            // IDExport
            // 
            this.IDExport.Caption = "ID";
            this.IDExport.FieldName = "IDExport";
            this.IDExport.MinWidth = 10;
            this.IDExport.Name = "IDExport";
            this.IDExport.Visible = true;
            this.IDExport.VisibleIndex = 0;
            this.IDExport.Width = 100;
            // 
            // NameExport
            // 
            this.NameExport.Caption = "Lý do lập";
            this.NameExport.FieldName = "NameExport";
            this.NameExport.MinWidth = 25;
            this.NameExport.Name = "NameExport";
            this.NameExport.Visible = true;
            this.NameExport.VisibleIndex = 1;
            this.NameExport.Width = 678;
            // 
            // StaffExport
            // 
            this.StaffExport.Caption = "Nhân viên lập";
            this.StaffExport.FieldName = "StaffExport";
            this.StaffExport.MinWidth = 25;
            this.StaffExport.Name = "StaffExport";
            this.StaffExport.OptionsFilter.AllowAutoFilter = false;
            this.StaffExport.OptionsFilter.AllowFilter = false;
            this.StaffExport.Visible = true;
            this.StaffExport.VisibleIndex = 2;
            this.StaffExport.Width = 212;
            // 
            // TypeExport
            // 
            this.TypeExport.Caption = "Loại phiếu";
            this.TypeExport.FieldName = "TypeExport";
            this.TypeExport.MinWidth = 25;
            this.TypeExport.Name = "TypeExport";
            this.TypeExport.Visible = true;
            this.TypeExport.VisibleIndex = 3;
            this.TypeExport.Width = 105;
            // 
            // MoneyExport
            // 
            this.MoneyExport.Caption = "Tổng tiền";
            this.MoneyExport.FieldName = "MoneyExport";
            this.MoneyExport.MinWidth = 25;
            this.MoneyExport.Name = "MoneyExport";
            this.MoneyExport.Visible = true;
            this.MoneyExport.VisibleIndex = 4;
            this.MoneyExport.Width = 337;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.tableLayoutPanel1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = false;
            this.bunifuPanel2.Size = new System.Drawing.Size(1636, 165);
            this.bunifuPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.moneyDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.moneyAll, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.moneyOut, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.moneyIn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1636, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // moneyDate
            // 
            this.moneyDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyDate.getMoney = ((long)(0));
            this.moneyDate.getSetImage = global::DoAnThucTap.Properties.Resources.add;
            this.moneyDate.Gettitle = "Tiền nhập thêm";
            this.moneyDate.Location = new System.Drawing.Point(820, 2);
            this.moneyDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyDate.Name = "moneyDate";
            this.moneyDate.Size = new System.Drawing.Size(405, 161);
            this.moneyDate.TabIndex = 3;
            // 
            // moneyAll
            // 
            this.moneyAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyAll.getMoney = ((long)(0));
            this.moneyAll.getSetImage = global::DoAnThucTap.Properties.Resources.budget;
            this.moneyAll.Gettitle = "Quỹ tiền mặt";
            this.moneyAll.Location = new System.Drawing.Point(1229, 2);
            this.moneyAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyAll.Name = "moneyAll";
            this.moneyAll.Size = new System.Drawing.Size(405, 161);
            this.moneyAll.TabIndex = 2;
            // 
            // moneyOut
            // 
            this.moneyOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyOut.getMoney = ((long)(0));
            this.moneyOut.getSetImage = global::DoAnThucTap.Properties.Resources.money_inflation;
            this.moneyOut.Gettitle = "Chi ra";
            this.moneyOut.Location = new System.Drawing.Point(2, 2);
            this.moneyOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyOut.Name = "moneyOut";
            this.moneyOut.Size = new System.Drawing.Size(405, 161);
            this.moneyOut.TabIndex = 1;
            // 
            // moneyIn
            // 
            this.moneyIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyIn.getMoney = ((long)(0));
            this.moneyIn.getSetImage = global::DoAnThucTap.Properties.Resources.up1;
            this.moneyIn.Gettitle = "Thu vào";
            this.moneyIn.Location = new System.Drawing.Point(411, 2);
            this.moneyIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyIn.Name = "moneyIn";
            this.moneyIn.Size = new System.Drawing.Size(405, 161);
            this.moneyIn.TabIndex = 0;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(1148, 3);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(570, 29);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Doanh thu";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Date_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1636, 677);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Date_Management_GUI.IconOptions.Icon")));
            this.Name = "Date_Management_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dòng tiền ngày";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProduct)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnReserved;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private userControl.itemMoneyDate moneyIn;
        private userControl.itemMoneyDate moneyAll;
        private userControl.itemMoneyDate moneyOut;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Bunifu.UI.WinForms.BunifuDropdown cbbType;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListProduct;
        private DevExpress.XtraGrid.Columns.GridColumn IDExport;
        private DevExpress.XtraGrid.Columns.GridColumn StaffExport;
        private DevExpress.XtraGrid.Columns.GridColumn TypeExport;
        private DevExpress.XtraGrid.Columns.GridColumn MoneyExport;
        private DevExpress.XtraGrid.Columns.GridColumn NameExport;
        private userControl.itemMoneyDate moneyDate;
    }
}