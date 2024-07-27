using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("CatalogoPais")]
public class CountryCatalog
{
    [Key] [Column("PaisId")] public int PaisId { get; set; }

    [MaxLength(255)]
    [Column("NombrePais")]
    public string NombrePais { get; set; }

    [MaxLength(255)]
    [Column("Nacionalidad")]
    public string Nacionalidad { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }
}