using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace StadiumTicketBooking.Forms
{
    partial class frmDatVe
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
            DataGridViewCellStyle headerStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();

            grpThongTinDatVe = new GroupBox();
            cboNhanVien = new ComboBox();
            cboKhachHang = new ComboBox();
            cboSuKien = new ComboBox();
            dtpNgayLap = new DateTimePicker();
            txtTongTien = new KryptonTextBox();
            txtGhiChu = new KryptonTextBox();
            lblNhanVien = new Label();
            lblKhachHang = new Label();
            lblSuKien = new Label();
            lblNgayLap = new Label();
            lblTongTien = new Label();
            lblGhiChu = new Label();
            btnTaoMoi = new KryptonButton();
            btnThanhToan = new KryptonButton();
            btnHuyDon = new KryptonButton();
            btnThoat = new KryptonButton();

            grpVeTrong = new GroupBox();
            dgvVeTrong = new DataGridView();
            colVeID = new DataGridViewTextBoxColumn();
            colTenSuKien = new DataGridViewTextBoxColumn();
            colSoGhe = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colGiaVe = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            btnChonVe = new KryptonButton();

            grpVeDaChon = new GroupBox();
            dgvVeDaChon = new DataGridView();
            colVeIDDaChon = new DataGridViewTextBoxColumn();
            colTenSuKienDaChon = new DataGridViewTextBoxColumn();
            colSoGheDaChon = new DataGridViewTextBoxColumn();
            colTenKhuVucDaChon = new DataGridViewTextBoxColumn();
            colGiaVeDaChon = new DataGridViewTextBoxColumn();
            btnBoVe = new KryptonButton();

            grpThongTinDatVe.SuspendLayout();
            grpVeTrong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeTrong).BeginInit();
            grpVeDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeDaChon).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinDatVe
            // 
            grpThongTinDatVe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinDatVe.BackColor = Color.White;
            grpThongTinDatVe.Controls.Add(cboNhanVien);
            grpThongTinDatVe.Controls.Add(cboKhachHang);
            grpThongTinDatVe.Controls.Add(cboSuKien);
            grpThongTinDatVe.Controls.Add(dtpNgayLap);
            grpThongTinDatVe.Controls.Add(txtTongTien);
            grpThongTinDatVe.Controls.Add(txtGhiChu);
            grpThongTinDatVe.Controls.Add(lblNhanVien);
            grpThongTinDatVe.Controls.Add(lblKhachHang);
            grpThongTinDatVe.Controls.Add(lblSuKien);
            grpThongTinDatVe.Controls.Add(lblNgayLap);
            grpThongTinDatVe.Controls.Add(lblTongTien);
            grpThongTinDatVe.Controls.Add(lblGhiChu);
            grpThongTinDatVe.Controls.Add(btnTaoMoi);
            grpThongTinDatVe.Controls.Add(btnThanhToan);
            grpThongTinDatVe.Controls.Add(btnHuyDon);
            grpThongTinDatVe.Controls.Add(btnThoat);
            grpThongTinDatVe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinDatVe.ForeColor = Color.FromArgb(45, 62, 80);
            grpThongTinDatVe.Location = new Point(20, 15);
            grpThongTinDatVe.Name = "grpThongTinDatVe";
            grpThongTinDatVe.Size = new Size(1240, 220);
            grpThongTinDatVe.TabIndex = 0;
            grpThongTinDatVe.TabStop = false;
            grpThongTinDatVe.Text = "Thông tin đặt vé";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Segoe UI", 10F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(170, 31);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(300, 31);
            cboNhanVien.TabIndex = 0;
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Font = new Font("Segoe UI", 10F);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(170, 78);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(300, 31);
            cboKhachHang.TabIndex = 1;
            // 
            // cboSuKien
            // 
            cboSuKien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuKien.Font = new Font("Segoe UI", 10F);
            cboSuKien.FormattingEnabled = true;
            cboSuKien.Location = new Point(170, 125);
            cboSuKien.Name = "cboSuKien";
            cboSuKien.Size = new Size(300, 31);
            cboSuKien.TabIndex = 2;
            cboSuKien.SelectedIndexChanged += cboSuKien_SelectedIndexChanged;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayLap.Font = new Font("Segoe UI", 10F);
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.Location = new Point(650, 31);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(220, 30);
            dtpNgayLap.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(650, 78);
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
            txtTongTien.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(650, 125);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(220, 34);
            txtGhiChu.StateCommon.Border.Color1 = Color.FromArgb(210, 218, 226);
            txtGhiChu.StateCommon.Border.Color2 = Color.FromArgb(210, 218, 226);
            txtGhiChu.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            txtGhiChu.StateCommon.Border.Rounding = 6F;
            txtGhiChu.StateCommon.Content.Color1 = Color.FromArgb(45, 52, 54);
            txtGhiChu.StateCommon.Content.Font = new Font("Segoe UI", 10F);
            txtGhiChu.TabIndex = 5;
            // 
            // labels
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 10F);
            lblNhanVien.ForeColor = Color.FromArgb(45, 52, 54);
            lblNhanVien.Location = new Point(30, 37);
            lblNhanVien.Text = "Nhân viên:";
            //
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 10F);
            lblKhachHang.ForeColor = Color.FromArgb(45, 52, 54);
            lblKhachHang.Location = new Point(30, 84);
            lblKhachHang.Text = "Khách hàng:";
            //
            lblSuKien.AutoSize = true;
            lblSuKien.Font = new Font("Segoe UI", 10F);
            lblSuKien.ForeColor = Color.FromArgb(45, 52, 54);
            lblSuKien.Location = new Point(30, 131);
            lblSuKien.Text = "Sự kiện:";
            //
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 10F);
            lblNgayLap.ForeColor = Color.FromArgb(45, 52, 54);
            lblNgayLap.Location = new Point(530, 37);
            lblNgayLap.Text = "Ngày lập:";
            //
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10F);
            lblTongTien.ForeColor = Color.FromArgb(45, 52, 54);
            lblTongTien.Location = new Point(530, 84);
            lblTongTien.Text = "Tổng tiền:";
            //
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 10F);
            lblGhiChu.ForeColor = Color.FromArgb(45, 52, 54);
            lblGhiChu.Location = new Point(530, 131);
            lblGhiChu.Text = "Ghi chú:";
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Location = new Point(930, 28);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.OverrideDefault.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.OverrideDefault.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.OverrideDefault.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.OverrideDefault.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnTaoMoi.OverrideDefault.Border.Rounding = 8F;
            btnTaoMoi.Size = new Size(130, 40);
            btnTaoMoi.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnTaoMoi.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnTaoMoi.StateCommon.Border.Rounding = 8F;
            btnTaoMoi.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTaoMoi.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTaoMoi.TabIndex = 6;
            btnTaoMoi.Values.Text = "Tạo mới";
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(1080, 28);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.OverrideDefault.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnThanhToan.OverrideDefault.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnThanhToan.OverrideDefault.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnThanhToan.OverrideDefault.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnThanhToan.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThanhToan.OverrideDefault.Border.Rounding = 8F;
            btnThanhToan.Size = new Size(130, 40);
            btnThanhToan.StateCommon.Back.Color1 = Color.FromArgb(46, 204, 113);
            btnThanhToan.StateCommon.Back.Color2 = Color.FromArgb(46, 204, 113);
            btnThanhToan.StateCommon.Border.Color1 = Color.FromArgb(46, 204, 113);
            btnThanhToan.StateCommon.Border.Color2 = Color.FromArgb(46, 204, 113);
            btnThanhToan.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThanhToan.StateCommon.Border.Rounding = 8F;
            btnThanhToan.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThanhToan.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThanhToan.TabIndex = 7;
            btnThanhToan.Values.Text = "Thanh toán";
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuyDon
            // 
            btnHuyDon.Location = new Point(930, 82);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.OverrideDefault.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuyDon.OverrideDefault.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuyDon.OverrideDefault.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuyDon.OverrideDefault.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuyDon.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnHuyDon.OverrideDefault.Border.Rounding = 8F;
            btnHuyDon.Size = new Size(130, 40);
            btnHuyDon.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18);
            btnHuyDon.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            btnHuyDon.StateCommon.Border.Color1 = Color.FromArgb(243, 156, 18);
            btnHuyDon.StateCommon.Border.Color2 = Color.FromArgb(243, 156, 18);
            btnHuyDon.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnHuyDon.StateCommon.Border.Rounding = 8F;
            btnHuyDon.StateCommon.Content.ShortText.Color1 = Color.White;
            btnHuyDon.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuyDon.TabIndex = 8;
            btnHuyDon.Values.Text = "Hủy đơn";
            btnHuyDon.Click += btnHuyDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1080, 82);
            btnThoat.Name = "btnThoat";
            btnThoat.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.OverrideDefault.Border.Rounding = 8F;
            btnThoat.Size = new Size(130, 40);
            btnThoat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnThoat.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnThoat.StateCommon.Border.Rounding = 8F;
            btnThoat.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThoat.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.TabIndex = 9;
            btnThoat.Values.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // grpVeTrong
            // 
            grpVeTrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpVeTrong.BackColor = Color.White;
            grpVeTrong.Controls.Add(dgvVeTrong);
            grpVeTrong.Controls.Add(btnChonVe);
            grpVeTrong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpVeTrong.ForeColor = Color.FromArgb(45, 62, 80);
            grpVeTrong.Location = new Point(20, 250);
            grpVeTrong.Name = "grpVeTrong";
            grpVeTrong.Size = new Size(610, 440);
            grpVeTrong.TabIndex = 1;
            grpVeTrong.TabStop = false;
            grpVeTrong.Text = "Danh sách vé còn trống";
            // 
            // dgvVeTrong
            // 
            dgvVeTrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVeTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeTrong.BackgroundColor = Color.White;
            dgvVeTrong.BorderStyle = BorderStyle.None;
            dgvVeTrong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVeTrong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVeTrong.ColumnHeadersHeight = 40;
            dgvVeTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVeTrong.Columns.AddRange(new DataGridViewColumn[] { colVeID, colTenSuKien, colSoGhe, colTenKhuVuc, colTenSan, colGiaVe, colTrangThai });
            dgvVeTrong.EnableHeadersVisualStyles = false;
            dgvVeTrong.Location = new Point(10, 30);
            dgvVeTrong.MultiSelect = false;
            dgvVeTrong.Name = "dgvVeTrong";
            dgvVeTrong.RowHeadersVisible = false;
            dgvVeTrong.RowTemplate.Height = 35;
            dgvVeTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeTrong.Size = new Size(590, 350);
            dgvVeTrong.TabIndex = 0;
            dgvVeTrong.DoubleClick += btnChonVe_Click;
            headerStyle1.BackColor = Color.FromArgb(108, 92, 231);
            headerStyle1.ForeColor = Color.White;
            headerStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle1.SelectionBackColor = Color.FromArgb(108, 92, 231);
            headerStyle1.SelectionForeColor = Color.White;
            dgvVeTrong.ColumnHeadersDefaultCellStyle = headerStyle1;
            cellStyle1.Font = new Font("Segoe UI", 10F);
            cellStyle1.SelectionBackColor = Color.FromArgb(223, 230, 233);
            cellStyle1.SelectionForeColor = Color.Black;
            dgvVeTrong.DefaultCellStyle = cellStyle1;
            dgvVeTrong.GridColor = Color.FromArgb(230, 230, 230);
            // 
            // btnChonVe
            // 
            btnChonVe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChonVe.Location = new Point(450, 390);
            btnChonVe.Name = "btnChonVe";
            btnChonVe.OverrideDefault.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnChonVe.OverrideDefault.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnChonVe.OverrideDefault.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnChonVe.OverrideDefault.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnChonVe.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnChonVe.OverrideDefault.Border.Rounding = 8F;
            btnChonVe.Size = new Size(150, 40);
            btnChonVe.StateCommon.Back.Color1 = Color.FromArgb(39, 174, 96);
            btnChonVe.StateCommon.Back.Color2 = Color.FromArgb(39, 174, 96);
            btnChonVe.StateCommon.Border.Color1 = Color.FromArgb(39, 174, 96);
            btnChonVe.StateCommon.Border.Color2 = Color.FromArgb(39, 174, 96);
            btnChonVe.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnChonVe.StateCommon.Border.Rounding = 8F;
            btnChonVe.StateCommon.Content.ShortText.Color1 = Color.White;
            btnChonVe.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChonVe.TabIndex = 1;
            btnChonVe.Values.Text = "Chọn vé";
            btnChonVe.Click += btnChonVe_Click;
            // 
            // grpVeDaChon
            // 
            grpVeDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpVeDaChon.BackColor = Color.White;
            grpVeDaChon.Controls.Add(dgvVeDaChon);
            grpVeDaChon.Controls.Add(btnBoVe);
            grpVeDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpVeDaChon.ForeColor = Color.FromArgb(45, 62, 80);
            grpVeDaChon.Location = new Point(650, 250);
            grpVeDaChon.Name = "grpVeDaChon";
            grpVeDaChon.Size = new Size(610, 440);
            grpVeDaChon.TabIndex = 2;
            grpVeDaChon.TabStop = false;
            grpVeDaChon.Text = "Danh sách vé đã chọn";
            // 
            // dgvVeDaChon
            // 
            dgvVeDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVeDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeDaChon.BackgroundColor = Color.White;
            dgvVeDaChon.BorderStyle = BorderStyle.None;
            dgvVeDaChon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVeDaChon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVeDaChon.ColumnHeadersHeight = 40;
            dgvVeDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVeDaChon.Columns.AddRange(new DataGridViewColumn[] { colVeIDDaChon, colTenSuKienDaChon, colSoGheDaChon, colTenKhuVucDaChon, colGiaVeDaChon });
            dgvVeDaChon.EnableHeadersVisualStyles = false;
            dgvVeDaChon.Location = new Point(10, 30);
            dgvVeDaChon.MultiSelect = false;
            dgvVeDaChon.Name = "dgvVeDaChon";
            dgvVeDaChon.RowHeadersVisible = false;
            dgvVeDaChon.RowTemplate.Height = 35;
            dgvVeDaChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeDaChon.Size = new Size(590, 350);
            dgvVeDaChon.TabIndex = 0;
            headerStyle2.BackColor = Color.FromArgb(108, 92, 231);
            headerStyle2.ForeColor = Color.White;
            headerStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle2.SelectionBackColor = Color.FromArgb(108, 92, 231);
            headerStyle2.SelectionForeColor = Color.White;
            dgvVeDaChon.ColumnHeadersDefaultCellStyle = headerStyle2;
            cellStyle2.Font = new Font("Segoe UI", 10F);
            cellStyle2.SelectionBackColor = Color.FromArgb(223, 230, 233);
            cellStyle2.SelectionForeColor = Color.Black;
            dgvVeDaChon.DefaultCellStyle = cellStyle2;
            dgvVeDaChon.GridColor = Color.FromArgb(230, 230, 230);
            // 
            // btnBoVe
            // 
            btnBoVe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBoVe.Location = new Point(450, 390);
            btnBoVe.Name = "btnBoVe";
            btnBoVe.OverrideDefault.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnBoVe.OverrideDefault.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnBoVe.OverrideDefault.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnBoVe.OverrideDefault.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnBoVe.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.All;
            btnBoVe.OverrideDefault.Border.Rounding = 8F;
            btnBoVe.Size = new Size(150, 40);
            btnBoVe.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60);
            btnBoVe.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            btnBoVe.StateCommon.Border.Color1 = Color.FromArgb(231, 76, 60);
            btnBoVe.StateCommon.Border.Color2 = Color.FromArgb(231, 76, 60);
            btnBoVe.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnBoVe.StateCommon.Border.Rounding = 8F;
            btnBoVe.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBoVe.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBoVe.TabIndex = 1;
            btnBoVe.Values.Text = "Bỏ vé";
            btnBoVe.Click += btnBoVe_Click;
            // 
            // columns dgvVeTrong
            // 
            colVeID.DataPropertyName = "ID";
            colVeID.HeaderText = "ID";
            colVeID.FillWeight = 8F;
            colVeID.Name = "colVeID";

            colTenSuKien.DataPropertyName = "TenSuKien";
            colTenSuKien.HeaderText = "Sự Kiện";
            colTenSuKien.FillWeight = 25F;
            colTenSuKien.Name = "colTenSuKien";

            colSoGhe.DataPropertyName = "SoGhe";
            colSoGhe.HeaderText = "Ghế";
            colSoGhe.FillWeight = 12F;
            colSoGhe.Name = "colSoGhe";

            colTenKhuVuc.DataPropertyName = "TenKhuVuc";
            colTenKhuVuc.HeaderText = "Khu Vực";
            colTenKhuVuc.FillWeight = 18F;
            colTenKhuVuc.Name = "colTenKhuVuc";

            colTenSan.DataPropertyName = "TenSan";
            colTenSan.HeaderText = "Sân";
            colTenSan.FillWeight = 18F;
            colTenSan.Name = "colTenSan";

            colGiaVe.DataPropertyName = "GiaVe";
            colGiaVe.HeaderText = "Giá Vé";
            colGiaVe.FillWeight = 12F;
            colGiaVe.Name = "colGiaVe";

            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.FillWeight = 15F;
            colTrangThai.Name = "colTrangThai";
            // 
            // columns dgvVeDaChon
            // 
            colVeIDDaChon.DataPropertyName = "VeID";
            colVeIDDaChon.HeaderText = "ID";
            colVeIDDaChon.FillWeight = 10F;
            colVeIDDaChon.Name = "colVeIDDaChon";

            colTenSuKienDaChon.DataPropertyName = "TenSuKien";
            colTenSuKienDaChon.HeaderText = "Sự Kiện";
            colTenSuKienDaChon.FillWeight = 30F;
            colTenSuKienDaChon.Name = "colTenSuKienDaChon";

            colSoGheDaChon.DataPropertyName = "SoGhe";
            colSoGheDaChon.HeaderText = "Ghế";
            colSoGheDaChon.FillWeight = 15F;
            colSoGheDaChon.Name = "colSoGheDaChon";

            colTenKhuVucDaChon.DataPropertyName = "TenKhuVuc";
            colTenKhuVucDaChon.HeaderText = "Khu Vực";
            colTenKhuVucDaChon.FillWeight = 20F;
            colTenKhuVucDaChon.Name = "colTenKhuVucDaChon";

            colGiaVeDaChon.DataPropertyName = "GiaVe";
            colGiaVeDaChon.HeaderText = "Giá Vé";
            colGiaVeDaChon.FillWeight = 15F;
            colGiaVeDaChon.Name = "colGiaVeDaChon";
            // 
            // frmDatVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(grpVeDaChon);
            Controls.Add(grpVeTrong);
            Controls.Add(grpThongTinDatVe);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            Name = "frmDatVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Vé";
            Load += frmDatVe_Load;
            grpThongTinDatVe.ResumeLayout(false);
            grpThongTinDatVe.PerformLayout();
            grpVeTrong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeTrong).EndInit();
            grpVeDaChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeDaChon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinDatVe;
        private ComboBox cboNhanVien;
        private ComboBox cboKhachHang;
        private ComboBox cboSuKien;
        private DateTimePicker dtpNgayLap;
        private KryptonTextBox txtTongTien;
        private KryptonTextBox txtGhiChu;
        private Label lblNhanVien;
        private Label lblKhachHang;
        private Label lblSuKien;
        private Label lblNgayLap;
        private Label lblTongTien;
        private Label lblGhiChu;
        private KryptonButton btnTaoMoi;
        private KryptonButton btnThanhToan;
        private KryptonButton btnHuyDon;
        private KryptonButton btnThoat;

        private GroupBox grpVeTrong;
        private DataGridView dgvVeTrong;
        private KryptonButton btnChonVe;

        private GroupBox grpVeDaChon;
        private DataGridView dgvVeDaChon;
        private KryptonButton btnBoVe;

        private DataGridViewTextBoxColumn colVeID;
        private DataGridViewTextBoxColumn colTenSuKien;
        private DataGridViewTextBoxColumn colSoGhe;
        private DataGridViewTextBoxColumn colTenKhuVuc;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colGiaVe;
        private DataGridViewTextBoxColumn colTrangThai;

        private DataGridViewTextBoxColumn colVeIDDaChon;
        private DataGridViewTextBoxColumn colTenSuKienDaChon;
        private DataGridViewTextBoxColumn colSoGheDaChon;
        private DataGridViewTextBoxColumn colTenKhuVucDaChon;
        private DataGridViewTextBoxColumn colGiaVeDaChon;
    }
}