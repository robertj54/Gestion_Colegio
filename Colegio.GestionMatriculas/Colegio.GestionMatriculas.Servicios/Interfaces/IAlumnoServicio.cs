using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Alumno;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IAlumnoServicio : IServicioBase<AlumnoDtoResponse, AlumnoDtoRequest>
    {
        //Task<RespuestaBaseDto<AlumnoDtoResponse>> Registrar(AlumnoDtoRequest request);
        //Task<RespuestaPaginacionDto<AlumnoDtoResponse>> Listar(PaginacionDtoRequest request);
        Task<RespuestaBaseDto<AlumnoDtoResponse>> ObtenerPorDNI(string dni);
        //Task<bool> EliminarPorId(int id);
    }
}
