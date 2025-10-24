using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhamMinhTuan_231230946_de02.Models;

public partial class PhamMinhTuan231230946De02Context : DbContext
{
    public PhamMinhTuan231230946De02Context()
    {
    }

    public PhamMinhTuan231230946De02Context(DbContextOptions<PhamMinhTuan231230946De02Context> options)
        : base(options)
    {
    }
    public virtual DbSet<PmtCatalog> PmtCatalogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=THENAME\\SQLEXPRESS;Database=PhamMinhTuan_231230946_de02;Trusted_Connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PmtCatalog>(entity =>
        {
            entity.HasKey(e => e.PmtId).HasName("PK__pmtCatal__1F78FAC15B6EB0F9");

            entity.ToTable("pmtCatalog");

            entity.Property(e => e.PmtId).HasColumnName("pmtId");
            entity.Property(e => e.PmtCateActive)
                .HasDefaultValue(true)
                .HasColumnName("pmtCateActive");
            entity.Property(e => e.PmtCateName)
                .HasMaxLength(100)
                .HasColumnName("pmtCateName");
            entity.Property(e => e.PmtCatePrice).HasColumnName("pmtCatePrice");
            entity.Property(e => e.PmtCateQty).HasColumnName("pmtCateQty");
            entity.Property(e => e.PmtPicture)
                .HasMaxLength(255)
                .HasColumnName("pmtPicture");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
