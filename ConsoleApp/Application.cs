using Domain;

namespace ConsoleApp
{
    public class Application
    {
        
        public Application(IPrintService<User> printService, IEmployeeService employeeService) 
        {
            PrintService = printService;
            EmployeeService = employeeService;
        }

        public IPrintService<User> PrintService { get; }
        public IEmployeeService EmployeeService { get; }

        public void Run()
        {
            var employee = EmployeeService.GetAll();
            PrintService.Print(employee);
        }
    }
}