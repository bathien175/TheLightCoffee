﻿namespace DoAnThucTap.userControl
{
    partial class itemBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemBill));
            this.lblSL = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblName = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // lblSL
            // 
            this.lblSL.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(0, 0);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(56, 73);
            this.lblSL.TabIndex = 0;
            this.lblSL.Text = "x1";
            this.lblSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveImage = null;
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowBuffering = false;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AllowZooming = true;
            this.btnDelete.AllowZoomingOnFocus = false;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ErrorImage")));
            this.btnDelete.FadeWhenInactive = false;
            this.btnDelete.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDelete.Image = global::DoAnThucTap.Properties.Resources.delete;
            this.btnDelete.ImageActive = null;
            this.btnDelete.ImageLocation = null;
            this.btnDelete.ImageMargin = 40;
            this.btnDelete.ImageSize = new System.Drawing.Size(41, 33);
            this.btnDelete.ImageZoomSize = new System.Drawing.Size(81, 73);
            this.btnDelete.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.InitialImage")));
            this.btnDelete.Location = new System.Drawing.Point(325, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0;
            this.btnDelete.ShowActiveImage = true;
            this.btnDelete.ShowCursorChanges = true;
            this.btnDelete.ShowImageBorders = false;
            this.btnDelete.ShowSizeMarkers = false;
            this.btnDelete.Size = new System.Drawing.Size(81, 73);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.ToolTipText = "";
            this.btnDelete.WaitOnLoad = false;
            this.btnDelete.Zoom = 40;
            this.btnDelete.ZoomSpeed = 10;
            // 
            // lblName
            // 
            this.lblName.AllowParentOverrides = false;
            this.lblName.AutoEllipsis = false;
            this.lblName.AutoSize = false;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(56, 0);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(269, 73);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên món";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // itemBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSL);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Name = "itemBill";
            this.Size = new System.Drawing.Size(406, 73);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSL;
        private Bunifu.UI.WinForms.BunifuImageButton btnDelete;
        private Bunifu.UI.WinForms.BunifuLabel lblName;
    }
}
