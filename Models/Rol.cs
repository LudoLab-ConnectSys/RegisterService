using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("Rol")]
public class Rol
{
    [Key] [Column("RolId")] public int RolId { get; set; }

    [Required] [Column("NombreRol")] public string NombreRol { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [JsonIgnore] public ICollection<UsuarioRol>? UsuarioRoles { get; set; }
}