using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.GestionMatriculas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private IAlumnoServicio _servicio;

        public AlumnosController(IAlumnoServicio servicio)
        {
            _servicio = servicio;
        }



        [HttpGet]
        public IActionResult Get([FromQuery] PaginacionDtoRequest request)
        {
            var resultado = _servicio.Listar(request);
            return Ok(resultado);
            //return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }
            
    }
}
