using DynamicBox.PurchasingRequestManagement.Core.Models.MaterialDemand;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicBox.PurchasingRequestManagement.Repository.Configurations
{
    public class MaterialDemandHistoryConfiguration : IEntityTypeConfiguration<MaterialDemandHistory>
    {
        public void Configure(EntityTypeBuilder<MaterialDemandHistory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DefinationId).HasPrecision(450);
            builder.Property(x => x.TenantId).HasPrecision(450);
            builder.Property(x => x.Version);
            builder.Property(x => x.WorkflowStatus);
            builder.Property(x => x.CorrelationId).HasPrecision(450);
            builder.Property(x => x.ContextType).HasPrecision(450);
            builder.Property(x => x.ContextId).HasPrecision(450);
            builder.Property(x => x.Name).HasPrecision(450);
            builder.Property(x => x.CreatedAt).HasColumnType("datetime2").HasPrecision(0);
            builder.Property(x => x.LastExecutedAt).HasColumnType("datetime2").HasPrecision(0);
            builder.Property(x => x.FinishedAt).HasColumnType("datetime2").HasPrecision(0);
            builder.Property(x => x.CancelledAt).HasColumnType("datetime2").HasPrecision(0);
            builder.Property(x => x.FaultedAt).HasColumnType("datetime2").HasPrecision(0);
            builder.Property(x => x.Data).HasPrecision(450);
            builder.Property(x => x.LastExecutedActivityId);
            builder.Property(x => x.DefinationVersionId);

            builder.HasOne(x => x.MaterialDemand).WithMany(x => x.MaterialDemandHistories).HasForeignKey(x => x.MaterialDemandId);
        }
    }
}
