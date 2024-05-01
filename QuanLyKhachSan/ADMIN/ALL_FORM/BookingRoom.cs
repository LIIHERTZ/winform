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
    public partial class BookingRoom : Form
    {
        BookingRoomDAO booking =new BookingRoomDAO();
        Admin temp;
        DateTime time;
        public BookingRoom()
        {
            InitializeComponent();
        }
        public BookingRoom(string a, string b,Admin n)
        {
            InitializeComponent();
            temp = n;
            booking = new BookingRoomDAO();
            int sl =  booking.demDatPhong();
            txt_MaDatPhong.Text = sl.ToString();
            txt_MaDatPhong.Enabled = false;

            txt_MaPhong.Enabled = false;

            txt_GiaTien.Text = a;
            txt_GiaTien.Enabled = false;

            txt_MaPhong.Text = b;
            txt_MaPhong.Enabled = false ;

            dtp_NgayDatPhong.Value = DateTime.Now;
            dtp_NgayTraPhong.Value = DateTime.Now;

            time = DateTime.Now;
            txt_ThoiGian.Enabled = false;
            txt_ThoiGian.Text = time.ToString("HH:mm:ss");

            txt_TenKhachHang.Enabled = false;
        }

        private void btn_Thoat_DashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            int ketQua = DateTime.Compare(dtp_NgayDatPhong.Value, dtp_NgayTraPhong.Value);
            if (txt_MaKH.Text=="")
            {
                MessageBox.Show("Chưa nhập mã khách hàng!", "Chú ý");
            }
            else if (txt_TenKhachHang.Text == "")
            {
                MessageBox.Show("Khách hàng không tồn tại hoặc chưa đăng ký tài khoản!", "Chú ý");
            }
            else if (txt_SoNguoi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn số lượng người!", "Chú ý");
            }
            else if (booking.checkSoNguoi(txt_SoNguoi.Text,txt_MaPhong.Text))
            {
                MessageBox.Show("Vượt quá lượng người cho phép!", "Chú ý");
            }
            else if (ketQua>=0)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày đặt phòng!", "Chú ý");
            }
            else
            {
                booking = new BookingRoomDAO();
                DatPhong a = new DatPhong();
                a.MaKH = Convert.ToInt32(txt_MaKH.Text);
                a.MaPhong = Convert.ToInt32(txt_MaPhong.Text);
                a.ThoiGianDat = time;
                a.NgayDat = dtp_NgayDatPhong.Value;
                a.NgayTra = dtp_NgayTraPhong.Value;
                a.TinhTrang = "unfinish";
                booking.Them(a);
                UC_RoomsDAO ucroom = new UC_RoomsDAO();
                ucroom.Sua(txt_MaPhong.Text);
                this.Close();
                AdminDAO admin = new AdminDAO();
                admin.loadAllUCRooms(temp);
            }
        }

        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {
            booking = new BookingRoomDAO();
            string s = booking.checkMaKhachHang(txt_MaKH.Text);
            txt_TenKhachHang.Text = s;

        }

        private void txt_SoNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
