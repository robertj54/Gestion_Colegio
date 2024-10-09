using AutoMapper;
using Colegio.GestionMatriculas.Dto.Request.Docente;
using Colegio.GestionMatriculas.Dto.Response.Docente;
using Colegio.GestionMatriculas.Entidades;

namespace Colegio.GestionMatriculas.Servicios.Mapper
{
    public class DocentePerfil : Profile
    {
        public DocentePerfil()
        {
            CreateMap<DocenteDtoRequest, TblDocente>();
            CreateMap<TblDocente, DocenteDtoResponse>();
        }
    }
}
