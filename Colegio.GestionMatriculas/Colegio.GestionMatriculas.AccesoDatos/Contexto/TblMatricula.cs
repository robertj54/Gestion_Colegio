using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Contexto;

public partial class TblMatricula
{
    /// <summary>
    /// Id de matricula
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Codigo de matricula
    /// </summary>
    public string? Codigo { get; set; }

    /// <summary>
    /// Fecha de matricula
    /// </summary>
    public string? FechaMatricula { get; set; }

    /// <summary>
    /// Periodo de matricula
    /// </summary>
    public string? Periodo { get; set; }

    /// <summary>
    /// Id de alumno
    /// </summary>
    public int IdAlumno { get; set; }

    /// <summary>
    /// Id de grado seccion
    /// </summary>
    public int IdGradoSeccion { get; set; }

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

    public virtual TblAlumno IdAlumnoNavigation { get; set; } = null!;

    public virtual TblGradoSeccion IdGradoSeccionNavigation { get; set; } = null!;
}
