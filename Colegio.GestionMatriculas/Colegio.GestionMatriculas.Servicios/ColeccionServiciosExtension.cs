using Colegio.GestionMatriculas.Servicios.Implementaciones;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Colegio.GestionMatriculas.Servicios
{
    public static class ColeccionServiciosExtension
    {
        public static IServiceCollection AddServicios(this IServiceCollection services)
        {

            services.AddScoped<IAlumnoServicio, AlumnoServicio>();
            services.AddScoped<ICursoServicio, CursoServicio>();
            services.AddScoped<IGradoSeccionServicio, GradoSeccionServicio>();
            services.AddScoped<IDocenteServicio, DocenteServicio>();

            services.AddScoped<IUsuarioServicio, UsuarioServicio>();
            return services;
        }
    }
}
