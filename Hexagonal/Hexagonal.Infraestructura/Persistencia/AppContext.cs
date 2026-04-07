using Hexagonal.Infraestructura.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Hexagonal.Infraestructura.Persistencia
{
    public class AppContext : DbContext
    {
        public AppContext() { }

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<ProductoEntidad> Producto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "name=DockerConnection",
                    // ESTA ES LA PARTE IMPORTANTE:
                    x => x.MigrationsAssembly("Hexagonal.WebAPI.Hexagonal.API")
                );
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductoEntidad>()
                            .Property(p => p.Precio)
                            .HasPrecision(18, 2);
        }
    }
}
