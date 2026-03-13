using Krypton.Toolkit;

namespace StadiumTicketBooking.Forms
{
    partial class frmDangNhap
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
            panelLeft = new KryptonPanel();
            lblMoTa = new KryptonLabel();
            lblHeThong = new KryptonLabel();
            panelRight = new KryptonPanel();
            chkHienMatKhau = new KryptonCheckBox();
            btnThoat = new KryptonButton();
            btnDangNhap = new KryptonButton();
            txtMatKhau = new KryptonTextBox();
            txtTenDangNhap = new KryptonTextBox();
            lblMatKhau = new KryptonLabel();
            lblTenDangNhap = new KryptonLabel();
            lblDangNhap = new KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)panelLeft).BeginInit();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelRight).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(lblMoTa);
            panelLeft.Controls.Add(lblHeThong);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(453, 667);
            panelLeft.StateCommon.Color1 = Color.FromArgb(30, 41, 59);
            panelLeft.StateCommon.Color2 = Color.FromArgb(15, 23, 42);
            panelLeft.TabIndex = 0;
            // 
            // lblMoTa
            // 
            lblMoTa.Location = new Point(43, 313);
            lblMoTa.Margin = new Padding(3, 4, 3, 4);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(352, 75);
            lblMoTa.StateCommon.ShortText.Color1 = Color.Gainsboro;
            lblMoTa.StateCommon.ShortText.Color2 = Color.Gainsboro;
            lblMoTa.StateCommon.ShortText.Font = new Font("Segoe UI", 10F);
            lblMoTa.TabIndex = 1;
            lblMoTa.Values.Text = "Đăng nhập để quản lý vé, hóa đơn,\r\nkhách hàng và các danh mục hệ thống.";
            // 
            // lblHeThong
            // 
            lblHeThong.Location = new Point(40, 160);
            lblHeThong.Margin = new Padding(3, 4, 3, 4);
            lblHeThong.Name = "lblHeThong";
            lblHeThong.Size = new Size(473, 127);
            lblHeThong.StateCommon.ShortText.Color1 = Color.White;
            lblHeThong.StateCommon.ShortText.Color2 = Color.White;
            lblHeThong.StateCommon.ShortText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeThong.TabIndex = 0;
            lblHeThong.Values.Text = "HỆ THỐNG\r\nĐẶT VÉ SÂN VẬN ĐỘNG";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(chkHienMatKhau);
            panelRight.Controls.Add(btnThoat);
            panelRight.Controls.Add(btnDangNhap);
            panelRight.Controls.Add(txtMatKhau);
            panelRight.Controls.Add(txtTenDangNhap);
            panelRight.Controls.Add(lblMatKhau);
            panelRight.Controls.Add(lblTenDangNhap);
            panelRight.Controls.Add(lblDangNhap);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(453, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(461, 667);
            panelRight.StateCommon.Color1 = Color.White;
            panelRight.StateCommon.Color2 = Color.White;
            panelRight.TabIndex = 1;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.Location = new Point(82, 433);
            chkHienMatKhau.Margin = new Padding(3, 4, 3, 4);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(152, 35);
            chkHienMatKhau.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F);
            chkHienMatKhau.TabIndex = 2;
            chkHienMatKhau.Values.Text = "Hiện mật khẩu";
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(254, 493);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 56);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(239, 68, 68);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(239, 68, 68);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Color2 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.TabIndex = 4;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(82, 493);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(160, 56);
            btnDangNhap.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnDangNhap.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnDangNhap.StateCommon.Border.Color1 = Color.FromArgb(37, 99, 235);
            btnDangNhap.StateCommon.Border.Color2 = Color.FromArgb(37, 99, 235);
            btnDangNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnDangNhap.StateCommon.Border.Rounding = 8F;
            btnDangNhap.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDangNhap.StateCommon.Content.ShortText.Color2 = Color.White;
            btnDangNhap.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Values.DropDownArrowColor = Color.Empty;
            btnDangNhap.Values.Text = "Đăng nhập";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(82, 367);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(331, 38);
            txtMatKhau.StateCommon.Border.Color1 = Color.Silver;
            txtMatKhau.StateCommon.Border.Color2 = Color.Silver;
            txtMatKhau.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtMatKhau.StateCommon.Border.Rounding = 8F;
            txtMatKhau.StateCommon.Content.Font = new Font("Segoe UI", 11F);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(82, 233);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(331, 38);
            txtTenDangNhap.StateCommon.Border.Color1 = Color.Silver;
            txtTenDangNhap.StateCommon.Border.Color2 = Color.Silver;
            txtTenDangNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtTenDangNhap.StateCommon.Border.Rounding = 8F;
            txtTenDangNhap.StateCommon.Content.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Location = new Point(82, 327);
            lblMatKhau.Margin = new Padding(3, 4, 3, 4);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(102, 36);
            lblMatKhau.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Values.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Location = new Point(82, 193);
            lblTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(152, 36);
            lblTenDangNhap.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Values.Text = "Tên đăng nhập";
            // 
            // lblDangNhap
            // 
            lblDangNhap.Location = new Point(80, 93);
            lblDangNhap.Margin = new Padding(3, 4, 3, 4);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(360, 61);
            lblDangNhap.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblDangNhap.StateCommon.ShortText.Color2 = Color.FromArgb(30, 41, 59);
            lblDangNhap.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Values.Text = "Đăng nhập hệ thống";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)panelLeft).EndInit();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelRight).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private KryptonPanel panelLeft;
        private KryptonLabel lblMoTa;
        private KryptonLabel lblHeThong;
        private KryptonPanel panelRight;
        private KryptonCheckBox chkHienMatKhau;
        private KryptonButton btnThoat;
        private KryptonButton btnDangNhap;
        private KryptonTextBox txtMatKhau;
        private KryptonTextBox txtTenDangNhap;
        private KryptonLabel lblMatKhau;
        private KryptonLabel lblTenDangNhap;
        private KryptonLabel lblDangNhap;
    }
}