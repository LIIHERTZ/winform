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
            cbb_MaDatPhong.DataSource = buy.loadMaDatPhong();
            cbb_MaDatPhong.DisplayMember = "MaPhong";
            cbb_MaDatPhong.ValueMember = "MaDatPhong";
            cbb_MaDatPhong.SelectedIndex = -1;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MaDatPhong.SelectedValue != null)
            {
                string madatphong = cbb_MaDatPhong.SelectedValue.ToString();
                lbl_TenKH.Text = buy.layTenKH(madatphong);
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
            else if (txt_SoLuong.Text == "")
            {
                lbl_TongTien.Text = "";
            }

        }

        private void btn_Mua_Click(object sender, EventArgs e)
        {
            if (cbb_MaDatPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phòng!", "Chú ý");
            }
            else if(txt_SoLuong.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Chú ý");
            }
            else
            {
                TongDichVu a = new TongDichVu();
                a.MaDV = madv;
                string madatphong = cbb_MaDatPhong.SelectedValue.ToString();
                a.MaDatPhong = Convert.ToInt32(madatphong);
                a.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                buy.themDichVu(a);
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo");
                this.Close();
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
