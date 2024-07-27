using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("CatalogoProvincia")]
public class ProvinceCatalog
{
    [Key] [Column("ProvinciaId")] public int ProvinciaId { get; set; }

    [MaxLength(255)]
    [Column("NombreProvincia")]
    public string NombreProvincia { get; set; }

    [Required] [Column("PaisId")] public int PaisId { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("PaisId")] public CountryCatalog? Pais { get; set; }
}