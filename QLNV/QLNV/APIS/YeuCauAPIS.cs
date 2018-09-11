﻿using QLNV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLNV.APIS
{
    class YeuCauAPIS
    {
        QLNVNhanVienEntities db = new QLNVNhanVienEntities();
        //GetYeuCau
        public IQueryable<YeuCau> GetYeuCau()
        {
            return db.YeuCau;
        }
        public YeuCau GetYeuCauID(int Id)
        {
            return db.YeuCau.SingleOrDefault(x => x.YeuCauID == Id);
        }
        public YeuCau GetYeuCauNgayTruc(DateTime ngayTruc)
        {
            return db.YeuCau.SingleOrDefault(x => x.NgayTruc == ngayTruc);
        }
        public YeuCau GetYeuCauIdAdmin(int IdAdmin)
        {
            return db.YeuCau.SingleOrDefault(x => x.IDAdmin == IdAdmin);
        }
        public void PostYeuCau(YeuCau yeuCau)
        {
            if (yeuCau == null)
            {

            }
            else
            {
                db.YeuCau.Add(yeuCau);
                db.SaveChanges();
            }
        }
        public void UpdateYeuCau(YeuCau yeuCau)
        {
            YeuCau YeuCau = db.YeuCau.SingleOrDefault(x => x.YeuCauID == yeuCau.YeuCauID);
            if (yeuCau == null)
            {

            }
            else
            {
                YeuCau.NgayTruc = yeuCau.NgayTruc;
                YeuCau.SoLuongCa = yeuCau.SoLuongCa;
                YeuCau.IDAdmin = yeuCau.IDAdmin;
            }
        }
        public void DeleteYeuCau(YeuCau yeuCau)
        {
            YeuCau YeuCau = db.YeuCau.SingleOrDefault(x => x.YeuCauID == yeuCau.YeuCauID);
            if (yeuCau == null)
            {

            }
            else
            {
                db.YeuCau.Remove(yeuCau);
            }
        }
    }
}
