using AutoMapper;
using Colegio.GestionMatriculas.Comun;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios.Interfaces;

namespace Colegio.GestionMatriculas.Servicios.Implementaciones
{
    public class AlumnoServicio : IAlumnoServicio
    {
        private readonly IAlumnoRepositorio _repositorio;
        private readonly IMapper _mapper;

        public AlumnoServicio(IAlumnoRepositorio repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }



        public async Task<RespuestaPaginacionDto<AlumnoDtoResponse>> Listar(PaginacionDtoRequest request)
        {
            RespuestaPaginacionDto<AlumnoDtoResponse> respuesta = new();
            try
            {
                var resultado = await _repositorio.ListAsync(
                    predicado: p => p.Estado == true,
                    //selector: p => new AlumnoDtoResponse
                    //{
                    //    Id = p.Id,
                    //    Dni = p.Dni,
                    //    Nombres = p.Nombres,
                    //    ApellidoPaterno = p.ApellidoPaterno,
                    //    ApellidoMaterno = p.ApellidoMaterno,
                    //    Genero = p.Genero,
                    //    FechaNacimiento = p.FechaNacimiento
                    //},
                    selector: p => _mapper.Map<AlumnoDtoResponse>(p),
                    orderBy: p => p.Id,
                    pagina: request.NumeroPagina,
                    filas: request.TotalFilas);
                respuesta.Data = resultado.Collection;
                respuesta.success = true;
                respuesta.TotalFilas = resultado.TotalRegistros;
                respuesta.TotalPagina = Utils.CalcularTotalPaginas(resultado.TotalRegistros, request.TotalFilas);
                return respuesta;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<RespuestaBaseDto<AlumnoDtoResponse>> ObtenerPorDNI(string dni)
        {
            RespuestaBaseDto<AlumnoDtoResponse> respuesta = new RespuestaBaseDto<AlumnoDtoResponse>();

            try
            {
                var resultado = await _repositorio.ListAsync(
                    predicado: p => p.Dni == dni,
                    selector: p => _mapper.Map<AlumnoDtoResponse>(p)
                    );
                respuesta.Data = resultado.FirstOrDefault();
                respuesta.success = respuesta.Data != null ? true:false;
                respuesta.message = respuesta.success ? "Alumno encontrado" : "Alumno no encontrado";
            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }

        public async Task<RespuestaBaseDto<AlumnoDtoResponse>> Registrar(AlumnoDtoRequest request)
        {
            RespuestaBaseDto<AlumnoDtoResponse> respuesta = new();
            try
            {
                var alumno = _mapper.Map<TblAlumno>(request);
                var nuevo = await _repositorio.AddAsync(alumno);
                respuesta.Data = _mapper.Map<AlumnoDtoResponse>(nuevo);
                respuesta.success = true;
                respuesta.message = "Cliente registrado exitosamente";
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<RespuestaBaseDto> EliminarPorId(int id)
        {
            RespuestaBaseDto respuesta = new();
            try
            {
                var nuevo = await _repositorio.DeleteByIdAsync(id);
                respuesta.success = true;
                respuesta.message = "Registro de alumno eliminado exitosamente";
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
