using GeekShopping.Services.Products.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeekShopping.Services.Products.Infrastructure.EntityTypesConfigurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnType("CHAR(36)")
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(x => x.ImageUrl)
                .HasMaxLength(300);

            builder
                .OwnsOne(x => x.Price, p =>
                {
                    p.Property(x => x.Value)
                        .HasPrecision(6, 2)
                        .HasDefaultValue(0.00)
                        .IsRequired();
                });

            builder
                .HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .HasPrincipalKey(x => x.Id)
                .IsRequired();
        }
    }
}