namespace DoAnThucTap.GUI
{
    partial class menu_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_Management_GUI));
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cbbCategory = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ptImageProduct = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtUnitProduct = new System.Windows.Forms.TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvListProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Product_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_isActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openfile = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
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
            this.btnDelete.Caption = "Xóa món";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1409, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 771);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1409, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 747);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1409, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 747);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.cbbCategory);
            this.splitContainerControl1.Panel1.Controls.Add(this.ptImageProduct);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel5);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPriceProduct);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel4);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtUnitProduct);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel3);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNameProduct);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcProduct);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1409, 747);
            this.splitContainerControl1.SplitterPosition = 184;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // cbbCategory
            // 
            this.cbbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbbCategory.BackgroundColor = System.Drawing.Color.White;
            this.cbbCategory.BorderColor = System.Drawing.Color.Silver;
            this.cbbCategory.BorderRadius = 1;
            this.cbbCategory.Color = System.Drawing.Color.Silver;
            this.cbbCategory.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbCategory.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbCategory.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbCategory.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbCategory.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCategory.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbCategory.FillDropDown = true;
            this.cbbCategory.FillIndicator = false;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Icon = null;
            this.cbbCategory.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbCategory.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbCategory.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbCategory.ItemBackColor = System.Drawing.Color.White;
            this.cbbCategory.ItemBorderColor = System.Drawing.Color.White;
            this.cbbCategory.ItemForeColor = System.Drawing.Color.Black;
            this.cbbCategory.ItemHeight = 26;
            this.cbbCategory.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbCategory.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbCategory.ItemTopMargin = 3;
            this.cbbCategory.Location = new System.Drawing.Point(229, 97);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(333, 32);
            this.cbbCategory.TabIndex = 10;
            this.cbbCategory.Text = null;
            this.cbbCategory.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbCategory.TextLeftMargin = 5;
            // 
            // ptImageProduct
            // 
            this.ptImageProduct.AllowFocused = false;
            this.ptImageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ptImageProduct.AutoSizeHeight = true;
            this.ptImageProduct.BorderRadius = 0;
            this.ptImageProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptImageProduct.Image = global::DoAnThucTap.Properties.Resources.noimage;
            this.ptImageProduct.IsCircle = true;
            this.ptImageProduct.Location = new System.Drawing.Point(13, 39);
            this.ptImageProduct.Margin = new System.Windows.Forms.Padding(4);
            this.ptImageProduct.Name = "ptImageProduct";
            this.ptImageProduct.Size = new System.Drawing.Size(136, 136);
            this.ptImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptImageProduct.TabIndex = 9;
            this.ptImageProduct.TabStop = false;
            this.ptImageProduct.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.ptImageProduct.Click += new System.EventHandler(this.ptImageProduct_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.AutoSize = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(29, 4);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(98, 21);
            this.bunifuLabel5.TabIndex = 8;
            this.bunifuLabel5.Text = "Ảnh minh họa";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPriceProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceProduct.Location = new System.Drawing.Point(700, 101);
            this.txtPriceProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(343, 26);
            this.txtPriceProduct.TabIndex = 7;
            this.txtPriceProduct.Enter += new System.EventHandler(this.txtPriceProduct_Enter);
            this.txtPriceProduct.Leave += new System.EventHandler(this.txtPriceProduct_Leave);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(570, 106);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(122, 21);
            this.bunifuLabel4.TabIndex = 6;
            this.bunifuLabel4.Text = "Đơn giá bán:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtUnitProduct
            // 
            this.txtUnitProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUnitProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUnitProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUnitProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitProduct.Location = new System.Drawing.Point(700, 39);
            this.txtUnitProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitProduct.Name = "txtUnitProduct";
            this.txtUnitProduct.Size = new System.Drawing.Size(343, 26);
            this.txtUnitProduct.TabIndex = 5;
            this.txtUnitProduct.TextChanged += new System.EventHandler(this.txtUnitProduct_TextChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(570, 39);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(122, 29);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "Đơn vị tính:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(157, 106);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(64, 21);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Thể loại:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.Location = new System.Drawing.Point(229, 39);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(333, 26);
            this.txtNameProduct.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(157, 44);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(64, 21);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Tên món:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gcProduct
            // 
            this.gcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcProduct.Location = new System.Drawing.Point(0, 0);
            this.gcProduct.MainView = this.gvListProduct;
            this.gcProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gcProduct.MenuManager = this.barManager1;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.Size = new System.Drawing.Size(1409, 553);
            this.gcProduct.TabIndex = 0;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListProduct});
            // 
            // gvListProduct
            // 
            this.gvListProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Product_Image,
            this.Product_Category,
            this.Product_Unit,
            this.Product_Price,
            this.Product_isActive});
            this.gvListProduct.DetailHeight = 437;
            this.gvListProduct.GridControl = this.gcProduct;
            this.gvListProduct.Name = "gvListProduct";
            this.gvListProduct.OptionsFind.AlwaysVisible = true;
            this.gvListProduct.OptionsView.ShowAutoFilterRow = true;
            this.gvListProduct.OptionsView.ShowGroupPanel = false;
            this.gvListProduct.RowHeight = 125;
            this.gvListProduct.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvListProduct_RowClick);
            // 
            // Product_ID
            // 
            this.Product_ID.Caption = "ID";
            this.Product_ID.FieldName = "Product_ID";
            this.Product_ID.MinWidth = 12;
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Visible = true;
            this.Product_ID.VisibleIndex = 0;
            this.Product_ID.Width = 81;
            // 
            // Product_Name
            // 
            this.Product_Name.Caption = "Tên món";
            this.Product_Name.FieldName = "Product_Name";
            this.Product_Name.MinWidth = 31;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Visible = true;
            this.Product_Name.VisibleIndex = 1;
            this.Product_Name.Width = 750;
            // 
            // Product_Image
            // 
            this.Product_Image.Caption = "Ảnh minh họa";
            this.Product_Image.FieldName = "Product_Image";
            this.Product_Image.MinWidth = 31;
            this.Product_Image.Name = "Product_Image";
            this.Product_Image.OptionsFilter.AllowAutoFilter = false;
            this.Product_Image.OptionsFilter.AllowFilter = false;
            this.Product_Image.Visible = true;
            this.Product_Image.VisibleIndex = 2;
            this.Product_Image.Width = 200;
            // 
            // Product_Category
            // 
            this.Product_Category.Caption = "Loại";
            this.Product_Category.FieldName = "Product_Category";
            this.Product_Category.MinWidth = 31;
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Visible = true;
            this.Product_Category.VisibleIndex = 3;
            this.Product_Category.Width = 125;
            // 
            // Product_Unit
            // 
            this.Product_Unit.Caption = "Đơn vị tính";
            this.Product_Unit.FieldName = "Product_Unit";
            this.Product_Unit.MinWidth = 31;
            this.Product_Unit.Name = "Product_Unit";
            this.Product_Unit.Visible = true;
            this.Product_Unit.VisibleIndex = 4;
            this.Product_Unit.Width = 165;
            // 
            // Product_Price
            // 
            this.Product_Price.Caption = "Giá bán";
            this.Product_Price.FieldName = "Product_Price";
            this.Product_Price.MinWidth = 31;
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.Visible = true;
            this.Product_Price.VisibleIndex = 5;
            this.Product_Price.Width = 386;
            // 
            // Product_isActive
            // 
            this.Product_isActive.Caption = "Trạng thái";
            this.Product_isActive.FieldName = "Product_isActive";
            this.Product_isActive.MinWidth = 31;
            this.Product_isActive.Name = "Product_isActive";
            this.Product_isActive.Visible = true;
            this.Product_isActive.VisibleIndex = 6;
            this.Product_isActive.Width = 117;
            // 
            // openfile
            // 
            this.openfile.FileName = "filedialog";
            // 
            // menu_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1409, 771);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("menu_Management_GUI.IconOptions.Icon")));
            this.Name = "menu_Management_GUI";
            this.Text = "Quản lý thực đơn";
            this.Load += new System.EventHandler(this.menu_Management_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptImageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnPrinter;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Bunifu.UI.WinForms.BunifuDropdown cbbCategory;
        private Bunifu.UI.WinForms.BunifuPictureBox ptImageProduct;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.TextBox txtUnitProduct;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.TextBox txtNameProduct;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListProduct;
        private DevExpress.XtraGrid.Columns.GridColumn Product_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Category;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Price;
        private DevExpress.XtraGrid.Columns.GridColumn Product_Image;
        private DevExpress.XtraGrid.Columns.GridColumn Product_isActive;
        private DevExpress.XtraEditors.XtraOpenFileDialog openfile;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
    }
}