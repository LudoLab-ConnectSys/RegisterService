using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("UsuarioRol")]
public class UserRole
{
    [Key]
    [ForeignKey("Usuario")]
    [Column("UsuarioId")]
    public int UsuarioId { get; set; }

    [Key]
    [ForeignKey("Rol")]
    [Column("RolId")]
    public int RolId { get; set; }

    [Column("FechaAsignacion")] public DateTime FechaAsignacion { get; set; } = DateTime.Now;

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    public virtual User? Usuario { get; set; }
    public virtual Role? Rol { get; set; }
}