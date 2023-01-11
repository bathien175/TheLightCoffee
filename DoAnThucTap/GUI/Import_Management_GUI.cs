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
    public partial class Import_Management_GUI : DevExpress.XtraEditors.XtraForm
    {
        public Import_Management_GUI()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            billDAO dao = new billDAO();
            List<Import> listImport = dao.getFullListImport();
            List<importDTO> listdto = new List<importDTO>();
            foreach (var item in listImport)
            {
                importDTO dto = new importDTO();
                dto.Import_ID = item.Import_ID;
                dto.Import_Date = item.Import_Date;
                dto.Import_Staff = new staffDAO().getStaff(item.Import_Staff).Staff_Name;
                dto.Import_TotalMoney = item.Import_TotalMoney;
                listdto.Add(dto);
            }
            gcImport.DataSource = listdto;
            gvListImport.OptionsBehavior.Editable = false;
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
            ShowGridPreview(gcImport);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}