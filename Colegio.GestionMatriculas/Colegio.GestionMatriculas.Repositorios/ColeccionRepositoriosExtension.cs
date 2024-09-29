using Colegio.GestionMatriculas.Repositorios.Implementaciones;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Repositorios
{
    public static  class ColeccionRepositoriosExtension
    {
        public static IServiceCollection AddRepositorios(this IServiceCollection services)
        {
            services.AddScoped<IAlumnoRepositorio, AlumnoRepositorio>();
            services.AddScoped<ICursoRepositorio, CursoRepositorio>();
            return services;
        }

    }
}
