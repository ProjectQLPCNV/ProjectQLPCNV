using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.Model;
using QLNV.APIS;
using QLNV.View;

namespace QLNV
{
    public partial class FormQuanLyCanBo : Form
    {
        public FormQuanLyCanBo()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.ToList();
        }

        private void FormQuanLyCanBo_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.ToList();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            FormThem f = new FormThem(new CanBo());
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        canBoBindingSource.Add(f.canBoInfo);
                        db.CanBo.Add(f.canBoInfo);
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
