using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Proyecto_recursos_humanos.Entities;

namespace Proyecto_recursos_humanos
{
    public partial class DBProyectoFinalContext : DbContext
    {
        public DBProyectoFinalContext()
        {
        }

        public DBProyectoFinalContext(DbContextOptions<DBProyectoFinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidato> Candidatos { get; set; } = null!;
        public virtual DbSet<Capacitacione> Capacitaciones { get; set; } = null!;
        public virtual DbSet<Competencia> Competencias { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<ExperienciasLaborale> ExperienciasLaborales { get; set; } = null!;
        public virtual DbSet<Idioma> Idiomas { get; set; } = null!;
        public virtual DbSet<Puesto> Puestos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioCompetencium> UsuarioCompetencia { get; set; } = null!;
        public virtual DbSet<UsuarioIdioma> UsuarioIdiomas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("data source=C:\\Users\\Darianny Peguero\\Source\\Repos\\Proyecto recursos humanos\\Proyecto recursos humanos\\DBProyectoFinal.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidato>(entity =>
            {
                entity.ToTable("candidatos");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Puesto)
                    .WithMany(p => p.Candidatos)
                    .HasForeignKey(d => d.PuestoId);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Candidatos)
                    .HasForeignKey(d => d.UsuarioId);
            });

            modelBuilder.Entity<Capacitacione>(entity =>
            {
                entity.ToTable("capacitaciones");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Capacitaciones)
                    .HasForeignKey(d => d.UsuarioId);
            });

            modelBuilder.Entity<Competencia>(entity =>
            {
                entity.ToTable("competencias");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("empleados");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ExperienciasLaborale>(entity =>
            {
                entity.ToTable("experiencias_laborales");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ExperienciasLaborales)
                    .HasForeignKey(d => d.UsuarioId);
            });

            modelBuilder.Entity<Idioma>(entity =>
            {
                entity.ToTable("idiomas");

                entity.HasIndex(e => e.Name, "IX_idiomas_Name")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.ToTable("puestos");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UsuarioCompetencium>(entity =>
            {
                entity.ToTable("usuario_competencia");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Competencia)
                    .WithMany(p => p.UsuarioCompetencia)
                    .HasForeignKey(d => d.CompetenciaId);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioCompetencia)
                    .HasForeignKey(d => d.UsuarioId);
            });

            modelBuilder.Entity<UsuarioIdioma>(entity =>
            {
                entity.ToTable("usuario_idioma");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Idioma)
                    .WithMany(p => p.UsuarioIdiomas)
                    .HasForeignKey(d => d.IdiomaId);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioIdiomas)
                    .HasForeignKey(d => d.UsuarioId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
