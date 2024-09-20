using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Dto.Request
{
    public  class PaginacionDtoRequest
    {
        public int NumeroPagina { get; set; }
        public int TotalFilas { get; set; }
    }
}
