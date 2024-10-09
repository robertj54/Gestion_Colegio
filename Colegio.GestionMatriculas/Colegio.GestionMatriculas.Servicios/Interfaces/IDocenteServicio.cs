using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Docente;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Docente;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IDocenteServicio:IServicioBase<DocenteDtoResponse, DocenteDtoRequest>
    {
        //Task<RespuestaBaseDto<DocenteDtoResponse>> Registrar(DocenteDtoRequest request);
        //Task<RespuestaPaginacionDto<DocenteDtoResponse>> Listar(PaginacionDtoRequest request);
        //Task<RespuestaBaseDto<bool>> EliminarPorId(string id);
    }
}
