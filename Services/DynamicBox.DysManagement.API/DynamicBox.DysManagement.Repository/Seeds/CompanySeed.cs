using DynamicBox.DysManagement.Core.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicBox.DysManagement.Repository.Seeds
{
    public class CompanySeed : IEntityTypeConfiguration<CompanyInformation>
    {
        public void Configure(EntityTypeBuilder<CompanyInformation> builder)
        {
            builder.HasData(new CompanyInformation
            {
                Id = 1,
                BusinessCode = "1000",
                CompanyName = " Enerya Enerji A.Ş.",
                CompanyDescription = "Enerya enerji informations",
                CompanyPhone = "444 8 429",
                CompanyAddress = "İçerenköy Mah. Yeşilvadi Sok. No:3/4 Ataşehir / İSTANBUL",
                CompanyCity = "İstanbul",
                CompanyRegion = "Türkiye",
                CreatedDate = DateTime.Now,
                UpdatedDate = null,
            });
        }
    }
}
