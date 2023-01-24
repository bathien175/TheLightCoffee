namespace DoAnThucTap.userControl
{
    partial class itemMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemMenu));
            this.imageMenu = new System.Windows.Forms.PictureBox();
            this.lblNameMenu = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // imageMenu
            // 
            this.imageMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageMenu.Image = global::DoAnThucTap.Properties.Resources.fruit_basket;
            this.imageMenu.Location = new System.Drawing.Point(0, 0);
            this.imageMenu.Margin = new System.Windows.Forms.Padding(2);
            this.imageMenu.Name = "imageMenu";
            this.imageMenu.Size = new System.Drawing.Size(188, 162);
            this.imageMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageMenu.TabIndex = 0;
            this.imageMenu.TabStop = false;
            // 
            // lblNameMenu
            // 
            this.lblNameMenu.AllowParentOverrides = false;
            this.lblNameMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameMenu.AutoEllipsis = false;
            this.lblNameMenu.AutoSize = false;
            this.lblNameMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameMenu.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNameMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMenu.Location = new System.Drawing.Point(2, 167);
            this.lblNameMenu.Margin = new System.Windows.Forms.Padding(2);
            this.lblNameMenu.Name = "lblNameMenu";
            this.lblNameMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameMenu.Size = new System.Drawing.Size(183, 28);
            this.lblNameMenu.TabIndex = 1;
            this.lblNameMenu.Text = "Sữa tươi trân châu đường đen";
            this.lblNameMenu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameMenu.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.AutoSize = false;
            this.lblPrice.CursorType = null;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPrice.Location = new System.Drawing.Point(2, 201);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(183, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "0 đ";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // itemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameMenu);
            this.Controls.Add(this.imageMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(15, 8, 15, 0);
            this.Name = "itemMenu";
            this.Size = new System.Drawing.Size(188, 219);
            ((System.ComponentModel.ISupportInitialize)(this.imageMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageMenu;
        private Bunifu.UI.WinForms.BunifuLabel lblNameMenu;
        private Bunifu.UI.WinForms.BunifuLabel lblPrice;
    }
}
