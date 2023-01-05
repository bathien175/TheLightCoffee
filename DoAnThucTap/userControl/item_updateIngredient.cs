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

namespace DoAnThucTap.userControl
{
    public partial class item_updateIngredient : UserControl
    {
        private int iid, quantity,idIngredient;
        private string name, unit;
        private byte[] image;
        public item_updateIngredient()
        {
            InitializeComponent();
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public int getIID
        {
            get { return iid; }
            set { iid = value; lblID.Text = iid.ToString(); }
        }
        public String getName
        {
            get { return name; }
            set { name = value; lblNAme.Text = name.ToString(); }
        }
        public String getUnit
        {
            get { return unit; }
            set { unit = value; lblUnit.Text = unit.ToString(); }
        }

        private void nbrQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(nbrQuantity.Value);
        }

        public byte[] getImage
        {
            get { return image; }
            set
            {
                image = value;
                imgIngredient.Image = Base64ToImage(image);
            }
        }
        public int getQuantity
        {
            get { return quantity; } 
            set
            {
                quantity = value;
                nbrQuantity.Value = quantity;
                nbrQuantity.Maximum= quantity;
            }
        }
        public int getIDIngredient 
        {
            get { return idIngredient; }
            set { idIngredient = value; }
        }
    }
}
