
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
            builder.Property(x => x.LdapId).IsRequired().HasMaxLength(100);
            builder.Property(x => x.sAMAAccountName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ObjectGuid).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PrefferedUserName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Manager).IsRequired().HasMaxLength(100); 
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            builder.Property(x => x.WorkflowId).IsRequired().HasMaxLength(250);
            builder.Property(x => x.WorkflowDefinitionId).IsRequired().HasMaxLength(250);
            builder.Property(x => x.WorkflowName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.WorkflowVersion).HasColumnType("bigint");
            builder.Property(x => x.CompanyId).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(150);
            builder.HasOne(x => x.Company).WithMany(x => x.MaterialDemands).HasForeignKey(x => x.CompanyId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
