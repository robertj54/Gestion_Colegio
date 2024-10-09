using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request.GradoSecion;
using Colegio.GestionMatriculas.Dto.Response.GradoSeccion;
using Colegio.GestionMatriculas.Entidades;

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
