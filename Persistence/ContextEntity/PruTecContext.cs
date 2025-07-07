using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence.ContextEntity
{
    public class PruTecContext(DbContextOptions<PruTecContext> options) : DbContext(options)
    {
        public virtual DbSet<Cliente> cliente { get; set; } 
        public virtual DbSet<Motivo> motivo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
