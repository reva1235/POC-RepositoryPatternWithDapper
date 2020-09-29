using Domain;
using System.Collections.Generic;

namespace ConsoleApp
{
    public interface IEmployeeService
    {
        IEnumerable<User> GetAll();
    }
}