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

namespace QLNV.View
{
    public partial class FormChonCa : Form
    {
        public FormChonCa()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        private void FormChonCa_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.ToList();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            for(int i= dtGridTrai.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dtGridTrai.Rows[i];
                if (Convert.ToBoolean(row.Cells["Chon"].Value))
                {
                    canBoBindingSource1.Add((CanBo)row.DataBoundItem);
                    canBoBindingSource.RemoveAt(row.Index);
                }
               
            }
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            for(int i=dtGribPhai.RowCount - 1; i >= 0; i--)
            {

                DataGridViewRow row = dtGribPhai.Rows[i];
                if (Convert.ToBoolean(row.Cells["Chon1"].Value))
                {
                    canBoBindingSource.Add((CanBo)row.DataBoundItem);
                    canBoBindingSource1.RemoveAt(row.Index);
                }
            }
        }
    }
}
