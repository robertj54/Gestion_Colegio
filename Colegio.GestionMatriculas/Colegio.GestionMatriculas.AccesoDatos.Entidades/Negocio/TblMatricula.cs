namespace Colegio.GestionMatriculas.Entidades;

public partial class TblMatricula : EntidadBase
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

    public virtual TblAlumno IdAlumnoNavigation { get; set; } = null!;

    public virtual TblGradoSeccion IdGradoSeccionNavigation { get; set; } = null!;
}
