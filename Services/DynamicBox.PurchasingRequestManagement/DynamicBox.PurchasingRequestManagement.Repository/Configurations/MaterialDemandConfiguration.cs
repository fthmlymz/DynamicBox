
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
            builder.Property(x => x.Description).IsRequired().HasMaxLength(250);
            builder.Property(x => x.CreatedUserId).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreatedUserName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CompanyId).IsRequired().HasMaxLength(100);
            builder.Property(x => x.BusinessCode).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.Company).WithMany(x => x.MaterialDemands).HasForeignKey(x => x.CompanyId);//.OnDelete(DeleteBehavior.Cascade);
        }
    }
}
