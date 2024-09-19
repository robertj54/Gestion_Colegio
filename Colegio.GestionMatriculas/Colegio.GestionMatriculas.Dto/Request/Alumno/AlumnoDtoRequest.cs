using Colegio.GestionMatriculas.Comun;
using System.ComponentModel.DataAnnotations;

namespace Colegio.GestionMatriculas.Dto.Request.Alumno
{
    public class AlumnoDtoRequest
    {
        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// DNI alumno
        /// </summary>
        public string Dni { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Nombres alumno
        /// </summary>
        public string Nombres { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Apellido paterno
        /// </summary>
        public string ApellidoPaterno { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Apellido materno
        /// </summary>
        public string ApellidoMaterno { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Genero alumno
        /// </summary>
        public string Genero { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Fecha nacimiento
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
    }
}