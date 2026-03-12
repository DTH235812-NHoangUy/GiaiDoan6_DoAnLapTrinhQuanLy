using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private int id;
        private BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        public frmHoaDon_ChiTiet() : this(0)
        {
        }

        public frmHoaDon_ChiTiet(int maHoaDon)
        {
            InitializeComponent();
            id = maHoaDon;
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
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = hoaDonChiTiet;

            if (id != 0)
                TaiHoaDonCanSua();

            LayVeVaoComboBox();
            BatTatChucNang();
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
            cboNhanVien.DataSource = context.NhanVien
                .AsNoTracking()
                .OrderBy(x => x.HoVaTen)
                .ToList();

            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.SelectedIndex = -1;
        }

        private void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang
                .AsNoTracking()
                .OrderBy(x => x.HoVaTen)
                .ToList();

            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.SelectedIndex = -1;
        }

        // Chỉ lấy vé chưa bán.
        // Nếu đang sửa hóa đơn thì vẫn cho hiện các vé đang thuộc chính hóa đơn đó.
        private void LayVeVaoComboBox()
        {
            var veDaBanCuaHoaDonKhac = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Where(x => x.HoaDonID != id)
                .Select(x => x.VeID)
                .ToList();

            var dsVe = context.Ve
                .AsNoTracking()
                .Where(v => !veDaBanCuaHoaDonKhac.Contains(v.ID))
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
                return;
            }

            cboNhanVien.SelectedValue = hoaDon.NhanVienID;
            cboKhachHang.SelectedValue = hoaDon.KhachHangID;
            txtGhiChuHoaDon.Text = hoaDon.GhiChu ?? "";

            var ct = context.HoaDon_ChiTiet
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

            hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            dataGridView.DataSource = hoaDonChiTiet;
        }

        private void BatTatChucNang()
        {
            btnLuuHoaDon.Enabled = hoaDonChiTiet.Count > 0;
            btnXoa.Enabled = hoaDonChiTiet.Count > 0;

            if (id == 0 && hoaDonChiTiet.Count == 0)
            {
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }
        }

        private void CapNhatTongTienTamTinh()
        {
            int tongTien = hoaDonChiTiet.Sum(x => x.ThanhTien);
            this.Text = $"Hóa đơn chi tiết - Tạm tính: {tongTien:N0}";
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (cboVe.SelectedIndex < 0)
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

            // Chặn vé đã bán ở hóa đơn khác
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

            // Chặn trùng trong hóa đơn đang lập
            var daTonTai = hoaDonChiTiet.FirstOrDefault(x => x.VeID == maVe);
            if (daTonTai != null)
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

            DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
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
            };

            hoaDonChiTiet.Add(ct);

            // Làm mới danh sách vé để vé vừa chọn không hiện lại nữa
            LayVeVaoComboBox();
            numSoLuongBan.Value = 1;
            numDonGiaBan.Value = 0;

            BatTatChucNang();
            CapNhatTongTienTamTinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maVe = Convert.ToInt32(dataGridView.CurrentRow.Cells["VeID"].Value);
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.VeID == maVe);

            if (chiTiet != null)
                hoaDonChiTiet.Remove(chiTiet);

            LayVeVaoComboBox();
            BatTatChucNang();
            CapNhatTongTienTamTinh();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboKhachHang.SelectedIndex < 0)
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

            try
            {
                // Kiểm tra lại lần cuối trước khi lưu
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
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                        hd.GhiChu = txtGhiChuHoaDon.Text;
                        context.HoaDon.Update(hd);

                        var old = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDon_ChiTiet.RemoveRange(old);

                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                            {
                                HoaDonID = id,
                                VeID = item.VeID,
                                DonGiaBan = item.DonGiaBan
                            };
                            context.HoaDon_ChiTiet.Add(ct);
                        }

                        context.SaveChanges();
                    }
                }
                else
                {
                    HoaDon hd = new HoaDon
                    {
                        NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue),
                        KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue),
                        NgayLap = DateTime.Now,
                        GhiChu = txtGhiChuHoaDon.Text
                    };

                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                        {
                            HoaDonID = hd.ID,
                            VeID = item.VeID,
                            DonGiaBan = item.DonGiaBan
                        };
                        context.HoaDon_ChiTiet.Add(ct);
                    }

                    context.SaveChanges();
                    id = hd.ID;
                }

                MessageBox.Show("Đã lưu thành công!", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            // Nếu sau này bảng Ve có giá mặc định thì gán numDonGiaBan ở đây.
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

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}