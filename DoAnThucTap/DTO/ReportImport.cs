using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace DoAnThucTap.DTO
{
    public partial class ReportImport : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportImport()
        {
            InitializeComponent();
        }

        public void initData(List<exportIImport_Result> list)
        {
            objectDataSource2.DataSource = list;
        }

    }
}
