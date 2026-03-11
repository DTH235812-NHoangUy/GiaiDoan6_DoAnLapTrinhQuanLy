using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmNhanVien : Form
    {
        StadiumDbContext context = new StadiumDbContext();
        bool xuLyThem = false;
        int currentId;

        string projectRootFolder;
        string imagesFolder;
        string employeeImagesFolder;

        public frmNhanVien()
        {
            InitializeComponent();

            projectRootFolder = GetProjectRootFolder();
            imagesFolder = Path.Combine(projectRootFolder, "Images");
            employeeImagesFolder = Path.Combine(imagesFolder, "AnhTheNhanVien");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            if (!Directory.Exists(employeeImagesFolder))
                Directory.CreateDirectory(employeeImagesFolder);

            dgvNhanVien.DataError += (s, e) => { e.ThrowException = false; };
            dgvNhanVien.CellFormatting += dgvNhanVien_CellFormatting;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
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
            CaiDatNut(btnNhap, Properties.Resources.import_24, "Nhập Excel");
            CaiDatNut(btnXuat, Properties.Resources.export_24, "Xuất Excel");
            CaiDatNut(btnDoiAnh, Properties.Resources.camera_24, "Đổi ảnh thẻ");
        }

        private string GetProjectRootFolder()
        {
            string baseDir = Application.StartupPath;
            DirectoryInfo dir = new DirectoryInfo(baseDir);

            while (dir != null)
            {
                try
                {
                    bool hasCsproj = dir.GetFiles("*.csproj").Length > 0;
                    if (hasCsproj)
                        return dir.FullName;
                }
                catch
                {
                }

                dir = dir.Parent;
            }

            return AppDomain.CurrentDomain.BaseDirectory;
        }

        private string FindImagePath(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            string employeePath = Path.Combine(employeeImagesFolder, fileName);
            if (File.Exists(employeePath))
                return employeePath;

            string directPath = Path.Combine(imagesFolder, fileName);
            if (File.Exists(directPath))
                return directPath;

            try
            {
                string[] files = Directory.GetFiles(imagesFolder, fileName, SearchOption.AllDirectories);
                if (files.Length > 0)
                    return files[0];
            }
            catch
            {
            }

            return null;
        }

        private void ClearPictureBox()
        {
            try
            {
                picHinhAnh.ImageLocation = null;

                if (picHinhAnh.Image != null)
                {
                    Image oldImage = picHinhAnh.Image;
                    picHinhAnh.Image = null;
                    oldImage.Dispose();
                }
            }
            catch
            {
            }
        }

        private void ShowImageToPictureBox(string imagePath)
        {
            ClearPictureBox();

            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
                return;

            try
            {
                byte[] bytes = File.ReadAllBytes(imagePath);
                using (MemoryStream ms = new MemoryStream(bytes))
                using (Image img = Image.FromStream(ms))
                {
                    picHinhAnh.Image = new Bitmap(img);
                }

                picHinhAnh.ImageLocation = imagePath;
            }
            catch
            {
                ClearPictureBox();
            }
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colHinhAnh")
            {
                if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    string fileName = e.Value.ToString();
                    string path = FindImagePath(fileName);

                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        try
                        {
                            byte[] bytes = File.ReadAllBytes(path);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            using (Image img = Image.FromStream(ms))
                            {
                                e.Value = new Bitmap(img, 50, 50);
                                e.FormattingApplied = true;
                            }
                        }
                        catch
                        {
                            e.Value = null;
                            e.FormattingApplied = true;
                        }
                    }
                    else
                    {
                        e.Value = null;
                        e.FormattingApplied = true;
                    }
                }
                else
                {
                    e.Value = null;
                    e.FormattingApplied = true;
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();

            btnDoiAnh.Left = picHinhAnh.Left;
            btnDoiAnh.Top = picHinhAnh.Bottom + 8;
            btnDoiAnh.Width = picHinhAnh.Width;

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

            BindingSource bs = new BindingSource();
            bs.DataSource = listHienThi;

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
            Binding bImg = new Binding("Tag", bs, "HinhAnh", true);
            bImg.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrWhiteSpace(ev.Value.ToString()))
                    ev.Value = FindImagePath(ev.Value.ToString());
                else
                    ev.Value = null;
            };
            picHinhAnh.DataBindings.Add(bImg);

            dgvNhanVien.DataSource = bs;

            string filePath = picHinhAnh.Tag?.ToString();
            ShowImageToPictureBox(filePath);
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            object value = dgvNhanVien.CurrentRow.Cells["colHinhAnh"].Value;
            if (value == null)
            {
                ClearPictureBox();
                return;
            }

            string fileName = value.ToString();
            string imagePath = FindImagePath(fileName);
            ShowImageToPictureBox(imagePath);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofd.FileName;
                    string fileName = Path.GetFileName(sourcePath);
                    string destPath = Path.Combine(employeeImagesFolder, fileName);

                    try
                    {
                        ClearPictureBox();

                        if (!string.Equals(
                            Path.GetFullPath(sourcePath),
                            Path.GetFullPath(destPath),
                            StringComparison.OrdinalIgnoreCase))
                        {
                            File.Copy(sourcePath, destPath, true);
                        }

                        ShowImageToPictureBox(destPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể đổi ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string fileNameOnly = string.IsNullOrEmpty(picHinhAnh.ImageLocation)
                    ? ""
                    : Path.GetFileName(picHinhAnh.ImageLocation);

                if (xuLyThem)
                {
                    NhanVien nv = new NhanVien
                    {
                        HoVaTen = txtHoTen.Text.Trim(),
                        DienThoai = txtDienThoai.Text.Trim(),
                        TenDangNhap = txtDangNhap.Text.Trim(),
                        MatKhau = txtMatKhau.Text.Trim(),
                        VaiTroID = Convert.ToInt32(cboVaiTro.SelectedValue),
                        HinhAnh = fileNameOnly
                    };
                    context.NhanVien.Add(nv);
                }
                else
                {
                    if (dgvNhanVien.CurrentRow != null)
                    {
                        currentId = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value);
                        var nv = context.NhanVien.Find(currentId);

                        if (nv != null)
                        {
                            nv.HoVaTen = txtHoTen.Text.Trim();
                            nv.DienThoai = txtDienThoai.Text.Trim();
                            nv.TenDangNhap = txtDangNhap.Text.Trim();
                            nv.MatKhau = txtMatKhau.Text.Trim();
                            nv.VaiTroID = Convert.ToInt32(cboVaiTro.SelectedValue);

                            if (!string.IsNullOrEmpty(fileNameOnly))
                                nv.HinhAnh = fileNameOnly;
                        }
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                BatTatChucNang(false);
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtDangNhap.Clear();
            txtMatKhau.Clear();
            ClearPictureBox();

            if (cboVaiTro.Items.Count > 0)
                cboVaiTro.SelectedIndex = 0;

            txtHoTen.Focus();
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

            string ten = dgvNhanVien.CurrentRow.Cells["colHoVaTen"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Xóa nhân viên {ten}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int idXoa = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value);
                var nv = context.NhanVien.Find(idXoa);

                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    LoadDataGrid();
                    ClearPictureBox();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            LoadDataGrid();
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            this.Close();
        }
    }
}