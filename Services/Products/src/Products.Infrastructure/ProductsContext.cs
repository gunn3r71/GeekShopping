using GeekShopping.Services.Products.Domain.Entities;
using GeekShopping.Services.Products.Infrastructure.EntityTypesConfigurations;
using Microsoft.EntityFrameworkCore;

public class ProductsContext : DbContext
{
    public ProductsContext()
    {
    }

    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Using reflection to get entity types configurations
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductEntityConfiguration).Assembly);
    }
}