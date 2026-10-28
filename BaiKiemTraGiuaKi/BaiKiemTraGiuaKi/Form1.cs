using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BaiKiemTraGiuaKi.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiKiemTraGiuaKi
{
    public partial class Form1 : Form
    {
        private DuLieuContext db = new DuLieuContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvCongViec.DataSource = db.CongViecs
                .Select(x => new {
                    x.MaCongViec,
                    x.TenCongViec,
                    x.LuongThang
                })
                .ToList();
        }

        private void ResetForm()
        {
            txtMaCongViec.Clear();
            txtTenCongViec.Clear();
            txtLuongThang.Clear();

            txtMaCongViec.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaCongViec.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCongViec.Rows[e.RowIndex];
            txtMaCongViec.Text = row.Cells["MaCongViec"].Value?.ToString();
            txtTenCongViec.Text = row.Cells["TenCongViec"].Value?.ToString();
            txtLuongThang.Text = row.Cells["LuongThang"].Value?.ToString();

            txtMaCongViec.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaCongViec.Text.Trim();
            string ten = txtTenCongViec.Text.Trim();
            string luong = txtLuongThang.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Mã công việc không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCongViec.Focus();
                return;
            }

            if (ma.Length > 10)
            {
                MessageBox.Show("Mã công việc tối đa 10 ký tự!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCongViec.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Tên công việc không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCongViec.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(luong) || !double.TryParse(luong, out double l) || l < 0)
            {
                MessageBox.Show("Lương tháng phải là số dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongThang.Focus();
                return;
            }

            if (luong.Length > 8)
            {
                MessageBox.Show("Lương tháng tối đa 8 ký tự!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongThang.Focus();
                return;
            }

            if (db.CongViecs.Any(x => x.MaCongViec == ma))
            {
                MessageBox.Show("Mã công việc đã tồn tại!", "Trùng khóa chính", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCongViec.Focus();
                return;
            }

            CongViec cv = new CongViec
            {
                MaCongViec = ma,
                TenCongViec = ten,
                LuongThang = luong
            };

            db.CongViecs.Add(cv);
            db.SaveChanges();

            MessageBox.Show("Thêm mới công việc thành công!", "Thông báo");
            LoadData();
            ResetForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaCongViec.Text.Trim();
            string ten = txtTenCongViec.Text.Trim();
            string luong = txtLuongThang.Text.Trim();

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Tên công việc không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCongViec.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(luong) || !double.TryParse(luong, out double l) || l < 0)
            {
                MessageBox.Show("Lương tháng phải là số dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongThang.Focus();
                return;
            }

            if (luong.Length > 8)
            {
                MessageBox.Show("Lương tháng tối đa 8 ký tự!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongThang.Focus();
                return;
            }

            var cv = db.CongViecs.Find(ma);
            if (cv != null)
            {
                cv.TenCongViec = ten;
                cv.LuongThang = luong;

                db.SaveChanges();

                MessageBox.Show("Cập nhật công việc thành công!", "Thông báo");
                LoadData();
                ResetForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaCongViec.Text.Trim();

            if (MessageBox.Show("Bạn có muốn xóa công việc này không ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cv = db.CongViecs.Find(ma);
                if (cv != null)
                {
                    db.CongViecs.Remove(cv);
                    db.SaveChanges();

                    MessageBox.Show("Xóa công việc thành công!", "Thông báo");
                    LoadData();
                    ResetForm();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}