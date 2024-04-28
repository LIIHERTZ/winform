using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ADMIN.ALL_LAYER_DAO
{
    internal class UC_HistoryDAO
    {
        QLKS_ENTITY db = new QLKS_ENTITY();
        public string layTenKH(int a)
        {
            string b = "";
            var q = from k in db.KhachHangs
                    where k.MaKH == a
                    select k;
            foreach (var k in q)
            {
                b = k.HoTen;
            }
            return b;
        }

        public List<DatPhong> loadLichSu(int a)
        {
            var p = from k in db.DatPhongs
                    where k.MaKH == a
                    select k;
            return p.ToList();
        }
    }
}
