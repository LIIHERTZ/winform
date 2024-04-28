using QuanLyKhachSan.ADMIN.ALL_LAYER_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.ADMIN.ALL_FORM
{
    public partial class CustomerDetail : Form
    {
        string z;
        CustomerDetailDAO customerdetaildao = new CustomerDetailDAO();
        public CustomerDetail()
        {
            InitializeComponent();
        }

        public CustomerDetail(string s)
        {
            InitializeComponent();
            KhachHang a = new KhachHang();
            a = customerdetaildao.LoadData(s);
            txt_MaKH.Text = a.MaKH.ToString();
            txt_TenKH.Text = a.HoTen;
            txt_DiaChi.Text = a.DiaChi;
            txt_SDT.Text = a.SDT;
            txt_TenDN.Text = a.TenDangNhap;
            txt_CCCD.Text = a.CCCD;
            txt_NgaySinh.Text = a.NgaySinh.ToString();
            txt_GioiTinh.Text = a.GioiTinh;
            string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            z = a.Anh;
            string image1 = Path.Combine(appDirectory, z);
            pic_Anh.Image = Image.FromFile(image1);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            txt_TenKH.Enabled = true;
            txt_TenDN.Enabled = true;
            txt_SDT.Enabled = true;
            txt_NgaySinh.Enabled = true;
            txt_GioiTinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_CCCD.Enabled = true;
            btn_ChonAnh.Enabled = true;
            txt_TenKH.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            txt_TenKH.Enabled = false;
            txt_TenDN.Enabled = false;
            txt_SDT.Enabled = false;
            txt_NgaySinh.Enabled = false;
            txt_GioiTinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_CCCD.Enabled = false;
            btn_ChonAnh.Enabled = false;

            KhachHang a = new KhachHang();
            a.MaKH = Convert.ToInt32(txt_MaKH.Text);
            a.HoTen = txt_TenKH.Text;
            a.DiaChi = txt_DiaChi.Text;
            a.SDT = txt_SDT.Text;
            a.TenDangNhap = txt_TenDN.Text;
            a.CCCD = txt_CCCD.Text;
            a.NgaySinh = DateTime.Parse(txt_NgaySinh.Text);
            a.GioiTinh = txt_GioiTinh.Text;
            a.Anh = z;

            customerdetaildao.Luu(a);

        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            customerdetaildao.SaveImage(pic_Anh, out z);
        }
    }
}
