using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace DoAnThucTap.DTO
{
    public partial class ReportDate : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDate()
        {
            InitializeComponent();
        }

        public void InitData(List<dateReport> list,long totalbill, long totalimport,long totalmoney)
        {
            objectDataSource1.DataSource = list;
            TotalBill.Value= totalbill;
            TotalImport.Value= totalimport;
            TotalMoney.Value= totalmoney;
        }
    }
}

