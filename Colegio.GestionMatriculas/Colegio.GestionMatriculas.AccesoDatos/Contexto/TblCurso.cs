using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Datos;

public partial class TblCurso
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Nivel { get; set; } = null!;

    public bool? Vigente { get; set; }

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

    public virtual ICollection<TblCursoGradoSeccion> TblCursoGradoSeccions { get; set; } = new List<TblCursoGradoSeccion>();
}
