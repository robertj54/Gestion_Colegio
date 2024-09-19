using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Dto.Response
{
    public class RespuestaBaseDto
    {
        public string? message { get; set; }
        public bool success { get; set; }
    }

    public class RespuestaBaseDto<T> : RespuestaBaseDto
    {
        public T? Data { get; set; }
    }
}
