namespace DoAnThucTap.userControl
{
    partial class OptionHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionHome));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblOption = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imgImage
            // 
            this.imgImage.AllowFocused = false;
            this.imgImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgImage.AutoSizeHeight = true;
            this.imgImage.BorderRadius = 69;
            this.imgImage.Image = ((System.Drawing.Image)(resources.GetObject("imgImage.Image")));
            this.imgImage.IsCircle = true;
            this.imgImage.Location = new System.Drawing.Point(30, 24);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(139, 139);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImage.TabIndex = 0;
            this.imgImage.TabStop = false;
            this.imgImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblOption
            // 
            this.lblOption.AllowParentOverrides = false;
            this.lblOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOption.AutoEllipsis = false;
            this.lblOption.AutoSize = false;
            this.lblOption.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOption.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblOption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(11, 169);
            this.lblOption.Name = "lblOption";
            this.lblOption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOption.Size = new System.Drawing.Size(176, 25);
            this.lblOption.TabIndex = 1;
            this.lblOption.Text = "Tên chức năng";
            this.lblOption.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOption.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // OptionHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.imgImage);
            this.Name = "OptionHome";
            this.Size = new System.Drawing.Size(200, 203);
            this.Load += new System.EventHandler(this.OptionHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel lblOption;
        private Bunifu.UI.WinForms.BunifuPictureBox imgImage;
    }
}
