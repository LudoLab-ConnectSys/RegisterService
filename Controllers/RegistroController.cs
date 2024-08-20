using Microsoft.AspNetCore.Mvc;
using RegisterService.Models;
using RegisterService.Services.Registro;

namespace RegisterService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroController : ControllerBase
    {
        private readonly IRegistroService _registroService;

        public RegistroController(IRegistroService registroService)
        {
            _registroService = registroService;
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarUsuario([FromBody] RegistroUsuarioRequest request)
        {
            try
            {
                var result = await _registroService.RegistrarUsuarioAsync(request);

                if (result is OkObjectResult)
                {
                    return Ok(new { success = true });
                }

                return BadRequest(new { success = false });
            }
            catch (Exception ex)
            {
                // Loguear el error y devolver una respuesta detallada
                return BadRequest(new { success = false, error = ex.Message, details = ex.StackTrace });
            }
        }
    }
}