using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("CatalogoCanton")]
public class CantonCatalog
{
    [Key] [Column("CantonId")] public int CantonId { get; set; }

    [MaxLength(255)]
    [Column("NombreCanton")]
    public string NombreCanton { get; set; }

    [Required] [Column("ProvinciaId")] public int ProvinciaId { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("ProvinciaId")] public ProvinceCatalog? Provincia { get; set; }
}