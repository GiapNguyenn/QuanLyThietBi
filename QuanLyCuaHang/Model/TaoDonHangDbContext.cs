using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCuaHang.Model
{
    public partial class TaoDonHangDbContext : DbContext
    {
        public TaoDonHangDbContext()
            : base("name=TaoDonHangDbContext")
        {
        }

        public virtual DbSet<tblTaoDonHang> tblTaoDonHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblTaoDonHang>()
                .Property(e => e.SDTKhachHang)
                .IsUnicode(false);
        }
    }
}
