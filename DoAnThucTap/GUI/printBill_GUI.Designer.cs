namespace DoAnThucTap.GUI
{
    partial class printBill_GUI
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
            this.reportView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportView
            // 
            this.reportView.ActiveViewIndex = -1;
            this.reportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportView.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportView.Location = new System.Drawing.Point(0, 0);
            this.reportView.Name = "reportView";
            this.reportView.Size = new System.Drawing.Size(867, 892);
            this.reportView.TabIndex = 0;
            // 
            // printBill_GUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(867, 892);
            this.Controls.Add(this.reportView);
            this.Name = "printBill_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "printBill_GUI";
            this.Load += new System.EventHandler(this.printBill_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportView;
    }
}