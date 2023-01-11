namespace DoAnThucTap.GUI
{
    partial class Staff_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Management_GUI));
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtStaffCode = new System.Windows.Forms.TextBox();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpkDatebirth = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ptImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gcStaff = new DevExpress.XtraGrid.GridControl();
            this.gvListStaff = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Staff_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_Datebirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_isAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Staff_isActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openfile = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStaff)).BeginInit();
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
            this.barDockControl1.Size = new System.Drawing.Size(1432, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 720);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1432, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 690);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1432, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 690);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 30);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.txtStaffCode);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel7);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbbGender);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel6);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpkDatebirth);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel4);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtAddress);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtName);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.ptImage);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel5);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtSDT);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcStaff);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1432, 690);
            this.splitContainerControl1.SplitterPosition = 184;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStaffCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStaffCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStaffCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffCode.Location = new System.Drawing.Point(317, 30);
            this.txtStaffCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Size = new System.Drawing.Size(291, 30);
            this.txtStaffCode.TabIndex = 19;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.AutoSize = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.Location = new System.Drawing.Point(157, 36);
            this.bunifuLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel7.TabIndex = 18;
            this.bunifuLabel7.Text = "Mã nhân viên:";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbbGender
            // 
            this.cbbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGender.Location = new System.Drawing.Point(1197, 84);
            this.cbbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(219, 24);
            this.cbbGender.TabIndex = 17;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.AutoSize = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(1037, 84);
            this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel6.TabIndex = 16;
            this.bunifuLabel6.Text = "Giới tính:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtpkDatebirth
            // 
            this.dtpkDatebirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpkDatebirth.BackColor = System.Drawing.Color.Transparent;
            this.dtpkDatebirth.BorderRadius = 1;
            this.dtpkDatebirth.Color = System.Drawing.Color.Silver;
            this.dtpkDatebirth.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpkDatebirth.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpkDatebirth.DisabledColor = System.Drawing.Color.Gray;
            this.dtpkDatebirth.DisplayWeekNumbers = false;
            this.dtpkDatebirth.DPHeight = 0;
            this.dtpkDatebirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkDatebirth.FillDatePicker = true;
            this.dtpkDatebirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkDatebirth.ForeColor = System.Drawing.Color.Black;
            this.dtpkDatebirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDatebirth.Icon = ((System.Drawing.Image)(resources.GetObject("dtpkDatebirth.Icon")));
            this.dtpkDatebirth.IconColor = System.Drawing.Color.Gray;
            this.dtpkDatebirth.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpkDatebirth.LeftTextMargin = 5;
            this.dtpkDatebirth.Location = new System.Drawing.Point(776, 84);
            this.dtpkDatebirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkDatebirth.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpkDatebirth.Name = "dtpkDatebirth";
            this.dtpkDatebirth.Size = new System.Drawing.Size(253, 32);
            this.dtpkDatebirth.TabIndex = 15;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(616, 84);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel4.TabIndex = 14;
            this.bunifuLabel4.Text = "Ngày sinh:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(317, 141);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1102, 30);
            this.txtAddress.TabIndex = 13;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(157, 142);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel2.TabIndex = 12;
            this.bunifuLabel2.Text = "Địa chỉ:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(776, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(640, 30);
            this.txtName.TabIndex = 11;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(616, 31);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Tên nhân viên:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ptImage
            // 
            this.ptImage.AllowFocused = false;
            this.ptImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ptImage.AutoSizeHeight = true;
            this.ptImage.BorderRadius = 0;
            this.ptImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptImage.Image = global::DoAnThucTap.Properties.Resources.noimage;
            this.ptImage.IsCircle = true;
            this.ptImage.Location = new System.Drawing.Point(13, 44);
            this.ptImage.Margin = new System.Windows.Forms.Padding(4);
            this.ptImage.Name = "ptImage";
            this.ptImage.Size = new System.Drawing.Size(136, 136);
            this.ptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptImage.TabIndex = 9;
            this.ptImage.TabStop = false;
            this.ptImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.ptImage.Click += new System.EventHandler(this.ptImage_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(22, 7);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(109, 23);
            this.bunifuLabel5.TabIndex = 8;
            this.bunifuLabel5.Text = "Ảnh minh họa";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(317, 84);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(291, 30);
            this.txtSDT.TabIndex = 5;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(157, 84);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "Số điện thoại:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gcStaff
            // 
            this.gcStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStaff.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcStaff.Location = new System.Drawing.Point(0, 0);
            this.gcStaff.MainView = this.gvListStaff;
            this.gcStaff.Margin = new System.Windows.Forms.Padding(4);
            this.gcStaff.MenuManager = this.barManager1;
            this.gcStaff.Name = "gcStaff";
            this.gcStaff.Size = new System.Drawing.Size(1432, 494);
            this.gcStaff.TabIndex = 0;
            this.gcStaff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListStaff});
            // 
            // gvListStaff
            // 
            this.gvListStaff.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Staff_ID,
            this.Staff_Name,
            this.Staff_Image,
            this.Staff_Gender,
            this.Staff_Datebirth,
            this.Staff_Phone,
            this.Staff_Address,
            this.Staff_isAdmin,
            this.Staff_isActive});
            this.gvListStaff.DetailHeight = 437;
            this.gvListStaff.GridControl = this.gcStaff;
            this.gvListStaff.Name = "gvListStaff";
            this.gvListStaff.OptionsFind.AlwaysVisible = true;
            this.gvListStaff.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListStaff.OptionsView.ShowAutoFilterRow = true;
            this.gvListStaff.OptionsView.ShowGroupPanel = false;
            this.gvListStaff.RowHeight = 125;
            this.gvListStaff.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvListStaff_RowClick);
            // 
            // Staff_ID
            // 
            this.Staff_ID.Caption = "ID";
            this.Staff_ID.FieldName = "Staff_ID";
            this.Staff_ID.MinWidth = 12;
            this.Staff_ID.Name = "Staff_ID";
            this.Staff_ID.Visible = true;
            this.Staff_ID.VisibleIndex = 0;
            this.Staff_ID.Width = 46;
            // 
            // Staff_Name
            // 
            this.Staff_Name.Caption = "Tên nhân viên";
            this.Staff_Name.FieldName = "Staff_Name";
            this.Staff_Name.MinWidth = 31;
            this.Staff_Name.Name = "Staff_Name";
            this.Staff_Name.Visible = true;
            this.Staff_Name.VisibleIndex = 1;
            this.Staff_Name.Width = 190;
            // 
            // Staff_Image
            // 
            this.Staff_Image.Caption = "Ảnh";
            this.Staff_Image.FieldName = "Staff_Image";
            this.Staff_Image.MinWidth = 31;
            this.Staff_Image.Name = "Staff_Image";
            this.Staff_Image.Visible = true;
            this.Staff_Image.VisibleIndex = 2;
            this.Staff_Image.Width = 95;
            // 
            // Staff_Gender
            // 
            this.Staff_Gender.Caption = "Giới tính";
            this.Staff_Gender.FieldName = "Staff_Gender";
            this.Staff_Gender.MinWidth = 31;
            this.Staff_Gender.Name = "Staff_Gender";
            this.Staff_Gender.Visible = true;
            this.Staff_Gender.VisibleIndex = 3;
            this.Staff_Gender.Width = 66;
            // 
            // Staff_Datebirth
            // 
            this.Staff_Datebirth.Caption = "Ngày sinh";
            this.Staff_Datebirth.FieldName = "Staff_Datebirth";
            this.Staff_Datebirth.MinWidth = 31;
            this.Staff_Datebirth.Name = "Staff_Datebirth";
            this.Staff_Datebirth.Visible = true;
            this.Staff_Datebirth.VisibleIndex = 4;
            this.Staff_Datebirth.Width = 91;
            // 
            // Staff_Phone
            // 
            this.Staff_Phone.Caption = "Số điện thoại";
            this.Staff_Phone.FieldName = "Staff_Phone";
            this.Staff_Phone.MinWidth = 31;
            this.Staff_Phone.Name = "Staff_Phone";
            this.Staff_Phone.Visible = true;
            this.Staff_Phone.VisibleIndex = 5;
            this.Staff_Phone.Width = 114;
            // 
            // Staff_Address
            // 
            this.Staff_Address.Caption = "Địa chỉ";
            this.Staff_Address.FieldName = "Staff_Address";
            this.Staff_Address.MinWidth = 31;
            this.Staff_Address.Name = "Staff_Address";
            this.Staff_Address.Visible = true;
            this.Staff_Address.VisibleIndex = 6;
            this.Staff_Address.Width = 265;
            // 
            // Staff_isAdmin
            // 
            this.Staff_isAdmin.Caption = "Chức vụ";
            this.Staff_isAdmin.FieldName = "Staff_isAdmin";
            this.Staff_isAdmin.MinWidth = 31;
            this.Staff_isAdmin.Name = "Staff_isAdmin";
            this.Staff_isAdmin.Visible = true;
            this.Staff_isAdmin.VisibleIndex = 7;
            this.Staff_isAdmin.Width = 125;
            // 
            // Staff_isActive
            // 
            this.Staff_isActive.Caption = "Làm việc";
            this.Staff_isActive.FieldName = "Staff_isActive";
            this.Staff_isActive.MinWidth = 31;
            this.Staff_isActive.Name = "Staff_isActive";
            this.Staff_isActive.Visible = true;
            this.Staff_isActive.VisibleIndex = 8;
            this.Staff_isActive.Width = 125;
            // 
            // openfile
            // 
            this.openfile.FileName = "filedialog";
            // 
            // Staff_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1432, 720);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Staff_Management_GUI.IconOptions.Icon")));
            this.Name = "Staff_Management_GUI";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Staff_Management_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStaff)).EndInit();
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
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TextBox txtAddress;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox ptImage;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.TextBox txtSDT;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private DevExpress.XtraGrid.GridControl gcStaff;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListStaff;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_Image;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_Datebirth;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_Address;
        private System.Windows.Forms.ComboBox cbbGender;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpkDatebirth;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_isAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn Staff_isActive;
        private DevExpress.XtraEditors.XtraOpenFileDialog openfile;
        private System.Windows.Forms.TextBox txtStaffCode;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
    }
}