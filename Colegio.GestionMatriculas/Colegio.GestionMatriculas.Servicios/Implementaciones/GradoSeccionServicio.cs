using AutoMapper;
using Colegio.GestionMatriculas.Comun;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.GradoSecion;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Curso;
using Colegio.GestionMatriculas.Dto.Response.GradoSeccion;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Implementaciones;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Servicios.Implementaciones
{
    public class GradoSeccionServicio : IGradoSeccionServicio
    {
        private IGradoSeccionRepositorio _repositorio;
        private IMapper _mapper;

        public GradoSeccionServicio(IGradoSeccionRepositorio repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }
        public async Task<RespuestaPaginacionDto<GradoSeccionDtoResponse>> Listar(PaginacionDtoRequest request)
        {
            RespuestaPaginacionDto<GradoSeccionDtoResponse> respuesta = new();
            try
            {
                var resultado = await _repositorio.ListAsync(
                    predicado: p => p.Estado == true,

                    selector: p => _mapper.Map<GradoSeccionDtoResponse>(p),
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

        public async Task<RespuestaBaseDto<GradoSeccionDtoResponse>> Registrar(GradoSeccionDtoRequest request)
        {
            RespuestaBaseDto<GradoSeccionDtoResponse> respuesta = new();
            try
            {
                var curso = _mapper.Map<TblGradoSeccion>(request);
                var nuevo = await _repositorio.AddAsync(curso);
                respuesta.Data = _mapper.Map<GradoSeccionDtoResponse>(nuevo);
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
