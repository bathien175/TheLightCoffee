﻿namespace DoAnThucTap.GUI
{
    partial class Admin_DateReport_Management_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_DateReport_Management_GUI));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReceipt = new DoAnThucTap.userControl.itemMoneyDate();
            this.btnPayment = new DoAnThucTap.userControl.itemMoneyDate();
            this.btnImportMoney = new DoAnThucTap.userControl.itemMoneyDate();
            this.btnTotalMoney = new DoAnThucTap.userControl.itemMoneyDate();
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvListProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StaffExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoneyExport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(1421, 139);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.gcProduct);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 139);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = false;
            this.bunifuPanel2.Size = new System.Drawing.Size(1421, 598);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnTotalMoney, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnImportMoney, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPayment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReceipt, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1421, 139);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReceipt.getMoney = ((long)(0));
            this.btnReceipt.getSetImage = global::DoAnThucTap.Properties.Resources.up1;
            this.btnReceipt.Gettitle = "Tổng thu";
            this.btnReceipt.Location = new System.Drawing.Point(3, 3);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(349, 133);
            this.btnReceipt.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayment.getMoney = ((long)(0));
            this.btnPayment.getSetImage = global::DoAnThucTap.Properties.Resources.money_inflation;
            this.btnPayment.Gettitle = "Tổng chi";
            this.btnPayment.Location = new System.Drawing.Point(358, 3);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(349, 133);
            this.btnPayment.TabIndex = 1;
            // 
            // btnImportMoney
            // 
            this.btnImportMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportMoney.getMoney = ((long)(0));
            this.btnImportMoney.getSetImage = global::DoAnThucTap.Properties.Resources.money_flow;
            this.btnImportMoney.Gettitle = "Tiền nhập vào";
            this.btnImportMoney.Location = new System.Drawing.Point(713, 3);
            this.btnImportMoney.Name = "btnImportMoney";
            this.btnImportMoney.Size = new System.Drawing.Size(349, 133);
            this.btnImportMoney.TabIndex = 2;
            // 
            // btnTotalMoney
            // 
            this.btnTotalMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTotalMoney.getMoney = ((long)(0));
            this.btnTotalMoney.getSetImage = global::DoAnThucTap.Properties.Resources.costs_and_revenues_chart;
            this.btnTotalMoney.Gettitle = "Doanh thu";
            this.btnTotalMoney.Location = new System.Drawing.Point(1068, 3);
            this.btnTotalMoney.Name = "btnTotalMoney";
            this.btnTotalMoney.Size = new System.Drawing.Size(350, 133);
            this.btnTotalMoney.TabIndex = 3;
            // 
            // gcProduct
            // 
            this.gcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduct.Location = new System.Drawing.Point(0, 0);
            this.gcProduct.MainView = this.gvListProduct;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.Size = new System.Drawing.Size(1421, 598);
            this.gcProduct.TabIndex = 1;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListProduct});
            // 
            // gvListProduct
            // 
            this.gvListProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDExport,
            this.NameExport,
            this.StaffExport,
            this.TypeExport,
            this.MoneyExport});
            this.gvListProduct.GridControl = this.gcProduct;
            this.gvListProduct.Name = "gvListProduct";
            this.gvListProduct.OptionsFind.AlwaysVisible = true;
            this.gvListProduct.OptionsView.ShowAutoFilterRow = true;
            this.gvListProduct.OptionsView.ShowGroupPanel = false;
            this.gvListProduct.RowHeight = 10;
            // 
            // IDExport
            // 
            this.IDExport.Caption = "ID";
            this.IDExport.FieldName = "IDExport";
            this.IDExport.MinWidth = 10;
            this.IDExport.Name = "IDExport";
            this.IDExport.Visible = true;
            this.IDExport.VisibleIndex = 0;
            this.IDExport.Width = 100;
            // 
            // NameExport
            // 
            this.NameExport.Caption = "Lý do lập";
            this.NameExport.FieldName = "NameExport";
            this.NameExport.MinWidth = 25;
            this.NameExport.Name = "NameExport";
            this.NameExport.Visible = true;
            this.NameExport.VisibleIndex = 1;
            this.NameExport.Width = 678;
            // 
            // StaffExport
            // 
            this.StaffExport.Caption = "Nhân viên lập";
            this.StaffExport.FieldName = "StaffExport";
            this.StaffExport.MinWidth = 25;
            this.StaffExport.Name = "StaffExport";
            this.StaffExport.OptionsFilter.AllowAutoFilter = false;
            this.StaffExport.OptionsFilter.AllowFilter = false;
            this.StaffExport.Visible = true;
            this.StaffExport.VisibleIndex = 2;
            this.StaffExport.Width = 212;
            // 
            // TypeExport
            // 
            this.TypeExport.Caption = "Loại phiếu";
            this.TypeExport.FieldName = "TypeExport";
            this.TypeExport.MinWidth = 25;
            this.TypeExport.Name = "TypeExport";
            this.TypeExport.Visible = true;
            this.TypeExport.VisibleIndex = 3;
            this.TypeExport.Width = 105;
            // 
            // MoneyExport
            // 
            this.MoneyExport.Caption = "Tổng tiền";
            this.MoneyExport.FieldName = "MoneyExport";
            this.MoneyExport.MinWidth = 25;
            this.MoneyExport.Name = "MoneyExport";
            this.MoneyExport.Visible = true;
            this.MoneyExport.VisibleIndex = 4;
            this.MoneyExport.Width = 337;
            // 
            // Admin_DateReport_Management_GUI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1421, 737);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Admin_DateReport_Management_GUI.IconOptions.Icon")));
            this.Name = "Admin_DateReport_Management_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hôm nay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private userControl.itemMoneyDate btnTotalMoney;
        private userControl.itemMoneyDate btnImportMoney;
        private userControl.itemMoneyDate btnPayment;
        private userControl.itemMoneyDate btnReceipt;
        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListProduct;
        private DevExpress.XtraGrid.Columns.GridColumn IDExport;
        private DevExpress.XtraGrid.Columns.GridColumn NameExport;
        private DevExpress.XtraGrid.Columns.GridColumn StaffExport;
        private DevExpress.XtraGrid.Columns.GridColumn TypeExport;
        private DevExpress.XtraGrid.Columns.GridColumn MoneyExport;
    }
}