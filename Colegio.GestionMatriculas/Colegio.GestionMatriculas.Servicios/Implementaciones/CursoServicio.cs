﻿using AutoMapper;
using Colegio.GestionMatriculas.Comun;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Curso;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using Colegio.GestionMatriculas.Dto.Response.Curso;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<RespuestaBaseDto<bool>> EliminarPorId(string id)
        {
            throw new NotImplementedException();
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
