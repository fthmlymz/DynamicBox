using Microsoft.EntityFrameworkCore;

namespace DynamicBox.Autoflow.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
