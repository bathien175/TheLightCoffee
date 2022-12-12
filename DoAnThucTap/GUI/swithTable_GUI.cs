using DevExpress.Xpo.DB;
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
    public partial class swithTable_GUI : Form
    {
        private String tableCur = "A2";
        public swithTable_GUI(String tablecode)
        {
            InitializeComponent();
            this.tableCur = tablecode;
            lblData.Text = "Chuyển bàn " + tableCur;
        }
        private void swithTable_GUI_Load(object sender, EventArgs e)
        {
            tableDAO dao  =new tableDAO();
            List<DTO.DBTable> list = dao.listTableSwitch(tableCur);
            if (list.Count > 0)
            {
                foreach (DTO.DBTable item in list)
                {
                    Button btn = new Button
                    {
                        Tag = item.Table_Code,
                        Width = 100,
                        Height = 50,
                        Text = item.Table_Code,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White,
                        Cursor = Cursors.Hand
                    };
                    switch (item.Table_Status)
                    {
                        case 0: 
                            btn.BackColor= Color.DarkGreen;
                            break;
                        case 1:
                            btn.BackColor = Color.DarkGoldenrod;
                            break; 
                        case 2: 
                            btn.BackColor = Color.DarkRed;
                            break;
                    }
                    btn.Click += BtnSwitch_Click;
                    tbTabe.Controls.Add(btn);
                }
            }
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            tableDAO dao = new tableDAO();
            String tbSwitch = (sender as Button).Tag.ToString();
            var tb = dao.getTableByID(tbSwitch);
            billDAO bildao = new billDAO();
            if (tb.Table_Status == 0)
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn chuyển từ bàn " + tableCur + " sang bàn " + tbSwitch + " chứ?", "Chờ đã!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.No)
                {
                    //chuyển bàn
                    bildao.switchTable(tableCur,tbSwitch);
                    MessageBox.Show("Chuyển bàn thành công!","Chúc mừng!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bàn số " + tbSwitch + " đã có khách! Bạn muốn gộp bàn chứ?", "Chờ đã!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.No)
                {
                    //gộp bàn
                    bildao.switchTable(tableCur, tbSwitch);
                    MessageBox.Show("Gộp bàn thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
