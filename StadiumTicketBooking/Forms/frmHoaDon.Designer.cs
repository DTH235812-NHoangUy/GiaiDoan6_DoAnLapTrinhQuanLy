using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            grpDanhSach = new GroupBox();
            dgvHoaDon = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            panelBottom = new Panel();
            btnLapHoaDon = new KryptonButton();
            btnInHoaDon = new KryptonButton();
            btnSua = new KryptonButton();
            btnXoa = new KryptonButton();
            btnThoat = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnXuat = new KryptonButton();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(dgvHoaDon);
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(12, 12);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1060, 525);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvHoaDon.ColumnHeadersHeight = 40;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle8;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(3, 26);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 32;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1054, 496);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dataGridView_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 45F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.FillWeight = 130F;
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.FillWeight = 140F;
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NgayLap.DefaultCellStyle = dataGridViewCellStyle6;
            NgayLap.FillWeight = 110F;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.Blue;
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle7;
            TongTienHoaDon.FillWeight = 120F;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.LinkBehavior = LinkBehavior.HoverUnderline;
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            XemChiTiet.Resizable = DataGridViewTriState.True;
            XemChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            XemChiTiet.TrackVisitedState = false;
            // 
            // panelBottom
            // 
            panelBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(btnLapHoaDon);
            panelBottom.Controls.Add(btnInHoaDon);
            panelBottom.Controls.Add(btnSua);
            panelBottom.Controls.Add(btnXoa);
            panelBottom.Controls.Add(btnThoat);
            panelBottom.Controls.Add(btnTimKiem);
            panelBottom.Controls.Add(btnXuat);
            panelBottom.Location = new Point(12, 543);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1060, 72);
            panelBottom.TabIndex = 1;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Location = new Point(18, 15);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(155, 40);
            btnLapHoaDon.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnLapHoaDon.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnLapHoaDon.StateCommon.Border.Color1 = Color.Silver;
            btnLapHoaDon.StateCommon.Border.Color2 = Color.Silver;
            btnLapHoaDon.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnLapHoaDon.StateCommon.Border.Rounding = 6F;
            btnLapHoaDon.StateCommon.Content.ShortText.Color1 = Color.Blue;
            btnLapHoaDon.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnLapHoaDon.TabIndex = 0;
            btnLapHoaDon.Values.DropDownArrowColor = Color.Empty;
            btnLapHoaDon.Values.Text = "Lập hóa đơn mới...";
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(188, 15);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(135, 40);
            btnInHoaDon.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnInHoaDon.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnInHoaDon.StateCommon.Border.Color1 = Color.Silver;
            btnInHoaDon.StateCommon.Border.Color2 = Color.Silver;
            btnInHoaDon.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnInHoaDon.StateCommon.Border.Rounding = 6F;
            btnInHoaDon.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Values.DropDownArrowColor = Color.Empty;
            btnInHoaDon.Values.Text = "In hóa đơn...";
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(338, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnSua.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnSua.StateCommon.Border.Color1 = Color.Silver;
            btnSua.StateCommon.Border.Color2 = Color.Silver;
            btnSua.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnSua.StateCommon.Border.Rounding = 6F;
            btnSua.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnSua.TabIndex = 2;
            btnSua.Values.DropDownArrowColor = Color.Empty;
            btnSua.Values.Text = "Sửa...";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(463, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 40);
            btnXoa.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnXoa.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnXoa.StateCommon.Border.Color1 = Color.Silver;
            btnXoa.StateCommon.Border.Color2 = Color.Silver;
            btnXoa.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.StateCommon.Border.Rounding = 6F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.Red;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnXoa.TabIndex = 3;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(573, 15);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 40);
            btnThoat.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnThoat.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnThoat.StateCommon.Border.Color1 = Color.Silver;
            btnThoat.StateCommon.Border.Color2 = Color.Silver;
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.StateCommon.Border.Rounding = 6F;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnThoat.TabIndex = 4;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(683, 15);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 40);
            btnTimKiem.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnTimKiem.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnTimKiem.StateCommon.Border.Color1 = Color.Silver;
            btnTimKiem.StateCommon.Border.Color2 = Color.Silver;
            btnTimKiem.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.StateCommon.Border.Rounding = 6F;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm...";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(823, 15);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(130, 40);
            btnXuat.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnXuat.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnXuat.StateCommon.Border.Color1 = Color.Silver;
            btnXuat.StateCommon.Border.Color2 = Color.Silver;
            btnXuat.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.StateCommon.Border.Rounding = 6F;
            btnXuat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnXuat.TabIndex = 6;
            btnXuat.Values.DropDownArrowColor = Color.Empty;
            btnXuat.Values.Text = "Xuất Excel...";
            btnXuat.Click += btnXuat_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 627);
            Controls.Add(panelBottom);
            Controls.Add(grpDanhSach);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDanhSach;
        private DataGridView dgvHoaDon;
        private Panel panelBottom;
        private KryptonButton btnLapHoaDon;
        private KryptonButton btnInHoaDon;
        private KryptonButton btnSua;
        private KryptonButton btnXoa;
        private KryptonButton btnThoat;
        private KryptonButton btnTimKiem;
        private KryptonButton btnXuat;

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
    }
}