using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Response;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IServicioBase<TDtoResponse, TDtoRequest> where TDtoResponse : DtoResponseBase where TDtoRequest : DtoRequestBase
    {
        Task<RespuestaBaseDto<TDtoResponse>> Registrar(TDtoRequest request);
        Task<RespuestaPaginacionDto<TDtoResponse>> Listar(PaginacionDtoRequest request);
        Task<RespuestaBaseDto> EliminarPorId(int id);
    }
}
