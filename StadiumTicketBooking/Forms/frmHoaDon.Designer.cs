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

            grpThongTin = new GroupBox();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            lblTuNgay = new Label();
            lblDenNgay = new Label();
            btnLoc = new KryptonButton();
            btnTaiLai = new KryptonButton();
            btnXemChiTiet = new KryptonButton();
            btnThoat = new KryptonButton();

            grpDanhSach = new GroupBox();
            dgvHoaDon = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNhanVien = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();

            grpThongTin.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.BackColor = Color.White;
            grpThongTin.Controls.Add(dtpTuNgay);
            grpThongTin.Controls.Add(dtpDenNgay);
            grpThongTin.Controls.Add(lblTuNgay);
            grpThongTin.Controls.Add(lblDenNgay);
            grpThongTin.Controls.Add(btnLoc);
            grpThongTin.Controls.Add(btnTaiLai);
            grpThongTin.Controls.Add(btnXemChiTiet);
            grpThongTin.Controls.Add(btnThoat);
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.ForeColor = Color.FromArgb(45, 62, 80);
            grpThongTin.Location = new Point(20, 15);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1240, 110);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin lọc hóa đơn";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 10F);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(140, 35);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(180, 30);
            dtpTuNgay.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 10F);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(450, 35);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(180, 30);
            dtpDenNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI", 10F);
            lblTuNgay.ForeColor = Color.FromArgb(45, 52, 54);
            lblTuNgay.Location = new Point(30, 39);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(76, 23);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày:";
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 10F);
            lblDenNgay.ForeColor = Color.FromArgb(45, 52, 54);
            lblDenNgay.Location = new Point(350, 39);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(87, 23);
            lblDenNgay.TabIndex = 1;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(720, 28);
            btnLoc.Name = "btnLoc";
            btnLoc.OverrideDefault.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnLoc.OverrideDefault.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnLoc.OverrideDefault.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnLoc.OverrideDefault.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnLoc.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnLoc.OverrideDefault.Border.Rounding = 8F;
            btnLoc.Size = new Size(130, 40);
            btnLoc.StateCommon.Back.Color1 = Color.FromArgb(108, 92, 231);
            btnLoc.StateCommon.Back.Color2 = Color.FromArgb(108, 92, 231);
            btnLoc.StateCommon.Border.Color1 = Color.FromArgb(108, 92, 231);
            btnLoc.StateCommon.Border.Color2 = Color.FromArgb(108, 92, 231);
            btnLoc.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnLoc.StateCommon.Border.Rounding = 8F;
            btnLoc.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLoc.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoc.TabIndex = 2;
            btnLoc.Values.Text = "Lọc";
            btnLoc.Click += btnLoc_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(870, 28);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.OverrideDefault.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnTaiLai.OverrideDefault.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnTaiLai.OverrideDefault.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnTaiLai.OverrideDefault.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnTaiLai.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnTaiLai.OverrideDefault.Border.Rounding = 8F;
            btnTaiLai.Size = new Size(130, 40);
            btnTaiLai.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
            btnTaiLai.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            btnTaiLai.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219);
            btnTaiLai.StateCommon.Border.Color2 = Color.FromArgb(52, 152, 219);
            btnTaiLai.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnTaiLai.StateCommon.Border.Rounding = 8F;
            btnTaiLai.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTaiLai.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaiLai.TabIndex = 3;
            btnTaiLai.Values.Text = "Tải lại";
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Location = new Point(1020, 28);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.OverrideDefault.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.OverrideDefault.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.OverrideDefault.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.OverrideDefault.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnXemChiTiet.OverrideDefault.Border.Rounding = 8F;
            btnXemChiTiet.Size = new Size(130, 40);
            btnXemChiTiet.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnXemChiTiet.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnXemChiTiet.StateCommon.Border.Rounding = 8F;
            btnXemChiTiet.StateCommon.Content.ShortText.Color1 = Color.White;
            btnXemChiTiet.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXemChiTiet.TabIndex = 4;
            btnXemChiTiet.Values.Text = "Xem chi tiết";
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1160, 28);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(70, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 5;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.BackColor = Color.White;
            grpDanhSach.Controls.Add(dgvHoaDon);
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.ForeColor = Color.FromArgb(45, 62, 80);
            grpDanhSach.Location = new Point(20, 140);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1240, 550);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dgvHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHoaDon.ColumnHeadersHeight = 40;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colID, colNhanVien, colKhachHang, colNgayLap, colGhiChu, colTongTien });
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.Location = new Point(10, 30);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowTemplate.Height = 35;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1220, 510);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.DoubleClick += btnXemChiTiet_Click;
            headerStyle.BackColor = Color.FromArgb(108, 92, 231);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.SelectionBackColor = Color.FromArgb(108, 92, 231);
            headerStyle.SelectionForeColor = Color.White;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = headerStyle;
            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.SelectionBackColor = Color.FromArgb(223, 230, 233);
            cellStyle.SelectionForeColor = Color.Black;
            dgvHoaDon.DefaultCellStyle = cellStyle;
            dgvHoaDon.GridColor = Color.FromArgb(230, 230, 230);
            // 
            // columns
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.FillWeight = 8F;
            colID.Name = "colID";

            colNhanVien.DataPropertyName = "HoVaTenNhanVien";
            colNhanVien.HeaderText = "Nhân Viên";
            colNhanVien.FillWeight = 20F;
            colNhanVien.Name = "colNhanVien";

            colKhachHang.DataPropertyName = "HoVaTenKhachHang";
            colKhachHang.HeaderText = "Khách Hàng";
            colKhachHang.FillWeight = 20F;
            colKhachHang.Name = "colKhachHang";

            colNgayLap.DataPropertyName = "NgayLap";
            colNgayLap.HeaderText = "Ngày Lập";
            colNgayLap.FillWeight = 18F;
            colNgayLap.Name = "colNgayLap";

            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.FillWeight = 19F;
            colGhiChu.Name = "colGhiChu";

            colTongTien.DataPropertyName = "TongTien";
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.FillWeight = 15F;
            colTongTien.Name = "colTongTien";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpDanhSach);
            Controls.Add(grpThongTin);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Hóa Đơn";
            Load += frmHoaDon_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Label lblTuNgay;
        private Label lblDenNgay;
        private KryptonButton btnLoc;
        private KryptonButton btnTaiLai;
        private KryptonButton btnXemChiTiet;
        private KryptonButton btnThoat;

        private GroupBox grpDanhSach;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNhanVien;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colGhiChu;
        private DataGridViewTextBoxColumn colTongTien;
    }
}