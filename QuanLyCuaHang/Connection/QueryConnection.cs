using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Connection
{
    internal class QueryConnection
    {
        private static QueryConnection query;
        public static QueryConnection Query
        {
            get
            {
                if (query == null) query = new QueryConnection();
                return QueryConnection.query;
            }
            private set => query = value;
        }
        private QueryConnection() { }

        private string connectQL = "Data Source=10.0.40.206;Initial Catalog=QuanLyBanHang;Persist Security Info=True;User ID=win;Password=1;Encrypt=False";

        public DataTable LayDSTheoID(string query, string id)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                connection.Close();

            };
            return data;

        }
        public DataTable LayAllDanhSach(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                connection.Close();

            };
            return data;

        }
        public DataTable InsertNhanVien(string query, string id, string name, DateTime date, string gioitinh, string diachi, int ngaycong)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@ngaycong", ngaycong);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);
                connection.Close();

            };
            return data;
        }
        public DataTable deleteData(string query, string id)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maNV", id);

                int rowsAffected = cmd.ExecuteNonQuery(); // Thực hiện truy vấn DELETE và lấy số dòng bị ảnh hưởng

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dữ liệu đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return data;
        }
    }
}
