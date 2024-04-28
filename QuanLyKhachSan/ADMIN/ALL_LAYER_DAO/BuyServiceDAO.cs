using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ADMIN.ALL_LAYER_DAO
{
    internal class BuyServiceDAO
    {
        QLKS_ENTITY db = new QLKS_ENTITY();
        public List<DatPhong> loadMaDatPhong()
        {
            var p = from k in db.DatPhongs where k.TinhTrang == "unfinish" select k;
            return p.ToList();
        }
        public string layTenKH(string a)
        {
            string b="";
            var q = from k in db.DatPhongs
                    join j in db.Phongs on k.MaPhong equals j.MaPhong
                    join h in db.KhachHangs on k.MaKH equals h.MaKH
                    where j.TinhTrang != "empty" && a == k.MaDatPhong.ToString()
                    select new
                    {
                        k,
                        j,
                        h
                    };
            foreach( var item in q)
            {
                b = item.h.HoTen;
            }
            return b;
        }
        public int layTien(string a) 
        {
            int kq = 0;
            var q = from k in db.DichVus where k.MaDV.ToString() == a select k;
            foreach (var k in q)
            {
                kq = Convert.ToInt32(k.Gia);
            }
            return kq;
        }
        public void themDichVu(TongDichVu a)
        {
            db.TongDichVus.Add(a);
            db.SaveChanges();

        }
    }
}
