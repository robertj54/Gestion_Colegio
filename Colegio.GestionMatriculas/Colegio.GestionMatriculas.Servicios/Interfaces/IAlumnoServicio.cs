using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IAlumnoServicio
    {
        Task<RespuestaBaseDto<AlumnoDtoResponse>> Registrar(AlumnoDtoRequest request);
        Task<RespuestaPaginacionDto<AlumnoDtoResponse>> Listar(PaginacionDtoRequest request);
    }
}
