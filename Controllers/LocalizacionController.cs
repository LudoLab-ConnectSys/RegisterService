using Microsoft.AspNetCore.Mvc;
using RegisterService.Services.Localizacion;

namespace RegisterService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocalizacionController : ControllerBase
    {
        private readonly ILocalizacionService _localizacionService;

        public LocalizacionController(ILocalizacionService localizacionService)
        {
            _localizacionService = localizacionService;
        }

        [HttpGet("paises")]
        public async Task<IActionResult> ListarPaises()
        {
            var paises = await _localizacionService.ListarPaisesAsync();
            return Ok(paises);
        }

        [HttpGet("provincias/{paisId}")]
        public async Task<IActionResult> ListarProvinciasPorPais(int paisId)
        {
            var provincias = await _localizacionService.ListarProvinciasPorPaisAsync(paisId);
            return Ok(provincias);
        }

        [HttpGet("cantones/{provinciaId}")]
        public async Task<IActionResult> ListarCantonesPorProvincia(int provinciaId)
        {
            var cantones = await _localizacionService.ListarCantonesPorProvinciaAsync(provinciaId);
            return Ok(cantones);
        }

        [HttpGet("parroquias/{cantonId}")]
        public async Task<IActionResult> ListarParroquiasPorCanton(int cantonId)
        {
            var parroquias = await _localizacionService.ListarParroquiasPorCantonAsync(cantonId);
            return Ok(parroquias);
        }

        [HttpGet("etnias")]
        public async Task<IActionResult> ListarEtnias()
        {
            var etnias = await _localizacionService.ListarEtniasAsync();
            return Ok(etnias);
        }

        // Nuevos endpoints para listar todas las provincias, cantones y parroquias

        [HttpGet("provincias")]
        public async Task<IActionResult> ListarTodasLasProvincias()
        {
            var provincias = await _localizacionService.ListarTodasLasProvinciasAsync();
            return Ok(provincias);
        }

        [HttpGet("cantones")]
        public async Task<IActionResult> ListarTodosLosCantones()
        {
            var cantones = await _localizacionService.ListarTodosLosCantonesAsync();
            return Ok(cantones);
        }

        [HttpGet("parroquias")]
        public async Task<IActionResult> ListarTodasLasParroquias()
        {
            var parroquias = await _localizacionService.ListarTodasLasParroquiasAsync();
            return Ok(parroquias);
        }
    }
}