using Krypton.Toolkit;
using StadiumTicketBooking.Data.Entity;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    public partial class frmVe : Form
    {
        private readonly StadiumDbContext context = new StadiumDbContext();
        private bool xuLyThem = false;
        private int currentId = 0;

        private string projectRootFolder;
        private string imagesFolder;
        private string ticketImagesFolder;

        public frmVe()
        {
            InitializeComponent();

            projectRootFolder = GetProjectRootFolder();
            imagesFolder = Path.Combine(projectRootFolder, "Images");
            ticketImagesFolder = Path.Combine(imagesFolder, "AnhVe");

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            if (!Directory.Exists(ticketImagesFolder))
                Directory.CreateDirectory(ticketImagesFolder);

            dgvVe.DataError += (s, e) => { e.ThrowException = false; };
            dgvVe.CellFormatting += dgvVe_CellFormatting;
            dgvVe.SelectionChanged += dgvVe_SelectionChanged;
        }

        private string GetProjectRootFolder()
        {
            string baseDir = Application.StartupPath;
            DirectoryInfo dir = new DirectoryInfo(baseDir);

            while (dir != null)
            {
                try
                {
                    if (dir.GetFiles("*.csproj").Length > 0)
                        return dir.FullName;
                }
                catch { }

                dir = dir.Parent;
            }

            return AppDomain.CurrentDomain.BaseDirectory;
        }

        private string FindImagePath(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            string ticketPath = Path.Combine(ticketImagesFolder, fileName);
            if (File.Exists(ticketPath))
                return ticketPath;

            string directPath = Path.Combine(imagesFolder, fileName);
            if (File.Exists(directPath))
                return directPath;

            try
            {
                string[] files = Directory.GetFiles(imagesFolder, fileName, SearchOption.AllDirectories);
                if (files.Length > 0)
                    return files[0];
            }
            catch { }

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
            catch { }
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

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;

            cboSuKien.Enabled = giaTri;
            cboGhe.Enabled = giaTri;
            txtGiaVe.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;
            btnDoiAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            dgvVe.Enabled = !giaTri;

            txtID.ReadOnly = true;
        }

        private void XoaDuLieuNhap()
        {
            txtID.Text = string.Empty;
            txtGiaVe.Text = string.Empty;

            if (cboSuKien.Items.Count > 0)
                cboSuKien.SelectedIndex = 0;

            if (cboGhe.Items.Count > 0)
                cboGhe.SelectedIndex = 0;

            cboTrangThai.Text = "Trống";
            ClearPictureBox();
        }

        private void TaiDanhSachSuKien()
        {
            var dsSuKien = context.SuKien
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.TenSuKien + " - " + x.SanVanDong.TenSan
                })
                .ToList();

            cboSuKien.DataSource = dsSuKien;
            cboSuKien.DisplayMember = "TenHienThi";
            cboSuKien.ValueMember = "ID";
        }

        private void TaiDanhSachGhe()
        {
            var dsGhe = context.Ghe
                .Select(x => new
                {
                    x.ID,
                    TenHienThi = x.SoGhe + " - " + x.KhuVuc.TenKhuVuc + " - " + x.KhuVuc.SanVanDong.TenSan
                })
                .ToList();

            cboGhe.DataSource = dsGhe;
            cboGhe.DisplayMember = "TenHienThi";
            cboGhe.ValueMember = "ID";
        }

        private void TaiTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Đã đặt");
            cboTrangThai.Items.Add("Đã bán");
            cboTrangThai.SelectedIndex = 0;
        }

        private void TaiDuLieu()
        {
            dgvVe.AutoGenerateColumns = false;

            var listVe = context.Ve
                .Select(x => new
                {
                    x.ID,
                    x.SuKienID,
                    x.GheID,
                    TenSuKien = x.SuKien.TenSuKien,
                    SoGhe = x.Ghe.SoGhe,
                    TenKhuVuc = x.Ghe.KhuVuc.TenKhuVuc,
                    TenSan = x.Ghe.KhuVuc.SanVanDong.TenSan,
                    x.GiaVe,
                    x.TrangThai,
                    x.HinhAnh
                })
                .ToList();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listVe
            };

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);

            txtGiaVe.DataBindings.Clear();
            txtGiaVe.DataBindings.Add("Text", bindingSource, "GiaVe", false, DataSourceUpdateMode.Never);

            cboSuKien.DataBindings.Clear();
            cboSuKien.DataBindings.Add("SelectedValue", bindingSource, "SuKienID", false, DataSourceUpdateMode.Never);

            cboGhe.DataBindings.Clear();
            cboGhe.DataBindings.Add("SelectedValue", bindingSource, "GheID", false, DataSourceUpdateMode.Never);

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("Text", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding bImg = new Binding("Tag", bindingSource, "HinhAnh", true);
            bImg.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrWhiteSpace(ev.Value.ToString()))
                    ev.Value = FindImagePath(ev.Value.ToString());
                else
                    ev.Value = null;
            };
            picHinhAnh.DataBindings.Add(bImg);

            dgvVe.DataSource = null;
            dgvVe.DataSource = bindingSource;

            if (dgvVe.Columns["colGiaVe"] != null)
            {
                dgvVe.Columns["colGiaVe"].DefaultCellStyle.Format = "N0";
                dgvVe.Columns["colGiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            string filePath = picHinhAnh.Tag?.ToString();
            ShowImageToPictureBox(filePath);
        }

        private void frmVe_Load(object sender, EventArgs e)
        {
            CaiDatIconNut();
            TaiDanhSachSuKien();
            TaiDanhSachGhe();
            TaiTrangThai();
            BatTatChucNang(false);
            TaiDuLieu();
        }

        private void dgvVe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvVe.Columns[e.ColumnIndex].Name == "colHinhAnh")
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
                                e.Value = new Bitmap(img, 55, 40);
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

        private void dgvVe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow == null) return;

            object value = dgvVe.CurrentRow.Cells["colHinhAnh"].Value;
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
                    string destPath = Path.Combine(ticketImagesFolder, fileName);

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            currentId = 0;
            BatTatChucNang(true);
            XoaDuLieuNhap();
            cboSuKien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvVe.CurrentRow.Cells["colID"].Value?.ToString(), out currentId))
            {
                xuLyThem = false;
                BatTatChucNang(true);
                cboSuKien.Focus();
            }
            else
            {
                MessageBox.Show("Không xác định được vé cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vé cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvVe.CurrentRow.Cells["colID"].Value?.ToString(), out int idXoa))
            {
                MessageBox.Show("Không xác định được vé cần xóa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenVe = dgvVe.CurrentRow.Cells["colTenSuKien"].Value?.ToString() + " - " +
                           dgvVe.CurrentRow.Cells["colSoGhe"].Value?.ToString();

            DialogResult ketQua = MessageBox.Show(
                $"Xác nhận xóa vé: {tenVe}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                var ve = context.Ve.Find(idXoa);
                if (ve != null)
                {
                    context.Ve.Remove(ve);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TaiDuLieu();
                    BatTatChucNang(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa vé này vì đang có dữ liệu liên quan!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboSuKien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sự kiện!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSuKien.Focus();
                return;
            }

            if (cboGhe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ghế!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGhe.Focus();
                return;
            }

            if (!int.TryParse(txtGiaVe.Text.Trim(), out int giaVe) || giaVe < 0)
            {
                MessageBox.Show("Giá vé không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaVe.Focus();
                return;
            }

            string trangThai = cboTrangThai.Text.Trim();
            int suKienId = Convert.ToInt32(cboSuKien.SelectedValue);
            int gheId = Convert.ToInt32(cboGhe.SelectedValue);

            if (string.IsNullOrWhiteSpace(trangThai))
                trangThai = "Trống";

            try
            {
                string fileNameOnly = string.IsNullOrEmpty(picHinhAnh.ImageLocation)
                    ? ""
                    : Path.GetFileName(picHinhAnh.ImageLocation);

                if (xuLyThem)
                {
                    bool daTonTai = context.Ve.Any(x =>
                        x.SuKienID == suKienId &&
                        x.GheID == gheId);

                    if (daTonTai)
                    {
                        MessageBox.Show("Vé của ghế này trong sự kiện đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboGhe.Focus();
                        return;
                    }

                    Ve ve = new Ve
                    {
                        SuKienID = suKienId,
                        GheID = gheId,
                        GiaVe = giaVe,
                        TrangThai = "Trống",
                        HinhAnh = fileNameOnly
                    };

                    context.Ve.Add(ve);
                }
                else
                {
                    if (!int.TryParse(txtID.Text, out int idSua))
                    {
                        MessageBox.Show("Không xác định được vé cần sửa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool trungDuLieu = context.Ve.Any(x =>
                        x.SuKienID == suKienId &&
                        x.GheID == gheId &&
                        x.ID != idSua);

                    if (trungDuLieu)
                    {
                        MessageBox.Show("Vé của ghế này trong sự kiện đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboGhe.Focus();
                        return;
                    }

                    var ve = context.Ve.Find(idSua);
                    if (ve != null)
                    {
                        ve.SuKienID = suKienId;
                        ve.GheID = gheId;
                        ve.GiaVe = giaVe;
                        ve.TrangThai = trangThai;

                        if (!string.IsNullOrEmpty(fileNameOnly))
                            ve.HinhAnh = fileNameOnly;

                        context.Ve.Update(ve);
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
            ClearPictureBox();
            TaiDuLieu();
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