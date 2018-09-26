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
using Dapper;
using System.Configuration;
using System.Data.SqlClient;


namespace QLNV.View
{
    public partial class FormTKCanBo : Form
    {
        public FormTKCanBo()
        {
            InitializeComponent();
        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            CanBo canBo = new CanBo();
            canBo.CanBoID = 7;
            string picke1 = fromDateSticker.Value.ToString("yyyy/M/d");

            string picke2 = toDateSticker.Value.ToString("yyyy/M/d");

            string query = string.Format("SELECT * from YeuCau where NgayTruc between '{0}' and '{1}'", picke1, picke2);
            List<YeuCau> lstYeuCau = db.YeuCau.SqlQuery(query).ToList();
            List<YeuCau> yeuCaus = new List<YeuCau>();
            foreach (YeuCau yeuCau in lstYeuCau)
            {
                yeuCaus.Add(db.YeuCau.SingleOrDefault(x => x.YeuCauID == yeuCau.YeuCauID));

            }
            List<PhanCong> lstCongViec = new List<PhanCong>();
            foreach (YeuCau yeuCau in yeuCaus)
            {
                List<PhanCong> p = yeuCau.PhanCong.ToList().FindAll(x => x.CanBoID == canBo.CanBoID);
                lstCongViec.AddRange(p);
            }
            dtGridTKCanBo.DataSource = lstCongViec;
        }

        private void dtGridTKCanBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTKCanBo_Load(object sender, EventArgs e)
        {

        }

        private void cbbTimTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.Where(x => x.HoTen.Contains(cbbTimTen.Text)).ToList();
        }
    }
}
