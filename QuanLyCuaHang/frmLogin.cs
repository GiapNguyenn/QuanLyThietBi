using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCuaHang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            if(Properties.Settings.Default.UserName!=string.Empty)
            {
                txtUser.Text= Properties.Settings.Default.UserName;
            }
            togeLuuMk.CheckedChanged += togeLuuMk_CheckedChanged;

            // Đặt trạng thái của toggle switch dựa trên có hay không có tên người dùng
            togeLuuMk.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.UserName);
            this.AcceptButton = btnDangNhap;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
         
            string user ="";
            if(string.IsNullOrEmpty(txtUser.Text) )
            {
                errUser.SetError(txtUser, "Tài khoảng không được để trống");
                errUser.GetError(txtUser);
            }
            else
            {
                errUser.Clear();
                user = txtUser.Text;
            }    
            string password = txtPassword.Text;
            if (password.Length < 6)
            {
                errorPass.SetError(txtPassword, "Mật khẩu phải từ 6 kí tự ");
                errorPass.GetError(txtPassword);
            }
            else
            {
                errorPass.Clear();
               
            }    
            string query = "EXEC TNG_Login @user,@password";
            QueryConnection.Query.Login(query, user, password);
        }

        private void togeLuuMk_CheckedChanged(object sender, EventArgs e)
        {
            // Lưu tên người dùng nếu toggle switch được kích hoạt
            Properties.Settings.Default.UserName = togeLuuMk.Checked ? txtUser.Text : string.Empty;
            Properties.Settings.Default.Save();
        }
      
    }
}
