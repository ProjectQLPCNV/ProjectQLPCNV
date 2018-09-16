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
using QLNV.Model;
using QLNV.View;

namespace QLNV
{
    public partial class FormQuanLyYeuCau : Form
    {
        
        public FormQuanLyYeuCau()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        QLPCNhanVienEntities db;
        private void FormQuanLyYeuCau_Load(object sender, EventArgs e)
        {
            //Đoạn này load được đc hết DB vào GridView luôn nhưng vẫn theo thứ tự
            db = new QLPCNhanVienEntities();
            yeuCauBindingSource.DataSource = db.YeuCau.ToList();
        }
        YeuCauAPIS yeuCauAPIS = new YeuCauAPIS();
        //void getDataGrid()
        //{
        //    List<YeuCau> lstYeuCau = yeuCauAPIS.GetYeuCau().ToList();
        //    gridYeuCau.DataSource = lstYeuCau;
        //    gridYeuCau.Columns[0].HeaderText = "Mã Yêu Cầu";
        //    gridYeuCau.Columns[1].HeaderText = "Ngày Trực";
        //    gridYeuCau.Columns[2].HeaderText = "SL Ca Trực";
        //    gridYeuCau.Columns[4].HeaderText = "SL Người Trực";
        //    gridYeuCau.Columns.Remove("User");
        //    gridYeuCau.Columns.Remove("IDAdmin");
        //    gridYeuCau.Columns.Remove("CaTruc");
        //    gridYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    gridYeuCau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        //}
        List<CaTruc> TaoCaTrucMacDinh()
        {
            List<CaTruc> lstCaTruc = new List<CaTruc>();
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 1",
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 2",
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 3",
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 4",
            });
            lstCaTruc.Add(new CaTruc()
            {
                TenCa = "Ca 5",
            });
           
            return lstCaTruc;
        }
        private void BtnTaoCa_Click(object sender, EventArgs e)
        {
            
            YeuCau addYeuCau = new YeuCau();
            addYeuCau.SoLuongCa = int.Parse(txtSoLuongCa.Text.ToString());
            addYeuCau.SoLuongNguoi = int.Parse(txtSoNguoiLam.Text.ToString());
            addYeuCau.NgayTruc = DateTime.Parse(dtNgayNhap.Text.ToString());
            List<CaTruc> lstCaTruc = TaoCaTrucMacDinh();
            foreach(CaTruc caTruc in lstCaTruc)
            {
                addYeuCau.CaTruc.Add(caTruc);
            }
            yeuCauAPIS.PostYeuCau(addYeuCau);
            List<CaTruc> CaTruc = addYeuCau.CaTruc.ToList();
            FormChonCa f = new FormChonCa(CaTruc);
            f.Show();
            gridYeuCau.DataSource = null;
            //getDataGrid();
        }

        private void gridYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.gridYeuCau.Rows[e.RowIndex];
            //int i= int.Parse(row.Cells["YeuCauID"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowId = gridYeuCau.SelectedCells[0].RowIndex;
            int id = int.Parse(gridYeuCau.Rows[rowId].Cells[0].Value.ToString());
            YeuCau yeuCau=db.YeuCau.SingleOrDefault(x => x.YeuCauID == id);
            List < CaTruc > lstCaTruc = yeuCau.CaTruc.ToList();
            FormChonCa chonCa = new FormChonCa(lstCaTruc);
            chonCa.Show();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            YeuCau yeuCau = yeuCauBindingSource.Current as YeuCau;
            if (yeuCau != null)
            {
                FormSuaYeuCau f = new FormSuaYeuCau(yeuCau);
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            yeuCauBindingSource.EndEdit();
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
                int rowId = gridYeuCau.SelectedCells[0].RowIndex;
                int id = int.Parse(gridYeuCau.Rows[rowId].Cells[0].Value.ToString());
                YeuCau yeuCau = db.YeuCau.SingleOrDefault(x => x.YeuCauID == id);
                db.YeuCau.Remove(yeuCau);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                yeuCauBindingSource.DataSource = db.YeuCau.ToList();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongCa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
