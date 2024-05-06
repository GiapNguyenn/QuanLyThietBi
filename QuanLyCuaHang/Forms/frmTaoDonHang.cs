using QuanLyCuaHang.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Forms
{
    public partial class frmTaoDonHang : Form
    {
        QueryConnection cn = new QueryConnection();
        public frmTaoDonHang()
        {
            InitializeComponent();
        }
        public void HienThiDonHang()
        {
            string sql = "select * from tblTaoDonHang";
            dgvTaoDonHang.DataSource = cn.TaoBang(sql);
        }
        public void LoadCbbMaSp()
        {
            QueryConnection queryConnection = new QueryConnection();
            DataTable dt = queryConnection.LayAllDanhSach("SELECT DISTINCT MaSP FROM tblSanPham");

            if (dt != null && dt.Rows.Count > 0)
            {
                // Thiết lập DataSource cho ComboBox
                CbbSanPham.DataSource = dt;

                // Thiết lập cột để hiển thị trong ComboBox
                CbbSanPham.DisplayMember = "MaSP";
            }
        }
        public void ThoiGianHienTai()
        {
            DateTime date = DateTime.Now;
            dateThoiGian.Value = date;
        }

        private void CbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

            string maSanPham = CbbSanPham.Text.ToString();
            string s = "Data Source=10.0.41.190;Initial Catalog=QuanLyBanHang;Persist Security Info=True;User ID=win;Password=1;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(s))
            {
                connection.Open();
                string query = "SELECT TenSanPham, SoLuong, GiaBan FROM tblSanPham WHERE MaSP = @MaSanPham";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenSanPham.Text = reader["TenSanPham"].ToString();
                        txtSoLuong.Text = reader["SoLuong"].ToString();
                        txtGiaBan.Text = reader["GiaBan"].ToString();
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }

        private void frmTaoDonHang_Load(object sender, EventArgs e)
        {
            string query = "Exec LayTatCaDonDatHang";
            dgvTaoDonHang.DataSource = QueryConnection.Query.LayAllDonDatHang(query);
            ThoiGianHienTai();
            LoadCbbMaSp();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QueryConnection queryConnection = new QueryConnection();
            string madonhang = txtMaDonHang.Text;
            string tenkhachhang = txtTenKhachHang.Text;
            string sdt = txtSdtKhachHang.Text;
            DateTime date = dateThoiGian.Value;
            string diaChi = txtDiaChi.Text;
            string masanpham = CbbSanPham.Text;
            int soluongmuonlay = Convert.ToInt32(txtSoLuongMuonLay.Text);
            string query = "Exec InsertDonHang @madonhang,@tenkhachhang,@sdt,@date,@diachi,@masanpham,@soluongmuonlay";
            QueryConnection.Query.InsertDonHang(query, madonhang, tenkhachhang, sdt, date, diaChi, masanpham, soluongmuonlay);
            string loadds = "Exec LayTatCaDonDatHang";
            dgvTaoDonHang.DataSource = QueryConnection.Query.LayAllDonDatHang(loadds);
            LoadCbbMaSp();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaoDonHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng việc thực hiện phương thức btnXoa_Click nếu không có hàng nào được chọn
            }

            // Lấy giá trị của cột ID (hoặc cột khóa chính) từ hàng được chọn
            string id = dgvTaoDonHang.SelectedRows[0].Cells[0].Value.ToString();

            // Xác nhận với người dùng trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from tblTaoDonHang where MaDonHang= '" + id + "'";
                    cn.ExcuteNonQuery(sql);
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDonHang();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có lỗi xảy ra trong quá trình thực hiện
                    MessageBox.Show("Không thể xóa dữ liệu. Vui lòng thử lại!\nĐã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
