using Microsoft.EntityFrameworkCore;
using Pag_Pix_Core.Domain.Entities;

namespace Pag_Pix_Core.Repository.Adaptadores.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pagador> Pagador{ get; set; }
        public DbSet<Pagamento> Pagamento{ get; set; }
        public DbSet<Recebedor> Recebedor{ get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
    
}
