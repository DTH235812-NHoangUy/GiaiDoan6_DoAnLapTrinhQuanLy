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
        public bool DaXoaHoaDon { get; private set; } = false;

        public List<DanhSachHoaDon_ChiTiet> DanhSachChiTietSauKhiSua { get; private set; }
            = new List<DanhSachHoaDon_ChiTiet>();

        public int KhachHangIDSauKhiSua { get; private set; } = 0;
        public string GhiChuSauKhiSua { get; private set; } = "";

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
            if (!moTuDatVe)
            {
                cboNhanVien.Enabled = false;
                cboKhachHang.Enabled = false;
                txtGhiChuHoaDon.Enabled = false;

                btnLuuHoaDon.Enabled = false;
                btnXoa.Enabled = !LaAdmin() && hoaDonChiTiet.Count > 0;
                return;
            }

            if (LaAdmin())
            {
                cboNhanVien.Enabled = false;
                cboKhachHang.Enabled = false;
                txtGhiChuHoaDon.Enabled = false;

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
            CaiDatNut(btnXoa, Properties.Resources.delete_24, "Xóa");
            CaiDatNut(btnLuuHoaDon, Properties.Resources.save_24, "Lưu hóa đơn");
            CaiDatNut(btnInHoaDon, Properties.Resources.save_24, "In hóa đơn...");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, moTuDatVe ? "Quay lại đặt vé" : "Thoát");
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
            bool coDuLieu = hoaDonChiTiet.Count > 0;

            if (!moTuDatVe)
            {
                btnLuuHoaDon.Enabled = false;
                btnXoa.Enabled = !LaAdmin() && coDuLieu;
                return;
            }

            if (LaAdmin())
            {
                btnLuuHoaDon.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }

            btnLuuHoaDon.Enabled = coDuLieu;
            btnXoa.Enabled = coDuLieu;
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
            BatTatChucNang();
            ApDungPhanQuyen();
            CapNhatTongTienTamTinh();
            dataGridView.Refresh();
        }

        private void XoaChiTietTamKhiMoTuDatVe()
        {
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

            if (MessageBox.Show("Bạn có chắc muốn xóa vé này khỏi danh sách?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
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

        private void XoaChiTietDaLuu()
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView.CurrentRow.Cells["ID"]?.Value == null)
            {
                MessageBox.Show("Không lấy được mã chi tiết hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int chiTietID = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            var chiTiet = context.HoaDon_ChiTiet
                .SingleOrDefault(x => x.ID == chiTietID && x.HoaDonID == id);

            if (chiTiet == null)
            {
                MessageBox.Show("Không tìm thấy vé trong chi tiết hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LaNhanVien())
            {
                bool hopLe = context.HoaDon
                    .AsNoTracking()
                    .Any(x => x.ID == id && x.NhanVienID == nhanVienIDDangNhap);

                if (!hopLe)
                {
                    MessageBox.Show("Bạn không có quyền xóa vé của hóa đơn này.",
                        "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa vé này khỏi hóa đơn không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                context.HoaDon_ChiTiet.Remove(chiTiet);
                context.SaveChanges();

                bool conChiTiet = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Any(x => x.HoaDonID == id);

                if (!conChiTiet)
                {
                    var hoaDon = context.HoaDon.SingleOrDefault(x => x.ID == id);
                    if (hoaDon != null)
                    {
                        context.HoaDon.Remove(hoaDon);
                        context.SaveChanges();
                    }

                    DaXoaHoaDon = true;

                    MessageBox.Show("Đã xóa vé cuối cùng. Hóa đơn đã được xóa luôn.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                TaiHoaDonCanSua();
                LamMoiSauThayDoiChiTiet();

                MessageBox.Show("Đã xóa vé khỏi hóa đơn thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa vé khỏi hóa đơn thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem chi tiết hóa đơn, không được xóa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (moTuDatVe)
                XoaChiTietTamKhiMoTuDatVe();
            else
                XoaChiTietDaLuu();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (!moTuDatVe)
            {
                MessageBox.Show("Hóa đơn đã lập chỉ được xem, không được lưu chỉnh sửa tại màn hình này.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                    MessageBox.Show("Có vé đã được bán bởi hóa đơn khác. Vui lòng tải lại dữ liệu.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    hd.GhiChu = string.IsNullOrWhiteSpace(txtGhiChuHoaDon.Text)
                        ? null
                        : txtGhiChuHoaDon.Text.Trim();

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
                        GhiChu = string.IsNullOrWhiteSpace(txtGhiChuHoaDon.Text)
                            ? null
                            : txtGhiChuHoaDon.Text.Trim()
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

                int tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);

                MessageBox.Show(
                    $"Đã lưu hóa đơn thành công!\nMã hóa đơn: {id}\nTổng tiền: {tongTien:N0} VNĐ",
                    "Hoàn tất",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu hóa đơn thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn gắn chức năng in hóa đơn sau nhé.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (moTuDatVe)
            {
                if (cboKhachHang.SelectedValue != null)
                    KhachHangIDSauKhiSua = Convert.ToInt32(cboKhachHang.SelectedValue);

                GhiChuSauKhiSua = txtGhiChuHoaDon.Text.Trim();
                DanhSachChiTietSauKhiSua = hoaDonChiTiet.ToList();

                DialogResult = DialogResult.OK;
                Close();
                return;
            }

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