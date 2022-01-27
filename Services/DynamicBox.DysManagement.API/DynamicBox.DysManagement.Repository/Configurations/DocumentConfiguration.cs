using DynamicBox.DysManagement.Core.Models.Document;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicBox.DysManagement.Repository.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DocumentName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DocumentNumber).HasMaxLength(100);
            builder.Property(x => x.DocumentCode).HasDefaultValueSql("NEWID()");
            builder.ToTable("Documents");

            //Bir döküman sadece bir kuruma bağlı olabilir, bir kurumunda birden fazla dökümanı olabilir
            //builder.HasOne(x => x.SubCompanie).WithMany(x => x.d).HasForeignKey(x => x.Id);
        }
    }
}
