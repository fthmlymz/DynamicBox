using DynamicBox.PurchasingRequestManagement.Core.Models.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicBox.PurchasingRequestManagement.Repository.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Price).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.StockNo).IsRequired();
            builder.Property(x => x.CompanyId).IsRequired();
            builder.HasOne(x => x.Company).WithMany(x => x.Products).HasForeignKey(x => x.CompanyId); //.OnDelete(DeleteBehavior.NoAction);
        }
    }
}
