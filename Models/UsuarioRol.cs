using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RegisterService.Models;

[Table("UsuarioRol")]
public class UsuarioRol
{
    [Column("UsuarioId")] public int UsuarioId { get; set; }

    [Column("RolId")] public int RolId { get; set; }

    [Column("FechaAsignacion")] public DateTime FechaAsignacion { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("UsuarioId")] [JsonIgnore] public Usuario? Usuario { get; set; }

    [ForeignKey("RolId")] [JsonIgnore] public Rol? Rol { get; set; }
}