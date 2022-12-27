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
    public partial class item_Recipe : UserControl
    {
        private int Step;
        private String StepInfo;
        public item_Recipe()
        {
            InitializeComponent();
        }
        public int getStep
        {
            get
            {
                return (int)Step;
            }
            set
            {
                Step = value;
                lblStep.Text = "Bước " + Step + ": ";
            }
        }
        public String getStepInfo
        {
            get
            {
                return (String)StepInfo;
            }
            set
            {
                StepInfo = value;
            }
        }

        private void txtStep_TextChange(object sender, EventArgs e)
        {
            getStepInfo = txtStep.Text;
        }
    }
}
