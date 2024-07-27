using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("DatoEPN")]
public class EpnData
{
    [Key] [Column("EPNId")] public int EPNId { get; set; }

    [Required] [Column("UsuarioId")] public int UsuarioId { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("NumeroUnico")]
    public string NumeroUnico { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("CorreoInstitucional")]
    public string CorreoInstitucional { get; set; }

    [MaxLength(255)] [Column("Facultad")] public string Facultad { get; set; }

    [MaxLength(255)] [Column("Carrera")] public string Carrera { get; set; }

    [Column("Semestre")] public int? Semestre { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("UsuarioId")] public User? Usuario { get; set; }
}