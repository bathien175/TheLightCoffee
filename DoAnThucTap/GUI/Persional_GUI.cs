using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DoAnThucTap.DAO;
using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace DoAnThucTap.GUI
{
    public partial class Persional_GUI : DevExpress.XtraEditors.XtraForm
    {
        private String staff= "";
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
                imgAvatar.Image = Base64ToImage(staffcur.Staff_Image);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword_GUI pass = new ChangePassword_GUI(new staffDAO().getStaff(staff));
            pass.ShowDialog();
        }
        public byte[] ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;";
            DialogResult choose = open.ShowDialog();
            if (choose == DialogResult.OK)
            {
                String path = open.FileName;
                Bitmap bt = new Bitmap(Image.FromFile(path));

                //-- Xuất ra pictureBox 
                imgAvatar.Image = bt;

                byte[] codeimage = ImageToBase64(bt, ImageFormat.Jpeg);
                staffDAO dao = new staffDAO();
                dao.EditImageStaff(codeimage, staff);
            }
        }    
    }
}