using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class DetailProduct_GUI : Form
    {
        private int proID;
        public DetailProduct_GUI(int productID)
        {
            InitializeComponent();
            proID = productID;
            LoadData();
            loadRecipe();
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadData()
        {
            menuDAO dao = new menuDAO();
            Product p = dao.getProductbyID(proID);
            lblNameProduct.Text = p.Product_Name;
            lblTypeProduct.Text = dao.GetCategory(p.Product_Category).Category_Name;
            lblUnit.Text = p.Product_Unit;
            lblPrice.Text = String.Format("{0:0,0}", p.Product_Price) + " VNĐ";
            imageProduct.Image = Base64ToImage(p.Product_Image);
        }

        void loadRecipe()
        {
            menuDAO dao = new menuDAO();
            List<Recipe> list = dao.getRecipe(proID);
            if (list.Count>0)
            {
                foreach (Recipe item in list)
                {
                    txtRecipe.Text += $"{Environment.NewLine}{item.Recipe_Info}{Environment.NewLine}";
                }
            }
            
        }

    }
}
