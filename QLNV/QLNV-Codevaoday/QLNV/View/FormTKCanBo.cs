﻿using System;
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

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //DateTime Tungay = fromDateSticker.Value.Date;
            //DateTime DenNgay = DateTime.Parse(toDateSticker.Value.Date.ToShortDateString());
            DateTime Tungay = fromDateSticker.Value.Date;
            DateTime DenNgay = toDateSticker.Value.Date;
            int ID = 10;
            CanBo canBo = db.CanBo.SingleOrDefault(x => x.CanBoID == ID);
            List<PhanCong> lstCongViec = canBo.PhanCong.ToList();
            List<PhanCong> lstThongKe = new List<PhanCong>();
            foreach (PhanCong phanCong in lstCongViec)
            {
                if(DateTime.Compare(phanCong.YeuCau.NgayTruc.Value.Date, Tungay) == -1 && DateTime.Compare(phanCong.YeuCau.NgayTruc.Value.Date, DenNgay)==-1)
                {
                    lstCongViec.Add(phanCong);
                }
            }
            dtGridTKCanBo.DataSource = lstCongViec;
            //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            //{
            //    if (db.State == ConnectionState.Closed)
            //        db.Open();
            //    string query = "select cb.CanBoID,ct.CaTrucID,ct.PhanCongID,ct.YeuCauID" +
            //                "from CanBo cb inner join PhanCong ct on cb.CanBoID = ct.CanBoID" +
            //                    $"where cb.NgaySinh between '{ fromDateSticker.Value}' and '{ toDateSticker.Value}'";
            //    dtGridTKCanBo.DataSource = db.Query<CanBo>(query, commandType: CommandType.Text);
            //}            
        }
    }
}
