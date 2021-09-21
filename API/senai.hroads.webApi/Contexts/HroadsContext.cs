using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.hroads.webApi.Domains;

#nullable disable

namespace senai.hroads.webApi.Contexts
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Habilidadeclasse> Habilidadeclasses { get; set; }
        public virtual DbSet<Personagem> Personagens { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }
        public virtual DbSet<Tipousuario> Tipousuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=NOTE0113I5\\SQLEXPRESS; initial catalog=HROADS_13GP; user Id=sa; pwd=Senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__CLASSE__60FFF801966AACAA");

                entity.ToTable("CLASSE");

                entity.Property(e => e.IdClasse)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idClasse");

                entity.Property(e => e.NomeClasse)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeClasse");
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__HABILIDA__655F7528436A364F");

                entity.ToTable("HABILIDADE");

                entity.Property(e => e.IdHabilidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idHabilidade");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.NomeHabilidade)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeHabilidade");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK__HABILIDAD__idTip__38996AB5");
            });

            modelBuilder.Entity<Habilidadeclasse>(entity =>
            {
                entity.HasKey(e => e.IdHabilidadeClasse)
                    .HasName("PK__HABILIDA__777709CA98F3C96F");

                entity.ToTable("HABILIDADECLASSE");

                entity.Property(e => e.IdHabilidadeClasse)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idHabilidadeClasse");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Habilidadeclasses)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__HABILIDAD__idCla__3D5E1FD2");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany(p => p.Habilidadeclasses)
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__HABILIDAD__idHab__3E52440B");
            });

            modelBuilder.Entity<Personagem>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__PERSONAG__02B7D48C84F25418");

                entity.ToTable("PERSONAGEM");

                entity.HasIndex(e => e.NomePersonagem, "UQ__PERSONAG__2075C7B874BD0B1C")
                    .IsUnique();

                entity.Property(e => e.IdPersoagem).HasColumnName("idPersoagem");

                entity.Property(e => e.DataAtualizacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dataAtualizacao")
                    .IsFixedLength(true);

                entity.Property(e => e.DataCriacao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dataCriacao")
                    .IsFixedLength(true);

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.NomeJogador)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nomeJogador");

                entity.Property(e => e.NomePersonagem)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nomePersonagem");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Personagens)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__PERSONAGE__idCla__4222D4EF");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__TIPO__BDD0DFE16A734718");

                entity.ToTable("TIPO");

                entity.Property(e => e.IdTipo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idTipo");

                entity.Property(e => e.NomeTipo)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("nomeTipo");
            });

            modelBuilder.Entity<Tipousuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TIPOUSUA__03006BFFFCD9BDA4");

                entity.ToTable("TIPOUSUARIO");

                entity.Property(e => e.IdTipoUsuario)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nomeTipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIO__645723A677F77B3D");

                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.EmailUsuario, "UQ__USUARIO__ACC1DD99E6D6C643")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.EmailUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emailUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeUsuario");

                entity.Property(e => e.SenhaUsuario)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("senhaUsuario");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__USUARIO__idTipoU__4AB81AF0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
