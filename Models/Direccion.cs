using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RegisterService.Models;

[Table("Direccion")]
public class Direccion
{
    [Key] [Column("DireccionId")] public int DireccionId { get; set; }

    [Column("CallePrincipal")] public string? CallePrincipal { get; set; }

    [Column("Numeracion")] public string? Numeracion { get; set; }

    [Column("CalleSecundaria")] public string? CalleSecundaria { get; set; }

    [Column("Sector")] public string? Sector { get; set; }

    [Column("Referencia")] public string? Referencia { get; set; }

    [Column("CodigoPostal")] public string? CodigoPostal { get; set; }

    [Column("UsuarioId")] public int UsuarioId { get; set; }

    [Column("ParroquiaId")] public int ParroquiaId { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("UsuarioId")] [JsonIgnore] public Usuario? Usuario { get; set; }

    [ForeignKey("ParroquiaId")] public CatalogoParroquia? Parroquia { get; set; }
}