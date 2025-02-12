﻿using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Contexto;

public partial class TblCursoGradoSeccion
{
    public int Id { get; set; }

    /// <summary>
    /// Id de curso
    /// </summary>
    public int IdCurso { get; set; }

    /// <summary>
    /// Id de grado seccion
    /// </summary>
    public int IdGradoSeccion { get; set; }

    public bool Estado { get; set; }

    public virtual TblCurso IdCursoNavigation { get; set; } = null!;

    public virtual TblGradoSeccion IdGradoSeccionNavigation { get; set; } = null!;
}
