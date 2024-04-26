using QuanLyKhachSan.ADMIN.ALL_LAYER_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.ADMIN.ALL_FORM
{
    public partial class BuyService : Form
    {
        BuyServiceDAO buy = new BuyServiceDAO();    
        public BuyService()
        {
            InitializeComponent();
        }
        string madv;
        public BuyService(string a, string b)
        {
            InitializeComponent();
            madv = a;
            lbl_TenDV.Text = b;
            cbb_MaKH.DataSource = buy.loadKhachHang();
            cbb_MaKH.DisplayMember = "MaKH";
            cbb_MaKH.ValueMember = "MaKH";
            cbb_MaKH.SelectedIndex = -1;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MaKH.SelectedValue != null)
            {
                string maKhachHang = cbb_MaKH.SelectedValue.ToString();
                lbl_TenKH.Text = buy.layTenKH(maKhachHang);
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            int sl = 0;
            if (int.TryParse(txt_SoLuong.Text, out sl))
            {
               int gia = buy.layTien(madv);
               lbl_TongTien.Text = (sl*gia).ToString() + " vnđ";
            }

        }

        private void btn_Mua_Click(object sender, EventArgs e)
        {
            TongDichVu a = new TongDichVu();
            a.MaDV = madv;
            string maKhachHang = cbb_MaKH.SelectedValue.ToString();
            a.MaKH = Convert.ToInt32(maKhachHang);
            for (int i = 0; i < Convert.ToInt32(txt_SoLuong.Text); i++) 
            {
                buy.themDichVu(a);
            }
            MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo");
            this.Close();
        }
    }
}
