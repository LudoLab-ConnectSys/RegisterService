using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("Direccion")]
public class Address
{
    [Key] [Column("DireccionId")] public int DireccionId { get; set; }

    [MaxLength(255)]
    [Column("CallePrincipal")]
    public string CallePrincipal { get; set; }

    [MaxLength(50)] [Column("Numeracion")] public string Numeracion { get; set; }

    [MaxLength(255)]
    [Column("CalleSecundaria")]
    public string CalleSecundaria { get; set; }

    [MaxLength(255)] [Column("Sector")] public string Sector { get; set; }

    [MaxLength(255)]
    [Column("Referencia")]
    public string Referencia { get; set; }

    [MaxLength(50)]
    [Column("CodigoPostal")]
    public string CodigoPostal { get; set; }

    [Required] [Column("UsuarioId")] public int UsuarioId { get; set; }

    [Required] [Column("ParroquiaId")] public int ParroquiaId { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("UsuarioId")] public User? Usuario { get; set; }

    [ForeignKey("ParroquiaId")] public ParishCatalog? Parroquia { get; set; }
}