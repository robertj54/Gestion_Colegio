using Colegio.GestionMatriculas.Dto.Request;
using Colegio.GestionMatriculas.Dto.Request.GradoSecion;
using Colegio.GestionMatriculas.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Colegio.GestionMatriculas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradoSeccionController : ControllerBase
    {
        private IGradoSeccionServicio _servicio;

        public GradoSeccionController(IGradoSeccionServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PaginacionDtoRequest request)
        {
            var resultado = await _servicio.Listar(request);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GradoSeccionDtoRequest request)
        {
            var resultado = await _servicio.Registrar(request);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }

        [HttpDelete]
        public async Task<IActionResult> Eliminar(int id)
        {
            var resultado = await _servicio.EliminarPorId(id);
            return resultado.success ? Ok(resultado) : BadRequest(resultado);
        }
    }
}
