using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Contexto;

public partial class TblGradoSeccion
{
    /// <summary>
    /// Id del grado seccion
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Grado de estudio
    /// </summary>
    public string Grado { get; set; } = null!;

    /// <summary>
    /// Nivel de instruccion
    /// </summary>
    public string Nivel { get; set; } = null!;

    /// <summary>
    /// Seccion del grado
    /// </summary>
    public string Seccion { get; set; } = null!;

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

    public virtual ICollection<TblCursoGradoSeccion> TblCursoGradoSeccions { get; set; } = new List<TblCursoGradoSeccion>();

    public virtual ICollection<TblMatricula> TblMatriculas { get; set; } = new List<TblMatricula>();
}
