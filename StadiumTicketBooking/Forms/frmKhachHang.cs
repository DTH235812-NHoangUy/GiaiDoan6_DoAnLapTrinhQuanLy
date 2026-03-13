using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmKhachHang : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private int currentId = 0;
        private string vaiTro = "";

        public frmKhachHang()
        {
            InitializeComponent();
        }

        public frmKhachHang(string vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro ?? "";
        }

        private bool LaAdmin()
        {
            return vaiTro.Trim().ToLower() == "admin";
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

            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            dgvKhachHang.Enabled = !giaTri;

            txtID.ReadOnly = true;
        }

        private void ApDungPhanQuyen()
        {
            if (LaAdmin())
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                txtHoVaTen.Enabled = false;
                txtDienThoai.Enabled = false;
                txtDiaChi.Enabled = false;
            }
        }

        private void XoaDuLieuNhap()
        {
            txtID.Text = string.Empty;
            txtHoVaTen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        private void TaiDuLieu()
        {
            dgvKhachHang.AutoGenerateColumns = false;

            var listKhachHang = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listKhachHang
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = bindingSource;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            BatTatChucNang(false);
            TaiDuLieu();
            ApDungPhanQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được thêm.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            xuLyThem = true;
            currentId = 0;
            BatTatChucNang(true);
            XoaDuLieuNhap();
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được sửa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvKhachHang.CurrentRow.Cells["colID"].Value?.ToString(), out currentId))
            {
                xuLyThem = false;
                BatTatChucNang(true);
                txtHoVaTen.Focus();
            }
            else
            {
                MessageBox.Show("Không xác định được khách hàng cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được xóa.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvKhachHang.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được khách hàng cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenKhachHang = dgvKhachHang.CurrentRow.Cells["colHoVaTen"].Value?.ToString() ?? "";

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận xóa khách hàng: {tenKhachHang}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                var kh = context.KhachHang.Find(idXoa);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                    ApDungPhanQuyen();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đang có hóa đơn liên quan!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (LaAdmin())
            {
                MessageBox.Show("Admin chỉ được xem khách hàng, không được lưu.",
                    "Phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string hoVaTen = txtHoVaTen.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoVaTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    bool daTonTai = context.KhachHang.Any(x =>
                        x.HoVaTen == hoVaTen &&
                        x.DienThoai == dienThoai);

                    if (daTonTai)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHoVaTen.Focus();
                        return;
                    }

                    KhachHang kh = new KhachHang
                    {
                        HoVaTen = hoVaTen,
                        DienThoai = string.IsNullOrWhiteSpace(dienThoai) ? null : dienThoai,
                        DiaChi = string.IsNullOrWhiteSpace(diaChi) ? null : diaChi
                    };

                    context.KhachHang.Add(kh);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được khách hàng cần sửa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungDuLieu = context.KhachHang.Any(x =>
                        x.HoVaTen == hoVaTen &&
                        x.DienThoai == dienThoai &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Khách hàng này đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtHoVaTen.Focus();
                        return;
                    }

                    var kh = context.KhachHang.Find(idSua);
                    if (kh != null)
                    {
                        kh.HoVaTen = hoVaTen;
                        kh.DienThoai = string.IsNullOrWhiteSpace(dienThoai) ? null : dienThoai;
                        kh.DiaChi = string.IsNullOrWhiteSpace(diaChi) ? null : diaChi;

                        context.KhachHang.Update(kh);
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TaiDuLieu();
                BatTatChucNang(false);
                ApDungPhanQuyen();
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
            ApDungPhanQuyen();
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