using Krypton.Toolkit;

namespace StadiumTicketBooking.Forms
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new KryptonPanel();
            btnDangXuat = new KryptonButton();
            btnVaiTro = new KryptonButton();
            btnNhanVien = new KryptonButton();
            btnSanVanDong = new KryptonButton();
            btnKhuVuc = new KryptonButton();
            btnGhe = new KryptonButton();
            btnSuKien = new KryptonButton();
            btnVe = new KryptonButton();
            btnKhachHang = new KryptonButton();
            btnChiTietHoaDon = new KryptonButton();
            btnHoaDon = new KryptonButton();
            btnDatVe = new KryptonButton();
            btnTrangChu = new KryptonButton();
            panelLogo = new KryptonPanel();
            lblLogo = new KryptonLabel();
            panelTop = new KryptonPanel();
            lblVaiTro = new KryptonLabel();
            lblNguoiDung = new KryptonLabel();
            lblTenHeThong = new KryptonLabel();
            panelBody = new KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)panelMenu).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelLogo).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelTop).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelBody).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnVaiTro);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(btnSanVanDong);
            panelMenu.Controls.Add(btnKhuVuc);
            panelMenu.Controls.Add(btnGhe);
            panelMenu.Controls.Add(btnSuKien);
            panelMenu.Controls.Add(btnVe);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnChiTietHoaDon);
            panelMenu.Controls.Add(btnHoaDon);
            panelMenu.Controls.Add(btnDatVe);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(274, 960);
            panelMenu.StateCommon.Color1 = Color.FromArgb(30, 41, 59);
            panelMenu.StateCommon.Color2 = Color.FromArgb(30, 41, 59);
            panelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.Location = new Point(0, 896);
            btnDangXuat.Margin = new Padding(3, 4, 3, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(274, 64);
            btnDangXuat.TabIndex = 12;
            btnDangXuat.Values.DropDownArrowColor = Color.Empty;
            btnDangXuat.Values.Text = "Đăng xuất";
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnVaiTro
            // 
            btnVaiTro.Dock = DockStyle.Top;
            btnVaiTro.Location = new Point(0, 831);
            btnVaiTro.Margin = new Padding(3, 4, 3, 4);
            btnVaiTro.Name = "btnVaiTro";
            btnVaiTro.Size = new Size(274, 64);
            btnVaiTro.TabIndex = 11;
            btnVaiTro.Values.DropDownArrowColor = Color.Empty;
            btnVaiTro.Values.Text = "Vai trò";
            btnVaiTro.Click += btnVaiTro_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.Location = new Point(0, 767);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(274, 64);
            btnNhanVien.TabIndex = 10;
            btnNhanVien.Values.DropDownArrowColor = Color.Empty;
            btnNhanVien.Values.Text = "Nhân viên";
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnSanVanDong
            // 
            btnSanVanDong.Dock = DockStyle.Top;
            btnSanVanDong.Location = new Point(0, 703);
            btnSanVanDong.Margin = new Padding(3, 4, 3, 4);
            btnSanVanDong.Name = "btnSanVanDong";
            btnSanVanDong.Size = new Size(274, 64);
            btnSanVanDong.TabIndex = 9;
            btnSanVanDong.Values.DropDownArrowColor = Color.Empty;
            btnSanVanDong.Values.Text = "Sân vận động";
            btnSanVanDong.Click += btnSanVanDong_Click;
            // 
            // btnKhuVuc
            // 
            btnKhuVuc.Dock = DockStyle.Top;
            btnKhuVuc.Location = new Point(0, 639);
            btnKhuVuc.Margin = new Padding(3, 4, 3, 4);
            btnKhuVuc.Name = "btnKhuVuc";
            btnKhuVuc.Size = new Size(274, 64);
            btnKhuVuc.TabIndex = 8;
            btnKhuVuc.Values.DropDownArrowColor = Color.Empty;
            btnKhuVuc.Values.Text = "Khu vực";
            btnKhuVuc.Click += btnKhuVuc_Click;
            // 
            // btnGhe
            // 
            btnGhe.Dock = DockStyle.Top;
            btnGhe.Location = new Point(0, 575);
            btnGhe.Margin = new Padding(3, 4, 3, 4);
            btnGhe.Name = "btnGhe";
            btnGhe.Size = new Size(274, 64);
            btnGhe.TabIndex = 7;
            btnGhe.Values.DropDownArrowColor = Color.Empty;
            btnGhe.Values.Text = "Ghế";
            btnGhe.Click += btnGhe_Click;
            // 
            // btnSuKien
            // 
            btnSuKien.Dock = DockStyle.Top;
            btnSuKien.Location = new Point(0, 511);
            btnSuKien.Margin = new Padding(3, 4, 3, 4);
            btnSuKien.Name = "btnSuKien";
            btnSuKien.Size = new Size(274, 64);
            btnSuKien.TabIndex = 6;
            btnSuKien.Values.DropDownArrowColor = Color.Empty;
            btnSuKien.Values.Text = "Sự kiện";
            btnSuKien.Click += btnSuKien_Click;
            // 
            // btnVe
            // 
            btnVe.Dock = DockStyle.Top;
            btnVe.Location = new Point(0, 447);
            btnVe.Margin = new Padding(3, 4, 3, 4);
            btnVe.Name = "btnVe";
            btnVe.Size = new Size(274, 64);
            btnVe.TabIndex = 5;
            btnVe.Values.DropDownArrowColor = Color.Empty;
            btnVe.Values.Text = "Vé";
            btnVe.Click += btnVe_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.Location = new Point(0, 383);
            btnKhachHang.Margin = new Padding(3, 4, 3, 4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(274, 64);
            btnKhachHang.TabIndex = 4;
            btnKhachHang.Values.DropDownArrowColor = Color.Empty;
            btnKhachHang.Values.Text = "Khách hàng";
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnChiTietHoaDon
            // 
            btnChiTietHoaDon.Dock = DockStyle.Top;
            btnChiTietHoaDon.Location = new Point(0, 319);
            btnChiTietHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            btnChiTietHoaDon.Size = new Size(274, 64);
            btnChiTietHoaDon.TabIndex = 3;
            btnChiTietHoaDon.Values.DropDownArrowColor = Color.Empty;
            btnChiTietHoaDon.Values.Text = "Chi tiết hóa đơn";
            btnChiTietHoaDon.Click += btnChiTietHoaDon_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.Location = new Point(0, 255);
            btnHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(274, 64);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Values.DropDownArrowColor = Color.Empty;
            btnHoaDon.Values.Text = "Hóa đơn";
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Dock = DockStyle.Top;
            btnDatVe.Location = new Point(0, 191);
            btnDatVe.Margin = new Padding(3, 4, 3, 4);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(274, 64);
            btnDatVe.TabIndex = 1;
            btnDatVe.Values.DropDownArrowColor = Color.Empty;
            btnDatVe.Values.Text = "Đặt vé";
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.Location = new Point(0, 127);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(274, 64);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Values.DropDownArrowColor = Color.Empty;
            btnTrangChu.Values.Text = "Trang chủ";
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(274, 127);
            panelLogo.StateCommon.Color1 = Color.FromArgb(15, 23, 42);
            panelLogo.StateCommon.Color2 = Color.FromArgb(15, 23, 42);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Margin = new Padding(3, 4, 3, 4);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(274, 127);
            lblLogo.StateCommon.ShortText.Color1 = Color.White;
            lblLogo.StateCommon.ShortText.Color2 = Color.White;
            lblLogo.StateCommon.ShortText.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLogo.TabIndex = 0;
            lblLogo.Values.Text = "STADIUM\r\nTICKET BOOKING";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblVaiTro);
            panelTop.Controls.Add(lblNguoiDung);
            panelTop.Controls.Add(lblTenHeThong);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(274, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1212, 100);
            panelTop.StateCommon.Color1 = Color.White;
            panelTop.StateCommon.Color2 = Color.White;
            panelTop.TabIndex = 1;
            // 
            // lblVaiTro
            // 
            lblVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVaiTro.Location = new Point(848, 56);
            lblVaiTro.Margin = new Padding(3, 4, 3, 4);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(131, 36);
            lblVaiTro.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            lblVaiTro.TabIndex = 2;
            lblVaiTro.Values.Text = "Vai trò: Trống";
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNguoiDung.Location = new Point(816, 19);
            lblNguoiDung.Margin = new Padding(3, 4, 3, 4);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(272, 36);
            lblNguoiDung.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            lblNguoiDung.TabIndex = 1;
            lblNguoiDung.Values.Text = "Người dùng: Chưa đăng nhập";
            // 
            // lblTenHeThong
            // 
            lblTenHeThong.Location = new Point(23, 27);
            lblTenHeThong.Margin = new Padding(3, 4, 3, 4);
            lblTenHeThong.Name = "lblTenHeThong";
            lblTenHeThong.Size = new Size(526, 55);
            lblTenHeThong.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblTenHeThong.StateCommon.ShortText.Color2 = Color.FromArgb(30, 41, 59);
            lblTenHeThong.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenHeThong.TabIndex = 0;
            lblTenHeThong.Values.Text = "QUẢN LÝ ĐẶT VÉ SÂN VẬN ĐỘNG";
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(274, 100);
            panelBody.Margin = new Padding(3, 4, 3, 4);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1212, 860);
            panelBody.StateCommon.Color1 = Color.FromArgb(241, 245, 249);
            panelBody.StateCommon.Color2 = Color.FromArgb(241, 245, 249);
            panelBody.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(panelBody);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý đặt vé sân vận động";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)panelMenu).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelLogo).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelTop).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelBody).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KryptonPanel panelMenu;
        private KryptonPanel panelLogo;
        private KryptonLabel lblLogo;
        private KryptonButton btnTrangChu;
        private KryptonButton btnDatVe;
        private KryptonButton btnHoaDon;
        private KryptonButton btnChiTietHoaDon;
        private KryptonButton btnKhachHang;
        private KryptonButton btnVe;
        private KryptonButton btnSuKien;
        private KryptonButton btnGhe;
        private KryptonButton btnKhuVuc;
        private KryptonButton btnSanVanDong;
        private KryptonButton btnNhanVien;
        private KryptonButton btnVaiTro;
        private KryptonButton btnDangXuat;
        private KryptonPanel panelTop;
        private KryptonLabel lblTenHeThong;
        private KryptonLabel lblNguoiDung;
        private KryptonLabel lblVaiTro;
        private KryptonPanel panelBody;
    }
}