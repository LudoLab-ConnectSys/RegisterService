using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RegisterService.Models;

[Table("DatoEPN")]
public class DatoEPN
{
    [Key] [Column("EPNId")] public int EPNId { get; set; }

    [Column("UsuarioId")] public int UsuarioId { get; set; }

    [Required] [Column("NumeroUnico")] public string NumeroUnico { get; set; }

    [Required]
    [Column("CorreoInstitucional")]
    public string CorreoInstitucional { get; set; }

    [Column("Facultad")] public string? Facultad { get; set; }

    [Column("Carrera")] public string? Carrera { get; set; }

    [Column("Semestre")] public int? Semestre { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("UsuarioId")] [JsonIgnore] public Usuario? Usuario { get; set; }
}