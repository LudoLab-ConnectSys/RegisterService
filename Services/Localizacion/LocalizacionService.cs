using Microsoft.EntityFrameworkCore;
using RegisterService.Data;

namespace RegisterService.Services.Localizacion
{
    public class LocalizacionService : ILocalizacionService
    {
        private readonly ApplicationDbContext _context;

        public LocalizacionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CatalogoPais>> ListarPaisesAsync()
        {
            return await _context.CatalogoPaises.Where(p => p.EstadoActivo).ToListAsync();
        }

        public async Task<IEnumerable<CatalogoProvincia>> ListarProvinciasPorPaisAsync(int paisId)
        {
            return await _context.CatalogoProvincias
                .Where(p => p.PaisId == paisId && p.EstadoActivo)
                .ToListAsync();
        }

        public async Task<IEnumerable<CatalogoCanton>> ListarCantonesPorProvinciaAsync(int provinciaId)
        {
            return await _context.CatalogoCantones
                .Where(c => c.ProvinciaId == provinciaId && c.EstadoActivo)
                .ToListAsync();
        }

        public async Task<IEnumerable<CatalogoParroquia>> ListarParroquiasPorCantonAsync(int cantonId)
        {
            return await _context.CatalogoParroquias
                .Where(p => p.CantonId == cantonId && p.EstadoActivo)
                .ToListAsync();
        }

        public async Task<IEnumerable<Etnia>> ListarEtniasAsync()
        {
            return await _context.Etnias.Where(e => e.EstadoActivo).ToListAsync();
        }

        // Implementaciones de las nuevas funciones

        public async Task<IEnumerable<CatalogoProvincia>> ListarTodasLasProvinciasAsync()
        {
            return await _context.CatalogoProvincias.Where(p => p.EstadoActivo).ToListAsync();
        }

        public async Task<IEnumerable<CatalogoCanton>> ListarTodosLosCantonesAsync()
        {
            return await _context.CatalogoCantones.Where(c => c.EstadoActivo).ToListAsync();
        }

        public async Task<IEnumerable<CatalogoParroquia>> ListarTodasLasParroquiasAsync()
        {
            return await _context.CatalogoParroquias.Where(p => p.EstadoActivo).ToListAsync();
        }
    }
}