using Microsoft.AspNetCore.Mvc;
using RegisterService.Data;
using RegisterService.Models;
using RegisterService.Utilities;

namespace RegisterService.Services.Registro
{
    public class RegistroService : IRegistroService
    {
        private readonly ApplicationDbContext _context;
        private readonly EncryptionHelper _encryptionHelper;
        private readonly ILogger<RegistroService> _logger; // Añade el logger

        public RegistroService(ApplicationDbContext context, EncryptionHelper encryptionHelper,
            ILogger<RegistroService> logger)
        {
            _context = context;
            _encryptionHelper = encryptionHelper;
            _logger = logger; // Inicializa el logger
        }

        public async Task<IActionResult> RegistrarUsuarioAsync(RegistroUsuarioRequest request)
        {
            try
            {
                _logger.LogInformation("Iniciando el registro del usuario...");

                // 1. Crear el usuario
                _logger.LogInformation("Creando al usuario...");
                //var encryptedCedula = _encryptionHelper.Encrypt(request.CedulaUsuario);
                var usuario = new Usuario
                {
                    CedulaUsuario = request.CedulaUsuario,
                    NombreUsuario = request.NombreUsuario,
                    ApellidosUsuario = request.ApellidosUsuario,
                    CorreoUsuario = request.CorreoUsuario,
                    CelularUsuario = request.CelularUsuario,
                    TelefonoUsuario = request.TelefonoUsuario,
                    FechaNacimiento = request.FechaNacimiento,
                    DefinicionEtnica = request.DefinicionEtnica,
                    Genero = request.Genero,
                    TieneDiscapacidad = request.TieneDiscapacidad,
                    NumeroCarnetConadis = request.NumeroCarnetConadis,
                    FechaCreacion = DateTime.Now,
                    EstadoActivo = true
                };

                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();

                // 2. Crear la dirección
                _logger.LogInformation("Creando la dirección...");
                var direccion = new Direccion
                {
                    CallePrincipal = request.CallePrincipal,
                    Numeracion = request.Numeracion,
                    CalleSecundaria = request.CalleSecundaria,
                    Sector = request.Sector,
                    Referencia = request.Referencia,
                    CodigoPostal = request.CodigoPostal,
                    ParroquiaId = request.ParroquiaId,
                    UsuarioId = usuario.IdUsuario,
                    EstadoActivo = true
                };

                _context.Direcciones.Add(direccion);
                await _context.SaveChangesAsync();

                // 3. Crear los datos EPN si se proporcionan
                if (!string.IsNullOrEmpty(request.NumeroUnico))
                {
                    _logger.LogInformation("Creando datos EPN...");
                    var datoEPN = new DatoEPN
                    {
                        NumeroUnico = request.NumeroUnico,
                        CorreoInstitucional = request.CorreoInstitucional,
                        Facultad = request.Facultad,
                        Carrera = request.Carrera,
                        Semestre = request.Semestre,
                        UsuarioId = usuario.IdUsuario,
                        EstadoActivo = true
                    };

                    _context.DatosEPN.Add(datoEPN);
                    await _context.SaveChangesAsync();
                }

                // 4. Asignar el rol al usuario
                _logger.LogInformation("Asignando rol al usuario...");
                var usuarioRol = new UsuarioRol
                {
                    UsuarioId = usuario.IdUsuario,
                    RolId = request.RolId,
                    FechaAsignacion = DateTime.Now,
                    EstadoActivo = true
                };

                _context.UsuarioRoles.Add(usuarioRol);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Usuario registrado exitosamente.");
                return new OkObjectResult("Usuario registrado exitosamente.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error inesperado durante el registro del usuario.");
                // Devolver el error completo al frontend, idealmente solo en desarrollo
                return new BadRequestObjectResult(new { success = false, error = ex.Message, details = ex.StackTrace });
            }
        }
    }
}