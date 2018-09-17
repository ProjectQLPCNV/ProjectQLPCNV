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
using System.Data.Entity.Infrastructure;

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
            
        }

        private void FormQuanLyCanBo_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.ToList();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSua f = new FormThemSua(new CanBo());
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        canBoBindingSource.Add(f.canBoInfo);
                        db.CanBo.Add(f.canBoInfo);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            CanBo canBo = canBoBindingSource.Current as CanBo;
            if (canBo != null)
            {
                FormThemSua f = new FormThemSua(canBo);
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            canBoBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Chac Muon Xoa Khong?", "Mesage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rowId= dtGridQLCanBo.SelectedCells[0].RowIndex;
                int id = int.Parse(dtGridQLCanBo.Rows[rowId].Cells[0].Value.ToString());
                CanBo canBo=db.CanBo.SingleOrDefault(x => x.CanBoID == id);
                db.CanBo.Remove(canBo);
                try
                {
                    db.SaveChanges();
                }catch(Exception ex)
                {

                }
                canBoBindingSource.DataSource = db.CanBo.ToList();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)   
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {
            //dtGridQLCanBo.DataSource = db.CanBo.Where(x => x.DonVi.Contains(txtDonVi.Text)).ToList();
        }

        private void txtChuVu_TextChanged(object sender, EventArgs e)
        {
            dtGridQLCanBo.DataSource = db.CanBo.Where(x => x.ChucVu.Contains(txtChuVu.Text)).ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtGridQLCanBo.DataSource = db.CanBo.Where(x => x.HoTen.Contains(txtTimKiem.Text)).ToList();
        }
    }
}
