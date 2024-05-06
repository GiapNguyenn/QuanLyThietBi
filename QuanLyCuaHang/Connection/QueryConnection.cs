using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Input;

namespace QuanLyCuaHang.Connection
{
    internal class QueryConnection
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter adapter;
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
        public QueryConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=10.0.41.190;Initial Catalog=QuanLyBanHang;Persist Security Info=True;User ID=win;Password=1;Encrypt=False");
        }

        private string connectQL = "Data Source=10.0.41.190;Initial Catalog=QuanLyBanHang;Persist Security Info=True;User ID=win;Password=1;Encrypt=False";
        public SqlConnection Getcon()
        {
            return new SqlConnection("Data Source=10.0.41.190;Initial Catalog=QuanLyBanHang;Persist Security Info=True;User ID=win;Password=1;Encrypt=False");

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
        public DataTable InsertNhanVien(string query, string id, string name, string gioitinh, DateTime date, string diachi, int ngaycong)
        {
            DataTable data2 = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@ngaycong", ngaycong);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data2);
                connection.Close();

            };
            return data2;
        }
        public DataTable deleteData(string query, string id)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maNV", id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dữ liệu đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }

            return data;
        }
            public DataTable UpdateData(string query, string manv, string name, DateTime date, string gioiTinh, string diachi, int ngaycong)
            {
                DataTable data4 = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectQL))
                {
                    connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", manv);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                    cmd.Parameters.AddWithValue("@ngaycong", ngaycong);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu nào được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connection.Close();

                };
                return data4;
            }
            public DataTable TimKiem(string query, string keyword)
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectQL))
                {
                    connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@keyword", keyword.Trim());


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(data);
                    connection.Close();

                };
                return data;
            }
             public DataTable Login(string query,string user ,string password)
             {
                 DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectQL))
                {
                    connection.Open(); // Mở kết nối đến cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@user",user );
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    
                    adapter.Fill(data);
                    int count = (int)cmd.ExecuteScalar(); 
                    connection.Close();
                    if(count > 0)
                    {
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    }    
                };
                return data;
             }
            public DataTable LayAllDonDatHang(string query)
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
            public DataTable InsertDonHang(string query, string madh, string tenkh, string sdt, DateTime date, string diachi, string masp, int soluongmuonlay)
            {
                DataTable data2 = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectQL))
                {
                    try
                    {
                        connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@madonhang", madh);
                        cmd.Parameters.AddWithValue("@tenkhachhang", tenkh);
                        cmd.Parameters.AddWithValue("@sdt", sdt);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@masanpham", masp);
                        cmd.Parameters.AddWithValue("@soluongmuonlay", soluongmuonlay);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(data2);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bi loi do " + ex.Message);
                    }


                };
                return data2;
            }
        public DataTable LayAllTaIkhoan(string query)
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
        public DataTable InsertTaiKhoan(string query,string tendangnhap,string password,string manv)
        {
            DataTable data2 = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                try
                {
                    connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tendangnhap",tendangnhap);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@manv", manv);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(data2);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bi loi do " + ex.Message);
                }


            };
            return data2;
        }
        public DataTable UpdateTaiKhoan(string query,string tendangnhap,string password)
        {
            DataTable data4 = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectQL))
            {
                connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tendangnhap",tendangnhap);
                cmd.Parameters.AddWithValue("@password",password);
              
                cmd.ExecuteNonQuery();

                connection.Close();

            };
            return data4;
        }



        public DataTable TaoBang(string sql)
            {
                con = Getcon();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            public void ExcuteNonQuery(string sql)
            {
                con = Getcon();
                command = new SqlCommand(sql, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
        }
    } 
