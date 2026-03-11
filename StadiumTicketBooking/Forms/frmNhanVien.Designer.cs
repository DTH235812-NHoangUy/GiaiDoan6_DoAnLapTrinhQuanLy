using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpTTNV = new GroupBox();
            cboVaiTro = new ComboBox();
            btnXuat = new KryptonButton();
            btnNhap = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnThoat = new KryptonButton();
            btnHuy = new KryptonButton();
            btnLuu = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThem = new KryptonButton();
            lblVaiTro = new Label();
            lblMatKhau = new Label();
            lblTenDN = new Label();
            txtMatKhau = new KryptonTextBox();
            txtDangNhap = new KryptonTextBox();
            btnDoiAnh = new KryptonButton();
            picHinhAnh = new PictureBox();
            txtDienThoai = new KryptonTextBox();
            lblDienThoai = new Label();
            lblHoTen = new Label();
            txtHoTen = new KryptonTextBox();
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
            grpTTNV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTNV.BackColor = Color.White;
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
            grpTTNV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTTNV.ForeColor = Color.FromArgb(45, 62, 80);
            grpTTNV.Location = new Point(20, 15);
            grpTTNV.Name = "grpTTNV";
            grpTTNV.Size = new Size(1240, 276);
            grpTTNV.TabIndex = 0;
            grpTTNV.TabStop = false;
            grpTTNV.Text = "Thông tin nhân viên";
            // 
            // cboVaiTro
            // 
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.Font = new Font("Segoe UI", 10F);
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(160, 182);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(230, 31);
            cboVaiTro.TabIndex = 21;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.OverrideDefault.Border.Rounding = 8F;
            btnXuat.Size = new Size(150, 40);
            btnXuat.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.StateCommon.Border.Rounding = 8F;
            btnXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXuat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuat.TabIndex = 20;
            btnXuat.Values.DropDownArrowColor = Color.Empty;
            btnXuat.Values.Text = "Xuất Excel";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNhap.OverrideDefault.Border.Rounding = 8F;
            btnNhap.Size = new Size(150, 40);
            btnNhap.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNhap.StateCommon.Border.Rounding = 8F;
            btnNhap.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNhap.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.TabIndex = 19;
            btnNhap.Values.DropDownArrowColor = Color.Empty;
            btnNhap.Values.Text = "Nhập Excel";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.OverrideDefault.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.OverrideDefault.Border.Rounding = 8F;
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.StateCommon.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.StateCommon.Border.Rounding = 8F;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(150, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 17;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.OverrideDefault.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnHuy.OverrideDefault.Border.Rounding = 8F;
            btnHuy.Size = new Size(150, 40);
            btnHuy.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnHuy.StateCommon.Border.Rounding = 8F;
            btnHuy.StateCommon.Content.ShortText.Color1 = Color.White;
            btnHuy.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.TabIndex = 16;
            btnHuy.Values.DropDownArrowColor = Color.Empty;
            btnHuy.Values.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.OverrideDefault.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnLuu.OverrideDefault.Border.Rounding = 8F;
            btnLuu.Size = new Size(150, 40);
            btnLuu.StateCommon.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnLuu.StateCommon.Border.Rounding = 8F;
            btnLuu.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLuu.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.TabIndex = 15;
            btnLuu.Values.DropDownArrowColor = Color.Empty;
            btnLuu.Values.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSua.OverrideDefault.Border.Rounding = 8F;
            btnSua.Size = new Size(150, 40);
            btnSua.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSua.StateCommon.Border.Rounding = 8F;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.TabIndex = 14;
            btnSua.Values.DropDownArrowColor = Color.Empty;
            btnSua.Values.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.OverrideDefault.Border.Rounding = 8F;
            btnXoa.Size = new Size(150, 40);
            btnXoa.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.StateCommon.Border.Rounding = 8F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.TabIndex = 13;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(440, 26);
            btnThem.Name = "btnThem";
            btnThem.OverrideDefault.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThem.OverrideDefault.Border.Rounding = 8F;
            btnThem.Size = new Size(150, 40);
            btnThem.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThem.StateCommon.Border.Rounding = 8F;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.TabIndex = 12;
            btnThem.Values.DropDownArrowColor = Color.Empty;
            btnThem.Values.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 10F);
            lblVaiTro.ForeColor = Color.FromArgb(45, 52, 54);
            lblVaiTro.Location = new Point(30, 186);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(64, 23);
            lblVaiTro.TabIndex = 10;
            lblVaiTro.Text = "Vai trò:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.ForeColor = Color.FromArgb(45, 52, 54);
            lblMatKhau.Location = new Point(30, 138);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 9;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTenDN
            // 
            lblTenDN.AutoSize = true;
            lblTenDN.Font = new Font("Segoe UI", 10F);
            lblTenDN.ForeColor = Color.FromArgb(45, 52, 54);
            lblTenDN.Location = new Point(30, 88);
            lblTenDN.Name = "lblTenDN";
            lblTenDN.Size = new Size(128, 23);
            lblTenDN.TabIndex = 8;
            lblTenDN.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(160, 132);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(230, 34);
            txtMatKhau.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtMatKhau.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtMatKhau.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtMatKhau.StateCommon.Border.Rounding = 6F;
            txtMatKhau.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtMatKhau.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Location = new Point(160, 82);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(230, 34);
            txtDangNhap.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtDangNhap.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtDangNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtDangNhap.StateCommon.Border.Rounding = 6F;
            txtDangNhap.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtDangNhap.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtDangNhap.TabIndex = 6;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoiAnh.Location = new Point(985, 210);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.OverrideDefault.Back.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Back.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Border.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Border.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDoiAnh.OverrideDefault.Border.Rounding = 8F;
            btnDoiAnh.Size = new Size(180, 38);
            btnDoiAnh.StateCommon.Back.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Back.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Border.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Border.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDoiAnh.StateCommon.Border.Rounding = 8F;
            btnDoiAnh.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDoiAnh.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoiAnh.TabIndex = 5;
            btnDoiAnh.Values.DropDownArrowColor = Color.Empty;
            btnDoiAnh.Values.Text = "Đổi ảnh thẻ";
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(985, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(180, 175);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 4;
            picHinhAnh.TabStop = false;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(160, 32);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(230, 34);
            txtDienThoai.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtDienThoai.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtDienThoai.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtDienThoai.StateCommon.Border.Rounding = 6F;
            txtDienThoai.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtDienThoai.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtDienThoai.TabIndex = 3;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 10F);
            lblDienThoai.ForeColor = Color.FromArgb(45, 52, 54);
            lblDienThoai.Location = new Point(30, 38);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(93, 23);
            lblDienThoai.TabIndex = 2;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.ForeColor = Color.FromArgb(45, 52, 54);
            lblHoTen.Location = new Point(30, 236);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 23);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(160, 226);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(230, 34);
            txtHoTen.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtHoTen.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtHoTen.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtHoTen.StateCommon.Border.Rounding = 6F;
            txtHoTen.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtHoTen.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtHoTen.TabIndex = 0;
            // 
            // grpNhanVien
            // 
            grpNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNhanVien.BackColor = Color.White;
            grpNhanVien.Controls.Add(dgvNhanVien);
            grpNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpNhanVien.ForeColor = Color.FromArgb(45, 62, 80);
            grpNhanVien.Location = new Point(20, 303);
            grpNhanVien.Name = "grpNhanVien";
            grpNhanVien.Size = new Size(1240, 405);
            grpNhanVien.TabIndex = 1;
            grpNhanVien.TabStop = false;
            grpNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 40;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colID, colHoVaTen, colDienThoai, colTenDangNhap, colVaiTro, colHinhAnh });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 230, 233);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = Color.FromArgb(230, 230, 230);
            dgvNhanVien.Location = new Point(10, 30);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 70;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1220, 365);
            dgvNhanVien.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 10F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colHoVaTen
            // 
            colHoVaTen.DataPropertyName = "HoVaTen";
            colHoVaTen.FillWeight = 22F;
            colHoVaTen.HeaderText = "Họ Và Tên";
            colHoVaTen.MinimumWidth = 6;
            colHoVaTen.Name = "colHoVaTen";
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.FillWeight = 18F;
            colDienThoai.HeaderText = "Điện Thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.FillWeight = 20F;
            colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "TenVaiTro";
            colVaiTro.FillWeight = 15F;
            colVaiTro.HeaderText = "Vai Trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colHinhAnh.DefaultCellStyle = dataGridViewCellStyle2;
            colHinhAnh.FillWeight = 15F;
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
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpNhanVien);
            Controls.Add(grpTTNV);
            Font = new Font("Segoe UI", 9F);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
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
        private KryptonButton btnDoiAnh;
        private PictureBox picHinhAnh;
        private KryptonTextBox txtDienThoai;
        private Label lblDienThoai;
        private Label lblHoTen;
        private KryptonTextBox txtHoTen;
        private Label lblMatKhau;
        private Label lblTenDN;
        private KryptonTextBox txtMatKhau;
        private KryptonTextBox txtDangNhap;
        private Label lblVaiTro;
        private KryptonButton btnSua;
        private KryptonButton btnXoa;
        private KryptonButton btnThem;
        private KryptonButton btnXuat;
        private KryptonButton btnNhap;
        private KryptonButton btnTimKiem;
        private KryptonButton btnThoat;
        private KryptonButton btnHuy;
        private KryptonButton btnLuu;
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