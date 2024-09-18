using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Colegio.GestionMatriculas.AccesoDatos.Datos;

public partial class BdGestionColegioContext : DbContext
{
    public BdGestionColegioContext()
    {
    }

    public BdGestionColegioContext(DbContextOptions<BdGestionColegioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAlumno> TblAlumnos { get; set; }

    public virtual DbSet<TblCurso> TblCursos { get; set; }

    public virtual DbSet<TblCursoDocente> TblCursoDocentes { get; set; }

    public virtual DbSet<TblCursoGradoSeccion> TblCursoGradoSeccions { get; set; }

    public virtual DbSet<TblDocente> TblDocentes { get; set; }

    public virtual DbSet<TblGradoSeccion> TblGradoSeccions { get; set; }

    public virtual DbSet<TblMatricula> TblMatriculas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(local); database=BD_GestionColegio; integrated security=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<TblAlumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblAlumn__3214EC07FD692BEA");

            entity.ToTable("tblAlumno");

            entity.Property(e => e.Id).HasComment("Id Alumno");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Apellido materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Apellido paterno");
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("DNI alumno")
                .HasColumnName("DNI");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.FechaNacimiento).HasComment("Fecha nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Genero alumno");
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("Nombres alumno");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("USUSQL")
                .HasComment("Usuario creación registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCurso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCurso__3214EC0718CF988A");

            entity.ToTable("tblCurso");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.Nivel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("USUSQL")
                .HasComment("Usuario creación registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario modificación registro");
            entity.Property(e => e.Vigente).HasDefaultValue(true);
        });

        modelBuilder.Entity<TblCursoDocente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCurso__3214EC07EFDEC4B7");

            entity.ToTable("tblCurso_Docente");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdCurso).HasComment("Id de curso");
            entity.Property(e => e.IdDocente).HasComment("Id de docente");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.TblCursoDocentes)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__tblCurso___IdCur__3B75D760");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.TblCursoDocentes)
                .HasForeignKey(d => d.IdDocente)
                .HasConstraintName("FK__tblCurso___IdDoc__3C69FB99");
        });

        modelBuilder.Entity<TblCursoGradoSeccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCurso__3214EC070ADA1E58");

            entity.ToTable("tblCurso_GradoSeccion");

            entity.Property(e => e.IdCurso).HasComment("Id de curso");
            entity.Property(e => e.IdGradoSeccion).HasComment("Id de grado seccion");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.TblCursoGradoSeccions)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCurso_GradoSeccion_tblCurso");

            entity.HasOne(d => d.IdGradoSeccionNavigation).WithMany(p => p.TblCursoGradoSeccions)
                .HasForeignKey(d => d.IdGradoSeccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCurso_GradoSeccion_tblGradoSeccion");
        });

        modelBuilder.Entity<TblDocente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblDocen__3214EC07E2731678");

            entity.ToTable("tblDocente");

            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DNI");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("USUSQL")
                .HasComment("Usuario creación registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario modificación registro");
        });

        modelBuilder.Entity<TblGradoSeccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGrado__3214EC0776BD1E52");

            entity.ToTable("tblGradoSeccion");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.Grado)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Nivel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seccion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("USUSQL")
                .HasComment("Usuario creación registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario modificación registro");
        });

        modelBuilder.Entity<TblMatricula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblMatri__3214EC079B81593D");

            entity.ToTable("tblMatricula");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaMatricula)
                .HasMaxLength(10)
                .HasDefaultValueSql("(getdate())")
                .IsFixedLength();
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.Periodo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("USUSQL")
                .HasComment("Usuario creación registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario modificación registro");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.TblMatriculas)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMatricula_tblAlumno");

            entity.HasOne(d => d.IdGradoSeccionNavigation).WithMany(p => p.TblMatriculas)
                .HasForeignKey(d => d.IdGradoSeccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMatricula_tblGradoSeccion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
