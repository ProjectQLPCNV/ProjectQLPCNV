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

namespace QLNV
{
    public partial class FormQuanLyYeuCau : Form
    {
        YeuCauAPIS yeuCauAPIS = new YeuCauAPIS();
        public FormQuanLyYeuCau()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormQuanLyYeuCau_Load(object sender, EventArgs e)
        {
            getDataGrid();
        }
        void getDataGrid()
        {
            List<YeuCau> lstYeuCau = yeuCauAPIS.GetYeuCau().ToList();
            gridYeuCau.DataSource = lstYeuCau;
            gridYeuCau.Columns[0].HeaderText = "Mã Yêu Cầu";
            gridYeuCau.Columns[1].HeaderText = "Ngày Trực";
            gridYeuCau.Columns[2].HeaderText = "Số Lượng Ca Trực";
            gridYeuCau.Columns[4].HeaderText = "Số Lượng Người Trực";
            gridYeuCau.Columns.Remove("User");
            gridYeuCau.Columns.Remove("IDAdmin");
            gridYeuCau.Columns.Remove("CaTruc");
            gridYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridYeuCau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void BtnTaoCa_Click(object sender, EventArgs e)
        {
            YeuCau addYeuCau = new YeuCau();
            addYeuCau.SoLuongCa = int.Parse(txtSoLuongCa.Text.ToString());
            addYeuCau.SoLuongNguoi = int.Parse(txtSoNguoiLam.Text.ToString());
            addYeuCau.NgayTruc = DateTime.Parse(dtNgayNhap.Text.ToString());
            for(int i=0; i < addYeuCau.SoLuongCa; i++)
            {
                string tenCa = "Ca " + (i + 1);
                addYeuCau.CaTruc.Add(new CaTruc()
                {
                    TenCa=tenCa
                });
            }
            yeuCauAPIS.PostYeuCau(addYeuCau);
   
            gridYeuCau.DataSource = null;
            getDataGrid();
        }

        private void gridYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gridYeuCau.Rows[e.RowIndex];
            int i= int.Parse(row.Cells["YeuCauID"].Value.ToString());
        }
    }
}
