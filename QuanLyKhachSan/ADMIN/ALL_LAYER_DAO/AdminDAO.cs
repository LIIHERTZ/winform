﻿using QuanLyKhachSan.ADMIN.ALL_USER_CONTROL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.ADMIN.ALL_LAYER_DAO
{
    internal class AdminDAO
    {
        QLKS_ENTITY db = new QLKS_ENTITY();
        string ten;
        FlowLayoutPanel fl;
        public void loadAllUCRooms(FlowLayoutPanel f)
        {

            var q = from k in db.Phongs
                    join j in db.LoaiPhongs on k.LoaiPhong equals j.MaLoaiPhong
                    select new
                    {
                        k,
                        j
                    };
            foreach (var item in q)
            {
                Phong a = new Phong();
                LoaiPhong b = new LoaiPhong();
                a.MaPhong = item.k.MaPhong;
                a.LoaiPhong = item.k.LoaiPhong;
                a.TinhTrang = item.k.TinhTrang;
                b.MaLoaiPhong = item.j.MaLoaiPhong;
                b.MoTa = item.j.MoTa;
                b.Gia = item.j.Gia;
                b.Anh = item.j.Anh;
                b.SoNguoi = item.j.SoNguoi;
                UC_Rooms c = new UC_Rooms(a,b);
                f.Controls.Add(c);
            }
        }
        public void loadAllUCBookedRooms(FlowLayoutPanel f,string tendnnv)
        {
            fl = f;
            ten = tendnnv;
            var q = from datPhong in db.DatPhongs
                        join phong in db.Phongs on datPhong.MaPhong equals phong.MaPhong
                        join loaiPhong in db.LoaiPhongs on phong.LoaiPhong equals loaiPhong.MaLoaiPhong
                        where phong.TinhTrang == "full" && datPhong.TinhTrang == "unfinish"
                        select new
                            {
                                DatPhong = datPhong,
                                Phong = phong,
                                LoaiPhong = loaiPhong
                            };
            foreach (var item in q)
            {
                Phong a = new Phong(); 
                LoaiPhong b = new LoaiPhong();
                DatPhong c = new DatPhong();
                a.MaPhong = item.Phong.MaPhong;
                a.LoaiPhong = item.Phong.LoaiPhong;
                a.TinhTrang = item.Phong.TinhTrang;
                b.MaLoaiPhong = item.LoaiPhong.MaLoaiPhong;
                b.MoTa = item.LoaiPhong.MoTa;
                b.Gia = item.LoaiPhong.Gia;
                b.Anh = item.LoaiPhong.Anh;
                b.SoNguoi = item.LoaiPhong.SoNguoi;
                c.MaDatPhong = item.DatPhong.MaDatPhong;
                c.MaPhong = item.DatPhong.MaPhong;
                c.MaKH = item.DatPhong.MaKH;
                c.NgayDat = item.DatPhong.NgayDat;  
                c.NgayTra = item.DatPhong.NgayTra;
                c.ThoiGianDat  = item.DatPhong.ThoiGianDat;

                UC_BookedRooms d = new UC_BookedRooms(a, b, c,tendnnv);
                f.Controls.Add(d);
            }
        }

        public void loadThanhToan(FlowLayoutPanel f)
        {
            fl = f;
            UC_Pay pay = new UC_Pay();
            f.Controls.Add(pay);
        }

        public void loadAllUCReserveRooms(FlowLayoutPanel f, string tendnnv)
        {
            fl = f;
            ten = tendnnv;
            var q = from datPhong in db.DatPhongs
                    join phong in db.Phongs on datPhong.MaPhong equals phong.MaPhong
                    join loaiPhong in db.LoaiPhongs on phong.LoaiPhong equals loaiPhong.MaLoaiPhong
                    where phong.TinhTrang == "wait" && datPhong.TinhTrang == "unfinish"
                    select new
                    {
                        DatPhong = datPhong,
                        Phong = phong,
                        LoaiPhong = loaiPhong
                    };
            foreach (var item in q)
            {
                Phong a = new Phong();
                LoaiPhong b = new LoaiPhong();
                DatPhong c = new DatPhong();
                a.MaPhong = item.Phong.MaPhong;
                a.LoaiPhong = item.Phong.LoaiPhong;
                a.TinhTrang = item.Phong.TinhTrang;
                b.MaLoaiPhong = item.LoaiPhong.MaLoaiPhong;
                b.MoTa = item.LoaiPhong.MoTa;
                b.Gia = item.LoaiPhong.Gia;
                b.Anh = item.LoaiPhong.Anh;
                b.SoNguoi = item.LoaiPhong.SoNguoi;
                c.MaDatPhong = item.DatPhong.MaDatPhong;
                c.MaPhong = item.DatPhong.MaPhong;
                c.MaKH = item.DatPhong.MaKH;
                c.NgayDat = item.DatPhong.NgayDat;
                c.ThoiGianDat = item.DatPhong.ThoiGianDat;

                UC_ReserveRooms d = new UC_ReserveRooms(a, b, c, tendnnv);
                f.Controls.Add(d);
            }
        }
        public void loadAllUCServices(FlowLayoutPanel f)
        {
            fl = f;
            var p = from k in db.DichVus select k;
            foreach (var k in p)
            {
                UC_Services a = new UC_Services(k);
                f.Controls.Add(a);
            }
        }
        public void RefreshBookedRooms()
        {
            if (fl != null)
            {
                fl.Controls.Clear();
                loadAllUCBookedRooms(fl, ten);
            }

        }
        public void loadLichSu(FlowLayoutPanel f)
        {
            fl = f;
            UC_History his = new UC_History();
            f.Controls.Add(his);
        }
        public void loadKhachHang(FlowLayoutPanel f)
        {
            fl = f;
            UC_Customer cus = new UC_Customer();
            f.Controls.Add(cus);
        }

    }
}
