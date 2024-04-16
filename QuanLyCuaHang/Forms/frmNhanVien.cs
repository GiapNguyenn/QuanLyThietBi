using QuanLyCuaHang.Connection;
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
    public partial class frmNhanVien : Form
    {
        string gioiTinh;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string query = "EXEC TNG_TimKiemAllNhanVien";
            dataGridNhanVien.DataSource = QueryConnection.Query.LayAllDanhSach(query);
        }
        //phương thức xoá 
        public void Xoa()
        {
            txtMaNV.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtNgayCong.Text = "";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string maNV=txtMaNV.Text;
            string tenNV = txtTenNhanVien.Text;
            string gioiTinh = radNam.Checked ? "Nam" : (radNu.Checked ? "Nữ" :"" ) ;//toán tử 3 ngôi
            DateTime namSinh = dateNam.Value;
            string diaChi = txtDiaChi.Text;
            int ngayCong = int.Parse(txtNgayCong.Text);
            string query = "EXEC TNG_InsertNhanVien @id,@name,@date,@gioitinh,@diachi,@ngaycong";
            QueryConnection.Query.InsertNhanVien(query,maNV,tenNV,gioiTinh,namSinh,diaChi,ngayCong);
            string newdl = "EXEC TNG_TimKiemAllNhanVien";
            dataGridNhanVien.DataSource = QueryConnection.Query.LayAllDanhSach(newdl);


        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dataGridNhanVien.SelectedRows.Count > 0)
            {
                string maNV = dataGridNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
                string query = "EXEC TNG_XoaID @maNV";
                QueryConnection.Query.deleteData(query, maNV);
                string query2 = "EXEC TNG_TimKiemAllNhanVien";
                dataGridNhanVien.DataSource = QueryConnection.Query.LayAllDanhSach(query2); // Chú ý sử dụng query2, không phải query

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            if(dataGridNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridNhanVien.SelectedRows[0];
                string maNV = txtMaNV.Text;
                string tenNV = txtTenNhanVien.Text;
                DateTime namSinh = dateNam.Value;
                string gioitinh =gioiTinh;
                string diaChi = txtDiaChi.Text;
                int ngayCong = Convert.ToInt32(txtNgayCong.Text);
                string query = " EXEC TNG_UpDateNhanVien @id,@name,@date,@gioitinh,@diachi,@ngaycong ";
                QueryConnection.Query.UpdateData(query,maNV ,tenNV, namSinh,gioitinh, diaChi, ngayCong);
                string query2 = "EXEC TNG_TimKiemAllNhanVien";
                dataGridNhanVien.DataSource = QueryConnection.Query.LayAllDanhSach(query2);
            }    
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật");
            }    

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                gioiTinh = "Nam";
            }
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            if (radNu.Checked)
            {
                gioiTinh = "Nữ";
            }
        }
    }
}
