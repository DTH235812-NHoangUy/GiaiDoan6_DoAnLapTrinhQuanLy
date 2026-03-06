namespace StadiumTicketBooking.Forms
{
    partial class frmSanVanDong
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
            grpTTSVD = new GroupBox();
            btnDoiAnh = new Button();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            picHinhAnh = new PictureBox();
            txtDiaChi = new TextBox();
            txtTenSan = new TextBox();
            txtID = new TextBox();
            lblDiaChi = new Label();
            lblTenSan = new Label();
            lblID = new Label();
            grpSanVanDong = new GroupBox();
            dgvSanVanDong = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            grpTTSVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            grpSanVanDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).BeginInit();
            SuspendLayout();
            // 
            // grpTTSVD
            // 
            grpTTSVD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTTSVD.Controls.Add(btnDoiAnh);
            grpTTSVD.Controls.Add(btnTimKiem);
            grpTTSVD.Controls.Add(btnXuat);
            grpTTSVD.Controls.Add(btnNhap);
            grpTTSVD.Controls.Add(btnThoat);
            grpTTSVD.Controls.Add(btnHuy);
            grpTTSVD.Controls.Add(btnLuu);
            grpTTSVD.Controls.Add(btnSua);
            grpTTSVD.Controls.Add(btnXoa);
            grpTTSVD.Controls.Add(btnThem);
            grpTTSVD.Controls.Add(picHinhAnh);
            grpTTSVD.Controls.Add(txtDiaChi);
            grpTTSVD.Controls.Add(txtTenSan);
            grpTTSVD.Controls.Add(txtID);
            grpTTSVD.Controls.Add(lblDiaChi);
            grpTTSVD.Controls.Add(lblTenSan);
            grpTTSVD.Controls.Add(lblID);
            grpTTSVD.Location = new Point(12, 12);
            grpTTSVD.Name = "grpTTSVD";
            grpTTSVD.Size = new Size(776, 175);
            grpTTSVD.TabIndex = 0;
            grpTTSVD.TabStop = false;
            grpTTSVD.Text = "Thông tin sân vận động";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoiAnh.Location = new Point(640, 135);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(75, 34);
            btnDoiAnh.TabIndex = 0;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(478, 101);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(93, 29);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(478, 66);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 29);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất";
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(478, 25);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 35);
            btnNhap.TabIndex = 3;
            btnNhap.Text = "Nhập";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(370, 97);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 33);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(370, 60);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(370, 27);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 27);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(260, 95);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 35);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(260, 60);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(260, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(610, 20);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(150, 110);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 10;
            picHinhAnh.TabStop = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(90, 97);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(150, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtTenSan
            // 
            txtTenSan.Location = new Point(90, 62);
            txtTenSan.Name = "txtTenSan";
            txtTenSan.Size = new Size(150, 27);
            txtTenSan.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.Location = new Point(90, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 27);
            txtID.TabIndex = 13;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(20, 100);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(58, 20);
            lblDiaChi.TabIndex = 14;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenSan
            // 
            lblTenSan.AutoSize = true;
            lblTenSan.Location = new Point(20, 65);
            lblTenSan.Name = "lblTenSan";
            lblTenSan.Size = new Size(61, 20);
            lblTenSan.TabIndex = 15;
            lblTenSan.Text = "Tên sân:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(20, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 16;
            lblID.Text = "ID";
            // 
            // grpSanVanDong
            // 
            grpSanVanDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpSanVanDong.Controls.Add(dgvSanVanDong);
            grpSanVanDong.Location = new Point(12, 193);
            grpSanVanDong.Name = "grpSanVanDong";
            grpSanVanDong.Size = new Size(776, 245);
            grpSanVanDong.TabIndex = 1;
            grpSanVanDong.TabStop = false;
            grpSanVanDong.Text = "Danh sách sân vận động";
            // 
            // dgvSanVanDong
            // 
            dgvSanVanDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanVanDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanVanDong.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSan, colDiaChi, colHinhAnh });
            dgvSanVanDong.Dock = DockStyle.Fill;
            dgvSanVanDong.Location = new Point(3, 23);
            dgvSanVanDong.Name = "dgvSanVanDong";
            dgvSanVanDong.RowHeadersWidth = 51;
            dgvSanVanDong.Size = new Size(770, 219);
            dgvSanVanDong.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Resizable = DataGridViewTriState.True;
            // 
            // colTenSan
            // 
            colTenSan.DataPropertyName = "TenSan";
            colTenSan.HeaderText = "Tên Sân";
            colTenSan.MinimumWidth = 6;
            colTenSan.Name = "colTenSan";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            colHinhAnh.HeaderText = "Hình ảnh sân vận động";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.Resizable = DataGridViewTriState.True;
            colHinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanVanDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpSanVanDong);
            Controls.Add(grpTTSVD);
            Name = "frmSanVanDong";
            Text = "Quản Lý Sân Vận Động";
            Load += frmSanVanDong_Load;
            grpTTSVD.ResumeLayout(false);
            grpTTSVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            grpSanVanDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTTSVD;
        private Label lblID;
        private Label lblTenSan;
        private Label lblDiaChi;
        private TextBox txtID;
        private TextBox txtTenSan;
        private TextBox txtDiaChi;
        private PictureBox picHinhAnh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnDoiAnh;
        private GroupBox grpSanVanDong;
        private DataGridView dgvSanVanDong;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewImageColumn colHinhAnh;
    }
}