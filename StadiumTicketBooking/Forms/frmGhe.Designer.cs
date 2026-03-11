using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmGhe
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

            grpTTGhe = new GroupBox();
            cboKhuVuc = new ComboBox();
            btnXuat = new KryptonButton();
            btnNhap = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnThoat = new KryptonButton();
            btnHuy = new KryptonButton();
            btnLuu = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThem = new KryptonButton();
            txtSoGhe = new KryptonTextBox();
            txtID = new KryptonTextBox();
            lblSoGhe = new Label();
            lblKhuVuc = new Label();
            lblID = new Label();
            grpGhe = new GroupBox();
            dgvGhe = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSoGhe = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            grpTTGhe.SuspendLayout();
            grpGhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGhe).BeginInit();
            SuspendLayout();
            // 
            // grpTTGhe
            // 
            grpTTGhe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTGhe.BackColor = Color.White;
            grpTTGhe.Controls.Add(cboKhuVuc);
            grpTTGhe.Controls.Add(btnXuat);
            grpTTGhe.Controls.Add(btnNhap);
            grpTTGhe.Controls.Add(btnTimKiem);
            grpTTGhe.Controls.Add(btnThoat);
            grpTTGhe.Controls.Add(btnHuy);
            grpTTGhe.Controls.Add(btnLuu);
            grpTTGhe.Controls.Add(btnSua);
            grpTTGhe.Controls.Add(btnXoa);
            grpTTGhe.Controls.Add(btnThem);
            grpTTGhe.Controls.Add(txtSoGhe);
            grpTTGhe.Controls.Add(txtID);
            grpTTGhe.Controls.Add(lblSoGhe);
            grpTTGhe.Controls.Add(lblKhuVuc);
            grpTTGhe.Controls.Add(lblID);
            grpTTGhe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTTGhe.ForeColor = Color.FromArgb(45, 62, 80);
            grpTTGhe.Location = new Point(20, 15);
            grpTTGhe.Name = "grpTTGhe";
            grpTTGhe.Size = new Size(1240, 210);
            grpTTGhe.TabIndex = 0;
            grpTTGhe.TabStop = false;
            grpTTGhe.Text = "Thông tin ghế";
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhuVuc.Font = new Font("Segoe UI", 10F);
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(150, 132);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(260, 31);
            cboKhuVuc.TabIndex = 15;
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
            btnXuat.TabIndex = 14;
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
            btnNhap.TabIndex = 13;
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
            btnTimKiem.TabIndex = 12;
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
            btnThoat.TabIndex = 11;
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
            btnHuy.TabIndex = 10;
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
            btnLuu.TabIndex = 9;
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
            btnSua.TabIndex = 8;
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
            btnXoa.TabIndex = 7;
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
            btnThem.TabIndex = 6;
            btnThem.Values.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtSoGhe
            // 
            txtSoGhe.Location = new Point(150, 82);
            txtSoGhe.Name = "txtSoGhe";
            txtSoGhe.Size = new Size(260, 34);
            txtSoGhe.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtSoGhe.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtSoGhe.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtSoGhe.StateCommon.Border.Rounding = 6F;
            txtSoGhe.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtSoGhe.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtSoGhe.TabIndex = 5;
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
            txtID.TabIndex = 4;
            // 
            // lblSoGhe
            // 
            lblSoGhe.AutoSize = true;
            lblSoGhe.Font = new Font("Segoe UI", 10F);
            lblSoGhe.ForeColor = Color.FromArgb(45, 52, 54);
            lblSoGhe.Location = new Point(30, 88);
            lblSoGhe.Name = "lblSoGhe";
            lblSoGhe.Size = new Size(65, 23);
            lblSoGhe.TabIndex = 2;
            lblSoGhe.Text = "Số ghế:";
            // 
            // lblKhuVuc
            // 
            lblKhuVuc.AutoSize = true;
            lblKhuVuc.Font = new Font("Segoe UI", 10F);
            lblKhuVuc.ForeColor = Color.FromArgb(45, 52, 54);
            lblKhuVuc.Location = new Point(30, 138);
            lblKhuVuc.Name = "lblKhuVuc";
            lblKhuVuc.Size = new Size(78, 23);
            lblKhuVuc.TabIndex = 1;
            lblKhuVuc.Text = "Khu vực:";
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
            // grpGhe
            // 
            grpGhe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpGhe.BackColor = Color.White;
            grpGhe.Controls.Add(dgvGhe);
            grpGhe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpGhe.ForeColor = Color.FromArgb(45, 62, 80);
            grpGhe.Location = new Point(20, 240);
            grpGhe.Name = "grpGhe";
            grpGhe.Size = new Size(1240, 450);
            grpGhe.TabIndex = 1;
            grpGhe.TabStop = false;
            grpGhe.Text = "Danh sách ghế";
            // 
            // dgvGhe
            // 
            dgvGhe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGhe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGhe.BackgroundColor = Color.White;
            dgvGhe.BorderStyle = BorderStyle.None;
            dgvGhe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGhe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGhe.ColumnHeadersHeight = 40;
            dgvGhe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGhe.Columns.AddRange(new DataGridViewColumn[] { colID, colSoGhe, colTenKhuVuc, colTenSan });
            dgvGhe.EnableHeadersVisualStyles = false;
            dgvGhe.Location = new Point(10, 30);
            dgvGhe.MultiSelect = false;
            dgvGhe.Name = "dgvGhe";
            dgvGhe.RowHeadersVisible = false;
            dgvGhe.RowTemplate.Height = 35;
            dgvGhe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGhe.Size = new Size(1220, 410);
            dgvGhe.TabIndex = 0;
            headerStyle.BackColor = Color.FromArgb(108, 92, 231);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.SelectionBackColor = Color.FromArgb(108, 92, 231);
            headerStyle.SelectionForeColor = Color.White;
            dgvGhe.ColumnHeadersDefaultCellStyle = headerStyle;
            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.SelectionBackColor = Color.FromArgb(223, 230, 233);
            cellStyle.SelectionForeColor = Color.Black;
            dgvGhe.DefaultCellStyle = cellStyle;
            dgvGhe.GridColor = Color.FromArgb(230, 230, 230);
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 10F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colSoGhe
            // 
            colSoGhe.DataPropertyName = "SoGhe";
            colSoGhe.FillWeight = 20F;
            colSoGhe.HeaderText = "Số Ghế";
            colSoGhe.MinimumWidth = 6;
            colSoGhe.Name = "colSoGhe";
            // 
            // colTenKhuVuc
            // 
            colTenKhuVuc.DataPropertyName = "TenKhuVuc";
            colTenKhuVuc.FillWeight = 30F;
            colTenKhuVuc.HeaderText = "Khu Vực";
            colTenKhuVuc.MinimumWidth = 6;
            colTenKhuVuc.Name = "colTenKhuVuc";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.FillWeight = 40F;
            colTenSan.HeaderText = "Sân Vận Động";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // frmGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpGhe);
            Controls.Add(grpTTGhe);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "frmGhe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Ghế";
            Load += frmGhe_Load;
            grpTTGhe.ResumeLayout(false);
            grpTTGhe.PerformLayout();
            grpGhe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGhe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTGhe;
        private ComboBox cboKhuVuc;
        private KryptonButton btnXuat;
        private KryptonButton btnNhap;
        private KryptonButton btnTimKiem;
        private KryptonButton btnThoat;
        private KryptonButton btnHuy;
        private KryptonButton btnLuu;
        private KryptonButton btnSua;
        private KryptonButton btnXoa;
        private KryptonButton btnThem;
        private KryptonTextBox txtSoGhe;
        private KryptonTextBox txtID;
        private Label lblSoGhe;
        private Label lblKhuVuc;
        private Label lblID;
        private GroupBox grpGhe;
        private DataGridView dgvGhe;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSoGhe;
        private DataGridViewTextBoxColumn colTenKhuVuc;
        private DataGridViewTextBoxColumn colTenSan;
    }
}