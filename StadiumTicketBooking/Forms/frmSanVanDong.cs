using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmSanVanDong : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private int currentId;

        private string projectRootFolder;
        private string imagesFolder;
        private string stadiumImagesFolder;

        public frmSanVanDong()
        {
            InitializeComponent();

            projectRootFolder = GetProjectRootFolder();
            imagesFolder = Path.Combine(projectRootFolder, "Images");
            stadiumImagesFolder = Path.Combine(imagesFolder, "AnhSanVanDong");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            if (!Directory.Exists(stadiumImagesFolder))
                Directory.CreateDirectory(stadiumImagesFolder);

            dgvSanVanDong.DataError += (s, e) => { e.ThrowException = false; };
            dgvSanVanDong.CellFormatting += dgvSanVanDong_CellFormatting;
            dgvSanVanDong.SelectionChanged += dgvSanVanDong_SelectionChanged;
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
            CaiDatNut(btnDoiAnh, Properties.Resources.camera_24, "Đổi ảnh");
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

            string stadiumPath = Path.Combine(stadiumImagesFolder, fileName);
            if (File.Exists(stadiumPath))
                return stadiumPath;

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
            btnThoat.Enabled = !dangSua;
            btnNhap.Enabled = !dangSua;
            btnXuat.Enabled = !dangSua;
            btnTimKiem.Enabled = !dangSua;
            dgvSanVanDong.Enabled = !dangSua;

            txtID.ReadOnly = true;
        }

        private void dgvSanVanDong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvSanVanDong.Columns[e.ColumnIndex].Name == "colHinhAnh")
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
                                e.Value = new Bitmap(img, 70, 45);
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

        private void frmSanVanDong_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();

            // Fix nút Đổi ảnh luôn nằm ngay dưới ảnh
            btnDoiAnh.Left = picHinhAnh.Left;
            btnDoiAnh.Top = picHinhAnh.Bottom + 8;
            btnDoiAnh.Width = picHinhAnh.Width;

            BatTatChucNang(false);
            dgvSanVanDong.AutoGenerateColumns = false;
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            var listSVD = context.SanVanDong.ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = listSVD;

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bs, "ID", true, DataSourceUpdateMode.Never);

            txtTenSan.DataBindings.Clear();
            txtTenSan.DataBindings.Add("Text", bs, "TenSan", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi", true, DataSourceUpdateMode.Never);

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

            dgvSanVanDong.DataSource = null;
            dgvSanVanDong.DataSource = bs;

            string filePath = picHinhAnh.Tag?.ToString();
            ShowImageToPictureBox(filePath);
        }

        private void dgvSanVanDong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanVanDong.CurrentRow == null) return;

            object value = dgvSanVanDong.CurrentRow.Cells["colHinhAnh"].Value;
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
                    string destPath = Path.Combine(stadiumImagesFolder, fileName);

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
            if (string.IsNullOrWhiteSpace(txtTenSan.Text))
            {
                MessageBox.Show("Tên sân không được để trống!");
                return;
            }

            try
            {
                string fileNameOnly = string.IsNullOrEmpty(picHinhAnh.ImageLocation)
                    ? ""
                    : Path.GetFileName(picHinhAnh.ImageLocation);

                if (xuLyThem)
                {
                    SanVanDong svd = new SanVanDong
                    {
                        TenSan = txtTenSan.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        HinhAnh = fileNameOnly
                    };
                    context.SanVanDong.Add(svd);
                }
                else
                {
                    var svd = context.SanVanDong.Find(currentId);
                    if (svd != null)
                    {
                        svd.TenSan = txtTenSan.Text.Trim();
                        svd.DiaChi = txtDiaChi.Text.Trim();

                        if (!string.IsNullOrEmpty(fileNameOnly))
                            svd.HinhAnh = fileNameOnly;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                LoadDataGrid();
                BatTatChucNang(false);
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

            txtID.Text = "";
            txtTenSan.Clear();
            txtDiaChi.Clear();
            ClearPictureBox();

            txtTenSan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanVanDong.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);
            currentId = Convert.ToInt32(dgvSanVanDong.CurrentRow.Cells["colID"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanVanDong.CurrentRow == null) return;

            int idXoa = Convert.ToInt32(dgvSanVanDong.CurrentRow.Cells["colID"].Value);
            string tenSan = dgvSanVanDong.CurrentRow.Cells["colTenSan"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Xác nhận xóa sân: {tenSan}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var svd = context.SanVanDong.Find(idXoa);
                if (svd != null)
                {
                    context.SanVanDong.Remove(svd);
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
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}