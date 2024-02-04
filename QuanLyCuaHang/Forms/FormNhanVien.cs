using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Forms
{
    public partial class FormNhanVien : Form
    {
        private static int NhanVienCuoi = 0;
        public FormNhanVien()
        {
            InitializeComponent();
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            int NgayCong, NamSinh;
            int row = 0;
            int MaNV;

            dataGridNhanVien.Rows.Add();
            row = dataGridNhanVien.Rows.Count - 2;
            //NhanVienCuoi++;
            MaNV = NhanVienCuoi++;
            string TenNhanVien, DiaChi, GioiTinh;
            NgayCong = Convert.ToInt32(txtNgayCong.Text);
            NamSinh = Convert.ToInt32(txtNamSinh.Text);
            TenNhanVien = (txtTenNhanVien.Text);
            DiaChi = (txtDiaChi.Text);
            GioiTinh = (cbxGioiTinh.Text);
            //
            
            dataGridNhanVien["MaNV", row].Value = NhanVienCuoi.ToString();
            dataGridNhanVien["TenNhanVien", row].Value = txtTenNhanVien.Text;
            dataGridNhanVien["NamSinh", row].Value = txtNamSinh.Text;
            dataGridNhanVien["GioiTinh", row].Value = cbxGioiTinh.Text;
            dataGridNhanVien["DiaChi", row].Value = txtDiaChi.Text;
            dataGridNhanVien["NgayCong", row].Value = txtNgayCong.Text;
            TinhLuong();
            dataGridNhanVien["Luong", row].Value = lblLuong.Text;
            txtMaNV.Text = (MaNV + 1).ToString();
        }

        //tính lương
        public void TinhLuong()
        {
            int NgayCong = Convert.ToInt32(txtNgayCong.Text);
            int luong = 500000, tienThuong = luong * 2;

            if (NgayCong >= 30)
            {
                lblLuong.Text = ((luong * NgayCong) + tienThuong).ToString("#,##0") + "VNĐ";
            }
            else if (NgayCong < 30)
            {
                lblLuong.Text = (luong * NgayCong).ToString("#,##0") + "VNĐ";
            }
        }
        //phương thức xoá 
        public void Xoa()
        {
            txtMaNV.Text = "";
            txtTenNhanVien.Text = "";
            txtNamSinh.Text = "";
            cbxGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtNgayCong.Text = "";
        }

        private void dataGridNhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtMaNV.Text = dataGridNhanVien.Rows[rowIndex].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataGridNhanVien.Rows[rowIndex].Cells[1].Value.ToString();
            txtNamSinh.Text = dataGridNhanVien.Rows[rowIndex].Cells[2].Value.ToString();
            cbxGioiTinh.Text = dataGridNhanVien.Rows[rowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridNhanVien.Rows[rowIndex].Cells[4].Value.ToString();
            txtNgayCong.Text = dataGridNhanVien.Rows[rowIndex].Cells[5].Value.ToString();
            lblLuong.Text = dataGridNhanVien.Rows[rowIndex].Cells[6].Value.ToString();
        }

        //button Update
        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            int selectRowIndex = dataGridNhanVien.CurrentCell.RowIndex;
            //kiểm tra xem có hàng nào được chọn không
            if (selectRowIndex < 0 || selectRowIndex >= dataGridNhanVien.RowCount - 1)
            {
                MessageBox.Show("Vui lòng chọn hàng để cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //lấy dữ liệu
            int MaNV = int.Parse(txtMaNV.Text);
            string TenNhanVien = txtTenNhanVien.Text;
            int NamSinh = Convert.ToInt32(txtNamSinh.Text);
            string GioiTinh = cbxGioiTinh.Text;
            string DiaChi = txtDiaChi.Text;
            int NgayCong = Convert.ToInt32(txtNgayCong.Text);
            TinhLuong();
            string Luong = lblLuong.Text;

            //cập nhật dữ liệu vào data
            UpdateDataGridView(selectRowIndex, MaNV, TenNhanVien, NamSinh, GioiTinh, DiaChi, NgayCong, Luong);
            MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //cập nhật data
        private void UpdateDataGridView(int row, int maNV, string tenNV, int namSinh, string gioiTinh, string diaChi, int ngayCong, string luong)
        {
            dataGridNhanVien.Rows[row].Cells["MaNV"].Value = maNV.ToString();
            dataGridNhanVien.Rows[row].Cells["TenNhanVien"].Value = tenNV;
            dataGridNhanVien.Rows[row].Cells["NamSinh"].Value = namSinh.ToString();
            dataGridNhanVien.Rows[row].Cells["GioiTinh"].Value = gioiTinh;
            dataGridNhanVien.Rows[row].Cells["DiaChi"].Value = diaChi;
            dataGridNhanVien.Rows[row].Cells["NgayCong"].Value = ngayCong.ToString();
            dataGridNhanVien.Rows[row].Cells["Luong"].Value = luong;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dataGridNhanVien.CurrentRow != null)
            {
                int selectRowIndex = dataGridNhanVien.CurrentRow.Index;
                // Xác nhận xoá dữ liệu
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu ?", "Xác Nhận Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(txtTimKiem.Text))
                    {
                        // Xoá dòng được chọn
                        dataGridNhanVien.Rows.RemoveAt(selectRowIndex);
                        Xoa();
                        MessageBox.Show("Dữ liệu đã xoá thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Xoá dòng được chọn
                        dataGridNhanVien.Rows.RemoveAt(selectRowIndex);
                        Xoa();
                        MessageBox.Show("Dữ liệu đã xoá thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TimKiemEmployeeByName(string tenTimKiem)
        {
            foreach (DataGridViewRow row in dataGridNhanVien.Rows)
            {
                string TenNhanVien = row.Cells[1].Value?.ToString();
                if (!row.IsNewRow)
                {
                    if (!string.IsNullOrEmpty(TenNhanVien) && TenNhanVien.Contains(tenTimKiem))
                    {
                        row.Visible = true;
                    }
                    else
                    { row.Visible = false; }
                }
            }
        }
        private void RefeshDaTaNhanVien()
        {
            foreach (DataGridViewRow row in dataGridNhanVien.Rows)
            {
                row.Visible = true;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenTimKiem = txtTimKiem.Text;
            if (string.IsNullOrEmpty(tenTimKiem))
            {
                RefeshDaTaNhanVien();
            }
            else
            {
                TimKiemEmployeeByName(tenTimKiem);
            }
        }
    }

}
