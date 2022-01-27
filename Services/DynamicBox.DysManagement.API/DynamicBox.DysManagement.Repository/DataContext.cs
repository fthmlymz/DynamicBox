using DynamicBox.DysManagement.Core.Models.Company;
using DynamicBox.DysManagement.Core.Models.Document;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.DysManagement.Repository
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<CompanyInformation> CompanyInformations { get; set; }
        public DbSet<SubCompanie> SubCompanies { get; set; }

        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentInstance> DocumentInstances { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //    //Tek tek almak için
        //    //modelBuilder.ApplyConfiguration(new DocumentConfiguration());

        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
