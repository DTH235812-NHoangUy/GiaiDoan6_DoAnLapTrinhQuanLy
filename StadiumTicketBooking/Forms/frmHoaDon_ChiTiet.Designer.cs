using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmHoaDon_ChiTiet
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
            txtHoaDonID = new KryptonTextBox();
            txtTongTien = new KryptonTextBox();
            lblHoaDonID = new Label();
            lblTongTien = new Label();
            btnTaiLai = new KryptonButton();
            btnThoat = new KryptonButton();

            grpDanhSach = new GroupBox();
            dgvChiTiet = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colHoaDonID = new DataGridViewTextBoxColumn();
            colTenSuKien = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colViTriGhe = new DataGridViewTextBoxColumn();
            colDonGiaBan = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();

            grpThongTin.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.BackColor = Color.White;
            grpThongTin.Controls.Add(txtHoaDonID);
            grpThongTin.Controls.Add(txtTongTien);
            grpThongTin.Controls.Add(lblHoaDonID);
            grpThongTin.Controls.Add(lblTongTien);
            grpThongTin.Controls.Add(btnTaiLai);
            grpThongTin.Controls.Add(btnThoat);
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.ForeColor = Color.FromArgb(45, 62, 80);
            grpThongTin.Location = new Point(20, 15);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1240, 100);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin hóa đơn";
            // 
            // txtHoaDonID
            // 
            txtHoaDonID.Location = new Point(140, 32);
            txtHoaDonID.Name = "txtHoaDonID";
            txtHoaDonID.ReadOnly = true;
            txtHoaDonID.Size = new Size(220, 34);
            txtHoaDonID.StateCommon.Back.Color1 = Color.FromArgb(245, 246, 250);
            txtHoaDonID.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtHoaDonID.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtHoaDonID.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtHoaDonID.StateCommon.Border.Rounding = 6F;
            txtHoaDonID.StateCommon.Content.Color1 = Color.FromArgb(99, 110, 114);
            txtHoaDonID.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtHoaDonID.TabIndex = 0;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(500, 32);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(220, 34);
            txtTongTien.StateCommon.Back.Color1 = Color.FromArgb(245, 246, 250);
            txtTongTien.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtTongTien.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtTongTien.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtTongTien.StateCommon.Border.Rounding = 6F;
            txtTongTien.StateCommon.Content.Color1 = Color.FromArgb(99, 110, 114);
            txtTongTien.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtTongTien.TabIndex = 1;
            // 
            // lblHoaDonID
            // 
            lblHoaDonID.AutoSize = true;
            lblHoaDonID.Font = new Font("Segoe UI", 10F);
            lblHoaDonID.ForeColor = Color.FromArgb(45, 52, 54);
            lblHoaDonID.Location = new Point(30, 38);
            lblHoaDonID.Name = "lblHoaDonID";
            lblHoaDonID.Size = new Size(99, 23);
            lblHoaDonID.TabIndex = 0;
            lblHoaDonID.Text = "Mã hóa đơn:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10F);
            lblTongTien.ForeColor = Color.FromArgb(45, 52, 54);
            lblTongTien.Location = new Point(380, 38);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(85, 23);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(960, 28);
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
            btnTaiLai.TabIndex = 2;
            btnTaiLai.Values.Text = "Tải lại";
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1110, 28);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(120, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 3;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSach.BackColor = Color.White;
            grpDanhSach.Controls.Add(dgvChiTiet);
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.ForeColor = Color.FromArgb(45, 62, 80);
            grpDanhSach.Location = new Point(20, 130);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1240, 560);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách chi tiết hóa đơn";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.BorderStyle = BorderStyle.None;
            dgvChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiTiet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChiTiet.ColumnHeadersHeight = 40;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colSTT, colHoaDonID, colTenSuKien, colTenSan, colViTriGhe, colDonGiaBan, colThanhTien });
            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.Location = new Point(10, 30);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowTemplate.Height = 35;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(1220, 520);
            dgvChiTiet.TabIndex = 0;
            headerStyle.BackColor = Color.FromArgb(108, 92, 231);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.SelectionBackColor = Color.FromArgb(108, 92, 231);
            headerStyle.SelectionForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = headerStyle;
            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.SelectionBackColor = Color.FromArgb(223, 230, 233);
            cellStyle.SelectionForeColor = Color.Black;
            dgvChiTiet.DefaultCellStyle = cellStyle;
            dgvChiTiet.GridColor = Color.FromArgb(230, 230, 230);
            // 
            // colSTT
            // 
            colSTT.DataPropertyName = "STT";
            colSTT.HeaderText = "STT";
            colSTT.FillWeight = 8F;
            colSTT.Name = "colSTT";
            // 
            // colHoaDonID
            // 
            colHoaDonID.DataPropertyName = "HoaDonID";
            colHoaDonID.HeaderText = "Mã HĐ";
            colHoaDonID.FillWeight = 10F;
            colHoaDonID.Name = "colHoaDonID";
            // 
            // colTenSuKien
            // 
            colTenSuKien.DataPropertyName = "TenSuKien";
            colTenSuKien.HeaderText = "Tên Sự Kiện";
            colTenSuKien.FillWeight = 22F;
            colTenSuKien.Name = "colTenSuKien";
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.HeaderText = "Tên Sân";
            colTenSan.FillWeight = 16F;
            colTenSan.Name = "colTenSan";
            // 
            // colViTriGhe
            // 
            colViTriGhe.DataPropertyName = "ViTriGhe";
            colViTriGhe.HeaderText = "Vị Trí Ghế";
            colViTriGhe.FillWeight = 22F;
            colViTriGhe.Name = "colViTriGhe";
            // 
            // colDonGiaBan
            // 
            colDonGiaBan.DataPropertyName = "DonGiaBan";
            colDonGiaBan.HeaderText = "Đơn Giá Bán";
            colDonGiaBan.FillWeight = 11F;
            colDonGiaBan.Name = "colDonGiaBan";
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.FillWeight = 11F;
            colThanhTien.Name = "colThanhTien";
            // 
            // frmHoaDon_ChiTiet
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
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết Hóa Đơn";
            Load += frmHoaDon_ChiTiet_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private KryptonTextBox txtHoaDonID;
        private KryptonTextBox txtTongTien;
        private Label lblHoaDonID;
        private Label lblTongTien;
        private KryptonButton btnTaiLai;
        private KryptonButton btnThoat;

        private GroupBox grpDanhSach;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colHoaDonID;
        private DataGridViewTextBoxColumn colTenSuKien;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colViTriGhe;
        private DataGridViewTextBoxColumn colDonGiaBan;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}