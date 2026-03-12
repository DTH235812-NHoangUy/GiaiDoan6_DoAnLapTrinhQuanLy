using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();

        public frmHoaDon_ChiTiet()
        {
            InitializeComponent();
        }

        public frmHoaDon_ChiTiet(int hoaDonId)
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
            CaiDatNut(btnTaiLai, Properties.Resources.import_24, "Tải lại");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            CauHinhLuoi();

            dgvChiTiet.SelectionChanged += dgvChiTiet_SelectionChanged;

            TaiDuLieu();
        }

        private void CauHinhLuoi()
        {
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TaiDuLieu()
        {
            try
            {
                var ds = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Select(x => new
                    {
                        HoaDonID = x.HoaDonID,
                        ChiTietID = x.ID,
                        TenSuKien = x.Ve.SuKien.TenSuKien,
                        TenSan = x.Ve.Ghe.KhuVuc.SanVanDong.TenSan,
                        ViTriGhe = x.Ve.Ghe.KhuVuc.TenKhuVuc + " - Ghế " + x.Ve.Ghe.SoGhe,
                        DonGiaBan = x.DonGiaBan,
                        ThanhTien = x.DonGiaBan
                    })
                    .OrderBy(x => x.HoaDonID)
                    .ThenBy(x => x.ChiTietID)
                    .ToList();

                var hienThi = ds
                    .Select((x, index) => new
                    {
                        STT = index + 1,
                        HoaDonID = x.HoaDonID,
                        TenSuKien = x.TenSuKien,
                        TenSan = x.TenSan,
                        ViTriGhe = x.ViTriGhe,
                        DonGiaBan = x.DonGiaBan,
                        ThanhTien = x.ThanhTien
                    })
                    .ToList();

                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = hienThi;

                txtHoaDonID.Text = "";
                txtTongTien.Text = "0";

                DinhDangCotTien();
                CapNhatThongTinTheoDongDangChon();

                if (hienThi.Count == 0)
                {
                    MessageBox.Show("Chưa có chi tiết hóa đơn nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được chi tiết hóa đơn.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatThongTinTheoDongDangChon()
        {
            if (dgvChiTiet.CurrentRow != null)
            {
                object maHoaDon = dgvChiTiet.CurrentRow.Cells["colHoaDonID"].Value;
                object thanhTien = dgvChiTiet.CurrentRow.Cells["colThanhTien"].Value;

                txtHoaDonID.Text = maHoaDon?.ToString() ?? "";

                if (thanhTien != null && decimal.TryParse(thanhTien.ToString(), out decimal tien))
                {
                    txtTongTien.Text = tien.ToString("N0");
                }
                else
                {
                    txtTongTien.Text = "0";
                }

                return;
            }

            txtHoaDonID.Text = "";
            txtTongTien.Text = "0";
        }

        private void dgvChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            CapNhatThongTinTheoDongDangChon();
        }

        private void DinhDangCotTien()
        {
            if (dgvChiTiet.Columns["colDonGiaBan"] != null)
            {
                dgvChiTiet.Columns["colDonGiaBan"].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["colDonGiaBan"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvChiTiet.Columns["colThanhTien"] != null)
            {
                dgvChiTiet.Columns["colThanhTien"].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["colThanhTien"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
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