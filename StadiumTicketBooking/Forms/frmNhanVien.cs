using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmNhanVien :  Form
    {
        StadiumDbContext context = new StadiumDbContext();
        bool xuLyThem = false;
        int currentId;
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");

        public frmNhanVien()
        {
            InitializeComponent();
            if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);

            // Chặn lỗi định dạng khi DataGridView load chuỗi string vào cột Image
            dgvNhanVien.DataError += (s, e) => { e.ThrowException = false; };

            // Đấu nối sự kiện hiển thị ảnh trên lưới
            this.dgvNhanVien.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvNhanVien_CellFormatting);
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtHoTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboVaiTro.Enabled = giaTri;
            btnDoiAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            dgvNhanVien.Enabled = !giaTri;
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra đúng tên cột chứa ảnh (colHinhAnh)
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colHinhAnh")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    string path = Path.Combine(imagesFolder, e.Value.ToString());
                    if (File.Exists(path))
                    {
                        try
                        {
                            // Đọc qua mảng byte để tránh lock file
                            byte[] bytes = File.ReadAllBytes(path);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                Image img = Image.FromStream(ms);
                                e.Value = new Bitmap(img, 50, 50); // Resize nhỏ để bảng mượt
                            }
                        }
                        catch { e.Value = null; }
                    }
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvNhanVien.AutoGenerateColumns = false;

            cboVaiTro.DataSource = context.VaiTro.ToList();
            cboVaiTro.DisplayMember = "TenVaiTro";
            cboVaiTro.ValueMember = "ID";

            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            var listHienThi = context.NhanVien
                .Select(x => new
                {
                    x.ID,
                    x.HoVaTen,
                    x.DienThoai,
                    x.TenDangNhap,
                    x.MatKhau,
                    x.VaiTroID,
                    TenVaiTro = x.VaiTro.TenVaiTro,
                    x.HinhAnh
                }).ToList();

            BindingSource bs = new BindingSource { DataSource = listHienThi };

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bs, "HoVaTen", true, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bs, "DienThoai", true, DataSourceUpdateMode.Never);
            txtDangNhap.DataBindings.Clear();
            txtDangNhap.DataBindings.Add("Text", bs, "TenDangNhap", true, DataSourceUpdateMode.Never);
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bs, "MatKhau", true, DataSourceUpdateMode.Never);
            cboVaiTro.DataBindings.Clear();
            cboVaiTro.DataBindings.Add("SelectedValue", bs, "VaiTroID", true, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding bImg = new Binding("ImageLocation", bs, "HinhAnh", true);
            bImg.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrEmpty(ev.Value.ToString()))
                    ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(bImg);

            dgvNhanVien.DataSource = bs;
        }

        // --- SỬA NÚT ĐỔI ẢNH: GIỮ TÊN FILE GỐC ---
        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên file gốc (ví dụ: myphoto.jpg)
                    string fileName = Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(imagesFolder, fileName);

                    // Copy vào thư mục dự án (ghi đè nếu trùng tên)
                    File.Copy(ofd.FileName, destPath, true);

                    // Gán vào ImageLocation để nút Lưu lấy ra sử dụng
                    picHinhAnh.ImageLocation = destPath;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên file từ đường dẫn ImageLocation (chỉ lấy phần nhanvien.jpg)
                string fileNameOnly = Path.GetFileName(picHinhAnh.ImageLocation);

                if (xuLyThem)
                {
                    NhanVien nv = new NhanVien
                    {
                        HoVaTen = txtHoTen.Text,
                        DienThoai = txtDienThoai.Text,
                        TenDangNhap = txtDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                        VaiTroID = (int)cboVaiTro.SelectedValue,
                        HinhAnh = fileNameOnly ?? "" // Lưu "tenfile.jpg" vào SQL
                    };
                    context.NhanVien.Add(nv);
                }
                else
                {
                    if (dgvNhanVien.CurrentRow != null)
                    {
                        currentId = (int)dgvNhanVien.CurrentRow.Cells["colID"].Value;
                        var nv = context.NhanVien.Find(currentId);
                        if (nv != null)
                        {
                            nv.HoVaTen = txtHoTen.Text;
                            nv.DienThoai = txtDienThoai.Text;
                            nv.TenDangNhap = txtDangNhap.Text;
                            nv.MatKhau = txtMatKhau.Text;
                            nv.VaiTroID = (int)cboVaiTro.SelectedValue;
                            nv.HinhAnh = fileNameOnly ?? nv.HinhAnh;
                        }
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                BatTatChucNang(false);
                LoadDataGrid();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtDangNhap.Clear();
            txtMatKhau.Clear();
            picHinhAnh.ImageLocation = null;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            string ten = dgvNhanVien.CurrentRow.Cells["colHoVaTen"].Value.ToString();
            if (MessageBox.Show($"Xóa nhân viên {ten}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idXoa = (int)dgvNhanVien.CurrentRow.Cells["colID"].Value;
                var nv = context.NhanVien.Find(idXoa);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    LoadDataGrid();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}