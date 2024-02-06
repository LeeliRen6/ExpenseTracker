using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class AplicacaoDbContext:DbContext
    {
        public AplicacaoDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
