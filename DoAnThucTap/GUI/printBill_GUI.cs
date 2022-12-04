using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class printBill_GUI : Form
    {
        private int billid;
        public printBill_GUI(int Bill_Code)
        {
            InitializeComponent();
            this.billid = Bill_Code;
        }

        private void printBill_GUI_Load(object sender, EventArgs e)
        {
            String connectStr = @"Data Source=LAPTOP-G2HJIU6F\SQLEXPRESS;Initial Catalog=TheLightCoffee;User ID=sa;Password=sa;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String sql = $"exec exportBillTakeAway '{billid}'";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable("BillTakeAway");
            dap.Fill(tb);
            ReportBillTakeAway bill = new ReportBillTakeAway();
            bill.SetDataSource(tb);
            reportView.ReportSource = bill;
            reportView.RefreshReport();
            conn.Close();


        }
    }
}
