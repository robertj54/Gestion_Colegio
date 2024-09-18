using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Datos;

public partial class TblAlumno
{
    /// <summary>
    /// Id Alumno
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// DNI alumno
    /// </summary>
    public string Dni { get; set; } = null!;

    /// <summary>
    /// Nombres alumno
    /// </summary>
    public string Nombres { get; set; } = null!;

    /// <summary>
    /// Apellido paterno
    /// </summary>
    public string ApellidoPaterno { get; set; } = null!;

    /// <summary>
    /// Apellido materno
    /// </summary>
    public string ApellidoMaterno { get; set; } = null!;

    /// <summary>
    /// Genero alumno
    /// </summary>
    public string Genero { get; set; } = null!;

    /// <summary>
    /// Fecha nacimiento
    /// </summary>
    public DateOnly FechaNacimiento { get; set; }

    /// <summary>
    /// Fecha creación registro
    /// </summary>
    public DateOnly FechaCreacion { get; set; }

    /// <summary>
    /// Usuario creación registro
    /// </summary>
    public string UsuarioCreacion { get; set; } = null!;

    /// <summary>
    /// Fecha modificación registro
    /// </summary>
    public DateOnly? FechaModificacion { get; set; }

    public string? UsuarioModificacion { get; set; }

    public virtual ICollection<TblMatricula> TblMatriculas { get; set; } = new List<TblMatricula>();
}
