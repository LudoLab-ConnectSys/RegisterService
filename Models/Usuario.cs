﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("Usuario")]
public class Usuario
{
    [Key] [Column("id_usuario")] public int IdUsuario { get; set; }

    [Column("cedula_usuario")] public string? CedulaUsuario { get; set; }

    [Column("contrasena")] public string? Contrasena { get; set; }

    [Required] [Column("nombre_usuario")] public string NombreUsuario { get; set; }

    [Required]
    [Column("apellidos_usuario")]
    public string ApellidosUsuario { get; set; }

    [Column("edad_usuario")] public int? EdadUsuario { get; set; }

    [Column("correo_usuario")] public string? CorreoUsuario { get; set; }

    [Column("celular_usuario")] public string? CelularUsuario { get; set; }

    [Column("telefono_usuario")] public string? TelefonoUsuario { get; set; }

    [Column("FechaNacimiento")] public DateTime FechaNacimiento { get; set; }

    [Column("definicionEtnica")] public int? DefinicionEtnica { get; set; }

    [Column("genero")] public string? Genero { get; set; }

    [Column("tieneDiscapacidad")] public bool? TieneDiscapacidad { get; set; }

    [Column("numeroCarnetConadis")] public string? NumeroCarnetConadis { get; set; }

    [Column("FechaCreacion")] public DateTime FechaCreacion { get; set; }

    [Column("UltimoLogin")] public DateTime? UltimoLogin { get; set; }

    [Column("estadoActivo")] public bool EstadoActivo { get; set; }

    [ForeignKey("DefinicionEtnica")] public Etnia Etnia { get; set; }

    [JsonIgnore] public ICollection<Direccion>? Direcciones { get; set; }

    [JsonIgnore] public ICollection<DatoEPN>? DatosEPN { get; set; }

    [JsonIgnore] public ICollection<UsuarioRol>? UsuarioRoles { get; set; }
}