using DoAnThucTap.DAO;
using DoAnThucTap.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap
{
    public partial class Login_GUI : Form
    {
        public Login_GUI()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblShowHide_MouseHover(object sender, EventArgs e)
        {
            lblShowHide.ForeColor = Color.Green;
        }

        private void lblShowHide_Click(object sender, EventArgs e)
        {
            if(lblShowHide.Text == "Hiện")
            {
                txtPassword.PasswordChar = '\0';
                lblShowHide.Text = "Ẩn";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                lblShowHide.Text = "Hiện";
            }
        }

        private void lblShowHide_MouseLeave(object sender, EventArgs e)
        {
            lblShowHide.ForeColor = Color.DodgerBlue;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDAO dao = new LoginDAO();
            bool admin = false;
            if (btnAdmin.CheckState == Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked)
            {
                admin= true;
            }
            else
            {
                admin= false;
            }
            var staff = dao.Login(txtStaffCode.Text, txtPassword.Text, admin);
            if (staff!=null)
            {
                Home_GUI home = new Home_GUI(staff);
                this.Hide();
                home.ShowDialog();
                this.Show();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng!", "Lỗi đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
