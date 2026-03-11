using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmGhe : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private int currentId = 0;

        public frmGhe()
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

            txtSoGhe.Enabled = giaTri;
            cboKhuVuc.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            dgvGhe.Enabled = !giaTri;

            txtID.ReadOnly = true;
        }

        private void XoaDuLieuNhap()
        {
            txtID.Text = string.Empty;
            txtSoGhe.Text = string.Empty;

            if (cboKhuVuc.Items.Count > 0)
                cboKhuVuc.SelectedIndex = 0;
        }

        private void TaiDanhSachKhuVuc()
        {
            var dsKhuVuc = context.KhuVuc
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.TenKhuVuc + " - " + x.SanVanDong.TenSan
                })
                .ToList();

            cboKhuVuc.DataSource = dsKhuVuc;
            cboKhuVuc.DisplayMember = "TenHienThi";
            cboKhuVuc.ValueMember = "ID";
        }

        private void TaiDuLieu()
        {
            dgvGhe.AutoGenerateColumns = false;

            var listGhe = context.Ghe
                .Select(x => new
                {
                    x.ID,
                    x.SoGhe,
                    x.KhuVucID,
                    TenKhuVuc = x.KhuVuc.TenKhuVuc,
                    TenSan = x.KhuVuc.SanVanDong.TenSan
                })
                .ToList();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listGhe
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtSoGhe.DataBindings.Clear();
            txtSoGhe.DataBindings.Add("Text", bindingSource, "SoGhe", false, DataSourceUpdateMode.Never);

            cboKhuVuc.DataBindings.Clear();
            cboKhuVuc.DataBindings.Add("SelectedValue", bindingSource, "KhuVucID", false, DataSourceUpdateMode.Never);

            dgvGhe.DataSource = null;
            dgvGhe.DataSource = bindingSource;
        }

        private void frmGhe_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            TaiDanhSachKhuVuc();
            BatTatChucNang(false);
            TaiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            currentId = 0;
            BatTatChucNang(true);
            XoaDuLieuNhap();
            txtSoGhe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGhe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn ghế cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvGhe.CurrentRow.Cells["colID"].Value?.ToString(), out currentId))
            {
                xuLyThem = false;
                BatTatChucNang(true);
                txtSoGhe.Focus();
            }
            else
            {
                MessageBox.Show("Không xác định được ghế cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGhe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn ghế cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvGhe.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được ghế cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string soGhe = dgvGhe.CurrentRow.Cells["colSoGhe"].Value?.ToString() ?? "";

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận xóa ghế: {soGhe}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                var ghe = context.Ghe.Find(idXoa);
                if (ghe != null)
                {
                    context.Ghe.Remove(ghe);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa ghế này vì đang có dữ liệu liên quan!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string soGhe = txtSoGhe.Text.Trim();

            if (string.IsNullOrWhiteSpace(soGhe))
            {
                MessageBox.Show("Vui lòng nhập số ghế!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoGhe.Focus();
                return;
            }

            if (cboKhuVuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khu vực!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboKhuVuc.Focus();
                return;
            }

            int khuVucId = Convert.ToInt32(cboKhuVuc.SelectedValue);

            try
            {
                if (xuLyThem)
                {
                    bool daTonTai = context.Ghe.Any(x =>
                        x.SoGhe == soGhe &&
                        x.KhuVucID == khuVucId);

                    if (daTonTai)
                    {
                        MessageBox.Show("Ghế này đã tồn tại trong khu vực đã chọn!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoGhe.Focus();
                        return;
                    }

                    Ghe ghe = new Ghe
                    {
                        SoGhe = soGhe,
                        KhuVucID = khuVucId
                    };

                    context.Ghe.Add(ghe);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được ghế cần sửa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungDuLieu = context.Ghe.Any(x =>
                        x.SoGhe == soGhe &&
                        x.KhuVucID == khuVucId &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Ghế này đã tồn tại trong khu vực đã chọn!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoGhe.Focus();
                        return;
                    }

                    var ghe = context.Ghe.Find(idSua);
                    if (ghe != null)
                    {
                        ghe.SoGhe = soGhe;
                        ghe.KhuVucID = khuVucId;
                        context.Ghe.Update(ghe);
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