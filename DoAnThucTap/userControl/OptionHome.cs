using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.userControl
{
    public partial class OptionHome : UserControl
    {
        public OptionHome()
        {
            InitializeComponent();
        }

        public Image imageOption { get; set; }
        public String nameOption { get; set; }

        private void OptionHome_Load(object sender, EventArgs e)
        {
            imgImage.Image = imageOption;
            lblOption.Text = nameOption;
        }
    }
}
