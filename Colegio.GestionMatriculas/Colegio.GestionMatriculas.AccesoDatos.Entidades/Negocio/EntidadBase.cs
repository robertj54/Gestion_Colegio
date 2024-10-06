using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Entidades
{
    public class EntidadBase
    {
        /// <summary>
        /// Identificador del registro, autoincremental
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 0 - Inactivo / 1 - Activo
        /// </summary>
        public bool Estado { get; set; } = true;

        /// <summary>
        /// Fecha creación registro
        /// </summary>
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        /// <summary>
        /// Usuario creación registro
        /// </summary>
        public string UsuarioCreacion { get; set; } = Environment.UserName!;

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
