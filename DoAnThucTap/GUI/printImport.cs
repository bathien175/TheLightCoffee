using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThucTap.GUI
{
    public partial class printImport : DevExpress.XtraEditors.XtraForm
    {
        public printImport()
        {
            InitializeComponent();
        }

        public void Print(List<exportIImport_Result> data)
        {
            ReportImport report = new ReportImport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.initData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}