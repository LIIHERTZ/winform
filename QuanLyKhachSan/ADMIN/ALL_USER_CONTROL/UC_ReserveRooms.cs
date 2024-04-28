using QuanLyKhachSan.ADMIN.ALL_FORM;
using QuanLyKhachSan.ADMIN.ALL_LAYER_DAO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.ADMIN.ALL_USER_CONTROL
{
    public partial class UC_ReserveRooms : UserControl
    {
        string tendnNV;
        UC_ReseverRoomsDAO booked = new UC_ReseverRoomsDAO();
        Admin temp;
        public UC_ReserveRooms()
        {
            InitializeComponent();
        }
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public UC_ReserveRooms(Phong a, LoaiPhong b, DatPhong c, Admin f,string s)
        {
            InitializeComponent();
            temp = f;
            tendnNV = s;
            lbl_TinhTrang.Text = a.TinhTrang;
            lbl_MaDatPhong.Text = c.MaDatPhong.ToString();
            lbl_MaPhong.Text = a.MaPhong.ToString();
            lbl_LoaiPhong.Text = b.MaLoaiPhong;
            lbl_MaKH.Text = c.MaKH.ToString();
            lbl_TenKH.Text = booked.layTenKhachHang(c.MaKH.ToString());
            string day = c.NgayDat.ToString();
            lbl_NgayDat.Text = day.Substring(0, 10);
            string time = c.ThoiGianDat.ToString();
            lbl_ThoiGianDat.Text = time.Substring(10, 10);
            string image = Path.Combine(appDirectory, b.Anh);
            pic_Anh.Image = Image.FromFile(image);

        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            booked = new UC_ReseverRoomsDAO();
            booked.sua(lbl_MaPhong.Text);
            MessageBox.Show("Check In thành công!", "Thông báo");
            AdminDAO admin = new AdminDAO();
            admin.loadAllUCReserveRooms(temp, tendnNV);
        }
    }
}
