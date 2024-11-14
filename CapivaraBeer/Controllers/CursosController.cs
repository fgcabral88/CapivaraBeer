using CapivaraBeer.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CapivaraBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ICursosService _cursosServices;

        public CursosController(ICursosService cursosServices)
        {
            _cursosServices = cursosServices;
        }

        [HttpGet]
        [Route("RetornarCursosAsync")]
        public async Task<IActionResult> RetornarCursosAsync()
        {
            var retornarCursos = await _cursosServices.RetornarCursosAsync();

            return Ok(retornarCursos);
        }
    }
}
