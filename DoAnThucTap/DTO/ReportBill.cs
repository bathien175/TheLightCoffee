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
            if (give == -1 && recive == -1)
            {
                lblCusGive.Visible= false;
                lblCusRecive.Visible= false;
                pCusGive.Visible= false;
                pCusRecive.Visible= false;
            }
            else
            {
                lblCusGive.Visible = true;
                lblCusRecive.Visible = true;
                pCusGive.Visible = true;
                pCusRecive.Visible = true;
                CustomerGive.Value = give;
                ReciveCustomer.Value = recive;
            }
            objectDataSource1.DataSource = data;
        }

    }
}
