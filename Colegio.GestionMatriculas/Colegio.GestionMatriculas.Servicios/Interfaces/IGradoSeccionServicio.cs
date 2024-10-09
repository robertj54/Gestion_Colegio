using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.GradoSecion;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.GradoSeccion;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IGradoSeccionServicio:IServicioBase<GradoSeccionDtoResponse, GradoSeccionDtoRequest>
    {
        //Task<RespuestaBaseDto<GradoSeccionDtoResponse>> Registrar(GradoSeccionDtoRequest request);
        //Task<RespuestaPaginacionDto<GradoSeccionDtoResponse>> Listar(PaginacionDtoRequest request);
    }
}
