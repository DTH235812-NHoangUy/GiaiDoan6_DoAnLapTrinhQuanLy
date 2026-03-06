namespace StadiumTicketBooking.Forms
{
    partial class frmNhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grpTTNV = new GroupBox();
            cboVaiTro = new ComboBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lblVaiTro = new Label();
            lblMatKhau = new Label();
            lblTenDN = new Label();
            txtMatKhau = new TextBox();
            txtDangNhap = new TextBox();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            txtDienThoai = new TextBox();
            lblDienThoai = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            grpNhanVien = new GroupBox();
            dgvNhanVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoVaTen = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colVaiTro = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            grpTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpTTNV
            // 
            grpTTNV.BackColor = Color.Snow;
            grpTTNV.Controls.Add(cboVaiTro);
            grpTTNV.Controls.Add(btnXuat);
            grpTTNV.Controls.Add(btnNhap);
            grpTTNV.Controls.Add(btnTimKiem);
            grpTTNV.Controls.Add(btnThoat);
            grpTTNV.Controls.Add(btnHuy);
            grpTTNV.Controls.Add(btnLuu);
            grpTTNV.Controls.Add(btnSua);
            grpTTNV.Controls.Add(btnXoa);
            grpTTNV.Controls.Add(btnThem);
            grpTTNV.Controls.Add(lblVaiTro);
            grpTTNV.Controls.Add(lblMatKhau);
            grpTTNV.Controls.Add(lblTenDN);
            grpTTNV.Controls.Add(txtMatKhau);
            grpTTNV.Controls.Add(txtDangNhap);
            grpTTNV.Controls.Add(btnDoiAnh);
            grpTTNV.Controls.Add(picHinhAnh);
            grpTTNV.Controls.Add(txtDienThoai);
            grpTTNV.Controls.Add(lblDienThoai);
            grpTTNV.Controls.Add(lblHoTen);
            grpTTNV.Controls.Add(txtHoTen);
            grpTTNV.Dock = DockStyle.Top;
            grpTTNV.ForeColor = Color.Black;
            grpTTNV.Location = new Point(0, 0);
            grpTTNV.Name = "grpTTNV";
            grpTTNV.Size = new Size(785, 241);
            grpTTNV.TabIndex = 0;
            grpTTNV.TabStop = false;
            grpTTNV.Text = "Thông tin nhân viên:";
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Admin", "NhanVien" });
            cboVaiTro.Location = new Point(235, 100);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(151, 28);
            cboVaiTro.TabIndex = 21;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(491, 149);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(491, 114);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(491, 16);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(115, 203);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(115, 168);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(115, 133);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(6, 203);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(6, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 133);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Location = new Point(175, 103);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(54, 20);
            lblVaiTro.TabIndex = 10;
            lblVaiTro.Text = "Vai Trò";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(257, 67);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 20);
            lblMatKhau.TabIndex = 9;
            lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblTenDN
            // 
            lblTenDN.AutoSize = true;
            lblTenDN.Location = new Point(257, 29);
            lblTenDN.Name = "lblTenDN";
            lblTenDN.Size = new Size(107, 20);
            lblTenDN.TabIndex = 8;
            lblTenDN.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(347, 67);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(360, 26);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(125, 27);
            txtDangNhap.TabIndex = 6;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoiAnh.BackColor = Color.Transparent;
            btnDoiAnh.ForeColor = Color.Black;
            btnDoiAnh.Location = new Point(638, 210);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(114, 29);
            btnDoiAnh.TabIndex = 5;
            btnDoiAnh.Text = "Đổi Ảnh Thẻ";
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(606, 16);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(146, 188);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 4;
            picHinhAnh.TabStop = false;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(102, 63);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(125, 27);
            txtDienThoai.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(15, 63);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(84, 20);
            lblDienThoai.TabIndex = 2;
            lblDienThoai.Text = "Điện Thoại:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(15, 25);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(59, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(84, 22);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 0;
            // 
            // grpNhanVien
            // 
            grpNhanVien.BackColor = Color.Transparent;
            grpNhanVien.Controls.Add(dgvNhanVien);
            grpNhanVien.Dock = DockStyle.Fill;
            grpNhanVien.Location = new Point(0, 241);
            grpNhanVien.Name = "grpNhanVien";
            grpNhanVien.Size = new Size(785, 264);
            grpNhanVien.TabIndex = 1;
            grpNhanVien.TabStop = false;
            grpNhanVien.Text = "Danh sách nhân viên:";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colTenDangNhap, colVaiTro, colHinhAnh });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 23);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(779, 238);
            dgvNhanVien.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colHoVaTen
            // 
            colHoVaTen.DataPropertyName = "HoVaTen";
            colHoVaTen.HeaderText = "Họ Và Tên";
            colHoVaTen.MinimumWidth = 6;
            colHoVaTen.Name = "colHoVaTen";
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.HeaderText = "Điện Thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "TenVaiTro";
            colVaiTro.HeaderText = "Vai Trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colHinhAnh.DefaultCellStyle = dataGridViewCellStyle1;
            colHinhAnh.HeaderText = "Hình Ảnh";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.Resizable = DataGridViewTriState.True;
            colHinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(785, 505);
            Controls.Add(grpNhanVien);
            Controls.Add(grpTTNV);
            Name = "frmNhanVien";
            Text = "Quản Lý Nhân Viên";
            Load += frmNhanVien_Load;
            grpTTNV.ResumeLayout(false);
            grpTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            grpNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTNV;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private TextBox txtDienThoai;
        private Label lblDienThoai;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblMatKhau;
        private Label lblTenDN;
        private TextBox txtMatKhau;
        private TextBox txtDangNhap;
        private Label lblVaiTro;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private GroupBox grpNhanVien;
        private DataGridView dgvNhanVien;
        private ComboBox cboVaiTro;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoVaTen;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colVaiTro;
        private DataGridViewImageColumn colHinhAnh;
    }
}