using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class TransferenciaContext : DbContext
    {
        public TransferenciaContext(DbContextOptions<TransferenciaContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Transferencia> Transferencias { get; set; }
    }
}

