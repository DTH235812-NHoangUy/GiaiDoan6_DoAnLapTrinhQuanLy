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
            CaiDatNut(btnLapHoaDon, Properties.Resources.add_24, "Lập hóa đơn mới...");
            CaiDatNut(btnInHoaDon, Properties.Resources.save_24, "In hóa đơn...");
            CaiDatNut(btnSua, Properties.Resources.edit_24, "Sửa...");
            CaiDatNut(btnXoa, Properties.Resources.delete_24, "Xóa");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnTimKiem, Properties.Resources.search_24, "Tìm kiếm...");
            CaiDatNut(btnXuat, Properties.Resources.export_24, "Xuất Excel...");
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            CauHinhDataGridView();
            TaiDanhSachHoaDon();
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
                var ds = context.HoaDon
                    .AsNoTracking()
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

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }

            TaiDanhSachHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!LayHoaDonDangChon())
                return;

            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }

            TaiDanhSachHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!LayHoaDonDangChon())
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này không?\nKhi xóa hóa đơn thì cũng xóa luôn chi tiết hóa đơn.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                var hoaDon = context.HoaDon
                    .Include(x => x.HoaDon_ChiTiet)
                    .FirstOrDefault(x => x.ID == id);

                if (hoaDon == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn cần xóa.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (hoaDon.HoaDon_ChiTiet.Any())
                    context.HoaDon_ChiTiet.RemoveRange(hoaDon.HoaDon_ChiTiet);

                context.HoaDon.Remove(hoaDon);
                context.SaveChanges();

                MessageBox.Show("Xóa hóa đơn thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDanhSachHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa hóa đơn thất bại.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (!LayHoaDonDangChon())
                return;

            MessageBox.Show("Bạn gắn chức năng in hóa đơn sau nhé.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn gắn chức năng tìm kiếm sau nhé.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int hoaDonId = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["ID"].Value);

                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(hoaDonId))
                {
                    chiTiet.ShowDialog();
                }

                TaiDanhSachHoaDon();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}