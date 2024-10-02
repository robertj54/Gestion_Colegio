using AutoMapper;
using Colegio.GestionMatriculas.Dto.Response.Usuario;
using Colegio.GestionMatriculas.Entidades.Seguridad.Resultados;
using Colegio.GestionMatriculas.Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
