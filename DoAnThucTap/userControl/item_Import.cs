using Bunifu.UI.WinForms;
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
    public partial class item_Import : UserControl
    {
        private int id, sl;
        private long price;
        private String name, unit;
        private byte[] image;
        public item_Import()
        {
            InitializeComponent();
        }
        public int getSetID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                lblID.Text = id.ToString();
            }
        }
        public int getSetSL
        {
            get
            {
                return sl;
            }
            set
            {
                sl = value;
                lblSL.Text = sl.ToString();
            }
        }
        public String getSetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                lblNameIngredient.Text = name;
            }
        }
        public String getSetUnit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
                lblUnit.Text = unit;
            }
        }
        public byte[] getSetImage
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                imgIngredient.Image = Base64ToImage(image);
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public long getSetPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                lblPrice.Text = String.Format("{0:0,0}", price) + " VNĐ";
            }
        }
        public BunifuImageButton getbtnSub()
        {
            return btnSub;
        }
        public BunifuImageButton getbtnDel()
        {
            return btnDel;
        }
    }
}
