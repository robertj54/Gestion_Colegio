using Colegio.GestionMatriculas.Servicios.Implementaciones;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Servicios
{
    public static class ColeccionServiciosExtension
    {
        public static IServiceCollection AddServicios(this IServiceCollection services)
        {

            services.AddScoped<IAlumnoServicio, AlumnoServicio>();
            services.AddScoped<ICursoServicio, CursoServicio>();
            return services;
        }
    }
}
