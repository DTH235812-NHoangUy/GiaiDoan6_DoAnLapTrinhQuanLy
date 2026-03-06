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
            grpTTVT = new GroupBox();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtVaiTro = new TextBox();
            txtID = new TextBox();
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
            grpTTVT.Location = new Point(12, 12);
            grpTTVT.Name = "grpTTVT";
            grpTTVT.Size = new Size(776, 135);
            grpTTVT.TabIndex = 0;
            grpTTVT.TabStop = false;
            grpTTVT.Text = "Thông tin vai trò:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(626, 90);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(626, 58);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất ";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(626, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập ";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(501, 90);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(501, 60);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(501, 25);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(378, 91);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(378, 56);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(378, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(108, 65);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(224, 27);
            txtVaiTro.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(108, 31);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(224, 27);
            txtID.TabIndex = 2;
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Location = new Point(27, 65);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(55, 20);
            lblVaiTro.TabIndex = 1;
            lblVaiTro.Text = "Vai trò:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(27, 34);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // groupVaiTro
            // 
            groupVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupVaiTro.Controls.Add(dgvVaiTro);
            groupVaiTro.Location = new Point(12, 164);
            groupVaiTro.Name = "groupVaiTro";
            groupVaiTro.Size = new Size(776, 274);
            groupVaiTro.TabIndex = 1;
            groupVaiTro.TabStop = false;
            groupVaiTro.Text = "Danh sách vai trò:";
            // 
            // dgvVaiTro
            // 
            dgvVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVaiTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaiTro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaiTro.Columns.AddRange(new DataGridViewColumn[] { colID, colVaiTro });
            dgvVaiTro.Location = new Point(6, 26);
            dgvVaiTro.Name = "dgvVaiTro";
            dgvVaiTro.RowHeadersWidth = 51;
            dgvVaiTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaiTro.Size = new Size(764, 242);
            dgvVaiTro.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "Mã ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colVaiTro
            // 
            colVaiTro.DataPropertyName = "TenVaiTro";
            colVaiTro.HeaderText = "Tên Vai Trò";
            colVaiTro.MinimumWidth = 6;
            colVaiTro.Name = "colVaiTro";
            // 
            // frmVaiTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupVaiTro);
            Controls.Add(grpTTVT);
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
        private Button btnTimKiem;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtVaiTro;
        private TextBox txtID;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colVaiTro;
    }
}