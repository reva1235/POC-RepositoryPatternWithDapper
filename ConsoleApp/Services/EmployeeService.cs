using System.Collections.Generic;

namespace ConsoleApp
{
    internal class EmployeeService : IEmployeeService
    {
        public EmployeeService(IPrintService<Employee> printService, IEmployeeRepository employeeRepository)
        {
            PrintService = printService;
            EmployeeRepository = employeeRepository;
        }

        public IPrintService<Employee> PrintService { get; }
        public IEmployeeRepository EmployeeRepository { get; }

        public IEnumerable<Employee> GetAll()
        {
            return EmployeeRepository.GetAll();
        }
    }
}