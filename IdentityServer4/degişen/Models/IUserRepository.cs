using System.Collections.Generic;

namespace DynamicBox.IdentityServer.Models
{
    public interface IUserRepository
    {
        User GetEmployee(int Id);
        IEnumerable<User> GetAllEmployee();
        User Add(User employee);
        User Update(User employeeChanges);
        User Delete(int id);
    }
}
