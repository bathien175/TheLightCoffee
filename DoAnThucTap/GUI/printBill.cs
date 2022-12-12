using DevExpress.XtraEditors;
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
    public partial class printBill : DevExpress.XtraEditors.XtraForm
    {
        public printBill()
        {
            InitializeComponent();
        }

        private void printBill_Load(object sender, EventArgs e)
        {
        }

        public void PrintBill(List<billIsTakeAway> data,long give, long recive)
        {
            ReportBill bill = new ReportBill();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in bill.Parameters)
                p.Visible = false;
            bill.InitData(give,recive,data);
            reportView.DocumentSource= bill;
            bill.CreateDocument();
        }

        public void PrintBillTable(List<billnoTakeAway> data, long give, long recive)
        {
            ReportBillTable bill = new ReportBillTable();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in bill.Parameters)
                p.Visible = false;
            bill.InitData(give, recive, data);
            reportView.DocumentSource = bill;
            bill.CreateDocument();
        }

        private void printBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}