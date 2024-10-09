using Colegio.GestionMatriculas.Comun;
using System.ComponentModel.DataAnnotations;

namespace Colegio.GestionMatriculas.Dto.Request.GradoSecion
{
    public class GradoSeccionDtoRequest : DtoRequestBase
    {
        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Grado de estudio
        /// </summary>
        public string Grado { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Nivel de instruccion
        /// </summary>
        public string Nivel { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Seccion del grado
        /// </summary>
        public string Seccion { get; set; } = null!;
    }
}
