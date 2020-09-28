using System.Collections.Generic;

namespace ConsoleApp
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
    }
}