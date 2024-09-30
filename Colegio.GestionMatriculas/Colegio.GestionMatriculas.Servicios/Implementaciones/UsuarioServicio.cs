using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request.Usuario;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Usuario;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Servicios.Implementaciones
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private IUsuarioRepositorio _repositorio;
        private IMapper _mapper;
        private IConfiguration _configuracion;
        public UsuarioServicio(IUsuarioRepositorio repositorio, IMapper mapper, IConfiguration configuracion)
        {
            _repositorio = repositorio;
            _mapper = mapper;
            _configuracion = configuracion;
        }

        public async Task<RespuestaBaseDto<UsuarioColaboradorDtoResponse>> ObtenerColaboradorPorUsuario(string usuario)
        {
            RespuestaBaseDto<UsuarioColaboradorDtoResponse> respuesta = new();
            try
            {
                var resultado = await _repositorio.ObtenerColaboradorPorUsuario(usuario);
                respuesta.Data = _mapper.Map<UsuarioColaboradorDtoResponse>(resultado);
                respuesta.success = true;
            }
            catch (Exception ex)
            {
                respuesta.success = false;
                respuesta.message = ex.Message;
            }
            return respuesta;
        }


        public async Task<RespuestaBaseDto<UsuarioPermisoDtoReponse>> ListarPermisosPorUsuario(string usuario)
        {
            RespuestaBaseDto<UsuarioPermisoDtoReponse> respuesta = new();
            try
            {
                var resultado = await _repositorio.ListarPermisosPorUsuario(usuario);
                respuesta.Data = _mapper.Map<UsuarioPermisoDtoReponse>(resultado);
                respuesta.success = true;
            }
            catch (Exception ex)
            {
                respuesta.success = false;
                respuesta.message = ex.Message;
            }
            return respuesta;
        }

        public Task<RespuestaBaseDto<LoginDtoResponse>> AutenticarUsuario(LoginDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
