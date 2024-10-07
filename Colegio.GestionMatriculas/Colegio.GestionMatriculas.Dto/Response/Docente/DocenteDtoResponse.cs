using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Dto.Response.Docente
{
    public class DocenteDtoResponse : DtoResponseBase
    {
        /// <summary>
        /// Id del docente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nro de dni docente
        /// </summary>
        public string Dni { get; set; } = null!;

        /// <summary>
        /// nombres del docente
        /// </summary>
        public string Nombres { get; set; } = null!;

        /// <summary>
        /// Apellido paterno del docente
        /// </summary>
        public string ApellidoPaterno { get; set; } = null!;

        /// <summary>
        /// Apellido materno del docente
        /// </summary>
        public string ApellidoMaterno { get; set; } = null!;

        /// <summary>
        /// Fecha de nacimiento del docente
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Genero del docente -F:Femenino / M:Masculino
        /// </summary>
        public string Genero { get; set; } = null!;

        /// <summary>
        /// Especialidad del docente
        /// </summary>
        public string Especialidad { get; set; } = null!;
    }
}
