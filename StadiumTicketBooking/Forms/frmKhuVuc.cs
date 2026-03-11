using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmKhuVuc : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private int currentId = 0;

        public frmKhuVuc()
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
            CaiDatNut(btnThem, Properties.Resources.add_24, "Thêm");
            CaiDatNut(btnSua, Properties.Resources.edit_24, "Sửa");
            CaiDatNut(btnXoa, Properties.Resources.delete_24, "Xóa");
            CaiDatNut(btnLuu, Properties.Resources.save_24, "Lưu");
            CaiDatNut(btnHuy, Properties.Resources.cancel_24, "Hủy");
            CaiDatNut(btnThoat, Properties.Resources.exit_24, "Thoát");
            CaiDatNut(btnTimKiem, Properties.Resources.search_24, "Tìm kiếm");
            CaiDatNut(btnNhap, Properties.Resources.import_24, "Nhập");
            CaiDatNut(btnXuat, Properties.Resources.export_24, "Xuất");
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            txtTenKhuVuc.Enabled = giaTri;
            txtHeSoGia.Enabled = giaTri;
            cboSanVanDong.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            dgvKhuVuc.Enabled = !giaTri;

            txtID.ReadOnly = true;
        }

        private void XoaDuLieuNhap()
        {
            txtID.Text = string.Empty;
            txtTenKhuVuc.Text = string.Empty;
            txtHeSoGia.Text = string.Empty;

            if (cboSanVanDong.Items.Count > 0)
                cboSanVanDong.SelectedIndex = 0;
        }

        private void TaiDanhSachSanVanDong()
        {
            cboSanVanDong.DataSource = context.SanVanDong.ToList();
            cboSanVanDong.DisplayMember = "TenSan";
            cboSanVanDong.ValueMember = "ID";
        }

        private void TaiDuLieu()
        {
            dgvKhuVuc.AutoGenerateColumns = false;

            var listKhuVuc = context.KhuVuc
                .Select(x => new
                {
                    x.ID,
                    x.TenKhuVuc,
                    x.HeSoGia,
                    x.SanVanDongID,
                    TenSan = x.SanVanDong.TenSan
                })
                .ToList();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listKhuVuc
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtTenKhuVuc.DataBindings.Clear();
            txtTenKhuVuc.DataBindings.Add("Text", bindingSource, "TenKhuVuc", false, DataSourceUpdateMode.Never);

            txtHeSoGia.DataBindings.Clear();
            txtHeSoGia.DataBindings.Add("Text", bindingSource, "HeSoGia", false, DataSourceUpdateMode.Never);

            cboSanVanDong.DataBindings.Clear();
            cboSanVanDong.DataBindings.Add("SelectedValue", bindingSource, "SanVanDongID", false, DataSourceUpdateMode.Never);

            dgvKhuVuc.DataSource = null;
            dgvKhuVuc.DataSource = bindingSource;
        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            TaiDanhSachSanVanDong();
            BatTatChucNang(false);
            TaiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            currentId = 0;
            BatTatChucNang(true);
            XoaDuLieuNhap();
            txtTenKhuVuc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhuVuc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khu vực cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvKhuVuc.CurrentRow.Cells["colID"].Value?.ToString(), out currentId))
            {
                xuLyThem = false;
                BatTatChucNang(true);
                txtTenKhuVuc.Focus();
            }
            else
            {
                MessageBox.Show("Không xác định được khu vực cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhuVuc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khu vực cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvKhuVuc.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được khu vực cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenKhuVuc = dgvKhuVuc.CurrentRow.Cells["colTenKhuVuc"].Value?.ToString() ?? "";

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận xóa khu vực: {tenKhuVuc}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                var kv = context.KhuVuc.Find(idXoa);
                if (kv != null)
                {
                    context.KhuVuc.Remove(kv);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa khu vực này vì đang có ghế hoặc dữ liệu liên quan!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKhuVuc = txtTenKhuVuc.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenKhuVuc))
            {
                MessageBox.Show("Vui lòng nhập tên khu vực!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKhuVuc.Focus();
                return;
            }

            if (!double.TryParse(txtHeSoGia.Text.Trim(), out double heSoGia) || heSoGia <= 0)
            {
                MessageBox.Show("Hệ số giá không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeSoGia.Focus();
                return;
            }

            if (cboSanVanDong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sân vận động!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSanVanDong.Focus();
                return;
            }

            int sanVanDongId = Convert.ToInt32(cboSanVanDong.SelectedValue);

            try
            {
                if (xuLyThem)
                {
                    bool daTonTai = context.KhuVuc.Any(x =>
                        x.TenKhuVuc == tenKhuVuc &&
                        x.SanVanDongID == sanVanDongId);

                    if (daTonTai)
                    {
                        MessageBox.Show("Khu vực này đã tồn tại trong sân vận động đã chọn!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenKhuVuc.Focus();
                        return;
                    }

                    KhuVuc kv = new KhuVuc
                    {
                        TenKhuVuc = tenKhuVuc,
                        HeSoGia = heSoGia,
                        SanVanDongID = sanVanDongId
                    };

                    context.KhuVuc.Add(kv);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được khu vực cần sửa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungDuLieu = context.KhuVuc.Any(x =>
                        x.TenKhuVuc == tenKhuVuc &&
                        x.SanVanDongID == sanVanDongId &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Khu vực này đã tồn tại trong sân vận động đã chọn!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenKhuVuc.Focus();
                        return;
                    }

                    var kv = context.KhuVuc.Find(idSua);
                    if (kv != null)
                    {
                        kv.TenKhuVuc = tenKhuVuc;
                        kv.HeSoGia = heSoGia;
                        kv.SanVanDongID = sanVanDongId;
                        context.KhuVuc.Update(kv);
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDuLieu();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
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