using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmMain : KryptonForm
    {
        private int nhanVienID = 0;
        private string tenDangNhap = "";
        private string vaiTro = "";
        private Form? formHienTai = null;

        public int NhanVienIDHienTai => nhanVienID;
        public string TenDangNhapHienTai => tenDangNhap;
        public string VaiTroHienTai => vaiTro;

        public frmMain()
        {
            InitializeComponent();
            CaiDatMenu();
        }

        public frmMain(int nhanVienID, string tenDangNhap, string vaiTro)
        {
            InitializeComponent();
            this.nhanVienID = nhanVienID;
            this.tenDangNhap = tenDangNhap;
            this.vaiTro = vaiTro;
            CaiDatMenu();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiThongTinDangNhap();
            PhanQuyenTheoVaiTro();
            HienThiTrangChu();
        }

        private void CaiDatMenu()
        {
            CaiDatButtonMenu(btnTrangChu);
            CaiDatButtonMenu(btnDatVe);
            CaiDatButtonMenu(btnHoaDon);
            CaiDatButtonMenu(btnChiTietHoaDon);
            CaiDatButtonMenu(btnKhachHang);
            CaiDatButtonMenu(btnVe);
            CaiDatButtonMenu(btnSuKien);
            CaiDatButtonMenu(btnGhe);
            CaiDatButtonMenu(btnKhuVuc);
            CaiDatButtonMenu(btnSanVanDong);
            CaiDatButtonMenu(btnNhanVien);
            CaiDatButtonMenu(btnVaiTro);
            CaiDatButtonMenu(btnDangXuat);
        }

        private void CaiDatButtonMenu(KryptonButton btn)
        {
            btn.OverrideDefault.Back.Color1 = Color.FromArgb(30, 41, 59);
            btn.OverrideDefault.Back.Color2 = Color.FromArgb(30, 41, 59);
            btn.OverrideDefault.Border.Color1 = Color.FromArgb(30, 41, 59);
            btn.OverrideDefault.Border.Color2 = Color.FromArgb(30, 41, 59);
            btn.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;

            btn.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btn.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btn.StateCommon.Border.Color1 = Color.FromArgb(30, 41, 59);
            btn.StateCommon.Border.Color2 = Color.FromArgb(30, 41, 59);
            btn.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btn.StateCommon.Border.Rounding = 0;
            btn.StateCommon.Content.ShortText.Color1 = Color.White;
            btn.StateCommon.Content.ShortText.Color2 = Color.White;
            btn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);

            btn.StateTracking.Back.Color1 = Color.FromArgb(51, 65, 85);
            btn.StateTracking.Back.Color2 = Color.FromArgb(51, 65, 85);
            btn.StateTracking.Border.Color1 = Color.FromArgb(51, 65, 85);
            btn.StateTracking.Border.Color2 = Color.FromArgb(51, 65, 85);
            btn.StateTracking.Border.DrawBorders = PaletteDrawBorders.All;

            btn.StatePressed.Back.Color1 = Color.FromArgb(59, 130, 246);
            btn.StatePressed.Back.Color2 = Color.FromArgb(59, 130, 246);
            btn.StatePressed.Border.Color1 = Color.FromArgb(59, 130, 246);
            btn.StatePressed.Border.Color2 = Color.FromArgb(59, 130, 246);
            btn.StatePressed.Border.DrawBorders = PaletteDrawBorders.All;

            btn.ButtonStyle = ButtonStyle.Custom1;
            btn.Cursor = Cursors.Hand;
        }

        private void HienThiThongTinDangNhap()
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
                tenDangNhap = "admin";

            if (string.IsNullOrWhiteSpace(vaiTro))
                vaiTro = "Admin";

            lblNguoiDung.Values.Text = "Người dùng: " + tenDangNhap;
            lblVaiTro.Values.Text = "Vai trò: " + vaiTro;
        }

        private void PhanQuyenTheoVaiTro()
        {
            string role = vaiTro.Trim().ToLower();

            if (role == "admin")
            {
                btnTrangChu.Visible = true;
                btnDatVe.Visible = false;
                btnHoaDon.Visible = true;
                btnChiTietHoaDon.Visible = false;
                btnKhachHang.Visible = true;
                btnVe.Visible = true;
                btnSuKien.Visible = true;
                btnGhe.Visible = true;
                btnKhuVuc.Visible = true;
                btnSanVanDong.Visible = true;
                btnNhanVien.Visible = true;
                btnVaiTro.Visible = true;
                btnDangXuat.Visible = true;
            }
            else if (role == "nhanvien")
            {
                btnTrangChu.Visible = true;
                btnDatVe.Visible = true;
                btnHoaDon.Visible = true;
                btnChiTietHoaDon.Visible = true;
                btnKhachHang.Visible = true;
                btnVe.Visible = false;
                btnSuKien.Visible = false;
                btnGhe.Visible = false;
                btnKhuVuc.Visible = false;
                btnSanVanDong.Visible = false;
                btnNhanVien.Visible = false;
                btnVaiTro.Visible = false;
                btnDangXuat.Visible = true;
            }
            else
            {
                btnTrangChu.Visible = true;
                btnDatVe.Visible = false;
                btnHoaDon.Visible = false;
                btnChiTietHoaDon.Visible = false;
                btnKhachHang.Visible = false;
                btnVe.Visible = false;
                btnSuKien.Visible = false;
                btnGhe.Visible = false;
                btnKhuVuc.Visible = false;
                btnSanVanDong.Visible = false;
                btnNhanVien.Visible = false;
                btnVaiTro.Visible = false;
                btnDangXuat.Visible = true;
            }
        }

        private void MoFormCon(Form frm)
        {
            if (formHienTai != null)
                formHienTai.Close();

            formHienTai = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelBody.Controls.Clear();
            panelBody.Controls.Add(frm);
            panelBody.Tag = frm;

            frm.Show();
            frm.BringToFront();
        }

        private void HienThiTrangChu()
        {
            panelBody.Controls.Clear();

            Label lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = Color.FromArgb(30, 41, 59);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Text = "Chào mừng đến với hệ thống quản lý đặt vé sân vận động";

            panelBody.Controls.Add(lbl);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmDatVe(nhanVienID, vaiTro));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmHoaDon(nhanVienID, vaiTro));
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmHoaDon_ChiTiet(0, nhanVienID, vaiTro));
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmKhachHang(vaiTro));
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmVe());
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmSuKien());
        }

        private void btnGhe_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmGhe());
        }

        private void btnKhuVuc_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmKhuVuc());
        }

        private void btnSanVanDong_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmSanVanDong());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhanVien());
        }

        private void btnVaiTro_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmVaiTro());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}