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

        public frmHoaDon()
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
            CaiDatNut(btnLoc, Properties.Resources.search_24, "Lọc");
            CaiDatNut(btnTaiLai, Properties.Resources.import_24, "Tải lại");
            CaiDatNut(btnXemChiTiet, Properties.Resources.add_24, "Xem chi tiết");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            CauHinhLuoi();

            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today;

            TaiDuLieu();
        }

        private void CauHinhLuoi()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TaiDuLieu()
        {
            try
            {
                var ds = context.HoaDon
                    .AsNoTracking()
                    .Select(x => new DanhSachHoaDon
                    {
                        ID = x.ID,
                        HoVaTenNhanVien = x.NhanVien.HoVaTen,
                        HoVaTenKhachHang = x.KhachHang.HoVaTen,
                        NgayLap = x.NgayLap,
                        GhiChu = x.GhiChu,
                        TongTien = x.HoaDon_ChiTiet.Sum(ct => (double)ct.DonGiaBan)
                    })
                    .OrderByDescending(x => x.ID)
                    .ToList();

                dgvHoaDon.DataSource = null;
                dgvHoaDon.DataSource = ds;

                DinhDangCotNgay();
                DinhDangCotTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách hóa đơn.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LocDuLieu()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

                var ds = context.HoaDon
                    .AsNoTracking()
                    .Where(x => x.NgayLap >= tuNgay && x.NgayLap <= denNgay)
                    .Select(x => new DanhSachHoaDon
                    {
                        ID = x.ID,
                        HoVaTenNhanVien = x.NhanVien.HoVaTen,
                        HoVaTenKhachHang = x.KhachHang.HoVaTen,
                        NgayLap = x.NgayLap,
                        GhiChu = x.GhiChu,
                        TongTien = x.HoaDon_ChiTiet.Sum(ct => (double)ct.DonGiaBan)
                    })
                    .OrderByDescending(x => x.ID)
                    .ToList();

                dgvHoaDon.DataSource = null;
                dgvHoaDon.DataSource = ds;

                DinhDangCotNgay();
                DinhDangCotTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lọc được dữ liệu.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DinhDangCotNgay()
        {
            if (dgvHoaDon.Columns["colNgayLap"] != null)
            {
                dgvHoaDon.Columns["colNgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
        }

        private void DinhDangCotTien()
        {
            if (dgvHoaDon.Columns["colTongTien"] != null)
            {
                dgvHoaDon.Columns["colTongTien"].DefaultCellStyle.Format = "N0";
                dgvHoaDon.Columns["colTongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LocDuLieu();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today;
            TaiDuLieu();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvHoaDon.CurrentRow.Cells["colID"].Value?.ToString(), out int selectedHoaDonId))
            {
                MessageBox.Show("Không xác định được hóa đơn!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(selectedHoaDonId))
            {
                frm.ShowDialog();
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