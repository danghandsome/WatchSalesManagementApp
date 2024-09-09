using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanDongHo.Modules
{
    public partial class QLBanDongHoContextDB : DbContext
    {
        public QLBanDongHoContextDB()
            : base("name=QLBanDongHoContextDB")
        {
        }

        public virtual DbSet<DongHo> DongHoes { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<LoaiTK> LoaiTKs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DongHo>()
                .HasMany(e => e.GioHangs)
                .WithRequired(e => e.DongHo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DongHo>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.DongHo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.GioHangs)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);
        }
    }
}
