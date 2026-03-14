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

            grpThongTinHoaDon = new GroupBox();
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChuHoaDon = new TextBox();

            grpThongTinChiTiet = new GroupBox();
            btnXoa = new KryptonButton();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            VeID = new DataGridViewTextBoxColumn();
            TenSuKien = new DataGridViewTextBoxColumn();
            TenSan = new DataGridViewTextBoxColumn();
            ViTriGhe = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();

            panelBottom = new Panel();
            btnLuuHoaDon = new KryptonButton();
            btnInHoaDon = new KryptonButton();
            btnThoat = new KryptonButton();

            grpThongTinHoaDon.SuspendLayout();
            grpThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();

            // grpThongTinHoaDon
            grpThongTinHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinHoaDon.Controls.Add(lblNhanVien);
            grpThongTinHoaDon.Controls.Add(cboNhanVien);
            grpThongTinHoaDon.Controls.Add(lblKhachHang);
            grpThongTinHoaDon.Controls.Add(cboKhachHang);
            grpThongTinHoaDon.Controls.Add(lblGhiChu);
            grpThongTinHoaDon.Controls.Add(txtGhiChuHoaDon);
            grpThongTinHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpThongTinHoaDon.Location = new Point(12, 12);
            grpThongTinHoaDon.Name = "grpThongTinHoaDon";
            grpThongTinHoaDon.Size = new Size(1160, 135);
            grpThongTinHoaDon.TabIndex = 0;
            grpThongTinHoaDon.TabStop = false;
            grpThongTinHoaDon.Text = "Thông tin hóa đơn";

            // lblNhanVien
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNhanVien.Location = new Point(18, 42);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(122, 23);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Nhân viên lập:";

            // cboNhanVien
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(160, 38);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(410, 31);
            cboNhanVien.TabIndex = 1;

            // lblKhachHang
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblKhachHang.Location = new Point(620, 42);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(102, 23);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng:";

            // cboKhachHang
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(738, 38);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(390, 31);
            cboKhachHang.TabIndex = 3;

            // lblGhiChu
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGhiChu.Location = new Point(18, 92);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(128, 23);
            lblGhiChu.TabIndex = 4;
            lblGhiChu.Text = "Ghi chú hóa đơn:";

            // txtGhiChuHoaDon
            txtGhiChuHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGhiChuHoaDon.Location = new Point(160, 88);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(968, 30);
            txtGhiChuHoaDon.TabIndex = 5;

            // grpThongTinChiTiet
            grpThongTinChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinChiTiet.Controls.Add(btnXoa);
            grpThongTinChiTiet.Controls.Add(dataGridView);
            grpThongTinChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpThongTinChiTiet.Location = new Point(12, 153);
            grpThongTinChiTiet.Name = "grpThongTinChiTiet";
            grpThongTinChiTiet.Size = new Size(1160, 480);
            grpThongTinChiTiet.TabIndex = 1;
            grpThongTinChiTiet.TabStop = false;
            grpThongTinChiTiet.Text = "Danh sách vé trong hóa đơn";

            // btnXoa
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(1045, 32);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 38);
            btnXoa.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnXoa.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnXoa.StateCommon.Border.Color1 = Color.Silver;
            btnXoa.StateCommon.Border.Color2 = Color.Silver;
            btnXoa.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnXoa.StateCommon.Border.Rounding = 6F;
            btnXoa.StateCommon.Content.ShortText.Color1 = Color.Red;
            btnXoa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.TabIndex = 0;
            btnXoa.Values.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            // dataGridView
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ControlDark;
            dataGridView.ColumnHeadersHeight = 38;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, VeID, TenSuKien, TenSan, ViTriGhe, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(18, 84);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 32;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1117, 375);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;

            // ID
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID ChiTiet";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;

            // VeID
            VeID.DataPropertyName = "VeID";
            VeID.FillWeight = 55F;
            VeID.HeaderText = "Mã vé";
            VeID.Name = "VeID";
            VeID.ReadOnly = true;

            // TenSuKien
            TenSuKien.DataPropertyName = "TenSuKien";
            TenSuKien.FillWeight = 160F;
            TenSuKien.HeaderText = "Tên sự kiện";
            TenSuKien.Name = "TenSuKien";
            TenSuKien.ReadOnly = true;

            // TenSan
            TenSan.DataPropertyName = "TenSan";
            TenSan.FillWeight = 120F;
            TenSan.HeaderText = "Tên sân";
            TenSan.Name = "TenSan";
            TenSan.ReadOnly = true;

            // ViTriGhe
            ViTriGhe.DataPropertyName = "ViTriGhe";
            ViTriGhe.FillWeight = 160F;
            ViTriGhe.HeaderText = "Vị trí ghế";
            ViTriGhe.Name = "ViTriGhe";
            ViTriGhe.ReadOnly = true;

            // DonGiaBan
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle3;
            DonGiaBan.FillWeight = 110F;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;

            // SoLuongBan
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuongBan.FillWeight = 90F;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;

            // ThanhTien
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.FillWeight = 120F;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;

            // panelBottom
            panelBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBottom.Controls.Add(btnLuuHoaDon);
            panelBottom.Controls.Add(btnInHoaDon);
            panelBottom.Controls.Add(btnThoat);
            panelBottom.Location = new Point(12, 639);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1160, 62);
            panelBottom.TabIndex = 2;

            // btnLuuHoaDon
            btnLuuHoaDon.Location = new Point(320, 12);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(160, 38);
            btnLuuHoaDon.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnLuuHoaDon.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnLuuHoaDon.StateCommon.Border.Color1 = Color.Silver;
            btnLuuHoaDon.StateCommon.Border.Color2 = Color.Silver;
            btnLuuHoaDon.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnLuuHoaDon.StateCommon.Border.Rounding = 6F;
            btnLuuHoaDon.StateCommon.Content.ShortText.Color1 = Color.Blue;
            btnLuuHoaDon.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuuHoaDon.TabIndex = 0;
            btnLuuHoaDon.Values.Text = "Lưu hóa đơn";
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;

            // btnInHoaDon
            btnInHoaDon.Location = new Point(500, 12);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(145, 38);
            btnInHoaDon.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnInHoaDon.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnInHoaDon.StateCommon.Border.Color1 = Color.Silver;
            btnInHoaDon.StateCommon.Border.Color2 = Color.Silver;
            btnInHoaDon.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnInHoaDon.StateCommon.Border.Rounding = 6F;
            btnInHoaDon.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Values.Text = "In hóa đơn...";
            btnInHoaDon.Click += btnInHoaDon_Click;

            // btnThoat
            btnThoat.Location = new Point(665, 12);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 38);
            btnThoat.StateCommon.Back.Color1 = Color.WhiteSmoke;
            btnThoat.StateCommon.Back.Color2 = Color.WhiteSmoke;
            btnThoat.StateCommon.Border.Color1 = Color.Silver;
            btnThoat.StateCommon.Border.Color2 = Color.Silver;
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.StateCommon.Border.Rounding = 6F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.Red;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.TabIndex = 2;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            // frmHoaDon_ChiTiet
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(panelBottom);
            Controls.Add(grpThongTinChiTiet);
            Controls.Add(grpThongTinHoaDon);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;

            grpThongTinHoaDon.ResumeLayout(false);
            grpThongTinHoaDon.PerformLayout();
            grpThongTinChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinHoaDon;
        private Label lblNhanVien;
        private ComboBox cboNhanVien;
        private Label lblKhachHang;
        private ComboBox cboKhachHang;
        private Label lblGhiChu;
        private TextBox txtGhiChuHoaDon;

        private GroupBox grpThongTinChiTiet;
        private KryptonButton btnXoa;
        private DataGridView dataGridView;

        private Panel panelBottom;
        private KryptonButton btnLuuHoaDon;
        private KryptonButton btnInHoaDon;
        private KryptonButton btnThoat;

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn VeID;
        private DataGridViewTextBoxColumn TenSuKien;
        private DataGridViewTextBoxColumn TenSan;
        private DataGridViewTextBoxColumn ViTriGhe;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}