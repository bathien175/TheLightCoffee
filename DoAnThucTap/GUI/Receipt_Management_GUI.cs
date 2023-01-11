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
    public partial class Receipt_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Receipt_Management_GUI()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            billDAO dao = new billDAO();
            List<receipt> listreceipt = dao.getFullListReceipt();
            List<receiptDTO> listdto = new List<receiptDTO>();
            foreach (var item in listreceipt)
            {
                receiptDTO dto = new receiptDTO();
                dto.receipt_ID= item.receipt_ID;
                dto.receipt_name= item.receipt_name;
                if (item.receipt_isMoneyImport == true)
                {
                    dto.receipt_type = "Nhập tiền";
                }
                else
                {
                    dto.receipt_type = "Dịch vụ";
                }
                dto.receipt_time = Convert.ToDateTime(item.receipt_time);
                dto.receipt_staff = new staffDAO().getStaff(item.receipt_Staff).Staff_Name;
                dto.receipt_money = Convert.ToInt64(item.receipt_money);
                listdto.Add(dto);
            }
            gcReceipt.DataSource = listdto;
            gvListReceipt.OptionsBehavior.Editable = false;
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
            ShowGridPreview(gcReceipt);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}