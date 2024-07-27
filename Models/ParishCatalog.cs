using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("CatalogoParroquia")]
public class ParishCatalog
{
    [Key] [Column("ParroquiaId")] public int ParroquiaId { get; set; }

    [MaxLength(255)]
    [Column("NombreParroquia")]
    public string NombreParroquia { get; set; }

    [Required] [Column("CantonId")] public int CantonId { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("CantonId")] public CantonCatalog? Canton { get; set; }
}