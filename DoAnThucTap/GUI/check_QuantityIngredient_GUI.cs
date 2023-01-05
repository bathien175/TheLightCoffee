using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using DoAnThucTap.userControl;
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
    public partial class check_QuantityIngredient_GUI : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public check_QuantityIngredient_GUI()
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            InitializeComponent();
            loadData();
            SplashScreenManager.CloseForm();
        }

        void loadData()
        {
            flpMain.Controls.Clear();
            IngredientDAO dao = new IngredientDAO();
            List<Ingredient> list = dao.getFullIngredient();
            int iid = 1;
            foreach (var item in list)
            {
                item_updateIngredient u= new item_updateIngredient();
                u.getIDIngredient = item.Ingredient_ID;
                u.getIID = iid;
                u.getName = item.Ingredient_Name;
                u.getUnit = item.Ingredient_Unit;
                u.getQuantity = Convert.ToInt32(item.Ingredient_Reserved);
                u.getImage = item.Ingredient_Image;
                flpMain.Controls.Add(u);
                iid++;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Xin vui lòng chờ...");
            List<item_updateIngredient> list = new List<item_updateIngredient>();
            foreach (var item in flpMain.Controls)
            {
                item_updateIngredient u = (item_updateIngredient)item;
                list.Add(u);
            }
            IngredientDAO dao  =new IngredientDAO();
            dao.updateFullIngredient(list);
            SplashScreenManager.CloseForm();
            MessageBox.Show("Cập nhật kho thành công!","Chúc mừng!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}