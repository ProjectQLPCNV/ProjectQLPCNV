using QLNV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.APIS;

namespace QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        YeuCauAPIS yeuCauAPIS = new YeuCauAPIS();
        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
          
        }
        List<YeuCau> lstYeuCau1 = new List<YeuCau>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lstYeuCau1 = yeuCauAPIS.GetYeuCau().ToList();
            dataGridView2.DataSource = lstYeuCau1;
            dataGridView2.Columns[0].HeaderText = "Mã Yêu Cầu";
            dataGridView2.Columns[1].HeaderText = "Ngày Trực";
            dataGridView2.Columns[2].HeaderText = "SL Ca Trực";
            List<YeuCau> lstYeuCau = yeuCauAPIS.GetYeuCau().ToList();
            dataGridView1.DataSource = lstYeuCau;
        }
        List<YeuCau> ckeckYeucau = new List<YeuCau>();
        private void button1_Click(object sender, EventArgs e)
        {
            ckeckYeucau.AddRange(lstYeuCau1);
            dataGridView3.DataSource = ckeckYeucau;
        }
    }
}
