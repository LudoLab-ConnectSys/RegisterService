using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("CatalogoPais")]
public class CatalogoPais
{
    [Key] [Column("PaisId")] public int PaisId { get; set; }

    [Required] [Column("NombrePais")] public string NombrePais { get; set; }

    [Required] [Column("Nacionalidad")] public string Nacionalidad { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [JsonIgnore] public ICollection<CatalogoProvincia>? Provincias { get; set; }
}