namespace QuanLyKhachSan.ADMIN.ALL_USER_CONTROL
{
    partial class UC_History
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_LichSu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.txt_MaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_TenKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_LichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_LichSu
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dg_LichSu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_LichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dg_LichSu.ColumnHeadersHeight = 18;
            this.dg_LichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_LichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDP,
            this.MaKH,
            this.MaPhong,
            this.NgayDat,
            this.NgayTra,
            this.ThoiGianDat,
            this.TinhTrang});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_LichSu.DefaultCellStyle = dataGridViewCellStyle15;
            this.dg_LichSu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_LichSu.Location = new System.Drawing.Point(7, 85);
            this.dg_LichSu.Margin = new System.Windows.Forms.Padding(2);
            this.dg_LichSu.Name = "dg_LichSu";
            this.dg_LichSu.RowHeadersVisible = false;
            this.dg_LichSu.RowHeadersWidth = 51;
            this.dg_LichSu.RowTemplate.Height = 24;
            this.dg_LichSu.Size = new System.Drawing.Size(751, 379);
            this.dg_LichSu.TabIndex = 94;
            this.dg_LichSu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_LichSu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_LichSu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_LichSu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_LichSu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_LichSu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_LichSu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_LichSu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dg_LichSu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_LichSu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_LichSu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_LichSu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_LichSu.ThemeStyle.HeaderStyle.Height = 18;
            this.dg_LichSu.ThemeStyle.ReadOnly = false;
            this.dg_LichSu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_LichSu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_LichSu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_LichSu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_LichSu.ThemeStyle.RowsStyle.Height = 24;
            this.dg_LichSu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_LichSu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaDP
            // 
            this.MaDP.DataPropertyName = "MaDatPhong";
            this.MaDP.HeaderText = "Mã đặt phòng";
            this.MaDP.MinimumWidth = 6;
            this.MaDP.Name = "MaDP";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            // 
            // ThoiGianDat
            // 
            this.ThoiGianDat.DataPropertyName = "ThoiGianDat";
            this.ThoiGianDat.HeaderText = "Thời gian đặt";
            this.ThoiGianDat.MinimumWidth = 6;
            this.ThoiGianDat.Name = "ThoiGianDat";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.BackColor = System.Drawing.Color.Gray;
            this.btn_KiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemTra.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KiemTra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_KiemTra.Location = new System.Drawing.Point(546, 8);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(114, 42);
            this.btn_KiemTra.TabIndex = 99;
            this.btn_KiemTra.Text = "KIỂM TRA";
            this.btn_KiemTra.UseVisualStyleBackColor = false;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKH.DefaultText = "";
            this.txt_MaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKH.Location = new System.Drawing.Point(344, 23);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.PasswordChar = '\0';
            this.txt_MaKH.PlaceholderText = "";
            this.txt_MaKH.SelectedText = "";
            this.txt_MaKH.Size = new System.Drawing.Size(171, 22);
            this.txt_MaKH.TabIndex = 97;
            this.txt_MaKH.TextChanged += new System.EventHandler(this.txt_MaKH_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Black", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(7, 12);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(143, 44);
            this.guna2HtmlLabel2.TabIndex = 96;
            this.guna2HtmlLabel2.Text = "LỊCH SỬ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(170, 23);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(170, 33);
            this.guna2HtmlLabel1.TabIndex = 95;
            this.guna2HtmlLabel1.Text = "Nhập mã khách hàng:";
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.AutoSize = false;
            this.lbl_TenKH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenKH.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenKH.ForeColor = System.Drawing.Color.White;
            this.lbl_TenKH.Location = new System.Drawing.Point(344, 50);
            this.lbl_TenKH.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(171, 30);
            this.lbl_TenKH.TabIndex = 98;
            this.lbl_TenKH.Text = null;
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.dg_LichSu);
            this.Controls.Add(this.btn_KiemTra);
            this.Controls.Add(this.lbl_TenKH);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(779, 476);
            ((System.ComponentModel.ISupportInitialize)(this.dg_LichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dg_LichSu;
        private System.Windows.Forms.Button btn_KiemTra;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_TenKH;
    }
}
