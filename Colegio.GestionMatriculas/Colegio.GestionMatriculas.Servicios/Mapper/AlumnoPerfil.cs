using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using Colegio.GestionMatriculas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Servicios.Mapper
{
    public class AlumnoPerfil:Profile
    {
        public AlumnoPerfil()
        {
            CreateMap<AlumnoDtoRequest, TblAlumno>();
            CreateMap<TblAlumno, AlumnoDtoResponse>();
        }
    }
}
