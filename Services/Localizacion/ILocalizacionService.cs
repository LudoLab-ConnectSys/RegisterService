namespace RegisterService.Services.Localizacion
{
    public interface ILocalizacionService
    {
        Task<IEnumerable<CatalogoPais>> ListarPaisesAsync();
        Task<IEnumerable<CatalogoProvincia>> ListarProvinciasPorPaisAsync(int paisId);
        Task<IEnumerable<CatalogoCanton>> ListarCantonesPorProvinciaAsync(int provinciaId);
        Task<IEnumerable<CatalogoParroquia>> ListarParroquiasPorCantonAsync(int cantonId);
        Task<IEnumerable<Etnia>> ListarEtniasAsync();

        // Nuevas funciones para listar todas las provincias, cantones y parroquias
        Task<IEnumerable<CatalogoProvincia>> ListarTodasLasProvinciasAsync();
        Task<IEnumerable<CatalogoCanton>> ListarTodosLosCantonesAsync();
        Task<IEnumerable<CatalogoParroquia>> ListarTodasLasParroquiasAsync();
    }
}