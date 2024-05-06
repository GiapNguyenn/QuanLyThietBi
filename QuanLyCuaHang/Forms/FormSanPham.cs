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
using System.IO;
using System.Drawing.Imaging;

namespace QuanLyCuaHang.Forms
{
    public partial class FormSanPham : Form
    {

        QueryConnection cn = new QueryConnection();
        public void HienThiSanPham()
        {
            string sql = "select * from tblSanPham";
            dgvSanpham.DataSource = cn.TaoBang(sql);
        }
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sanPhamDataSet.tblSanPham' table. You can move, or remove it, as needed.
            this.tblSanPhamTableAdapter.Fill(this.sanPhamDataSet.tblSanPham);
            HienThiSanPham();
            LoadDataToComboBox();
        }
        public void LoadDataToComboBox()
        {
            string sql = "SELECT DISTINCT MaNhaCungCap FROM tblNhaCungCap"; // Thay ColumnName bằng tên cột chứa dữ liệu bạn muốn load vào ComboBox
            DataTable dt = cn.TaoBang(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                cbxManhacc.DataSource = dt;
                cbxManhacc.DisplayMember = "MaNhaCungCap"; // Thay ColumnName bằng tên cột chứa dữ liệu bạn muốn hiển thị trong ComboBox
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường nhập liệu có trống không
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(cbxHangSX.Text) || string.IsNullOrWhiteSpace(cbxManhacc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo câu lệnh SQL để chèn dữ liệu vào CSDL với giá trị hình ảnh là chuỗi Base64
                string sql = "INSERT INTO tblSanPham VALUES ('" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + cbxHangSX.Text + "','" + cbxManhacc.Text + "',"+txtSoluong.Text+",'" + txtTheLoai.Text + "','" + cbxXuatXu.Text + "','" + txtGiaBan.Text + "')";

                // Thực hiện câu lệnh SQL
                cn.ExcuteNonQuery(sql);

                // Hiển thị thông báo thành công và làm mới dữ liệu
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiSanPham();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra trong quá trình thực hiện
                MessageBox.Show("Không thể thêm dữ liệu. Vui lòng thử lại!\nĐã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng việc thực hiện phương thức btnXoa_Click nếu không có hàng nào được chọn
            }

            // Lấy giá trị của cột ID (hoặc cột khóa chính) từ hàng được chọn
            string id = dgvSanpham.SelectedRows[0].Cells[0].Value.ToString();

            // Xác nhận với người dùng trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from tblSanPham where MaSP= '" + id + "'";
                    cn.ExcuteNonQuery(sql);
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiSanPham();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có lỗi xảy ra trong quá trình thực hiện
                    MessageBox.Show("Không thể xóa dữ liệu. Vui lòng thử lại!\nĐã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSanpham.Rows[e.RowIndex];
            string maSP = row.Cells[0].Value.ToString();
            string tenSP = row.Cells[1].Value.ToString();
            string HangSX = row.Cells[2].Value.ToString();
            string maNhaCC = row.Cells[3].Value.ToString();
            string theloai = row.Cells[4].Value.ToString();
            string xuatXu = row.Cells[5].Value.ToString();
            string giaBan = row.Cells[6].Value.ToString();


            // Hiển thị dữ liệu lên các TextBox
            txtMaSP.Text = maSP;
            txtTenSP.Text = tenSP;
            cbxHangSX.Text = HangSX;
            cbxManhacc.Text = maNhaCC;
            txtTheLoai.Text = theloai;
            cbxXuatXu.Text = xuatXu;
            txtGiaBan.Text = giaBan;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            cn.ExcuteNonQuery("update tblSanPham set TenSanPham ='" + txtTenSP.Text + "', HangSanXuat ='" + cbxHangSX.Text + "', MaNhaCungCap ='" + cbxManhacc.Text + "', TheLoai ='" + txtTheLoai.Text + "', XuatXu ='" + cbxXuatXu.Text + "', GiaBan ='" + txtGiaBan.Text + "' where MaSP = '" + txtMaSP.Text + "' ");
            try
            {
                HienThiSanPham();
                MessageBox.Show("Sửa dữ liệu thành công");

            }
            catch
            {
                MessageBox.Show("Sửa dữ liệu không thành công");
            }
        }
        private void RefeshDaTaNhanCC()
        {
            foreach (DataGridViewRow row in dgvSanpham.Rows)
            {
                row.Visible = true;
            }

        }
        private void TimKiemEmployeeByName(string tenTimKiem)
        {

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvSanpham.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in dgvSanpham.Rows)
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = string.Empty;    
            txtTenSP.Text = string.Empty;
            cbxHangSX.SelectedIndex = -1;
            cbxManhacc.SelectedIndex = -1;
            txtTheLoai.Text = string.Empty;
            cbxXuatXu.SelectedIndex = -1;
            txtGiaBan.Text = string.Empty;
        }
    }
}

