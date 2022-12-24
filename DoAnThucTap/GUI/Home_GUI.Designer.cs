namespace DoAnThucTap.GUI
{
    partial class Home_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_GUI));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.top = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblNameStaff = new Bunifu.UI.WinForms.BunifuLabel();
            this.imgAvatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bottom = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnReportDay = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnIngredient = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTakeAway = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnStaff = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCreateBill = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.bottom.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // top
            // 
            this.top.BackgroundColor = System.Drawing.Color.Teal;
            this.top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top.BackgroundImage")));
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top.BorderColor = System.Drawing.Color.Transparent;
            this.top.BorderRadius = 3;
            this.top.BorderThickness = 1;
            this.top.Controls.Add(this.lblNameStaff);
            this.top.Controls.Add(this.imgAvatar);
            this.top.Controls.Add(this.btnLogout);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.ShowBorders = false;
            this.top.Size = new System.Drawing.Size(1371, 63);
            this.top.TabIndex = 0;
            // 
            // lblNameStaff
            // 
            this.lblNameStaff.AllowParentOverrides = false;
            this.lblNameStaff.AutoEllipsis = false;
            this.lblNameStaff.AutoSize = false;
            this.lblNameStaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameStaff.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNameStaff.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameStaff.ForeColor = System.Drawing.Color.White;
            this.lblNameStaff.Location = new System.Drawing.Point(103, 0);
            this.lblNameStaff.Name = "lblNameStaff";
            this.lblNameStaff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameStaff.Size = new System.Drawing.Size(282, 63);
            this.lblNameStaff.TabIndex = 2;
            this.lblNameStaff.Text = "Tên nhân viên";
            this.lblNameStaff.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameStaff.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // imgAvatar
            // 
            this.imgAvatar.AllowFocused = false;
            this.imgAvatar.AutoSizeHeight = true;
            this.imgAvatar.BorderRadius = 30;
            this.imgAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgAvatar.Image = global::DoAnThucTap.Properties.Resources.manager;
            this.imgAvatar.IsCircle = true;
            this.imgAvatar.Location = new System.Drawing.Point(0, 0);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(60, 60);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 1;
            this.imgAvatar.TabStop = false;
            this.imgAvatar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveImage = null;
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowBuffering = false;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AllowZooming = true;
            this.btnLogout.AllowZoomingOnFocus = false;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Teal;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ErrorImage")));
            this.btnLogout.FadeWhenInactive = false;
            this.btnLogout.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageActive = null;
            this.btnLogout.ImageLocation = null;
            this.btnLogout.ImageMargin = 0;
            this.btnLogout.ImageSize = new System.Drawing.Size(55, 52);
            this.btnLogout.ImageZoomSize = new System.Drawing.Size(56, 53);
            this.btnLogout.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.InitialImage")));
            this.btnLogout.Location = new System.Drawing.Point(1312, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Rotation = 0;
            this.btnLogout.ShowActiveImage = true;
            this.btnLogout.ShowCursorChanges = true;
            this.btnLogout.ShowImageBorders = true;
            this.btnLogout.ShowSizeMarkers = false;
            this.btnLogout.Size = new System.Drawing.Size(56, 53);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.ToolTipText = "";
            this.btnLogout.WaitOnLoad = false;
            this.btnLogout.Zoom = 0;
            this.btnLogout.ZoomSpeed = 10;
            this.btnLogout.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bottom
            // 
            this.bottom.BackgroundColor = System.Drawing.Color.White;
            this.bottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottom.BackgroundImage")));
            this.bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottom.BorderColor = System.Drawing.Color.Transparent;
            this.bottom.BorderRadius = 3;
            this.bottom.BorderThickness = 1;
            this.bottom.Controls.Add(this.bunifuPanel2);
            this.bottom.Controls.Add(this.bunifuPanel1);
            this.bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom.Location = new System.Drawing.Point(0, 63);
            this.bottom.Name = "bottom";
            this.bottom.ShowBorders = false;
            this.bottom.Size = new System.Drawing.Size(1371, 709);
            this.bottom.TabIndex = 1;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Green;
            this.bunifuPanel2.BorderRadius = 20;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnReportDay);
            this.bunifuPanel2.Controls.Add(this.btnIngredient);
            this.bunifuPanel2.Controls.Add(this.btnMenu);
            this.bunifuPanel2.Controls.Add(this.btnTakeAway);
            this.bunifuPanel2.Controls.Add(this.btnStaff);
            this.bunifuPanel2.Controls.Add(this.btnCreateBill);
            this.bunifuPanel2.Location = new System.Drawing.Point(15, 86);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1341, 611);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // btnReportDay
            // 
            this.btnReportDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportDay.BackColor = System.Drawing.Color.Snow;
            this.btnReportDay.color = System.Drawing.Color.Snow;
            this.btnReportDay.colorActive = System.Drawing.Color.RosyBrown;
            this.btnReportDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportDay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportDay.ForeColor = System.Drawing.Color.Black;
            this.btnReportDay.Image = global::DoAnThucTap.Properties.Resources.report;
            this.btnReportDay.ImagePosition = 19;
            this.btnReportDay.ImageZoom = 60;
            this.btnReportDay.LabelPosition = 39;
            this.btnReportDay.LabelText = "Chốt ngày";
            this.btnReportDay.Location = new System.Drawing.Point(896, 326);
            this.btnReportDay.Margin = new System.Windows.Forms.Padding(50, 70, 0, 0);
            this.btnReportDay.Name = "btnReportDay";
            this.btnReportDay.Size = new System.Drawing.Size(200, 200);
            this.btnReportDay.TabIndex = 18;
            this.btnReportDay.Click += new System.EventHandler(this.btnReportDay_Click);
            // 
            // btnIngredient
            // 
            this.btnIngredient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngredient.BackColor = System.Drawing.Color.Snow;
            this.btnIngredient.color = System.Drawing.Color.Snow;
            this.btnIngredient.colorActive = System.Drawing.Color.RosyBrown;
            this.btnIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngredient.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredient.ForeColor = System.Drawing.Color.Black;
            this.btnIngredient.Image = global::DoAnThucTap.Properties.Resources.fruit_basket;
            this.btnIngredient.ImagePosition = 19;
            this.btnIngredient.ImageZoom = 60;
            this.btnIngredient.LabelPosition = 39;
            this.btnIngredient.LabelText = "Nguyên liệu";
            this.btnIngredient.Location = new System.Drawing.Point(566, 326);
            this.btnIngredient.Margin = new System.Windows.Forms.Padding(50, 70, 0, 0);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(200, 200);
            this.btnIngredient.TabIndex = 15;
            this.btnIngredient.Click += new System.EventHandler(this.btnIngredient_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.color = System.Drawing.Color.Snow;
            this.btnMenu.colorActive = System.Drawing.Color.RosyBrown;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = global::DoAnThucTap.Properties.Resources.beverage;
            this.btnMenu.ImagePosition = 19;
            this.btnMenu.ImageZoom = 60;
            this.btnMenu.LabelPosition = 39;
            this.btnMenu.LabelText = "Thực đơn";
            this.btnMenu.Location = new System.Drawing.Point(237, 326);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(50, 70, 0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 200);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTakeAway.BackColor = System.Drawing.Color.Snow;
            this.btnTakeAway.color = System.Drawing.Color.Snow;
            this.btnTakeAway.colorActive = System.Drawing.Color.RosyBrown;
            this.btnTakeAway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeAway.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.ForeColor = System.Drawing.Color.Black;
            this.btnTakeAway.Image = global::DoAnThucTap.Properties.Resources.bill;
            this.btnTakeAway.ImagePosition = 19;
            this.btnTakeAway.ImageZoom = 60;
            this.btnTakeAway.LabelPosition = 39;
            this.btnTakeAway.LabelText = "Mang về";
            this.btnTakeAway.Location = new System.Drawing.Point(566, 70);
            this.btnTakeAway.Margin = new System.Windows.Forms.Padding(50, 70, 0, 0);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(200, 200);
            this.btnTakeAway.TabIndex = 12;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStaff.BackColor = System.Drawing.Color.Snow;
            this.btnStaff.color = System.Drawing.Color.Snow;
            this.btnStaff.colorActive = System.Drawing.Color.RosyBrown;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Image = global::DoAnThucTap.Properties.Resources.human_resources;
            this.btnStaff.ImagePosition = 19;
            this.btnStaff.ImageZoom = 60;
            this.btnStaff.LabelPosition = 39;
            this.btnStaff.LabelText = "Cá nhân";
            this.btnStaff.Location = new System.Drawing.Point(896, 70);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(50, 70, 0, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(200, 200);
            this.btnStaff.TabIndex = 11;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateBill.BackColor = System.Drawing.Color.Snow;
            this.btnCreateBill.color = System.Drawing.Color.Snow;
            this.btnCreateBill.colorActive = System.Drawing.Color.RosyBrown;
            this.btnCreateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBill.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.Black;
            this.btnCreateBill.Image = global::DoAnThucTap.Properties.Resources.store__1_;
            this.btnCreateBill.ImagePosition = 19;
            this.btnCreateBill.ImageZoom = 60;
            this.btnCreateBill.LabelPosition = 39;
            this.btnCreateBill.LabelText = "Bán tại chỗ";
            this.btnCreateBill.Location = new System.Drawing.Point(237, 70);
            this.btnCreateBill.Margin = new System.Windows.Forms.Padding(50, 70, 0, 0);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(200, 200);
            this.btnCreateBill.TabIndex = 10;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Green;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblTime);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 6);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1347, 74);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTime.AutoEllipsis = false;
            this.lblTime.AutoSize = false;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(3, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(1341, 68);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "20/12/2022 00:00:00";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Home_GUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1371, 772);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home_GUI";
            this.Text = "The Light Coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_GUI_FormClosing);
            this.Load += new System.EventHandler(this.Home_GUI_Load);
            this.top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.bottom.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bottom;
        private Bunifu.UI.WinForms.BunifuPanel top;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuImageButton btnLogout;
        private Bunifu.UI.WinForms.BunifuLabel lblNameStaff;
        private Bunifu.UI.WinForms.BunifuPictureBox imgAvatar;
        private System.Windows.Forms.Timer clock;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Framework.UI.BunifuTileButton btnReportDay;
        private Bunifu.Framework.UI.BunifuTileButton btnIngredient;
        private Bunifu.Framework.UI.BunifuTileButton btnMenu;
        private Bunifu.Framework.UI.BunifuTileButton btnTakeAway;
        private Bunifu.Framework.UI.BunifuTileButton btnStaff;
        private Bunifu.Framework.UI.BunifuTileButton btnCreateBill;
    }
}