using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Dto.Response
{
    public class RespuestaPaginacionDto<T>:RespuestaBaseDto
    {
        public ICollection<T>? Data { get; set; }
        public int TotalPagina { get; set; }
        public int TotalFilas { get; set; }
    }
}
