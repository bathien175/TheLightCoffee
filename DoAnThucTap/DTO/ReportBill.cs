using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace DoAnThucTap.DTO
{
    public partial class ReportBill : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBill()
        {
            InitializeComponent();
        }

        public void InitData(long give, long recive, List<billIsTakeAway> data)
        {
            CustomerGive.Value= give;
            ReciveCustomer.Value = recive;
            objectDataSource1.DataSource = data;
        }

    }
}
