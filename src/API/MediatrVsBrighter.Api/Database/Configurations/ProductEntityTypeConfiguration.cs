using MediatrVsBrighter.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatrVsBrighter.Api.Database.Configurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Konfiguracja klucza głównego
            builder.HasKey(p => p.Id);

            // Konfiguracja właściwości Name
            builder.Property(p => p.Name)
                   .IsRequired()      // Odpowiednik [Required]
                   .HasMaxLength(100); // Odpowiednik [MaxLength(100)]

            // Konfiguracja właściwości Price (decimal domyślnie jest nullable,
            // ale w .NET 8 jest już domyślnie non-nullable w Property)
            builder.Property(p => p.Price)
                   .IsRequired(); // Cena powinna być wymagana

            // Konfiguracja właściwości Description
            builder.Property(p => p.Description)
                   .HasMaxLength(500) // Odpowiednik [MaxLength(500)]
                   .IsRequired(false); // Opcjonalne, ponieważ jest to string?

            Seed(builder); // Wywołanie metody do wstępnego zapełnienia danymi
        }

        private static void Seed(EntityTypeBuilder<Product> builder)
        {
            // Metoda do wstępnego zapełnienia danymi
            builder.HasData(
                new Product { Id = Guid.NewGuid(), Name = "Laptop", Price = 1200.00M, Description = "Powerful laptop for work and gaming" },
                new Product { Id = Guid.NewGuid(), Name = "Mouse", Price = 25.00M, Description = "Wireless ergonomic mouse" },
                new Product { Id = Guid.NewGuid(), Name = "Keyboard", Price = 75.00M, Description = "Mechanical keyboard with RGB lighting" }
            );
        }
    }
}
