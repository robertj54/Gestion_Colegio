using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Entidades.Seguridad.Resultados
{
    public class UsuarioPermisoInfo
    {
        public int IdUsuario { get; set; }
        public string Colaborador { get; set; }
        public string CorreoElectronico { get; set; }
        public string Puesto { get; set; }
        public string Usuario { get; set; }
        public string Permisos { get; set; }
    }
}
