using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        private int id = 0;
        private int nhanVienIDDangNhap = 0;
        private string vaiTro = "";

        private int khachHangIDTam = 0;
        private string ghiChuTam = "";
        private bool moTuDatVe = false;

        private BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        public bool DaLuuThanhCong { get; private set; } = false;

        public frmHoaDon_ChiTiet() : this(0, 0, "")
        {
        }

        public frmHoaDon_ChiTiet(string vaiTro) : this(0, 0, vaiTro)
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon) : this(maHoaDon, 0, "")
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon, string vaiTro) : this(maHoaDon, 0, vaiTro)
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon, int nhanVienID, string vaiTro)
        {
            InitializeComponent();
            id = maHoaDon;
            nhanVienIDDangNhap = nhanVienID;
            this.vaiTro = vaiTro ?? "";
        }

        public frmHoaDon_ChiTiet(
            int nhanVienID,
            string vaiTro,
            int khachHangID,
            string ghiChu,
            List<DanhSachHoaDon_ChiTiet> dsChiTietTam)
            : this(0, nhanVienID, vaiTro)
        {
            moTuDatVe = true;
            khachHangIDTam = khachHangID;
            ghiChuTam = ghiChu ?? "";
            hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(
                dsChiTietTam ?? new List<DanhSachHoaDon_ChiTiet>());
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

        private int LayNhanVienLapHoaDon()
        {
            if (LaNhanVien())
                return nhanVienIDDangNhap;

            if (cboNhanVien.SelectedValue == null)
                return 0;

            return Convert.ToInt32(cboNhanVien.SelectedValue);
        }

        private void ApDungPhanQuyen()
        {
            if (LaAdmin())
            {
                cboNhanVien.Enabled = false;
                cboKhachHang.Enabled = false;
                cboVe.Enabled = false;
                numDonGiaBan.Enabled = false;
                numSoLuongBan.Enabled = false;
                txtGhiChuHoaDon.Enabled = false;

                btnXacNhanBan.Enabled = false;
                btnXoa.Enabled = false;
                btnLuuHoaDon.Enabled = false;
            }
            else if (LaNhanVien())
            {
                cboNhanVien.Enabled = false;
            }
        }

        private void CaiDatNut(KryptonButton btn, Image icon, string text)
        {
            btn.Values.Image = icon;
            btn.Values.Text = text;
        }

        private void CaiDatIconNut()
        {
            CaiDatNut(btnXacNhanBan, Properties.Resources.add_24, "Xác nhận bán");
            CaiDatNut(btnXoa, Properties.Resources.delete_24, "Xóa");
            CaiDatNut(btnLuuHoaDon, Properties.Resources.save_24, "Lưu hóa đơn");
            CaiDatNut(btnInHoaDon, Properties.Resources.save_24, "In hóa đơn...");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            CauHinhDataGridView();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = hoaDonChiTiet;

            TaiDanhMucComboBox();

            if (id != 0)
            {
                TaiHoaDonCanSua();
            }
            else if (moTuDatVe)
            {
                DoDuLieuTamTuDatVe();
            }

            LayVeVaoComboBox();
            BatTatChucNang();
            ApDungPhanQuyen();
            CapNhatTongTienTamTinh();
        }

        private void TaiDanhMucComboBox()
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
        }

        private void DoDuLieuTamTuDatVe()
        {
            if (khachHangIDTam > 0)
                cboKhachHang.SelectedValue = khachHangIDTam;

            txtGhiChuHoaDon.Text = ghiChuTam ?? "";
            dataGridView.DataSource = hoaDonChiTiet;
        }

        private void CauHinhDataGridView()
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;

            if (dataGridView.Columns["DonGiaBan"] != null)
            {
                dataGridView.Columns["DonGiaBan"].DefaultCellStyle.Format = "N0";
                dataGridView.Columns["DonGiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridView.Columns["SoLuongBan"] != null)
            {
                dataGridView.Columns["SoLuongBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridView.Columns["ThanhTien"] != null)
            {
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView.Columns["ThanhTien"].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void LayNhanVienVaoComboBox()
        {
            if (LaNhanVien())
            {
                var dsNhanVien = context.NhanVien
                    .AsNoTracking()
                    .Where(x => x.ID == nhanVienIDDangNhap)
                    .OrderBy(x => x.HoVaTen)
                    .ToList();

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.ValueMember = "ID";
                cboNhanVien.DisplayMember = "HoVaTen";

                if (dsNhanVien.Count > 0)
                    cboNhanVien.SelectedValue = nhanVienIDDangNhap;
                else
                    cboNhanVien.SelectedIndex = -1;
            }
            else
            {
                var dsNhanVien = context.NhanVien
                    .AsNoTracking()
                    .OrderBy(x => x.HoVaTen)
                    .ToList();

                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.ValueMember = "ID";
                cboNhanVien.DisplayMember = "HoVaTen";

                if (id == 0)
                    cboNhanVien.SelectedIndex = -1;
            }
        }

        private void LayKhachHangVaoComboBox()
        {
            var dsKhachHang = context.KhachHang
                .AsNoTracking()
                .OrderBy(x => x.HoVaTen)
                .ToList();

            cboKhachHang.DataSource = dsKhachHang;
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";

            if (id == 0 && !moTuDatVe)
                cboKhachHang.SelectedIndex = -1;
        }

        private void LayVeVaoComboBox()
        {
            var veDaBanCuaHoaDonKhac = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Where(x => x.HoaDonID != id)
                .Select(x => x.VeID)
                .ToList();

            var veDangCoTrongForm = hoaDonChiTiet.Select(x => x.VeID).ToList();

            var dsVe = context.Ve
                .AsNoTracking()
                .Where(v => !veDaBanCuaHoaDonKhac.Contains(v.ID)
                         && !veDangCoTrongForm.Contains(v.ID))
                .Select(v => new
                {
                    ID = v.ID,
                    TenVe = v.SuKien.TenSuKien + " | "
                          + v.Ghe.KhuVuc.SanVanDong.TenSan + " | "
                          + v.Ghe.KhuVuc.TenKhuVuc + " - Ghế " + v.Ghe.SoGhe
                })
                .OrderBy(x => x.TenVe)
                .ToList();

            cboVe.DataSource = dsVe;
            cboVe.ValueMember = "ID";
            cboVe.DisplayMember = "TenVe";
            cboVe.SelectedIndex = -1;
        }

        private void TaiHoaDonCanSua()
        {
            var hoaDon = context.HoaDon
                .AsNoTracking()
                .SingleOrDefault(r => r.ID == id);

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (LaNhanVien() && hoaDon.NhanVienID != nhanVienIDDangNhap)
            {
                MessageBox.Show("Bạn không có quyền xem hóa đơn này.", "Phân quyền",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            cboNhanVien.SelectedValue = hoaDon.NhanVienID;
            cboKhachHang.SelectedValue = hoaDon.KhachHangID;
            txtGhiChuHoaDon.Text = hoaDon.GhiChu ?? "";

            var dsChiTiet = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Where(r => r.HoaDonID == id)
                .Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    VeID = r.VeID,
                    TenSuKien = r.Ve.SuKien.TenSuKien,
                    TenSan = r.Ve.Ghe.KhuVuc.SanVanDong.TenSan,
                    ViTriGhe = r.Ve.Ghe.KhuVuc.TenKhuVuc + " - Ghế " + r.Ve.Ghe.SoGhe,
                    SoLuongBan = 1,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = r.DonGiaBan
                })
                .ToList();

            hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(dsChiTiet);
            dataGridView.DataSource = hoaDonChiTiet;
        }

        private void BatTatChucNang()
        {
            if (LaAdmin())
            {
                btnLuuHoaDon.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }

            bool coDuLieu = hoaDonChiTiet.Count > 0;
            btnLuuHoaDon.Enabled = coDuLieu;
            btnXoa.Enabled = coDuLieu;

            if (id == 0 && !coDuLieu)
            {
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }
        }

        private void CapNhatTongTienTamTinh()
        {
            int tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

            if (id == 0)
                Text = $"Hóa đơn chi tiết - Tạm tính: {tongTien:N0}";
            else
                Text = $"Hóa đơn chi tiết - Tổng tiền: {tongTien:N0}";
        }

        private void LamMoiSauThayDoiChiTiet()
        {
            LayVeVaoComboBox();
            BatTatChucNang();
            CapNhatTongTienTamTinh();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem chi tiết hóa đơn, không được bán vé.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboVe.SelectedIndex < 0 || cboVe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vé.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numDonGiaBan.Value <= 0)
            {
                MessageBox.Show("Đơn giá bán phải lớn hơn 0.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maVe = Convert.ToInt32(cboVe.SelectedValue);

            bool daBanTrongCSDL = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Any(x => x.VeID == maVe && x.HoaDonID != id);

            if (daBanTrongCSDL)
            {
                MessageBox.Show("Vé này đã được bán, vui lòng chọn vé khác.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LayVeVaoComboBox();
                return;
            }

            if (hoaDonChiTiet.Any(x => x.VeID == maVe))
            {
                MessageBox.Show("Vé này đã có trong hóa đơn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ve = context.Ve
                .AsNoTracking()
                .Where(v => v.ID == maVe)
                .Select(v => new
                {
                    v.ID,
                    TenSuKien = v.SuKien.TenSuKien,
                    TenSan = v.Ghe.KhuVuc.SanVanDong.TenSan,
                    ViTriGhe = v.Ghe.KhuVuc.TenKhuVuc + " - Ghế " + v.Ghe.SoGhe
                })
                .FirstOrDefault();

            if (ve == null)
            {
                MessageBox.Show("Không tìm thấy vé.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hoaDonChiTiet.Add(new DanhSachHoaDon_ChiTiet
            {
                ID = 0,
                HoaDonID = id,
                VeID = maVe,
                TenSuKien = ve.TenSuKien,
                TenSan = ve.TenSan,
                ViTriGhe = ve.ViTriGhe,
                SoLuongBan = 1,
                DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                ThanhTien = Convert.ToInt32(numDonGiaBan.Value)
            });

            numSoLuongBan.Value = 1;
            numDonGiaBan.Value = 0;

            LamMoiSauThayDoiChiTiet();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem chi tiết hóa đơn, không được xóa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView.CurrentRow.Cells["VeID"]?.Value == null)
            {
                MessageBox.Show("Không lấy được mã vé cần xóa.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maVe = Convert.ToInt32(dataGridView.CurrentRow.Cells["VeID"].Value);
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.VeID == maVe);

            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
                LamMoiSauThayDoiChiTiet();
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem chi tiết hóa đơn, không được lưu.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboKhachHang.SelectedIndex < 0 || cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có vé nào.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nhanVienLapHoaDon = LayNhanVienLapHoaDon();
            if (nhanVienLapHoaDon <= 0)
            {
                MessageBox.Show("Không xác định được nhân viên lập hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var dsVeDangLuu = hoaDonChiTiet.Select(x => x.VeID).ToList();

                bool coVeBiTrung = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Any(x => dsVeDangLuu.Contains(x.VeID) && x.HoaDonID != id);

                if (coVeBiTrung)
                {
                    MessageBox.Show("Có vé đã được bán bởi hóa đơn khác. Vui lòng tải lại danh sách vé.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LayVeVaoComboBox();
                    return;
                }

                if (id != 0)
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn cần lưu.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (LaNhanVien() && hd.NhanVienID != nhanVienIDDangNhap)
                    {
                        MessageBox.Show("Bạn không có quyền sửa hóa đơn này.",
                            "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    hd.NhanVienID = nhanVienLapHoaDon;
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    hd.GhiChu = string.IsNullOrWhiteSpace(txtGhiChuHoaDon.Text) ? null : txtGhiChuHoaDon.Text.Trim();

                    var dsCu = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                    context.HoaDon_ChiTiet.RemoveRange(dsCu);

                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                        {
                            HoaDonID = id,
                            VeID = item.VeID,
                            DonGiaBan = item.DonGiaBan
                        });
                    }

                    context.SaveChanges();
                }
                else
                {
                    HoaDon hd = new HoaDon
                    {
                        NhanVienID = nhanVienLapHoaDon,
                        KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue),
                        NgayLap = DateTime.Now,
                        GhiChu = string.IsNullOrWhiteSpace(txtGhiChuHoaDon.Text) ? null : txtGhiChuHoaDon.Text.Trim()
                    };

                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                        {
                            HoaDonID = hd.ID,
                            VeID = item.VeID,
                            DonGiaBan = item.DonGiaBan
                        });
                    }

                    context.SaveChanges();
                    id = hd.ID;
                }

                DaLuuThanhCong = true;

                MessageBox.Show("Đã lưu thành công!", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDanhMucComboBox();
                LayVeVaoComboBox();
                BatTatChucNang();
                CapNhatTongTienTamTinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu hóa đơn thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboVe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            numSoLuongBan.Value = 1;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn gắn chức năng in hóa đơn sau nhé.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}