using DynamicBox.DysManagement.Core.Models.Document;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBox.DysManagement.Repository.Configurations
{
    public class DocumentInstanceConfiguration : IEntityTypeConfiguration<DocumentInstance>
    {
        public void Configure(EntityTypeBuilder<DocumentInstance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ContextType).IsRequired();
        }
    }
}
