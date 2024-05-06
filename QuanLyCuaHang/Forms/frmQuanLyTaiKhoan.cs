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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        public void loaddata()
        {
            string query = "TNG_QuanLyTaiKhoan_GetAll";
            datagirdQuanLy.DataSource = QueryConnection.Query.LayAllDanhSach(query);
        }
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPass.Text;
            string manv = txtMaNV.Text;
            string query = "Exec TNG_DANGKYTAIKHOAN @tendangnhap,@password,@manv";
            QueryConnection.Query.InsertTaiKhoan(query, user, password, manv);
            loaddata();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPass.Text;
            string query = "EXEC TNG_DOIMATKHAU @tendangnhap,@password";
            QueryConnection.Query.UpdateTaiKhoan(query,user,password);  
            loaddata(); 
        }
    }
}
