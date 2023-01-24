namespace DoAnThucTap.GUI
{
    partial class ExtraFee_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraFee_Management_GUI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrinter = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.openfile = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpkDateEnd = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpkDateStart = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gcExtraFee = new DevExpress.XtraGrid.GridControl();
            this.gvListExtraFee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Surcharge_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Surcharge_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Surcharge_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Surcharge_DateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Surcharge_DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcExtraFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListExtraFee)).BeginInit();
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
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnCancel,
            this.btnPrinter,
            this.btnClose,
            this.btnRestore});
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestore),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrinter),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Khôi phục";
            this.btnRestore.Id = 7;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
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
            // btnPrinter
            // 
            this.btnPrinter.Caption = "In";
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
            this.barDockControl1.Size = new System.Drawing.Size(1465, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 728);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1465, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 704);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1465, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 704);
            // 
            // openfile
            // 
            this.openfile.FileName = "filedialog";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 24);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.txtMoney);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel5);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpkDateEnd);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel4);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpkDateStart);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtName);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcExtraFee);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1465, 704);
            this.splitContainerControl1.SplitterPosition = 93;
            this.splitContainerControl1.TabIndex = 7;
            // 
            // txtMoney
            // 
            this.txtMoney.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMoney.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(888, 4);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(564, 26);
            this.txtMoney.TabIndex = 25;
            this.txtMoney.Enter += new System.EventHandler(this.txtMoney_Enter);
            this.txtMoney.Leave += new System.EventHandler(this.txtMoney_Leave);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(786, 8);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(94, 29);
            this.bunifuLabel1.TabIndex = 24;
            this.bunifuLabel1.Text = "Số tiền:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.AutoSize = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(397, 47);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel5.TabIndex = 23;
            this.bunifuLabel5.Text = "Ngày áp dụng:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpkDateEnd
            // 
            this.dtpkDateEnd.BackColor = System.Drawing.Color.Transparent;
            this.dtpkDateEnd.BorderRadius = 1;
            this.dtpkDateEnd.Color = System.Drawing.Color.Silver;
            this.dtpkDateEnd.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpkDateEnd.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpkDateEnd.DisabledColor = System.Drawing.Color.Gray;
            this.dtpkDateEnd.DisplayWeekNumbers = false;
            this.dtpkDateEnd.DPHeight = 0;
            this.dtpkDateEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkDateEnd.FillDatePicker = false;
            this.dtpkDateEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkDateEnd.ForeColor = System.Drawing.Color.Black;
            this.dtpkDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateEnd.Icon = ((System.Drawing.Image)(resources.GetObject("dtpkDateEnd.Icon")));
            this.dtpkDateEnd.IconColor = System.Drawing.Color.Gray;
            this.dtpkDateEnd.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpkDateEnd.LeftTextMargin = 5;
            this.dtpkDateEnd.Location = new System.Drawing.Point(556, 47);
            this.dtpkDateEnd.MinimumSize = new System.Drawing.Size(0, 32);
            this.dtpkDateEnd.Name = "dtpkDateEnd";
            this.dtpkDateEnd.Size = new System.Drawing.Size(222, 32);
            this.dtpkDateEnd.TabIndex = 22;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(4, 47);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(156, 29);
            this.bunifuLabel4.TabIndex = 21;
            this.bunifuLabel4.Text = "Ngày áp dụng:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpkDateStart
            // 
            this.dtpkDateStart.BackColor = System.Drawing.Color.Transparent;
            this.dtpkDateStart.BorderRadius = 1;
            this.dtpkDateStart.Color = System.Drawing.Color.Silver;
            this.dtpkDateStart.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpkDateStart.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpkDateStart.DisabledColor = System.Drawing.Color.Gray;
            this.dtpkDateStart.DisplayWeekNumbers = false;
            this.dtpkDateStart.DPHeight = 0;
            this.dtpkDateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkDateStart.FillDatePicker = false;
            this.dtpkDateStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkDateStart.ForeColor = System.Drawing.Color.Black;
            this.dtpkDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateStart.Icon = ((System.Drawing.Image)(resources.GetObject("dtpkDateStart.Icon")));
            this.dtpkDateStart.IconColor = System.Drawing.Color.Gray;
            this.dtpkDateStart.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpkDateStart.LeftTextMargin = 5;
            this.dtpkDateStart.Location = new System.Drawing.Point(168, 47);
            this.dtpkDateStart.MinimumSize = new System.Drawing.Size(0, 32);
            this.dtpkDateStart.Name = "dtpkDateStart";
            this.dtpkDateStart.Size = new System.Drawing.Size(222, 32);
            this.dtpkDateStart.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(168, 7);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(610, 26);
            this.txtName.TabIndex = 19;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(4, 7);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(156, 29);
            this.bunifuLabel3.TabIndex = 18;
            this.bunifuLabel3.Text = "Lý do giảm giá:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gcExtraFee
            // 
            this.gcExtraFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExtraFee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcExtraFee.Location = new System.Drawing.Point(0, 0);
            this.gcExtraFee.MainView = this.gvListExtraFee;
            this.gcExtraFee.Margin = new System.Windows.Forms.Padding(4);
            this.gcExtraFee.MenuManager = this.barManager1;
            this.gcExtraFee.Name = "gcExtraFee";
            this.gcExtraFee.Size = new System.Drawing.Size(1465, 601);
            this.gcExtraFee.TabIndex = 0;
            this.gcExtraFee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListExtraFee});
            // 
            // gvListExtraFee
            // 
            this.gvListExtraFee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Surcharge_ID,
            this.Surcharge_Name,
            this.Surcharge_Price,
            this.Surcharge_DateStart,
            this.Surcharge_DateEnd});
            this.gvListExtraFee.DetailHeight = 437;
            this.gvListExtraFee.GridControl = this.gcExtraFee;
            this.gvListExtraFee.Name = "gvListExtraFee";
            this.gvListExtraFee.OptionsFind.AlwaysVisible = true;
            this.gvListExtraFee.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListExtraFee.OptionsView.ShowAutoFilterRow = true;
            this.gvListExtraFee.OptionsView.ShowGroupPanel = false;
            this.gvListExtraFee.RowHeight = 20;
            this.gvListExtraFee.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvListExtraFee_RowClick);
            // 
            // Surcharge_ID
            // 
            this.Surcharge_ID.Caption = "ID";
            this.Surcharge_ID.FieldName = "Surcharge_ID";
            this.Surcharge_ID.MinWidth = 12;
            this.Surcharge_ID.Name = "Surcharge_ID";
            this.Surcharge_ID.Visible = true;
            this.Surcharge_ID.VisibleIndex = 0;
            this.Surcharge_ID.Width = 80;
            // 
            // Surcharge_Name
            // 
            this.Surcharge_Name.Caption = "Lý do phụ thu";
            this.Surcharge_Name.FieldName = "Surcharge_Name";
            this.Surcharge_Name.MinWidth = 31;
            this.Surcharge_Name.Name = "Surcharge_Name";
            this.Surcharge_Name.Visible = true;
            this.Surcharge_Name.VisibleIndex = 1;
            this.Surcharge_Name.Width = 748;
            // 
            // Surcharge_Price
            // 
            this.Surcharge_Price.Caption = "Số tiền";
            this.Surcharge_Price.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.Surcharge_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Surcharge_Price.FieldName = "Surcharge_Price";
            this.Surcharge_Price.MinWidth = 31;
            this.Surcharge_Price.Name = "Surcharge_Price";
            this.Surcharge_Price.Visible = true;
            this.Surcharge_Price.VisibleIndex = 2;
            this.Surcharge_Price.Width = 199;
            // 
            // Surcharge_DateStart
            // 
            this.Surcharge_DateStart.Caption = "Ngày áp dụng";
            this.Surcharge_DateStart.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.Surcharge_DateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Surcharge_DateStart.FieldName = "Surcharge_DateStart";
            this.Surcharge_DateStart.MinWidth = 31;
            this.Surcharge_DateStart.Name = "Surcharge_DateStart";
            this.Surcharge_DateStart.Visible = true;
            this.Surcharge_DateStart.VisibleIndex = 3;
            this.Surcharge_DateStart.Width = 282;
            // 
            // Surcharge_DateEnd
            // 
            this.Surcharge_DateEnd.Caption = "Ngày kết thúc";
            this.Surcharge_DateEnd.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.Surcharge_DateEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Surcharge_DateEnd.FieldName = "Surcharge_DateEnd";
            this.Surcharge_DateEnd.MinWidth = 31;
            this.Surcharge_DateEnd.Name = "Surcharge_DateEnd";
            this.Surcharge_DateEnd.Visible = true;
            this.Surcharge_DateEnd.VisibleIndex = 4;
            this.Surcharge_DateEnd.Width = 250;
            // 
            // ExtraFee_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1465, 728);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ExtraFee_Management_GUI.IconOptions.Icon")));
            this.Name = "ExtraFee_Management_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phụ thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcExtraFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListExtraFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraOpenFileDialog openfile;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcExtraFee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListExtraFee;
        private DevExpress.XtraGrid.Columns.GridColumn Surcharge_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Surcharge_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Surcharge_Price;
        private DevExpress.XtraGrid.Columns.GridColumn Surcharge_DateStart;
        private DevExpress.XtraGrid.Columns.GridColumn Surcharge_DateEnd;
        private System.Windows.Forms.TextBox txtMoney;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpkDateEnd;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpkDateStart;
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}