using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.Curso;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.GestionMatriculas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private ICursoServicio _servicio;

        public CursosController(ICursoServicio servicio)
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
        [HttpPost]
        public async Task<IActionResult> Post(CursoDtoRequest request)
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
