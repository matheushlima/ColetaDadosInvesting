using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Trade.Core.Entities;

namespace Trade.Infrastructure.Models
{
    public partial class tradeContext : DbContext
    {
        public tradeContext()
        {
        }

        public tradeContext(DbContextOptions<tradeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcaoTb> AcaoTbs { get; set; } = null!;
        public virtual DbSet<MoedaTb> MoedaTbs { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcaoTb>(entity =>
            {
                entity.ToTable("acao_tb");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.DataHora).HasColumnName("data_hora");

                entity.Property(e => e.Maxima).HasColumnName("maxima");

                entity.Property(e => e.Minima).HasColumnName("minima");

                entity.Property(e => e.Nome).HasColumnName("nome");

                entity.Property(e => e.Ultimo).HasColumnName("ultimo");

                entity.Property(e => e.Variacao).HasColumnName("variacao");

                entity.Property(e => e.VariacaoPorcent).HasColumnName("variacao_porcent");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<MoedaTb>(entity =>
            {
                entity.ToTable("moeda_tb");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Compra).HasColumnName("compra");

                entity.Property(e => e.DataHora).HasColumnName("data_hora");

                entity.Property(e => e.Maxima).HasColumnName("maxima");

                entity.Property(e => e.Minima).HasColumnName("minima");

                entity.Property(e => e.Nome).HasColumnName("nome");

                entity.Property(e => e.Variacao).HasColumnName("variacao");

                entity.Property(e => e.VariacaoPorcent).HasColumnName("variacao_porcent");

                entity.Property(e => e.Venda).HasColumnName("venda");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
