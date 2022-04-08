using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }       
    }
}
