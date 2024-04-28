using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.ADMIN.ALL_LAYER_DAO
{
    internal class CustomerDetailDAO
    {
        QLKS_ENTITY db = new QLKS_ENTITY();

        public KhachHang LoadData(string s)
        {
            KhachHang khachhang = db.KhachHangs.FirstOrDefault(kh => kh.MaKH.ToString() == s);
            return khachhang;
        }

        public void Luu(KhachHang a)
        {
            var p = db.KhachHangs.FirstOrDefault(k => k.MaKH == a.MaKH);
            if (p != null)
            {
                p.HoTen = a.HoTen;
                p.DiaChi = a.DiaChi;
                p.SDT = a.SDT;
                p.TenDangNhap = a.TenDangNhap;
                p.CCCD = a.CCCD;
                p.NgaySinh = a.NgaySinh;
                p.GioiTinh = a.GioiTinh;
                p.Anh = a.Anh;

                db.SaveChanges();
            }
            db.SaveChanges();
            MessageBox.Show("Sửa thông tin khách hàng thành công!");
        }
        public void SaveImage(PictureBox image, out string filename)
        {
            filename = string.Empty;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(opf.FileName);
                filename = Path.GetFileName(opf.FileName);
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string dest = Path.Combine(appDirectory, filename);
                File.Copy(opf.FileName, dest, true);
            }
        }
    }
}
