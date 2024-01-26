﻿using Microsoft.EntityFrameworkCore;

namespace ASPNETCore.WebApi.Models
{
    public partial class ficaihmgContext : DbContext
    {
        public ficaihmgContext()
        {
        }

        public ficaihmgContext(DbContextOptions<ficaihmgContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbaluno> Tbaluno { get; set; }
        public virtual DbSet<Tbescola> Tbescola { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbaluno>(entity =>
            {
                entity.HasKey(e => e.AluId)
                    .HasName("PK__TBALUNO__73BC0203B8187FA0");

                entity.Property(e => e.AluEndNmrLog).IsFixedLength();

                entity.Property(e => e.AluImportado).IsFixedLength();

                entity.Property(e => e.AluSexo).IsFixedLength();

                entity.Property(e => e.AluStatus)
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength();

                entity.Property(e => e.AluTelCel).IsFixedLength();

                entity.Property(e => e.AluTelCelDdd).IsFixedLength();

                entity.Property(e => e.AluTelCon).IsFixedLength();

                entity.Property(e => e.AluTelConDdd).IsFixedLength();

                entity.Property(e => e.AluTelRes).IsFixedLength();

                entity.Property(e => e.AluTelResDdd).IsFixedLength();
            });

            modelBuilder.Entity<Tbescola>(entity =>
            {
                entity.HasKey(e => e.EscId)
                    .HasName("PK__TBESCOLA__EC68EC58DEDDB78C");

                entity.Property(e => e.EscCategoria).IsFixedLength();

                entity.Property(e => e.EscEndCidNom).IsFixedLength();

                entity.Property(e => e.EscEndNmrLog).IsFixedLength();

                entity.Property(e => e.EscImportada).IsFixedLength();

                entity.Property(e => e.EscStatus)
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength();

                entity.Property(e => e.EscTel).IsFixedLength();

                entity.Property(e => e.EscTelDdd).IsFixedLength();

                entity.Property(e => e.EscTipo).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}