using Microsoft.EntityFrameworkCore;
using RegisterService.Models;

namespace RegisterService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CatalogoCanton> CatalogoCantones { get; set; }
        public DbSet<CatalogoPais> CatalogoPaises { get; set; }
        public DbSet<CatalogoParroquia> CatalogoParroquias { get; set; }
        public DbSet<CatalogoProvincia> CatalogoProvincias { get; set; }
        public DbSet<DatoEPN> DatosEPN { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Etnia> Etnias { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioRol> UsuarioRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de relaciones de clave primaria compuesta en UsuarioRol
            modelBuilder.Entity<UsuarioRol>()
                .HasKey(ur => new { ur.UsuarioId, ur.RolId });

            // Configuración de relaciones y restricciones
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Direcciones)
                .WithOne(d => d.Usuario)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.DatosEPN)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.UsuarioRoles)
                .WithOne(ur => ur.Usuario)
                .HasForeignKey(ur => ur.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Rol>()
                .HasMany(r => r.UsuarioRoles)
                .WithOne(ur => ur.Rol)
                .HasForeignKey(ur => ur.RolId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}