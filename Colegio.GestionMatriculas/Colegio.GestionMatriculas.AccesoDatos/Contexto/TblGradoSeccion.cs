using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Datos;

public partial class TblGradoSeccion
{
    public int Id { get; set; }

    public string Grado { get; set; } = null!;

    public string Nivel { get; set; } = null!;

    public string Seccion { get; set; } = null!;

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
