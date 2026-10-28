namespace BaiKiemTraGiuaKi
{
    partial class Form1
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

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            grpThongTin = new GroupBox();
            lblMaCongViec = new Label();
            txtMaCongViec = new TextBox();
            lblTenCongViec = new Label();
            txtTenCongViec = new TextBox();
            lblLuongThang = new Label();
            txtLuongThang = new TextBox();
            grpDanhSach = new GroupBox();
            dgvCongViec = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grpThongTin.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCongViec).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1044, 61);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "DANH MỤC CÔNG VIỆC";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblMaCongViec);
            grpThongTin.Controls.Add(txtMaCongViec);
            grpThongTin.Controls.Add(lblTenCongViec);
            grpThongTin.Controls.Add(txtTenCongViec);
            grpThongTin.Controls.Add(lblLuongThang);
            grpThongTin.Controls.Add(txtLuongThang);
            grpThongTin.Location = new Point(53, 66);
            grpThongTin.Margin = new Padding(4, 5, 4, 5);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(4, 5, 4, 5);
            grpThongTin.Size = new Size(944, 175);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin công việc";
            // 
            // lblMaCongViec
            // 
            lblMaCongViec.AutoSize = true;
            lblMaCongViec.Location = new Point(201, 29);
            lblMaCongViec.Margin = new Padding(4, 0, 4, 0);
            lblMaCongViec.Name = "lblMaCongViec";
            lblMaCongViec.Size = new Size(121, 25);
            lblMaCongViec.TabIndex = 0;
            lblMaCongViec.Text = "Mã công việc:";
            // 
            // txtMaCongViec
            // 
            txtMaCongViec.Location = new Point(418, 29);
            txtMaCongViec.Margin = new Padding(4, 5, 4, 5);
            txtMaCongViec.Name = "txtMaCongViec";
            txtMaCongViec.Size = new Size(370, 31);
            txtMaCongViec.TabIndex = 1;
            // 
            // lblTenCongViec
            // 
            lblTenCongViec.AutoSize = true;
            lblTenCongViec.Location = new Point(201, 76);
            lblTenCongViec.Margin = new Padding(4, 0, 4, 0);
            lblTenCongViec.Name = "lblTenCongViec";
            lblTenCongViec.Size = new Size(122, 25);
            lblTenCongViec.TabIndex = 2;
            lblTenCongViec.Text = "Tên công việc:";
            // 
            // txtTenCongViec
            // 
            txtTenCongViec.Location = new Point(418, 76);
            txtTenCongViec.Margin = new Padding(4, 5, 4, 5);
            txtTenCongViec.Name = "txtTenCongViec";
            txtTenCongViec.Size = new Size(370, 31);
            txtTenCongViec.TabIndex = 3;
            // 
            // lblLuongThang
            // 
            lblLuongThang.AutoSize = true;
            lblLuongThang.Location = new Point(205, 120);
            lblLuongThang.Margin = new Padding(4, 0, 4, 0);
            lblLuongThang.Name = "lblLuongThang";
            lblLuongThang.Size = new Size(118, 25);
            lblLuongThang.TabIndex = 4;
            lblLuongThang.Text = "Lương tháng:";
            // 
            // txtLuongThang
            // 
            txtLuongThang.Location = new Point(418, 120);
            txtLuongThang.Margin = new Padding(4, 5, 4, 5);
            txtLuongThang.Name = "txtLuongThang";
            txtLuongThang.Size = new Size(370, 31);
            txtLuongThang.TabIndex = 5;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvCongViec);
            grpDanhSach.Location = new Point(53, 251);
            grpDanhSach.Margin = new Padding(4, 5, 4, 5);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(4, 5, 4, 5);
            grpDanhSach.Size = new Size(944, 276);
            grpDanhSach.TabIndex = 2;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách công việc";
            // 
            // dgvCongViec
            // 
            dgvCongViec.AllowUserToAddRows = false;
            dgvCongViec.AllowUserToDeleteRows = false;
            dgvCongViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCongViec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCongViec.Dock = DockStyle.Fill;
            dgvCongViec.Location = new Point(4, 29);
            dgvCongViec.Margin = new Padding(4, 5, 4, 5);
            dgvCongViec.MultiSelect = false;
            dgvCongViec.Name = "dgvCongViec";
            dgvCongViec.ReadOnly = true;
            dgvCongViec.RowHeadersWidth = 62;
            dgvCongViec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCongViec.Size = new Size(936, 242);
            dgvCongViec.TabIndex = 0;
            dgvCongViec.CellClick += dgvCongViec_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(74, 537);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(157, 63);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(318, 537);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(157, 63);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(575, 537);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(157, 63);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(819, 537);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(157, 63);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 612);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpDanhSach);
            Controls.Add(grpThongTin);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Danh mục công việc -frmCongViec";
            Load += Form1_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCongViec).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaCongViec;
        private System.Windows.Forms.TextBox txtMaCongViec;
        private System.Windows.Forms.Label lblTenCongViec;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.Label lblLuongThang;
        private System.Windows.Forms.TextBox txtLuongThang;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvCongViec;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}