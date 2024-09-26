using Azure.Core;
using Colegio.GestionMatriculas.AccesoDatos.Contexto;
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
        public async Task<IActionResult> Get([FromQuery] PaginacionDtoRequest request)
        {
            var resultado = await _servicio.Listar(request);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

        [HttpGet("GetByDNI/{dni:int}")]
        public async Task<IActionResult> Get(string dni)
        {
            var resultado = await _servicio.ObtenerPorDNI(dni);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

    }
}
