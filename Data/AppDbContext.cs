using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Adicione seus DbSets aqui, por exemplo:
        // public DbSet<SeuModelo> SeusModelos { get; set; }
    }
}
