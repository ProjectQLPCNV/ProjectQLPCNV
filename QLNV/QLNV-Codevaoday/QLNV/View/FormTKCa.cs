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

namespace QLNV.View
{
    public partial class FormTKCa : Form
    {
        public FormTKCa()
        {
            InitializeComponent();
        }

        private void FormTKCa_Load(object sender, EventArgs e)
        {

        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            CanBo canBo = new CanBo();
            canBo.CanBoID = 7;
            string picke1 = fromDate.Value.ToString("yyyy/M/d");

            string picke2 = toDate.Value.ToString("yyyy/M/d");

            string query = string.Format("SELECT * from YeuCau where NgayTruc between '{0}' and '{1}'", picke1, picke2);
            List<YeuCau> lstYeuCau = db.YeuCau.SqlQuery(query).ToList();
            //List<YeuCau> yeuCaus = new List<YeuCau>();
            //foreach (YeuCau yeuCau in lstYeuCau)
            //{
            //    yeuCaus.Add(db.YeuCau.SingleOrDefault(x => x.YeuCauID == yeuCau.YeuCauID));

            //}
            //List<PhanCong> lstCongViec = new List<PhanCong>();
            //foreach (YeuCau yeuCau in yeuCaus)
            //{
            //    List<PhanCong> p = yeuCau.PhanCong.ToList().FindAll(x => x.CanBoID == canBo.CanBoID);
            //    lstCongViec.AddRange(p);
            //}
            dtGridTKCanBo.DataSource = lstYeuCau;
        }

        private void dtGridTKCanBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
