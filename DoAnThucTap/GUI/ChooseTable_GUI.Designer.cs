namespace DoAnThucTap.GUI
{
    partial class ChooseTable_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTable_GUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.top = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblData = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnLocation2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLocation1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLocation0 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTea = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.showTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuTrip = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.createBill = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTable = new System.Windows.Forms.ToolStripMenuItem();
            this.cancleBook = new System.Windows.Forms.ToolStripMenuItem();
            this.detailBill = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánTáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.menuTrip.SuspendLayout();
            this.SuspendLayout();
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
            this.top.Size = new System.Drawing.Size(1375, 53);
            this.top.TabIndex = 1;
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
            this.lblData.Size = new System.Drawing.Size(1316, 47);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Tại cửa hàng";
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
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 2;
            this.bunifuPanel1.Controls.Add(this.btnLocation2);
            this.bunifuPanel1.Controls.Add(this.btnLocation1);
            this.bunifuPanel1.Controls.Add(this.btnLocation0);
            this.bunifuPanel1.Controls.Add(this.btnTea);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 53);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1375, 62);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // btnLocation2
            // 
            this.btnLocation2.AllowAnimations = true;
            this.btnLocation2.AllowMouseEffects = true;
            this.btnLocation2.AllowToggling = false;
            this.btnLocation2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLocation2.AnimationSpeed = 200;
            this.btnLocation2.AutoGenerateColors = false;
            this.btnLocation2.AutoRoundBorders = false;
            this.btnLocation2.AutoSizeLeftIcon = true;
            this.btnLocation2.AutoSizeRightIcon = true;
            this.btnLocation2.BackColor = System.Drawing.Color.Transparent;
            this.btnLocation2.BackColor1 = System.Drawing.Color.Teal;
            this.btnLocation2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocation2.BackgroundImage")));
            this.btnLocation2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation2.ButtonText = "Tầng 2";
            this.btnLocation2.ButtonTextMarginLeft = 0;
            this.btnLocation2.ColorContrastOnClick = 45;
            this.btnLocation2.ColorContrastOnHover = 45;
            this.btnLocation2.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLocation2.CustomizableEdges = borderEdges1;
            this.btnLocation2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLocation2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLocation2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLocation2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLocation2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLocation2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation2.ForeColor = System.Drawing.Color.White;
            this.btnLocation2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocation2.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocation2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLocation2.IconMarginLeft = 11;
            this.btnLocation2.IconPadding = 10;
            this.btnLocation2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocation2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocation2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLocation2.IconSize = 25;
            this.btnLocation2.IdleBorderColor = System.Drawing.Color.Azure;
            this.btnLocation2.IdleBorderRadius = 10;
            this.btnLocation2.IdleBorderThickness = 1;
            this.btnLocation2.IdleFillColor = System.Drawing.Color.Teal;
            this.btnLocation2.IdleIconLeftImage = null;
            this.btnLocation2.IdleIconRightImage = null;
            this.btnLocation2.IndicateFocus = false;
            this.btnLocation2.Location = new System.Drawing.Point(609, 6);
            this.btnLocation2.Name = "btnLocation2";
            this.btnLocation2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLocation2.OnDisabledState.BorderRadius = 10;
            this.btnLocation2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation2.OnDisabledState.BorderThickness = 1;
            this.btnLocation2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLocation2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLocation2.OnDisabledState.IconLeftImage = null;
            this.btnLocation2.OnDisabledState.IconRightImage = null;
            this.btnLocation2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLocation2.onHoverState.BorderRadius = 10;
            this.btnLocation2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation2.onHoverState.BorderThickness = 1;
            this.btnLocation2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLocation2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLocation2.onHoverState.IconLeftImage = null;
            this.btnLocation2.onHoverState.IconRightImage = null;
            this.btnLocation2.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            this.btnLocation2.OnIdleState.BorderRadius = 10;
            this.btnLocation2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation2.OnIdleState.BorderThickness = 1;
            this.btnLocation2.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnLocation2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLocation2.OnIdleState.IconLeftImage = null;
            this.btnLocation2.OnIdleState.IconRightImage = null;
            this.btnLocation2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLocation2.OnPressedState.BorderRadius = 10;
            this.btnLocation2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation2.OnPressedState.BorderThickness = 1;
            this.btnLocation2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLocation2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLocation2.OnPressedState.IconLeftImage = null;
            this.btnLocation2.OnPressedState.IconRightImage = null;
            this.btnLocation2.Size = new System.Drawing.Size(193, 49);
            this.btnLocation2.TabIndex = 4;
            this.btnLocation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLocation2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLocation2.TextMarginLeft = 0;
            this.btnLocation2.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLocation2.UseDefaultRadiusAndThickness = true;
            this.btnLocation2.Click += new System.EventHandler(this.btnLocation2_Click);
            // 
            // btnLocation1
            // 
            this.btnLocation1.AllowAnimations = true;
            this.btnLocation1.AllowMouseEffects = true;
            this.btnLocation1.AllowToggling = false;
            this.btnLocation1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLocation1.AnimationSpeed = 200;
            this.btnLocation1.AutoGenerateColors = false;
            this.btnLocation1.AutoRoundBorders = false;
            this.btnLocation1.AutoSizeLeftIcon = true;
            this.btnLocation1.AutoSizeRightIcon = true;
            this.btnLocation1.BackColor = System.Drawing.Color.Transparent;
            this.btnLocation1.BackColor1 = System.Drawing.Color.Teal;
            this.btnLocation1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocation1.BackgroundImage")));
            this.btnLocation1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation1.ButtonText = "Tầng 1";
            this.btnLocation1.ButtonTextMarginLeft = 0;
            this.btnLocation1.ColorContrastOnClick = 45;
            this.btnLocation1.ColorContrastOnHover = 45;
            this.btnLocation1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLocation1.CustomizableEdges = borderEdges2;
            this.btnLocation1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLocation1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLocation1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLocation1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLocation1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLocation1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation1.ForeColor = System.Drawing.Color.White;
            this.btnLocation1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocation1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocation1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLocation1.IconMarginLeft = 11;
            this.btnLocation1.IconPadding = 10;
            this.btnLocation1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocation1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocation1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLocation1.IconSize = 25;
            this.btnLocation1.IdleBorderColor = System.Drawing.Color.Azure;
            this.btnLocation1.IdleBorderRadius = 10;
            this.btnLocation1.IdleBorderThickness = 1;
            this.btnLocation1.IdleFillColor = System.Drawing.Color.Teal;
            this.btnLocation1.IdleIconLeftImage = null;
            this.btnLocation1.IdleIconRightImage = null;
            this.btnLocation1.IndicateFocus = false;
            this.btnLocation1.Location = new System.Drawing.Point(410, 6);
            this.btnLocation1.Name = "btnLocation1";
            this.btnLocation1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLocation1.OnDisabledState.BorderRadius = 10;
            this.btnLocation1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation1.OnDisabledState.BorderThickness = 1;
            this.btnLocation1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLocation1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLocation1.OnDisabledState.IconLeftImage = null;
            this.btnLocation1.OnDisabledState.IconRightImage = null;
            this.btnLocation1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLocation1.onHoverState.BorderRadius = 10;
            this.btnLocation1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation1.onHoverState.BorderThickness = 1;
            this.btnLocation1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLocation1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLocation1.onHoverState.IconLeftImage = null;
            this.btnLocation1.onHoverState.IconRightImage = null;
            this.btnLocation1.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            this.btnLocation1.OnIdleState.BorderRadius = 10;
            this.btnLocation1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation1.OnIdleState.BorderThickness = 1;
            this.btnLocation1.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnLocation1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLocation1.OnIdleState.IconLeftImage = null;
            this.btnLocation1.OnIdleState.IconRightImage = null;
            this.btnLocation1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLocation1.OnPressedState.BorderRadius = 10;
            this.btnLocation1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation1.OnPressedState.BorderThickness = 1;
            this.btnLocation1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLocation1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLocation1.OnPressedState.IconLeftImage = null;
            this.btnLocation1.OnPressedState.IconRightImage = null;
            this.btnLocation1.Size = new System.Drawing.Size(193, 49);
            this.btnLocation1.TabIndex = 3;
            this.btnLocation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLocation1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLocation1.TextMarginLeft = 0;
            this.btnLocation1.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLocation1.UseDefaultRadiusAndThickness = true;
            this.btnLocation1.Click += new System.EventHandler(this.btnLocation1_Click);
            // 
            // btnLocation0
            // 
            this.btnLocation0.AllowAnimations = true;
            this.btnLocation0.AllowMouseEffects = true;
            this.btnLocation0.AllowToggling = false;
            this.btnLocation0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLocation0.AnimationSpeed = 200;
            this.btnLocation0.AutoGenerateColors = false;
            this.btnLocation0.AutoRoundBorders = false;
            this.btnLocation0.AutoSizeLeftIcon = true;
            this.btnLocation0.AutoSizeRightIcon = true;
            this.btnLocation0.BackColor = System.Drawing.Color.Transparent;
            this.btnLocation0.BackColor1 = System.Drawing.Color.Teal;
            this.btnLocation0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocation0.BackgroundImage")));
            this.btnLocation0.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation0.ButtonText = "Tầng trệt";
            this.btnLocation0.ButtonTextMarginLeft = 0;
            this.btnLocation0.ColorContrastOnClick = 45;
            this.btnLocation0.ColorContrastOnHover = 45;
            this.btnLocation0.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnLocation0.CustomizableEdges = borderEdges3;
            this.btnLocation0.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLocation0.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLocation0.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLocation0.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLocation0.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLocation0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation0.ForeColor = System.Drawing.Color.White;
            this.btnLocation0.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocation0.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocation0.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLocation0.IconMarginLeft = 11;
            this.btnLocation0.IconPadding = 10;
            this.btnLocation0.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocation0.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocation0.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLocation0.IconSize = 25;
            this.btnLocation0.IdleBorderColor = System.Drawing.Color.Azure;
            this.btnLocation0.IdleBorderRadius = 10;
            this.btnLocation0.IdleBorderThickness = 1;
            this.btnLocation0.IdleFillColor = System.Drawing.Color.Teal;
            this.btnLocation0.IdleIconLeftImage = null;
            this.btnLocation0.IdleIconRightImage = null;
            this.btnLocation0.IndicateFocus = false;
            this.btnLocation0.Location = new System.Drawing.Point(211, 6);
            this.btnLocation0.Name = "btnLocation0";
            this.btnLocation0.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLocation0.OnDisabledState.BorderRadius = 10;
            this.btnLocation0.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation0.OnDisabledState.BorderThickness = 1;
            this.btnLocation0.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLocation0.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLocation0.OnDisabledState.IconLeftImage = null;
            this.btnLocation0.OnDisabledState.IconRightImage = null;
            this.btnLocation0.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLocation0.onHoverState.BorderRadius = 10;
            this.btnLocation0.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation0.onHoverState.BorderThickness = 1;
            this.btnLocation0.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLocation0.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLocation0.onHoverState.IconLeftImage = null;
            this.btnLocation0.onHoverState.IconRightImage = null;
            this.btnLocation0.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            this.btnLocation0.OnIdleState.BorderRadius = 10;
            this.btnLocation0.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation0.OnIdleState.BorderThickness = 1;
            this.btnLocation0.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnLocation0.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLocation0.OnIdleState.IconLeftImage = null;
            this.btnLocation0.OnIdleState.IconRightImage = null;
            this.btnLocation0.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLocation0.OnPressedState.BorderRadius = 10;
            this.btnLocation0.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLocation0.OnPressedState.BorderThickness = 1;
            this.btnLocation0.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLocation0.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLocation0.OnPressedState.IconLeftImage = null;
            this.btnLocation0.OnPressedState.IconRightImage = null;
            this.btnLocation0.Size = new System.Drawing.Size(193, 49);
            this.btnLocation0.TabIndex = 2;
            this.btnLocation0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLocation0.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLocation0.TextMarginLeft = 0;
            this.btnLocation0.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLocation0.UseDefaultRadiusAndThickness = true;
            this.btnLocation0.Click += new System.EventHandler(this.btnLocation0_Click);
            // 
            // btnTea
            // 
            this.btnTea.AllowAnimations = true;
            this.btnTea.AllowMouseEffects = true;
            this.btnTea.AllowToggling = false;
            this.btnTea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTea.AnimationSpeed = 200;
            this.btnTea.AutoGenerateColors = false;
            this.btnTea.AutoRoundBorders = false;
            this.btnTea.AutoSizeLeftIcon = true;
            this.btnTea.AutoSizeRightIcon = true;
            this.btnTea.BackColor = System.Drawing.Color.Transparent;
            this.btnTea.BackColor1 = System.Drawing.Color.Teal;
            this.btnTea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTea.BackgroundImage")));
            this.btnTea.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTea.ButtonText = "Bàn đang bận";
            this.btnTea.ButtonTextMarginLeft = 0;
            this.btnTea.ColorContrastOnClick = 45;
            this.btnTea.ColorContrastOnHover = 45;
            this.btnTea.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnTea.CustomizableEdges = borderEdges4;
            this.btnTea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTea.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTea.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTea.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTea.ForeColor = System.Drawing.Color.White;
            this.btnTea.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTea.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnTea.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTea.IconMarginLeft = 11;
            this.btnTea.IconPadding = 10;
            this.btnTea.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTea.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnTea.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTea.IconSize = 25;
            this.btnTea.IdleBorderColor = System.Drawing.Color.Azure;
            this.btnTea.IdleBorderRadius = 10;
            this.btnTea.IdleBorderThickness = 1;
            this.btnTea.IdleFillColor = System.Drawing.Color.Teal;
            this.btnTea.IdleIconLeftImage = null;
            this.btnTea.IdleIconRightImage = null;
            this.btnTea.IndicateFocus = false;
            this.btnTea.Location = new System.Drawing.Point(12, 6);
            this.btnTea.Name = "btnTea";
            this.btnTea.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTea.OnDisabledState.BorderRadius = 10;
            this.btnTea.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTea.OnDisabledState.BorderThickness = 1;
            this.btnTea.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTea.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTea.OnDisabledState.IconLeftImage = null;
            this.btnTea.OnDisabledState.IconRightImage = null;
            this.btnTea.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTea.onHoverState.BorderRadius = 10;
            this.btnTea.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTea.onHoverState.BorderThickness = 1;
            this.btnTea.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTea.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTea.onHoverState.IconLeftImage = null;
            this.btnTea.onHoverState.IconRightImage = null;
            this.btnTea.OnIdleState.BorderColor = System.Drawing.Color.Azure;
            this.btnTea.OnIdleState.BorderRadius = 10;
            this.btnTea.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTea.OnIdleState.BorderThickness = 1;
            this.btnTea.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.btnTea.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTea.OnIdleState.IconLeftImage = null;
            this.btnTea.OnIdleState.IconRightImage = null;
            this.btnTea.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTea.OnPressedState.BorderRadius = 10;
            this.btnTea.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTea.OnPressedState.BorderThickness = 1;
            this.btnTea.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTea.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTea.OnPressedState.IconLeftImage = null;
            this.btnTea.OnPressedState.IconRightImage = null;
            this.btnTea.Size = new System.Drawing.Size(193, 49);
            this.btnTea.TabIndex = 1;
            this.btnTea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTea.TextMarginLeft = 0;
            this.btnTea.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTea.UseDefaultRadiusAndThickness = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // showTable
            // 
            this.showTable.AutoScroll = true;
            this.showTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showTable.Location = new System.Drawing.Point(0, 115);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(1375, 671);
            this.showTable.TabIndex = 3;
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
            this.menuTrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuTrip.Size = new System.Drawing.Size(297, 108);
            this.menuTrip.Style = MetroFramework.MetroColorStyle.Green;
            this.menuTrip.Theme = MetroFramework.MetroThemeStyle.Light;
            this.menuTrip.UseCustomBackColor = true;
            this.menuTrip.UseCustomForeColor = true;
            this.menuTrip.UseStyleColors = true;
            // 
            // createBill
            // 
            this.createBill.Image = global::DoAnThucTap.Properties.Resources.invoice;
            this.createBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBill.Name = "createBill";
            this.createBill.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createBill.Size = new System.Drawing.Size(296, 26);
            this.createBill.Text = "Tạo hóa đơn";
            this.createBill.Click += new System.EventHandler(this.createBill_Click);
            // 
            // bookTable
            // 
            this.bookTable.Image = global::DoAnThucTap.Properties.Resources.check;
            this.bookTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookTable.Name = "bookTable";
            this.bookTable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.bookTable.Size = new System.Drawing.Size(296, 26);
            this.bookTable.Text = "Đặt bàn";
            this.bookTable.Click += new System.EventHandler(this.bookTable_Click);
            // 
            // cancleBook
            // 
            this.cancleBook.Enabled = false;
            this.cancleBook.Image = global::DoAnThucTap.Properties.Resources.close__1_;
            this.cancleBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancleBook.Name = "cancleBook";
            this.cancleBook.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.cancleBook.Size = new System.Drawing.Size(296, 26);
            this.cancleBook.Text = "Hủy lệnh đặt";
            this.cancleBook.Click += new System.EventHandler(this.cancleBook_Click);
            // 
            // detailBill
            // 
            this.detailBill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaHóaĐơnToolStripMenuItem,
            this.chuyểnBànToolStripMenuItem,
            this.thanhToánTáchToolStripMenuItem});
            this.detailBill.Enabled = false;
            this.detailBill.Image = global::DoAnThucTap.Properties.Resources.pencil;
            this.detailBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailBill.Name = "detailBill";
            this.detailBill.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.detailBill.Size = new System.Drawing.Size(296, 26);
            this.detailBill.Text = "Hóa đơn";
            this.detailBill.Click += new System.EventHandler(this.detailBill_Click);
            // 
            // chỉnhSửaHóaĐơnToolStripMenuItem
            // 
            this.chỉnhSửaHóaĐơnToolStripMenuItem.Image = global::DoAnThucTap.Properties.Resources.edit;
            this.chỉnhSửaHóaĐơnToolStripMenuItem.Name = "chỉnhSửaHóaĐơnToolStripMenuItem";
            this.chỉnhSửaHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.chỉnhSửaHóaĐơnToolStripMenuItem.Text = "Chỉnh sửa hóa đơn";
            this.chỉnhSửaHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaHóaĐơnToolStripMenuItem_Click);
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.Image = global::DoAnThucTap.Properties.Resources.change;
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn";
            this.chuyểnBànToolStripMenuItem.Click += new System.EventHandler(this.chuyểnBànToolStripMenuItem_Click);
            // 
            // thanhToánTáchToolStripMenuItem
            // 
            this.thanhToánTáchToolStripMenuItem.Image = global::DoAnThucTap.Properties.Resources.split;
            this.thanhToánTáchToolStripMenuItem.Name = "thanhToánTáchToolStripMenuItem";
            this.thanhToánTáchToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.thanhToánTáchToolStripMenuItem.Text = "Thanh toán tách";
            this.thanhToánTáchToolStripMenuItem.Click += new System.EventHandler(this.thanhToánTáchToolStripMenuItem_Click);
            // 
            // ChooseTable_GUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 786);
            this.ControlBox = false;
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseTable_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseTable_GUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.top.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.menuTrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel top;
        private Bunifu.UI.WinForms.BunifuLabel lblData;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLocation2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLocation1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLocation0;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTea;
        private System.Windows.Forms.FlowLayoutPanel showTable;
        private MetroFramework.Controls.MetroContextMenu menuTrip;
        private System.Windows.Forms.ToolStripMenuItem createBill;
        private System.Windows.Forms.ToolStripMenuItem bookTable;
        private System.Windows.Forms.ToolStripMenuItem cancleBook;
        private System.Windows.Forms.ToolStripMenuItem detailBill;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánTáchToolStripMenuItem;
    }
}