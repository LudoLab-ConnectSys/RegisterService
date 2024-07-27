using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("Etnia")]
public class Ethnicity
{
    [Key] [Column("id")] public int Id { get; set; }

    [MaxLength(255)]
    [Column("nombreEtnia")]
    public string NombreEtnia { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }
}