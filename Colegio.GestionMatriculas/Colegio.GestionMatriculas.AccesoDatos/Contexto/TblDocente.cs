using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Datos;

public partial class TblDocente
{
    public int Id { get; set; }

    public string Dni { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string ApellidoMaterno { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Genero { get; set; } = null!;

    public string Especialidad { get; set; } = null!;

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

    /// <summary>
    /// Usuario modificación registro
    /// </summary>
    public string? UsuarioModificacion { get; set; }

    public virtual ICollection<TblCursoDocente> TblCursoDocentes { get; set; } = new List<TblCursoDocente>();
}
