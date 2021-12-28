using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KhoaLuanAspMVC.Models
{
    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=MyDB")
        {
        }

        public virtual DbSet<CHUYENNGANH> CHUYENNGANHs { get; set; }
        public virtual DbSet<CTDAOTAO> CTDAOTAOs { get; set; }
        public virtual DbSet<DIEM> DIEMs { get; set; }
        public virtual DbSet<HOCPHAN> HOCPHANs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<KHOAHOC> KHOAHOCs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUYENNGANH>()
                .Property(e => e.MACN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUYENNGANH>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUYENNGANH>()
                .HasMany(e => e.HOCPHANs)
                .WithRequired(e => e.CHUYENNGANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTDAOTAO>()
                .Property(e => e.MACT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTDAOTAO>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTDAOTAO>()
                .HasMany(e => e.HOCPHANs)
                .WithRequired(e => e.CTDAOTAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.IDHP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MAHP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCPHAN>()
                .Property(e => e.IDHP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCPHAN>()
                .Property(e => e.MAHP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCPHAN>()
                .Property(e => e.MACT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCPHAN>()
                .Property(e => e.MACN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCPHAN>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.HOCPHAN)
                .HasForeignKey(e => new { e.IDHP, e.MAHP })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOA>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOA>()
                .Property(e => e.SODIENTHOAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOAHOC>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOAHOC>()
                .Property(e => e.NAMBD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOAHOC>()
                .Property(e => e.NAMKT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOAHOC>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.SINHVIENs)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MACN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.DIEMs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);
        }
    }
}
