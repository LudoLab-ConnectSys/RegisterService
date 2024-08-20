using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RegisterService.Models;

[Table("CatalogoCanton")]
public class CatalogoCanton
{
    [Key] [Column("CantonId")] public int CantonId { get; set; }

    [Required] [Column("NombreCanton")] public string NombreCanton { get; set; }

    [Column("ProvinciaId")] public int ProvinciaId { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("ProvinciaId")]
    [JsonIgnore]
    public CatalogoProvincia? Provincia { get; set; }
}