using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaVotacionAutomatizada.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidatos> Candidatos { get; set; }
        public virtual DbSet<Ciudadanos> Ciudadanos { get; set; }
        public virtual DbSet<Elecciones> Elecciones { get; set; }
        public virtual DbSet<Partidos> Partidos { get; set; }
        public virtual DbSet<PuestoElectivos> PuestoElectivos { get; set; }
        public virtual DbSet<VotosElecciones> VotosElecciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-L4MO65IR\\SQLEXPRESS;Database=VotacionDB;persist security info=True;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Candidatos>(entity =>
            {
                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PartidoId).HasColumnName("PartidoID");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PuestoElectivosId).HasColumnName("Puesto_electivosID");

                entity.HasOne(d => d.Partido)
                    .WithMany(p => p.Candidatos)
                    .HasForeignKey(d => d.PartidoId)
                    .HasConstraintName("FK__Candidato__Parti__70DDC3D8");

                entity.HasOne(d => d.PuestoElectivos)
                    .WithMany(p => p.Candidatos)
                    .HasForeignKey(d => d.PuestoElectivosId)
                    .HasConstraintName("FK__Candidato__Puest__71D1E811");
            });

            modelBuilder.Entity<Ciudadanos>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Elecciones>(entity =>
            {
                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Partidos>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PuestoElectivos>(entity =>
            {
                entity.ToTable("Puesto_electivos");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VotosElecciones>(entity =>
            {
                entity.Property(e => e.CandidatoId).HasColumnName("CandidatoID");

                entity.Property(e => e.EleccionId).HasColumnName("EleccionID");

                entity.HasOne(d => d.Candidato)
                    .WithMany(p => p.VotosElecciones)
                    .HasForeignKey(d => d.CandidatoId)
                    .HasConstraintName("FK__VotosElec__Candi__75A278F5");

                entity.HasOne(d => d.Eleccion)
                    .WithMany(p => p.VotosElecciones)
                    .HasForeignKey(d => d.EleccionId)
                    .HasConstraintName("FK__VotosElec__Elecc__74AE54BC");
            });
        }
    }
}
