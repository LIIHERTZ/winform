using QuanLyKhachSan.ADMIN.ALL_USER_CONTROL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.ADMIN.ALL_LAYER_DAO
{
    internal class UC_PayDAO
    {
        QLKS_ENTITY db = new QLKS_ENTITY();
        public List<HoaDon> loadMaHoaDon()
        {
            var p = from k in db.HoaDons where k.TinhTrang == "wait" select k;
            return p.ToList();
        }
        public void loadHoaDon(string mhd,UC_Pay pay)
        {
            int mdp=-1;
            int giaphong = 0;
            DateTime ngaydat = new DateTime(2024, 4, 25); 
            DateTime ngaytra = new DateTime(2024, 4, 25); 
            var query = from hoaDon in db.HoaDons
                        join nhanVien in db.NhanViens on hoaDon.NhanVienThanhToan equals nhanVien.MaNV
                        join datPhong in db.DatPhongs on hoaDon.MaDatPhong equals datPhong.MaDatPhong
                        join phong in db.Phongs on datPhong.MaPhong equals phong.MaPhong
                        join loaiPhong in db.LoaiPhongs on phong.LoaiPhong equals loaiPhong.MaLoaiPhong
                        join khachHang in db.KhachHangs on datPhong.MaKH equals khachHang.MaKH
                        where hoaDon.MaHoaDon.ToString() == mhd
                        select new
                        {
                            HoaDon = hoaDon,
                            NhanVien = nhanVien,
                            DatPhong = datPhong,
                            Phong = phong,
                            LoaiPhong = loaiPhong,
                            KhachHang = khachHang
                        };
            foreach (var item in query)
            {
                pay.lbl_MaHD.Text = item.HoaDon.MaHoaDon.ToString();
                pay.lbl_MaDatPhong.Text = item.DatPhong.MaDatPhong.ToString();
                pay.lbl_MaKH.Text = item.KhachHang.MaKH.ToString();
                pay.lbl_MaPhong.Text = item.Phong.MaPhong.ToString();
                pay.lbl_LoaiPhong.Text = item.LoaiPhong.MaLoaiPhong;
                pay.lbl_NgayDatPhong.Text = item.DatPhong.NgayDat.ToString();
                string ngayTra = item.HoaDon.NgayLap.ToString();
                pay.lbl_NgayTraPhong.Text = item.HoaDon.NgayLap.ToString();
                pay.lbl_NgayLapHoaDon.Text = ngayTra.Substring(0, 10);
                pay.lbl_MaNV.Text = item.NhanVien.HoTen.ToString();
                pay.lbl_TenKH.Text = item.KhachHang.HoTen.ToString();
                mdp = item.DatPhong.MaDatPhong;
                ngaydat = item.DatPhong.NgayDat.Value;
                ngaytra = item.DatPhong.NgayTra.Value;
                giaphong = Convert.ToInt32(item.LoaiPhong.Gia);
            }
            int tt = 0;
            var q = from k in db.TongDichVus
                    join j in db.DichVus on k.MaDV equals j.MaDV
                    where k.MaDatPhong.ToString() == mdp.ToString()
                    select new
                    {
                         TongDichVu = k,
                         DichVu = j,

                    };
            foreach ( var item in q)
            {
                int sl = Convert.ToInt32(item.TongDichVu.SoLuong);
                int gia = Convert.ToInt32(item.DichVu.Gia);
                tt = tt + sl*gia;
            }
            TimeSpan duration =  ngaytra - ngaydat;
            int songay = duration.Days;
            int tienphong = songay * giaphong;
            int tongtien = tienphong + tt; 
            pay.lbl_TienPhong.Text = tienphong.ToString();
            pay.lbl_TienDV.Text = tt.ToString();
            pay.lbl_TongTien .Text = tongtien.ToString();  
        }
    }
}
