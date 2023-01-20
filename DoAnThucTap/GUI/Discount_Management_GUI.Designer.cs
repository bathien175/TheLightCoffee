namespace DoAnThucTap.GUI
{
    partial class Discount_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount_Management_GUI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnApply = new DevExpress.XtraBars.BarButtonItem();
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
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpkDateEnd = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtpkDateStart = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.nbrPer = new System.Windows.Forms.NumericUpDown();
            this.btnAllproduct = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gcDiscount = new DevExpress.XtraGrid.GridControl();
            this.gvListDiscount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Discount_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount_DateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount_DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount_Per = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListDiscount)).BeginInit();
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
            this.btnRestore,
            this.btnApply});
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnApply),
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
            // btnApply
            // 
            this.btnApply.Caption = "Áp dụng khuyến mãi";
            this.btnApply.Id = 8;
            this.btnApply.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.ImageOptions.Image")));
            this.btnApply.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnApply.ImageOptions.LargeImage")));
            this.btnApply.Name = "btnApply";
            this.btnApply.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnApply.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnApply_ItemClick);
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
            this.barDockControl1.Size = new System.Drawing.Size(1499, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 759);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1499, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 735);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1499, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 735);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel5);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpkDateEnd);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel4);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtpkDateStart);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel2);
            this.splitContainerControl1.Panel1.Controls.Add(this.nbrPer);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAllproduct);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtName);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcDiscount);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1499, 735);
            this.splitContainerControl1.SplitterPosition = 89;
            this.splitContainerControl1.TabIndex = 7;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.AutoSize = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(402, 48);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel5.TabIndex = 17;
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
            this.dtpkDateEnd.Location = new System.Drawing.Point(561, 48);
            this.dtpkDateEnd.MinimumSize = new System.Drawing.Size(0, 32);
            this.dtpkDateEnd.Name = "dtpkDateEnd";
            this.dtpkDateEnd.Size = new System.Drawing.Size(222, 32);
            this.dtpkDateEnd.TabIndex = 16;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(13, 48);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel4.TabIndex = 15;
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
            this.dtpkDateStart.Location = new System.Drawing.Point(173, 48);
            this.dtpkDateStart.MinimumSize = new System.Drawing.Size(0, 32);
            this.dtpkDateStart.Name = "dtpkDateStart";
            this.dtpkDateStart.Size = new System.Drawing.Size(222, 32);
            this.dtpkDateStart.TabIndex = 14;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(1240, 9);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(151, 29);
            this.bunifuLabel2.TabIndex = 13;
            this.bunifuLabel2.Text = "Phần trăm ưu đãi";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // nbrPer
            // 
            this.nbrPer.BackColor = System.Drawing.Color.White;
            this.nbrPer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrPer.Location = new System.Drawing.Point(1153, 10);
            this.nbrPer.Name = "nbrPer";
            this.nbrPer.Size = new System.Drawing.Size(80, 24);
            this.nbrPer.TabIndex = 12;
            // 
            // btnAllproduct
            // 
            this.btnAllproduct.AllowBindingControlAnimation = true;
            this.btnAllproduct.AllowBindingControlColorChanges = false;
            this.btnAllproduct.AllowBindingControlLocation = true;
            this.btnAllproduct.AllowCheckBoxAnimation = false;
            this.btnAllproduct.AllowCheckmarkAnimation = true;
            this.btnAllproduct.AllowOnHoverStates = true;
            this.btnAllproduct.AutoCheck = true;
            this.btnAllproduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAllproduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllproduct.BackgroundImage")));
            this.btnAllproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAllproduct.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.btnAllproduct.BorderRadius = 12;
            this.btnAllproduct.Checked = true;
            this.btnAllproduct.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.btnAllproduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAllproduct.CustomCheckmarkImage = null;
            this.btnAllproduct.Location = new System.Drawing.Point(893, 12);
            this.btnAllproduct.MinimumSize = new System.Drawing.Size(17, 17);
            this.btnAllproduct.Name = "btnAllproduct";
            this.btnAllproduct.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAllproduct.OnCheck.BorderRadius = 12;
            this.btnAllproduct.OnCheck.BorderThickness = 2;
            this.btnAllproduct.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.btnAllproduct.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.btnAllproduct.OnCheck.CheckmarkThickness = 2;
            this.btnAllproduct.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.btnAllproduct.OnDisable.BorderRadius = 12;
            this.btnAllproduct.OnDisable.BorderThickness = 2;
            this.btnAllproduct.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.btnAllproduct.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.btnAllproduct.OnDisable.CheckmarkThickness = 2;
            this.btnAllproduct.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAllproduct.OnHoverChecked.BorderRadius = 12;
            this.btnAllproduct.OnHoverChecked.BorderThickness = 2;
            this.btnAllproduct.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAllproduct.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.btnAllproduct.OnHoverChecked.CheckmarkThickness = 2;
            this.btnAllproduct.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAllproduct.OnHoverUnchecked.BorderRadius = 12;
            this.btnAllproduct.OnHoverUnchecked.BorderThickness = 1;
            this.btnAllproduct.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.btnAllproduct.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllproduct.OnUncheck.BorderRadius = 12;
            this.btnAllproduct.OnUncheck.BorderThickness = 1;
            this.btnAllproduct.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.btnAllproduct.Size = new System.Drawing.Size(21, 21);
            this.btnAllproduct.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.btnAllproduct.TabIndex = 11;
            this.btnAllproduct.ThreeState = false;
            this.btnAllproduct.ToolTipText = null;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(921, 9);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(225, 29);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Áp dụng toàn bộ sản phẩm";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(173, 8);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(713, 26);
            this.txtName.TabIndex = 9;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(13, 8);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(152, 29);
            this.bunifuLabel3.TabIndex = 8;
            this.bunifuLabel3.Text = "Lý do giảm giá:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gcDiscount
            // 
            this.gcDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiscount.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDiscount.Location = new System.Drawing.Point(0, 0);
            this.gcDiscount.MainView = this.gvListDiscount;
            this.gcDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.gcDiscount.MenuManager = this.barManager1;
            this.gcDiscount.Name = "gcDiscount";
            this.gcDiscount.Size = new System.Drawing.Size(1499, 636);
            this.gcDiscount.TabIndex = 0;
            this.gcDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListDiscount});
            // 
            // gvListDiscount
            // 
            this.gvListDiscount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Discount_ID,
            this.Discount_Name,
            this.Discount_Type,
            this.Discount_DateStart,
            this.Discount_DateEnd,
            this.Discount_Per});
            this.gvListDiscount.DetailHeight = 437;
            this.gvListDiscount.GridControl = this.gcDiscount;
            this.gvListDiscount.Name = "gvListDiscount";
            this.gvListDiscount.OptionsFind.AlwaysVisible = true;
            this.gvListDiscount.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListDiscount.OptionsView.ShowAutoFilterRow = true;
            this.gvListDiscount.OptionsView.ShowGroupPanel = false;
            this.gvListDiscount.RowHeight = 20;
            this.gvListDiscount.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvListDiscount_RowClick);
            // 
            // Discount_ID
            // 
            this.Discount_ID.Caption = "ID";
            this.Discount_ID.FieldName = "Discount_ID";
            this.Discount_ID.MinWidth = 12;
            this.Discount_ID.Name = "Discount_ID";
            this.Discount_ID.Visible = true;
            this.Discount_ID.VisibleIndex = 0;
            this.Discount_ID.Width = 69;
            // 
            // Discount_Name
            // 
            this.Discount_Name.Caption = "Tên mã giảm";
            this.Discount_Name.FieldName = "Discount_Name";
            this.Discount_Name.MinWidth = 31;
            this.Discount_Name.Name = "Discount_Name";
            this.Discount_Name.Visible = true;
            this.Discount_Name.VisibleIndex = 1;
            this.Discount_Name.Width = 738;
            // 
            // Discount_Type
            // 
            this.Discount_Type.Caption = "Loại giảm giá";
            this.Discount_Type.FieldName = "Discount_Type";
            this.Discount_Type.MinWidth = 31;
            this.Discount_Type.Name = "Discount_Type";
            this.Discount_Type.Visible = true;
            this.Discount_Type.VisibleIndex = 2;
            this.Discount_Type.Width = 191;
            // 
            // Discount_DateStart
            // 
            this.Discount_DateStart.Caption = "Ngày bắt đầu";
            this.Discount_DateStart.FieldName = "Discount_DateStart";
            this.Discount_DateStart.MinWidth = 31;
            this.Discount_DateStart.Name = "Discount_DateStart";
            this.Discount_DateStart.Visible = true;
            this.Discount_DateStart.VisibleIndex = 3;
            this.Discount_DateStart.Width = 191;
            // 
            // Discount_DateEnd
            // 
            this.Discount_DateEnd.Caption = "Ngày kết thúc";
            this.Discount_DateEnd.FieldName = "Discount_DateEnd";
            this.Discount_DateEnd.MinWidth = 25;
            this.Discount_DateEnd.Name = "Discount_DateEnd";
            this.Discount_DateEnd.Visible = true;
            this.Discount_DateEnd.VisibleIndex = 4;
            this.Discount_DateEnd.Width = 191;
            // 
            // Discount_Per
            // 
            this.Discount_Per.Caption = "Phần trăm";
            this.Discount_Per.FieldName = "Discount_Per";
            this.Discount_Per.MinWidth = 25;
            this.Discount_Per.Name = "Discount_Per";
            this.Discount_Per.Visible = true;
            this.Discount_Per.VisibleIndex = 5;
            this.Discount_Per.Width = 100;
            // 
            // Discount_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1499, 759);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Discount_Management_GUI.IconOptions.Icon")));
            this.Name = "Discount_Management_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khuyến mãi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbrPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListDiscount)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn Discount_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Discount_Type;
        private DevExpress.XtraGrid.Columns.GridColumn Discount_DateStart;
        private DevExpress.XtraGrid.Columns.GridColumn Discount_DateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn Discount_Per;
        private Bunifu.UI.WinForms.BunifuCheckBox btnAllproduct;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.NumericUpDown nbrPer;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpkDateEnd;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpkDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn Discount_Name;
        private DevExpress.XtraBars.BarButtonItem btnApply;
    }
}