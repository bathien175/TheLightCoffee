using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class managementStaff_GUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public managementStaff_GUI()
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
    }
}