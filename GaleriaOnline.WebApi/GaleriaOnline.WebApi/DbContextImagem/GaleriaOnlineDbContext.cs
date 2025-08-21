using System;
using System.Collections.Generic;
using GaleriaOnline.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GaleriaOnline.WebApi.DbContextImagem;

public partial class GaleriaOnlineDbContext : DbContext
{
    public GaleriaOnlineDbContext()
    {
    }

    public GaleriaOnlineDbContext(DbContextOptions<GaleriaOnlineDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Imagem> Imagens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server=G15-MVINICIUS;Database=GaleriaOnlineDB;Trusted_Connection=True;TrustServerCertificate=True;");
        => optionsBuilder.UseSqlServer("Server=DESKTOP-LAO5MIJ\\SQLEXPRESSTEC;Database=UploadImagemDB;user Id = sa; Pwd=abc123;TrustServerCertificate=True;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Imagem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Imagens__3214EC0738DF8966");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
