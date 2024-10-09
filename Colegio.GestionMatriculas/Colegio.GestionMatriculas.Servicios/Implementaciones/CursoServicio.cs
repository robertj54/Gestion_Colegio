using AutoMapper;
using Colegio.GestionMatriculas.Comun;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Curso;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Curso;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios.Interfaces;

namespace Colegio.GestionMatriculas.Servicios.Implementaciones
{
    public class CursoServicio : ICursoServicio
    {
        private ICursoRepositorio _repositorio;
        private IMapper _mapper;

        public CursoServicio(ICursoRepositorio repositorio, IMapper mapper)
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
                respuesta.success = true;
                respuesta.message = "Registro de Curso eliminado exitosamente";
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<RespuestaPaginacionDto<CursoDtoResponse>> Listar(PaginacionDtoRequest request)
        {
            RespuestaPaginacionDto<CursoDtoResponse> respuesta = new();
            try
            {
                var resultado = await _repositorio.ListAsync(
                    predicado: p => p.Estado == true,

                    selector: p => _mapper.Map<CursoDtoResponse>(p),
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

        public async Task<RespuestaBaseDto<CursoDtoResponse>> Registrar(CursoDtoRequest request)
        {
            RespuestaBaseDto<CursoDtoResponse> respuesta = new();
            try
            {
                var curso = _mapper.Map<TblCurso>(request);
                var nuevo = await _repositorio.AddAsync(curso);
                respuesta.Data = _mapper.Map<CursoDtoResponse>(nuevo);
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
