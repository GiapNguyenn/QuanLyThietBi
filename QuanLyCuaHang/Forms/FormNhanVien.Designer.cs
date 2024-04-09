namespace QuanLyCuaHang.Forms
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblThongTinNhanVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtNgayCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dataGridNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDanhSachNV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemNV = new FontAwesome.Sharp.IconButton();
            this.btnCapNhatNV = new FontAwesome.Sharp.IconButton();
            this.btnXoaNV = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCuaHang.Properties.Resources.NhanVien;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblThongTinNhanVien
            // 
            this.lblThongTinNhanVien.AutoSize = true;
            this.lblThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinNhanVien.Location = new System.Drawing.Point(12, 87);
            this.lblThongTinNhanVien.Name = "lblThongTinNhanVien";
            this.lblThongTinNhanVien.Size = new System.Drawing.Size(172, 22);
            this.lblThongTinNhanVien.TabIndex = 1;
            this.lblThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "- Tên Nhân Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "- Năm Sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tính Lương :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "- Ngày Công :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "- Địa Chỉ :";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(154, 170);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(163, 20);
            this.txtTenNhanVien.TabIndex = 9;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(143, 211);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(174, 20);
            this.txtNamSinh.TabIndex = 10;
            // 
            // txtNgayCong
            // 
            this.txtNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayCong.Location = new System.Drawing.Point(143, 329);
            this.txtNgayCong.Name = "txtNgayCong";
            this.txtNgayCong.Size = new System.Drawing.Size(174, 20);
            this.txtNgayCong.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "- Giới Tính:";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(143, 253);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(174, 21);
            this.cbxGioiTinh.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(143, 289);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(174, 20);
            this.txtDiaChi.TabIndex = 15;
            // 
            // dataGridNhanVien
            // 
            this.dataGridNhanVien.AllowUserToDeleteRows = false;
            this.dataGridNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNhanVien,
            this.NamSinh,
            this.GioiTinh,
            this.DiaChi,
            this.NgayCong,
            this.Luong});
            this.dataGridNhanVien.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridNhanVien.Location = new System.Drawing.Point(372, 134);
            this.dataGridNhanVien.Name = "dataGridNhanVien";
            this.dataGridNhanVien.ReadOnly = true;
            this.dataGridNhanVien.Size = new System.Drawing.Size(509, 250);
            this.dataGridNhanVien.TabIndex = 16;
            this.dataGridNhanVien.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridNhanVien_RowHeaderMouseClick);
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // NamSinh
            // 
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgayCong
            // 
            this.NgayCong.HeaderText = "Ngày Công";
            this.NgayCong.Name = "NgayCong";
            this.NgayCong.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // lblDanhSachNV
            // 
            this.lblDanhSachNV.AutoSize = true;
            this.lblDanhSachNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachNV.Location = new System.Drawing.Point(396, 65);
            this.lblDanhSachNV.Name = "lblDanhSachNV";
            this.lblDanhSachNV.Size = new System.Drawing.Size(147, 19);
            this.lblDanhSachNV.TabIndex = 22;
            this.lblDanhSachNV.Text = "Danh sách nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tìm kiếm nhân viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(548, 98);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(201, 20);
            this.txtTimKiem.TabIndex = 24;
            // 
            // lblLuong
            // 
            this.lblLuong.BackColor = System.Drawing.Color.DarkGray;
            this.lblLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLuong.Location = new System.Drawing.Point(143, 394);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(185, 33);
            this.lblLuong.TabIndex = 25;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.DarkGray;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(154, 129);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(163, 20);
            this.txtMaNV.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "- Mã Nhân Viên :";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.Green;
            this.btnThemNV.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnThemNV.IconColor = System.Drawing.Color.Green;
            this.btnThemNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemNV.IconSize = 30;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(372, 401);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemNV.Size = new System.Drawing.Size(112, 38);
            this.btnThemNV.TabIndex = 28;
            this.btnThemNV.Text = "Thêm NV";
            this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCapNhatNV.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnCapNhatNV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCapNhatNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhatNV.IconSize = 25;
            this.btnCapNhatNV.Location = new System.Drawing.Point(501, 401);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(134, 38);
            this.btnCapNhatNV.TabIndex = 29;
            this.btnCapNhatNV.Text = "Cập nhật NV";
            this.btnCapNhatNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhatNV.UseVisualStyleBackColor = true;
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.Red;
            this.btnXoaNV.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnXoaNV.IconColor = System.Drawing.Color.Red;
            this.btnXoaNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaNV.IconSize = 25;
            this.btnXoaNV.Location = new System.Drawing.Point(652, 401);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(97, 38);
            this.btnXoaNV.TabIndex = 30;
            this.btnXoaNV.Text = "Xoá NV";
            this.btnXoaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(773, 401);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(82, 38);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "Thoát";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(604, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(889, 544);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnCapNhatNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDanhSachNV);
            this.Controls.Add(this.dataGridNhanVien);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgayCong);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThongTinNhanVien);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormNhanVien";
            this.Text = "Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblThongTinNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtNgayCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dataGridNhanVien;
        private System.Windows.Forms.Label lblDanhSachNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnThemNV;
        private FontAwesome.Sharp.IconButton btnCapNhatNV;
        private FontAwesome.Sharp.IconButton btnXoaNV;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }


}