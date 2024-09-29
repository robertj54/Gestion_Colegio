using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.Entidades;

public class TblCurso : EntidadBase
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

    public virtual ICollection<TblCursoDocente> TblCursoDocentes { get; set; } = new List<TblCursoDocente>();

    public virtual ICollection<TblCursoGradoSeccion> TblCursoGradoSeccions { get; set; } = new List<TblCursoGradoSeccion>();
}
