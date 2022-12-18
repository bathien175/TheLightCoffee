namespace DoAnThucTap.GUI
{
    partial class multip_Import_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(multip_Import_GUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.top = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblData = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tbImport = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.nbrSL = new System.Windows.Forms.NumericUpDown();
            this.btnImport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cbbIngredient = new Bunifu.UI.WinForms.BunifuDropdown();
            this.top.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSL)).BeginInit();
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
            this.top.BorderColor = System.Drawing.Color.Teal;
            this.top.BorderRadius = 0;
            this.top.BorderThickness = 1;
            this.top.Controls.Add(this.lblData);
            this.top.Controls.Add(this.btnBack);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.ShowBorders = true;
            this.top.Size = new System.Drawing.Size(1716, 53);
            this.top.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AllowParentOverrides = false;
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoEllipsis = false;
            this.lblData.AutoSize = false;
            this.lblData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblData.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblData.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(56, 3);
            this.lblData.Name = "lblData";
            this.lblData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblData.Size = new System.Drawing.Size(1657, 47);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Nhập hàng";
            this.lblData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblData.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = global::DoAnThucTap.Properties.Resources.left_arrow;
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 0;
            this.btnBack.ImageSize = new System.Drawing.Size(46, 46);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(47, 47);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = false;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(47, 47);
            this.btnBack.TabIndex = 0;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 0;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 53);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(1716, 650);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel3.BorderRadius = 0;
            this.bunifuPanel3.BorderThickness = 0;
            this.bunifuPanel3.Controls.Add(this.tbImport);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 66);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.Padding = new System.Windows.Forms.Padding(25);
            this.bunifuPanel3.ShowBorders = false;
            this.bunifuPanel3.Size = new System.Drawing.Size(1716, 584);
            this.bunifuPanel3.TabIndex = 1;
            // 
            // tbImport
            // 
            this.tbImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImport.AutoScroll = true;
            this.tbImport.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tbImport.Location = new System.Drawing.Point(28, 28);
            this.tbImport.Name = "tbImport";
            this.tbImport.Size = new System.Drawing.Size(1660, 528);
            this.tbImport.TabIndex = 0;
            this.tbImport.WrapContents = false;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel2.Controls.Add(this.nbrSL);
            this.bunifuPanel2.Controls.Add(this.btnImport);
            this.bunifuPanel2.Controls.Add(this.btnAdd);
            this.bunifuPanel2.Controls.Add(this.cbbIngredient);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = false;
            this.bunifuPanel2.Size = new System.Drawing.Size(1716, 66);
            this.bunifuPanel2.TabIndex = 0;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(640, 6);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(176, 54);
            this.bunifuLabel2.TabIndex = 5;
            this.bunifuLabel2.Text = "Chọn số lượng";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 6);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(134, 54);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Nguyên liệu";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // nbrSL
            // 
            this.nbrSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrSL.Location = new System.Drawing.Point(822, 17);
            this.nbrSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrSL.Name = "nbrSL";
            this.nbrSL.Size = new System.Drawing.Size(101, 30);
            this.nbrSL.TabIndex = 3;
            this.nbrSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnImport
            // 
            this.btnImport.AllowAnimations = true;
            this.btnImport.AllowMouseEffects = true;
            this.btnImport.AllowToggling = false;
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.AnimationSpeed = 200;
            this.btnImport.AutoGenerateColors = false;
            this.btnImport.AutoRoundBorders = false;
            this.btnImport.AutoSizeLeftIcon = true;
            this.btnImport.AutoSizeRightIcon = true;
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BackColor1 = System.Drawing.Color.DarkGreen;
            this.btnImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImport.BackgroundImage")));
            this.btnImport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.ButtonText = "Xuất phiếu nhập";
            this.btnImport.ButtonTextMarginLeft = 0;
            this.btnImport.ColorContrastOnClick = 45;
            this.btnImport.ColorContrastOnHover = 45;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnImport.CustomizableEdges = borderEdges1;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImport.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImport.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnImport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnImport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnImport.IconMarginLeft = 11;
            this.btnImport.IconPadding = 10;
            this.btnImport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnImport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnImport.IconSize = 25;
            this.btnImport.IdleBorderColor = System.Drawing.Color.DarkGreen;
            this.btnImport.IdleBorderRadius = 20;
            this.btnImport.IdleBorderThickness = 1;
            this.btnImport.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.btnImport.IdleIconLeftImage = null;
            this.btnImport.IdleIconRightImage = null;
            this.btnImport.IndicateFocus = false;
            this.btnImport.Location = new System.Drawing.Point(1117, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnImport.OnDisabledState.BorderRadius = 20;
            this.btnImport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.OnDisabledState.BorderThickness = 1;
            this.btnImport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnImport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnImport.OnDisabledState.IconLeftImage = null;
            this.btnImport.OnDisabledState.IconRightImage = null;
            this.btnImport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImport.onHoverState.BorderRadius = 20;
            this.btnImport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.onHoverState.BorderThickness = 1;
            this.btnImport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnImport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnImport.onHoverState.IconLeftImage = null;
            this.btnImport.onHoverState.IconRightImage = null;
            this.btnImport.OnIdleState.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnImport.OnIdleState.BorderRadius = 20;
            this.btnImport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.OnIdleState.BorderThickness = 1;
            this.btnImport.OnIdleState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnImport.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnImport.OnIdleState.IconLeftImage = null;
            this.btnImport.OnIdleState.IconRightImage = null;
            this.btnImport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImport.OnPressedState.BorderRadius = 20;
            this.btnImport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnImport.OnPressedState.BorderThickness = 1;
            this.btnImport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnImport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnImport.OnPressedState.IconLeftImage = null;
            this.btnImport.OnPressedState.IconRightImage = null;
            this.btnImport.Size = new System.Drawing.Size(219, 54);
            this.btnImport.TabIndex = 2;
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImport.TextMarginLeft = 0;
            this.btnImport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnImport.UseDefaultRadiusAndThickness = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.DarkGreen;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Thêm";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges2;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.IdleBorderRadius = 20;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(929, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 20;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.BorderRadius = 20;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.OnIdleState.BorderRadius = 20;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.BorderRadius = 20;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(182, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbIngredient
            // 
            this.cbbIngredient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbIngredient.BackColor = System.Drawing.Color.Transparent;
            this.cbbIngredient.BackgroundColor = System.Drawing.Color.White;
            this.cbbIngredient.BorderColor = System.Drawing.Color.Silver;
            this.cbbIngredient.BorderRadius = 1;
            this.cbbIngredient.Color = System.Drawing.Color.Silver;
            this.cbbIngredient.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbIngredient.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbIngredient.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbIngredient.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbIngredient.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbIngredient.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbIngredient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbIngredient.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIngredient.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbIngredient.FillDropDown = true;
            this.cbbIngredient.FillIndicator = false;
            this.cbbIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbIngredient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbIngredient.ForeColor = System.Drawing.Color.Black;
            this.cbbIngredient.FormattingEnabled = true;
            this.cbbIngredient.Icon = null;
            this.cbbIngredient.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbIngredient.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbIngredient.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbIngredient.ItemBackColor = System.Drawing.Color.White;
            this.cbbIngredient.ItemBorderColor = System.Drawing.Color.White;
            this.cbbIngredient.ItemForeColor = System.Drawing.Color.Black;
            this.cbbIngredient.ItemHeight = 26;
            this.cbbIngredient.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbIngredient.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbIngredient.ItemTopMargin = 3;
            this.cbbIngredient.Location = new System.Drawing.Point(152, 15);
            this.cbbIngredient.Name = "cbbIngredient";
            this.cbbIngredient.Size = new System.Drawing.Size(482, 32);
            this.cbbIngredient.TabIndex = 0;
            this.cbbIngredient.Text = null;
            this.cbbIngredient.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbIngredient.TextLeftMargin = 5;
            // 
            // multip_Import_GUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1716, 703);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "multip_Import_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "multip_Import_GUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.top.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbrSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel top;
        private Bunifu.UI.WinForms.BunifuLabel lblData;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.FlowLayoutPanel tbImport;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnImport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuDropdown cbbIngredient;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.NumericUpDown nbrSL;
    }
}