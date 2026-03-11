using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmSanVanDong
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            grpTTSVD = new GroupBox();
            btnDoiAnh = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnXuat = new KryptonButton();
            btnNhap = new KryptonButton();
            btnThoat = new KryptonButton();
            btnHuy = new KryptonButton();
            btnLuu = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThem = new KryptonButton();
            picHinhAnh = new PictureBox();
            txtDiaChi = new KryptonTextBox();
            txtTenSan = new KryptonTextBox();
            txtID = new KryptonTextBox();
            lblDiaChi = new Label();
            lblTenSan = new Label();
            lblID = new Label();
            grpSanVanDong = new GroupBox();
            dgvSanVanDong = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            grpTTSVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            grpSanVanDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).BeginInit();
            SuspendLayout();
            // 
            // grpTTSVD
            // 
            grpTTSVD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTSVD.BackColor = Color.White;
            grpTTSVD.Controls.Add(btnDoiAnh);
            grpTTSVD.Controls.Add(btnTimKiem);
            grpTTSVD.Controls.Add(btnXuat);
            grpTTSVD.Controls.Add(btnNhap);
            grpTTSVD.Controls.Add(btnThoat);
            grpTTSVD.Controls.Add(btnHuy);
            grpTTSVD.Controls.Add(btnLuu);
            grpTTSVD.Controls.Add(btnSua);
            grpTTSVD.Controls.Add(btnXoa);
            grpTTSVD.Controls.Add(btnThem);
            grpTTSVD.Controls.Add(picHinhAnh);
            grpTTSVD.Controls.Add(txtDiaChi);
            grpTTSVD.Controls.Add(txtTenSan);
            grpTTSVD.Controls.Add(txtID);
            grpTTSVD.Controls.Add(lblDiaChi);
            grpTTSVD.Controls.Add(lblTenSan);
            grpTTSVD.Controls.Add(lblID);
            grpTTSVD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTTSVD.ForeColor = Color.FromArgb(45, 62, 80);
            grpTTSVD.Location = new Point(20, 15);
            grpTTSVD.Name = "grpTTSVD";
            grpTTSVD.Size = new Size(1240, 215);
            grpTTSVD.TabIndex = 0;
            grpTTSVD.TabStop = false;
            grpTTSVD.Text = "Thông tin sân vận động";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoiAnh.Location = new Point(985, 160);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.OverrideDefault.Back.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Back.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Border.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Border.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnDoiAnh.OverrideDefault.Border.Rounding = 8F;
            btnDoiAnh.Size = new Size(180, 38);
            btnDoiAnh.StateCommon.Back.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Back.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Border.Color1 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Border.Color2 = Color.FromArgb(99, 110, 114);
            btnDoiAnh.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnDoiAnh.StateCommon.Border.Rounding = 8F;
            btnDoiAnh.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDoiAnh.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoiAnh.TabIndex = 0;
            btnDoiAnh.Values.Text = "Đổi ảnh";
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 118);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.OverrideDefault.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnTimKiem.OverrideDefault.Border.Rounding = 8F;
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.StateCommon.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnTimKiem.StateCommon.Border.Rounding = 8F;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Values.Text = "Tìm kiếm";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 72);
            btnXuat.Name = "btnXuat";
            btnXuat.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnXuat.OverrideDefault.Border.Rounding = 8F;
            btnXuat.Size = new Size(150, 40);
            btnXuat.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnXuat.StateCommon.Border.Rounding = 8F;
            btnXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXuat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuat.TabIndex = 2;
            btnXuat.Values.Text = "Xuất";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnNhap.OverrideDefault.Border.Rounding = 8F;
            btnNhap.Size = new Size(150, 40);
            btnNhap.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnNhap.StateCommon.Border.Rounding = 8F;
            btnNhap.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNhap.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.TabIndex = 3;
            btnNhap.Values.Text = "Nhập";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(150, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 4;
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
            btnHuy.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnHuy.OverrideDefault.Border.Rounding = 8F;
            btnHuy.Size = new Size(150, 40);
            btnHuy.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnHuy.StateCommon.Border.Rounding = 8F;
            btnHuy.StateCommon.Content.ShortText.Color1 = Color.White;
            btnHuy.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.TabIndex = 5;
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
            btnLuu.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnLuu.OverrideDefault.Border.Rounding = 8F;
            btnLuu.Size = new Size(150, 40);
            btnLuu.StateCommon.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnLuu.StateCommon.Border.Rounding = 8F;
            btnLuu.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLuu.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.TabIndex = 6;
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
            btnSua.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnSua.OverrideDefault.Border.Rounding = 8F;
            btnSua.Size = new Size(150, 40);
            btnSua.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnSua.StateCommon.Border.Rounding = 8F;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.TabIndex = 7;
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
            btnXoa.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnXoa.OverrideDefault.Border.Rounding = 8F;
            btnXoa.Size = new Size(150, 40);
            btnXoa.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnXoa.StateCommon.Border.Rounding = 8F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.TabIndex = 8;
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
            btnThem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThem.OverrideDefault.Border.Rounding = 8F;
            btnThem.Size = new Size(150, 40);
            btnThem.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThem.StateCommon.Border.Rounding = 8F;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.TabIndex = 9;
            btnThem.Values.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(985, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(180, 125);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 10;
            picHinhAnh.TabStop = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(130, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(260, 34);
            txtDiaChi.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtDiaChi.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtDiaChi.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtDiaChi.StateCommon.Border.Rounding = 6F;
            txtDiaChi.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtDiaChi.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtDiaChi.TabIndex = 11;
            // 
            // txtTenSan
            // 
            txtTenSan.Location = new Point(130, 82);
            txtTenSan.Name = "txtTenSan";
            txtTenSan.Size = new Size(260, 34);
            txtTenSan.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtTenSan.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtTenSan.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtTenSan.StateCommon.Border.Rounding = 6F;
            txtTenSan.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtTenSan.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtTenSan.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(260, 34);
            txtID.StateCommon.Back.Color1 = Color.FromArgb(245, 246, 250);
            txtID.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtID.StateCommon.Border.Rounding = 6F;
            txtID.StateCommon.Content.Color1 = Color.FromArgb(99, 110, 114);
            txtID.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtID.TabIndex = 13;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = Color.FromArgb(45, 52, 54);
            lblDiaChi.Location = new Point(30, 138);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(63, 23);
            lblDiaChi.TabIndex = 14;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenSan
            // 
            lblTenSan.AutoSize = true;
            lblTenSan.Font = new Font("Segoe UI", 10F);
            lblTenSan.ForeColor = Color.FromArgb(45, 52, 54);
            lblTenSan.Location = new Point(30, 88);
            lblTenSan.Name = "lblTenSan";
            lblTenSan.Size = new Size(69, 23);
            lblTenSan.TabIndex = 15;
            lblTenSan.Text = "Tên sân:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(45, 52, 54);
            lblID.Location = new Point(30, 38);
            lblID.Name = "lblID";
            lblID.Size = new Size(29, 23);
            lblID.TabIndex = 16;
            lblID.Text = "ID:";
            // 
            // grpSanVanDong
            // 
            grpSanVanDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpSanVanDong.BackColor = Color.White;
            grpSanVanDong.Controls.Add(dgvSanVanDong);
            grpSanVanDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpSanVanDong.ForeColor = Color.FromArgb(45, 62, 80);
            grpSanVanDong.Location = new Point(20, 245);
            grpSanVanDong.Name = "grpSanVanDong";
            grpSanVanDong.Size = new Size(1240, 445);
            grpSanVanDong.TabIndex = 1;
            grpSanVanDong.TabStop = false;
            grpSanVanDong.Text = "Danh sách sân vận động";
            // 
            // dgvSanVanDong
            // 
            dgvSanVanDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanVanDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanVanDong.BackgroundColor = Color.White;
            dgvSanVanDong.BorderStyle = BorderStyle.None;
            dgvSanVanDong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSanVanDong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSanVanDong.EnableHeadersVisualStyles = false;
            dgvSanVanDong.Location = new Point(10, 30);
            dgvSanVanDong.MultiSelect = false;
            dgvSanVanDong.Name = "dgvSanVanDong";
            dgvSanVanDong.RowHeadersVisible = false;
            dgvSanVanDong.RowTemplate.Height = 70;
            dgvSanVanDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanVanDong.Size = new Size(1220, 405);
            dgvSanVanDong.TabIndex = 0;
            dgvSanVanDong.GridColor = Color.FromArgb(230, 230, 230);
            dgvSanVanDong.ColumnHeadersHeight = 40;
            dgvSanVanDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            headerStyle.BackColor = Color.FromArgb(108, 92, 231);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.SelectionBackColor = Color.FromArgb(108, 92, 231);
            headerStyle.SelectionForeColor = Color.White;
            dgvSanVanDong.ColumnHeadersDefaultCellStyle = headerStyle;

            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.SelectionBackColor = Color.FromArgb(223, 230, 233);
            cellStyle.SelectionForeColor = Color.Black;
            dgvSanVanDong.DefaultCellStyle = cellStyle;

            dgvSanVanDong.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSan, colDiaChi, colHinhAnh });
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 15F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 25F;
            colTenSan.HeaderText = "Tên Sân";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.FillWeight = 30F;
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            colHinhAnh.FillWeight = 30F;
            colHinhAnh.HeaderText = "Hình ảnh sân vận động";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanVanDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpSanVanDong);
            Controls.Add(grpTTSVD);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            WindowState = FormWindowState.Normal;
            Name = "frmSanVanDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sân Vận Động";
            Load += frmSanVanDong_Load;
            grpTTSVD.ResumeLayout(false);
            grpTTSVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            grpSanVanDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTSVD;
        private Label lblID;
        private Label lblTenSan;
        private Label lblDiaChi;
        private KryptonTextBox txtID;
        private KryptonTextBox txtTenSan;
        private KryptonTextBox txtDiaChi;
        private PictureBox picHinhAnh;
        private KryptonButton btnThem;
        private KryptonButton btnXoa;
        private KryptonButton btnSua;
        private KryptonButton btnLuu;
        private KryptonButton btnHuy;
        private KryptonButton btnThoat;
        private KryptonButton btnNhap;
        private KryptonButton btnXuat;
        private KryptonButton btnTimKiem;
        private KryptonButton btnDoiAnh;
        private GroupBox grpSanVanDong;
        private DataGridView dgvSanVanDong;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewImageColumn colHinhAnh;
    }
}