using DynamicBox.IdentityServer.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicBox.IdentityServer.Data
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(DbContextOptions opts) : base(opts)
        {

        }

        public DbSet<CustomUser> CustomUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomUser>().HasData(new CustomUser()
            {
                Id = 1,
                Email = "fthmlymz@hotmail.com",
                Password = "Aa123456789*",
                BusinessCode = "1",
                City = "Konya",
                UserName = "fthmlymz@hotmail.com"
            });
            base.OnModelCreating(builder);
        }
    }
}
