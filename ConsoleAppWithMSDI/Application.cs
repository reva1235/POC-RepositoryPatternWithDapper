using Domain;
using Services.Core;

namespace ConsoleAppWithMSDI
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
            EmployeeService.Hire(new User
            {
                USER_NAME = "Batman",
                PASSWORD = "Bruce",
                USER_GROUP = "Heros",
                BLOB = new byte[] {0xff, 0x01}
            });
            
            PrintService.Print(EmployeeService.GetAll());
        }
    }
}