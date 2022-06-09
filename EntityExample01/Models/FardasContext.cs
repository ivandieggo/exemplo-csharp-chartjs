using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityExample01.Models
{
    public partial class FardasContext : DbContext
    {
        public FardasContext()
        {
        }

        public FardasContext(DbContextOptions<FardasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CamisaJogo> CamisaJogos { get; set; }
        public virtual DbSet<Esporte> Esportes { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemLote> ItemLotes { get; set; }
        public virtual DbSet<Lote> Lotes { get; set; }
        public virtual DbSet<TipoCamisa> TipoCamisas { get; set; }
        public virtual DbSet<TipoItem> TipoItems { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HT1H0C4\\SQLEXPRESS;Database=Fardas;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<CamisaJogo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CamisaJogo");

                entity.Property(e => e.DescricaoCamisaJogo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdCamisaJogo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Esporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Esporte");

                entity.Property(e => e.IdEsporte).HasColumnName("idEsporte");

                entity.Property(e => e.IdTime)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idTime");

                entity.Property(e => e.NomeTime)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nomeTime");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Item");

                entity.Property(e => e.Ativo).HasColumnName("ativo");

                entity.Property(e => e.DescricaoItem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descricaoItem");

                entity.Property(e => e.IdDisponibilidade).HasColumnName("idDisponibilidade");

                entity.Property(e => e.IdItem)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idItem");

                entity.Property(e => e.IdOrigem).HasColumnName("idOrigem");

                entity.Property(e => e.IdTime).HasColumnName("idTime");

                entity.Property(e => e.IdTipoItem).HasColumnName("idTipoItem");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.ValorAnunciado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorAnunciado");

                entity.Property(e => e.ValorCompra)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorCompra");

                entity.Property(e => e.ValorPromo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorPromo");

                entity.Property(e => e.ValorVendaEfetivo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorVendaEfetivo");
            });

            modelBuilder.Entity<ItemLote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemLote");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.IdItemLote).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Lote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lote");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DescricaoLote)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdLote).ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioAtualizacao)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoCamisa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TipoCamisa");

                entity.Property(e => e.DescricaoTipoCamisa)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoCamisa)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idTipoCamisa");
            });

            modelBuilder.Entity<TipoItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TipoItem");

                entity.Property(e => e.DescricaoTipoItem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descricaoTipoItem");

                entity.Property(e => e.IdTipoItem).HasColumnName("idTipoItem");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
