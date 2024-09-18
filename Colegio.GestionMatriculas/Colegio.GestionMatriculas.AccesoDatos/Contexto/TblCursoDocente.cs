using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Datos;

public partial class TblCursoDocente
{
    public int Id { get; set; }

    /// <summary>
    /// Id de curso
    /// </summary>
    public int? IdCurso { get; set; }

    /// <summary>
    /// Id de docente
    /// </summary>
    public int? IdDocente { get; set; }

    public virtual TblCurso? IdCursoNavigation { get; set; }

    public virtual TblDocente? IdDocenteNavigation { get; set; }
}
