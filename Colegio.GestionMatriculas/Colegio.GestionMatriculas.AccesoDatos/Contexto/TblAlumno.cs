using System;
using System.Collections.Generic;

namespace Colegio.GestionMatriculas.AccesoDatos.Contexto;

public partial class TblAlumno : EntidadBase
{


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




    public virtual ICollection<TblMatricula> TblMatriculas { get; set; } = new List<TblMatricula>();
}
