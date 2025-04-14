using prjICETASK4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace prjICETASK4.Data.Config
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(a => a.ProductID);

            builder.Property(a => a.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.ProductPrice)
                .IsRequired()
                ;


            builder.HasData(
                new Products
                {
                    ProductID = 1,
                    ProductName = "Apples",
                    ProductPrice = 18,
               
                },
                new Products
                {
                    ProductID = 2,
                    ProductName = "Bananas",
                    ProductPrice = 12,
            
                },
                new Products
                {
                    ProductID = 3,
                    ProductName = "Cherries",
                    ProductPrice = 25,

                }
            );
        }
    }
}
