using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterService.Models
{
    [Table("CatalogoPais")]
    public class Nacionalidad
    {
        [Column("PaisId")] public int PaisId { get; set; }

        [Column("Nacionalidad")] public string NombreNacionalidad { get; set; }
    }
}