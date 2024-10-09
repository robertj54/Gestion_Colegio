namespace Colegio.GestionMatriculas.Dto.Response.Alumno
{
    public class AlumnoDtoResponse : DtoResponseBase
    {
        /// <summary>
        /// Id Alumno
        /// </summary>
        public int Id { get; set; }

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
        public DateTime FechaNacimiento { get; set; }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - FechaNacimiento.Year;
            }
        }
    }
}
