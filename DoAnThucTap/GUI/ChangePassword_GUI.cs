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
    public partial class ChangePassword_GUI : Form
    {
        private Staff staff = new Staff();
        public ChangePassword_GUI(Staff s)
        {
            InitializeComponent();
            this.staff = s;
        }

        bool checkOldPass()
        {
            if (txtOldPass.Text != staff.Staff_Password)
            {
                warningPass.Text = "Mật khẩu nhập chưa đúng!";
                warningPass.Visible = true;
                return false;
            }
            else
            {
                warningPass.Visible = false;
                return true;
            }
        }

        bool checkNewPass()
        {
            if(txtNewPass.Text == string.Empty)
            {
                warningNewPass.Text = "Mật khẩu không được bỏ trống!";
                warningNewPass.Visible = true;
                return false;
            }
            else if (txtNewPass.Text.Length<6|| txtNewPass.Text.Length >50)
            {
                warningNewPass.Text = "Mật khẩu không hợp lệ!";
                warningNewPass.Visible = true;
                return false;
            }
            else
            {
                warningNewPass.Visible = false;
                return true;
            }
        }

        bool checkAgainPass()
        {
            if (txtNewPassAgain.Text != txtNewPass.Text)
            {
                waningNewPassAgain.Text = "Mật khẩu nhập lại không trùng khớp!";
                waningNewPassAgain.Visible = true;
                return false;
            }
            else
            {
                waningNewPassAgain.Visible = false;
                return true; ;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (checkOldPass() && checkNewPass() && checkAgainPass())
            {
                staffDAO dao  = new staffDAO();
                dao.EditPasswordStaff(txtNewPass.Text, staff.Staff_Code);
                MessageBox.Show("Đổi mật khẩu thành công!","Chúc mừng!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin chưa hợp lệ!", "Đã có lỗi xảy ra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
