using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Alumno;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PaginacionDtoRequest request)
        {
            var resultado = await _servicio.Listar(request);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

        [Authorize]
        [HttpGet("GetByDNI/{dni:int}")]
        public async Task<IActionResult> Get(string dni)
        {
            var resultado = await _servicio.ObtenerPorDNI(dni);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(AlumnoDtoRequest request)
        {
            var resultado = await _servicio.Registrar(request);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> Eliminar(int id)
        {
            var resultado = await _servicio.EliminarPorId(id);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

    }
}
