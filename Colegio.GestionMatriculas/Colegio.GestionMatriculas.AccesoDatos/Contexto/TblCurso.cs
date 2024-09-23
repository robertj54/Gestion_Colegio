using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Contexto;

public partial class TblCurso
{
    /// <summary>
    /// Id del curso
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre de curso
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripcion de curso
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Nivel de instruccion
    /// </summary>
    public string Nivel { get; set; } = null!;

    /// <summary>
    /// Estado de vigencia de curso - 0:Inactivo / 1:Activo
    /// </summary>
    public bool? Vigente { get; set; }

    public bool Estado { get; set; }

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
