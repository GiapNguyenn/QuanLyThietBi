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
    }
}
