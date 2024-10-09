using Colegio.GestionMatriculas.Repositorios.Implementaciones;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Colegio.GestionMatriculas.Repositorios
{
    public static class ColeccionRepositoriosExtension
    {
        public static IServiceCollection AddRepositorios(this IServiceCollection services)
        {
            services.AddScoped<IAlumnoRepositorio, AlumnoRepositorio>();
            services.AddScoped<ICursoRepositorio, CursoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IGradoSeccionRepositorio, GradoSeccionRepositorio>();
            services.AddScoped<IDocenteRepositorio, DocenteRepositorio>();
            return services;
        }

    }
}
