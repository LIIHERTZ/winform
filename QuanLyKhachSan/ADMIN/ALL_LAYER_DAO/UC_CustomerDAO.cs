using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.ADMIN.ALL_LAYER_DAO
{
    internal class UC_CustomerDAO
    {
        QLKS_ENTITY db = new QLKS_ENTITY();
        public List<KhachHang> LoadKH()
        {
            var p = from k in db.KhachHangs select k;
            return p.ToList();
        }

        public List<KhachHang> LocKH(int a)
        {
            var p = from k in db.KhachHangs
                    where k.MaKH == a
                    select k;
            return p.ToList();
        }
    }
}
