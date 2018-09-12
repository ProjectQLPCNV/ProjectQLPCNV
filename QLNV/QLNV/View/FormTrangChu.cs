using QLNV.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        private void quảnLýYêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyYeuCau f = new FormQuanLyYeuCau();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyCanBo f = new FormQuanLyCanBo();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.MdiParent = this;
            f.Show();
            
        }

        public void FormTrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                quảnLýYêuCầuToolStripMenuItem.Enabled = true;
                quảnLýCánBộToolStripMenuItem.Enabled = true;

            }
        }

        private void tKTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.isLoginSess)
            {
                tKCaTheoCánBộToolStripMenuItem.Enabled = true;
                tKCaTheoĐơnVịToolStripMenuItem.Enabled = true;
                tKTheoNgayToolStripMenuItem.Enabled = true;
            }
        }
    }
}
