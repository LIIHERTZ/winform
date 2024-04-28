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
    public partial class UC_History : UserControl
    {
        UC_HistoryDAO historyDAO = new UC_HistoryDAO();
        public UC_History()
        {
            InitializeComponent();
            dg_LichSu.AutoGenerateColumns = false;
        }

        private void txt_MaKH_TextChanged(object sender, EventArgs e)
        {
            if (txt_MaKH.Text != "")
            {
                lbl_TenKH.Text = historyDAO.layTenKH(Convert.ToInt32(txt_MaKH.Text));
            }
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            historyDAO = new UC_HistoryDAO();
            dg_LichSu.DataSource = historyDAO.loadLichSu(Convert.ToInt32(txt_MaKH.Text));
        }

    }
}
