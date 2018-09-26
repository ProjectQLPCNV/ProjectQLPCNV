using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.Model;

namespace QLNV.View
{
   
    public partial class FormChonCa : Form
    {
        YeuCau yeuCauEdit = new YeuCau();
        public FormChonCa(YeuCau yeuCau)
        {
            yeuCauEdit = yeuCau;
            InitializeComponent();
            List<CaTruc> lstCaTruc = yeuCau.CaTruc.ToList();
            if(lstCaTruc.Count != 0)
            {
                cbxChonCa.DataSource = lstCaTruc;
                cbxChonCa.DisplayMember = "TenCa";
                cbxChonCa.ValueMember = "CaTrucID";
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
        }
        QLPCNhanVienEntities db = new QLPCNhanVienEntities();
        private void FormChonCa_Load(object sender, EventArgs e)
        {
            canBoBindingSource.DataSource = db.CanBo.ToList();
            dtBatDau.Format = DateTimePickerFormat.Custom;
            dtBatDau.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtBatDau.ShowUpDown = true;
            dtKetThuc.Format = DateTimePickerFormat.Custom;
            dtKetThuc.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtKetThuc.ShowUpDown = true;
            lstCBDuocChon = new List<CanBo>();

        }
        List<CanBo> lstCBPhanCong;
        List<CanBo> lstCBBoPhanCong;
        List<CanBo> lstCBDuocChon;
        CaTruc caTrucEdit;
        private void btnPhai_Click(object sender, EventArgs e)
        {
            if (caTrucEdit == null)
            {
                MessageBox.Show("Ấn Nút 'Xem' Ca Chực Để Chọn Ca");
                return;
            }
            for (int i= dtGridTrai.RowCount - 1; i >= 0; i--)
            {
                int? SoViec = yeuCauEdit.PhanCong.Count;
                DataGridViewRow row = dtGridTrai.Rows[i];
                bool ae = Convert.ToBoolean(row.Cells["Chon"].Value);
                if (Convert.ToBoolean(row.Cells["Chon"].Value))
                {
                    if(lstCBDuocChon.Count <= yeuCauEdit.SoLuongNguoi && SoViec+1 < yeuCauEdit.SoLuongCa)
                    {
                        CanBo canBo = (CanBo)row.DataBoundItem;
                        List<PhanCong> lstPhancong = new List<PhanCong>();
                        if (canBo.PhanCong.Count != 0)
                        {
                             lstPhancong = canBo.PhanCong.ToList().FindAll(x => x.YeuCau.NgayTruc == yeuCauEdit.NgayTruc);
                        }
                       
                        if (lstPhancong.Count > 0)
                        {
                            foreach (PhanCong phanCong in lstPhancong)
                            {
                                if (DateTime.Compare((DateTime)phanCong.CaTruc.BatDau, (DateTime)caTrucEdit.BatDau) == 0 && DateTime.Compare((DateTime)caTrucEdit.BatDau, (DateTime)phanCong.CaTruc.KetThuc) == -1)
                                {
                                    MessageBox.Show("Cán bộ "+canBo.HoTen+"trùng ca trực");
                                }
                                else
                                {
                                    canBoBindingSource4.Add((CanBo)row.DataBoundItem);
                                    canBoBindingSource3.Add((CanBo)row.DataBoundItem);
                                    canBoBindingSource.RemoveAt(row.Index);
                                    lstCBDuocChon.Add(canBo);
                                    lstCBPhanCong.Add(canBo);
                                    dtGribPhai.DataSource = null;
                                    dtGribPhai.DataSource = lstPhancong;
                                }
                            }
                        }
                        else
                        {
                            canBoBindingSource4.Add((CanBo)row.DataBoundItem);
                            canBoBindingSource3.Add((CanBo)row.DataBoundItem);
                            canBoBindingSource.RemoveAt(row.Index);
                            lstCBDuocChon.Add((CanBo)row.DataBoundItem);
                            lstCBPhanCong.Add(canBo);
                            dtGribPhai.DataSource = null;
                            dtGribPhai.DataSource = lstCBPhanCong;
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Số người chọn đã đủ hoặc đã vượt quá số ca yêu cầu");
                        return;
                    }
                }
               
            }
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (caTrucEdit == null)
            {
                MessageBox.Show("Ấn Nút 'Xem' Ca Chực Để Chọn Ca");
                return;
            }
            for (int i=dtGribPhai.RowCount - 1; i >= 0; i--)
            {

                DataGridViewRow row = dtGribPhai.Rows[i];
                if (Convert.ToBoolean(row.Cells["Chon1"].Value))
                {
                    canBoBindingSource.Add((CanBo)row.DataBoundItem);
                    canBoBindingSource4.RemoveAt(row.Index);
                    canBoBindingSource3.RemoveAt(row.Index);

                    lstCBBoPhanCong.Add((CanBo)row.DataBoundItem);
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
            List<PhanCong> lstPhancong = new List<PhanCong>();
            db.PhanCong.RemoveRange(caTrucEdit.PhanCong);
            foreach(CanBo canBo in lstCBPhanCong)
            {
                lstPhancong.Add(new PhanCong()
                {
                    YeuCauID=yeuCauEdit.YeuCauID,
                    CanBoID = canBo.CanBoID,
                    CaTrucID = caTrucEdit.CaTrucID
                });
            }
            db.PhanCong.AddRange(lstPhancong);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
               
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            caTrucEdit = new CaTruc();
            if(cbxChonCa.SelectedValue == null)
            {
                MessageBox.Show("Không tìm thấy ca");
                return;
            }
            int id = int.Parse(cbxChonCa.SelectedValue.ToString());
            caTrucEdit = db.CaTruc.SingleOrDefault(x => x.CaTrucID == id);
            lstCBPhanCong = new List<CanBo>();
            lstCBBoPhanCong = new List<CanBo>();
            foreach(PhanCong phanCong in caTrucEdit.PhanCong)
            {
                lstCBPhanCong.Add(phanCong.CanBo);
            }
            dtGribPhai.DataSource = lstCBPhanCong;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGridTrai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
