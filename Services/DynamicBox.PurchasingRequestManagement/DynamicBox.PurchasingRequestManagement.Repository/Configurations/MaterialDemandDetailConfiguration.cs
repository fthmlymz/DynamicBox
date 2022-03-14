using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicBox.PurchasingRequestManagement.Repository.Configurations
{
    public class MaterialDemandDetailConfiguration : IEntityTypeConfiguration<MaterialDemandDetail>
    {
        public void Configure(EntityTypeBuilder<MaterialDemandDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.TotalDemand).IsRequired();
            builder.Property(x => x.StockName).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.MaterialDemands).WithMany(x => x.MaterialDemandDetails).HasForeignKey(x => x.MaterialDemandId);//.OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Products).WithMany(x => x.MaterialDemandDetails).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
