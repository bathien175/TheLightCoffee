namespace DoAnThucTap.GUI
{
    partial class adminManagement_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminManagement_GUI));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.itemNameStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemPersonal = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemListStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemAuthor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemSalary = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemMenu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemTop = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemExtraFee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemTable = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemIngredient = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemImport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement15 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement16 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement14 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemNameStaff,
            this.accordionControlSeparator1,
            this.accordionControlElement2,
            this.accordionControlElement8,
            this.accordionControlElement3,
            this.accordionControlElement4,
            this.accordionControlElement5,
            this.accordionControlElement6});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(311, 757);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // itemNameStaff
            // 
            this.itemNameStaff.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemPersonal,
            this.itemLogOut});
            this.itemNameStaff.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left)});
            this.itemNameStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemNameStaff.ImageOptions.Image")));
            this.itemNameStaff.Name = "itemNameStaff";
            this.itemNameStaff.Text = "Admin";
            // 
            // itemPersonal
            // 
            this.itemPersonal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemPersonal.ImageOptions.Image")));
            this.itemPersonal.Name = "itemPersonal";
            this.itemPersonal.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemPersonal.Text = "Cá nhân";
            this.itemPersonal.Click += new System.EventHandler(this.itemPersonal_Click);
            // 
            // itemLogOut
            // 
            this.itemLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemLogOut.ImageOptions.Image")));
            this.itemLogOut.Name = "itemLogOut";
            this.itemLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemLogOut.Text = "Đăng xuất";
            this.itemLogOut.Click += new System.EventHandler(this.itemLogOut_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Khách hàng";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemListStaff,
            this.itemAuthor,
            this.itemSalary});
            this.accordionControlElement8.Expanded = true;
            this.accordionControlElement8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement8.ImageOptions.Image")));
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Text = "Nhân viên";
            // 
            // itemListStaff
            // 
            this.itemListStaff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemListStaff.ImageOptions.SvgImage")));
            this.itemListStaff.Name = "itemListStaff";
            this.itemListStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemListStaff.Text = "Danh sách nhân viên";
            // 
            // itemAuthor
            // 
            this.itemAuthor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemAuthor.ImageOptions.SvgImage")));
            this.itemAuthor.Name = "itemAuthor";
            this.itemAuthor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemAuthor.Text = "Cấp quyền";
            // 
            // itemSalary
            // 
            this.itemSalary.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemSalary.ImageOptions.SvgImage")));
            this.itemSalary.Name = "itemSalary";
            this.itemSalary.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemSalary.Text = "Tính lương";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemMenu,
            this.itemTop,
            this.itemExtraFee,
            this.itemTable});
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Hàng hóa - Dịch vụ";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // itemMenu
            // 
            this.itemMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemMenu.ImageOptions.SvgImage")));
            this.itemMenu.Name = "itemMenu";
            this.itemMenu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemMenu.Text = "Thực đơn";
            // 
            // itemTop
            // 
            this.itemTop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemTop.ImageOptions.SvgImage")));
            this.itemTop.Name = "itemTop";
            this.itemTop.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemTop.Text = "Bảng xếp hạng";
            // 
            // itemExtraFee
            // 
            this.itemExtraFee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemExtraFee.ImageOptions.SvgImage")));
            this.itemExtraFee.Name = "itemExtraFee";
            this.itemExtraFee.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemExtraFee.Text = "Phụ thu";
            // 
            // itemTable
            // 
            this.itemTable.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemTable.ImageOptions.SvgImage")));
            this.itemTable.Name = "itemTable";
            this.itemTable.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemTable.Text = "Bàn";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemIngredient,
            this.itemImport});
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Kho";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // itemIngredient
            // 
            this.itemIngredient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemIngredient.ImageOptions.SvgImage")));
            this.itemIngredient.Name = "itemIngredient";
            this.itemIngredient.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemIngredient.Text = "Nguyên vật liệu";
            // 
            // itemImport
            // 
            this.itemImport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("itemImport.ImageOptions.SvgImage")));
            this.itemImport.Name = "itemImport";
            this.itemImport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemImport.Text = "Nhập kho";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement15,
            this.accordionControlElement16});
            this.accordionControlElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement5.ImageOptions.Image")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Thu chi";
            // 
            // accordionControlElement15
            // 
            this.accordionControlElement15.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement15.ImageOptions.SvgImage")));
            this.accordionControlElement15.Name = "accordionControlElement15";
            this.accordionControlElement15.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement15.Text = "Các khoản thu";
            // 
            // accordionControlElement16
            // 
            this.accordionControlElement16.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement16.ImageOptions.SvgImage")));
            this.accordionControlElement16.Name = "accordionControlElement16";
            this.accordionControlElement16.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement16.Text = "Các khoản chi";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement12,
            this.accordionControlElement13,
            this.accordionControlElement14});
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Báo cáo";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement12.ImageOptions.SvgImage")));
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Báo cáo tổng quan";
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement13.ImageOptions.Image")));
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Báo cáo bán hàng";
            // 
            // accordionControlElement14
            // 
            this.accordionControlElement14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement14.ImageOptions.Image")));
            this.accordionControlElement14.Name = "accordionControlElement14";
            this.accordionControlElement14.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement14.Text = "Báo cáo nhập hàng";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1516, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Bán hàng";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "Hóa đơn trong ngày";
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 0;
            this.pnlMain.BorderThickness = 0;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(311, 39);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = false;
            this.pnlMain.Size = new System.Drawing.Size(1205, 757);
            this.pnlMain.TabIndex = 3;
            // 
            // adminManagement_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1516, 796);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::DoAnThucTap.Properties.Resources.manager;
            this.Name = "adminManagement_GUI";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện dành cho quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminManagement_GUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemNameStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemPersonal;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemLogOut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemListStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemAuthor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemSalary;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemTop;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemExtraFee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemTable;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemIngredient;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemImport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement15;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement16;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement14;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
    }
}