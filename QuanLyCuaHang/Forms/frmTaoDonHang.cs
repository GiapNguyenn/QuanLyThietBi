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
        public frmTaoDonHang()
        {
            InitializeComponent();
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

        private void CbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

            string maSanPham = CbbSanPham.Text.ToString();
            string s = "Data Source=192.168.1.18;Initial Catalog=QuanLyBanHang;Persist Security Info=True;User ID=win;Password=1;Encrypt=False";

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
            dataGridDatDonHang.DataSource = QueryConnection.Query.LayAllDonDatHang(query);
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
            dataGridDatDonHang.DataSource = QueryConnection.Query.LayAllDonDatHang(loadds);
            LoadCbbMaSp();
        }
    }
}
