using Bunifu.UI.WinForms;
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
    public partial class Ingredient_GUI : Form
    {
        private Staff staffcur;
        public Ingredient_GUI(String staffcode)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu lên...");
            InitializeComponent();
            loadStaff(staffcode);
            SplashScreenManager.CloseForm();
        }
        void loadStaff(string sid)
        {
            staffDAO dao = new staffDAO();
            staffcur = dao.getStaff(sid);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadData()
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu lên...");
            tbData.Controls.Clear();
            IngredientDAO dao = new IngredientDAO();
            List<Ingredient> list = dao.getFullIngredient();
            if (list.Count > 0)
            {
                int stt = 1;
                foreach (var item in list)
                {
                    item_Ingredient ingre = new item_Ingredient();
                    ingre.code = item.Ingredient_ID;
                    ingre.idIngredient = stt;
                    ingre.nameIngredient = item.Ingredient_Name;
                    ingre.imageIngredient = item.Ingredient_Image;
                    ingre.unitIngredient = item.Ingredient_Unit;
                    ingre.priceIngredient = item.Ingredient_PriceImport;
                    ingre.reservedIngredient = Convert.ToDouble(item.Ingredient_Reserved);
                    BunifuImageButton btn = ingre.getBtn();
                    btn.Tag = item.Ingredient_ID;
                    btn.Click += Btn_Click;
                    ingre.Width = tbData.Width;
                    tbData.Controls.Add(ingre);
                    stt++;
                }
            }
            SplashScreenManager.CloseForm();
        }

        private void btnFind50_Click(object sender, EventArgs e)
        {
            findIngredient(txtFind50.Text);
        }

        void findIngredient (String t)
        {
            SplashScreenManager.ShowForm(this, typeof(loadingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu lên...");
            tbData.Controls.Clear();
            IngredientDAO dao = new IngredientDAO();
            List<Ingredient> list = dao.findIngredient(t);
            if (list.Count > 0)
            {
                int stt = 1;
                foreach (var item in list)
                {
                    item_Ingredient ingre = new item_Ingredient();
                    ingre.code = item.Ingredient_ID;
                    ingre.idIngredient = stt;
                    ingre.nameIngredient = item.Ingredient_Name;
                    ingre.imageIngredient = item.Ingredient_Image;
                    ingre.unitIngredient = item.Ingredient_Unit;
                    ingre.priceIngredient = item.Ingredient_PriceImport;
                    ingre.reservedIngredient = Convert.ToDouble(item.Ingredient_Reserved);
                    BunifuImageButton btn = ingre.getBtn();
                    btn.Tag = item.Ingredient_ID;
                    btn.Click += Btn_Click;
                    ingre.Width = tbData.Width;
                    tbData.Controls.Add(ingre);
                    stt++;
                }
            }
            SplashScreenManager.CloseForm();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //multip import
            multip_Import_GUI import = new multip_Import_GUI(staffcur.Staff_Code);
            this.Hide();
            import.ShowDialog();
            this.Show();
        }
        void updateReservedSingle(int id)
        {
            IngredientDAO dao = new IngredientDAO();
            Ingredient i = dao.getIngredientbyID(id);
            foreach (var item in tbData.Controls)
            {
                item_Ingredient k = (item_Ingredient)item;
                if (k.code == i.Ingredient_ID)
                {
                    k.reservedIngredient = Convert.ToDouble(i.Ingredient_Reserved);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int iid = Convert.ToInt32((sender as BunifuImageButton).Tag);
            //single import
            single_Import_GUI import = new single_Import_GUI(staffcur.Staff_Code,iid);
            import.ShowDialog();
            updateReservedSingle(iid);
        }
    }
}
