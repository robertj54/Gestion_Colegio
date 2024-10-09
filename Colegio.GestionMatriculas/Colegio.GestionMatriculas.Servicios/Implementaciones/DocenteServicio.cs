using AutoMapper;
using Colegio.GestionMatriculas.Comun;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Docente;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Docente;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios.Interfaces;

namespace Colegio.GestionMatriculas.Servicios.Implementaciones
{
    public class DocenteServicio : IDocenteServicio
    {
        private IDocenteRepositorio _repositorio;
        private IMapper _mapper;

        public DocenteServicio(IDocenteRepositorio repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<RespuestaBaseDto> EliminarPorId(int id)
        {
            RespuestaBaseDto respuesta = new();
            try
            {
                var nuevo = await _repositorio.DeleteByIdAsync(id);
                respuesta.success = nuevo;
                respuesta.message = nuevo ? "Registro de docente eliminado exitosamente" : "Docente no encontrado";
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<RespuestaPaginacionDto<DocenteDtoResponse>> Listar(PaginacionDtoRequest request)
        {
            RespuestaPaginacionDto<DocenteDtoResponse> respuesta = new();
            try
            {
                var resultado = await _repositorio.ListAsync(
                    predicado: p => p.Estado == true,

                    selector: p => _mapper.Map<DocenteDtoResponse>(p),
                    orderBy: p => p.Id,
                    pagina: request.NumeroPagina,
                    filas: request.TotalFilas);
                respuesta.Data = resultado.Collection;
                respuesta.success = true;
                respuesta.TotalFilas = resultado.TotalRegistros;
                respuesta.TotalPagina = Utils.CalcularTotalPaginas(resultado.TotalRegistros, request.TotalFilas);
                return respuesta;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RespuestaBaseDto<DocenteDtoResponse>> Registrar(DocenteDtoRequest request)
        {
            RespuestaBaseDto<DocenteDtoResponse> respuesta = new();
            try
            {
                var curso = _mapper.Map<TblDocente>(request);
                var nuevo = await _repositorio.AddAsync(curso);
                respuesta.Data = _mapper.Map<DocenteDtoResponse>(nuevo);
                respuesta.success = true;
                respuesta.message = "Curso registrado exitosamente";
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
