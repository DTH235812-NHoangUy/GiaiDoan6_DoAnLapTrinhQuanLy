using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmHoaDon : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private int id = 0;
        private int nhanVienIDDangNhap = 0;
        private string vaiTro = "";

        public frmHoaDon()
        {
            InitializeComponent();
        }

        public frmHoaDon(int nhanVienID, string vaiTro)
        {
            InitializeComponent();
            this.nhanVienIDDangNhap = nhanVienID;
            this.vaiTro = vaiTro ?? "";
        }

        private bool LaAdmin()
        {
            return vaiTro.Trim().ToLower() == "admin";
        }

        private void ApDungPhanQuyen()
        {
            if (LaAdmin())
            {
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = dgvHoaDon.Rows.Count > 0;
            }
        }

        private void CaiDatNut(KryptonButton btn, Image icon, string text)
        {
            btn.Values.Image = icon;
            btn.Values.Text = text;
        }

        private void CaiDatIconNut()
        {
            CaiDatNut(btnInHoaDon, Properties.Resources.save_24, "In hóa đơn...");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnTimKiem, Properties.Resources.search_24, "Tìm kiếm...");
            CaiDatNut(btnXuat, Properties.Resources.export_24, "Xuất Excel...");
            CaiDatNut(btnXoa, Properties.Resources.delete_24, "Xóa");
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            CauHinhDataGridView();
            TaiDanhSachHoaDon();
            ApDungPhanQuyen();
        }

        private void CauHinhDataGridView()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.RowHeadersVisible = false;

            if (dgvHoaDon.Columns["NgayLap"] != null)
            {
                dgvHoaDon.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvHoaDon.Columns["NgayLap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvHoaDon.Columns["TongTienHoaDon"] != null)
            {
                dgvHoaDon.Columns["TongTienHoaDon"].DefaultCellStyle.Format = "N0";
                dgvHoaDon.Columns["TongTienHoaDon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvHoaDon.Columns["TongTienHoaDon"].DefaultCellStyle.ForeColor = Color.Blue;
                dgvHoaDon.Columns["TongTienHoaDon"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }

            if (dgvHoaDon.Columns["XemChiTiet"] != null)
            {
                dgvHoaDon.Columns["XemChiTiet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void TaiDanhSachHoaDon()
        {
            try
            {
                var query = context.HoaDon.AsNoTracking();

                if (!LaAdmin())
                {
                    query = query.Where(r => r.NhanVienID == nhanVienIDDangNhap);
                }

                var ds = query
                    .Select(r => new DanhSachHoaDon
                    {
                        ID = r.ID,
                        HoVaTenNhanVien = r.NhanVien.HoVaTen,
                        HoVaTenKhachHang = r.KhachHang.HoVaTen,
                        NgayLap = r.NgayLap,
                        GhiChu = r.GhiChu,
                        TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (double)ct.DonGiaBan),
                        XemChiTiet = "Xem chi tiết"
                    })
                    .OrderByDescending(r => r.ID)
                    .ToList();

                dgvHoaDon.DataSource = null;
                dgvHoaDon.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách hóa đơn.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDanhSachHoaDon(object dataSource)
        {
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = dataSource;
        }

        private bool LayHoaDonDangChon()
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgvHoaDon.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Không lấy được mã hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value);
            return true;
        }

        private bool KiemTraHoaDonThuocNhanVienDangNhap()
        {
            if (LaAdmin())
                return true;

            bool hopLe = context.HoaDon
                .AsNoTracking()
                .Any(x => x.ID == id && x.NhanVienID == nhanVienIDDangNhap);

            if (!hopLe)
            {
                MessageBox.Show("Bạn không có quyền thao tác hóa đơn này.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (!LayHoaDonDangChon())
                return;

            if (!KiemTraHoaDonThuocNhanVienDangNhap())
                return;

            MessageBox.Show("Bạn gắn chức năng in hóa đơn sau nhé.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập từ khóa tìm kiếm (mã hóa đơn, khách hàng, nhân viên, ngày lập, ghi chú, tổng tiền):",
                "Tìm kiếm hóa đơn",
                "");

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                TaiDanhSachHoaDon();
                ApDungPhanQuyen();
                return;
            }

            try
            {
                string lower = searchTerm.Trim().ToLower();

                var query = context.HoaDon.AsNoTracking();

                if (!LaAdmin())
                {
                    query = query.Where(r => r.NhanVienID == nhanVienIDDangNhap);
                }

                var ketQua = query
                    .Select(r => new DanhSachHoaDon
                    {
                        ID = r.ID,
                        HoVaTenNhanVien = r.NhanVien.HoVaTen,
                        HoVaTenKhachHang = r.KhachHang.HoVaTen,
                        NgayLap = r.NgayLap,
                        GhiChu = r.GhiChu,
                        TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (double)ct.DonGiaBan),
                        XemChiTiet = "Xem chi tiết"
                    })
                    .ToList()
                    .Where(r =>
                        r.ID.ToString().ToLower().Contains(lower) ||
                        (r.HoVaTenNhanVien ?? "").ToLower().Contains(lower) ||
                        (r.HoVaTenKhachHang ?? "").ToLower().Contains(lower) ||
                        (r.GhiChu ?? "").ToLower().Contains(lower) ||
                        r.NgayLap.ToString("dd/MM/yyyy").ToLower().Contains(lower) ||
                        r.TongTienHoaDon.ToString("N0").ToLower().Contains(lower) ||
                        r.TongTienHoaDon.ToString().ToLower().Contains(lower))
                    .OrderByDescending(r => r.ID)
                    .ToList();

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachHoaDon();
                }
                else
                {
                    TaiDanhSachHoaDon(ketQua);
                }

                ApDungPhanQuyen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem hóa đơn, không được xóa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!LayHoaDonDangChon())
                return;

            if (!KiemTraHoaDonThuocNhanVienDangNhap())
                return;

            if (MessageBox.Show(
                "Bạn có chắc muốn xóa toàn bộ hóa đơn này không?\nToàn bộ vé trong hóa đơn cũng sẽ bị xóa khỏi chi tiết.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var dsChiTiet = context.HoaDon_ChiTiet
                    .Where(x => x.HoaDonID == id)
                    .ToList();

                context.HoaDon_ChiTiet.RemoveRange(dsChiTiet);

                var hoaDon = context.HoaDon.SingleOrDefault(x => x.ID == id);
                if (hoaDon != null)
                {
                    context.HoaDon.Remove(hoaDon);
                }

                context.SaveChanges();

                MessageBox.Show("Đã xóa toàn bộ hóa đơn thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDanhSachHoaDon();
                ApDungPhanQuyen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa hóa đơn thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn gắn chức năng xuất Excel sau nhé.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int hoaDonId = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["ID"].Value);

                if (!LaAdmin())
                {
                    bool hopLe = context.HoaDon
                        .AsNoTracking()
                        .Any(x => x.ID == hoaDonId && x.NhanVienID == nhanVienIDDangNhap);

                    if (!hopLe)
                    {
                        MessageBox.Show("Bạn không có quyền xem chi tiết hóa đơn này.",
                            "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(hoaDonId, nhanVienIDDangNhap, vaiTro))
                {
                    chiTiet.ShowDialog();
                }

                TaiDanhSachHoaDon();
                ApDungPhanQuyen();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}