using Domain;
using System.Collections.Generic;

namespace Services.Core
{
    public interface IEmployeeService
    {
        IEnumerable<User> GetAll();
        void Hire(User user);
    }
}