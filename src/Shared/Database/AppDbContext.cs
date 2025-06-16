using MediatrVsBrighter.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatrVsBrighter.Api.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Zastosuj wszystkie konfiguracje implementującego po IEntityTypeConfiguration z aktualnego projektu
            // W tym projekcie konfiguracje są w folderze Database/Configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
