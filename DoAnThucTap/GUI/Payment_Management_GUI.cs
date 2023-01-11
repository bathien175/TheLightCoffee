using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class Payment_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Payment_Management_GUI()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            billDAO dao = new billDAO();
            List<Payment> listPayment = dao.getFullListPayment();
            List<paymentDTO> listdto = new List<paymentDTO>();
            foreach (var item in listPayment)
            {
                paymentDTO dto = new paymentDTO();
                dto.payment_ID = item.Payment_ID;
                dto.payment_name = item.Payment_name;
                dto.payment_time = Convert.ToDateTime(item.Payment_time);
                dto.payment_staff = new staffDAO().getStaff(item.Payment_Staff).Staff_Name;
                dto.payment_money = Convert.ToInt64(item.Payment_money);
                listdto.Add(dto);
            }
            gcPayment.DataSource = listdto;
            gvListPayment.OptionsBehavior.Editable = false;
        }
        private void ShowGridPreview(GridControl gcTable)
        {
            // Check whether the GridControl can be previewed.
            if (!gcTable.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            gcTable.ShowPrintPreview();
        }
        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcPayment);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}