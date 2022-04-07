using System.Collections.Generic;
using System.Linq;

namespace DynamicBox.IdentityServer.Models
{
    public class MockEmployeeRepository : IUserRepository
    {
        private List<User> _userList;

        public MockEmployeeRepository()
        {
            _userList = new List<User>()
            {
                new User() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@pragimtech.com" },
                new User() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@pragimtech.com" },
                new User() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@pragimtech.com" },
            };
        }
        public User Add(User employee)
        {
            employee.Id = _userList.Max(e => e.Id) + 1;
            _userList.Add(employee);
            return employee;
        }

        public User Delete(int id)
        {
            User employee = _userList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _userList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<User> GetAllEmployee()
        {
            return _userList;
        }

        public User GetEmployee(int Id)
        {
            return _userList.FirstOrDefault(e => e.Id == Id);
        }

        public User Update(User employeeChanges)
        {
            User employee = _userList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
