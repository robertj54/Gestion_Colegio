using Colegio.GestionMatriculas.Dto.Request.GradoSecion;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Response.GradoSeccion;
using Colegio.GestionMatriculas.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colegio.GestionMatriculas.Dto.Response.Docente;
using Colegio.GestionMatriculas.Dto.Request.Docente;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IDocenteServicio
    {
        Task<RespuestaBaseDto<DocenteDtoResponse>> Registrar(DocenteDtoRequest request);
        Task<RespuestaPaginacionDto<DocenteDtoResponse>> Listar(PaginacionDtoRequest request);
        Task<RespuestaBaseDto<bool>> EliminarPorId(string id);
    }
}
