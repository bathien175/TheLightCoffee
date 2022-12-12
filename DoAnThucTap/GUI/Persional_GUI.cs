using DevExpress.XtraEditors;
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
    public partial class Persional_GUI : DevExpress.XtraEditors.XtraForm
    {
        private String staff= "";
        OpenFileDialog open;
        public Persional_GUI(String s)
        {
            InitializeComponent();
            this.staff = s;
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            staffDAO dao = new staffDAO();
            Staff staffcur = dao.getStaff(staff);
            if (staffcur != null)
            {
                txtStaffCode.Text = staffcur.Staff_Code;
                if(staffcur.Staff_Datebirth!=null)
                    dtpkDatebirth.Value = Convert.ToDateTime(staffcur.Staff_Datebirth);
                if(staffcur.Staff_Gender!=null)
                    cbbGender.Text= staffcur.Staff_Gender;
                if (staffcur.Staff_Name != null)
                    txtNameStaff.Text = staffcur.Staff_Name;
                if(staffcur.Staff_Phone!=null)
                    txtSDT.Text = staffcur.Staff_Phone;
                if (staffcur.Staff_isAdmin == true)
                {
                    cbbLevel.SelectedIndex = 0;
                }
                else
                {
                    cbbLevel.SelectedIndex = 1;
                }
                if(staffcur.Staff_Address!=null)
                    txtAddress.Text = staffcur.Staff_Address;
                if (staffcur.Staff_Image != null)
                {
                    imgAvatar.Image = Image.FromFile(@"../../ImageStaff/" + staffcur.Staff_Image);
                }
                else
                {
                    imgAvatar.Image = Image.FromFile(@"../../ImageStaff/avatar.gif");
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword_GUI pass = new ChangePassword_GUI(new staffDAO().getStaff(staff));
            pass.ShowDialog();
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    //coppy ảnh sang thư mục của app
                    String path = open.FileName;
                    String imageName = staff + ".jpg";
                    String source = @"../../ImageStaff/" + imageName;
                    File.Copy(path, source, true);
                    imgAvatar.Image = Image.FromFile(source);

                    //update data trong csdl
                    staffDAO dao = new staffDAO();
                    dao.EditImageStaff(imageName, staff);

                    //thông báo
                    MessageBox.Show("Cập nhật ảnh thành công!","Chúc mừng!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    throw;
                }  
            }
        }
    }
}