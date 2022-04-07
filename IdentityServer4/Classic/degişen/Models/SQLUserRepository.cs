using DynamicBox.IdentityServer.Data;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DynamicBox.IdentityServer.Models
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<SQLUserRepository> logger;

        public SQLUserRepository(ApplicationDbContext context,
                                    ILogger<SQLUserRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public User Add(User employee)
        {
            context.Users.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public User Delete(int id)
        {
            User employee = context.Users.Find(id);
            if (employee != null)
            {
                context.Users.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<User> GetAllEmployee()
        {
            return context.Users;
        }

        public User GetEmployee(int Id)
        {
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");

            return context.Users.Find(Id);
        }

        public User Update(User employeeChanges)
        {
            var employee = context.Users.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
