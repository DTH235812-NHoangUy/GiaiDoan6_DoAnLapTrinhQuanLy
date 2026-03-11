using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmVaiTro
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpTTVT = new GroupBox();
            btnTimKiem = new KryptonButton();
            btnXuat = new KryptonButton();
            btnNhap = new KryptonButton();
            btnThoat = new KryptonButton();
            btnHuy = new KryptonButton();
            btnLuu = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThem = new KryptonButton();
            txtVaiTro = new KryptonTextBox();
            txtID = new KryptonTextBox();
            lblVaiTro = new Label();
            lblID = new Label();
            groupVaiTro = new GroupBox();
            dgvVaiTro = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colVaiTro = new DataGridViewTextBoxColumn();
            grpTTVT.SuspendLayout();
            groupVaiTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVaiTro).BeginInit();
            SuspendLayout();
            // 
            // grpTTVT
            // 
            grpTTVT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTVT.BackColor = Color.White;
            grpTTVT.Controls.Add(btnTimKiem);
            grpTTVT.Controls.Add(btnXuat);
            grpTTVT.Controls.Add(btnNhap);
            grpTTVT.Controls.Add(btnThoat);
            grpTTVT.Controls.Add(btnHuy);
            grpTTVT.Controls.Add(btnLuu);
            grpTTVT.Controls.Add(btnSua);
            grpTTVT.Controls.Add(btnXoa);
            grpTTVT.Controls.Add(btnThem);
            grpTTVT.Controls.Add(txtVaiTro);
            grpTTVT.Controls.Add(txtID);
            grpTTVT.Controls.Add(lblVaiTro);
            grpTTVT.Controls.Add(lblID);
            grpTTVT.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTTVT.ForeColor = Color.FromArgb(45, 62, 80);
            grpTTVT.Location = new Point(20, 15);
            grpTTVT.Name = "grpTTVT";
            grpTTVT.Size = new Size(1240, 180);
            grpTTVT.TabIndex = 0;
            grpTTVT.TabStop = false;
            grpTTVT.Text = "Thông tin vai trò";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1045, 118);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.OverrideDefault.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.OverrideDefault.Border.Rounding = 8F;
            btnTimKiem.Size = new Size(150, 40);
            btnTimKiem.StateCommon.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnTimKiem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.StateCommon.Border.Rounding = 8F;
            btnTimKiem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1045, 72);
            btnXuat.Name = "btnXuat";
            btnXuat.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.OverrideDefault.Border.Rounding = 8F;
            btnXuat.Size = new Size(150, 40);
            btnXuat.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnXuat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.StateCommon.Border.Rounding = 8F;
            btnXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXuat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuat.TabIndex = 11;
            btnXuat.Values.DropDownArrowColor = Color.Empty;
            btnXuat.Values.Text = "Xuất";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1045, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNhap.OverrideDefault.Border.Rounding = 8F;
            btnNhap.Size = new Size(150, 40);
            btnNhap.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnNhap.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnNhap.StateCommon.Border.Rounding = 8F;
            btnNhap.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNhap.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhap.TabIndex = 10;
            btnNhap.Values.DropDownArrowColor = Color.Empty;
            btnNhap.Values.Text = "Nhập";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(875, 118);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(150, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 9;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(875, 72);
            btnHuy.Name = "btnHuy";
            btnHuy.OverrideDefault.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnHuy.OverrideDefault.Border.Rounding = 8F;
            btnHuy.Size = new Size(150, 40);
            btnHuy.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuy.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnHuy.StateCommon.Border.Rounding = 8F;
            btnHuy.StateCommon.Content.ShortText.Color1 = Color.White;
            btnHuy.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.TabIndex = 8;
            btnHuy.Values.DropDownArrowColor = Color.Empty;
            btnHuy.Values.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(875, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.OverrideDefault.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnLuu.OverrideDefault.Border.Rounding = 8F;
            btnLuu.Size = new Size(150, 40);
            btnLuu.StateCommon.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnLuu.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnLuu.StateCommon.Border.Rounding = 8F;
            btnLuu.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLuu.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.TabIndex = 7;
            btnLuu.Values.DropDownArrowColor = Color.Empty;
            btnLuu.Values.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(705, 118);
            btnSua.Name = "btnSua";
            btnSua.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSua.OverrideDefault.Border.Rounding = 8F;
            btnSua.Size = new Size(150, 40);
            btnSua.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnSua.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSua.StateCommon.Border.Rounding = 8F;
            btnSua.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.TabIndex = 6;
            btnSua.Values.DropDownArrowColor = Color.Empty;
            btnSua.Values.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(705, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.OverrideDefault.Border.Rounding = 8F;
            btnXoa.Size = new Size(150, 40);
            btnXoa.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnXoa.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.StateCommon.Border.Rounding = 8F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.TabIndex = 5;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(705, 26);
            btnThem.Name = "btnThem";
            btnThem.OverrideDefault.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThem.OverrideDefault.Border.Rounding = 8F;
            btnThem.Size = new Size(150, 40);
            btnThem.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnThem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThem.StateCommon.Border.Rounding = 8F;
            btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.TabIndex = 4;
            btnThem.Values.DropDownArrowColor = Color.Empty;
            btnThem.Values.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(130, 88);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(520, 34);
            txtVaiTro.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtVaiTro.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtVaiTro.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtVaiTro.StateCommon.Border.Rounding = 6F;
            txtVaiTro.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtVaiTro.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtVaiTro.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 38);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(520, 34);
            txtID.StateCommon.Back.Color1 = Color.FromArgb(245, 246, 250);
            txtID.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtID.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            txtID.StateCommon.Border.Rounding = 6F;
            txtID.StateCommon.Content.Color1 = Color.FromArgb(99, 110, 114);
            txtID.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtID.TabIndex = 2;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 10F);
            lblVaiTro.ForeColor = Color.FromArgb(45, 52, 54);
            lblVaiTro.Location = new Point(30, 93);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(64, 23);
            lblVaiTro.TabIndex = 1;
            lblVaiTro.Text = "Vai trò:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(45, 52, 54);
            lblID.Location = new Point(30, 43);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // groupVaiTro
            // 
            groupVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupVaiTro.BackColor = Color.White;
            groupVaiTro.Controls.Add(dgvVaiTro);
            groupVaiTro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupVaiTro.ForeColor = Color.FromArgb(45, 62, 80);
            groupVaiTro.Location = new Point(20, 210);
            groupVaiTro.Name = "groupVaiTro";
            groupVaiTro.Size = new Size(1240, 480);
            groupVaiTro.TabIndex = 1;
            groupVaiTro.TabStop = false;
            groupVaiTro.Text = "Danh sách vai trò";
            // 
            // dgvVaiTro
            // 
            dgvVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVaiTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaiTro.BackgroundColor = Color.White;
            dgvVaiTro.BorderStyle = BorderStyle.None;
            dgvVaiTro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVaiTro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(108, 92, 231);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvVaiTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVaiTro.ColumnHeadersHeight = 40;
            dgvVaiTro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVaiTro.Columns.AddRange(new DataGridViewColumn[] { colID, colVaiTro });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 230, 233);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVaiTro.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVaiTro.EnableHeadersVisualStyles = false;
            dgvVaiTro.GridColor = Color.FromArgb(230, 230, 230);
            dgvVaiTro.Location = new Point(10, 30);
            dgvVaiTro.MultiSelect = false;
            dgvVaiTro.Name = "dgvVaiTro";
            dgvVaiTro.RowHeadersVisible = false;
            dgvVaiTro.RowHeadersWidth = 51;
            dgvVaiTro.RowTemplate.Height = 32;
            dgvVaiTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaiTro.Size = new Size(1220, 440);
            dgvVaiTro.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 25F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "TenVaiTro";
            colVaiTro.FillWeight = 75F;
            colVaiTro.HeaderText = "Tên Vai Trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            // 
            // frmVaiTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(groupVaiTro);
            Controls.Add(grpTTVT);
            Font = new Font("Segoe UI", 9F);
            Name = "frmVaiTro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Vai Trò";
            Load += frmVaiTro_Load;
            grpTTVT.ResumeLayout(false);
            grpTTVT.PerformLayout();
            groupVaiTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVaiTro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTVT;
        private GroupBox groupVaiTro;
        private Label lblVaiTro;
        private Label lblID;
        private DataGridView dgvVaiTro;
        private KryptonButton btnTimKiem;
        private KryptonButton btnXuat;
        private KryptonButton btnNhap;
        private KryptonButton btnThoat;
        private KryptonButton btnHuy;
        private KryptonButton btnLuu;
        private KryptonButton btnSua;
        private KryptonButton btnXoa;
        private KryptonButton btnThem;
        private KryptonTextBox txtVaiTro;
        private KryptonTextBox txtID;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colVaiTro;
    }
}