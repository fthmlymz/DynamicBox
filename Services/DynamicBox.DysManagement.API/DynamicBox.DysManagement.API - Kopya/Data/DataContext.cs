using DynamicBox.DysManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.DysManagement.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
     
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentInstance> DocumentInstances { get; set; }
    }
}
