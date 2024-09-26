﻿using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                respuesta.TotalPagina = (int)Math.Ceiling((double)resultado.TotalRegistros / request.TotalFilas);
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
                respuesta.success = true;
                respuesta.message = "Alumno encontrado";
            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }

        public Task<RespuestaBaseDto<AlumnoDtoResponse>> Registrar(AlumnoDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
