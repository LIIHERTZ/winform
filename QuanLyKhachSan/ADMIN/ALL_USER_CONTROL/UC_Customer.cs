using QuanLyKhachSan.ADMIN.ALL_FORM;
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

namespace QuanLyKhachSan.ADMIN.ALL_USER_CONTROL
{
    public partial class UC_Customer : UserControl
    {
        UC_CustomerDAO uccustomerdao = new UC_CustomerDAO();
        public UC_Customer()
        {
            InitializeComponent();
            dg_KhachHang.AutoGenerateColumns = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
       
            dg_KhachHang.DataSource = uccustomerdao.LoadKH();
        }
        private void dg_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string s = dg_KhachHang.Rows[rowIndex].Cells["MaKH"].Value.ToString();

            CustomerDetail a = new CustomerDetail(s);
            a.ShowDialog();
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            uccustomerdao = new UC_CustomerDAO();
            dg_KhachHang.DataSource = uccustomerdao.LocKH(Convert.ToInt32(txt_MaKH.Text));
        }
    }
}
