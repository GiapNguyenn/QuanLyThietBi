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
    public partial class FormNhaCungCap : Form
    {
        QueryConnection cn = new QueryConnection();

        public FormNhaCungCap()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            string sql = "select * from tblNhaCungCap ";
            dgvNhaCungCap.DataSource = cn.TaoBang(sql);
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhaCungCapDataSet.tblNhaCungCap' table. You can move, or remove it, as needed.
            this.tblNhaCungCapTableAdapter.Fill(this.nhaCungCapDataSet.tblNhaCungCap);
            HienThi();  
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các ô textbox có được nhập đầy đủ không
            if (string.IsNullOrWhiteSpace(txtMaNhaCC.Text) || string.IsNullOrWhiteSpace(txtTenNhaCC.Text) || string.IsNullOrWhiteSpace(txtHotline.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng việc thực hiện phương thức btnThem_Click nếu một trong các ô textbox chưa được nhập
            }

            try
            {
                // Tạo câu lệnh SQL để chèn dữ liệu vào CSDL
                string sql = "insert into tblNhaCungCap values('" + txtMaNhaCC.Text + "','" + txtTenNhaCC.Text + "','" + txtHotline.Text + "','" + txtEmail.Text + "')";

                // Thực hiện câu lệnh SQL
                cn.ExcuteNonQuery(sql);

                // Hiển thị thông báo thành công và làm mới dữ liệu
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThi();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra trong quá trình thực hiện
                MessageBox.Show("Không thể thêm dữ liệu. Vui lòng thử lại!\nĐã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng việc thực hiện phương thức btnXoa_Click nếu không có hàng nào được chọn
            }

            // Lấy giá trị của cột ID (hoặc cột khóa chính) từ hàng được chọn
            string id = dgvNhaCungCap.SelectedRows[0].Cells[0].Value.ToString();

            // Xác nhận với người dùng trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from tblNhaCungCap where MaNhaCungCap= '" + id + "'";
                    cn.ExcuteNonQuery(sql);
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có lỗi xảy ra trong quá trình thực hiện
                    MessageBox.Show("Không thể xóa dữ liệu. Vui lòng thử lại!\nĐã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            cn.ExcuteNonQuery("update tblNhaCungCap set TenNhaCungCap ='" + txtTenNhaCC.Text + "', Hotline ='" + txtHotline.Text + "', Email ='" + txtEmail.Text + "' where MaNhaCungCap = '" + txtMaNhaCC.Text + "' ");
            try
            {
                HienThi();
                MessageBox.Show("Sửa dữ liệu thành công");

            }
            catch
            {
                MessageBox.Show("Sửa dữ liệu không thành công");
            }
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhaCungCap.Rows.Count)
            {
                // Lấy dữ liệu từ dòng được chọn trong DataGridView
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                string maNhaCC = row.Cells[0].Value.ToString();
                string tenNhaCC = row.Cells[1].Value.ToString();
                string hotline = row.Cells[2].Value.ToString();
                string email = row.Cells[3].Value.ToString();

                // Hiển thị dữ liệu lên các TextBox
                txtMaNhaCC.Text = maNhaCC;
                txtTenNhaCC.Text = tenNhaCC;
                txtHotline.Text = hotline;
                txtEmail.Text = email;

            }
        }
        private void RefeshDaTaNhanCC()
        {
            foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
            {
                row.Visible = true;
            }

        }
        private void TimKiemEmployeeByName(string tenTimKiem)
        {

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvNhaCungCap.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
            {
                if (!row.IsNewRow)
                {
                    string TenNhaCC = Convert.ToString(row.Cells[1].Value); // Lấy giá trị tên nhà cung cấp từ cột có tên là "TenNhaCC"
                    if (!string.IsNullOrEmpty(TenNhaCC) && TenNhaCC.Contains(tenTimKiem))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenTimKiem = txtTimKiem.Text;
            if (string.IsNullOrEmpty(tenTimKiem))
            {
                RefeshDaTaNhanCC();
            }
            else
            {
                TimKiemEmployeeByName(tenTimKiem);
            }
        }
    }
}
