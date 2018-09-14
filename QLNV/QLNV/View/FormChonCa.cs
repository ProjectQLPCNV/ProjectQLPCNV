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
        public FormChonCa(List<CaTruc> lstCaTruc)
        {
            InitializeComponent();
            cbxChonCa.DataSource = lstCaTruc;
            cbxChonCa.DisplayMember = "TenCa";
            cbxChonCa.ValueMember = "CaTrucID";
        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        private void FormChonCa_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.ToList();
            
        }
        List<CanBo> lstCBPhanCong = new List<CanBo>();
        List<CanBo> lstCBBoPhanCong = new List<CanBo>();
        List<CanBo> lstCBDuocChon = new List<CanBo>();
        private void btnPhai_Click(object sender, EventArgs e)
        {
            for(int i= dtGridTrai.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dtGridTrai.Rows[i];
                if (Convert.ToBoolean(row.Cells["Chon"].Value))
                {
                    canBoBindingSource1.Add((CanBo)row.DataBoundItem);
                    canBoBindingSource.RemoveAt(row.Index);
                    lstCBDuocChon.Add((CanBo)row.DataBoundItem);
                    lstCBPhanCong.Add((CanBo)row.DataBoundItem);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
