using DevExpress.XtraSplashScreen;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class AdminForm_GUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminForm_GUI()
        {
            InitializeComponent();
        }
        void openForm(Type typeform)
        {
            foreach (var item in MdiChildren)
            {
                if (item.GetType() == typeform)
                {
                    item.Activate();
                    return;
                }

            }
            Form f = (Form)Activator.CreateInstance(typeform);
            f.MdiParent = this;
            f.Show();
        }
        private void btnPersonal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(Persional_GUI));
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(menu_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnIngredient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Ingredient_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Category_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnStaffList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Staff_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnRecipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Recipe_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnTopMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(statistical_menu_GUI));
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //quản lý bàn
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Table_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý khuyến mãi
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Discount_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý phụ thu
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(ExtraFee_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý hóa đơn
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Bill_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý phiếu nhập
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Import_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý phiếu thu
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Receipt_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnPayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý phiếu chi
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Payment_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnReportDate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý thống kê ngày
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Admin_DateReport_Management_GUI));
            SplashScreenManager.CloseForm();
        }

        private void btnReportTotal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Quản lý thống kê ngày
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            openForm(typeof(Admin_ReportByDate_Management_GUI));
            SplashScreenManager.CloseForm();
        }
    }
}