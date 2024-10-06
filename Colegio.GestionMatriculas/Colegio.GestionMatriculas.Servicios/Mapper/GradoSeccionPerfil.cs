using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request.Curso;
using Colegio.GestionMatriculas.Dto.Request.GradoSecion;
using Colegio.GestionMatriculas.Dto.Response.Curso;
using Colegio.GestionMatriculas.Dto.Response.GradoSeccion;
using Colegio.GestionMatriculas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Servicios.Mapper
{
    public class GradoSeccionPerfil : Profile
    {
        public GradoSeccionPerfil()
        {
            CreateMap<GradoSeccionDtoRequest, TblGradoSeccion>();
            CreateMap<TblGradoSeccion, GradoSeccionDtoResponse>();
        }
    }
}
