using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace DoAnThucTap.DTO
{
    public partial class ReportBillTable : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBillTable()
        {
            InitializeComponent();
        }
        public void InitData(long give, long recive, List<billnoTakeAway> data)
        {
            if (give == -1 && recive == -1)
            {
                lblCusGive.Visible = false;
                lblRecive.Visible = false;
                pCusGive.Visible = false;
                pCusRecive.Visible = false;
                lbltitle.Text = "PHIẾU TÍNH TIỀN";
            }
            else
            {
                lblCusGive.Visible = true;
                lblRecive.Visible = true;
                pCusGive.Visible = true;
                pCusRecive.Visible = true;
                cusGiveMoney.Value = give;
                cusReciveMoeny.Value = recive;
                lbltitle.Text = "HÓA ĐƠN THANH TOÁN";
            }
            objectDataSource1.DataSource = data;
        }

    }
}
