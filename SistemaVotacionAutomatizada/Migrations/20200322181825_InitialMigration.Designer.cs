﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaVotacionAutomatizada.Models;

namespace SistemaVotacionAutomatizada.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200322181825_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.Candidatos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("apellido")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .HasColumnName("estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<int?>("PartidoId")
                        .HasColumnName("PartidoID");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnName("photo")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int?>("PuestoElectivosId")
                        .HasColumnName("Puesto_electivosID");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.HasIndex("PuestoElectivosId");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.Ciudadanos", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.Property<string>("Apellido")
                        .HasColumnName("apellido")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .HasColumnName("estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Ciudadanos");
                });

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.Elecciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Estado")
                        .HasColumnName("estado");

                    b.Property<DateTime?>("Fecha")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("fecha")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Elecciones");
                });

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.Partidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnName("descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .HasColumnName("estado");

                    b.Property<string>("Logo")
                        .HasColumnName("logo")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.PuestoElectivos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .HasColumnName("estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Puesto_electivos");
                });

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.VotosElecciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidatoId")
                        .HasColumnName("CandidatoID");

                    b.Property<int?>("EleccionId")
                        .HasColumnName("EleccionID");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.HasIndex("EleccionId");

                    b.ToTable("VotosElecciones");
                });

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.Candidatos", b =>
                {
                    b.HasOne("SistemaVotacionAutomatizada.Models.Partidos", "Partido")
                        .WithMany("Candidatos")
                        .HasForeignKey("PartidoId")
                        .HasConstraintName("FK__Candidato__Parti__70DDC3D8");

                    b.HasOne("SistemaVotacionAutomatizada.Models.PuestoElectivos", "PuestoElectivos")
                        .WithMany("Candidatos")
                        .HasForeignKey("PuestoElectivosId")
                        .HasConstraintName("FK__Candidato__Puest__71D1E811");
                });

            modelBuilder.Entity("SistemaVotacionAutomatizada.Models.VotosElecciones", b =>
                {
                    b.HasOne("SistemaVotacionAutomatizada.Models.Candidatos", "Candidato")
                        .WithMany("VotosElecciones")
                        .HasForeignKey("CandidatoId")
                        .HasConstraintName("FK__VotosElec__Candi__75A278F5");

                    b.HasOne("SistemaVotacionAutomatizada.Models.Elecciones", "Eleccion")
                        .WithMany("VotosElecciones")
                        .HasForeignKey("EleccionId")
                        .HasConstraintName("FK__VotosElec__Elecc__74AE54BC");
                });
#pragma warning restore 612, 618
        }
    }
}
