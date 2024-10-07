using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using Colegio.GestionMatriculas.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colegio.GestionMatriculas.Entidades;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IServicioBase<TDtoResponse> where TDtoResponse : DtoResponseBase
    {
        Task<RespuestaBaseDto<TDtoResponse>> Registrar(DtoResponseBase request);
        Task<RespuestaPaginacionDto<TDtoResponse>> Listar(PaginacionDtoRequest request);
        Task<bool> EliminarPorId(int id);
    }
}
