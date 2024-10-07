using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Dto.Response.GradoSeccion
{
    public class GradoSeccionDtoResponse : DtoResponseBase
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
    }
}
