using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Response.Alumno;
using Colegio.GestionMatriculas.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colegio.GestionMatriculas.Dto.Request.GradoSecion;
using Colegio.GestionMatriculas.Dto.Response.GradoSeccion;

namespace Colegio.GestionMatriculas.Servicios.Interfaces
{
    public interface IGradoSeccionServicio
    {
        Task<RespuestaBaseDto<GradoSeccionDtoResponse>> Registrar(GradoSeccionDtoRequest request);
        Task<RespuestaPaginacionDto<GradoSeccionDtoResponse>> Listar(PaginacionDtoRequest request);
    }
}
