using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Curso;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Curso;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface ICursoServicio:IServicioBase<CursoDtoResponse, CursoDtoRequest>
    {
        //Task<RespuestaBaseDto<CursoDtoResponse>> Registrar(CursoDtoRequest request);
        //Task<RespuestaPaginacionDto<CursoDtoResponse>> Listar(PaginacionDtoRequest request);
        //Task<RespuestaBaseDto<bool>> EliminarPorId(string id);
    }
}
