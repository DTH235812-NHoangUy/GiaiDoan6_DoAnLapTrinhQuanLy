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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            grpDanhSach = new GroupBox();
            dgvHoaDon = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();

            panelBottom = new Panel();
            btnInHoaDon = new KryptonButton();
            btnThoat = new KryptonButton();
            btnTimKiem = new KryptonButton();
            btnXuat = new KryptonButton();
            btnXoa = new KryptonButton();

            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();

            // grpDanhSach
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.Controls.Add(dgvHoaDon);
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(12, 12);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1060, 525);
            grpDanhSach.TabIndex = 0;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách hóa đơn";

            // dgvHoaDon
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BorderStyle = BorderStyle.Fixed3D;

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            dgvHoaDon.ColumnHeadersHeight = 40;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;

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
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;

            // ID
            ID.DataPropertyName = "ID";
            ID.FillWeight = 45F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;

            // HoVaTenNhanVien
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.FillWeight = 130F;
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;

            // HoVaTenKhachHang
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.FillWeight = 140F;
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;

            // NgayLap
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NgayLap.DefaultCellStyle = dataGridViewCellStyle3;
            NgayLap.FillWeight = 110F;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;

            // TongTienHoaDon
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Blue;
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            TongTienHoaDon.FillWeight = 120F;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;

            // XemChiTiet
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.LinkBehavior = LinkBehavior.HoverUnderline;
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            XemChiTiet.Resizable = DataGridViewTriState.True;
            XemChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            XemChiTiet.TrackVisitedState = false;

            // panelBottom
            panelBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(btnInHoaDon);
            panelBottom.Controls.Add(btnThoat);
            panelBottom.Controls.Add(btnTimKiem);
            panelBottom.Controls.Add(btnXuat);
            panelBottom.Controls.Add(btnXoa);
            panelBottom.Location = new Point(12, 543);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1060, 72);
            panelBottom.TabIndex = 1;

            // btnInHoaDon
            btnInHoaDon.Location = new Point(18, 15);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(135, 40);
            btnInHoaDon.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnInHoaDon.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnInHoaDon.StateCommon.Border.Color1 = Color.Silver;
            btnInHoaDon.StateCommon.Border.Color2 = Color.Silver;
            btnInHoaDon.StateCommon.Border.DrawBorders =
                PaletteDrawBorders.Top | PaletteDrawBorders.Bottom |
                PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnInHoaDon.StateCommon.Border.Rounding = 6F;
            btnInHoaDon.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnInHoaDon.TabIndex = 0;
            btnInHoaDon.Values.DropDownArrowColor = Color.Empty;
            btnInHoaDon.Values.Text = "In hóa đơn...";
            btnInHoaDon.Click += btnInHoaDon_Click;

            // btnThoat
            btnThoat.Location = new Point(168, 15);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 40);
            btnThoat.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnThoat.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnThoat.StateCommon.Border.Color1 = Color.Silver;
            btnThoat.StateCommon.Border.Color2 = Color.Silver;
            btnThoat.StateCommon.Border.DrawBorders =
                PaletteDrawBorders.Top | PaletteDrawBorders.Bottom |
                PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnThoat.StateCommon.Border.Rounding = 6F;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnThoat.TabIndex = 1;
            btnThoat.Values.DropDownArrowColor = Color.Empty;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            // btnTimKiem
            btnTimKiem.Location = new Point(283, 15);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 40);
            btnTimKiem.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnTimKiem.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnTimKiem.StateCommon.Border.Color1 = Color.Silver;
            btnTimKiem.StateCommon.Border.Color2 = Color.Silver;
            btnTimKiem.StateCommon.Border.DrawBorders =
                PaletteDrawBorders.Top | PaletteDrawBorders.Bottom |
                PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnTimKiem.StateCommon.Border.Rounding = 6F;
            btnTimKiem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Values.DropDownArrowColor = Color.Empty;
            btnTimKiem.Values.Text = "Tìm kiếm...";
            btnTimKiem.Click += btnTimKiem_Click;

            // btnXuat
            btnXuat.Location = new Point(423, 15);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(130, 40);
            btnXuat.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnXuat.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnXuat.StateCommon.Border.Color1 = Color.Silver;
            btnXuat.StateCommon.Border.Color2 = Color.Silver;
            btnXuat.StateCommon.Border.DrawBorders =
                PaletteDrawBorders.Top | PaletteDrawBorders.Bottom |
                PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXuat.StateCommon.Border.Rounding = 6F;
            btnXuat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnXuat.TabIndex = 3;
            btnXuat.Values.DropDownArrowColor = Color.Empty;
            btnXuat.Values.Text = "Xuất Excel...";
            btnXuat.Click += btnXuat_Click;

            // btnXoa
            btnXoa.Location = new Point(568, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnXoa.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnXoa.StateCommon.Border.Color1 = Color.Silver;
            btnXoa.StateCommon.Border.Color2 = Color.Silver;
            btnXoa.StateCommon.Border.DrawBorders =
                PaletteDrawBorders.Top | PaletteDrawBorders.Bottom |
                PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btnXoa.StateCommon.Border.Rounding = 6F;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F);
            btnXoa.TabIndex = 4;
            btnXoa.Values.DropDownArrowColor = Color.Empty;
            btnXoa.Values.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            // frmHoaDon
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
        private KryptonButton btnInHoaDon;
        private KryptonButton btnThoat;
        private KryptonButton btnTimKiem;
        private KryptonButton btnXuat;
        private KryptonButton btnXoa;

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
    }
}