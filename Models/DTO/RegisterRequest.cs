using System;

namespace RegisterService.Models
{
    public class RegisterRequest
    {
        public string TipoUsuario { get; set; }
        public bool EsEstudianteEpn { get; set; } = false;
        public string? TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int? DefinicionEtnica { get; set; } = 5;
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string ConfirmarCorreo { get; set; }
        public string Celular { get; set; }
        public string? TelefonoConvencional { get; set; }

        public int ParroquiaId { get; set; }
        public string CallePrincipal { get; set; }
        public string Numeracion { get; set; }
        public string CalleSecundaria { get; set; }
        public string Sector { get; set; }
        public string Referencia { get; set; }
        public string CodigoPostal { get; set; }
        public bool TieneDiscapacidad { get; set; } = false;
        public string? NumeroCarnetConadis { get; set; }
        public string? CodigoUnico { get; set; }
        public string? CorreoInstitucional { get; set; }
        public string? Facultad { get; set; }
        public string? Carrera { get; set; }
        public int? SemestreActual { get; set; }
    }
}