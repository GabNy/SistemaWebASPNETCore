using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaWebProdutos.Models
{
    public partial class sistwebContext : DbContext
    {
        public sistwebContext()
        {
        }

        public sistwebContext(DbContextOptions<sistwebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>(entity =>
            {
                entity.HasKey(e => e.ProdCodigo);

                entity.Property(e => e.ProdCodigo).HasColumnName("Prod_Codigo");

                entity.Property(e => e.ProdNome)
                    .IsRequired()
                    .HasColumnName("Prod_Nome")
                    .HasMaxLength(20);

                entity.Property(e => e.ProdPreco)
                    .HasColumnName("Prod_Preco")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ProdQtde).HasColumnName("Prod_Qtde");
            });
        }
    }
}
