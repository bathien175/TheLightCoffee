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
            cusGiveMoney.Value = give;
            cusReciveMoeny.Value = recive;
            objectDataSource1.DataSource = data;
        }

    }
}
