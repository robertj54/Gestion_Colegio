using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using Colegio.GestionMatriculas.Entidades;

namespace Colegio.GestionMatriculas.Servicios.Mapper
{
    public class AlumnoPerfil : Profile
    {
        public AlumnoPerfil()
        {
            CreateMap<AlumnoDtoRequest, TblAlumno>();
            CreateMap<TblAlumno, AlumnoDtoResponse>();
        }
    }
}
