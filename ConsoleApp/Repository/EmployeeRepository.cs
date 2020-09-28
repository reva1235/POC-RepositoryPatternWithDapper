using System.Collections.Generic;

namespace ConsoleApp
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return new[] 
            {
                new Employee{ },
                new Employee{ },
            };
        }
    }
}