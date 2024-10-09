namespace Colegio.GestionMatriculas.Entidades;

public partial class TblGradoSeccion : EntidadBase
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

    public virtual ICollection<TblCursoGradoSeccion> TblCursoGradoSeccions { get; set; } = new List<TblCursoGradoSeccion>();

    public virtual ICollection<TblMatricula> TblMatriculas { get; set; } = new List<TblMatricula>();
}
