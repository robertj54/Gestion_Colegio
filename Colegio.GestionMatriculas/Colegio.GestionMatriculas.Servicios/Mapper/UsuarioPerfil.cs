using AutoMapper;
using Colegio.GestionMatriculas.Dto.Response.Usuario;
using Colegio.GestionMatriculas.Entidades.Seguridad;
using Colegio.GestionMatriculas.Entidades.Seguridad.Resultados;

namespace Colegio.GestionMatriculas.Servicios.Mapper
{
    public class UsuarioPerfil : Profile
    {
        public UsuarioPerfil()
        {
            CreateMap<UsuarioColaboradorResult, UsuarioColaboradorDtoResponse>();
            CreateMap<UsuarioPermisoInfo, UsuarioPermisoDtoReponse>();
        }
    }
}
