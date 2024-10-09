using AutoMapper;
using Colegio.GestionMatriculas.Servicios.Mapper;

namespace Colegio.GestionMatriculas.Servicios
{
    public static class ColeccionPerfilesMapperExtension
    {
        public static IMapperConfigurationExpression AddPerfilesMapper(this IMapperConfigurationExpression config)
        {
            config.AddProfile<AlumnoPerfil>();
            config.AddProfile<CursoPerfil>();
            config.AddProfile<UsuarioPerfil>();
            config.AddProfile<GradoSeccionPerfil>();
            return config;
        }
    }
}
