using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using generic_repository_04.DMO;

namespace generic_repository_04.DataAccessLayer;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Islem> Islems { get; set; }

    public virtual DbSet<Kitap> Kitaps { get; set; }

    public virtual DbSet<Ogrenci> Ogrencis { get; set; }

    public virtual DbSet<Siniflar> Siniflars { get; set; }

    public virtual DbSet<Tur> Turs { get; set; }

    public virtual DbSet<Yazar> Yazars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Turkish_CI_AS");

        modelBuilder.Entity<Islem>(entity =>
        {
            entity.HasKey(e => e.Islemno);

            entity.ToTable("islem");

            entity.Property(e => e.Islemno).HasColumnName("islemno");
            entity.Property(e => e.Atarih).HasColumnName("atarih");
            entity.Property(e => e.Kitapno).HasColumnName("kitapno");
            entity.Property(e => e.Ogrno).HasColumnName("ogrno");
            entity.Property(e => e.Vtarih).HasColumnName("vtarih");

            entity.HasOne(d => d.KitapnoNavigation).WithMany(p => p.Islems)
                .HasForeignKey(d => d.Kitapno)
                .HasConstraintName("FK_islem_kitap");

            entity.HasOne(d => d.OgrnoNavigation).WithMany(p => p.Islems)
                .HasForeignKey(d => d.Ogrno)
                .HasConstraintName("FK_islem_ogrenci");
        });

        modelBuilder.Entity<Kitap>(entity =>
        {
            entity.HasKey(e => e.Kitapno);

            entity.ToTable("kitap");

            entity.Property(e => e.Kitapno).HasColumnName("kitapno");
            entity.Property(e => e.Ad)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Puan).HasColumnName("puan");
            entity.Property(e => e.Sayfasayisi).HasColumnName("sayfasayisi");
            entity.Property(e => e.Turno).HasColumnName("turno");
            entity.Property(e => e.Yazarno).HasColumnName("yazarno");

            entity.HasOne(d => d.TurnoNavigation).WithMany(p => p.Kitaps)
                .HasForeignKey(d => d.Turno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_kitap_tur");

            entity.HasOne(d => d.YazarnoNavigation).WithMany(p => p.Kitaps)
                .HasForeignKey(d => d.Yazarno)
                .HasConstraintName("FK_kitap_yazar1");
        });

        modelBuilder.Entity<Ogrenci>(entity =>
        {
            entity.HasKey(e => e.Ogrno);

            entity.ToTable("ogrenci");

            entity.Property(e => e.Ogrno).HasColumnName("ogrno");
            entity.Property(e => e.Ad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Cinsiyet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cinsiyet");
            entity.Property(e => e.Dtarih)
                .HasColumnType("datetime")
                .HasColumnName("dtarih");
            entity.Property(e => e.Puan).HasColumnName("puan");
            entity.Property(e => e.Sinif)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("sinif");
            entity.Property(e => e.Soyad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("soyad");
        });

        modelBuilder.Entity<Siniflar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("siniflar");

            entity.Property(e => e.Ad)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("ad");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tur>(entity =>
        {
            entity.HasKey(e => e.Turno);

            entity.ToTable("tur");

            entity.Property(e => e.Turno).HasColumnName("turno");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("ad");
        });

        modelBuilder.Entity<Yazar>(entity =>
        {
            entity.HasKey(e => e.Yazarno);

            entity.ToTable("yazar");

            entity.Property(e => e.Yazarno)
                .ValueGeneratedNever()
                .HasColumnName("yazarno");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("soyad");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
