using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmVaiTro :  Form
    {
        StadiumDbContext context = new StadiumDbContext();
        bool xuLyThem = false;
        int id; // Lưu ID khi sửa/xóa

        public frmVaiTro()
        {
            InitializeComponent();
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
            dgvVaiTro.Enabled = !giaTri;

            // ID luôn khóa vì là khóa tự tăng
            txtID.ReadOnly = true;
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvVaiTro.AutoGenerateColumns = false;

            // Truy vấn dữ liệu từ DB
            var listVaiTro = context.VaiTro.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listVaiTro;

            // Fix lỗi Binding: Phải dùng đúng tên thuộc tính trong Model (ID, TenVaiTro)
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtVaiTro.DataBindings.Clear();
            txtVaiTro.DataBindings.Add("Text", bindingSource, "TenVaiTro", false, DataSourceUpdateMode.Never);

            dgvVaiTro.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtID.Clear();
            txtVaiTro.Clear();
            txtVaiTro.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvVaiTro.CurrentRow != null)
            {
                // Ép thành số (sa) an toàn từ cột colID (theo ảnh bạn chụp)
                if (int.TryParse(dgvVaiTro.CurrentRow.Cells["colID"].Value?.ToString(), out id))
                {
                    xuLyThem = false;
                    BatTatChucNang(true);
                    txtVaiTro.Focus();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVaiTro.CurrentRow == null) return;

            // Ép thành số (sa) để định danh chính xác bản ghi cần xóa
            if (int.TryParse(dgvVaiTro.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                if (MessageBox.Show($"Xác nhận xóa vai trò: {txtVaiTro.Text}?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var vt = context.VaiTro.Find(idXoa);
                        if (vt != null)
                        {
                            context.VaiTro.Remove(vt);
                            context.SaveChanges();
                            frmVaiTro_Load(sender, e);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa vai trò này vì đang có nhân viên sử dụng!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra txtVaiTro
            if (string.IsNullOrWhiteSpace(txtVaiTro.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVaiTro.Focus();
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    // Chống trùng tên vai trò
                    if (context.VaiTro.Any(x => x.TenVaiTro == txtVaiTro.Text.Trim()))
                    {
                        MessageBox.Show("Tên vai trò này đã tồn tại!");
                        return;
                    }

                    VaiTro vt = new VaiTro { TenVaiTro = txtVaiTro.Text.Trim() };
                    context.VaiTro.Add(vt);
                }
                else
                {
                    // Ép kiểu ID từ txtID để tìm bản ghi cần sửa
                    if (int.TryParse(txtID.Text, out int idSua))
                    {
                        var vt = context.VaiTro.Find(idSua);
                        if (vt != null)
                        {
                            vt.TenVaiTro = txtVaiTro.Text.Trim();
                            context.VaiTro.Update(vt);
                        }
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                frmVaiTro_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmVaiTro_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}