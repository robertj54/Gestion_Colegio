﻿using Colegio.GestionMatriculas.Dto.Request.Usuario;
using Colegio.GestionMatriculas.Dto.Response;
using Colegio.GestionMatriculas.Dto.Response.Usuario;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<RespuestaBaseDto<UsuarioColaboradorDtoResponse>> ObtenerColaboradorPorUsuario(string usuario);
        Task<RespuestaBaseDto<UsuarioPermisoDtoReponse>> ListarPermisosPorUsuario(string usuario);
        Task<RespuestaBaseDto<LoginDtoResponse>> AutenticarUsuario(LoginDtoRequest request);
    }
}
