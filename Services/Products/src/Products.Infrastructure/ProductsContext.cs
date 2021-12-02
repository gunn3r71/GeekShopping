using Microsoft.EntityFrameworkCore;

public class ProductsContext : DbContext
{
    public ProductsContext()
    {
    }

    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
    {
    }
}