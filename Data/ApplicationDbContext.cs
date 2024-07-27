using Microsoft.EntityFrameworkCore;
using RegisterService.Models;

namespace RegisterService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Usuario { get; set; }
    }
}