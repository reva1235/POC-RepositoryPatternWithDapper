using System.Collections.Generic;

namespace ConsoleApp
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
    }
}