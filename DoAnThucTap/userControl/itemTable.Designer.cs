namespace DoAnThucTap.userControl
{
    partial class itemTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemTable));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblTotalBill = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTableCode = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnOptionBill = new Bunifu.UI.WinForms.BunifuImageButton();
            this.createBill = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTable = new System.Windows.Forms.ToolStripMenuItem();
            this.cancleBook = new System.Windows.Forms.ToolStripMenuItem();
            this.detailBill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrip = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.menuTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Red;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 10;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.lblTime);
            this.bunifuPanel2.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel2.Controls.Add(this.lblTotalBill);
            this.bunifuPanel2.Controls.Add(this.lblTableCode);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 48);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(300, 154);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoEllipsis = false;
            this.lblTime.AutoSize = false;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 132);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(130, 22);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Bây giờ";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 14;
            this.bunifuPictureBox1.Image = global::DoAnThucTap.Properties.Resources.bill__1_;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(29, 29);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AllowParentOverrides = false;
            this.lblTotalBill.AutoEllipsis = false;
            this.lblTotalBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalBill.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.Color.White;
            this.lblTotalBill.Location = new System.Drawing.Point(38, 6);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalBill.Size = new System.Drawing.Size(2, 0);
            this.lblTotalBill.TabIndex = 1;
            this.lblTotalBill.Text = "0";
            this.lblTotalBill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalBill.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTableCode
            // 
            this.lblTableCode.AllowParentOverrides = false;
            this.lblTableCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTableCode.AutoEllipsis = false;
            this.lblTableCode.AutoSize = false;
            this.lblTableCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTableCode.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTableCode.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableCode.ForeColor = System.Drawing.Color.White;
            this.lblTableCode.Location = new System.Drawing.Point(3, 6);
            this.lblTableCode.Name = "lblTableCode";
            this.lblTableCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTableCode.Size = new System.Drawing.Size(294, 145);
            this.lblTableCode.TabIndex = 0;
            this.lblTableCode.Text = "Bàn A11";
            this.lblTableCode.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTableCode.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblStatus);
            this.bunifuPanel1.Controls.Add(this.btnOptionBill);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(300, 48);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AllowParentOverrides = false;
            this.lblStatus.AutoEllipsis = false;
            this.lblStatus.AutoSize = false;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(238, 48);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "    Bàn trống";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnOptionBill
            // 
            this.btnOptionBill.ActiveImage = null;
            this.btnOptionBill.AllowAnimations = true;
            this.btnOptionBill.AllowBuffering = false;
            this.btnOptionBill.AllowToggling = false;
            this.btnOptionBill.AllowZooming = true;
            this.btnOptionBill.AllowZoomingOnFocus = false;
            this.btnOptionBill.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOptionBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOptionBill.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnOptionBill.ErrorImage")));
            this.btnOptionBill.FadeWhenInactive = false;
            this.btnOptionBill.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnOptionBill.Image = global::DoAnThucTap.Properties.Resources.menu;
            this.btnOptionBill.ImageActive = null;
            this.btnOptionBill.ImageLocation = null;
            this.btnOptionBill.ImageMargin = 0;
            this.btnOptionBill.ImageSize = new System.Drawing.Size(56, 47);
            this.btnOptionBill.ImageZoomSize = new System.Drawing.Size(57, 48);
            this.btnOptionBill.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnOptionBill.InitialImage")));
            this.btnOptionBill.Location = new System.Drawing.Point(243, 0);
            this.btnOptionBill.Name = "btnOptionBill";
            this.btnOptionBill.Rotation = 0;
            this.btnOptionBill.ShowActiveImage = true;
            this.btnOptionBill.ShowCursorChanges = true;
            this.btnOptionBill.ShowImageBorders = false;
            this.btnOptionBill.ShowSizeMarkers = false;
            this.btnOptionBill.Size = new System.Drawing.Size(57, 48);
            this.btnOptionBill.TabIndex = 1;
            this.btnOptionBill.ToolTipText = "";
            this.btnOptionBill.WaitOnLoad = false;
            this.btnOptionBill.Zoom = 0;
            this.btnOptionBill.ZoomSpeed = 10;
            // 
            // createBill
            // 
            this.createBill.Image = global::DoAnThucTap.Properties.Resources.invoice;
            this.createBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBill.Name = "createBill";
            this.createBill.Size = new System.Drawing.Size(219, 26);
            this.createBill.Text = "Tạo hóa đơn";
            // 
            // bookTable
            // 
            this.bookTable.Image = global::DoAnThucTap.Properties.Resources.check;
            this.bookTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookTable.Name = "bookTable";
            this.bookTable.Size = new System.Drawing.Size(219, 26);
            this.bookTable.Text = "Đặt bàn";
            // 
            // cancleBook
            // 
            this.cancleBook.Image = global::DoAnThucTap.Properties.Resources.close__1_;
            this.cancleBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancleBook.Name = "cancleBook";
            this.cancleBook.Size = new System.Drawing.Size(219, 26);
            this.cancleBook.Text = "Hủy lệnh đặt";
            // 
            // detailBill
            // 
            this.detailBill.Image = global::DoAnThucTap.Properties.Resources.pencil;
            this.detailBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailBill.Name = "detailBill";
            this.detailBill.Size = new System.Drawing.Size(219, 26);
            this.detailBill.Text = "Xem thông tin hóa đơn";
            // 
            // menuTrip
            // 
            this.menuTrip.BackColor = System.Drawing.Color.White;
            this.menuTrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBill,
            this.bookTable,
            this.cancleBook,
            this.detailBill});
            this.menuTrip.Name = "menuTrip";
            this.menuTrip.Size = new System.Drawing.Size(220, 108);
            this.menuTrip.Style = MetroFramework.MetroColorStyle.Green;
            this.menuTrip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menuTrip.UseCustomBackColor = true;
            this.menuTrip.UseCustomForeColor = true;
            this.menuTrip.UseStyleColors = true;
            // 
            // itemTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "itemTable";
            this.Size = new System.Drawing.Size(300, 202);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.menuTrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnOptionBill;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalBill;
        private Bunifu.UI.WinForms.BunifuLabel lblTableCode;
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private System.Windows.Forms.ToolStripMenuItem createBill;
        private System.Windows.Forms.ToolStripMenuItem bookTable;
        private System.Windows.Forms.ToolStripMenuItem cancleBook;
        private System.Windows.Forms.ToolStripMenuItem detailBill;
        private MetroFramework.Controls.MetroContextMenu menuTrip;
    }
}
