using DevExpress.XtraEditors;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
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
    public partial class adminManagement_GUI : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Staff staffcur;
        public adminManagement_GUI(String staffcode)
        {
            InitializeComponent();
            staffDAO dao = new staffDAO();
            staffcur = dao.getStaff(staffcode);
            itemNameStaff.Text = staffcur.Staff_Name;
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void itemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminManagement_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sl = MessageBox.Show("Bạn thực sự muốn đăng xuất khỏi hệ thống chứ?", "Chờ đã!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sl != DialogResult.Yes)
            {
                e.Cancel= true;
            }
        }

        private void itemPersonal_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Persional_GUI per = new Persional_GUI(staffcur.Staff_Code);
            per.TopLevel = false;
            pnlMain.Controls.Add(per);
            per.Dock = DockStyle.Fill;
            per.Show();
        }
    }
}