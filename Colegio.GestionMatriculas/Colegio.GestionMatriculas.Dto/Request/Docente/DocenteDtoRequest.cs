using Colegio.GestionMatriculas.Comun;
using System.ComponentModel.DataAnnotations;

namespace Colegio.GestionMatriculas.Dto.Request.Docente
{
    public class DocenteDtoRequest : DtoRequestBase
    {
        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// nro de dni docente
        /// </summary>
        public string Dni { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// nombres del docente
        /// </summary>
        public string Nombres { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Apellido paterno del docente
        /// </summary>
        public string ApellidoPaterno { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Apellido materno del docente
        /// </summary>
        public string ApellidoMaterno { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Fecha de nacimiento del docente
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Genero del docente -F:Femenino / M:Masculino
        /// </summary>
        public string Genero { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Especialidad del docente
        /// </summary>
        public string Especialidad { get; set; } = null!;
    }
}
