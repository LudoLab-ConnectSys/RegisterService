using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("CatalogoParroquia")]
public class CatalogoParroquia
{
    [Key] [Column("ParroquiaId")] public int ParroquiaId { get; set; }

    [Required] [Column("NombreParroquia")] public string NombreParroquia { get; set; }

    [Column("CantonId")] public int CantonId { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("CantonId")] [JsonIgnore] public CatalogoCanton? Canton { get; set; }
}