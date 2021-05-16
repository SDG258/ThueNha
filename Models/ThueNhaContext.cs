using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ThueNha.Models
{
    public partial class ThueNhaContext : DbContext
    {
        public ThueNhaContext()
        {
        }

        public ThueNhaContext(DbContextOptions<ThueNhaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChuNha> ChuNhas { get; set; }
        public virtual DbSet<NguoiThue> NguoiThues { get; set; }
        public virtual DbSet<NhaChoThue> NhaChoThues { get; set; }
        public virtual DbSet<PhieuDangKyChoThue> PhieuDangKyChoThues { get; set; }
        public virtual DbSet<PhieuDiaChi> PhieuDiaChis { get; set; }
        public virtual DbSet<PhieuKhaoSat> PhieuKhaoSats { get; set; }
        public virtual DbSet<PhieuThueNha> PhieuThueNhas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BR58CHK\\SQLEXPRESS;Database=ThueNha;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChuNha>(entity =>
            {
                entity.HasKey(e => e.Cmnd);

                entity.ToTable("ChuNha");

                entity.Property(e => e.Cmnd)
                    .ValueGeneratedNever()
                    .HasColumnName("CMND");

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NguoiThue>(entity =>
            {
                entity.HasKey(e => e.MaNguoiThue);

                entity.ToTable("NguoiThue");

                entity.Property(e => e.Cmnd).HasColumnName("CMND");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NgaySinh).HasColumnType("date");
            });

            modelBuilder.Entity<NhaChoThue>(entity =>
            {
                entity.HasKey(e => e.MaNhaChoThue);

                entity.ToTable("NhaChoThue");

                entity.Property(e => e.Cmnd).HasColumnName("CMND");

                entity.Property(e => e.DacDiem)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Quan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CmndNavigation)
                    .WithMany(p => p.NhaChoThues)
                    .HasForeignKey(d => d.Cmnd)
                    .HasConstraintName("FK_NhaChoThue_ChuNha");
            });

            modelBuilder.Entity<PhieuDangKyChoThue>(entity =>
            {
                entity.HasKey(e => e.MaDk)
                    .HasName("PK_PhieuDangKy");

                entity.ToTable("PhieuDangKyChoThue");

                entity.Property(e => e.MaDk).HasColumnName("MaDK");

                entity.Property(e => e.NgayDk)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayDK");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKT");

                entity.HasOne(d => d.MaNhaChoThueNavigation)
                    .WithMany(p => p.PhieuDangKyChoThues)
                    .HasForeignKey(d => d.MaNhaChoThue)
                    .HasConstraintName("FK_PhieuDangKyChoThue_NhaChoThue");
            });

            modelBuilder.Entity<PhieuDiaChi>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDiaChi);

                entity.ToTable("PhieuDiaChi");

                entity.Property(e => e.ThoiGianXemNha).HasColumnType("datetime");

                entity.HasOne(d => d.MaNhaChoThueNavigation)
                    .WithMany(p => p.PhieuDiaChis)
                    .HasForeignKey(d => d.MaNhaChoThue)
                    .HasConstraintName("FK_PhieuDiaChi_NhaChoThue");

                entity.HasOne(d => d.MaPhieuThueNhaNavigation)
                    .WithMany(p => p.PhieuDiaChis)
                    .HasForeignKey(d => d.MaPhieuThueNha)
                    .HasConstraintName("FK_PhieuDiaChi_PhieuThueNha");
            });

            modelBuilder.Entity<PhieuKhaoSat>(entity =>
            {
                entity.HasKey(e => e.MaPkx)
                    .HasName("PK_PhieuKhaoXac");

                entity.ToTable("PhieuKhaoSat");

                entity.Property(e => e.MaPkx).HasColumnName("MaPKX");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MaDk).HasColumnName("MaDK");

                entity.HasOne(d => d.MaDkNavigation)
                    .WithMany(p => p.PhieuKhaoSats)
                    .HasForeignKey(d => d.MaDk)
                    .HasConstraintName("FK_PhieuKhaoSat_PhieuDangKyChoThue");
            });

            modelBuilder.Entity<PhieuThueNha>(entity =>
            {
                entity.HasKey(e => e.MaPhieuThueNha);

                entity.ToTable("PhieuThueNha");

                entity.Property(e => e.MaPhieuThueNha).ValueGeneratedNever();

                entity.HasOne(d => d.MaNguoiThueNavigation)
                    .WithMany(p => p.PhieuThueNhas)
                    .HasForeignKey(d => d.MaNguoiThue)
                    .HasConstraintName("FK_PhieuThueNha_NguoiThue");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
