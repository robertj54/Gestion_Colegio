﻿using Colegio.GestionMatriculas.Dto.Request;
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

        public AlumnoServicio(IAlumnoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<RespuestaPaginacionDto<AlumnoDtoResponse>> Listar(PaginacionDtoRequest request)
        {

            RespuestaPaginacionDto<AlumnoDtoResponse> respuesta = new();
            try
            {
                var resultado = await _repositorio.ListAsync();

                //respuesta.Data = resultado;
                respuesta.success = true;
                return respuesta;

            }
            catch (Exception)
            {

                throw;
            }
            

           
        }

        public Task<RespuestaBaseDto<AlumnoDtoResponse>> Registrar(AlumnoDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
