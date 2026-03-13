using Microsoft.EntityFrameworkCore;
using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;

namespace StadiumTicketBooking.Forms
{
    public partial class frmDangNhap : KryptonForm
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
            chkHienMatKhau.Checked = false;
            txtTenDangNhap.Focus();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '●';
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
                e.SuppressKeyPress = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DangNhap()
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên đăng nhập.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show(
                    "Vui lòng nhập mật khẩu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                var nhanVien = context.NhanVien
                    .Include(x => x.VaiTro)
                    .FirstOrDefault(x => x.TenDangNhap == tenDangNhap);

                if (nhanVien == null)
                {
                    MessageBox.Show(
                        "Tên đăng nhập không tồn tại.",
                        "Lỗi đăng nhập",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtTenDangNhap.Focus();
                    txtTenDangNhap.SelectAll();
                    return;
                }

                if (nhanVien.MatKhau != matKhau)
                {
                    MessageBox.Show(
                        "Mật khẩu không đúng.",
                        "Lỗi đăng nhập",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtMatKhau.Focus();
                    txtMatKhau.SelectAll();
                    return;
                }

                int nhanVienID = nhanVien.ID;
                string vaiTro = nhanVien.VaiTro != null ? nhanVien.VaiTro.TenVaiTro : "NhanVien";
                string tenHienThi = !string.IsNullOrWhiteSpace(nhanVien.HoVaTen)
                    ? nhanVien.HoVaTen
                    : nhanVien.TenDangNhap;

                MessageBox.Show(
                    "Đăng nhập thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();

                frmMain frm = new frmMain(nhanVienID, tenHienThi, vaiTro);
                frm.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đăng nhập thất bại.\n\nChi tiết: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}