using DynamicBox.PurchasingManagement.Core.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicBox.PurchasingRequestManagement.Repository.Configurations
{
    public class CompanyConfigruation : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.BusinessCode).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(100);
        }
    }
}
