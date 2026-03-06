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
    public partial class frmSanVanDong :  Form
    {
        StadiumDbContext context = new StadiumDbContext();
        bool xuLyThem = false;
        int currentId;
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");

        public frmSanVanDong()
        {
            InitializeComponent();
            if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);

            // 1. CHẶN LỖI ĐỊNH DẠNG: DataGridView sẽ không hiện hộp thoại lỗi khi thấy chuỗi string ở cột ảnh
            dgvSanVanDong.DataError += (s, e) => { e.ThrowException = false; };

            // 2. ĐẤU NỐI SỰ KIỆN: Ép chuỗi tên file thành hình ảnh hiển thị trên bảng
            this.dgvSanVanDong.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvSanVanDong_CellFormatting);
        }

        private void BatTatChucNang(bool dangSua)
        {
            btnLuu.Enabled = dangSua;
            btnHuy.Enabled = dangSua;
            txtTenSan.Enabled = dangSua;
            txtDiaChi.Enabled = dangSua;
            btnDoiAnh.Enabled = dangSua;

            btnThem.Enabled = !dangSua;
            btnSua.Enabled = !dangSua;
            btnXoa.Enabled = !dangSua;
            dgvSanVanDong.Enabled = !dangSua;

            txtID.ReadOnly = true;
        }

        private void dgvSanVanDong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu là cột Hình ảnh (Name trong Designer phải là colHinhAnh)
            if (dgvSanVanDong.Columns[e.ColumnIndex].Name == "colHinhAnh" || dgvSanVanDong.Columns[e.ColumnIndex].HeaderText.Contains("Ảnh"))
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    string fileName = e.Value.ToString();
                    string path = Path.Combine(imagesFolder, fileName);

                    if (File.Exists(path))
                    {
                        try
                        {
                            // Đọc file dưới dạng mảng byte để không gây khóa file (lock file)
                            byte[] bytes = File.ReadAllBytes(path);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                Image img = Image.FromStream(ms);
                                // Tạo bản thu nhỏ (Thumbnail) để GridView không bị giật lag
                                e.Value = new Bitmap(img, 60, 40);
                            }
                        }
                        catch { e.Value = null; }
                    }
                }
            }
        }

        private void frmSanVanDong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvSanVanDong.AutoGenerateColumns = false;
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            var listSVD = context.SanVanDong.ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = listSVD;

            // Bindings các trường nhập liệu
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bs, "ID", true, DataSourceUpdateMode.Never);

            txtTenSan.DataBindings.Clear();
            txtTenSan.DataBindings.Add("Text", bs, "TenSan", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi", true, DataSourceUpdateMode.Never);

            // Bindings ảnh cho PictureBox lớn
            picHinhAnh.DataBindings.Clear();
            Binding bImg = new Binding("ImageLocation", bs, "HinhAnh", true);
            bImg.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrEmpty(ev.Value.ToString()))
                    ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(bImg);

            dgvSanVanDong.DataSource = bs;
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // LẤY TÊN FILE GỐC (Ví dụ: mydinh.jpg)
                    string fileName = Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(imagesFolder, fileName);

                    // Copy file vào thư mục dự án (ghi đè nếu trùng tên)
                    File.Copy(ofd.FileName, destPath, true);

                    // Hiển thị lên PictureBox
                    picHinhAnh.ImageLocation = destPath;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSan.Text))
            {
                MessageBox.Show("Tên sân không được để trống!");
                return;
            }

            try
            {
                // Lấy chỉ tên file để lưu vào SQL (ví dụ: mydinh.jpg)
                string fileNameOnly = Path.GetFileName(picHinhAnh.ImageLocation);

                if (xuLyThem)
                {
                    SanVanDong svd = new SanVanDong
                    {
                        TenSan = txtTenSan.Text,
                        DiaChi = txtDiaChi.Text,
                        HinhAnh = fileNameOnly ?? ""
                    };
                    context.SanVanDong.Add(svd);
                }
                else
                {
                    var svd = context.SanVanDong.Find(currentId);
                    if (svd != null)
                    {
                        svd.TenSan = txtTenSan.Text;
                        svd.DiaChi = txtDiaChi.Text;
                        svd.HinhAnh = fileNameOnly ?? svd.HinhAnh;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                LoadDataGrid();
                BatTatChucNang(false);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtID.Text = "Tự động";
            txtTenSan.Clear();
            txtDiaChi.Clear();
            picHinhAnh.ImageLocation = null;
            picHinhAnh.Image = null;
            txtTenSan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanVanDong.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
            currentId = (int)dgvSanVanDong.CurrentRow.Cells["colID"].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanVanDong.CurrentRow == null) return;

            int idXoa = (int)dgvSanVanDong.CurrentRow.Cells["colID"].Value;
            string tenSan = dgvSanVanDong.CurrentRow.Cells["colTenSan"].Value.ToString();

            if (MessageBox.Show($"Xác nhận xóa sân: {tenSan}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var svd = context.SanVanDong.Find(idXoa);
                if (svd != null)
                {
                    context.SanVanDong.Remove(svd);
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