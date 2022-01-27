
using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicBox.PurchasingRequestManagement.Repository.Configurations
{
    public class MaterialDemandConfiguration : IEntityTypeConfiguration<MaterialDemand>
    {
        public void Configure(EntityTypeBuilder<MaterialDemand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Company).WithMany(x => x.MaterialDemands).HasForeignKey(x => x.CompanyId);
        }
    }
}
