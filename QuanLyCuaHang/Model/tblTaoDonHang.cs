namespace QuanLyCuaHang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTaoDonHang")]
    public partial class tblTaoDonHang
    {
        [Key]
        [StringLength(50)]
        public string MaDonHang { get; set; }

        [StringLength(50)]
        public string TenKhachHang { get; set; }

        [StringLength(50)]
        public string SDTKhachHang { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(50)]
        public string MaSP { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }

        public int ThanhTien { get; set; }
    }
}
