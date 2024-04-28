using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.ADMIN.ALL_LAYER_DAO
{
    internal class UC_ReseverRoomsDAO
    {
        QLKS_ENTITY db = new QLKS_ENTITY();
        public string layTenKhachHang(string a)
        {
            string b = "";
            var q = from k in db.KhachHangs where k.MaKH.ToString() == a select k;
            foreach (var k in q)
            {
                b = k.HoTen;
            }
            return b;
        }
        public void sua(string MaPhong)
        {
            var p = from k in db.Phongs where k.MaPhong.ToString() == MaPhong select k;
            foreach (var j in p)
            {
                j.TinhTrang = "full";
            }
            db.SaveChanges();
        }
    }
}
