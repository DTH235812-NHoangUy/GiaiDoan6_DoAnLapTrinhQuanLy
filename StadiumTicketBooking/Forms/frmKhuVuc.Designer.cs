using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmKhuVuc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

            grpTTKhuVuc = new GroupBox();
            cboSanVanDong = new ComboBox();
            btnXuat = new KryptonButton();
            btnNhap = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnThoat = new KryptonButton();
            btnHuy = new KryptonButton();
            btnLuu = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThem = new KryptonButton();
            txtHeSoGia = new KryptonTextBox();
            txtTenKhuVuc = new KryptonTextBox();
            txtID = new KryptonTextBox();
            lblHeSoGia = new Label();
            lblTenKhuVuc = new Label();
            lblSanVanDong = new Label();
            lblID = new Label();
            grpKhuVuc = new GroupBox();
            dgvKhuVuc = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colHeSoGia = new DataGridViewTextBoxColumn();
            grpTTKhuVuc.SuspendLayout();
            grpKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).BeginInit();
            SuspendLayout();
            // 
            // grpTTKhuVuc
            // 
            grpTTKhuVuc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTKhuVuc.BackColor = Color.White;
            grpTTKhuVuc.Controls.Add(cboSanVanDong);
            grpTTKhuVuc.Controls.Add(btnXuat);
            grpTTKhuVuc.Controls.Add(btnNhap);
            grpTTKhuVuc.Controls.Add(btnTimKiem);
            grpTTKhuVuc.Controls.Add(btnThoat);
            grpTTKhuVuc.Controls.Add(btnHuy);
            grpTTKhuVuc.Controls.Add(btnLuu);
            grpTTKhuVuc.Controls.Add(btnSua);
            grpTTKhuVuc.Controls.Add(btnXoa);
            grpTTKhuVuc.Controls.Add(btnThem);
            grpTTKhuVuc.Controls.Add(txtHeSoGia);
            grpTTKhuVuc.Controls.Add(txtTenKhuVuc);
            grpTTKhuVuc.Controls.Add(txtID);
            grpTTKhuVuc.Controls.Add(lblHeSoGia);
            grpTTKhuVuc.Controls.Add(lblTenKhuVuc);
            grpTTKhuVuc.Controls.Add(lblSanVanDong);
            grpTTKhuVuc.Controls.Add(lblID);
            grpTTKhuVuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTTKhuVuc.ForeColor = Color.FromArgb(45, 62, 80);
            grpTTKhuVuc.Location = new Point(20, 15);
            grpTTKhuVuc.Name = "grpTTKhuVuc";
            grpTTKhuVuc.Size = new Size(1240, 235);
            grpTTKhuVuc.TabIndex = 0;
            grpTTKhuVuc.TabStop = false;
            grpTTKhuVuc.Text = "Thông tin khu vực";
            // 
            // cboSanVanDong
            // 
            cboSanVanDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanVanDong.Font = new Font("Segoe UI", 10F);
            cboSanVanDong.FormattingEnabled = true;
            cboSanVanDong.Location = new Point(150, 132);
            cboSanVanDong.Name = "cboSanVanDong";
            cboSanVanDong.Size = new Size(260, 31);
            cboSanVanDong.TabIndex = 17;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(800, 118);
            btnXuat.Name = "btnXuat";
            btnXuat.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnXuat.OverrideDefault.Border.Rounding = 8F;
            btnXuat.Size = new Size(150, 40);
            btnXuat.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnXuat.StateCommon.Border.Rounding = 8F;
            btnXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXuat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuat.TabIndex = 16;
            btnXuat.Values.Text = "Xuất";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(800, 72);
            btnNhap.Name = "btnNhap";
            btnNhap.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnNhap.OverrideDefault.Border.Rounding = 8F;
            btnNhap.Size = new Size(150, 40);
            btnNhap.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnNhap.StateCommon.Border.Rounding = 8F;
            btnNhap.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNhap.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.TabIndex = 15;
            btnNhap.Values.Text = "Nhập";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(800, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.OverrideDefault.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnTimKiem.OverrideDefault.Border.Rounding = 8F;
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.StateCommon.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnTimKiem.StateCommon.Border.Rounding = 8F;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Values.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(620, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(150, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 13;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(620, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.OverrideDefault.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnHuy.OverrideDefault.Border.Rounding = 8F;
            btnHuy.Size = new Size(150, 40);
            btnHuy.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnHuy.StateCommon.Border.Rounding = 8F;
            btnHuy.StateCommon.Content.ShortText.Color1 = Color.White;
            btnHuy.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.TabIndex = 12;
            btnHuy.Values.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(620, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.OverrideDefault.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnLuu.OverrideDefault.Border.Rounding = 8F;
            btnLuu.Size = new Size(150, 40);
            btnLuu.StateCommon.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnLuu.StateCommon.Border.Rounding = 8F;
            btnLuu.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLuu.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.TabIndex = 11;
            btnLuu.Values.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(440, 118);
            btnSua.Name = "btnSua";
            btnSua.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnSua.OverrideDefault.Border.Rounding = 8F;
            btnSua.Size = new Size(150, 40);
            btnSua.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnSua.StateCommon.Border.Rounding = 8F;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.TabIndex = 10;
            btnSua.Values.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(440, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnXoa.OverrideDefault.Border.Rounding = 8F;
            btnXoa.Size = new Size(150, 40);
            btnXoa.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnXoa.StateCommon.Border.Rounding = 8F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.TabIndex = 9;
            btnXoa.Values.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(440, 26);
            btnThem.Name = "btnThem";
            btnThem.OverrideDefault.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThem.OverrideDefault.Border.Rounding = 8F;
            btnThem.Size = new Size(150, 40);
            btnThem.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThem.StateCommon.Border.Rounding = 8F;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.TabIndex = 8;
            btnThem.Values.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtHeSoGia
            // 
            txtHeSoGia.Location = new Point(150, 182);
            txtHeSoGia.Name = "txtHeSoGia";
            txtHeSoGia.Size = new Size(260, 34);
            txtHeSoGia.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtHeSoGia.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtHeSoGia.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtHeSoGia.StateCommon.Border.Rounding = 6F;
            txtHeSoGia.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtHeSoGia.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtHeSoGia.TabIndex = 7;
            // 
            // txtTenKhuVuc
            // 
            txtTenKhuVuc.Location = new Point(150, 82);
            txtTenKhuVuc.Name = "txtTenKhuVuc";
            txtTenKhuVuc.Size = new Size(260, 34);
            txtTenKhuVuc.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtTenKhuVuc.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtTenKhuVuc.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtTenKhuVuc.StateCommon.Border.Rounding = 6F;
            txtTenKhuVuc.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtTenKhuVuc.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtTenKhuVuc.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 32);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 34);
            txtID.StateCommon.Back.Color1 = Color.FromArgb(245, 246, 250);
            txtID.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtID.StateCommon.Border.Rounding = 6F;
            txtID.StateCommon.Content.Color1 = Color.FromArgb(99, 110, 114);
            txtID.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtID.TabIndex = 5;
            // 
            // lblHeSoGia
            // 
            lblHeSoGia.AutoSize = true;
            lblHeSoGia.Font = new Font("Segoe UI", 10F);
            lblHeSoGia.ForeColor = Color.FromArgb(45, 52, 54);
            lblHeSoGia.Location = new Point(30, 188);
            lblHeSoGia.Name = "lblHeSoGia";
            lblHeSoGia.Size = new Size(86, 23);
            lblHeSoGia.TabIndex = 3;
            lblHeSoGia.Text = "Hệ số giá:";
            // 
            // lblTenKhuVuc
            // 
            lblTenKhuVuc.AutoSize = true;
            lblTenKhuVuc.Font = new Font("Segoe UI", 10F);
            lblTenKhuVuc.ForeColor = Color.FromArgb(45, 52, 54);
            lblTenKhuVuc.Location = new Point(30, 88);
            lblTenKhuVuc.Name = "lblTenKhuVuc";
            lblTenKhuVuc.Size = new Size(104, 23);
            lblTenKhuVuc.TabIndex = 2;
            lblTenKhuVuc.Text = "Tên khu vực:";
            // 
            // lblSanVanDong
            // 
            lblSanVanDong.AutoSize = true;
            lblSanVanDong.Font = new Font("Segoe UI", 10F);
            lblSanVanDong.ForeColor = Color.FromArgb(45, 52, 54);
            lblSanVanDong.Location = new Point(30, 138);
            lblSanVanDong.Name = "lblSanVanDong";
            lblSanVanDong.Size = new Size(114, 23);
            lblSanVanDong.TabIndex = 1;
            lblSanVanDong.Text = "Sân vận động:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(45, 52, 54);
            lblID.Location = new Point(30, 38);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // grpKhuVuc
            // 
            grpKhuVuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpKhuVuc.BackColor = Color.White;
            grpKhuVuc.Controls.Add(dgvKhuVuc);
            grpKhuVuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpKhuVuc.ForeColor = Color.FromArgb(45, 62, 80);
            grpKhuVuc.Location = new Point(20, 265);
            grpKhuVuc.Name = "grpKhuVuc";
            grpKhuVuc.Size = new Size(1240, 425);
            grpKhuVuc.TabIndex = 1;
            grpKhuVuc.TabStop = false;
            grpKhuVuc.Text = "Danh sách khu vực";
            // 
            // dgvKhuVuc
            // 
            dgvKhuVuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhuVuc.BackgroundColor = Color.White;
            dgvKhuVuc.BorderStyle = BorderStyle.None;
            dgvKhuVuc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhuVuc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKhuVuc.ColumnHeadersHeight = 40;
            dgvKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhuVuc.Columns.AddRange(new DataGridViewColumn[] { colID, colTenKhuVuc, colTenSan, colHeSoGia });
            dgvKhuVuc.EnableHeadersVisualStyles = false;
            dgvKhuVuc.Location = new Point(10, 30);
            dgvKhuVuc.MultiSelect = false;
            dgvKhuVuc.Name = "dgvKhuVuc";
            dgvKhuVuc.RowHeadersVisible = false;
            dgvKhuVuc.RowTemplate.Height = 35;
            dgvKhuVuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhuVuc.Size = new Size(1220, 385);
            dgvKhuVuc.TabIndex = 0;
            headerStyle.BackColor = Color.FromArgb(108, 92, 231);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.SelectionBackColor = Color.FromArgb(108, 92, 231);
            headerStyle.SelectionForeColor = Color.White;
            dgvKhuVuc.ColumnHeadersDefaultCellStyle = headerStyle;
            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.SelectionBackColor = Color.FromArgb(223, 230, 233);
            cellStyle.SelectionForeColor = Color.Black;
            dgvKhuVuc.DefaultCellStyle = cellStyle;
            dgvKhuVuc.GridColor = Color.FromArgb(230, 230, 230);
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 10F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenKhuVuc
            // 
            colTenKhuVuc.DataPropertyName = "TenKhuVuc";
            colTenKhuVuc.FillWeight = 35F;
            colTenKhuVuc.HeaderText = "Tên Khu Vực";
            colTenKhuVuc.MinimumWidth = 6;
            colTenKhuVuc.Name = "colTenKhuVuc";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 35F;
            colTenSan.HeaderText = "Sân Vận Động";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // colHeSoGia
            // 
            colHeSoGia.DataPropertyName = "HeSoGia";
            colHeSoGia.FillWeight = 20F;
            colHeSoGia.HeaderText = "Hệ Số Giá";
            colHeSoGia.MinimumWidth = 6;
            colHeSoGia.Name = "colHeSoGia";
            // 
            // frmKhuVuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpKhuVuc);
            Controls.Add(grpTTKhuVuc);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "frmKhuVuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khu Vực";
            Load += frmKhuVuc_Load;
            grpTTKhuVuc.ResumeLayout(false);
            grpTTKhuVuc.PerformLayout();
            grpKhuVuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTKhuVuc;
        private ComboBox cboSanVanDong;
        private KryptonButton btnXuat;
        private KryptonButton btnNhap;
        private KryptonButton btnTimKiem;
        private KryptonButton btnThoat;
        private KryptonButton btnHuy;
        private KryptonButton btnLuu;
        private KryptonButton btnSua;
        private KryptonButton btnXoa;
        private KryptonButton btnThem;
        private KryptonTextBox txtHeSoGia;
        private KryptonTextBox txtTenKhuVuc;
        private KryptonTextBox txtID;
        private Label lblHeSoGia;
        private Label lblTenKhuVuc;
        private Label lblSanVanDong;
        private Label lblID;
        private GroupBox grpKhuVuc;
        private DataGridView dgvKhuVuc;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenKhuVuc;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colHeSoGia;
    }
}