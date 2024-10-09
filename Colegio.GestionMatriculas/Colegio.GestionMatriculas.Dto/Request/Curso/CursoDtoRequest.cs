using Colegio.GestionMatriculas.Comun;
using System.ComponentModel.DataAnnotations;

namespace Colegio.GestionMatriculas.Dto.Request.Curso
{
    public class CursoDtoRequest : DtoRequestBase
    {
        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Nombre de curso
        /// </summary>
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Descripcion de curso
        /// </summary>
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = Constantes.Mensaje_Requerido)]
        /// <summary>
        /// Nivel de instruccion
        /// </summary>
        public string Nivel { get; set; } = null!;
    }
}
