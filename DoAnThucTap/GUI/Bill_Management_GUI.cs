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
    public partial class Bill_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Bill_Management_GUI()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            billDAO dao = new billDAO();
            List<Bill> listbill = dao.getFullListBill();
            List<billDTO> listdto = new List<billDTO>();
            foreach (var item in listbill)
            {
                billDTO dto = new billDTO();
                dto.Bill_ID= item.Bill_ID;
                dto.Bill_Table = item.Bill_Table;
                dto.Bill_Staff = new staffDAO().findStaff(item.Bill_Staff).Staff_Name;
                if (item.Bill_isTakeAway)
                {
                    dto.Bill_Type = "Mang về";
                }
                else
                {
                    dto.Bill_Type = "Tại chỗ";
                }
                dto.Bill_Discount = item.Bill_Discount;
                dto.Bill_Surchange = Convert.ToInt64(item.Bill_ExtraFee);
                dto.Bill_DateStart = Convert.ToDateTime(item.Bill_TimeFrom);
                dto.Bill_DateEnd = Convert.ToDateTime(item.Bill_TimeTo);
                dto.Bill_TotalMoney = Convert.ToInt64(item.Bill_TotalMoney);
                listdto.Add(dto);
            }
            gcBill.DataSource = listdto;
            gvListBill.OptionsBehavior.Editable = false;
        }
        private void btnPrinter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowGridPreview(gcBill);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
    }
}