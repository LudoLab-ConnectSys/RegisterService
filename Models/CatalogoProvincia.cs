using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("CatalogoProvincia")]
public class CatalogoProvincia
{
    [Key] [Column("ProvinciaId")] public int ProvinciaId { get; set; }

    [Required] [Column("NombreProvincia")] public string NombreProvincia { get; set; }

    [Column("PaisId")] public int PaisId { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("PaisId")] [JsonIgnore] public CatalogoPais? Pais { get; set; }

    [JsonIgnore] public ICollection<CatalogoCanton>? Cantones { get; set; }
}