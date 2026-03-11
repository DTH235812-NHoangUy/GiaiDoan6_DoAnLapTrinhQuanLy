using StadiumTicketBooking.Data.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmVaiTro : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private int id = 0;

        public frmVaiTro()
        {
            InitializeComponent();
        }

        private void CaiDatNut(Krypton.Toolkit.KryptonButton btn, System.Drawing.Image icon, string text)
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
            txtVaiTro.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            dgvVaiTro.Enabled = !giaTri;

            txtID.ReadOnly = true;
        }

        private void XoaDuLieuNhap()
        {
            txtID.Text = string.Empty;
            txtVaiTro.Text = string.Empty;
        }

        private void TaiDuLieu()
        {
            dgvVaiTro.AutoGenerateColumns = false;

            var listVaiTro = context.VaiTro.ToList();
            BindingSource bindingSource = new BindingSource
            {
                DataSource = listVaiTro
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtVaiTro.DataBindings.Clear();
            txtVaiTro.DataBindings.Add("Text", bindingSource, "TenVaiTro", false, DataSourceUpdateMode.Never);

            dgvVaiTro.DataSource = null;
            dgvVaiTro.DataSource = bindingSource;
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            BatTatChucNang(false);
            XoaDuLieuNhap();
            TaiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            id = 0;
            BatTatChucNang(true);
            XoaDuLieuNhap();
            txtVaiTro.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvVaiTro.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvVaiTro.CurrentRow.Cells["colID"].Value?.ToString(), out id))
            {
                xuLyThem = false;
                BatTatChucNang(true);
                txtVaiTro.Focus();
            }
            else
            {
                MessageBox.Show("Không xác định được vai trò cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVaiTro.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvVaiTro.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được vai trò cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận xóa vai trò: {txtVaiTro.Text.Trim()}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                var vt = context.VaiTro.Find(idXoa);
                if (vt != null)
                {
                    context.VaiTro.Remove(vt);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa vai trò này vì đang có nhân viên sử dụng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenVaiTro = txtVaiTro.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenVaiTro))
            {
                MessageBox.Show("Vui lòng nhập tên vai trò!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVaiTro.Focus();
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    bool daTonTai = context.VaiTro.Any(x => x.TenVaiTro == tenVaiTro);
                    if (daTonTai)
                    {
                        MessageBox.Show("Tên vai trò này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtVaiTro.Focus();
                        return;
                    }

                    VaiTro vt = new VaiTro
                    {
                        TenVaiTro = tenVaiTro
                    };

                    context.VaiTro.Add(vt);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được vai trò cần sửa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungTen = context.VaiTro.Any(x => x.TenVaiTro == tenVaiTro && x.ID != idSua);
                    if (trungTen)
                    {
                        MessageBox.Show("Tên vai trò này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtVaiTro.Focus();
                        return;
                    }

                    var vt = context.VaiTro.Find(idSua);
                    if (vt != null)
                    {
                        vt.TenVaiTro = tenVaiTro;
                        context.VaiTro.Update(vt);
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