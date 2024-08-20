using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RegisterService.Models;

[Table("Etnia")]
public class Etnia
{
    [Key] [Column("id")] public int Id { get; set; }

    [Required] [Column("nombreEtnia")] public string NombreEtnia { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [JsonIgnore] public ICollection<Usuario>? Usuarios { get; set; }
}