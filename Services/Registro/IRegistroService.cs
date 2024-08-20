using Microsoft.AspNetCore.Mvc;
using RegisterService.Models;

namespace RegisterService.Services.Registro
{
    public interface IRegistroService
    {
        Task<IActionResult> RegistrarUsuarioAsync(RegistroUsuarioRequest request);
    }
}