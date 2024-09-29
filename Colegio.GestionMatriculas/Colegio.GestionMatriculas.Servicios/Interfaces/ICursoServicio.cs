using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Curso;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface ICursoServicio
    {
        Task<RespuestaBaseDto<CursoDtoResponse>> Registrar(CursoDtoRequest request);
        Task<RespuestaPaginacionDto<CursoDtoResponse>> Listar(PaginacionDtoRequest request);
    }
}
