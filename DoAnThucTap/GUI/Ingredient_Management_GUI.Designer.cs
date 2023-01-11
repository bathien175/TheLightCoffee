namespace DoAnThucTap.GUI
{
    partial class Ingredient_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingredient_Management_GUI));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ptImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gcIngredient = new DevExpress.XtraGrid.GridControl();
            this.gvListIngredient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ingredient_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ingredient_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ingredient_Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ingredient_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ingredient_Reserved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ingredient_PriceImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ingredient_isActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 30);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(1321, 0);
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
            this.barDockControl1.Size = new System.Drawing.Size(1321, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 750);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1321, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 720);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1321, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 720);
            // 
            // openfile
            // 
            this.openfile.FileName = "filedialog";
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
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPrice);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtName);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.ptImage);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel5);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtUnit);
            this.splitContainerControl1.Panel1.Controls.Add(this.bunifuLabel3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcIngredient);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1321, 720);
            this.splitContainerControl1.SplitterPosition = 184;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(290, 111);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(408, 30);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(157, 112);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(121, 29);
            this.bunifuLabel2.TabIndex = 12;
            this.bunifuLabel2.Text = "Đơn giá nhập:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(290, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(408, 30);
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
            this.bunifuLabel1.Location = new System.Drawing.Point(157, 45);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(125, 29);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Tên sản phẩm:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
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
            this.ptImage.Location = new System.Drawing.Point(13, 35);
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
            this.bunifuLabel5.Location = new System.Drawing.Point(24, 7);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(109, 23);
            this.bunifuLabel5.TabIndex = 8;
            this.bunifuLabel5.Text = "Ảnh minh họa";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(821, 44);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(450, 30);
            this.txtUnit.TabIndex = 5;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(706, 46);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(107, 29);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "Đơn vị tính:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gcIngredient
            // 
            this.gcIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcIngredient.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcIngredient.Location = new System.Drawing.Point(0, 0);
            this.gcIngredient.MainView = this.gvListIngredient;
            this.gcIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.gcIngredient.MenuManager = this.barManager1;
            this.gcIngredient.Name = "gcIngredient";
            this.gcIngredient.Size = new System.Drawing.Size(1321, 524);
            this.gcIngredient.TabIndex = 0;
            this.gcIngredient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListIngredient});
            // 
            // gvListIngredient
            // 
            this.gvListIngredient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ingredient_ID,
            this.Ingredient_Name,
            this.Ingredient_Image,
            this.Ingredient_Unit,
            this.Ingredient_Reserved,
            this.Ingredient_PriceImport,
            this.Ingredient_isActive});
            this.gvListIngredient.DetailHeight = 437;
            this.gvListIngredient.GridControl = this.gcIngredient;
            this.gvListIngredient.Name = "gvListIngredient";
            this.gvListIngredient.OptionsFind.AlwaysVisible = true;
            this.gvListIngredient.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvListIngredient.OptionsView.ShowAutoFilterRow = true;
            this.gvListIngredient.OptionsView.ShowGroupPanel = false;
            this.gvListIngredient.RowHeight = 125;
            this.gvListIngredient.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvListIngredient_RowClick);
            // 
            // Ingredient_ID
            // 
            this.Ingredient_ID.Caption = "ID";
            this.Ingredient_ID.FieldName = "Ingredient_ID";
            this.Ingredient_ID.MinWidth = 12;
            this.Ingredient_ID.Name = "Ingredient_ID";
            this.Ingredient_ID.Visible = true;
            this.Ingredient_ID.VisibleIndex = 0;
            this.Ingredient_ID.Width = 71;
            // 
            // Ingredient_Name
            // 
            this.Ingredient_Name.Caption = "Tên món";
            this.Ingredient_Name.FieldName = "Ingredient_Name";
            this.Ingredient_Name.MinWidth = 31;
            this.Ingredient_Name.Name = "Ingredient_Name";
            this.Ingredient_Name.Visible = true;
            this.Ingredient_Name.VisibleIndex = 1;
            this.Ingredient_Name.Width = 662;
            // 
            // Ingredient_Image
            // 
            this.Ingredient_Image.Caption = "Ảnh minh họa";
            this.Ingredient_Image.FieldName = "Ingredient_Image";
            this.Ingredient_Image.MinWidth = 31;
            this.Ingredient_Image.Name = "Ingredient_Image";
            this.Ingredient_Image.Visible = true;
            this.Ingredient_Image.VisibleIndex = 2;
            this.Ingredient_Image.Width = 176;
            // 
            // Ingredient_Unit
            // 
            this.Ingredient_Unit.Caption = "Đơn vị tính";
            this.Ingredient_Unit.FieldName = "Ingredient_Unit";
            this.Ingredient_Unit.MinWidth = 31;
            this.Ingredient_Unit.Name = "Ingredient_Unit";
            this.Ingredient_Unit.Visible = true;
            this.Ingredient_Unit.VisibleIndex = 4;
            this.Ingredient_Unit.Width = 250;
            // 
            // Ingredient_Reserved
            // 
            this.Ingredient_Reserved.Caption = "Tồn kho";
            this.Ingredient_Reserved.FieldName = "Ingredient_Reserved";
            this.Ingredient_Reserved.MinWidth = 31;
            this.Ingredient_Reserved.Name = "Ingredient_Reserved";
            this.Ingredient_Reserved.Visible = true;
            this.Ingredient_Reserved.VisibleIndex = 3;
            this.Ingredient_Reserved.Width = 110;
            // 
            // Ingredient_PriceImport
            // 
            this.Ingredient_PriceImport.Caption = "Đơn giá nhập";
            this.Ingredient_PriceImport.FieldName = "Ingredient_PriceImport";
            this.Ingredient_PriceImport.MinWidth = 31;
            this.Ingredient_PriceImport.Name = "Ingredient_PriceImport";
            this.Ingredient_PriceImport.Visible = true;
            this.Ingredient_PriceImport.VisibleIndex = 5;
            this.Ingredient_PriceImport.Width = 191;
            // 
            // Ingredient_isActive
            // 
            this.Ingredient_isActive.Caption = "Trạng thái";
            this.Ingredient_isActive.FieldName = "Ingredient_isActive";
            this.Ingredient_isActive.MinWidth = 31;
            this.Ingredient_isActive.Name = "Ingredient_isActive";
            this.Ingredient_isActive.Visible = true;
            this.Ingredient_isActive.VisibleIndex = 6;
            this.Ingredient_isActive.Width = 154;
            // 
            // Ingredient_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1321, 750);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Ingredient_Management_GUI.IconOptions.Icon")));
            this.Name = "Ingredient_Management_GUI";
            this.Text = "Quản lý nguyên liệu";
            this.Load += new System.EventHandler(this.Ingredient_Management_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
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
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox ptImage;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.TextBox txtUnit;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private DevExpress.XtraGrid.GridControl gcIngredient;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListIngredient;
        private DevExpress.XtraGrid.Columns.GridColumn Ingredient_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Ingredient_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Ingredient_Image;
        private DevExpress.XtraGrid.Columns.GridColumn Ingredient_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn Ingredient_Reserved;
        private DevExpress.XtraGrid.Columns.GridColumn Ingredient_PriceImport;
        private DevExpress.XtraGrid.Columns.GridColumn Ingredient_isActive;
        private System.Windows.Forms.TextBox txtPrice;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}