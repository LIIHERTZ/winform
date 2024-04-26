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
        public List<KhachHang> loadKhachHang()
        {
            var p = from k in db.KhachHangs select k;
            return p.ToList();
        }
        public string layTenKH(string a)
        {
            string b="";
            var q = from k in db.KhachHangs where k.MaKH.ToString() == a select k;
            foreach (var k in q) 
            {
                b = k.HoTen;
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
