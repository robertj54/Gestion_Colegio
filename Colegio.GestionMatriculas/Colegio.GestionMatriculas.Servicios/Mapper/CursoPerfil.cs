using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request.Curso;
using Colegio.GestionMatriculas.Dto.Response.Curso;
using Colegio.GestionMatriculas.Entidades;

namespace Colegio.GestionMatriculas.Servicios.Mapper
{
    public class CursoPerfil : Profile
    {
        public CursoPerfil()
        {
            CreateMap<CursoDtoRequest, TblCurso>();
            CreateMap<TblCurso, CursoDtoResponse>();
        }
    }
}
