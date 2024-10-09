namespace Colegio.GestionMatriculas.Dto.Response.Curso
{
    public class CursoDtoResponse : DtoResponseBase
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

    }
}
