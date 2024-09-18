using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Entidades.Negocio
{
    public class EntidadBase
    {
        /// <summary>
        /// Fecha creación registro
        /// </summary>
        public DateOnly FechaCreacion { get; set; }

        /// <summary>
        /// Usuario creación registro
        /// </summary>
        public string UsuarioCreacion { get; set; } = null!;

        /// <summary>
        /// Fecha modificación registro
        /// </summary>
        public DateOnly? FechaModificacion { get; set; }

        /// <summary>
        /// Usuario modificacion registro
        /// </summary>
        public string? UsuarioModificacion { get; set; }
    }
}
