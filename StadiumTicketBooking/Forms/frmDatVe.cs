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

        private class VeChonTam
        {
            public int VeID { get; set; }
            public string TenSuKien { get; set; } = string.Empty;
            public string SoGhe { get; set; } = string.Empty;
            public string TenKhuVuc { get; set; } = string.Empty;
            public int GiaVe { get; set; }
        }

        private readonly List<VeChonTam> gioVe = new List<VeChonTam>();

        public frmDatVe()
        {
            InitializeComponent();
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

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            TaiNhanVien();
            TaiKhachHang();
            TaiSuKien();
            DinhDangGrid();
            TaoMoiDon();
        }

        private void DinhDangGrid()
        {
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
            var dsNhanVien = context.NhanVien
                .Select(x => new
                {
                    x.ID,
                    x.HoVaTen
                })
                .ToList();

            cboNhanVien.DataSource = dsNhanVien;
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
        }

        private void TaiKhachHang()
        {
            var dsKhachHang = context.KhachHang
                .Select(x => new
                {
                    x.ID,
                    x.HoVaTen
                })
                .ToList();

            cboKhachHang.DataSource = dsKhachHang;
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.ValueMember = "ID";
        }

        private void TaiSuKien()
        {
            var dsSuKien = context.SuKien
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.TenSuKien + " - " + x.SanVanDong.TenSan
                })
                .ToList();

            cboSuKien.DataSource = dsSuKien;
            cboSuKien.DisplayMember = "TenHienThi";
            cboSuKien.ValueMember = "ID";
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

            TaiVeTrong();
            TaiGioVe();
            CapNhatTongTien();
        }

        private void TaiVeTrong()
        {
            dgvVeTrong.AutoGenerateColumns = false;

            int suKienId = LaySuKienIdDangChon();
            if (suKienId <= 0)
            {
                dgvVeTrong.DataSource = null;
                return;
            }

            var dsVeIdTrongGio = gioVe.Select(x => x.VeID).ToList();

            var listVeTrong = context.Ve
                .AsNoTracking()
                .Where(x => x.SuKienID == suKienId
                         && !string.IsNullOrWhiteSpace(x.TrangThai)
                         && x.TrangThai.Trim() == "Trống"
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
                .ToList();

            dgvVeTrong.DataSource = null;
            dgvVeTrong.DataSource = listVeTrong;

            DinhDangGrid();
        }

        private void TaiGioVe()
        {
            dgvVeDaChon.AutoGenerateColumns = false;

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
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNhanVien.Focus();
                return;
            }

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

            using var transaction = context.Database.BeginTransaction();
            try
            {
                HoaDon hoaDon = new HoaDon
                {
                    NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue),
                    KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue),
                    NgayLap = dtpNgayLap.Value,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };

                context.HoaDon.Add(hoaDon);
                context.SaveChanges();

                foreach (var item in gioVe)
                {
                    var ve = context.Ve.FirstOrDefault(x => x.ID == item.VeID);

                    if (ve == null)
                    {
                        throw new Exception($"Không tìm thấy vé ID = {item.VeID}.");
                    }

                    if (string.IsNullOrWhiteSpace(ve.TrangThai) || ve.TrangThai.Trim() != "Trống")
                    {
                        throw new Exception($"Vé {item.SoGhe} không còn ở trạng thái Trống.");
                    }

                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                    {
                        HoaDonID = hoaDon.ID,
                        VeID = item.VeID,
                        DonGiaBan = item.GiaVe
                    };

                    context.HoaDon_ChiTiet.Add(ct);

                    ve.TrangThai = "Đã bán";
                }

                context.SaveChanges();
                transaction.Commit();

                MessageBox.Show($"Thanh toán thành công! Mã hóa đơn: {hoaDon.ID}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaoMoiDon();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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