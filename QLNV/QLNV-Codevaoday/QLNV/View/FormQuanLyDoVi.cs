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
    public partial class FormQuanLyDoVi : Form
    {
        public FormQuanLyDoVi()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        
        private void FormQuanLyDoVi_Load(object sender, EventArgs e)
        {
            donViBindingSource.DataSource = db.DonVi.ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DonVi tenDonVi = new DonVi();
            tenDonVi.TenDonVI = txtThem.Text.Trim();
            db.DonVi.Add(tenDonVi);
            donViBindingSource.Add(tenDonVi);
            db.SaveChanges();
            txtThem.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }
        private async void btnSua_Click(object sender, EventArgs e)
        {
            donViBindingSource.EndEdit();
            await db.SaveChangesAsync();
        }
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            dtGridQLDonVi.DataSource = db.DonVi.Where(x => x.TenDonVI.Contains(txtTim.Text)).ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Chac Muon Xoa Khong?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowId = dtGridQLDonVi.SelectedCells[0].RowIndex;
                int id = int.Parse(dtGridQLDonVi.Rows[rowId].Cells[0].Value.ToString());
                DonVi donVi = db.DonVi.SingleOrDefault(x => x.DonViID == id);
                db.DonVi.Remove(donVi);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                }
                dtGridQLDonVi.DataSource = db.DonVi.ToList();
            }
        }
    }
}
