using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models;

[Table("Rol")]
public class Role
{
    [Key] [Column("RolId")] public int RolId { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("NombreRol")]
    public string NombreRol { get; set; }

    [Required] [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    public virtual ICollection<UserRole>? UsuarioRoles { get; set; }
}