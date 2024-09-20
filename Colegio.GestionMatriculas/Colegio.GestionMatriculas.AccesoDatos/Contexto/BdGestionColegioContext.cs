using System;
using System.Collections.Generic;
using Colegio.GestionMatriculas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Colegio.GestionMatriculas.AccesoDatos.Contexto;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<TblAlumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblAlumn__3214EC070F03C848");

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
                .IsUnicode(false)
                .HasComment("Usuario modificacion registro");
        });

        modelBuilder.Entity<TblCurso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCurso__3214EC071F74C501");

            entity.ToTable("tblCurso");

            entity.Property(e => e.Id).HasComment("Id del curso");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Descripcion de curso");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.Nivel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nivel de instruccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Nombre de curso");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("USUSQL")
                .HasComment("Usuario creación registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario modificación registro");
            entity.Property(e => e.Vigente)
                .HasDefaultValue(true)
                .HasComment("Estado de vigencia de curso - 0:Inactivo / 1:Activo");
        });

        modelBuilder.Entity<TblCursoDocente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCurso__3214EC07D813020A");

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
            entity.HasKey(e => e.Id).HasName("PK__tblCurso__3214EC07DBFC06FD");

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
            entity.HasKey(e => e.Id).HasName("PK__tblDocen__3214EC073A990114");

            entity.ToTable("tblDocente");

            entity.Property(e => e.Id).HasComment("Id del docente");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Apellido materno del docente");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Apellido paterno del docente");
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("nro de dni docente")
                .HasColumnName("DNI");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("Especialidad del docente");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.FechaNacimiento).HasComment("Fecha de nacimiento del docente");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Genero del docente -F:Femenino / M:Masculino");
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("nombres del docente");
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
            entity.HasKey(e => e.Id).HasName("PK__tblGrado__3214EC0736BDAA99");

            entity.ToTable("tblGradoSeccion");

            entity.Property(e => e.Id).HasComment("Id del grado seccion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.Grado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasComment("Grado de estudio");
            entity.Property(e => e.Nivel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nivel de instruccion");
            entity.Property(e => e.Seccion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Seccion del grado");
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
            entity.HasKey(e => e.Id).HasName("PK__tblMatri__3214EC07FE567B3D");

            entity.ToTable("tblMatricula");

            entity.Property(e => e.Id).HasComment("Id de matricula");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("Codigo de matricula");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha creación registro");
            entity.Property(e => e.FechaMatricula)
                .HasMaxLength(10)
                .HasDefaultValueSql("(getdate())")
                .IsFixedLength()
                .HasComment("Fecha de matricula");
            entity.Property(e => e.FechaModificacion).HasComment("Fecha modificación registro");
            entity.Property(e => e.IdAlumno).HasComment("Id de alumno");
            entity.Property(e => e.IdGradoSeccion).HasComment("Id de grado seccion");
            entity.Property(e => e.Periodo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasComment("Periodo de matricula");
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
