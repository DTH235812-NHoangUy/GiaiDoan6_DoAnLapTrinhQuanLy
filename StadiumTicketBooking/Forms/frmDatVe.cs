using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmDatVe : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private int nhanVienIDDangNhap = 0;
        private string vaiTro = "";

        private class VeChonTam
        {
            public int VeID { get; set; }
            public string TenSuKien { get; set; } = string.Empty;
            public string SoGhe { get; set; } = string.Empty;
            public string TenKhuVuc { get; set; } = string.Empty;
            public string TenSan { get; set; } = string.Empty;
            public int GiaVe { get; set; }
        }

        private readonly List<VeChonTam> gioVe = new List<VeChonTam>();

        public frmDatVe()
        {
            InitializeComponent();
        }

        public frmDatVe(int nhanVienID, string vaiTro)
        {
            InitializeComponent();
            this.nhanVienIDDangNhap = nhanVienID;
            this.vaiTro = vaiTro ?? "";
        }

        private void CaiDatNut(KryptonButton btn, Image icon, string text)
        {
            btn.Values.Image = icon;
            btn.Values.Text = text;
        }

        private void CaiDatIconNut()
        {
            CaiDatNut(btnTaoMoi, Properties.Resources.add_24, "Tạo mới");
            CaiDatNut(btnThanhToan, Properties.Resources.save_24, "Thanh toán");
            CaiDatNut(btnHuyDon, Properties.Resources.cancel_24, "Hủy đơn");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnChonVe, Properties.Resources.add_24, "Chọn vé");
            CaiDatNut(btnBoVe, Properties.Resources.delete_24, "Bỏ vé");
        }

        private bool LaAdmin()
        {
            string role = vaiTro.Trim().ToLower();
            return role == "admin";
        }

        private bool LaNhanVien()
        {
            string role = vaiTro.Trim().ToLower();
            return role == "nhanvien" || role == "nhân viên";
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin không được phép đặt vé.", "Phân quyền",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            if (LaNhanVien() && nhanVienIDDangNhap <= 0)
            {
                MessageBox.Show("Không xác định được nhân viên đang đăng nhập.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            CaiDatIconNut();
            DinhDangGrid();
            TaiNhanVien();
            TaiKhachHang();
            TaiSuKien();
            TaoMoiDon();
        }

        private void DinhDangGrid()
        {
            dgvVeTrong.AutoGenerateColumns = false;
            dgvVeDaChon.AutoGenerateColumns = false;

            dgvVeTrong.AllowUserToAddRows = false;
            dgvVeTrong.AllowUserToDeleteRows = false;
            dgvVeTrong.MultiSelect = false;
            dgvVeTrong.ReadOnly = true;
            dgvVeTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeTrong.RowHeadersVisible = false;

            dgvVeDaChon.AllowUserToAddRows = false;
            dgvVeDaChon.AllowUserToDeleteRows = false;
            dgvVeDaChon.MultiSelect = false;
            dgvVeDaChon.ReadOnly = true;
            dgvVeDaChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeDaChon.RowHeadersVisible = false;

            if (dgvVeTrong.Columns["colGiaVe"] != null)
            {
                dgvVeTrong.Columns["colGiaVe"].DefaultCellStyle.Format = "N0";
                dgvVeTrong.Columns["colGiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvVeDaChon.Columns["colGiaVeDaChon"] != null)
            {
                dgvVeDaChon.Columns["colGiaVeDaChon"].DefaultCellStyle.Format = "N0";
                dgvVeDaChon.Columns["colGiaVeDaChon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void TaiNhanVien()
        {
            if (LaNhanVien())
            {
                var dsNhanVien = context.NhanVien
                    .AsNoTracking()
                    .Where(x => x.ID == nhanVienIDDangNhap)
                    .Select(x => new
                    {
                        x.ID,
                        x.HoVaTen
                    })
                    .ToList();

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.DisplayMember = "HoVaTen";
                cboNhanVien.ValueMember = "ID";

                if (dsNhanVien.Count > 0)
                    cboNhanVien.SelectedValue = nhanVienIDDangNhap;
                else
                    cboNhanVien.SelectedIndex = -1;

                cboNhanVien.Enabled = false;
            }
            else
            {
                var dsNhanVien = context.NhanVien
                    .AsNoTracking()
                    .Select(x => new
                    {
                        x.ID,
                        x.HoVaTen
                    })
                    .OrderBy(x => x.HoVaTen)
                    .ToList();

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.DisplayMember = "HoVaTen";
                cboNhanVien.ValueMember = "ID";
                cboNhanVien.SelectedIndex = -1;
                cboNhanVien.Enabled = true;
            }
        }

        private void TaiKhachHang()
        {
            var dsKhachHang = context.KhachHang
                .AsNoTracking()
                .Select(x => new
                {
                    x.ID,
                    x.HoVaTen
                })
                .OrderBy(x => x.HoVaTen)
                .ToList();

            cboKhachHang.DataSource = dsKhachHang;
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.ValueMember = "ID";

            if (dsKhachHang.Count > 0)
                cboKhachHang.SelectedIndex = 0;
            else
                cboKhachHang.SelectedIndex = -1;
        }

        private void TaiSuKien()
        {
            var dsSuKien = context.SuKien
                .AsNoTracking()
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.TenSuKien + " - " + x.SanVanDong.TenSan
                })
                .OrderBy(x => x.TenHienThi)
                .ToList();

            cboSuKien.DataSource = dsSuKien;
            cboSuKien.DisplayMember = "TenHienThi";
            cboSuKien.ValueMember = "ID";

            if (dsSuKien.Count > 0)
                cboSuKien.SelectedIndex = 0;
            else
                cboSuKien.SelectedIndex = -1;
        }

        private int LaySuKienIdDangChon()
        {
            if (cboSuKien.SelectedValue == null)
                return 0;

            if (cboSuKien.SelectedValue is int id)
                return id;

            int.TryParse(cboSuKien.SelectedValue.ToString(), out id);
            return id;
        }

        private void TaoMoiDon()
        {
            gioVe.Clear();
            dtpNgayLap.Value = DateTime.Now;
            txtGhiChu.Text = string.Empty;

            if (LaNhanVien())
                TaiNhanVien();

            TaiVeTrong();
            TaiGioVe();
            CapNhatTongTien();
        }

        private void TaiVeTrong()
        {
            int suKienId = LaySuKienIdDangChon();
            if (suKienId <= 0)
            {
                dgvVeTrong.DataSource = null;
                return;
            }

            var dsVeIdTrongGio = gioVe.Select(x => x.VeID).ToList();

            var veDaBan = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Select(x => x.VeID)
                .ToList();

            var listVeTrong = context.Ve
                .AsNoTracking()
                .Where(x => x.SuKienID == suKienId
                         && !veDaBan.Contains(x.ID)
                         && !dsVeIdTrongGio.Contains(x.ID))
                .Select(x => new
                {
                    x.ID,
                    TenSuKien = x.SuKien.TenSuKien,
                    SoGhe = x.Ghe.SoGhe,
                    TenKhuVuc = x.Ghe.KhuVuc.TenKhuVuc,
                    TenSan = x.Ghe.KhuVuc.SanVanDong.TenSan,
                    x.GiaVe
                })
                .OrderBy(x => x.SoGhe)
                .ToList();

            dgvVeTrong.DataSource = null;
            dgvVeTrong.DataSource = listVeTrong;
            DinhDangGrid();
        }

        private void TaiGioVe()
        {
            var ds = gioVe
                .Select(x => new
                {
                    VeID = x.VeID,
                    TenSuKien = x.TenSuKien,
                    SoGhe = x.SoGhe,
                    TenKhuVuc = x.TenKhuVuc,
                    GiaVe = x.GiaVe
                })
                .ToList();

            dgvVeDaChon.DataSource = null;
            dgvVeDaChon.DataSource = ds;
            DinhDangGrid();
        }

        private void CapNhatTongTien()
        {
            txtTongTien.Text = gioVe.Sum(x => x.GiaVe).ToString("N0");
        }

        private void cboSuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            gioVe.Clear();
            TaiVeTrong();
            TaiGioVe();
            CapNhatTongTien();
        }

        private void btnChonVe_Click(object sender, EventArgs e)
        {
            if (dgvVeTrong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvVeTrong.CurrentRow.Cells["colVeID"].Value?.ToString(), out int veId))
            {
                MessageBox.Show("Không xác định được vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gioVe.Any(x => x.VeID == veId))
            {
                MessageBox.Show("Vé này đã có trong giỏ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VeChonTam ve = new VeChonTam
            {
                VeID = veId,
                TenSuKien = dgvVeTrong.CurrentRow.Cells["colTenSuKien"].Value?.ToString() ?? "",
                SoGhe = dgvVeTrong.CurrentRow.Cells["colSoGhe"].Value?.ToString() ?? "",
                TenKhuVuc = dgvVeTrong.CurrentRow.Cells["colTenKhuVuc"].Value?.ToString() ?? "",
                TenSan = dgvVeTrong.CurrentRow.Cells["colTenSan"].Value?.ToString() ?? "",
                GiaVe = Convert.ToInt32(dgvVeTrong.CurrentRow.Cells["colGiaVe"].Value ?? 0)
            };

            gioVe.Add(ve);

            TaiVeTrong();
            TaiGioVe();
            CapNhatTongTien();
        }

        private void btnBoVe_Click(object sender, EventArgs e)
        {
            if (dgvVeDaChon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần bỏ khỏi giỏ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvVeDaChon.CurrentRow.Cells["colVeIDDaChon"].Value?.ToString(), out int veId))
            {
                MessageBox.Show("Không xác định được vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var veTrongGio = gioVe.FirstOrDefault(x => x.VeID == veId);
            if (veTrongGio != null)
            {
                gioVe.Remove(veTrongGio);
                TaiVeTrong();
                TaiGioVe();
                CapNhatTongTien();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoiDon();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy dữ liệu đang chọn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TaoMoiDon();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboKhachHang.Focus();
                return;
            }

            if (gioVe.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vé!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dsVeCanMua = gioVe.Select(x => x.VeID).ToList();

            bool coVeDaBan = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Any(x => dsVeCanMua.Contains(x.VeID));

            if (coVeDaBan)
            {
                MessageBox.Show("Có vé vừa được bán bởi hóa đơn khác. Vui lòng tải lại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TaiVeTrong();
                return;
            }

            var dsChiTietTam = gioVe.Select(x => new DanhSachHoaDon_ChiTiet
            {
                ID = 0,
                HoaDonID = 0,
                VeID = x.VeID,
                TenSuKien = x.TenSuKien,
                TenSan = x.TenSan,
                ViTriGhe = x.TenKhuVuc + " - Ghế " + x.SoGhe,
                SoLuongBan = 1,
                DonGiaBan = x.GiaVe,
                ThanhTien = x.GiaVe
            }).ToList();

            using (frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(
                nhanVienIDDangNhap,
                vaiTro,
                Convert.ToInt32(cboKhachHang.SelectedValue),
                txtGhiChu.Text.Trim(),
                dsChiTietTam))
            {
                frm.ShowDialog();

                if (frm.DaLuuThanhCong)
                {
                    MessageBox.Show("Thanh toán thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaoMoiDon();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}